namespace umi.device
{
    partial class frmAtualizarBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtualizarBase));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItemVoltar = new System.Windows.Forms.MenuItem();
            this.menuItemAtualizar = new System.Windows.Forms.MenuItem();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblResultados = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNumRegBase = new System.Windows.Forms.Label();
            this.lblNumRegBaseTit = new System.Windows.Forms.Label();
            this.lblNumRegAtual = new System.Windows.Forms.Label();
            this.lblNumRegAtualTit = new System.Windows.Forms.Label();
            this.lblProgresso = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.picAjuda = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemVoltar);
            this.mainMenu1.MenuItems.Add(this.menuItemAtualizar);
            // 
            // menuItemVoltar
            // 
            this.menuItemVoltar.Text = "&Voltar";
            this.menuItemVoltar.Click += new System.EventHandler(this.menuItemVoltar_Click);
            // 
            // menuItemAtualizar
            // 
            this.menuItemAtualizar.Text = "&Atualizar";
            this.menuItemAtualizar.Click += new System.EventHandler(this.menuItemAtualizar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.BackColor = System.Drawing.Color.White;
            this.txtDescricao.Location = new System.Drawing.Point(37, 3);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(199, 78);
            this.txtDescricao.TabIndex = 5;
            this.txtDescricao.Text = "Este procedimento atualizará a Base de Dados Local com os dados recuperados da úl" +
                "tima consulta de contribuintes, e não depende de conexão com a Internet.";
            // 
            // lblResultados
            // 
            this.lblResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblResultados.Location = new System.Drawing.Point(1, 104);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(166, 20);
            this.lblResultados.Text = "Informações da Atualização";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 53);
            // 
            // lblNumRegBase
            // 
            this.lblNumRegBase.Location = new System.Drawing.Point(185, 141);
            this.lblNumRegBase.Name = "lblNumRegBase";
            this.lblNumRegBase.Size = new System.Drawing.Size(50, 17);
            this.lblNumRegBase.Text = "0";
            // 
            // lblNumRegBaseTit
            // 
            this.lblNumRegBaseTit.Location = new System.Drawing.Point(1, 141);
            this.lblNumRegBaseTit.Name = "lblNumRegBaseTit";
            this.lblNumRegBaseTit.Size = new System.Drawing.Size(181, 17);
            this.lblNumRegBaseTit.Text = "Número de registros na base:";
            // 
            // lblNumRegAtual
            // 
            this.lblNumRegAtual.Location = new System.Drawing.Point(185, 162);
            this.lblNumRegAtual.Name = "lblNumRegAtual";
            this.lblNumRegAtual.Size = new System.Drawing.Size(50, 17);
            this.lblNumRegAtual.Text = "0";
            // 
            // lblNumRegAtualTit
            // 
            this.lblNumRegAtualTit.Location = new System.Drawing.Point(1, 162);
            this.lblNumRegAtualTit.Name = "lblNumRegAtualTit";
            this.lblNumRegAtualTit.Size = new System.Drawing.Size(181, 17);
            this.lblNumRegAtualTit.Text = "Número de registros a atualizar:";
            // 
            // lblProgresso
            // 
            this.lblProgresso.Location = new System.Drawing.Point(185, 182);
            this.lblProgresso.Name = "lblProgresso";
            this.lblProgresso.Size = new System.Drawing.Size(50, 20);
            this.lblProgresso.Text = "0%";
            this.lblProgresso.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1, 182);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(165, 20);
            this.progressBar1.Visible = false;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 246);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(240, 22);
            // 
            // picAjuda
            // 
            this.picAjuda.Image = ((System.Drawing.Image)(resources.GetObject("picAjuda.Image")));
            this.picAjuda.Location = new System.Drawing.Point(2, 3);
            this.picAjuda.Name = "picAjuda";
            this.picAjuda.Size = new System.Drawing.Size(32, 32);
            // 
            // frmAtualizarBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.picAjuda);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.lblProgresso);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblNumRegBase);
            this.Controls.Add(this.lblNumRegBaseTit);
            this.Controls.Add(this.lblNumRegAtual);
            this.Controls.Add(this.lblNumRegAtualTit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.txtDescricao);
            this.Menu = this.mainMenu1;
            this.Name = "frmAtualizarBase";
            this.Text = "UMI - Atualizar Base Local";
            this.Load += new System.EventHandler(this.frmAtualizarBase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNumRegBase;
        private System.Windows.Forms.Label lblNumRegBaseTit;
        private System.Windows.Forms.Label lblNumRegAtual;
        private System.Windows.Forms.Label lblNumRegAtualTit;
        private System.Windows.Forms.Label lblProgresso;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.MenuItem menuItemVoltar;
        private System.Windows.Forms.PictureBox picAjuda;
        private System.Windows.Forms.MenuItem menuItemAtualizar;
    }
}