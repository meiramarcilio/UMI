namespace umi.device
{
    partial class frmContribuinteDetalhar
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItemVoltar = new System.Windows.Forms.MenuItem();
            this.menuItemProcurar = new System.Windows.Forms.MenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDados = new System.Windows.Forms.TabPage();
            this.lstDados = new System.Windows.Forms.ListView();
            this.lstDadosColumn1 = new System.Windows.Forms.ColumnHeader();
            this.lstDadosColumn2 = new System.Windows.Forms.ColumnHeader();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItemVisualizar = new System.Windows.Forms.MenuItem();
            this.tabRepres = new System.Windows.Forms.TabPage();
            this.lblSociosTit = new System.Windows.Forms.Label();
            this.socioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgSocio = new System.Windows.Forms.DataGrid();
            this.dgSocioStyle = new System.Windows.Forms.DataGridTableStyle();
            this.dgSocioColCPF = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgSocioColNome = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgSocioColQualif = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgSocioColResp = new System.Windows.Forms.DataGridTextBoxColumn();
            this.tabOcorr = new System.Windows.Forms.TabPage();
            this.lblOcorrenciasTit = new System.Windows.Forms.Label();
            this.ocorrenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgOcorrencias = new System.Windows.Forms.DataGrid();
            this.dgOcorrStyle = new System.Windows.Forms.DataGridTableStyle();
            this.dgOcorrColDtInclusao = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgOcorrColDescricao = new System.Windows.Forms.DataGridTextBoxColumn();
            this.tabECF = new System.Windows.Forms.TabPage();
            this.eCFEquipamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgECFEquipamentos = new System.Windows.Forms.DataGrid();
            this.dgECFEquipStyle = new System.Windows.Forms.DataGridTableStyle();
            this.dgECFColCaixa = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgECFColSerie = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgECFColEquip = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgECFColModelo = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgECFColSituacao = new System.Windows.Forms.DataGridTextBoxColumn();
            this.lblECFTit = new System.Windows.Forms.Label();
            this.tabRecolh = new System.Windows.Forms.TabPage();
            this.recolhimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgRecolhimento = new System.Windows.Forms.DataGrid();
            this.dgRecolhStyle = new System.Windows.Forms.DataGridTableStyle();
            this.dgRecolhColVencim = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgRecolhColValorDoc = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgRecolhColValorPago = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgRecolhColPagamento = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgRecolhColCodRec = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dtpFimRecolhimento = new System.Windows.Forms.DateTimePicker();
            this.lblRecolhPeriod = new System.Windows.Forms.Label();
            this.dtpInicioRecolhimento = new System.Windows.Forms.DateTimePicker();
            this.lblRecolhimentoTit = new System.Windows.Forms.Label();
            this.tabNFSaida = new System.Windows.Forms.TabPage();
            this.notaFiscalSaidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgNFSaida = new System.Windows.Forms.DataGrid();
            this.dgNFSaidaStyle = new System.Windows.Forms.DataGridTableStyle();
            this.dgNFSaidColNum = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgNFSaidColSerie = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgNFSaidColValor = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgNFSaidColICMS = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dtpNFSaidaFim = new System.Windows.Forms.DateTimePicker();
            this.lblNFSaidaPeriodo = new System.Windows.Forms.Label();
            this.dtpNFSaidaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblNotasFiscaisSaidaTit = new System.Windows.Forms.Label();
            this.tabNFEntr = new System.Windows.Forms.TabPage();
            this.dtpNFEntradaFim = new System.Windows.Forms.DateTimePicker();
            this.lblNFEntradaPeriodo = new System.Windows.Forms.Label();
            this.dtpNFEntradaInicio = new System.Windows.Forms.DateTimePicker();
            this.notaFiscalEntradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgNFEntrada = new System.Windows.Forms.DataGrid();
            this.dgNFEntradaStyle = new System.Windows.Forms.DataGridTableStyle();
            this.dgNFEntrColNum = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgNFEntrColSerie = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgNFEntrColValor = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgNFEntrColICMS = new System.Windows.Forms.DataGridTextBoxColumn();
            this.lblNotasFiscaisEntradaTit = new System.Windows.Forms.Label();
            this.tabPend = new System.Windows.Forms.TabPage();
            this.dgPendencias = new System.Windows.Forms.DataGrid();
            this.dtpFimPendencia = new System.Windows.Forms.DateTimePicker();
            this.lblPendPeriodo = new System.Windows.Forms.Label();
            this.dtpInicioPendencia = new System.Windows.Forms.DateTimePicker();
            this.lblPendenciasTit = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgRecolhCol = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgRecolhValorDoc = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgRecolhClValorDoc = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgRecolhValorPago = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgECFColSit = new System.Windows.Forms.DataGridTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabDados.SuspendLayout();
            this.tabRepres.SuspendLayout();
            this.tabOcorr.SuspendLayout();
            this.tabECF.SuspendLayout();
            this.tabRecolh.SuspendLayout();
            this.tabNFSaida.SuspendLayout();
            this.tabNFEntr.SuspendLayout();
            this.tabPend.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabDados);
            this.tabControl1.Controls.Add(this.tabRepres);
            this.tabControl1.Controls.Add(this.tabOcorr);
            this.tabControl1.Controls.Add(this.tabECF);
            this.tabControl1.Controls.Add(this.tabRecolh);
            this.tabControl1.Controls.Add(this.tabNFSaida);
            this.tabControl1.Controls.Add(this.tabNFEntr);
            this.tabControl1.Controls.Add(this.tabPend);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.None;
            this.tabControl1.Location = new System.Drawing.Point(0, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 229);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.lstDados);
            this.tabDados.Location = new System.Drawing.Point(0, 0);
            this.tabDados.Name = "tabDados";
            this.tabDados.Size = new System.Drawing.Size(240, 206);
            this.tabDados.Text = "Dados";
            // 
            // lstDados
            // 
            this.lstDados.Columns.Add(this.lstDadosColumn1);
            this.lstDados.Columns.Add(this.lstDadosColumn2);
            this.lstDados.ContextMenu = this.contextMenu1;
            this.lstDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDados.FullRowSelect = true;
            this.lstDados.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstDados.Location = new System.Drawing.Point(0, 0);
            this.lstDados.Name = "lstDados";
            this.lstDados.Size = new System.Drawing.Size(240, 206);
            this.lstDados.TabIndex = 0;
            this.lstDados.View = System.Windows.Forms.View.Details;
            // 
            // lstDadosColumn1
            // 
            this.lstDadosColumn1.Text = "Dado";
            this.lstDadosColumn1.Width = 100;
            // 
            // lstDadosColumn2
            // 
            this.lstDadosColumn2.Text = "Valor";
            this.lstDadosColumn2.Width = 300;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.Add(this.menuItemVisualizar);
            // 
            // menuItemVisualizar
            // 
            this.menuItemVisualizar.Text = "&Visualizar";
            this.menuItemVisualizar.Click += new System.EventHandler(this.menuItemVisualizar_Click);
            // 
            // tabRepres
            // 
            this.tabRepres.Controls.Add(this.lblSociosTit);
            this.tabRepres.Controls.Add(this.dgSocio);
            this.tabRepres.Location = new System.Drawing.Point(0, 0);
            this.tabRepres.Name = "tabRepres";
            this.tabRepres.Size = new System.Drawing.Size(232, 203);
            this.tabRepres.Text = "Repres.";
            // 
            // lblSociosTit
            // 
            this.lblSociosTit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblSociosTit.Location = new System.Drawing.Point(60, 0);
            this.lblSociosTit.Name = "lblSociosTit";
            this.lblSociosTit.Size = new System.Drawing.Size(120, 16);
            this.lblSociosTit.Text = "Representantes";
            this.lblSociosTit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // socioBindingSource
            // 
            this.socioBindingSource.DataSource = typeof(umi.device.wsumi.Socio);
            // 
            // dgSocio
            // 
            this.dgSocio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgSocio.DataSource = this.socioBindingSource;
            this.dgSocio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgSocio.Location = new System.Drawing.Point(0, 15);
            this.dgSocio.Name = "dgSocio";
            this.dgSocio.RowHeadersVisible = false;
            this.dgSocio.Size = new System.Drawing.Size(232, 188);
            this.dgSocio.TabIndex = 2;
            this.dgSocio.TableStyles.Add(this.dgSocioStyle);
            // 
            // dgSocioStyle
            // 
            this.dgSocioStyle.GridColumnStyles.Add(this.dgSocioColCPF);
            this.dgSocioStyle.GridColumnStyles.Add(this.dgSocioColNome);
            this.dgSocioStyle.GridColumnStyles.Add(this.dgSocioColQualif);
            this.dgSocioStyle.GridColumnStyles.Add(this.dgSocioColResp);
            this.dgSocioStyle.MappingName = "Socio";
            // 
            // dgSocioColCPF
            // 
            this.dgSocioColCPF.Format = "{0:00.000.000-00}";
            this.dgSocioColCPF.HeaderText = "CPF";
            this.dgSocioColCPF.MappingName = "NU_CNPF";
            this.dgSocioColCPF.Width = 70;
            // 
            // dgSocioColNome
            // 
            this.dgSocioColNome.Format = "";
            this.dgSocioColNome.HeaderText = "Nome";
            this.dgSocioColNome.MappingName = "NM_FORMAL";
            this.dgSocioColNome.Width = 150;
            // 
            // dgSocioColQualif
            // 
            this.dgSocioColQualif.Format = "";
            this.dgSocioColQualif.HeaderText = "Qualificação";
            this.dgSocioColQualif.MappingName = "DS_QUALIFICACAO";
            this.dgSocioColQualif.Width = 100;
            // 
            // dgSocioColResp
            // 
            this.dgSocioColResp.Format = "";
            this.dgSocioColResp.HeaderText = "Resp. Legal";
            this.dgSocioColResp.MappingName = "FG_RESPONSAVELDESC";
            this.dgSocioColResp.Width = 70;
            // 
            // tabOcorr
            // 
            this.tabOcorr.Controls.Add(this.lblOcorrenciasTit);
            this.tabOcorr.Controls.Add(this.dgOcorrencias);
            this.tabOcorr.Location = new System.Drawing.Point(0, 0);
            this.tabOcorr.Name = "tabOcorr";
            this.tabOcorr.Size = new System.Drawing.Size(232, 203);
            this.tabOcorr.Text = "Ocorr.";
            // 
            // lblOcorrenciasTit
            // 
            this.lblOcorrenciasTit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblOcorrenciasTit.Location = new System.Drawing.Point(70, 0);
            this.lblOcorrenciasTit.Name = "lblOcorrenciasTit";
            this.lblOcorrenciasTit.Size = new System.Drawing.Size(100, 16);
            this.lblOcorrenciasTit.Text = "Ocorrências";
            this.lblOcorrenciasTit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ocorrenciaBindingSource
            // 
            this.ocorrenciaBindingSource.DataSource = typeof(umi.device.wsumi.Ocorrencia);
            // 
            // dgOcorrencias
            // 
            this.dgOcorrencias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgOcorrencias.DataSource = this.ocorrenciaBindingSource;
            this.dgOcorrencias.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgOcorrencias.Location = new System.Drawing.Point(0, 15);
            this.dgOcorrencias.Name = "dgOcorrencias";
            this.dgOcorrencias.RowHeadersVisible = false;
            this.dgOcorrencias.Size = new System.Drawing.Size(232, 188);
            this.dgOcorrencias.TabIndex = 4;
            this.dgOcorrencias.TableStyles.Add(this.dgOcorrStyle);
            // 
            // dgOcorrStyle
            // 
            this.dgOcorrStyle.GridColumnStyles.Add(this.dgOcorrColDtInclusao);
            this.dgOcorrStyle.GridColumnStyles.Add(this.dgOcorrColDescricao);
            this.dgOcorrStyle.MappingName = "Ocorrencia";
            // 
            // dgOcorrColDtInclusao
            // 
            this.dgOcorrColDtInclusao.Format = "";
            this.dgOcorrColDtInclusao.HeaderText = "Inclusão";
            this.dgOcorrColDtInclusao.MappingName = "DTINCLUSAO";
            this.dgOcorrColDtInclusao.Width = 80;
            // 
            // dgOcorrColDescricao
            // 
            this.dgOcorrColDescricao.Format = "";
            this.dgOcorrColDescricao.HeaderText = "Descrição";
            this.dgOcorrColDescricao.MappingName = "DESCRICAO";
            this.dgOcorrColDescricao.Width = 200;
            // 
            // tabECF
            // 
            this.tabECF.Controls.Add(this.dgECFEquipamentos);
            this.tabECF.Controls.Add(this.lblECFTit);
            this.tabECF.Location = new System.Drawing.Point(0, 0);
            this.tabECF.Name = "tabECF";
            this.tabECF.Size = new System.Drawing.Size(232, 203);
            this.tabECF.Text = "ECF";
            // 
            // eCFEquipamentoBindingSource
            // 
            this.eCFEquipamentoBindingSource.DataSource = typeof(umi.device.wsumi.ECFEquipamento);
            // 
            // dgECFEquipamentos
            // 
            this.dgECFEquipamentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgECFEquipamentos.DataSource = this.eCFEquipamentoBindingSource;
            this.dgECFEquipamentos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgECFEquipamentos.Location = new System.Drawing.Point(0, 15);
            this.dgECFEquipamentos.Name = "dgECFEquipamentos";
            this.dgECFEquipamentos.RowHeadersVisible = false;
            this.dgECFEquipamentos.Size = new System.Drawing.Size(232, 188);
            this.dgECFEquipamentos.TabIndex = 4;
            this.dgECFEquipamentos.TableStyles.Add(this.dgECFEquipStyle);
            this.dgECFEquipamentos.DoubleClick += new System.EventHandler(this.dgECFEquipamento_DoubleClick);
            // 
            // dgECFEquipStyle
            // 
            this.dgECFEquipStyle.GridColumnStyles.Add(this.dgECFColCaixa);
            this.dgECFEquipStyle.GridColumnStyles.Add(this.dgECFColSerie);
            this.dgECFEquipStyle.GridColumnStyles.Add(this.dgECFColEquip);
            this.dgECFEquipStyle.GridColumnStyles.Add(this.dgECFColModelo);
            this.dgECFEquipStyle.GridColumnStyles.Add(this.dgECFColSituacao);
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
            // lblECFTit
            // 
            this.lblECFTit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblECFTit.Location = new System.Drawing.Point(55, 0);
            this.lblECFTit.Name = "lblECFTit";
            this.lblECFTit.Size = new System.Drawing.Size(130, 16);
            this.lblECFTit.Text = "Equipamentos ECF";
            this.lblECFTit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabRecolh
            // 
            this.tabRecolh.Controls.Add(this.dgRecolhimento);
            this.tabRecolh.Controls.Add(this.dtpFimRecolhimento);
            this.tabRecolh.Controls.Add(this.lblRecolhPeriod);
            this.tabRecolh.Controls.Add(this.dtpInicioRecolhimento);
            this.tabRecolh.Controls.Add(this.lblRecolhimentoTit);
            this.tabRecolh.Location = new System.Drawing.Point(0, 0);
            this.tabRecolh.Name = "tabRecolh";
            this.tabRecolh.Size = new System.Drawing.Size(240, 206);
            this.tabRecolh.Text = "Recolh.";
            // 
            // recolhimentoBindingSource
            // 
            this.recolhimentoBindingSource.DataSource = typeof(umi.device.wsumi.Recolhimento);
            // 
            // dgRecolhimento
            // 
            this.dgRecolhimento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgRecolhimento.DataSource = this.recolhimentoBindingSource;
            this.dgRecolhimento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgRecolhimento.Location = new System.Drawing.Point(0, 40);
            this.dgRecolhimento.Name = "dgRecolhimento";
            this.dgRecolhimento.RowHeadersVisible = false;
            this.dgRecolhimento.Size = new System.Drawing.Size(240, 166);
            this.dgRecolhimento.TabIndex = 9;
            this.dgRecolhimento.TableStyles.Add(this.dgRecolhStyle);
            // 
            // dgRecolhStyle
            // 
            this.dgRecolhStyle.GridColumnStyles.Add(this.dgRecolhColVencim);
            this.dgRecolhStyle.GridColumnStyles.Add(this.dgRecolhColValorDoc);
            this.dgRecolhStyle.GridColumnStyles.Add(this.dgRecolhColValorPago);
            this.dgRecolhStyle.GridColumnStyles.Add(this.dgRecolhColPagamento);
            this.dgRecolhStyle.GridColumnStyles.Add(this.dgRecolhColCodRec);
            this.dgRecolhStyle.MappingName = "Recolhimento";
            // 
            // dgRecolhColVencim
            // 
            this.dgRecolhColVencim.Format = "";
            this.dgRecolhColVencim.HeaderText = "Vencimento";
            this.dgRecolhColVencim.MappingName = "DT_VENCIMENTO_DEBITO";
            this.dgRecolhColVencim.Width = 70;
            // 
            // dgRecolhColValorDoc
            // 
            this.dgRecolhColValorDoc.Format = "";
            this.dgRecolhColValorDoc.HeaderText = "Valor Doc R$";
            this.dgRecolhColValorDoc.MappingName = "VL_DOCUMENTO_ATUAL";
            this.dgRecolhColValorDoc.Width = 70;
            // 
            // dgRecolhColValorPago
            // 
            this.dgRecolhColValorPago.Format = "";
            this.dgRecolhColValorPago.HeaderText = "Valor Pago R$";
            this.dgRecolhColValorPago.MappingName = "VL_NOMINAL_PAGO_ATUAL";
            this.dgRecolhColValorPago.Width = 70;
            // 
            // dgRecolhColPagamento
            // 
            this.dgRecolhColPagamento.Format = "";
            this.dgRecolhColPagamento.HeaderText = "Pagamento";
            this.dgRecolhColPagamento.MappingName = "DT_PAGAMENTO";
            this.dgRecolhColPagamento.Width = 70;
            // 
            // dgRecolhColCodRec
            // 
            this.dgRecolhColCodRec.Format = "";
            this.dgRecolhColCodRec.HeaderText = "Cod. Receita";
            this.dgRecolhColCodRec.MappingName = "SQ_TRIBUTO";
            this.dgRecolhColCodRec.Width = 70;
            // 
            // dtpFimRecolhimento
            // 
            this.dtpFimRecolhimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFimRecolhimento.Location = new System.Drawing.Point(133, 17);
            this.dtpFimRecolhimento.Name = "dtpFimRecolhimento";
            this.dtpFimRecolhimento.Size = new System.Drawing.Size(81, 22);
            this.dtpFimRecolhimento.TabIndex = 6;
            // 
            // lblRecolhPeriod
            // 
            this.lblRecolhPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRecolhPeriod.Location = new System.Drawing.Point(112, 19);
            this.lblRecolhPeriod.Name = "lblRecolhPeriod";
            this.lblRecolhPeriod.Size = new System.Drawing.Size(16, 16);
            this.lblRecolhPeriod.Text = "a";
            this.lblRecolhPeriod.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpInicioRecolhimento
            // 
            this.dtpInicioRecolhimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioRecolhimento.Location = new System.Drawing.Point(27, 17);
            this.dtpInicioRecolhimento.Name = "dtpInicioRecolhimento";
            this.dtpInicioRecolhimento.Size = new System.Drawing.Size(81, 22);
            this.dtpInicioRecolhimento.TabIndex = 8;
            // 
            // lblRecolhimentoTit
            // 
            this.lblRecolhimentoTit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblRecolhimentoTit.Location = new System.Drawing.Point(70, 0);
            this.lblRecolhimentoTit.Name = "lblRecolhimentoTit";
            this.lblRecolhimentoTit.Size = new System.Drawing.Size(100, 16);
            this.lblRecolhimentoTit.Text = "Recolhimento";
            this.lblRecolhimentoTit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabNFSaida
            // 
            this.tabNFSaida.Controls.Add(this.dgNFSaida);
            this.tabNFSaida.Controls.Add(this.dtpNFSaidaFim);
            this.tabNFSaida.Controls.Add(this.lblNFSaidaPeriodo);
            this.tabNFSaida.Controls.Add(this.dtpNFSaidaInicio);
            this.tabNFSaida.Controls.Add(this.lblNotasFiscaisSaidaTit);
            this.tabNFSaida.Location = new System.Drawing.Point(0, 0);
            this.tabNFSaida.Name = "tabNFSaida";
            this.tabNFSaida.Size = new System.Drawing.Size(240, 206);
            this.tabNFSaida.Text = "NF Saída";
            // 
            // notaFiscalSaidaBindingSource
            // 
            this.notaFiscalSaidaBindingSource.DataSource = typeof(umi.device.wsumi.NotaFiscalSaida);
            // 
            // dgNFSaida
            // 
            this.dgNFSaida.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgNFSaida.DataSource = this.notaFiscalSaidaBindingSource;
            this.dgNFSaida.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgNFSaida.Location = new System.Drawing.Point(0, 40);
            this.dgNFSaida.Name = "dgNFSaida";
            this.dgNFSaida.RowHeadersVisible = false;
            this.dgNFSaida.Size = new System.Drawing.Size(240, 166);
            this.dgNFSaida.TabIndex = 18;
            this.dgNFSaida.TableStyles.Add(this.dgNFSaidaStyle);
            this.dgNFSaida.DoubleClick += new System.EventHandler(this.dgNFSaida_DoubleClick);
            // 
            // dgNFSaidaStyle
            // 
            this.dgNFSaidaStyle.GridColumnStyles.Add(this.dgNFSaidColNum);
            this.dgNFSaidaStyle.GridColumnStyles.Add(this.dgNFSaidColSerie);
            this.dgNFSaidaStyle.GridColumnStyles.Add(this.dgNFSaidColValor);
            this.dgNFSaidaStyle.GridColumnStyles.Add(this.dgNFSaidColICMS);
            this.dgNFSaidaStyle.MappingName = "NotaFiscalSaida";
            // 
            // dgNFSaidColNum
            // 
            this.dgNFSaidColNum.Format = "";
            this.dgNFSaidColNum.HeaderText = "Número";
            this.dgNFSaidColNum.MappingName = "DSNOTS_NOTAF";
            this.dgNFSaidColNum.Width = 70;
            // 
            // dgNFSaidColSerie
            // 
            this.dgNFSaidColSerie.Format = "";
            this.dgNFSaidColSerie.HeaderText = "Série";
            this.dgNFSaidColSerie.MappingName = "DSNOTS_SERIE";
            // 
            // dgNFSaidColValor
            // 
            this.dgNFSaidColValor.Format = "";
            this.dgNFSaidColValor.HeaderText = "Valor Total";
            this.dgNFSaidColValor.MappingName = "DSNOTS_VALTOTAL";
            this.dgNFSaidColValor.Width = 70;
            // 
            // dgNFSaidColICMS
            // 
            this.dgNFSaidColICMS.Format = "";
            this.dgNFSaidColICMS.HeaderText = "ICMS";
            this.dgNFSaidColICMS.MappingName = "DSNOTS_VALICMS";
            this.dgNFSaidColICMS.Width = 70;
            // 
            // dtpNFSaidaFim
            // 
            this.dtpNFSaidaFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNFSaidaFim.Location = new System.Drawing.Point(133, 17);
            this.dtpNFSaidaFim.Name = "dtpNFSaidaFim";
            this.dtpNFSaidaFim.Size = new System.Drawing.Size(81, 22);
            this.dtpNFSaidaFim.TabIndex = 10;
            // 
            // lblNFSaidaPeriodo
            // 
            this.lblNFSaidaPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNFSaidaPeriodo.Location = new System.Drawing.Point(112, 19);
            this.lblNFSaidaPeriodo.Name = "lblNFSaidaPeriodo";
            this.lblNFSaidaPeriodo.Size = new System.Drawing.Size(16, 16);
            this.lblNFSaidaPeriodo.Text = "a";
            this.lblNFSaidaPeriodo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpNFSaidaInicio
            // 
            this.dtpNFSaidaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNFSaidaInicio.Location = new System.Drawing.Point(27, 17);
            this.dtpNFSaidaInicio.Name = "dtpNFSaidaInicio";
            this.dtpNFSaidaInicio.Size = new System.Drawing.Size(81, 22);
            this.dtpNFSaidaInicio.TabIndex = 12;
            // 
            // lblNotasFiscaisSaidaTit
            // 
            this.lblNotasFiscaisSaidaTit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblNotasFiscaisSaidaTit.Location = new System.Drawing.Point(45, 0);
            this.lblNotasFiscaisSaidaTit.Name = "lblNotasFiscaisSaidaTit";
            this.lblNotasFiscaisSaidaTit.Size = new System.Drawing.Size(150, 16);
            this.lblNotasFiscaisSaidaTit.Text = "Notas Fiscais de Saída";
            this.lblNotasFiscaisSaidaTit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabNFEntr
            // 
            this.tabNFEntr.Controls.Add(this.dtpNFEntradaFim);
            this.tabNFEntr.Controls.Add(this.lblNFEntradaPeriodo);
            this.tabNFEntr.Controls.Add(this.dtpNFEntradaInicio);
            this.tabNFEntr.Controls.Add(this.dgNFEntrada);
            this.tabNFEntr.Controls.Add(this.lblNotasFiscaisEntradaTit);
            this.tabNFEntr.Location = new System.Drawing.Point(0, 0);
            this.tabNFEntr.Name = "tabNFEntr";
            this.tabNFEntr.Size = new System.Drawing.Size(240, 206);
            this.tabNFEntr.Text = "NF Entr.";
            // 
            // dtpNFEntradaFim
            // 
            this.dtpNFEntradaFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNFEntradaFim.Location = new System.Drawing.Point(133, 17);
            this.dtpNFEntradaFim.Name = "dtpNFEntradaFim";
            this.dtpNFEntradaFim.Size = new System.Drawing.Size(81, 22);
            this.dtpNFEntradaFim.TabIndex = 27;
            // 
            // lblNFEntradaPeriodo
            // 
            this.lblNFEntradaPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNFEntradaPeriodo.Location = new System.Drawing.Point(112, 19);
            this.lblNFEntradaPeriodo.Name = "lblNFEntradaPeriodo";
            this.lblNFEntradaPeriodo.Size = new System.Drawing.Size(16, 16);
            this.lblNFEntradaPeriodo.Text = "a";
            this.lblNFEntradaPeriodo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpNFEntradaInicio
            // 
            this.dtpNFEntradaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNFEntradaInicio.Location = new System.Drawing.Point(27, 17);
            this.dtpNFEntradaInicio.Name = "dtpNFEntradaInicio";
            this.dtpNFEntradaInicio.Size = new System.Drawing.Size(81, 22);
            this.dtpNFEntradaInicio.TabIndex = 28;
            // 
            // notaFiscalEntradaBindingSource
            // 
            this.notaFiscalEntradaBindingSource.DataSource = typeof(umi.device.wsumi.NotaFiscalEntrada);
            // 
            // dgNFEntrada
            // 
            this.dgNFEntrada.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgNFEntrada.DataSource = this.notaFiscalEntradaBindingSource;
            this.dgNFEntrada.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgNFEntrada.Location = new System.Drawing.Point(0, 40);
            this.dgNFEntrada.Name = "dgNFEntrada";
            this.dgNFEntrada.RowHeadersVisible = false;
            this.dgNFEntrada.Size = new System.Drawing.Size(240, 166);
            this.dgNFEntrada.TabIndex = 25;
            this.dgNFEntrada.TableStyles.Add(this.dgNFEntradaStyle);
            this.dgNFEntrada.DoubleClick += new System.EventHandler(this.dgNFEntrada_DoubleClick);
            // 
            // dgNFEntradaStyle
            // 
            this.dgNFEntradaStyle.GridColumnStyles.Add(this.dgNFEntrColNum);
            this.dgNFEntradaStyle.GridColumnStyles.Add(this.dgNFEntrColSerie);
            this.dgNFEntradaStyle.GridColumnStyles.Add(this.dgNFEntrColValor);
            this.dgNFEntradaStyle.GridColumnStyles.Add(this.dgNFEntrColICMS);
            this.dgNFEntradaStyle.MappingName = "NotaFiscalEntrada";
            // 
            // dgNFEntrColNum
            // 
            this.dgNFEntrColNum.Format = "";
            this.dgNFEntrColNum.HeaderText = "Número";
            this.dgNFEntrColNum.MappingName = "DSNOT_NOTAF";
            this.dgNFEntrColNum.Width = 70;
            // 
            // dgNFEntrColSerie
            // 
            this.dgNFEntrColSerie.Format = "";
            this.dgNFEntrColSerie.HeaderText = "Série";
            this.dgNFEntrColSerie.MappingName = "DSNOT_SERIE";
            // 
            // dgNFEntrColValor
            // 
            this.dgNFEntrColValor.Format = "";
            this.dgNFEntrColValor.HeaderText = "Valor Total";
            this.dgNFEntrColValor.MappingName = "DSNOT_VALTOTAL";
            this.dgNFEntrColValor.Width = 70;
            // 
            // dgNFEntrColICMS
            // 
            this.dgNFEntrColICMS.Format = "";
            this.dgNFEntrColICMS.HeaderText = "ICMS";
            this.dgNFEntrColICMS.MappingName = "DSNOT_VALICMS";
            this.dgNFEntrColICMS.Width = 70;
            // 
            // lblNotasFiscaisEntradaTit
            // 
            this.lblNotasFiscaisEntradaTit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblNotasFiscaisEntradaTit.Location = new System.Drawing.Point(40, 0);
            this.lblNotasFiscaisEntradaTit.Name = "lblNotasFiscaisEntradaTit";
            this.lblNotasFiscaisEntradaTit.Size = new System.Drawing.Size(160, 16);
            this.lblNotasFiscaisEntradaTit.Text = "Notas Fiscais de Entrada";
            this.lblNotasFiscaisEntradaTit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPend
            // 
            this.tabPend.Controls.Add(this.dgPendencias);
            this.tabPend.Controls.Add(this.dtpFimPendencia);
            this.tabPend.Controls.Add(this.lblPendPeriodo);
            this.tabPend.Controls.Add(this.dtpInicioPendencia);
            this.tabPend.Controls.Add(this.lblPendenciasTit);
            this.tabPend.Location = new System.Drawing.Point(0, 0);
            this.tabPend.Name = "tabPend";
            this.tabPend.Size = new System.Drawing.Size(240, 206);
            this.tabPend.Text = "Pend.";
            // 
            // dgPendencias
            // 
            this.dgPendencias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgPendencias.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgPendencias.Location = new System.Drawing.Point(0, 40);
            this.dgPendencias.Name = "dgPendencias";
            this.dgPendencias.Size = new System.Drawing.Size(240, 166);
            this.dgPendencias.TabIndex = 8;
            // 
            // dtpFimPendencia
            // 
            this.dtpFimPendencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFimPendencia.Location = new System.Drawing.Point(133, 17);
            this.dtpFimPendencia.Name = "dtpFimPendencia";
            this.dtpFimPendencia.Size = new System.Drawing.Size(81, 22);
            this.dtpFimPendencia.TabIndex = 5;
            // 
            // lblPendPeriodo
            // 
            this.lblPendPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPendPeriodo.Location = new System.Drawing.Point(112, 19);
            this.lblPendPeriodo.Name = "lblPendPeriodo";
            this.lblPendPeriodo.Size = new System.Drawing.Size(16, 16);
            this.lblPendPeriodo.Text = "a";
            this.lblPendPeriodo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpInicioPendencia
            // 
            this.dtpInicioPendencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioPendencia.Location = new System.Drawing.Point(27, 17);
            this.dtpInicioPendencia.Name = "dtpInicioPendencia";
            this.dtpInicioPendencia.Size = new System.Drawing.Size(81, 22);
            this.dtpInicioPendencia.TabIndex = 7;
            // 
            // lblPendenciasTit
            // 
            this.lblPendenciasTit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblPendenciasTit.Location = new System.Drawing.Point(40, 0);
            this.lblPendenciasTit.Name = "lblPendenciasTit";
            this.lblPendenciasTit.Size = new System.Drawing.Size(160, 16);
            this.lblPendenciasTit.Text = "Pendências de Posto";
            this.lblPendenciasTit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.BackColor = System.Drawing.Color.LightGray;
            this.lblRazaoSocial.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblRazaoSocial.Location = new System.Drawing.Point(0, 0);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(240, 16);
            this.lblRazaoSocial.Text = "{Razão Social do Contribuinte}";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            // 
            // dgRecolhCol
            // 
            this.dgRecolhCol.Format = "";
            // 
            // dgRecolhValorDoc
            // 
            this.dgRecolhValorDoc.Format = "";
            this.dgRecolhValorDoc.HeaderText = "Valor Doc R$";
            this.dgRecolhValorDoc.MappingName = "VL_DOCUMENTO_ATUAL";
            this.dgRecolhValorDoc.Width = 70;
            // 
            // dgRecolhClValorDoc
            // 
            this.dgRecolhClValorDoc.Format = "";
            this.dgRecolhClValorDoc.HeaderText = "Valor Doc R$";
            this.dgRecolhClValorDoc.MappingName = "VL_DOCUMENTO_ATUAL";
            this.dgRecolhClValorDoc.Width = 70;
            // 
            // dgRecolhValorPago
            // 
            this.dgRecolhValorPago.Format = "";
            this.dgRecolhValorPago.HeaderText = "Valor Pago R$";
            this.dgRecolhValorPago.MappingName = "VL_NOMINAL_PAGO_ATUAL";
            // 
            // dgECFColSit
            // 
            this.dgECFColSit.Format = "";
            // 
            // frmContribuinteDetalhar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.lblRazaoSocial);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusBar1);
            this.Menu = this.mainMenu1;
            this.Name = "frmContribuinteDetalhar";
            this.Text = "UMI - Contribuinte";
            this.Load += new System.EventHandler(this.frmContribuinteDetalhar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDados.ResumeLayout(false);
            this.tabRepres.ResumeLayout(false);
            this.tabOcorr.ResumeLayout(false);
            this.tabECF.ResumeLayout(false);
            this.tabRecolh.ResumeLayout(false);
            this.tabNFSaida.ResumeLayout(false);
            this.tabNFEntr.ResumeLayout(false);
            this.tabPend.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDados;
        private System.Windows.Forms.TabPage tabRepres;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.TabPage tabOcorr;
        private System.Windows.Forms.TabPage tabRecolh;
        private System.Windows.Forms.TabPage tabECF;
        private System.Windows.Forms.TabPage tabNFSaida;
        private System.Windows.Forms.TabPage tabNFEntr;
        private System.Windows.Forms.TabPage tabPend;
        private System.Windows.Forms.ListView lstDados;
        private System.Windows.Forms.ColumnHeader lstDadosColumn1;
        private System.Windows.Forms.ColumnHeader lstDadosColumn2;
        private System.Windows.Forms.DataGrid dgSocio;
        private System.Windows.Forms.DataGridTableStyle dgSocioStyle;
        private System.Windows.Forms.Label lblSociosTit;
        private System.Windows.Forms.BindingSource socioBindingSource;
        private System.Windows.Forms.DataGridTextBoxColumn dgSocioColCPF;
        private System.Windows.Forms.DataGridTextBoxColumn dgSocioColNome;
        private System.Windows.Forms.DataGridTextBoxColumn dgSocioColQualif;
        private System.Windows.Forms.DataGridTextBoxColumn dgSocioColResp;
        private System.Windows.Forms.DataGrid dgOcorrencias;
        private System.Windows.Forms.DataGridTableStyle dgOcorrStyle;
        private System.Windows.Forms.BindingSource ocorrenciaBindingSource;
        private System.Windows.Forms.Label lblOcorrenciasTit;
        private System.Windows.Forms.DataGridTextBoxColumn dgOcorrColDtInclusao;
        private System.Windows.Forms.DataGridTextBoxColumn dgOcorrColDescricao;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItemVisualizar;
        private System.Windows.Forms.MenuItem menuItemVoltar;
        private System.Windows.Forms.Label lblRecolhimentoTit;
        private System.Windows.Forms.MenuItem menuItemProcurar;
        private System.Windows.Forms.DateTimePicker dtpFimRecolhimento;
        private System.Windows.Forms.Label lblRecolhPeriod;
        private System.Windows.Forms.DateTimePicker dtpInicioRecolhimento;
        private System.Windows.Forms.DataGrid dgRecolhimento;
        private System.Windows.Forms.DataGridTableStyle dgRecolhStyle;
        private System.Windows.Forms.BindingSource recolhimentoBindingSource;
        private System.Windows.Forms.DataGridTextBoxColumn dgRecolhColVencim;
        private System.Windows.Forms.DataGridTextBoxColumn dgRecolhColValorDoc;
        private System.Windows.Forms.DataGridTextBoxColumn dgRecolhColValorPago;
        private System.Windows.Forms.DataGridTextBoxColumn dgRecolhColPagamento;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dgRecolhCol;
        private System.Windows.Forms.DataGridTextBoxColumn dgRecolhValorDoc;
        private System.Windows.Forms.DataGridTextBoxColumn dgRecolhClValorDoc;
        private System.Windows.Forms.DataGridTextBoxColumn dgRecolhValorPago;
        private System.Windows.Forms.DataGridTextBoxColumn dgRecolhColCodRec;
        private System.Windows.Forms.Label lblECFTit;
        private System.Windows.Forms.DataGrid dgECFEquipamentos;
        private System.Windows.Forms.DataGridTableStyle dgECFEquipStyle;
        private System.Windows.Forms.BindingSource eCFEquipamentoBindingSource;
        private System.Windows.Forms.DataGridTextBoxColumn dgECFColCaixa;
        private System.Windows.Forms.DataGridTextBoxColumn dgECFColEquip;
        private System.Windows.Forms.DataGridTextBoxColumn dgECFColModelo;
        private System.Windows.Forms.DataGridTextBoxColumn dgECFColSerie;
        private System.Windows.Forms.DataGridTextBoxColumn dgECFColSituacao;
        private System.Windows.Forms.DataGridTextBoxColumn dgECFColSit;
        private System.Windows.Forms.DateTimePicker dtpNFSaidaFim;
        private System.Windows.Forms.Label lblNFSaidaPeriodo;
        private System.Windows.Forms.DateTimePicker dtpNFSaidaInicio;
        private System.Windows.Forms.Label lblNotasFiscaisSaidaTit;
        private System.Windows.Forms.DataGrid dgNFSaida;
        private System.Windows.Forms.DataGridTableStyle dgNFSaidaStyle;
        private System.Windows.Forms.BindingSource notaFiscalSaidaBindingSource;
        private System.Windows.Forms.DataGridTextBoxColumn dgNFSaidColNum;
        private System.Windows.Forms.DataGridTextBoxColumn dgNFSaidColSerie;        
        private System.Windows.Forms.DataGridTextBoxColumn dgNFSaidColValor;
        private System.Windows.Forms.DataGridTextBoxColumn dgNFSaidColICMS;        
        private System.Windows.Forms.Label lblNotasFiscaisEntradaTit;
        private System.Windows.Forms.DataGrid dgNFEntrada;
        private System.Windows.Forms.DataGridTableStyle dgNFEntradaStyle;
        private System.Windows.Forms.BindingSource notaFiscalEntradaBindingSource;
        private System.Windows.Forms.DataGridTextBoxColumn dgNFEntrColNum;
        private System.Windows.Forms.DataGridTextBoxColumn dgNFEntrColSerie;
        private System.Windows.Forms.DataGridTextBoxColumn dgNFEntrColValor;
        private System.Windows.Forms.DataGridTextBoxColumn dgNFEntrColICMS;
        private System.Windows.Forms.DateTimePicker dtpNFEntradaFim;
        private System.Windows.Forms.Label lblNFEntradaPeriodo;
        private System.Windows.Forms.DateTimePicker dtpNFEntradaInicio;
        private System.Windows.Forms.Label lblPendenciasTit;
        private System.Windows.Forms.DateTimePicker dtpFimPendencia;
        private System.Windows.Forms.Label lblPendPeriodo;
        private System.Windows.Forms.DateTimePicker dtpInicioPendencia;
        private System.Windows.Forms.DataGrid dgPendencias;
    }
}