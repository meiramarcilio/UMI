namespace umi.device
{
    partial class frmNotaFiscalDetalhar
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
            this.lblNFDetalheTit = new System.Windows.Forms.Label();
            this.lstNFDetalhes = new System.Windows.Forms.ListView();
            this.menuItemVoltar = new System.Windows.Forms.MenuItem();
            this.lstNFDetalhDado = new System.Windows.Forms.ColumnHeader();
            this.lstNFDetalhValor = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemVoltar);
            // 
            // lblNFDetalheTit
            // 
            this.lblNFDetalheTit.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNFDetalheTit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblNFDetalheTit.Location = new System.Drawing.Point(0, 0);
            this.lblNFDetalheTit.Name = "lblNFDetalheTit";
            this.lblNFDetalheTit.Size = new System.Drawing.Size(240, 16);
            this.lblNFDetalheTit.Text = "Detalhes da Nota Fiscal";
            // 
            // lstNFDetalhes
            // 
            this.lstNFDetalhes.Columns.Add(this.lstNFDetalhDado);
            this.lstNFDetalhes.Columns.Add(this.lstNFDetalhValor);
            this.lstNFDetalhes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstNFDetalhes.FullRowSelect = true;
            this.lstNFDetalhes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstNFDetalhes.Location = new System.Drawing.Point(0, 18);
            this.lstNFDetalhes.Name = "lstNFDetalhes";
            this.lstNFDetalhes.Size = new System.Drawing.Size(240, 250);
            this.lstNFDetalhes.TabIndex = 2;
            this.lstNFDetalhes.View = System.Windows.Forms.View.Details;
            // 
            // menuItemVoltar
            // 
            this.menuItemVoltar.Text = "&Voltar";
            this.menuItemVoltar.Click += new System.EventHandler(this.menuItemVoltar_Click);
            // 
            // lstNFDetalhDado
            // 
            this.lstNFDetalhDado.Text = "Dado";
            this.lstNFDetalhDado.Width = 150;
            // 
            // lstNFDetalhValor
            // 
            this.lstNFDetalhValor.Text = "Valor";
            this.lstNFDetalhValor.Width = 300;
            // 
            // frmNotaFiscalDetalhar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.lstNFDetalhes);
            this.Controls.Add(this.lblNFDetalheTit);
            this.Menu = this.mainMenu1;
            this.Name = "frmNotaFiscalDetalhar";
            this.Text = "Nota Fiscal";
            this.Load += new System.EventHandler(this.frmNotaFiscalDetalhar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemVoltar;
        private System.Windows.Forms.Label lblNFDetalheTit;
        private System.Windows.Forms.ListView lstNFDetalhes;
        private System.Windows.Forms.ColumnHeader lstNFDetalhDado;
        private System.Windows.Forms.ColumnHeader lstNFDetalhValor;
    }
}