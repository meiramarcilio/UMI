using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace umi.device.business.GPS
{
    /// <summary>
    /// Extrai informação de uma sentença lida do Gps
    /// </summary>
    public class NmeaInterpreter
    {
        #region Atributos

        protected NumberFormatInfo nfi = (new CultureInfo("en-US")).NumberFormat;
        protected GpsPosicao posLatitude;
        protected GpsPosicao posLongitude;
        protected List<GpsSatelite> satSatelitesVista = new List<GpsSatelite>();

        /// <summary>
        /// Só dispara o evento de satélites quando o limiar (threshold) é atingido.
        /// Essa informação vêm expressa na sentença NMEA iniciada por '$GPGSV'.
        /// </summary>
        protected int intGSVThreshold = 0;        

        #endregion

        #region Eventos e Handlers

        public delegate void PosicaoEventHandler(GpsPosicao latitude, GpsPosicao longitude);
        public event PosicaoEventHandler OnPosicaoRecebida;

        public delegate void DataHoraEventHandler(DateTime dataHora);
        public event DataHoraEventHandler OnDataHoraMudada;

        public delegate void OrientacaoEventHandler(double orientacao);
        public event OrientacaoEventHandler OnOrientacaoRecebida;

        public delegate void VelocidadeEventHandler(double velocidade);
        public event VelocidadeEventHandler OnVelocidadeRecebida;

        public delegate void VelocidadeLimiteAlcancadaEventHandler();
        public event VelocidadeLimiteAlcancadaEventHandler OnVelocidadeLimiteAlcancada;

        public delegate void FixObtidoEventHandler();
        public event FixObtidoEventHandler OnFixObtido;

        public delegate void FixPerdidoEventHandler();
        public event FixPerdidoEventHandler OnFixPerdido;

        public delegate void SatelitesRecebidosEventHandler(List<GpsSatelite> satelites);
        public event SatelitesRecebidosEventHandler OnSatelitesRecebidos;

        public delegate void FixDataEventHandler(double diluicaoHorizontal, double altitudeNivelMar, double alturaWGS84);
        public event FixDataEventHandler OnFixData;

        #endregion
        
        #region Métodos

        /// <summary>
        /// Processa informação do receiver GPS
        /// </summary>
        /// <param name="sentenca">sentença (linha) lida do GPS</param>
        /// <returns>true = uma sentença com um "Mínimo Recomendado" foi encontrada</returns>
        public bool parse(string sentenca)
        {
            //Descarta a sentença se o checksum não é igual ao calculado:
            //if (!sentencaValida(sentenca)) return false;            
            
            // Divide a sentença em palavras
            string[] strPalavras = dividePalavras(sentenca);

            // Procura pela primeira palavra para decidir se continuará processando:
            switch (strPalavras[0])
            {
                case "$GPRMC":
                    return parseGPRMC(strPalavras); // sentença "Recommended Minimum" foi encontrada                    
                case "$GPGSV":
                    return parseGPGSV(strPalavras); // sentença "Satellites in View" foi encontrada
                case "$GPGGA":
                    return parseGPGGA(strPalavras); // sentença "Global Positioning System Fix Data" foi encontrada
                default:
                    return false; // Indica que a setença não foi renconhecida
            }            
        }

        /// <summary>
        /// Divide a sentença em palavras individuais
        /// </summary>
        /// <param name="sentenca">sentença (linha) lida do GPS</param>
        /// <returns>array de palavras (string)</returns>
        protected string[] dividePalavras(string sentenca)
        {
            return sentenca.Split(','); 
        }
         
        /// <summary>
        /// Interpreta uma mensagem $GPRMC (RMC = Recommended Minimum).
        /// Determina: Posição, Velocidade e Hora.
        /// </summary>
        /// <param name="strPalavras">array de palavras (string) da sentença (linha) lida do GPS</param>
        /// <returns>true = setença conhecida; false = senteça desconhecida</returns>
        protected bool parseGPRMC(string[] strPalavras)
        {
            bool boolSetencaReconhecida = false;
                   
            /** LATITUDE E LONGITUDE **/
            // Verifica se tem valores suficientes para descrever uma localização:
            if (strPalavras[2] == "A" && strPalavras[3] != "" && strPalavras[4] != "" && strPalavras[5] != "" && strPalavras[6] != "")
            {
                posLatitude = new GpsPosicao(double.Parse(strPalavras[3].Substring(0, 2), nfi),
                    double.Parse(strPalavras[3].Substring(2), nfi), 
                    strPalavras[4]);

                posLongitude = new GpsPosicao(double.Parse(strPalavras[5].Substring(0, 3), nfi),
                    double.Parse(strPalavras[5].Substring(3), nfi), 
                    strPalavras[6]);

                // Notifica a aplicação da mudança de posição:
                OnPosicaoRecebida(posLatitude, posLongitude);
                //Sentença reconhecida
                boolSetencaReconhecida = true;
            }

            /** DATA/HORA **/
            // Verifica se há valores suficientes para fazer o "parse" na hora derivada do satelite:
            if (strPalavras[1] != "")
            {
                //Sim. Extrai horas, minutos, segundos e milisegundos 
                int intUtcHoras = Convert.ToInt32(strPalavras[1].Substring(0, 2));
                int intUtcMinutos = Convert.ToInt32(strPalavras[1].Substring(2, 2));
                int intUtcSegundos = Convert.ToInt32(strPalavras[1].Substring(4, 2));
                int intUtcMilisegundos;                
                //Extrai os milisegundos se estiverem disponíveis:
                intUtcMilisegundos = Convert.ToInt32(strPalavras[1].Substring(7));                                 
                //Agora cria um objeto DateTime com todos os valores:
                DateTime hoje = System.DateTime.Now.ToUniversalTime(); 
                System.DateTime dtHoraSatelite = new System.DateTime(hoje.Year, hoje.Month, hoje.Day, intUtcHoras, intUtcMinutos, intUtcSegundos, intUtcMilisegundos);                
                //Notificar nova hora, ajustada à zona local:
                OnDataHoraMudada(dtHoraSatelite.ToLocalTime());
                //Sentença reconhecida
                boolSetencaReconhecida = true;
            }

            /** VELOCIDADE **/
            //Verifica se há informação suficiente para extrair a velocidade:
            if (strPalavras[7] != "")
            {
                //Sim. Converte em Km/h
                double dblVelocidade = (double.Parse(strPalavras[7], nfi) * 1.852);
                //Se estivermos acima de 110 Km/h então dispara um alarme de velocidade:
                if(dblVelocidade > 110) OnVelocidadeLimiteAlcancada();
                //Notificar nova velocidade:
                OnVelocidadeRecebida(dblVelocidade);
                //Sentença reconhecida
                boolSetencaReconhecida = true;
            }

            /** ORIENTAÇÃO **/
            //Verifica se há informação suficiente para extrair a orientação:
            if (strPalavras[8] != "")
            {
                //Indica que a sentença foi reconhecida: 
                double dblOrientacao = double.Parse(strPalavras[8], nfi); 
                OnOrientacaoRecebida(dblOrientacao);
                //Sentença reconhecida
                boolSetencaReconhecida = true;
            }

            /** FIX **/
            //Verifica se o dispositivo tem um "FIX" do satelite:
            if (strPalavras[2] != "")
            {
                switch(strPalavras[2])
                {
                    case "A": 
                        OnFixObtido();
                        break;  
                    case "V": 
                        OnFixPerdido();
                        break;
                }
                //Sentença reconhecida
                boolSetencaReconhecida = true;
            }            

            // Indica que a sentença foi reconhecida ou não
            return boolSetencaReconhecida;            
        }

        /// <summary>
        /// Interpreta uma sentença NMEA "Satélites em vista"
        /// </summary>
        /// <param name="strPalavras">array de palavras (string) da sentença (linha) lida do GPS</param>
        /// <returns>true = setença conhecida; false = senteça desconhecida</returns>
        protected bool parseGPGSV(string[] strPalavras)
        {            
            // Armazena o número da última sentença (a atual) GSV lida, para ser comparada
            // com o limiar (intGSVThreshold):
            int intGSVSentencaAtual = 0;
 
            if((strPalavras[1] != "") && (strPalavras[2] != "") && (strPalavras[3] != ""))
            {
                //Número de sentenças GSV para uma completa descrição dos dados:
                if (intGSVThreshold == 0) intGSVThreshold = Convert.ToInt32(strPalavras[1]);             

                //Sentença GSV atual:
                intGSVSentencaAtual = Convert.ToInt32(strPalavras[2]);

                // Se for a primeira senteça, reseta a lista de satélites:
                if (intGSVSentencaAtual == 1) satSatelitesVista.Clear();                

                //Cada sentença GSV contém 4 blocos de informação de satelites. 
                //Lê cada bloco e só notifica quando o limiar é alcançado:
                for (int i = 1; i <= 4; i++)
                {
                    //Verifica se sentença tem palavras suficientes para analisar: 
                    if ((strPalavras.Length - 1) >= (i * 4 + 3))
                    {
                        //Sim. Proceder com a análise do bloco. Verifica se contém alguma informação:
                        if ((strPalavras[i * 4] != "") && (strPalavras[i * 4 + 1] != "") && (strPalavras[i * 4 + 2] != "") && (strPalavras[i * 4 + 3] != ""))
                        {
                            //Sim. Extrai informação de satelite e adiciona à lista: 
                            satSatelitesVista.Add(new GpsSatelite(
                                Convert.ToInt32(strPalavras[i * 4]), //Pseudo Código Randômico
                                Convert.ToInt32(strPalavras[i * 4 + 1]), //Azimute
                                Convert.ToInt32(strPalavras[i * 4 + 2]), //Elevação
                                Convert.ToInt32(strPalavras[i * 4 + 2]))); //Nível do Sinal

                            //Se foi a última sentença GSV lida, então todos os dados GSV foram lidos;
                            //reseta o threshold e dispara o evento:
                            if (intGSVSentencaAtual == intGSVThreshold)
                            {
                                //Notificar esta informação de satelites:
                                OnSatelitesRecebidos(satSatelitesVista);
                            }
                        }
                    }
                }

                //Sentença reconhecida:
                return true;
            }

            //Sentença não reconhecida:
            return false; 
        }

        /// <summary>
        /// Interpreta uma sentença NMEA "Global Positioning System Fix Data"
        /// </summary>
        /// <param name="strPalavras">array de palavras (string) da sentença (linha) lida do GPS</param>
        /// <returns>true = setença conhecida; false = senteça desconhecida</returns>
        protected bool parseGPGGA(string[] strPalavras)
        {
            // Verifica se tem valores suficientes para descrever uma localização:
            if (strPalavras[8] != "" && strPalavras[9] != "" && strPalavras[11] != "")
            {                
                // Notifica a aplicação da mudança de posição:
                OnFixData(double.Parse(strPalavras[8], nfi), //diluição horizontal da posição
                    double.Parse(strPalavras[9], nfi), //altitude, em metros, sobre o nível do mar
                    double.Parse(strPalavras[11], nfi)); //altura do geóide sobre o elipsóide WGS84

                return true;
            }

            return false;
        }

        /// <summary>
        /// Returna true se o "checksum" de uma sentença é igual ao "checksum" calculado 
        /// </summary>
        /// <param name="sentenca">sentença (linha) lida do GPS</param>
        /// <returns>booleano</returns>
        protected bool sentencaValida(string sentenca)
        {
            // Compara os caracteres após o asterisco com o calculado:
            return (sentenca.Substring(sentenca.IndexOf("*") + 1, 2) == calculaChecksum(sentenca));
        }

        /// <summary>
        /// Calcula o checksum para uma sentença, através de um
        /// XOR (Ou exclusivo) de 8 bits (um byte) entre todos os caracteres, excluindo
        /// o '$' e o '*'.
        /// </summary>
        /// <param name="sentenca">sentença (linha) lida do GPS</param>
        /// <returns>string com valor em Hexadecimal de 2 dígitos</returns>
        protected string calculaChecksum(string sentenca)
        {
            bool boolExitFor = false;
            // Faz um loop (foreach) através de todos os caracteres para calcular o checksum 
            byte bytChecksum = 0;
            foreach (char caractere in sentenca)
            {
                switch (caractere)
                {
                    case '$':
                        break; // Ignora o sinal de dolar
                    case '*': // Para de processar antes do asterisco
                        boolExitFor = true;
                        break;
                    default: // Verifica se é o primeiro valor para o checksum:
                        if (bytChecksum == 0){ // Sim. Seta o checksum com o valor:
                            bytChecksum = Convert.ToByte(caractere); }
                        else{ // Não. XOR entre o checksum e este caractere:
                            bytChecksum ^= Convert.ToByte(caractere); }
                        break;
                }
                if (boolExitFor) break;
            }
            // Returna o checksum formatado como um caractere hexadecimal de dois dígitos:
            return bytChecksum.ToString("X2");
        }

        #endregion
    }
}
