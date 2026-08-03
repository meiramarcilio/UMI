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
    public partial class frmPasse : frmBusiness
    {
        #region Enum

        private enum enFilterRadio
        {
            placa = 0,
            passe = 1
        }

        #endregion

        #region Construtor

        public frmPasse()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void frmPasse_Load(object sender, EventArgs e)
        {
            inicializarForm();
        }        

        private void menuItemVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radPasse_CheckedChanged(object sender, EventArgs e)
        {
            changeRadio(enFilterRadio.passe);
        }

        private void radPlaca_CheckedChanged(object sender, EventArgs e)
        {
            changeRadio(enFilterRadio.placa);
        }

        private void menuItemProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;                
                listarPasses();
            }
            catch (System.Net.WebException ex)
            {
                msgAtencao(util.webserviceErrorMsg(ex.Message));
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
            exibirStatus(statusBar1, STATUSBAR_TEXTO_PADRAO);
            changeRadio(enFilterRadio.placa);
        }

        private void changeRadio(enFilterRadio radSelected)
        {
            txtPlaca.Enabled = false;
            txtPasse.Enabled = false;
            Color disabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            txtPlaca.BackColor = disabledColor;
            txtPasse.BackColor = disabledColor;

            if (radSelected == enFilterRadio.placa)
            {
                txtPlaca.Enabled = true;
                txtPlaca.Text = string.Empty;
                txtPlaca.Focus();
                txtPlaca.BackColor = Color.White;
            }
            else
            {
                txtPasse.Enabled = true;
                txtPasse.Text = string.Empty;
                txtPasse.Focus();
                txtPasse.BackColor = Color.White;
            }
        }

        private void listarPasses()
        {
            Passe[] passes;
            if (radPlaca.Checked)
            {
                if (txtPlaca.Text.Trim() == string.Empty) { msgExclamacao("Informe uma Placa de veículo."); return; }
                exibirStatus(statusBar1, "Procurando Placa...");
                txtPlaca.Text = txtPlaca.Text.Trim().ToUpper();
                passes = listarPassesAbertos(txtPlaca.Text.Trim());
            }
            else
            {
                if (!util.isNumber(txtPasse.Text.Trim())) { msgExclamacao("Número do Passe inválido."); return; }
                exibirStatus(statusBar1, "Procurando Passe...");
                passes = lerPasseAberto(Convert.ToInt32(txtPasse.Text.Trim()));
            }
            passeInternoBindingSource.DataSource = passes;

            if (passes.Length <= 0) msgAtencao("Nenhum Passe encontrado.");
        }

        #endregion        

    }
}