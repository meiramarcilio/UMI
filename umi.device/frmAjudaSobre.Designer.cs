namespace umi.device
{
    partial class frmAjudaSobre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItemVoltar = new System.Windows.Forms.MenuItem();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblVersaoTit = new System.Windows.Forms.Label();
            this.lblCODIN = new System.Windows.Forms.Label();
            this.lblSET = new System.Windows.Forms.Label();
            this.lblUMI = new System.Windows.Forms.Label();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemVoltar);
            // 
            // menuItemVoltar
            // 
            this.menuItemVoltar.Text = "&Voltar";
            this.menuItemVoltar.Click += new System.EventHandler(this.menuItemVoltar_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.Location = new System.Drawing.Point(56, 93);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(100, 16);
            this.lblVersao.Text = "[versão atual]";
            // 
            // lblVersaoTit
            // 
            this.lblVersaoTit.Location = new System.Drawing.Point(2, 93);
            this.lblVersaoTit.Name = "lblVersaoTit";
            this.lblVersaoTit.Size = new System.Drawing.Size(46, 16);
            this.lblVersaoTit.Text = "versão:";
            // 
            // lblCODIN
            // 
            this.lblCODIN.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblCODIN.Location = new System.Drawing.Point(2, 20);
            this.lblCODIN.Name = "lblCODIN";
            this.lblCODIN.Size = new System.Drawing.Size(223, 16);
            this.lblCODIN.Text = "Coordenadoria de Informática - CODIN";
            // 
            // lblSET
            // 
            this.lblSET.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblSET.Location = new System.Drawing.Point(2, 3);
            this.lblSET.Name = "lblSET";
            this.lblSET.Size = new System.Drawing.Size(237, 16);
            this.lblSET.Text = "Secretaria de Estado da Tributação - RN";
            // 
            // lblUMI
            // 
            this.lblUMI.Location = new System.Drawing.Point(2, 74);
            this.lblUMI.Name = "lblUMI";
            this.lblUMI.Size = new System.Drawing.Size(226, 16);
            this.lblUMI.Text = "Unidade Móvel Informatizada - UMI";
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 246);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(240, 22);
            // 
            // frmAjudaSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lblVersaoTit);
            this.Controls.Add(this.lblCODIN);
            this.Controls.Add(this.lblSET);
            this.Controls.Add(this.lblUMI);
            this.Menu = this.mainMenu1;
            this.Name = "frmAjudaSobre";
            this.Text = "UMI - Sobre o Programa";
            this.Load += new System.EventHandler(this.frmAjudaSobre_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblVersaoTit;
        private System.Windows.Forms.Label lblCODIN;
        private System.Windows.Forms.Label lblSET;
        private System.Windows.Forms.Label lblUMI;
        private System.Windows.Forms.MenuItem menuItemVoltar;
        private System.Windows.Forms.StatusBar statusBar1;
    }
}