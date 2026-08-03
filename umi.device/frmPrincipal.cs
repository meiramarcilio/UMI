using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umi.device.business;
using umi.device.business.GPS;

namespace umi.device
{
    public partial class frmPrincipal : frmBusiness
    {
        #region Atributos

        private Gps gps = null;
        private bool boolGpsAtualizado = false;
        
        /// <summary>
        /// Contador de tentativas de envio de GPS sem sucesso.
        /// Quando completar o número de 5 tentativas sem sucesso,
        /// o temporizador é desabilitado. Porém se estiver com
        /// valor maior que 0 (zero) e menor que 5 (cinco), mas conseguir
        /// um envio com sucesso, o contador é resetado para 0 (zero).
        /// </summary>
        private int intNumTentativasEnvioGps = 0;

        #endregion

        #region Construtor

        public frmPrincipal()
        {
            InitializeComponent();
        }

        #endregion        

        #region Eventos

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                inicializarForm();
            }
            catch (Exception ex)
            {
                msgAtencao(ex.Message + '\n' + ex.StackTrace);
            }
        }

        private void lnkContribuinte_Click(object sender, EventArgs e)
        {
            frmContribuinteBusca frm = new frmContribuinteBusca();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void lnkNotasFiscais_Click(object sender, EventArgs e)
        {
            frmNotaFiscal frm = new frmNotaFiscal();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void lnkECF_Click(object sender, EventArgs e)
        {
            frmECF frm = new frmECF();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void lnkNFE_Click(object sender, EventArgs e)
        {
            frmNotaFiscalEletronica frm = new frmNotaFiscalEletronica();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void lnkMonitor_Click(object sender, EventArgs e)
        {
            frmMonitor frm = new frmMonitor();
            frm.ShowDialog();
            frm.Dispose();
        }        

        private void lnkPasses_Click(object sender, EventArgs e)
        {
            frmPasse frm = new frmPasse();
            frm.ShowDialog();
            frm.Dispose();
        }        

        private void picContribuinte_Click(object sender, EventArgs e)
        {
            frmContribuinteBusca frm = new frmContribuinteBusca();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void picNotasFiscais_Click(object sender, EventArgs e)
        {
            frmNotaFiscal frm = new frmNotaFiscal();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void picECF_Click(object sender, EventArgs e)
        {
            frmECF frm = new frmECF();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void picNFE_Click(object sender, EventArgs e)
        {
            frmNotaFiscalEletronica frm = new frmNotaFiscalEletronica();
            frm.ShowDialog();
            frm.Dispose();
        }        

        private void picMonitor_Click(object sender, EventArgs e)
        {
            frmMonitor frm = new frmMonitor();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void picPasses_Click(object sender, EventArgs e)
        {
            frmPasse frm = new frmPasse();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void menuItemSobre_Click(object sender, EventArgs e)
        {
            frmAjudaSobre frm = new frmAjudaSobre();
            frm.ShowDialog();
        }

        private void menuItemAnotacoes_Click(object sender, EventArgs e)
        {
            msgExclamacao("Funcionalidade em desenvolvimento.");
        }

        private void menuItemLogoff_Click(object sender, EventArgs e)
        {
            logoff();
        }

        private void menuItemSair_Click(object sender, EventArgs e)
        {
            if (msgPergunta("Deseja sair do programa?", "UMI - Sair"))
            {
                timer1.Enabled = false;
                //Se houver instância e estiver aberto objeto Gps, então fecha-o:
                if (gps != null && gps.Aberto)
                {
                    gps.Fechar();                    
                }
                //Encerra a aplicação:
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //Chama o webservice que envia as informações do Gps
                if (boolGpsAtualizado)
                {
                    if(gps.Latitude.Graus > 0) enviarGps();
                    boolGpsAtualizado = false;
                    //reseta o contador de tentativas de envio sem sucesso:
                    intNumTentativasEnvioGps = 0;
                }                
            }
            catch (Exception)
            {
                intNumTentativasEnvioGps++; //incrementa contador de erros de envio
                if (intNumTentativasEnvioGps == 5) //testa se chegou no limite
                {
                    timer1.Enabled = false; //desabilita o temporizador
                    msgExclamacao("Envio de GPS com problemas. Temporizador desabilitado.");                    
                    //fecha o gps:
                    if (gps != null && gps.Aberto)
                    {
                        gps.Fechar();
                        gps = null;
                    }
                }
            }
        }

        #endregion
        
        #region Métodos

        private void inicializarForm()
        {
            frmLogin frm = new frmLogin();
            while (frm.DialogResult != DialogResult.Yes)
            {
                frm.ShowDialog();
            }
            frm.Dispose();
            statusBar1.Text = STATUSBAR_TEXTO_PADRAO;
            
            //inicia processamento GPS:
            gps = instanciaGps("COM4", 38400);
            gps.Abrir();
            gps.OnUpdated += new Gps.GpsEventHandler(gps_OnUpdated);
        }

        void gps_OnUpdated()
        {
            boolGpsAtualizado = true;
        }

        /// <summary>
        /// Efetua logout e abre a tela de login.
        /// </summary>
        private void logoff()
        {
            logout();
            inicializarForm();
        }

        #endregion                
        
    }
}