namespace umi.device
{
    partial class frmNotaFiscalEletronica
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
            this.menuItemProcurar = new System.Windows.Forms.MenuItem();
            this.lstNFe = new System.Windows.Forms.ListView();
            this.colCampo = new System.Windows.Forms.ColumnHeader();
            this.colValor = new System.Windows.Forms.ColumnHeader();
            this.txtCincoUltDig = new System.Windows.Forms.TextBox();
            this.txtNumNF = new System.Windows.Forms.TextBox();
            this.txtCNPJEmit = new System.Windows.Forms.TextBox();
            this.lbl5ultimdig = new System.Windows.Forms.Label();
            this.lblCNPJEmit = new System.Windows.Forms.Label();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.lblNumNF = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemVoltar);
            this.mainMenu1.MenuItems.Add(this.menuItemProcurar);
            // 
            // menuItemVoltar
            // 
            this.menuItemVoltar.Text = "&Voltar";
            this.menuItemVoltar.Click += new System.EventHandler(this.menuItemVoltar_Click);
            // 
            // menuItemProcurar
            // 
            this.menuItemProcurar.Text = "&Procurar";
            this.menuItemProcurar.Click += new System.EventHandler(this.menuItemProcurar_Click);
            // 
            // lstNFe
            // 
            this.lstNFe.Columns.Add(this.colCampo);
            this.lstNFe.Columns.Add(this.colValor);
            this.lstNFe.FullRowSelect = true;
            this.lstNFe.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstNFe.Location = new System.Drawing.Point(0, 74);
            this.lstNFe.Name = "lstNFe";
            this.lstNFe.Size = new System.Drawing.Size(240, 150);
            this.lstNFe.TabIndex = 15;
            this.lstNFe.View = System.Windows.Forms.View.Details;
            this.lstNFe.Visible = false;
            // 
            // colCampo
            // 
            this.colCampo.Text = "";
            this.colCampo.Width = 80;
            // 
            // colValor
            // 
            this.colValor.Text = "";
            this.colValor.Width = 220;
            // 
            // txtCincoUltDig
            // 
            this.txtCincoUltDig.Location = new System.Drawing.Point(130, 48);
            this.txtCincoUltDig.MaxLength = 5;
            this.txtCincoUltDig.Name = "txtCincoUltDig";
            this.txtCincoUltDig.Size = new System.Drawing.Size(108, 21);
            this.txtCincoUltDig.TabIndex = 14;
            // 
            // txtNumNF
            // 
            this.txtNumNF.Location = new System.Drawing.Point(130, 25);
            this.txtNumNF.MaxLength = 15;
            this.txtNumNF.Name = "txtNumNF";
            this.txtNumNF.Size = new System.Drawing.Size(108, 21);
            this.txtNumNF.TabIndex = 13;
            // 
            // txtCNPJEmit
            // 
            this.txtCNPJEmit.Location = new System.Drawing.Point(130, 2);
            this.txtCNPJEmit.MaxLength = 14;
            this.txtCNPJEmit.Name = "txtCNPJEmit";
            this.txtCNPJEmit.Size = new System.Drawing.Size(108, 21);
            this.txtCNPJEmit.TabIndex = 12;
            // 
            // lbl5ultimdig
            // 
            this.lbl5ultimdig.Location = new System.Drawing.Point(5, 45);
            this.lbl5ultimdig.Name = "lbl5ultimdig";
            this.lbl5ultimdig.Size = new System.Drawing.Size(125, 30);
            this.lbl5ultimdig.Text = "5 últimos dígitos\r\nda chave de acesso:";
            // 
            // lblCNPJEmit
            // 
            this.lblCNPJEmit.Location = new System.Drawing.Point(5, 4);
            this.lblCNPJEmit.Name = "lblCNPJEmit";
            this.lblCNPJEmit.Size = new System.Drawing.Size(100, 16);
            this.lblCNPJEmit.Text = "CNPJ Emitente:";
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 246);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(240, 22);
            // 
            // lblNumNF
            // 
            this.lblNumNF.Location = new System.Drawing.Point(5, 27);
            this.lblNumNF.Name = "lblNumNF";
            this.lblNumNF.Size = new System.Drawing.Size(100, 16);
            this.lblNumNF.Text = "Número da Nota:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblSituacao.Location = new System.Drawing.Point(5, 226);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(229, 17);
            // 
            // frmNotaFiscalEletronica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.lstNFe);
            this.Controls.Add(this.txtCincoUltDig);
            this.Controls.Add(this.txtNumNF);
            this.Controls.Add(this.txtCNPJEmit);
            this.Controls.Add(this.lbl5ultimdig);
            this.Controls.Add(this.lblNumNF);
            this.Controls.Add(this.lblCNPJEmit);
            this.Menu = this.mainMenu1;
            this.Name = "frmNotaFiscalEletronica";
            this.Text = "UMI - NF-e";
            this.Load += new System.EventHandler(this.frmNotaFiscalEletronica_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemVoltar;
        private System.Windows.Forms.MenuItem menuItemProcurar;
        private System.Windows.Forms.ListView lstNFe;
        private System.Windows.Forms.ColumnHeader colCampo;
        private System.Windows.Forms.ColumnHeader colValor;
        private System.Windows.Forms.TextBox txtCincoUltDig;
        private System.Windows.Forms.TextBox txtNumNF;
        private System.Windows.Forms.TextBox txtCNPJEmit;
        private System.Windows.Forms.Label lbl5ultimdig;
        private System.Windows.Forms.Label lblCNPJEmit;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.Label lblNumNF;
        private System.Windows.Forms.Label lblSituacao;
    }
}