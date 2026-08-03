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
    public partial class frmNotaFiscalDetalhar : frmBusiness
    {
        #region Atributos

        private NotaFiscalSaida nfSaida = null;
        private NotaFiscalEntrada nfEntrada = null;
        private string strRazaoSocial = string.Empty;

        #endregion

        #region Construtor

        public frmNotaFiscalDetalhar(string strRazaoSocialNota, NotaFiscalSaida nfs, NotaFiscalEntrada nfe)
        {
            InitializeComponent();
            strRazaoSocial = strRazaoSocialNota;
            nfSaida = nfs;
            nfEntrada = nfe;
        }

        #endregion

        #region Eventos

        private void menuItemVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNotaFiscalDetalhar_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;                
                if (nfSaida != null)
                {
                    lerNFSaida();
                }
                else if (nfEntrada != null)
                {
                    lerNFEntrada();
                }
                else
                {
                    msgExclamacao("Não é possível exibir os detalhes da nota fiscal.");
                }
            }
            catch (Exception ex)
            {
                msgAtencao(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        #endregion
     
        #region Métodos

        private void lerNFSaida()
        {
            this.lblNFDetalheTit.Text = "Nota Fiscal Saída - Detalhes";

            string strDtDigit = (nfSaida.DSNOTS_DTDIGIT == 0) ? string.Empty :
                nfSaida.DSNOTS_DTDIGIT.ToString().Substring(6) + "/" +
                nfSaida.DSNOTS_DTDIGIT.ToString().Substring(4, 2) + "/" +
                nfSaida.DSNOTS_DTDIGIT.ToString().Substring(0, 4);

            string strHoraDigit = (nfSaida.DSNOTS_HORA == 0) ? string.Empty :
                nfSaida.DSNOTS_HORA.ToString().Substring(0, 2) + ":" +
                nfSaida.DSNOTS_HORA.ToString().Substring(2);

            string strDtEmissao = (nfSaida.DSNOTS_DTEMISSAO == 0) ? string.Empty :
                nfSaida.DSNOTS_DTEMISSAO.ToString().Substring(6) + "/" +
                nfSaida.DSNOTS_DTEMISSAO.ToString().Substring(4, 2) + "/" +
                nfSaida.DSNOTS_DTEMISSAO.ToString().Substring(0, 4);

            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "Insc. Estad.", nfSaida.DSNOTS_INSCRI.ToString() }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "Razão Social", strRazaoSocial }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "Retenção", strDtDigit }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "Nota/Série", nfSaida.DSNOTS_NOTAF.ToString() + "/" + nfSaida.DSNOTS_SERIE }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "Vlr da Nota", nfSaida.DSNOTS_VALTOTAL.ToString() }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "Vlr do ICMS", nfSaida.DSNOTS_VALICMS.ToString() }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "Vlr ICMS Sub", nfSaida.DSNOTS_VALSUBST.ToString() }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "CNPJ Dest.", nfSaida.DSNOTS_CGCDEST }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "UF", nfSaida.DSNOTS_UFDEST }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "Emissão", strDtEmissao }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "Vlr Frete", nfSaida.DSNOTS_VLR_FRETE.ToString() }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "ICMS Frete", nfSaida.DSNOTS_ICMS_FRETE.ToString() }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "Peso", nfSaida.DSNOTS_PESO.ToString() }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "Doc. Frete", (nfSaida.DSNOTS_DOCPGFRETE.Length > 0) ? nfSaida.DSNOTS_DOCPGFRETE : "*** Sem informação ***" }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "Digitado/Alterado por", string.Format("{0} em {1} às {2}", nfSaida.DSNOTS_OPER_INC, strDtDigit, strHoraDigit) }));
        }

        private void lerNFEntrada()
        {
            this.lblNFDetalheTit.Text = "Nota Fiscal Entrada - Detalhes";

            string strDtDigit = (nfEntrada.DSNOT_DTDIGIT == 0) ? string.Empty :
                nfEntrada.DSNOT_DTDIGIT.ToString().Substring(6) + "/" +
                nfEntrada.DSNOT_DTDIGIT.ToString().Substring(4, 2) + "/" +
                nfEntrada.DSNOT_DTDIGIT.ToString().Substring(0, 4);

            string strHoraDigit = (nfEntrada.DSNOT_HORA == 0) ? string.Empty :
                nfEntrada.DSNOT_HORA.ToString().Substring(0, 2) + ":" +
                nfEntrada.DSNOT_HORA.ToString().Substring(2);

            string strDtEmissao = (nfEntrada.DSNOT_DTEMISSAO == 0) ? string.Empty :
                nfEntrada.DSNOT_DTEMISSAO.ToString().Substring(6) + "/" +
                nfEntrada.DSNOT_DTEMISSAO.ToString().Substring(4, 2) + "/" +
                nfEntrada.DSNOT_DTEMISSAO.ToString().Substring(0, 4);

            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "Insc. Estad.", nfEntrada.DSNOT_INSCRI.ToString() }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "Razão Social", strRazaoSocial }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "Retenção", strDtDigit }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "Nota/Série", nfEntrada.DSNOT_NOTAF.ToString() + "/" + nfEntrada.DSNOT_SERIE }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "Cobr.", nfEntrada.DSNOT_CODCOB.ToString() }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "Vlr da Nota", nfEntrada.DSNOT_VALTOTAL.ToString() }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "Vlr do ICMS", nfEntrada.DSNOT_VALICMS.ToString() }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "Vlr ICMS Sub", nfEntrada.DSNOT_ICMSUBST.ToString() }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "CNPJ Emit.", nfEntrada.DSNOT_CGC }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "UF", nfEntrada.DSNOT_UFEMIT }));
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "Emissão", strDtEmissao }));            
            lstNFDetalhes.Items.Add(new ListViewItem(new string[] { "Digitado/Alterado por", string.Format("{0} em {1} às {2}", nfEntrada.DSNOT_OPERADOR, strDtDigit, strHoraDigit)}));
        }

        #endregion
    }
}