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
    public partial class frmDetalharListViewItem : frmBusiness
    {
        #region Construtor

        public frmDetalharListViewItem(ListViewItem it)
        {
            InitializeComponent();
            
            lblDadoNome.Text = it.SubItems[0].Text;
            txtValor.Text = it.SubItems[1].Text;
            statusBar1.Text = STATUSBAR_TEXTO_PADRAO;
        }

        #endregion

        #region Eventos

        private void menuItemVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}