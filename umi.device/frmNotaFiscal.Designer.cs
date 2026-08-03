namespace umi.device
{
    partial class frmNotaFiscal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotaFiscal));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItemVoltar = new System.Windows.Forms.MenuItem();
            this.menuItemProcurar = new System.Windows.Forms.MenuItem();
            this.picNotasFiscais = new System.Windows.Forms.PictureBox();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNFSaida = new System.Windows.Forms.TabPage();
            this.notaFiscalSaidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgNFSaida = new System.Windows.Forms.DataGrid();
            this.dgNFSaidaStyle = new System.Windows.Forms.DataGridTableStyle();
            this.dgNFSaidColNum = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgNFSaidColSerie = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgNFSaidColValor = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgNFSaidColICMS = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dtpNFSaidaFim = new System.Windows.Forms.DateTimePicker();
            this.lblInscricaoTit1 = new System.Windows.Forms.Label();
            this.lblNFSaidaPeriodo1 = new System.Windows.Forms.Label();
            this.txtInscricao1 = new System.Windows.Forms.TextBox();
            this.dtpNFSaidaInicio = new System.Windows.Forms.DateTimePicker();
            this.tabNFEntr = new System.Windows.Forms.TabPage();
            this.notaFiscalEntradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgNFEntrada = new System.Windows.Forms.DataGrid();
            this.dgNFEntradaStyle = new System.Windows.Forms.DataGridTableStyle();
            this.dgNFEntrColNum = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgNFEntrColSerie = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgNFEntrColValor = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgNFEntrColICMS = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dtpNFEntradaFim = new System.Windows.Forms.DateTimePicker();
            this.lblInscricaoTit2 = new System.Windows.Forms.Label();
            this.lblNFSaidaPeriodo2 = new System.Windows.Forms.Label();
            this.txtInscricao2 = new System.Windows.Forms.TextBox();
            this.dtpNFEntradaInicio = new System.Windows.Forms.DateTimePicker();
            this.picNotasFiscais2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabNFSaida.SuspendLayout();
            this.tabNFEntr.SuspendLayout();
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
            // picNotasFiscais
            // 
            this.picNotasFiscais.Image = ((System.Drawing.Image)(resources.GetObject("picNotasFiscais.Image")));
            this.picNotasFiscais.Location = new System.Drawing.Point(192, 2);
            this.picNotasFiscais.Name = "picNotasFiscais";
            this.picNotasFiscais.Size = new System.Drawing.Size(45, 50);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 246);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(240, 22);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabNFSaida);
            this.tabControl1.Controls.Add(this.tabNFEntr);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 246);
            this.tabControl1.TabIndex = 2;
            // 
            // tabNFSaida
            // 
            this.tabNFSaida.Controls.Add(this.dgNFSaida);
            this.tabNFSaida.Controls.Add(this.dtpNFSaidaFim);
            this.tabNFSaida.Controls.Add(this.lblInscricaoTit1);
            this.tabNFSaida.Controls.Add(this.lblNFSaidaPeriodo1);
            this.tabNFSaida.Controls.Add(this.txtInscricao1);
            this.tabNFSaida.Controls.Add(this.dtpNFSaidaInicio);
            this.tabNFSaida.Controls.Add(this.picNotasFiscais);
            this.tabNFSaida.Location = new System.Drawing.Point(0, 0);
            this.tabNFSaida.Name = "tabNFSaida";
            this.tabNFSaida.Size = new System.Drawing.Size(240, 223);
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
            this.dgNFSaida.Location = new System.Drawing.Point(0, 54);
            this.dgNFSaida.Name = "dgNFSaida";
            this.dgNFSaida.RowHeadersVisible = false;
            this.dgNFSaida.Size = new System.Drawing.Size(240, 169);
            this.dgNFSaida.TabIndex = 19;
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
            this.dtpNFSaidaFim.Location = new System.Drawing.Point(109, 29);
            this.dtpNFSaidaFim.Name = "dtpNFSaidaFim";
            this.dtpNFSaidaFim.Size = new System.Drawing.Size(81, 22);
            this.dtpNFSaidaFim.TabIndex = 15;
            // 
            // lblInscricaoTit1
            // 
            this.lblInscricaoTit1.Location = new System.Drawing.Point(0, 7);
            this.lblInscricaoTit1.Name = "lblInscricaoTit1";
            this.lblInscricaoTit1.Size = new System.Drawing.Size(85, 17);
            this.lblInscricaoTit1.Text = "Insc. Estadual:";
            // 
            // lblNFSaidaPeriodo1
            // 
            this.lblNFSaidaPeriodo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNFSaidaPeriodo1.Location = new System.Drawing.Point(87, 32);
            this.lblNFSaidaPeriodo1.Name = "lblNFSaidaPeriodo1";
            this.lblNFSaidaPeriodo1.Size = new System.Drawing.Size(16, 16);
            this.lblNFSaidaPeriodo1.Text = "a";
            this.lblNFSaidaPeriodo1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtInscricao1
            // 
            this.txtInscricao1.Location = new System.Drawing.Point(88, 5);
            this.txtInscricao1.MaxLength = 10;
            this.txtInscricao1.Name = "txtInscricao1";
            this.txtInscricao1.Size = new System.Drawing.Size(102, 21);
            this.txtInscricao1.TabIndex = 14;
            // 
            // dtpNFSaidaInicio
            // 
            this.dtpNFSaidaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNFSaidaInicio.Location = new System.Drawing.Point(3, 29);
            this.dtpNFSaidaInicio.Name = "dtpNFSaidaInicio";
            this.dtpNFSaidaInicio.Size = new System.Drawing.Size(81, 22);
            this.dtpNFSaidaInicio.TabIndex = 17;
            // 
            // tabNFEntr
            // 
            this.tabNFEntr.Controls.Add(this.dgNFEntrada);
            this.tabNFEntr.Controls.Add(this.dtpNFEntradaFim);
            this.tabNFEntr.Controls.Add(this.lblInscricaoTit2);
            this.tabNFEntr.Controls.Add(this.lblNFSaidaPeriodo2);
            this.tabNFEntr.Controls.Add(this.txtInscricao2);
            this.tabNFEntr.Controls.Add(this.dtpNFEntradaInicio);
            this.tabNFEntr.Controls.Add(this.picNotasFiscais2);
            this.tabNFEntr.Location = new System.Drawing.Point(0, 0);
            this.tabNFEntr.Name = "tabNFEntr";
            this.tabNFEntr.Size = new System.Drawing.Size(240, 223);
            this.tabNFEntr.Text = "NF Entrada";
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
            this.dgNFEntrada.Location = new System.Drawing.Point(0, 54);
            this.dgNFEntrada.Name = "dgNFEntrada";
            this.dgNFEntrada.RowHeadersVisible = false;
            this.dgNFEntrada.Size = new System.Drawing.Size(240, 169);
            this.dgNFEntrada.TabIndex = 20;
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
            // dtpNFEntradaFim
            // 
            this.dtpNFEntradaFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNFEntradaFim.Location = new System.Drawing.Point(109, 29);
            this.dtpNFEntradaFim.Name = "dtpNFEntradaFim";
            this.dtpNFEntradaFim.Size = new System.Drawing.Size(81, 22);
            this.dtpNFEntradaFim.TabIndex = 11;
            // 
            // lblInscricaoTit2
            // 
            this.lblInscricaoTit2.Location = new System.Drawing.Point(0, 7);
            this.lblInscricaoTit2.Name = "lblInscricaoTit2";
            this.lblInscricaoTit2.Size = new System.Drawing.Size(85, 17);
            this.lblInscricaoTit2.Text = "Insc. Estadual:";
            // 
            // lblNFSaidaPeriodo2
            // 
            this.lblNFSaidaPeriodo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNFSaidaPeriodo2.Location = new System.Drawing.Point(87, 32);
            this.lblNFSaidaPeriodo2.Name = "lblNFSaidaPeriodo2";
            this.lblNFSaidaPeriodo2.Size = new System.Drawing.Size(16, 16);
            this.lblNFSaidaPeriodo2.Text = "a";
            this.lblNFSaidaPeriodo2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtInscricao2
            // 
            this.txtInscricao2.Location = new System.Drawing.Point(88, 5);
            this.txtInscricao2.MaxLength = 10;
            this.txtInscricao2.Name = "txtInscricao2";
            this.txtInscricao2.Size = new System.Drawing.Size(102, 21);
            this.txtInscricao2.TabIndex = 10;
            // 
            // dtpNFEntradaInicio
            // 
            this.dtpNFEntradaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNFEntradaInicio.Location = new System.Drawing.Point(3, 29);
            this.dtpNFEntradaInicio.Name = "dtpNFEntradaInicio";
            this.dtpNFEntradaInicio.Size = new System.Drawing.Size(81, 22);
            this.dtpNFEntradaInicio.TabIndex = 13;
            // 
            // picNotasFiscais2
            // 
            this.picNotasFiscais2.Image = ((System.Drawing.Image)(resources.GetObject("picNotasFiscais2.Image")));
            this.picNotasFiscais2.Location = new System.Drawing.Point(192, 2);
            this.picNotasFiscais2.Name = "picNotasFiscais2";
            this.picNotasFiscais2.Size = new System.Drawing.Size(45, 50);
            // 
            // frmNotaFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusBar1);
            this.Menu = this.mainMenu1;
            this.Name = "frmNotaFiscal";
            this.Text = "UMI - Notas Fiscais";
            this.Load += new System.EventHandler(this.frmNotaFiscal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabNFSaida.ResumeLayout(false);
            this.tabNFEntr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picNotasFiscais;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNFSaida;
        private System.Windows.Forms.TabPage tabNFEntr;
        private System.Windows.Forms.PictureBox picNotasFiscais2;
        private System.Windows.Forms.DateTimePicker dtpNFEntradaFim;
        private System.Windows.Forms.Label lblInscricaoTit2;
        private System.Windows.Forms.Label lblNFSaidaPeriodo2;
        private System.Windows.Forms.TextBox txtInscricao2;
        private System.Windows.Forms.DateTimePicker dtpNFEntradaInicio;
        private System.Windows.Forms.DateTimePicker dtpNFSaidaFim;
        private System.Windows.Forms.Label lblInscricaoTit1;
        private System.Windows.Forms.Label lblNFSaidaPeriodo1;
        private System.Windows.Forms.TextBox txtInscricao1;
        private System.Windows.Forms.DateTimePicker dtpNFSaidaInicio;
        private System.Windows.Forms.DataGrid dgNFSaida;        
        private System.Windows.Forms.DataGrid dgNFEntrada;        
        private System.Windows.Forms.MenuItem menuItemVoltar;
        private System.Windows.Forms.MenuItem menuItemProcurar;
        private System.Windows.Forms.BindingSource notaFiscalSaidaBindingSource;
        private System.Windows.Forms.BindingSource notaFiscalEntradaBindingSource;
        private System.Windows.Forms.DataGridTableStyle dgNFSaidaStyle;
        private System.Windows.Forms.DataGridTextBoxColumn dgNFSaidColNum;
        private System.Windows.Forms.DataGridTextBoxColumn dgNFSaidColSerie;        
        private System.Windows.Forms.DataGridTextBoxColumn dgNFSaidColValor;
        private System.Windows.Forms.DataGridTextBoxColumn dgNFSaidColICMS;
        private System.Windows.Forms.DataGridTableStyle dgNFEntradaStyle;
        private System.Windows.Forms.DataGridTextBoxColumn dgNFEntrColNum;
        private System.Windows.Forms.DataGridTextBoxColumn dgNFEntrColSerie;
        private System.Windows.Forms.DataGridTextBoxColumn dgNFEntrColValor;
        private System.Windows.Forms.DataGridTextBoxColumn dgNFEntrColICMS;
    }
}