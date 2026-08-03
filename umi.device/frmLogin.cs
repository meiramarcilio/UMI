using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umi.device.business;

namespace umi.device
{
    public partial class frmLogin : frmBusiness
    {
        #region Construtor

        public frmLogin()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                statusBar1.Text = string.Format("versão: {0}", lerVersao());
            }
            catch (Exception)
            {
                statusBar1.Text = string.Format("versão: impossível determinar.");
            }
        }

        private void menuItemSair_Click(object sender, EventArgs e)
        {
            if (msgPergunta("Deseja sair do programa?", "UMI - Sair"))
            {
                this.DialogResult = DialogResult.Yes;
                Application.Exit();
            }
        }

        private void menuItemEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
                exibirStatus(statusBar1, "Verificando usuário e senha...");                
                efetuarLogin();
            }
            catch (System.Net.WebException ex)
            {
                msgExclamacao(ex.Message); // "Autenticação falhou na comunicação com o servidor.");
            }
            catch (Exception ex)
            {
                msgAtencao(util.webserviceErrorMsg(ex.Message));
            }
            finally
            {
                exibirStatus(statusBar1, lerVersao());
                Cursor.Current = System.Windows.Forms.Cursors.Default;
            }
        }

        #endregion

        #region Métodos

        private void efetuarLogin()
        {
            string strLogin = txtLogin.Text.Trim().ToUpper();
            string strSenha = txtSenha.Text.Trim();

            if (strLogin == String.Empty) { msgExclamacao("Informe o Usuário."); return; }
            if (txtSenha.Text.Trim() == String.Empty) { msgExclamacao("Informe a Senha."); return; }
            if (strLogin.Length < 3) { msgExclamacao("Login do Usuário muito curto."); return; }
            if (!strLogin.StartsWith("AUD") && strLogin != "PF00784291454") { msgExclamacao("Usuário não é auditor fiscal."); return; }            

            if (login(strLogin, strSenha))
            {
                exibirStatus(statusBar1, "Usuário autenticado");
                if (USUARIO_LOGADO_REMOTO)
                {
                    //Usuário logado remotamente
                    msgAtencao(string.Format("Bem-vindo, {0}", USUARIO_NOME));
                }
                else
                {
                    //Usuário logado localmente
                    msgExclamacao(string.Format("Bem-vindo, {0}{1}", USUARIO_NOME, (USUARIO_LOGADO_LOCAL ? "\nVocê está off-line (desconectado), portanto só poderá consultar à Base de dados local." : "")), "Bem-vindo");
                }                
                this.DialogResult = DialogResult.Yes;
            }            
        }

        #endregion        
        
    }
}