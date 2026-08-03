using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Runtime.InteropServices;

namespace umi.device.business.GPS
{    
    /// <summary>
    /// Processa as informações do GPS.
    /// </summary>
    public class Gps : IDisposable
    {
        #region Constantes

        /// <summary>
        /// Porta Serial default (COM4).
        /// </summary>
        protected const string PORT_COM4 = "COM4";

        /// <summary>
        /// Velocidade (taxa) default (38400).
        /// </summary>
        protected const int BAUDRATE_38400 = 38400;

        #endregion

        #region Atributos Nmea, Porta Serial e Thread
        
        private NmeaInterpreter nmea = null;
        private SerialPort portaSerial = null;
        private Thread threadGps = null;
        private bool boolProcessarGpsThread = false;

        private string strNomePorta = string.Empty;
        private int intBaudRate = 0;        

        private string[] strPortas = { "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9" };
        private int[] intBaudRates = { 2400, 4800, 9600, 14400, 19200, 38400, 57600 };        
        
        #endregion

        #region Atributos do GPS

        private GpsPosicao posLatitude = new GpsPosicao();
        private GpsPosicao posLongitude = new GpsPosicao();
        private double dblVelocidade = 0;
        private bool boolVelocidadeLimiteAlcancada = false;
        private List<GpsSatelite> satSatelites = new List<GpsSatelite>();
        private double dblOrientacao = 0;
        private bool boolFix = false;
        private DateTime dtDataHora;
        private double dblDiluicaoHorizontal = 0;
        private double dblAltitudeNivelMar = 0;
        private double dblAlturaWGS84 = 0;

        #endregion

        #region Propriedades

        /// <summary>
        /// Indica se a porta serial está aberta
        /// </summary>
        public bool Aberto
        {
            get { return (portaSerial != null) ? portaSerial.IsOpen : false; }
        }

        /// <summary>
        /// Nome da Porta COM aberta
        /// </summary>
        public string NomePorta
        {
            get { return strNomePorta; }
        }

        /// <summary>
        /// Taxa (velocidade) de transmissão (por segundo)
        /// </summary>
        public int BaudRate
        {
            get { return intBaudRate; }
        }

        /// <summary>
        /// Latitude
        /// </summary>
        public GpsPosicao Latitude
        {
            get { return this.posLatitude; }
        }

        /// <summary>
        /// Longitude
        /// </summary>
        public GpsPosicao Longitude
        {
            get { return this.posLongitude; }
        }

        public double Velocidade
        {
            get { return this.dblVelocidade; }
        }

        public bool VelocidadeLimiteAlcancada
        {
            get { return this.boolVelocidadeLimiteAlcancada; }
        }

        /// <summary>
        /// Lista de satélites
        /// </summary>
        public List<GpsSatelite> Satelites
        {
            get { return this.satSatelites; }
        }

        public double Orientacao
        {
            get { return this.dblOrientacao; }
        }

        public bool Fix
        {
            get { return this.boolFix; }
        }

        public DateTime DataHora
        {
            get { return this.dtDataHora; }
        }

        public int NumeroSatelitesVista
        {
            get { return (this.satSatelites != null) ? this.satSatelites.Count : 0; }
        }

        /// <summary>
        /// Diluição horizontal da posição
        /// </summary>
        public double DiluicaoHorizontal
        {
            get { return this.dblDiluicaoHorizontal; }
        }

        /// <summary>
        /// Altitude, em metros, acima do nível do mar.
        /// </summary>
        public double AltitudeNivelMar
        {
            get { return this.dblAltitudeNivelMar; }
        }

