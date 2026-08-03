namespace umi.device
{
    partial class frmContribuinteBusca
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContribuinteBusca));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItemOpcoes = new System.Windows.Forms.MenuItem();
            this.menuItemAtualizarBase = new System.Windows.Forms.MenuItem();
            this.menuItemVoltar = new System.Windows.Forms.MenuItem();
            this.menuItemProcurar = new System.Windows.Forms.MenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cbbTipoBusca = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.picbConexao = new System.Windows.Forms.PictureBox();
            this.contribuinteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgResultados = new System.Windows.Forms.DataGrid();
            this.dgResultadoStyle = new System.Windows.Forms.DataGridTableStyle();
            this.dgResultColInscricao = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgResultColCNPJ = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgResultColRazaoSocial = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgResultColSituacao = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgResultColAtualizado = new System.Windows.Forms.DataGridTextBoxColumn();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemOpcoes);
            this.mainMenu1.MenuItems.Add(this.menuItemProcurar);
            // 
            // menuItemOpcoes
            // 
            this.menuItemOpcoes.MenuItems.Add(this.menuItemAtualizarBase);
            this.menuItemOpcoes.MenuItems.Add(this.menuItemVoltar);
            this.menuItemOpcoes.Text = "&Opcoes";
            // 
            // menuItemAtualizarBase
            // 
            this.menuItemAtualizarBase.Text = "&Atualizar Base Local";
            this.menuItemAtualizarBase.Click += new System.EventHandler(this.menuItemAtualizarBase_Click);
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
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(170, 16);
            this.lblTitulo.Text = "Consulta de Contribuintes";
            // 
            // lblValor
            // 
            this.lblValor.Location = new System.Drawing.Point(0, 41);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(78, 17);
            this.lblValor.Text = "Procurar por:";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCriterio
            // 
            this.lblCriterio.Location = new System.Drawing.Point(9, 20);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(69, 17);
            this.lblCriterio.Text = "Critério:";
            this.lblCriterio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbbTipoBusca
            // 
            this.cbbTipoBusca.Items.Add("Inscrição Estadual");
            this.cbbTipoBusca.Items.Add("CNPJ");
            this.cbbTipoBusca.Items.Add("CNPJ Base");
            this.cbbTipoBusca.Items.Add("CPF Sócio");
            this.cbbTipoBusca.Location = new System.Drawing.Point(80, 17);
            this.cbbTipoBusca.Name = "cbbTipoBusca";
            this.cbbTipoBusca.Size = new System.Drawing.Size(124, 22);
            this.cbbTipoBusca.TabIndex = 8;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(80, 39);
            this.txtFiltro.MaxLength = 100;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(124, 21);
            this.txtFiltro.TabIndex = 4;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 246);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(240, 22);
            // 
            // picbConexao
            // 
            this.picbConexao.Image = ((System.Drawing.Image)(resources.GetObject("picbConexao.Image")));
            this.picbConexao.Location = new System.Drawing.Point(205, 19);
            this.picbConexao.Name = "picbConexao";
            this.picbConexao.Size = new System.Drawing.Size(35, 35);
            // 
            // contribuinteBindingSource
            // 
            this.contribuinteBindingSource.DataSource = typeof(umi.device.wsumi.Contribuinte);
            // 
            // dgResultados
            // 
            this.dgResultados.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgResultados.DataSource = this.contribuinteBindingSource;
            this.dgResultados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgResultados.Location = new System.Drawing.Point(0, 61);
            this.dgResultados.Name = "dgResultados";
            this.dgResultados.RowHeadersVisible = false;
            this.dgResultados.Size = new System.Drawing.Size(240, 185);
            this.dgResultados.TabIndex = 13;
            this.dgResultados.TableStyles.Add(this.dgResultadoStyle);
            this.dgResultados.DoubleClick += new System.EventHandler(this.dgResultados_DoubleClick);
            // 
            // dgResultadoStyle
            // 
            this.dgResultadoStyle.GridColumnStyles.Add(this.dgResultColInscricao);
            this.dgResultadoStyle.GridColumnStyles.Add(this.dgResultColCNPJ);
            this.dgResultadoStyle.GridColumnStyles.Add(this.dgResultColRazaoSocial);
            this.dgResultadoStyle.GridColumnStyles.Add(this.dgResultColSituacao);
            this.dgResultadoStyle.GridColumnStyles.Add(this.dgResultColAtualizado);
            this.dgResultadoStyle.MappingName = "Contribuinte";
            // 
            // dgResultColInscricao
            // 
            this.dgResultColInscricao.Format = "";
            this.dgResultColInscricao.HeaderText = "Insc. Estadual";
            this.dgResultColInscricao.MappingName = "INSCRICAO_ESTADUAL";
            this.dgResultColInscricao.Width = 85;
            // 
            // dgResultColCNPJ
            // 
            this.dgResultColCNPJ.Format = "00\\.000\\.000\\/0000-00";
            this.dgResultColCNPJ.HeaderText = "CNPJ";
            this.dgResultColCNPJ.MappingName = "NU_CNPJ";
            this.dgResultColCNPJ.Width = 90;
            // 
            // dgResultColRazaoSocial
            // 
            this.dgResultColRazaoSocial.Format = "";
            this.dgResultColRazaoSocial.HeaderText = "Razão Social";
            this.dgResultColRazaoSocial.MappingName = "NM_FORMAL";
            this.dgResultColRazaoSocial.Width = 120;
            // 
            // dgResultColSituacao
            // 
            this.dgResultColSituacao.Format = "";
            this.dgResultColSituacao.HeaderText = "Situação";
            this.dgResultColSituacao.MappingName = "SITUACAO";
            // 
            // dgResultColAtualizado
            // 
            this.dgResultColAtualizado.Format = "";
            this.dgResultColAtualizado.HeaderText = "Atualizado";
            this.dgResultColAtualizado.MappingName = "DT_ULTIMA_ATUALIZACAO";
            this.dgResultColAtualizado.Width = 80;
            // 
            // frmContribuinteBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.dgResultados);
            this.Controls.Add(this.picbConexao);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cbbTipoBusca);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblTitulo);
            this.Menu = this.mainMenu1;
            this.Name = "frmContribuinteBusca";
            this.Text = "UMI - Consulta Contribuintes";
            this.Load += new System.EventHandler(this.frmContribuinteBusca_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cbbTipoBusca;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.PictureBox picbConexao;
        private System.Windows.Forms.DataGrid dgResultados;
        private System.Windows.Forms.BindingSource contribuinteBindingSource;
        private System.Windows.Forms.MenuItem menuItemOpcoes;
        private System.Windows.Forms.MenuItem menuItemAtualizarBase;
        private System.Windows.Forms.MenuItem menuItemVoltar;
        private System.Windows.Forms.MenuItem menuItemProcurar;
        private System.Windows.Forms.DataGridTableStyle dgResultadoStyle;
        private System.Windows.Forms.DataGridTextBoxColumn dgResultColInscricao;
        private System.Windows.Forms.DataGridTextBoxColumn dgResultColRazaoSocial;
        private System.Windows.Forms.DataGridTextBoxColumn dgResultColSituacao;
        private System.Windows.Forms.DataGridTextBoxColumn dgResultColCNPJ;
        private System.Windows.Forms.DataGridTextBoxColumn dgResultColAtualizado;
    }
}