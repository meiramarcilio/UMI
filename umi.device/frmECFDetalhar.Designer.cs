namespace umi.device
{
    partial class frmECFDetalhar
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
            this.lblInfoEquipTit = new System.Windows.Forms.Label();
            this.lstDetalhes = new System.Windows.Forms.ListView();
            this.lstDetalhesColDado = new System.Windows.Forms.ColumnHeader();
            this.lstDetalhesColValor = new System.Windows.Forms.ColumnHeader();
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
            // lblInfoEquipTit
            // 
            this.lblInfoEquipTit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfoEquipTit.Location = new System.Drawing.Point(0, 0);
            this.lblInfoEquipTit.Name = "lblInfoEquipTit";
            this.lblInfoEquipTit.Size = new System.Drawing.Size(190, 16);
            this.lblInfoEquipTit.Text = "Informações do Equipamento";
            // 
            // lstDetalhes
            // 
            this.lstDetalhes.Columns.Add(this.lstDetalhesColDado);
            this.lstDetalhes.Columns.Add(this.lstDetalhesColValor);
            this.lstDetalhes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstDetalhes.FullRowSelect = true;
            this.lstDetalhes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstDetalhes.Location = new System.Drawing.Point(0, 18);
            this.lstDetalhes.Name = "lstDetalhes";
            this.lstDetalhes.Size = new System.Drawing.Size(240, 250);
            this.lstDetalhes.TabIndex = 2;
            this.lstDetalhes.View = System.Windows.Forms.View.Details;
            // 
            // lstDetalhesColDado
            // 
            this.lstDetalhesColDado.Text = "Dado";
            this.lstDetalhesColDado.Width = 100;
            // 
            // lstDetalhesColValor
            // 
            this.lstDetalhesColValor.Text = "Valor";
            this.lstDetalhesColValor.Width = 350;
            // 
            // frmECFDetalhar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.lstDetalhes);
            this.Controls.Add(this.lblInfoEquipTit);
            this.Menu = this.mainMenu1;
            this.Name = "frmECFDetalhar";
            this.Text = "UMI - ECF Detalhado";
            this.Load += new System.EventHandler(this.frmECFDetalhar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemVoltar;
        private System.Windows.Forms.Label lblInfoEquipTit;
        private System.Windows.Forms.ListView lstDetalhes;
        private System.Windows.Forms.ColumnHeader lstDetalhesColDado;
        private System.Windows.Forms.ColumnHeader lstDetalhesColValor;
    }
}