        /// <summary>
        /// Altura do geóide sobre o elipsóide WGS84.
        /// </summary>
        public double AlturaWGS84
        {
            get { return this.dblAlturaWGS84; }
        }

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="nomePorta">Nome da Porta Serial (COM4 por exemplo)</param>
        /// <param name="baudRate">Taxa (velocidade) de transmissão (por segundo)</param>
        public Gps(string nomePorta, int baudRate)
        {
            strNomePorta = (Array.IndexOf(strPortas, nomePorta) > 0) ? nomePorta : PORT_COM4;
            intBaudRate = (Array.IndexOf(intBaudRates, baudRate) > 0) ? baudRate : BAUDRATE_38400;

            nmea = new NmeaInterpreter();
            nmea.OnPosicaoRecebida += new NmeaInterpreter.PosicaoEventHandler(nmea_OnPosicaoRecebida);
            nmea.OnDataHoraMudada += new NmeaInterpreter.DataHoraEventHandler(nmea_OnDataHoraMudada);
            nmea.OnFixObtido += new NmeaInterpreter.FixObtidoEventHandler(nmea_OnFixObtido);
            nmea.OnFixPerdido += new NmeaInterpreter.FixPerdidoEventHandler(nmea_OnFixPerdido);
            nmea.OnOrientacaoRecebida += new NmeaInterpreter.OrientacaoEventHandler(nmea_OnOrientacaoRecebida);
            nmea.OnSatelitesRecebidos += new NmeaInterpreter.SatelitesRecebidosEventHandler(nmea_OnSateliteRecebido);
            nmea.OnVelocidadeLimiteAlcancada += new NmeaInterpreter.VelocidadeLimiteAlcancadaEventHandler(nmea_OnVelocidadeLimiteAlcancada);
            nmea.OnVelocidadeRecebida += new NmeaInterpreter.VelocidadeEventHandler(nmea_OnVelocidadeRecebida);
            nmea.OnFixData += new NmeaInterpreter.FixDataEventHandler(nmea_OnFixData);
        }        

        /// <summary>
        /// Construtor 
        /// </summary>
        /// <param name="intBaudRate">velocidade (taxa) de transmissão (símbolo/segundo)</param>
        /// <remarks>Tenta abrir várias portas COM (da COM1 até a COM9); 
        /// Utiliza a velocidade (taxa) de transmissão de 38400</remarks>
        public Gps()
        {
            nmea = new NmeaInterpreter();
            nmea.OnPosicaoRecebida += new NmeaInterpreter.PosicaoEventHandler(nmea_OnPosicaoRecebida);
            nmea.OnDataHoraMudada += new NmeaInterpreter.DataHoraEventHandler(nmea_OnDataHoraMudada);
            nmea.OnFixObtido += new NmeaInterpreter.FixObtidoEventHandler(nmea_OnFixObtido);
            nmea.OnFixPerdido += new NmeaInterpreter.FixPerdidoEventHandler(nmea_OnFixPerdido);
            nmea.OnOrientacaoRecebida += new NmeaInterpreter.OrientacaoEventHandler(nmea_OnOrientacaoRecebida);
            nmea.OnSatelitesRecebidos += new NmeaInterpreter.SatelitesRecebidosEventHandler(nmea_OnSateliteRecebido);
            nmea.OnVelocidadeLimiteAlcancada += new NmeaInterpreter.VelocidadeLimiteAlcancadaEventHandler(nmea_OnVelocidadeLimiteAlcancada);
            nmea.OnVelocidadeRecebida += new NmeaInterpreter.VelocidadeEventHandler(nmea_OnVelocidadeRecebida);
            nmea.OnFixData += new NmeaInterpreter.FixDataEventHandler(nmea_OnFixData);
        }

        #endregion        

        #region IDisposable Members

        void IDisposable.Dispose()
        {
            if (portaSerial.IsOpen) portaSerial.Close();
        }

        #endregion        

        #region Event delegates and handlers

        public delegate void GpsEventHandler();
        /// <summary>
        /// Ocorre sempre que as informações do GPS forem atualizadas.
        /// </summary>
        public event GpsEventHandler OnUpdated;               
                
        #endregion

        #region Métodos Abrir e Fechar

