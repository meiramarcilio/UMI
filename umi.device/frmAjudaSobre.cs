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
    public partial class frmAjudaSobre : frmBusiness
    {
        public frmAjudaSobre()
        {
            InitializeComponent();
        }

        private void frmAjudaSobre_Load(object sender, EventArgs e)
        {
            try
            {
                lblVersao.Text = lerVersao();
                statusBar1.Text = STATUSBAR_TEXTO_PADRAO;
            }
            catch (Exception)
            {
                lblVersao.Text = "Impossível determinar a versão.";
            }
        }

        private void menuItemVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}