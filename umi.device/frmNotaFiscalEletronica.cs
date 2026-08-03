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
    public partial class frmNotaFiscalEletronica : frmBusiness
    {
        #region Construtor

        public frmNotaFiscalEletronica()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void menuItemVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItemProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                exibirStatus(statusBar1, "Procurando NF-e...");
                lerNFe();
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

        private void frmNotaFiscalEletronica_Load(object sender, EventArgs e)
        {
            inicializarForm();
        }

        #endregion

        #region Métodos

        private void inicializarForm()
        {
            exibirStatus(statusBar1, STATUSBAR_TEXTO_PADRAO);
        }

        private void lerNFe()
        {
            lstNFe.Visible = false;
            lblSituacao.Visible = false;
            NotaFiscalEletronica[] nfe = lerNFE(txtCNPJEmit.Text.Trim(), Convert.ToInt64(txtNumNF.Text.Trim()), txtCincoUltDig.Text.Trim());
            if (nfe.Length > 0)
            {                
                lstNFe.Items.Clear();
                lstNFe.Items.Add(new ListViewItem("Núm. NF-e:")).SubItems.Add(nfe[0].NNF.ToString());
                lstNFe.Items.Add(new ListViewItem("Série:")).SubItems.Add(nfe[0].SERIE.ToString());
                lstNFe.Items.Add(new ListViewItem("Emissão:")).SubItems.Add(nfe[0].DEMI.ToString());
                lstNFe.Items.Add(new ListViewItem("Valor R$:")).SubItems.Add(nfe[0].VALORNFE.ToString("F2"));
                lstNFe.Items.Add(new ListViewItem("Emitente:")).SubItems.Add(nfe[0].RAZAOSOCIALEMITENTE);
                lstNFe.Items.Add(new ListViewItem("Insc.Emit.:")).SubItems.Add(nfe[0].IEEMITENTE);
                lstNFe.Items.Add(new ListViewItem("UF Emit.:")).SubItems.Add(nfe[0].UFEMITENTE);
                lstNFe.Items.Add(new ListViewItem("Destinat.:")).SubItems.Add(nfe[0].RAZAOSOCIALDESTINATARIO);
                lstNFe.Items.Add(new ListViewItem("Insc.Dest.:")).SubItems.Add(nfe[0].IEDESTINATARIO);
                lstNFe.Items.Add(new ListViewItem("CNPJ Dest.:")).SubItems.Add(nfe[0].CNPJDESTINATARIO);
                lstNFe.Items.Add(new ListViewItem("UF Dest.:")).SubItems.Add(nfe[0].UFDESTINATARIO);
                lstNFe.Visible = true;

                //Lê os registros da NF-e:
                NotaFiscalRegistro[] nfr = lerNFRegistro(Convert.ToInt64(txtNumNF.Text.Trim()));
                if (nfr != null && nfr.Length > 0)
                {
                    lblSituacao.Text = string.Format(nfr[0].SITUACAO);
                    lblSituacao.Visible = true;
                }
                else
                {
                    lblSituacao.Text = "NF-e não registrada no Posto.";                    
                }
            }
        }

        #endregion
    }
}