        /// <summary>
        /// Abre uma porta serial (COM) e inicia o processamento GPS.
        /// </summary>
        /// <remarks>Se já estiver aberto, nada acontece.</remarks>
        public void Abrir()
        {
            if (!Aberto)
            {                
                if (strNomePorta.Length > 0)
                {
                    // Seta porta COM
                    portaSerial = new SerialPort(strNomePorta, intBaudRate);                    
                    portaSerial.ReadBufferSize = 1;
                    try { portaSerial.Open(); } //tenta abrir a porta
                    catch (Exception) { return; }                    
                }
                else
                {
                    int i = 0;
                    // Seta porta COM
                    portaSerial = new SerialPort(strPortas[i], intBaudRate);
                    portaSerial.ReadBufferSize = 1;
                    try { portaSerial.Open(); } //tenta abrir a porta
                    catch (Exception) { /*faz nada*/ }
                    while (i < strPortas.Length && !portaSerial.IsOpen)
                    {
                        portaSerial = new SerialPort(strPortas[i], intBaudRate);
                        portaSerial.ReadBufferSize = 1;
                        try{ portaSerial.Open(); } //tenta abrir a porta
                        catch (Exception){ /*faz nada*/ }
                        strNomePorta = strPortas[i]; //seta a porta que abriu
                        i++;
                    }
                }
                if (Aberto) //Se conseguiu abrir a porta serial, processa o thread:
                {
                    boolProcessarGpsThread = true;
                    threadGps = new Thread(new ThreadStart(Processar));
                    threadGps.IsBackground = true;
                    threadGps.Start();
                }
            }
        }        

        /// <summary>
        /// Pára o processamento do GPS e fecha a porta serial
        /// </summary>
        public void Fechar()
        {
            boolProcessarGpsThread = false;
            if (portaSerial.IsOpen) portaSerial.Close();
            if (threadGps != null) threadGps.Abort();
        }

        #endregion

        #region Método Processar

        /// <summary>
        /// Processa o GPS
        /// </summary>
        protected void Processar()
        {
            //declara um buffer:
            byte[] buffer = new byte[1];
            string strSetenca = string.Empty;
            //Enquanto o processamento estiver liberado e a porta estiver aberta:
            //lerá o Stream da porta serial:
            while (boolProcessarGpsThread && Aberto) //while(Aberto)            
            {
                try
                {
                    // verifica se há bytes a serem lidos:
                    if (portaSerial.BytesToRead > 0)
                    {
                        portaSerial.Read(buffer, 0, 1); //lê um byte e preenche o buffer
                        if (buffer[0] != '\r') //verifica se o fim da linha foi encontrado
                        {
                            strSetenca += Encoding.ASCII.GetString(buffer, 0, buffer.Length);
                        }
                        else
                        {
                            nmea.parse(strSetenca.Replace("\n", "")); //Chama o parser, mas elimina o caractere feed
                            strSetenca = string.Empty;
                        }
                    }
                }
                catch (Exception)
                {
                    /*faz nada*/ 
                    //throw;
                    return;
                }
            }
        }

        #endregion        

        #region Implementação dos Eventos

        /// <summary>
        /// Implementa o Evento de Posição recebida
        /// </summary>
        /// <param name="latitude">objeto latitude</param>
        /// <param name="longitude">objeto longitude</param>
        void nmea_OnPosicaoRecebida(GpsPosicao latitude, GpsPosicao longitude)
        {
            this.posLatitude = latitude;
            this.posLongitude = longitude;
            OnUpdated();
        }

        void nmea_OnVelocidadeRecebida(double velocidade)
        {
            this.dblVelocidade = velocidade;
            OnUpdated();
        }

        void nmea_OnVelocidadeLimiteAlcancada()
        {
            this.boolVelocidadeLimiteAlcancada = true;
            OnUpdated();
        }

        void nmea_OnSateliteRecebido(List<GpsSatelite> satelites)
        {
            this.satSatelites = new List<GpsSatelite>(satelites);
            OnUpdated();
        }

        void nmea_OnOrientacaoRecebida(double orientacao)
        {
            this.dblOrientacao = orientacao;
            OnUpdated();
        }

        void nmea_OnFixPerdido()
        {
            this.boolFix = false;
            OnUpdated();
        }

        void nmea_OnFixObtido()
        {
            this.boolFix = true;
            OnUpdated();
        }

        void nmea_OnDataHoraMudada(DateTime dataHora)
        {
            this.dtDataHora = dataHora;
            OnUpdated();
        }

        void nmea_OnFixData(double diluicaoHorizontal, double altitudeNivelMar, double alturaWGS84)
        {
            this.dblDiluicaoHorizontal = diluicaoHorizontal;
            this.dblAltitudeNivelMar = altitudeNivelMar;
            this.dblAlturaWGS84 = alturaWGS84;
            OnUpdated();
        }

