using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umi.device.business;
using Microsoft.WindowsMobile.PocketOutlook;

namespace umi.device
{
    public partial class frmContatos : frmBusiness
    {
        OutlookSession session = null;

        #region Construtor

        public frmContatos()
        {
            InitializeComponent();

            try
            {
                session = new OutlookSession();
            }
            catch (Exception ex)
            {
                msgAtencao(ex.Message);
            }
        }

        #endregion

        #region Eventos

        private void menuItemSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItemSIM_Click(object sender, EventArgs e)
        {
            
        }        

        private void menuItemContSmart_Click(object sender, EventArgs e)
        {
            try
            {                
                Cursor.Current = Cursors.WaitCursor;
                exibirStatus(statusBar1, "Carregando Contatos do Smartphone...");
                listarContatosSmartPhone();
            }
            catch (Exception ex)
            {
                msgAtencao(ex.Message);
            }
            finally
            {
                exibirStatus(statusBar1, "Número de Contatos" + session.Contacts.Items.Count);
                Cursor.Current = Cursors.Default;
            }
        }        

        private void menuItemExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (msgPergunta("Apagar contatos selecionados?", "Confirmação"))
                {
                    Cursor.Current = Cursors.WaitCursor;
                    exibirStatus(statusBar1, "Apagando contatos...");
                    deletarSelecionados();
                }
            }
            catch (Exception ex)
            {
                msgAtencao(ex.Message);
            }
            finally
            {
                exibirStatus(statusBar1, "");
                Cursor.Current = Cursors.Default;
            }
        }        

        private void menuItemDescSelec_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                exibirStatus(statusBar1, "Descartando seleção...");
                selecionarTodos(false);
            }
            catch (Exception ex)
            {
                msgAtencao(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                exibirStatus(statusBar1, "");
            }
        }

        private void menuItemSelecTodos_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                exibirStatus(statusBar1, "Selecionando todos...");
                selecionarTodos(true);
            }
            catch (Exception ex)
            {
                msgAtencao(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                exibirStatus(statusBar1, "");
            }
        }

        #endregion

        #region Métodos

        private void listarContatosSmartPhone()
        {
            ListViewItem item = null;
            if (session != null)
            {
                //ContactCollection contact = null;
                
                foreach (Contact cont in session.Contacts.Items)
                {
                    /*contact = cont;
                    //atualiza o telefone do campo Sala para o campo Telefone
                    if (contact.BusinessTelephoneNumber == string.Empty)
                    {
                        contact.BusinessTelephoneNumber = contact.OfficeLocation;
                        contact.Update();
                    }*/

                    //Adiciona o telefone à lista
                    item = new ListViewItem(new string[] {                         
                        cont.FirstName + " " + cont.LastName, 
                        cont.BusinessTelephoneNumber + ", " + cont.Business2TelephoneNumber });
                    item.Checked = true;
                    lstContatos.Items.Add(item);
                }                
            }
            else
            {
                msgExclamacao("Nenhum contato na lista.");
            }
        }

        private void deletarSelecionados()
        {
            foreach (ListViewItem item in lstContatos.Items)
            {
                if (item.Checked) session.Contacts.Items[item.Index].Delete();
            }
        }

        private void selecionarTodos(bool check)
        {
            foreach (ListViewItem item in lstContatos.Items)
            {
                item.Checked = check;
            }
        }        

        #endregion

        private void frmContatos_Closing(object sender, CancelEventArgs e)
        {
            if(session != null)
                session.Dispose();
        }
    }
}