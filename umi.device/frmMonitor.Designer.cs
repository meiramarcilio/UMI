namespace umi.device
{
    partial class frmMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonitor));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItemVoltar = new System.Windows.Forms.MenuItem();
            this.tabMonitor = new System.Windows.Forms.TabControl();
            this.tabBaseDados = new System.Windows.Forms.TabPage();
            this.picBaseDados = new System.Windows.Forms.PictureBox();
            this.lblBaseDadosNumContrib = new System.Windows.Forms.Label();
            this.lblNumRegBaseTit = new System.Windows.Forms.Label();
            this.lblLocalDataBaseTit = new System.Windows.Forms.Label();
            this.lblArquivoTit = new System.Windows.Forms.Label();
            this.lblBaseDadosArquivo = new System.Windows.Forms.Label();
            this.lblBaseDadosEspaco = new System.Windows.Forms.Label();
            this.lblEspacoTit = new System.Windows.Forms.Label();
            this.tabRedes = new System.Windows.Forms.TabPage();
            this.lstRedesAdaptadores = new System.Windows.Forms.ListBox();
            this.lblRedesAdaptTit = new System.Windows.Forms.Label();
            this.lstRedesConexoes = new System.Windows.Forms.ListBox();
            this.lblRedesConexTit = new System.Windows.Forms.Label();
            this.picWifi = new System.Windows.Forms.PictureBox();
            this.lblRedesTit = new System.Windows.Forms.Label();
            this.lblRedesIP = new System.Windows.Forms.Label();
            this.lblRedesIPTit = new System.Windows.Forms.Label();
            this.lblRedesWifiStatus = new System.Windows.Forms.Label();
            this.lblRedesWifiStatusTit = new System.Windows.Forms.Label();
            this.tabTelefone = new System.Windows.Forms.TabPage();
            this.lstTelConexoes = new System.Windows.Forms.ListBox();
            this.lblTelConexoesTit = new System.Windows.Forms.Label();
            this.progressBarSinalCelular = new System.Windows.Forms.ProgressBar();
            this.lblTelSinalTit = new System.Windows.Forms.Label();
            this.lblTelCobertura = new System.Windows.Forms.Label();
            this.lblTelCoberturaTit = new System.Windows.Forms.Label();
            this.lblTelefoneTit = new System.Windows.Forms.Label();
            this.picCelular = new System.Windows.Forms.PictureBox();
            this.tabGPS = new System.Windows.Forms.TabPage();
            this.lstGPS = new System.Windows.Forms.ListView();
            this.lstGPSColDado = new System.Windows.Forms.ColumnHeader();
            this.lstGPSColValor = new System.Windows.Forms.ColumnHeader();
            this.lblGPSTit = new System.Windows.Forms.Label();
            this.picGPS = new System.Windows.Forms.PictureBox();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.timer1 = new System.Windows.Forms.Timer();
            this.tabMonitor.SuspendLayout();
            this.tabBaseDados.SuspendLayout();
            this.tabRedes.SuspendLayout();
            this.tabTelefone.SuspendLayout();
            this.tabGPS.SuspendLayout();
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
            // tabMonitor
            // 
            this.tabMonitor.Controls.Add(this.tabBaseDados);
            this.tabMonitor.Controls.Add(this.tabRedes);
            this.tabMonitor.Controls.Add(this.tabTelefone);
            this.tabMonitor.Controls.Add(this.tabGPS);
            this.tabMonitor.Location = new System.Drawing.Point(0, 0);
            this.tabMonitor.Name = "tabMonitor";
            this.tabMonitor.SelectedIndex = 0;
            this.tabMonitor.Size = new System.Drawing.Size(240, 246);
            this.tabMonitor.TabIndex = 0;
            // 
            // tabBaseDados
            // 
            this.tabBaseDados.Controls.Add(this.picBaseDados);
            this.tabBaseDados.Controls.Add(this.lblBaseDadosNumContrib);
            this.tabBaseDados.Controls.Add(this.lblNumRegBaseTit);
            this.tabBaseDados.Controls.Add(this.lblLocalDataBaseTit);
            this.tabBaseDados.Controls.Add(this.lblArquivoTit);
            this.tabBaseDados.Controls.Add(this.lblBaseDadosArquivo);
            this.tabBaseDados.Controls.Add(this.lblBaseDadosEspaco);
            this.tabBaseDados.Controls.Add(this.lblEspacoTit);
            this.tabBaseDados.Location = new System.Drawing.Point(0, 0);
            this.tabBaseDados.Name = "tabBaseDados";
            this.tabBaseDados.Size = new System.Drawing.Size(240, 223);
            this.tabBaseDados.Text = "Base de dados";
            // 
            // picBaseDados
            // 
            this.picBaseDados.Image = ((System.Drawing.Image)(resources.GetObject("picBaseDados.Image")));
            this.picBaseDados.Location = new System.Drawing.Point(194, 2);
            this.picBaseDados.Name = "picBaseDados";
            this.picBaseDados.Size = new System.Drawing.Size(45, 53);
            // 
            // lblBaseDadosNumContrib
            // 
            this.lblBaseDadosNumContrib.Location = new System.Drawing.Point(126, 83);
            this.lblBaseDadosNumContrib.Name = "lblBaseDadosNumContrib";
            this.lblBaseDadosNumContrib.Size = new System.Drawing.Size(97, 18);
            this.lblBaseDadosNumContrib.Text = "0";
            // 
            // lblNumRegBaseTit
            // 
            this.lblNumRegBaseTit.Location = new System.Drawing.Point(2, 83);
            this.lblNumRegBaseTit.Name = "lblNumRegBaseTit";
            this.lblNumRegBaseTit.Size = new System.Drawing.Size(120, 18);
            this.lblNumRegBaseTit.Text = "Nº de Contribuintes:";
            // 
            // lblLocalDataBaseTit
            // 
            this.lblLocalDataBaseTit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblLocalDataBaseTit.ForeColor = System.Drawing.Color.DimGray;
            this.lblLocalDataBaseTit.Location = new System.Drawing.Point(0, 4);
            this.lblLocalDataBaseTit.Name = "lblLocalDataBaseTit";
            this.lblLocalDataBaseTit.Size = new System.Drawing.Size(202, 16);
            this.lblLocalDataBaseTit.Text = "Base de dados Local";
            // 
            // lblArquivoTit
            // 
            this.lblArquivoTit.Location = new System.Drawing.Point(2, 112);
            this.lblArquivoTit.Name = "lblArquivoTit";
            this.lblArquivoTit.Size = new System.Drawing.Size(52, 20);
            this.lblArquivoTit.Text = "Arquivo:";
            // 
            // lblBaseDadosArquivo
            // 
            this.lblBaseDadosArquivo.Location = new System.Drawing.Point(128, 112);
            this.lblBaseDadosArquivo.Name = "lblBaseDadosArquivo";
            this.lblBaseDadosArquivo.Size = new System.Drawing.Size(108, 100);
            this.lblBaseDadosArquivo.Text = "umidb";
            // 
            // lblBaseDadosEspaco
            // 
            this.lblBaseDadosEspaco.Location = new System.Drawing.Point(126, 54);
            this.lblBaseDadosEspaco.Name = "lblBaseDadosEspaco";
            this.lblBaseDadosEspaco.Size = new System.Drawing.Size(97, 17);
            this.lblBaseDadosEspaco.Text = "0 MB";
            // 
            // lblEspacoTit
            // 
            this.lblEspacoTit.Location = new System.Drawing.Point(2, 54);
            this.lblEspacoTit.Name = "lblEspacoTit";
            this.lblEspacoTit.Size = new System.Drawing.Size(97, 17);
            this.lblEspacoTit.Text = "Espaço ocupado:";
            // 
            // tabRedes
            // 
            this.tabRedes.Controls.Add(this.lstRedesAdaptadores);
            this.tabRedes.Controls.Add(this.lblRedesAdaptTit);
            this.tabRedes.Controls.Add(this.lstRedesConexoes);
            this.tabRedes.Controls.Add(this.lblRedesConexTit);
            this.tabRedes.Controls.Add(this.picWifi);
            this.tabRedes.Controls.Add(this.lblRedesTit);
            this.tabRedes.Controls.Add(this.lblRedesIP);
            this.tabRedes.Controls.Add(this.lblRedesIPTit);
            this.tabRedes.Controls.Add(this.lblRedesWifiStatus);
            this.tabRedes.Controls.Add(this.lblRedesWifiStatusTit);
            this.tabRedes.Location = new System.Drawing.Point(0, 0);
            this.tabRedes.Name = "tabRedes";
            this.tabRedes.Size = new System.Drawing.Size(232, 220);
            this.tabRedes.Text = "Redes";
            this.tabRedes.GotFocus += new System.EventHandler(this.tabRedes_GotFocus);
            // 
            // lstRedesAdaptadores
            // 
            this.lstRedesAdaptadores.Location = new System.Drawing.Point(91, 121);
            this.lstRedesAdaptadores.Name = "lstRedesAdaptadores";
            this.lstRedesAdaptadores.Size = new System.Drawing.Size(143, 58);
            this.lstRedesAdaptadores.TabIndex = 18;
            // 
            // lblRedesAdaptTit
            // 
            this.lblRedesAdaptTit.Location = new System.Drawing.Point(2, 121);
            this.lblRedesAdaptTit.Name = "lblRedesAdaptTit";
            this.lblRedesAdaptTit.Size = new System.Drawing.Size(85, 20);
            this.lblRedesAdaptTit.Text = "Adaptadores:";
            // 
            // lstRedesConexoes
            // 
            this.lstRedesConexoes.Location = new System.Drawing.Point(91, 61);
            this.lstRedesConexoes.Name = "lstRedesConexoes";
            this.lstRedesConexoes.Size = new System.Drawing.Size(143, 58);
            this.lstRedesConexoes.TabIndex = 9;
            // 
            // lblRedesConexTit
            // 
            this.lblRedesConexTit.Location = new System.Drawing.Point(2, 61);
            this.lblRedesConexTit.Name = "lblRedesConexTit";
            this.lblRedesConexTit.Size = new System.Drawing.Size(85, 20);
            this.lblRedesConexTit.Text = "Conexões:";
            // 
            // picWifi
            // 
            this.picWifi.Image = ((System.Drawing.Image)(resources.GetObject("picWifi.Image")));
            this.picWifi.Location = new System.Drawing.Point(187, 0);
            this.picWifi.Name = "picWifi";
            this.picWifi.Size = new System.Drawing.Size(52, 45);
            this.picWifi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // lblRedesTit
            // 
            this.lblRedesTit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblRedesTit.ForeColor = System.Drawing.Color.DimGray;
            this.lblRedesTit.Location = new System.Drawing.Point(0, 2);
            this.lblRedesTit.Name = "lblRedesTit";
            this.lblRedesTit.Size = new System.Drawing.Size(186, 16);
            this.lblRedesTit.Text = "Redes";
            // 
            // lblRedesIP
            // 
            this.lblRedesIP.Location = new System.Drawing.Point(91, 186);
            this.lblRedesIP.Name = "lblRedesIP";
            this.lblRedesIP.Size = new System.Drawing.Size(140, 31);
            this.lblRedesIP.Text = "127.0.0.1";
            // 
            // lblRedesIPTit
            // 
            this.lblRedesIPTit.Location = new System.Drawing.Point(0, 186);
            this.lblRedesIPTit.Name = "lblRedesIPTit";
            this.lblRedesIPTit.Size = new System.Drawing.Size(85, 20);
            this.lblRedesIPTit.Text = "Endereço IP:";
            // 
            // lblRedesWifiStatus
            // 
            this.lblRedesWifiStatus.Location = new System.Drawing.Point(91, 37);
            this.lblRedesWifiStatus.Name = "lblRedesWifiStatus";
            this.lblRedesWifiStatus.Size = new System.Drawing.Size(100, 20);
            this.lblRedesWifiStatus.Text = "desativada";
            // 
            // lblRedesWifiStatusTit
            // 
            this.lblRedesWifiStatusTit.Location = new System.Drawing.Point(2, 37);
            this.lblRedesWifiStatusTit.Name = "lblRedesWifiStatusTit";
            this.lblRedesWifiStatusTit.Size = new System.Drawing.Size(85, 20);
            this.lblRedesWifiStatusTit.Text = "Redes sem fio:";
            // 
            // tabTelefone
            // 
            this.tabTelefone.Controls.Add(this.lstTelConexoes);
            this.tabTelefone.Controls.Add(this.lblTelConexoesTit);
            this.tabTelefone.Controls.Add(this.progressBarSinalCelular);
            this.tabTelefone.Controls.Add(this.lblTelSinalTit);
            this.tabTelefone.Controls.Add(this.lblTelCobertura);
            this.tabTelefone.Controls.Add(this.lblTelCoberturaTit);
            this.tabTelefone.Controls.Add(this.lblTelefoneTit);
            this.tabTelefone.Controls.Add(this.picCelular);
            this.tabTelefone.Location = new System.Drawing.Point(0, 0);
            this.tabTelefone.Name = "tabTelefone";
            this.tabTelefone.Size = new System.Drawing.Size(232, 220);
            this.tabTelefone.Text = "Telefone";
            this.tabTelefone.GotFocus += new System.EventHandler(this.tabTelefone_GotFocus);
            // 
            // lstTelConexoes
            // 
            this.lstTelConexoes.Location = new System.Drawing.Point(104, 101);
            this.lstTelConexoes.Name = "lstTelConexoes";
            this.lstTelConexoes.Size = new System.Drawing.Size(129, 58);
            this.lstTelConexoes.TabIndex = 7;
            // 
            // lblTelConexoesTit
            // 
            this.lblTelConexoesTit.Location = new System.Drawing.Point(3, 101);
            this.lblTelConexoesTit.Name = "lblTelConexoesTit";
            this.lblTelConexoesTit.Size = new System.Drawing.Size(96, 20);
            this.lblTelConexoesTit.Text = "Conexões:";
            // 
            // progressBarSinalCelular
            // 
            this.progressBarSinalCelular.Location = new System.Drawing.Point(104, 63);
            this.progressBarSinalCelular.Name = "progressBarSinalCelular";
            this.progressBarSinalCelular.Size = new System.Drawing.Size(129, 20);
            // 
            // lblTelSinalTit
            // 
            this.lblTelSinalTit.Location = new System.Drawing.Point(3, 63);
            this.lblTelSinalTit.Name = "lblTelSinalTit";
            this.lblTelSinalTit.Size = new System.Drawing.Size(96, 20);
            this.lblTelSinalTit.Text = "Sinal de celular:";
            // 
            // lblTelCobertura
            // 
            this.lblTelCobertura.Location = new System.Drawing.Point(105, 32);
            this.lblTelCobertura.Name = "lblTelCobertura";
            this.lblTelCobertura.Size = new System.Drawing.Size(84, 20);
            this.lblTelCobertura.Text = "sem cobertura";
            // 
            // lblTelCoberturaTit
            // 
            this.lblTelCoberturaTit.Location = new System.Drawing.Point(3, 32);
            this.lblTelCoberturaTit.Name = "lblTelCoberturaTit";
            this.lblTelCoberturaTit.Size = new System.Drawing.Size(96, 20);
            this.lblTelCoberturaTit.Text = "Cobertura GPRS:";
            // 
            // lblTelefoneTit
            // 
            this.lblTelefoneTit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblTelefoneTit.ForeColor = System.Drawing.Color.DimGray;
            this.lblTelefoneTit.Location = new System.Drawing.Point(0, 2);
            this.lblTelefoneTit.Name = "lblTelefoneTit";
            this.lblTelefoneTit.Size = new System.Drawing.Size(165, 16);
            this.lblTelefoneTit.Text = "Telefone móvel";
            // 
            // picCelular
            // 
            this.picCelular.Image = ((System.Drawing.Image)(resources.GetObject("picCelular.Image")));
            this.picCelular.Location = new System.Drawing.Point(195, 0);
            this.picCelular.Name = "picCelular";
            this.picCelular.Size = new System.Drawing.Size(45, 52);
            // 
            // tabGPS
            // 
            this.tabGPS.Controls.Add(this.lstGPS);
            this.tabGPS.Controls.Add(this.lblGPSTit);
            this.tabGPS.Controls.Add(this.picGPS);
            this.tabGPS.Location = new System.Drawing.Point(0, 0);
            this.tabGPS.Name = "tabGPS";
            this.tabGPS.Size = new System.Drawing.Size(240, 223);
            this.tabGPS.Text = "GPS";
            // 
            // lstGPS
            // 
            this.lstGPS.Columns.Add(this.lstGPSColDado);
            this.lstGPS.Columns.Add(this.lstGPSColValor);
            this.lstGPS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstGPS.FullRowSelect = true;
            this.lstGPS.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstGPS.Location = new System.Drawing.Point(0, 47);
            this.lstGPS.Name = "lstGPS";
            this.lstGPS.Size = new System.Drawing.Size(240, 176);
            this.lstGPS.TabIndex = 9;
            this.lstGPS.View = System.Windows.Forms.View.Details;
            // 
            // lstGPSColDado
            // 
            this.lstGPSColDado.Text = "Dado";
            this.lstGPSColDado.Width = 80;
            // 
            // lstGPSColValor
            // 
            this.lstGPSColValor.Text = "Valor";
            this.lstGPSColValor.Width = 200;
            // 
            // lblGPSTit
            // 
            this.lblGPSTit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblGPSTit.ForeColor = System.Drawing.Color.DimGray;
            this.lblGPSTit.Location = new System.Drawing.Point(0, 2);
            this.lblGPSTit.Name = "lblGPSTit";
            this.lblGPSTit.Size = new System.Drawing.Size(185, 32);
            this.lblGPSTit.Text = "Sistema de Posicionamento Global";
            // 
            // picGPS
            // 
            this.picGPS.Image = ((System.Drawing.Image)(resources.GetObject("picGPS.Image")));
            this.picGPS.Location = new System.Drawing.Point(193, 0);
            this.picGPS.Name = "picGPS";
            this.picGPS.Size = new System.Drawing.Size(45, 47);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 246);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(240, 22);
            this.statusBar1.Text = ":: off-line :: USUÁRIO";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.tabMonitor);
            this.Menu = this.mainMenu1;
            this.Name = "frmMonitor";
            this.Text = "UMI - Monitor do Sistema";
            this.Load += new System.EventHandler(this.frmMonitor_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMonitor_Closing);
            this.tabMonitor.ResumeLayout(false);
            this.tabBaseDados.ResumeLayout(false);
            this.tabRedes.ResumeLayout(false);
            this.tabTelefone.ResumeLayout(false);
            this.tabGPS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemVoltar;
        private System.Windows.Forms.TabControl tabMonitor;
        private System.Windows.Forms.TabPage tabBaseDados;
        private System.Windows.Forms.TabPage tabRedes;
        private System.Windows.Forms.Label lblLocalDataBaseTit;
        private System.Windows.Forms.Label lblBaseDadosArquivo;
        private System.Windows.Forms.Label lblBaseDadosEspaco;
        private System.Windows.Forms.PictureBox picBaseDados;
        private System.Windows.Forms.Label lblEspacoTit;
        private System.Windows.Forms.Label lblRedesIP;
        private System.Windows.Forms.Label lblRedesIPTit;
        private System.Windows.Forms.Label lblRedesWifiStatus;
        private System.Windows.Forms.Label lblRedesWifiStatusTit;
        private System.Windows.Forms.TabPage tabTelefone;
        private System.Windows.Forms.Label lblRedesTit;
        private System.Windows.Forms.PictureBox picWifi;
        private System.Windows.Forms.Label lblBaseDadosNumContrib;
        private System.Windows.Forms.Label lblNumRegBaseTit;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.PictureBox picCelular;
        private System.Windows.Forms.Label lblTelefoneTit;
        private System.Windows.Forms.Label lblArquivoTit;
        private System.Windows.Forms.Label lblTelCobertura;
        private System.Windows.Forms.Label lblTelCoberturaTit;
        private System.Windows.Forms.Label lblTelSinalTit;
        private System.Windows.Forms.ProgressBar progressBarSinalCelular;
        private System.Windows.Forms.Label lblTelConexoesTit;
        private System.Windows.Forms.ListBox lstTelConexoes;
        private System.Windows.Forms.ListBox lstRedesConexoes;
        private System.Windows.Forms.Label lblRedesConexTit;
        private System.Windows.Forms.ListBox lstRedesAdaptadores;
        private System.Windows.Forms.Label lblRedesAdaptTit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabGPS;
        private System.Windows.Forms.PictureBox picGPS;
        private System.Windows.Forms.Label lblGPSTit;
        private System.Windows.Forms.ListView lstGPS;
        private System.Windows.Forms.ColumnHeader lstGPSColDado;
        private System.Windows.Forms.ColumnHeader lstGPSColValor;
    }
}