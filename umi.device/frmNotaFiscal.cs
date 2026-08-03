using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umi.device.wsumi;
using umi.device.business;

namespace umi.device
{
    public partial class frmNotaFiscal : frmBusiness
    {
        #region Atributos

        string strRazaoSocialEntr = string.Empty;
        string strRazaoSocialSaid = string.Empty;
        private NotaFiscalSaida[] nfSaida;
        private NotaFiscalEntrada[] nfEntrada;

        #endregion

        #region Propriedades

        public string strInscricaoEstadualSaida
        {
            get{ return txtInscricao1.Text.Trim(); }
        }

        public string strInscricaoEstadualEntrada
        {
            get { return txtInscricao2.Text.Trim(); }
        }

        #endregion

        #region Construtor

        public frmNotaFiscal()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void frmNotaFiscal_Load(object sender, EventArgs e)
        {
            inicializarForm();
        }        

        private void dgNFSaida_DoubleClick(object sender, EventArgs e)
        {
            detalharNotaFiscalSaida();
        }

        private void dgNFEntrada_DoubleClick(object sender, EventArgs e)
        {
            detalharNotaFiscalEntrada();
        }

        private void menuItemVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItemProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                switch (tabControl1.SelectedIndex)
                {
                    case 0: //NF de Saída
                        listarNotasFiscaisSaida();
                        break;
                    case 1: //NF de Entrada
                        listarNotasFiscaisEntrada();
                        break;
                }
            }
            catch (System.Net.WebException ex)
            {
                msgAtencao(ex.Message);
            }
            catch (Exception ex)
            {
                msgAtencao(ex.Message);
            }
            finally
            {
                exibirStatus(statusBar1, STATUSBAR_TEXTO_PADRAO);
                Cursor.Current = Cursors.Default;
            }
        }

        #endregion

        #region Métodos

        private void inicializarForm()
        {
            //datas dos DateTimePickers
            DateTime agora = DateTime.Now;
            dtpNFSaidaFim.Value = agora;
            dtpNFEntradaFim.Value = agora;
            dtpNFSaidaInicio.Value = agora.AddDays(-5);
            dtpNFEntradaInicio.Value = agora.AddDays(-5);

            exibirStatus(statusBar1, STATUSBAR_TEXTO_PADRAO);
        }

        /// <summary>
        /// Consulta no banco notas fiscais de saída do contribuinte
        /// </summary>
        private void listarNotasFiscaisSaida()
        {
            exibirStatus(statusBar1, "Procurando Notas de Saída...");
            //se o textbox da tab de NF de Entrada estiver em branco será preenchido:
            if (strInscricaoEstadualEntrada.Length <= 0) { txtInscricao2.Text = strInscricaoEstadualSaida; }
            //Lê a Razão Social do Contribuinte
            if(!lerRazaoSocialSaida()) return;
            //lista notas fiscais de saída:            
            nfSaida = listarNFSaida(strInscricaoEstadualSaida, dtpNFSaidaInicio.Value, dtpNFSaidaFim.Value);
            notaFiscalSaidaBindingSource.DataSource = nfSaida;
        }

        /// <summary>
        /// Consulta no banco notas fiscais de entrada do contribuinte
        /// </summary>
        private void listarNotasFiscaisEntrada()
        {
            exibirStatus(statusBar1, "Procurando Notas de Entrada...");
            //se o textbox da tab de NF de Saída estiver em branco será preenchido:
            if (strInscricaoEstadualSaida.Length <= 0) { txtInscricao1.Text = strInscricaoEstadualEntrada; }
            //Lê a Razão Social do Contribuinte
            if (!lerRazaoSocialEntrada()) return;
            //lista notas fiscais de entrada:
            nfEntrada = listarNFEntrada(strInscricaoEstadualEntrada, dtpNFEntradaInicio.Value, dtpNFEntradaFim.Value);
            notaFiscalEntradaBindingSource.DataSource = nfEntrada;
        }

        private void detalharNotaFiscalSaida()
        {
            frmNotaFiscalDetalhar frm = new frmNotaFiscalDetalhar(strRazaoSocialSaid, nfSaida[dgNFSaida.CurrentRowIndex], null);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void detalharNotaFiscalEntrada()
        {
            frmNotaFiscalDetalhar frm = new frmNotaFiscalDetalhar(strRazaoSocialEntr, null, nfEntrada[dgNFEntrada.CurrentRowIndex]);
            frm.ShowDialog();
            frm.Dispose();
        }

        private bool lerRazaoSocialEntrada()
        {
            Contribuinte[] contrib = lerContribuinte(strInscricaoEstadualEntrada);
            if (contrib.Length > 0) { strRazaoSocialEntr = contrib[0].NM_FORMAL; return true; }
            else { msgAtencao("Contribuinte não encontrado."); return false; }
        }

        private bool lerRazaoSocialSaida()
        {
            Contribuinte[] contrib = lerContribuinte(strInscricaoEstadualSaida);
            if (contrib.Length > 0) { strRazaoSocialSaid = contrib[0].NM_FORMAL; return true; }
            else { msgAtencao("Contribuinte não encontrado."); return false; }
        }

        #endregion
        
    }
}