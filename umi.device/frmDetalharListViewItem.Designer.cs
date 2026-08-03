namespace umi.device
{
    partial class frmDetalharListViewItem
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
            this.lblDadoNome = new System.Windows.Forms.Label();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.txtValor = new System.Windows.Forms.TextBox();
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
            // lblDadoNome
            // 
            this.lblDadoNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDadoNome.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblDadoNome.Location = new System.Drawing.Point(0, 0);
            this.lblDadoNome.Name = "lblDadoNome";
            this.lblDadoNome.Size = new System.Drawing.Size(240, 20);
            this.lblDadoNome.Text = "Dado";
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 246);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(240, 22);
            // 
            // txtValor
            // 
            this.txtValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtValor.Location = new System.Drawing.Point(0, 20);
            this.txtValor.Multiline = true;
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(240, 226);
            this.txtValor.TabIndex = 3;
            // 
            // frmDetalharListViewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.lblDadoNome);
            this.Menu = this.mainMenu1;
            this.Name = "frmDetalharListViewItem";
            this.Text = "UMI - Detalhe de Informações";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemVoltar;
        private System.Windows.Forms.Label lblDadoNome;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.TextBox txtValor;
    }
}