        #endregion
    }

    /// <summary>
    /// Descreve as informações de um satélite
    /// </summary>
    public class GpsSatelite
    {
        #region Atributos

        private int intPseudoCodigoRandomico;
        private int intAzimute;
        private int intElevacao;
        private int intNivelSinal;

        #endregion

        #region Propriedades

        /// <summary>
        /// Identificador do Satélite; PRN (Pseudo Random Number).
        /// </summary>
        public int PseudoCodigoRandomico
        {
            get { return intPseudoCodigoRandomico; }
        }

        /// <summary>
        /// Azimute (em graus).
        /// </summary>
        public int Azimute
        {
            get { return intAzimute; }
        }

        /// <summary>
        /// Elevação (em graus).
        /// </summary>
        public int Elevacao
        {
            get { return intElevacao; }
        }

        /// <summary>
        /// Nível do sinal; SNR (Signal to Noise Ratio); signal strength.
        /// </summary>
        public int NivelSinal
        {
            get { return intNivelSinal; }
        }

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="pseudoCodigoRandomico">Identificador do Satélite; PRN (Pseudo Random Number).</param>
        /// <param name="azimute">Azimute (em graus).</param>
        /// <param name="elevacao">Elevação (em graus).</param>
        /// <param name="nivelSinal">Nível do sinal; SNR (Signal to Noise Ratio); signal strength.</param>
        public GpsSatelite(int pseudoCodigoRandomico, int azimute, int elevacao, int nivelSinal)
        {
            intPseudoCodigoRandomico = pseudoCodigoRandomico;
            intAzimute = azimute;
            intElevacao = elevacao;
            intNivelSinal = nivelSinal;
        }

        public GpsSatelite()
        {
            intPseudoCodigoRandomico = 0;
            intAzimute = 0;
            intElevacao = 0;
            intNivelSinal = 0;
        }

        #endregion
    }

    /// <summary>
    /// Descreve uma Posição do GPS (latitude ou longitude)
    /// </summary>
    public class GpsPosicao
    {
        #region Atributos

        private double dblPosicaoGraus = 0;
        private double dblPosicaoMinutos = 0;
        private string strHemisferio = string.Empty;        

        #endregion

        #region Propriedades

        /// <summary>
        /// Posição em Graus
        /// </summary>
        public double Graus
        {
            get { return dblPosicaoGraus; }
        }


        /// <summary>
        /// Posição em Minutos
        /// </summary>
        public double Minutos
        {
            get { return dblPosicaoMinutos; }
        }

        /// <summary>
        /// Hemisfério da Posição (N = Norte, S = Sul, W = Oeste, E = Leste)
        /// </summary>
        public string Hemisferio
        {
            get { return strHemisferio; }
        }

        /// <summary>
        /// Descrição do Hemisfério da Posição (Norte, Sul, Oeste, Leste)
        /// </summary>
        public string HemisferioDescricao
        {
            get
            {
                switch (Hemisferio)
                {
                    case "N": return "Norte";
                    case "S": return "Sul";
                    case "W": return "Oeste";
                    case "E": return "Leste";
                    default: return string.Empty;
                }
            }
        }        

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="posicaoGraus">Posição em Graus.</param>
        /// <param name="posicaoMinutos">Posição em Minutos.</param>
        /// <param name="hemisferio">Hemisfério da Posição (N = Norte, S = Sul, W = Oeste, E = Leste)</param>
        public GpsPosicao(double posicaoGraus, double posicaoMinutos, string hemisferio)
        {
            this.dblPosicaoGraus = posicaoGraus;
            this.dblPosicaoMinutos = posicaoMinutos;
            this.strHemisferio = hemisferio;
        }

        public GpsPosicao()
        {
            this.dblPosicaoGraus = 0;
            this.dblPosicaoMinutos = 0;
            this.strHemisferio = "";
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Retorna a posicao completa (em graus e minuts)
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0}°{1}\"{2}", dblPosicaoGraus, dblPosicaoMinutos, strHemisferio);
        }

        #endregion
    }
}
