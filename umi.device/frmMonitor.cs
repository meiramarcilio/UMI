using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umi.device.business;
using umi.device.business.GPS;
using System.IO;

namespace umi.device
{
    public partial class frmMonitor : frmBusiness
    {
        #region Atributos

        private conetividade conectiv = null;
        private Gps gps = null;
        private bool boolGpsAtualizado = false;
        
        /// <summary>
        /// Flag para só fechar o GPS se ele já não havia sido
        /// aberto por outro formulário (tela).
        /// </summary>
        private bool boolGpsJaEstavaAberto = false;

        #endregion

        #region Construtor

        public frmMonitor()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void frmMonitor_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                this.inicializarForm();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                msgAtencao(ex.Message);
            }
        }

        private void menuItemVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void tabRedes_GotFocus(object sender, EventArgs e)
        {
            try
            {
                carregarRedes();
            }
            catch (Exception ex)
            {
                msgAtencao(ex.Message);
            }
        }

        private void tabTelefone_GotFocus(object sender, EventArgs e)
        {
            try
            {
                carregarTelefone();
            }
            catch (Exception ex)
            {
                msgAtencao(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                refresh();
            }
            catch (Exception ex)
            {
                msgAtencao(ex.Message);
                timer1.Enabled = false;
            }
        }

        private void frmMonitor_Closing(object sender, CancelEventArgs e)
        {
            timer1.Enabled = false;            

            //Se o gps está aberto, e antes de entrar neste formulário
            //não estava, então fecha-o:
            if (gps != null && gps.Aberto && !boolGpsJaEstavaAberto)
            {
                gps.Fechar();
            }
        }

        private void gps_OnUpdated()
        {
            boolGpsAtualizado = true;
        }

        #endregion

        #region Métodos

        private void inicializarForm()
        {
            statusBar1.Text = STATUSBAR_TEXTO_PADRAO;
            progressBarSinalCelular.Maximum = 100;
            progressBarSinalCelular.Minimum = 0;
            progressBarSinalCelular.Value = 0;

            conectiv = new conetividade();
            this.carregarBancoDados();
            this.carregarRedes();
            this.carregarTelefone();

            gps = instanciaGps("COM4", 38400); //recupera a instância do gps            
            if (gps.Aberto) //verifica se já estava aberto
                boolGpsJaEstavaAberto = true;
            else 
                gps.Abrir(); //estava fechado, então abri-lo-á
            
            //atribui um handler ao evento de atualização do gps:
            gps.OnUpdated += new Gps.GpsEventHandler(gps_OnUpdated);
        }                

        /// <summary>
        /// Checa o status da rede
        /// </summary>
        private void carregarRedes()
        {
            //Exibe valores default:
            lblRedesIP.Text = "127.0.0.1";
            lblRedesWifiStatus.Text = "desativada";
            lstRedesConexoes.Items.Clear();
            lstRedesAdaptadores.Items.Clear();

            //Checa o status da Rede Wifi:            
            try
            {
                if (conectiv.WifiLigada)
                {
                    lblRedesWifiStatus.Text = "ligada";

                    if (conectiv.WifiConectandoRede)
                    {
                        lblRedesWifiStatus.Text = "conectando";
                    }
                    else
                    {
                        if (conectiv.WifiConectadoRede)
                        {
                            lblRedesWifiStatus.Text = "conectado";
                        }
                        else
                        {
                            lblRedesWifiStatus.Text = "desconectado";
                        }
                    }
                }
                else
                {
                    lblRedesWifiStatus.Text = "desativada";
                }

                //Lista de Conexões Ativas:
                if (conectiv.RedeConexoesNumero > 0)
                {
                    string[] strConn = conectiv.RedeConexoes.Split(',');
                    foreach (string conn in strConn)
                    {
                        lstRedesConexoes.Items.Add(conn.ToUpper());
                    }

                    //Lista de Adaptadores das conexões ativas:                    
                    string[] strAdapt = conectiv.RedeConexoesAdaptadores.Split(',');
                    foreach (string adapt in strAdapt)
                    {
                        lstRedesAdaptadores.Items.Add(adapt.ToUpper());
                    }
                }
                else
                {
                    lstRedesConexoes.Items.Add("Nenhuma conexão.");
                }

                string strHostName = System.Net.Dns.GetHostName();                                
                System.Net.IPHostEntry thisHost = System.Net.Dns.GetHostEntry(strHostName);
                string strIP = thisHost.AddressList[0].ToString();
                lblRedesIP.Text = string.Format("{0} ({1})", (strIP.Length > 15 ? "GPRS" : strIP), strHostName);
            }
            catch (Exception)
            {
                throw new Exception("Falha ao tentar carregar informações de Rede");
            }
        }

        /// <summary>
        /// Lê informações a respeito da base de dados local.
        /// </summary>
        private void carregarBancoDados()
        {
            //Exibe valores default:
            lblBaseDadosEspaco.Text = "0 KB";
            lblBaseDadosArquivo.Text = "(não encontrado)";

            try
            {
                string count = contarContribuintes().ToString();
                lblBaseDadosNumContrib.Text = (count != string.Empty) ? count : "0";
            }
            catch (Exception)
            {
                throw new Exception("Falha ao tentar contar número de Contribuintes.");
            }            

            try
            {
                string strDbPath = string.Format("{0}{1}db{1}umidb",
                    Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase),
                    Path.DirectorySeparatorChar);                    

                if (File.Exists(strDbPath))
                {
                    FileInfo filInf = new FileInfo(strDbPath);
                    lblBaseDadosEspaco.Text = string.Format("{0} KB", (filInf.Length / 1024).ToString("F2"));
                    lblBaseDadosArquivo.Text = strDbPath;
                }
            }
            catch (System.IO.IOException)
            {
                throw new Exception("Falha ao tentar localizar arquivo da Base de Dados Local.");
            }
        }

        /// <summary>
        /// Lê informações do telefone
        /// </summary>
        private void carregarTelefone()
        {
            try
            {
                lblTelCobertura.Text = conectiv.TelefoneGPRSCobertura ? "Sim" : "Não";
                progressBarSinalCelular.Value = conectiv.TelefoneSinal;
                lstTelConexoes.Items.Clear();

                if (conectiv.TelefoneConexoesNumero > 0)
                {
                    string[] strConn = conectiv.TelefoneConexoes.Split(',');
                    foreach (string conn in strConn)
                    {
                        lstTelConexoes.Items.Add(conn.ToUpper());
                    }
                }
                else
                {
                    lstTelConexoes.Items.Add("Nenhuma conexão.");
                }
            }
            catch (Exception)
            {
                throw new Exception("Falha ao tentar carregar informações do telefone.");
            }                        
        }

        /// <summary>
        /// Lê informações do Gps
        /// </summary>
        private void carregarGps()
        {
            //Verifica se as informações do GPS foram atualizadas:
            if (boolGpsAtualizado)
            {
                lstGPS.Items.Clear();
                lock (gps)
                {
                    lstGPS.Items.Add(new ListViewItem(new string[] { "Fix", (gps.Fix ? "Obtido" : "Perdido") }));
                    lstGPS.Items.Add(new ListViewItem(new string[] { "Latitude", gps.Latitude.ToString() }));
                    lstGPS.Items.Add(new ListViewItem(new string[] { "Longitude", gps.Longitude.ToString() }));
                    lstGPS.Items.Add(new ListViewItem(new string[] { "Data/Hora", gps.DataHora.ToString("dd/MM/yyyy HH:mm:ss") }));
                    lstGPS.Items.Add(new ListViewItem(new string[] { "Velocidade", gps.Velocidade.ToString() }));
                    lstGPS.Items.Add(new ListViewItem(new string[] { "Altitude", gps.AltitudeNivelMar.ToString() }));
                    lstGPS.Items.Add(new ListViewItem(new string[] { "Satelites", gps.NumeroSatelitesVista.ToString() }));
                    lstGPS.Items.Add(new ListViewItem(new string[] { "Porta", gps.NomePorta }));
                    lstGPS.Items.Add(new ListViewItem(new string[] { "Baud", gps.BaudRate.ToString() }));
                }
                boolGpsAtualizado = false;
            }
        }

        /// <summary>
        /// Método chamado pelo timer, que carrega informações
        /// de Redes, do Telefone e do GPS
        /// </summary>
        private void refresh()
        {
            carregarRedes();
            carregarTelefone();
            carregarGps();
        }        

        #endregion        
    }
}