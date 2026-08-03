namespace umi.device
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItemSair = new System.Windows.Forms.MenuItem();
            this.lblUMITitulo = new System.Windows.Forms.Label();
            this.imgCarro = new System.Windows.Forms.PictureBox();
            this.lblERP = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.imgChaves = new System.Windows.Forms.PictureBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.menuItemEntrar = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemSair);
            this.mainMenu1.MenuItems.Add(this.menuItemEntrar);
            // 
            // menuItemSair
            // 
            this.menuItemSair.Text = "&Sair";
            this.menuItemSair.Click += new System.EventHandler(this.menuItemSair_Click);
            // 
            // lblUMITitulo
            // 
            this.lblUMITitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUMITitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblUMITitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUMITitulo.Location = new System.Drawing.Point(9, 4);
            this.lblUMITitulo.Name = "lblUMITitulo";
            this.lblUMITitulo.Size = new System.Drawing.Size(222, 20);
            this.lblUMITitulo.Text = "Unidade M�vel Informatizada";
            this.lblUMITitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imgCarro
            // 
            this.imgCarro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCarro.Image = ((System.Drawing.Image)(resources.GetObject("imgCarro.Image")));
            this.imgCarro.Location = new System.Drawing.Point(6, 24);
            this.imgCarro.Name = "imgCarro";
            this.imgCarro.Size = new System.Drawing.Size(229, 84);
            this.imgCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // lblERP
            // 
            this.lblERP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblERP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblERP.ForeColor = System.Drawing.Color.DimGray;
            this.lblERP.Location = new System.Drawing.Point(63, 121);
            this.lblERP.Name = "lblERP";
            this.lblERP.Size = new System.Drawing.Size(114, 18);
            this.lblERP.Text = "LOGIN - ERP";
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.Location = new System.Drawing.Point(60, 166);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(120, 21);
            this.txtSenha.TabIndex = 8;
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin.Location = new System.Drawing.Point(60, 143);
            this.txtLogin.MaxLength = 50;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(120, 21);
            this.txtLogin.TabIndex = 7;
            // 
            // imgChaves
            // 
            this.imgChaves.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.imgChaves.Image = ((System.Drawing.Image)(resources.GetObject("imgChaves.Image")));
            this.imgChaves.Location = new System.Drawing.Point(186, 140);
            this.imgChaves.Name = "imgChaves";
            this.imgChaves.Size = new System.Drawing.Size(45, 45);
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSenha.Location = new System.Drawing.Point(5, 166);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(50, 17);
            this.lblSenha.Text = "Senha:";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.Location = new System.Drawing.Point(5, 145);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 17);
            this.lblUsuario.Text = "Usu�rio:";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 246);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(240, 22);
            // 
            // menuItemEntrar
            // 
            this.menuItemEntrar.Text = "&Entrar";
            this.menuItemEntrar.Click += new System.EventHandler(this.menuItemEntrar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.imgChaves);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblERP);
            this.Controls.Add(this.imgCarro);
            this.Controls.Add(this.lblUMITitulo);
            this.Menu = this.mainMenu1;
            this.Name = "frmLogin";
            this.Text = "UMI - Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUMITitulo;
        private System.Windows.Forms.PictureBox imgCarro;
        private System.Windows.Forms.Label lblERP;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.PictureBox imgChaves;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.MenuItem menuItemSair;
        private System.Windows.Forms.MenuItem menuItemEntrar;
    }
}