namespace umi.device
{
    partial class frmPasse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasse));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItemVoltar = new System.Windows.Forms.MenuItem();
            this.menuItemProcurar = new System.Windows.Forms.MenuItem();
            this.passeInternoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgPasses = new System.Windows.Forms.DataGrid();
            this.dgPasseStyle = new System.Windows.Forms.DataGridTableStyle();
            this.radPasse = new System.Windows.Forms.RadioButton();
            this.radPlaca = new System.Windows.Forms.RadioButton();
            this.txtPasse = new System.Windows.Forms.TextBox();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.picCaminhao = new System.Windows.Forms.PictureBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.dgPasseColTipo = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgPasseColNumero = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgPasseColData = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgPasseColNomePosto = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgPasseColOrigem = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgPasseColDestino = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgPasseColPlaca = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgPasseColNomeMotorista = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgPasseColCPFMotorista = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgPasseColEmissor = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgPasseColPermMinutos = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgPasseColPermDias = new System.Windows.Forms.DataGridTextBoxColumn();
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
            // passeInternoBindingSource
            // 
            this.passeInternoBindingSource.DataSource = typeof(umi.device.wsumi.Passe);
            // 
            // dgPasses
            // 
            this.dgPasses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgPasses.DataSource = this.passeInternoBindingSource;
            this.dgPasses.Location = new System.Drawing.Point(0, 48);
            this.dgPasses.Name = "dgPasses";
            this.dgPasses.RowHeadersVisible = false;
            this.dgPasses.Size = new System.Drawing.Size(240, 198);
            this.dgPasses.TabIndex = 10;
            this.dgPasses.TableStyles.Add(this.dgPasseStyle);
            // 
            // dgPasseStyle
            // 
            this.dgPasseStyle.GridColumnStyles.Add(this.dgPasseColTipo);
            this.dgPasseStyle.GridColumnStyles.Add(this.dgPasseColNumero);
            this.dgPasseStyle.GridColumnStyles.Add(this.dgPasseColData);
            this.dgPasseStyle.GridColumnStyles.Add(this.dgPasseColNomePosto);
            this.dgPasseStyle.GridColumnStyles.Add(this.dgPasseColOrigem);
            this.dgPasseStyle.GridColumnStyles.Add(this.dgPasseColDestino);
            this.dgPasseStyle.GridColumnStyles.Add(this.dgPasseColPlaca);
            this.dgPasseStyle.GridColumnStyles.Add(this.dgPasseColNomeMotorista);
            this.dgPasseStyle.GridColumnStyles.Add(this.dgPasseColCPFMotorista);
            this.dgPasseStyle.GridColumnStyles.Add(this.dgPasseColEmissor);
            this.dgPasseStyle.GridColumnStyles.Add(this.dgPasseColPermMinutos);
            this.dgPasseStyle.GridColumnStyles.Add(this.dgPasseColPermDias);
            this.dgPasseStyle.MappingName = "Passe";
            // 
            // radPasse
            // 
            this.radPasse.Location = new System.Drawing.Point(3, 25);
            this.radPasse.Name = "radPasse";
            this.radPasse.Size = new System.Drawing.Size(77, 18);
            this.radPasse.TabIndex = 8;
            this.radPasse.TabStop = false;
            this.radPasse.Tag = "Filter";
            this.radPasse.Text = "Nº Passe:";
            this.radPasse.CheckedChanged += new System.EventHandler(this.radPasse_CheckedChanged);
            // 
            // radPlaca
            // 
            this.radPlaca.Checked = true;
            this.radPlaca.Location = new System.Drawing.Point(3, 3);
            this.radPlaca.Name = "radPlaca";
            this.radPlaca.Size = new System.Drawing.Size(77, 18);
            this.radPlaca.TabIndex = 6;
            this.radPlaca.Tag = "Filter";
            this.radPlaca.Text = "Placa:";
            this.radPlaca.CheckedChanged += new System.EventHandler(this.radPlaca_CheckedChanged);
            // 
            // txtPasse
            // 
            this.txtPasse.Enabled = false;
            this.txtPasse.Location = new System.Drawing.Point(80, 24);
            this.txtPasse.MaxLength = 30;
            this.txtPasse.Name = "txtPasse";
            this.txtPasse.Size = new System.Drawing.Size(100, 21);
            this.txtPasse.TabIndex = 9;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 246);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(240, 22);
            // 
            // picCaminhao
            // 
            this.picCaminhao.Image = ((System.Drawing.Image)(resources.GetObject("picCaminhao.Image")));
            this.picCaminhao.Location = new System.Drawing.Point(186, 0);
            this.picCaminhao.Name = "picCaminhao";
            this.picCaminhao.Size = new System.Drawing.Size(54, 45);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(80, 1);
            this.txtPlaca.MaxLength = 9;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 21);
            this.txtPlaca.TabIndex = 13;
            // 
            // dgPasseColTipo
            // 
            this.dgPasseColTipo.Format = "";
            this.dgPasseColTipo.HeaderText = " ";
            this.dgPasseColTipo.MappingName = "Tipo";
            this.dgPasseColTipo.Width = 30;
            // 
            // dgPasseColNumero
            // 
            this.dgPasseColNumero.Format = "";
            this.dgPasseColNumero.HeaderText = "Número";
            this.dgPasseColNumero.MappingName = "Num_Passe";
            this.dgPasseColNumero.Width = 70;
            // 
            // dgPasseColEntrada
            // 
            this.dgPasseColData.Format = "";
            this.dgPasseColData.HeaderText = "Entrada";
            this.dgPasseColData.MappingName = "Data";
            this.dgPasseColData.Width = 60;
            // 
            // dgPasseColPosto
            // 
            this.dgPasseColNomePosto.Format = "";
            this.dgPasseColNomePosto.HeaderText = "Posto";
            this.dgPasseColNomePosto.MappingName = "NomePosto";
            this.dgPasseColNomePosto.Width = 130;
            // 
            // dgPasseColOrigem
            // 
            this.dgPasseColOrigem.Format = "";
            this.dgPasseColOrigem.HeaderText = "Origem";
            this.dgPasseColOrigem.MappingName = "Origem";
            this.dgPasseColOrigem.Width = 60;
            // 
            // dgPasseColDestino
            // 
            this.dgPasseColDestino.Format = "";
            this.dgPasseColDestino.HeaderText = "Destino";
            this.dgPasseColDestino.MappingName = "Destino";
            this.dgPasseColDestino.Width = 60;
            // 
            // dgPasseColPlaca
            // 
            this.dgPasseColPlaca.Format = "";
            this.dgPasseColPlaca.HeaderText = "Placa";
            this.dgPasseColPlaca.MappingName = "Placa";
            // 
            // dgPasseColNomeMotorista
            // 
            this.dgPasseColNomeMotorista.Format = "";
            this.dgPasseColNomeMotorista.HeaderText = "Motorista";
            this.dgPasseColNomeMotorista.MappingName = "NomeMotorista";
            this.dgPasseColNomeMotorista.Width = 180;
            // 
            // dgPasseColCPF
            // 
            this.dgPasseColCPFMotorista.Format = "";
            this.dgPasseColCPFMotorista.HeaderText = "CPF Motorista";
            this.dgPasseColCPFMotorista.MappingName = "CPFMotorista";
            this.dgPasseColCPFMotorista.Width = 90;
            // 
            // dgPasseColEmissor
            // 
            this.dgPasseColEmissor.Format = "";
            this.dgPasseColEmissor.HeaderText = "Emissor";
            this.dgPasseColEmissor.MappingName = "Emissor";
            this.dgPasseColEmissor.Width = 90;
            // 
            // dgPasseColPermMinutos
            // 
            this.dgPasseColPermMinutos.Format = "";
            this.dgPasseColPermMinutos.HeaderText = "Tempo (min.)";
            this.dgPasseColPermMinutos.MappingName = "PermanenciaMinutos";
            this.dgPasseColPermMinutos.Width = 80;
            // 
            // dgPasseColPermDias
            // 
            this.dgPasseColPermDias.Format = "";
            this.dgPasseColPermDias.HeaderText = "Tempo (dias)";
            this.dgPasseColPermDias.MappingName = "PermanenciaDias";
            this.dgPasseColPermDias.Width = 80;            
            // 
            // frmPasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.picCaminhao);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.dgPasses);
            this.Controls.Add(this.radPasse);
            this.Controls.Add(this.radPlaca);
            this.Controls.Add(this.txtPasse);
            this.Menu = this.mainMenu1;
            this.Name = "frmPasse";
            this.Text = "UMI - Passes";
            this.Load += new System.EventHandler(this.frmPasse_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemVoltar;
        private System.Windows.Forms.DataGrid dgPasses;
        private System.Windows.Forms.DataGridTableStyle dgPasseStyle;
        private System.Windows.Forms.RadioButton radPasse;
        private System.Windows.Forms.RadioButton radPlaca;
        private System.Windows.Forms.TextBox txtPasse;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.MenuItem menuItemProcurar;
        private System.Windows.Forms.PictureBox picCaminhao;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.BindingSource passeInternoBindingSource;
        private System.Windows.Forms.DataGridTextBoxColumn dgPasseColTipo;
        private System.Windows.Forms.DataGridTextBoxColumn dgPasseColNumero;
        private System.Windows.Forms.DataGridTextBoxColumn dgPasseColData;
        private System.Windows.Forms.DataGridTextBoxColumn dgPasseColNomePosto;
        private System.Windows.Forms.DataGridTextBoxColumn dgPasseColOrigem;
        private System.Windows.Forms.DataGridTextBoxColumn dgPasseColDestino;
        private System.Windows.Forms.DataGridTextBoxColumn dgPasseColPlaca;
        private System.Windows.Forms.DataGridTextBoxColumn dgPasseColNomeMotorista;
        private System.Windows.Forms.DataGridTextBoxColumn dgPasseColCPFMotorista;
        private System.Windows.Forms.DataGridTextBoxColumn dgPasseColEmissor;
        private System.Windows.Forms.DataGridTextBoxColumn dgPasseColPermMinutos;
        private System.Windows.Forms.DataGridTextBoxColumn dgPasseColPermDias;
    }
}