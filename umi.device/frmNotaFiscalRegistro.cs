using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace umi.device
{
    public partial class frmNotaFiscalRegistro : Form
    {
        public frmNotaFiscalRegistro()
        {
            InitializeComponent();
        }

        private void menuItemVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}