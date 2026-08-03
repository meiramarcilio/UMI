namespace umi.device
{
    partial class frmECF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmECF));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItemVoltar = new System.Windows.Forms.MenuItem();
            this.menuItemProcurar = new System.Windows.Forms.MenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblECFTit = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cbbCriterio = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgECFEquipamentos = new System.Windows.Forms.DataGrid();
            this.dgECFEquipStyle = new System.Windows.Forms.DataGridTableStyle();
            this.dgECFColCaixa = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgECFColSerie = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgECFColEquip = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgECFColModelo = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgECFColSituacao = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgECFColInscricaoEstadual = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgECFColRazaoSocial = new System.Windows.Forms.DataGridTextBoxColumn();
            this.ECFEquipamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ECFLacreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgECFEquipLacreStyle = new System.Windows.Forms.DataGridTableStyle();
            this.dgECFLacreColNumero = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgECFLacreColDataInc = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgECFLacreColCodUsuInc = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgECFLacreColDataBaixa = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgECFLacreColCodUsuBaixa = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgECFLacreColDataCancel = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgECFLacreColCodUsuCanc = new System.Windows.Forms.DataGridTextBoxColumn();
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
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 246);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(240, 22);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(194, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            // 
            // lblECFTit
            // 
            this.lblECFTit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblECFTit.Location = new System.Drawing.Point(0, 0);
            this.lblECFTit.Name = "lblECFTit";
            this.lblECFTit.Size = new System.Drawing.Size(170, 16);
            this.lblECFTit.Text = "Consulta de ECF / Lacres";
            // 
            // lblValor
            // 
            this.lblValor.Location = new System.Drawing.Point(-1, 40);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(78, 17);
            this.lblValor.Text = "Procurar por:";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCriterio
            // 
            this.lblCriterio.Location = new System.Drawing.Point(8, 19);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(69, 17);
            this.lblCriterio.Text = "Critério:";
            this.lblCriterio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbbCriterio
            // 
            this.cbbCriterio.Items.Add("Inscrição Estadual");
            this.cbbCriterio.Items.Add("Número de Série");
            this.cbbCriterio.Items.Add("Lacre do Equipam.");
            this.cbbCriterio.Location = new System.Drawing.Point(79, 16);
            this.cbbCriterio.Name = "cbbCriterio";
            this.cbbCriterio.Size = new System.Drawing.Size(114, 22);
            this.cbbCriterio.TabIndex = 0;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(79, 38);
            this.txtFiltro.MaxLength = 100;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(114, 21);
            this.txtFiltro.TabIndex = 1;
            // 
            // dgECFEquipamentos
            // 
            this.dgECFEquipamentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgECFEquipamentos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgECFEquipamentos.Location = new System.Drawing.Point(0, 60);
            this.dgECFEquipamentos.Name = "dgECFEquipamentos";
            this.dgECFEquipamentos.RowHeadersVisible = false;
            this.dgECFEquipamentos.Size = new System.Drawing.Size(240, 186);
            this.dgECFEquipamentos.TabIndex = 17;
            this.dgECFEquipamentos.DoubleClick += new System.EventHandler(this.dgEquipamentos_DoubleClick);
            // 
            // dgECFEquipStyle
            // 
            this.dgECFEquipStyle.GridColumnStyles.Add(this.dgECFColCaixa);
            this.dgECFEquipStyle.GridColumnStyles.Add(this.dgECFColSerie);
            this.dgECFEquipStyle.GridColumnStyles.Add(this.dgECFColEquip);
            this.dgECFEquipStyle.GridColumnStyles.Add(this.dgECFColModelo);
            this.dgECFEquipStyle.GridColumnStyles.Add(this.dgECFColSituacao);
            this.dgECFEquipStyle.GridColumnStyles.Add(this.dgECFColInscricaoEstadual);
            this.dgECFEquipStyle.GridColumnStyles.Add(this.dgECFColRazaoSocial);
            this.dgECFEquipStyle.MappingName = "ECFEquipamento";
            // 
            // dgECFColCaixa
            // 
            this.dgECFColCaixa.Format = "";
            this.dgECFColCaixa.HeaderText = "Caixa";
            this.dgECFColCaixa.MappingName = "NU_CAIXA";
            // 
            // dgECFColSerie
            // 
            this.dgECFColSerie.Format = "";
            this.dgECFColSerie.HeaderText = "Série";
            this.dgECFColSerie.MappingName = "NU_SERIE";
            this.dgECFColSerie.Width = 80;
            // 
            // dgECFColEquip
            // 
            this.dgECFColEquip.Format = "";
            this.dgECFColEquip.HeaderText = "Equipamento";
            this.dgECFColEquip.MappingName = "DS_EQUIPAMENTO";
            this.dgECFColEquip.Width = 100;
            // 
            // dgECFColModelo
            // 
            this.dgECFColModelo.Format = "";
            this.dgECFColModelo.HeaderText = "Modelo";
            this.dgECFColModelo.MappingName = "DS_MODELO";
            this.dgECFColModelo.Width = 100;
            // 
            // dgECFColSituacao
            // 
            this.dgECFColSituacao.Format = "";
            this.dgECFColSituacao.HeaderText = "Situação";
            this.dgECFColSituacao.MappingName = "ST_EQUIPAMENTO_CONTRIB_DESC";
            this.dgECFColSituacao.Width = 70;
            // 
            // dgECFColInscricaoEstadual
            // 
            this.dgECFColInscricaoEstadual.Format = "";
            this.dgECFColInscricaoEstadual.HeaderText = "Insc. Estadual";
            this.dgECFColInscricaoEstadual.MappingName = "INSCRICAO_ESTADUAL";
            this.dgECFColInscricaoEstadual.Width = 90;
            // 
            // dgECFColRazaoSocial
            // 
            this.dgECFColRazaoSocial.Format = "";
            this.dgECFColRazaoSocial.HeaderText = "Razão Social";
            this.dgECFColRazaoSocial.MappingName = "NM_FORMAL";
            this.dgECFColRazaoSocial.Width = 200;
            // 
            // ECFEquipamentoBindingSource
            // 
            this.ECFEquipamentoBindingSource.DataSource = typeof(umi.device.wsumi.ECFEquipamento);
            // 
            // ECFLacreBindingSource
            // 
            this.ECFLacreBindingSource.DataSource = typeof(umi.device.wsumi.ECFLacre);
            // 
            // dgECFEquipLacreStyle
            // 
            this.dgECFEquipLacreStyle.GridColumnStyles.Add(this.dgECFLacreColNumero);
            this.dgECFEquipLacreStyle.GridColumnStyles.Add(this.dgECFLacreColDataInc);
            this.dgECFEquipLacreStyle.GridColumnStyles.Add(this.dgECFLacreColCodUsuInc);
            this.dgECFEquipLacreStyle.GridColumnStyles.Add(this.dgECFLacreColDataBaixa);
            this.dgECFEquipLacreStyle.GridColumnStyles.Add(this.dgECFLacreColCodUsuBaixa);
            this.dgECFEquipLacreStyle.GridColumnStyles.Add(this.dgECFLacreColDataCancel);
            this.dgECFEquipLacreStyle.GridColumnStyles.Add(this.dgECFLacreColCodUsuCanc);
            this.dgECFEquipLacreStyle.MappingName = "ECFLacre";
            // 
            // dgECFLacreColNumero
            // 
            this.dgECFLacreColNumero.Format = "";
            this.dgECFLacreColNumero.HeaderText = "Núm. Lacre";
            this.dgECFLacreColNumero.MappingName = "NU_LACRE";
            this.dgECFLacreColNumero.Width = 70;
            // 
            // dgECFLacreColDataInc
            // 
            this.dgECFLacreColDataInc.Format = "";
            this.dgECFLacreColDataInc.HeaderText = "Data Inclusão";
            this.dgECFLacreColDataInc.MappingName = "TM_INCLUSAO";
            this.dgECFLacreColDataInc.Width = 90;
            // 
            // dgECFLacreColCodUsuInc
            // 
            this.dgECFLacreColCodUsuInc.Format = "";
            this.dgECFLacreColCodUsuInc.HeaderText = "Usuár. Inclu.";
            this.dgECFLacreColCodUsuInc.MappingName = "CD_USUARIO_INCLUSAO";
            this.dgECFLacreColCodUsuInc.Width = 90;
            // 
            // dgECFLacreColDataBaixa
            // 
            this.dgECFLacreColDataBaixa.Format = "";
            this.dgECFLacreColDataBaixa.HeaderText = "Data Baixa";
            this.dgECFLacreColDataBaixa.MappingName = "TM_BAIXA";
            this.dgECFLacreColDataBaixa.Width = 90;
            // 
            // dgECFLacreColCodUsuBaixa
            // 
            this.dgECFLacreColCodUsuBaixa.Format = "";
            this.dgECFLacreColCodUsuBaixa.HeaderText = "Usuár. Baixa";
            this.dgECFLacreColCodUsuBaixa.MappingName = "CD_USUARIO_BAIXA";
            this.dgECFLacreColCodUsuBaixa.Width = 90;
            // 
            // dgECFLacreColDataCancel
            // 
            this.dgECFLacreColDataCancel.Format = "";
            this.dgECFLacreColDataCancel.HeaderText = "Data Cancel.";
            this.dgECFLacreColDataCancel.MappingName = "TM_CANCELAMENTO";
            this.dgECFLacreColDataCancel.Width = 90;
            // 
            // dgECFLacreColCodUsuCanc
            // 
            this.dgECFLacreColCodUsuCanc.Format = "";
            this.dgECFLacreColCodUsuCanc.HeaderText = "Usuár. Cancel.";
            this.dgECFLacreColCodUsuCanc.MappingName = "CD_USUARIO_CANCELAMENTO";
            this.dgECFLacreColCodUsuCanc.Width = 90;
            // 
            // frmECF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.dgECFEquipamentos);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cbbCriterio);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblECFTit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusBar1);
            this.Menu = this.mainMenu1;
            this.Name = "frmECF";
            this.Text = "UMI - Consulta ECF";
            this.Load += new System.EventHandler(this.frmECF_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemVoltar;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuItem menuItemProcurar;
        private System.Windows.Forms.Label lblECFTit;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cbbCriterio;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGrid dgECFEquipamentos;
        private System.Windows.Forms.DataGridTableStyle dgECFEquipStyle;
        private System.Windows.Forms.BindingSource ECFEquipamentoBindingSource;
        private System.Windows.Forms.BindingSource ECFLacreBindingSource;
        private System.Windows.Forms.DataGridTableStyle dgECFEquipLacreStyle;
        private System.Windows.Forms.DataGridTextBoxColumn dgECFColCaixa;
        private System.Windows.Forms.DataGridTextBoxColumn dgECFColEquip;
        private System.Windows.Forms.DataGridTextBoxColumn dgECFColModelo;
        private System.Windows.Forms.DataGridTextBoxColumn dgECFColSerie;
        private System.Windows.Forms.DataGridTextBoxColumn dgECFColSituacao;
        private System.Windows.Forms.DataGridTextBoxColumn dgECFColInscricaoEstadual;
        private System.Windows.Forms.DataGridTextBoxColumn dgECFColRazaoSocial;
        private System.Windows.Forms.DataGridTextBoxColumn dgECFLacreColNumero;
        private System.Windows.Forms.DataGridTextBoxColumn dgECFLacreColDataInc;
        private System.Windows.Forms.DataGridTextBoxColumn dgECFLacreColCodUsuInc;
        private System.Windows.Forms.DataGridTextBoxColumn dgECFLacreColDataBaixa;
        private System.Windows.Forms.DataGridTextBoxColumn dgECFLacreColCodUsuBaixa;
        private System.Windows.Forms.DataGridTextBoxColumn dgECFLacreColDataCancel;
        private System.Windows.Forms.DataGridTextBoxColumn dgECFLacreColCodUsuCanc;
    }
}