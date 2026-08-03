namespace umi.device
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lnkContribuinte = new System.Windows.Forms.LinkLabel();
            this.lnkNotasFiscais = new System.Windows.Forms.LinkLabel();
            this.lnkECF = new System.Windows.Forms.LinkLabel();
            this.lnkNFE = new System.Windows.Forms.LinkLabel();
            this.lnkPasses = new System.Windows.Forms.LinkLabel();
            this.picContribuinte = new System.Windows.Forms.PictureBox();
            this.picNotasFiscais = new System.Windows.Forms.PictureBox();
            this.picECF = new System.Windows.Forms.PictureBox();
            this.picNFE = new System.Windows.Forms.PictureBox();
            this.picPasses = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnkMonitor = new System.Windows.Forms.LinkLabel();
            this.picMonitor = new System.Windows.Forms.PictureBox();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItemOpcoes = new System.Windows.Forms.MenuItem();
            this.menuItemAjuda = new System.Windows.Forms.MenuItem();
            this.menuItemSobre = new System.Windows.Forms.MenuItem();
            this.menuItemAnotacoes = new System.Windows.Forms.MenuItem();
            this.menuItemLogoff = new System.Windows.Forms.MenuItem();
            this.menuItemSeparador1 = new System.Windows.Forms.MenuItem();
            this.menuItemSair = new System.Windows.Forms.MenuItem();
            this.timer1 = new System.Windows.Forms.Timer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkContribuinte
            // 
            this.lnkContribuinte.Location = new System.Drawing.Point(13, 55);
            this.lnkContribuinte.Name = "lnkContribuinte";
            this.lnkContribuinte.Size = new System.Drawing.Size(100, 20);
            this.lnkContribuinte.TabIndex = 0;
            this.lnkContribuinte.Text = "Contribuinte";
            this.lnkContribuinte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkContribuinte.Click += new System.EventHandler(this.lnkContribuinte_Click);
            // 
            // lnkNotasFiscais
            // 
            this.lnkNotasFiscais.Location = new System.Drawing.Point(116, 55);
            this.lnkNotasFiscais.Name = "lnkNotasFiscais";
            this.lnkNotasFiscais.Size = new System.Drawing.Size(100, 20);
            this.lnkNotasFiscais.TabIndex = 1;
            this.lnkNotasFiscais.Text = "Notas Fiscais";
            this.lnkNotasFiscais.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkNotasFiscais.Click += new System.EventHandler(this.lnkNotasFiscais_Click);
            // 
            // lnkECF
            // 
            this.lnkECF.Location = new System.Drawing.Point(13, 130);
            this.lnkECF.Name = "lnkECF";
            this.lnkECF.Size = new System.Drawing.Size(100, 20);
            this.lnkECF.TabIndex = 2;
            this.lnkECF.Text = "ECF";
            this.lnkECF.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkECF.Click += new System.EventHandler(this.lnkECF_Click);
            // 
            // lnkNFE
            // 
            this.lnkNFE.Location = new System.Drawing.Point(116, 130);
            this.lnkNFE.Name = "lnkNFE";
            this.lnkNFE.Size = new System.Drawing.Size(100, 20);
            this.lnkNFE.TabIndex = 3;
            this.lnkNFE.Text = "NF-e";
            this.lnkNFE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkNFE.Click += new System.EventHandler(this.lnkNFE_Click);
            // 
            // lnkPasses
            // 
            this.lnkPasses.Location = new System.Drawing.Point(116, 208);
            this.lnkPasses.Name = "lnkPasses";
            this.lnkPasses.Size = new System.Drawing.Size(100, 20);
            this.lnkPasses.TabIndex = 5;
            this.lnkPasses.Text = "Passes";
            this.lnkPasses.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkPasses.Click += new System.EventHandler(this.lnkPasses_Click);
            // 
            // picContribuinte
            // 
            this.picContribuinte.Image = ((System.Drawing.Image)(resources.GetObject("picContribuinte.Image")));
            this.picContribuinte.Location = new System.Drawing.Point(40, 7);
            this.picContribuinte.Name = "picContribuinte";
            this.picContribuinte.Size = new System.Drawing.Size(45, 51);
            this.picContribuinte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picContribuinte.Click += new System.EventHandler(this.picContribuinte_Click);
            // 
            // picNotasFiscais
            // 
            this.picNotasFiscais.Image = ((System.Drawing.Image)(resources.GetObject("picNotasFiscais.Image")));
            this.picNotasFiscais.Location = new System.Drawing.Point(142, 7);
            this.picNotasFiscais.Name = "picNotasFiscais";
            this.picNotasFiscais.Size = new System.Drawing.Size(45, 50);
            this.picNotasFiscais.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNotasFiscais.Click += new System.EventHandler(this.picNotasFiscais_Click);
            // 
            // picECF
            // 
            this.picECF.Image = ((System.Drawing.Image)(resources.GetObject("picECF.Image")));
            this.picECF.Location = new System.Drawing.Point(40, 85);
            this.picECF.Name = "picECF";
            this.picECF.Size = new System.Drawing.Size(45, 45);
            this.picECF.Click += new System.EventHandler(this.picECF_Click);
            // 
            // picNFE
            // 
            this.picNFE.Image = ((System.Drawing.Image)(resources.GetObject("picNFE.Image")));
            this.picNFE.Location = new System.Drawing.Point(142, 85);
            this.picNFE.Name = "picNFE";
            this.picNFE.Size = new System.Drawing.Size(45, 45);
            this.picNFE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNFE.Click += new System.EventHandler(this.picNFE_Click);
            // 
            // picPasses
            // 
            this.picPasses.Image = ((System.Drawing.Image)(resources.GetObject("picPasses.Image")));
            this.picPasses.Location = new System.Drawing.Point(136, 163);
            this.picPasses.Name = "picPasses";
            this.picPasses.Size = new System.Drawing.Size(62, 45);
            this.picPasses.Click += new System.EventHandler(this.picPasses_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lnkMonitor);
            this.panel1.Controls.Add(this.picPasses);
            this.panel1.Controls.Add(this.picContribuinte);
            this.panel1.Controls.Add(this.picNFE);
            this.panel1.Controls.Add(this.lnkContribuinte);
            this.panel1.Controls.Add(this.picNotasFiscais);
            this.panel1.Controls.Add(this.lnkPasses);
            this.panel1.Controls.Add(this.picMonitor);
            this.panel1.Controls.Add(this.lnkNFE);
            this.panel1.Controls.Add(this.lnkECF);
            this.panel1.Controls.Add(this.lnkNotasFiscais);
            this.panel1.Controls.Add(this.picECF);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 249);
            // 
            // lnkMonitor
            // 
            this.lnkMonitor.Location = new System.Drawing.Point(13, 208);
            this.lnkMonitor.Name = "lnkMonitor";
            this.lnkMonitor.Size = new System.Drawing.Size(100, 40);
            this.lnkMonitor.TabIndex = 4;
            this.lnkMonitor.Text = "Monitor do Sistema";
            this.lnkMonitor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkMonitor.Click += new System.EventHandler(this.lnkMonitor_Click);
            // 
            // picMonitor
            // 
            this.picMonitor.Image = ((System.Drawing.Image)(resources.GetObject("picMonitor.Image")));
            this.picMonitor.Location = new System.Drawing.Point(40, 158);
            this.picMonitor.Name = "picMonitor";
            this.picMonitor.Size = new System.Drawing.Size(45, 50);
            this.picMonitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMonitor.Click += new System.EventHandler(this.picMonitor_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 246);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(240, 22);
            this.statusBar1.Text = ":: off-line :: USUÁRIO";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemOpcoes);
            // 
            // menuItemOpcoes
            // 
            this.menuItemOpcoes.MenuItems.Add(this.menuItemAjuda);
            this.menuItemOpcoes.MenuItems.Add(this.menuItemAnotacoes);
            this.menuItemOpcoes.MenuItems.Add(this.menuItemLogoff);
            this.menuItemOpcoes.MenuItems.Add(this.menuItemSeparador1);
            this.menuItemOpcoes.MenuItems.Add(this.menuItemSair);
            this.menuItemOpcoes.Text = "&Opções";
            // 
            // menuItemAjuda
            // 
            this.menuItemAjuda.MenuItems.Add(this.menuItemSobre);
            this.menuItemAjuda.Text = "&Ajuda";
            // 
            // menuItemSobre
            // 
            this.menuItemSobre.Text = "&Sobre";
            this.menuItemSobre.Click += new System.EventHandler(this.menuItemSobre_Click);
            // 
            // menuItemAnotacoes
            // 
            this.menuItemAnotacoes.Text = "A&notações";
            this.menuItemAnotacoes.Click += new System.EventHandler(this.menuItemAnotacoes_Click);
            // 
            // menuItemLogoff
            // 
            this.menuItemLogoff.Text = "&Logoff";
            this.menuItemLogoff.Click += new System.EventHandler(this.menuItemLogoff_Click);
            // 
            // menuItemSeparador1
            // 
            this.menuItemSeparador1.Text = "-";
            // 
            // menuItemSair
            // 
            this.menuItemSair.Text = "&Sair";
            this.menuItemSair.Click += new System.EventHandler(this.menuItemSair_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.panel1);
            this.Menu = this.mainMenu1;
            this.Name = "frmPrincipal";
            this.Text = "UMI - Menu Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkContribuinte;
        private System.Windows.Forms.LinkLabel lnkNotasFiscais;
        private System.Windows.Forms.LinkLabel lnkECF;
        private System.Windows.Forms.LinkLabel lnkNFE;
        private System.Windows.Forms.LinkLabel lnkPasses;
        private System.Windows.Forms.PictureBox picContribuinte;
        private System.Windows.Forms.PictureBox picNotasFiscais;
        private System.Windows.Forms.PictureBox picECF;
        private System.Windows.Forms.PictureBox picNFE;
        private System.Windows.Forms.PictureBox picPasses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picMonitor;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.LinkLabel lnkMonitor;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItemOpcoes;
        private System.Windows.Forms.MenuItem menuItemAjuda;
        private System.Windows.Forms.MenuItem menuItemSobre;
        private System.Windows.Forms.MenuItem menuItemAnotacoes;
        private System.Windows.Forms.MenuItem menuItemLogoff;
        private System.Windows.Forms.MenuItem menuItemSeparador1;
        private System.Windows.Forms.MenuItem menuItemSair;
        private System.Windows.Forms.Timer timer1;
    }
}