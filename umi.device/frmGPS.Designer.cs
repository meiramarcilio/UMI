namespace umi.device
{
    partial class frmGPS
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
            this.menuItemSair = new System.Windows.Forms.MenuItem();
            this.menuItemAbrir = new System.Windows.Forms.MenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.timer1 = new System.Windows.Forms.Timer();
            this.dgSatelite = new System.Windows.Forms.DataGrid();
            this.dgSateliteStyle = new System.Windows.Forms.DataGridTableStyle();
            this.colOrient = new System.Windows.Forms.DataGridTextBoxColumn();
            this.colPRN = new System.Windows.Forms.DataGridTextBoxColumn();
            this.colAzimute = new System.Windows.Forms.DataGridTextBoxColumn();
            this.colElevac = new System.Windows.Forms.DataGridTextBoxColumn();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemSair);
            this.mainMenu1.MenuItems.Add(this.menuItemAbrir);
            // 
            // menuItemSair
            // 
            this.menuItemSair.Text = "Sair";
            this.menuItemSair.Click += new System.EventHandler(this.menuItemSair_Click);
            // 
            // menuItemAbrir
            // 
            this.menuItemAbrir.Text = "Abrir";
            this.menuItemAbrir.Click += new System.EventHandler(this.menuItemAbrir_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.Add(this.columnHeader1);
            this.listView1.Columns.Add(this.columnHeader2);
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(240, 160);
            this.listView1.TabIndex = 0;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dado";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valor";
            this.columnHeader2.Width = 200;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgSatelite
            // 
            this.dgSatelite.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgSatelite.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgSatelite.Location = new System.Drawing.Point(0, 160);
            this.dgSatelite.Name = "dgSatelite";
            this.dgSatelite.Size = new System.Drawing.Size(240, 108);
            this.dgSatelite.TabIndex = 1;
            this.dgSatelite.TableStyles.Add(this.dgSateliteStyle);
            // 
            // dgSateliteStyle
            // 
            this.dgSateliteStyle.GridColumnStyles.Add(this.colPRN);
            this.dgSateliteStyle.GridColumnStyles.Add(this.colAzimute);
            this.dgSateliteStyle.GridColumnStyles.Add(this.colOrient);
            this.dgSateliteStyle.GridColumnStyles.Add(this.colElevac);
            this.dgSateliteStyle.MappingName = "GpsSatelite";
            // 
            // colOrient
            // 
            this.colOrient.Format = "";
            this.colOrient.FormatInfo = null;
            this.colOrient.HeaderText = "Orient.";
            this.colOrient.MappingName = "Orientacao";
            this.colOrient.PropertyDescriptor = null;
            // 
            // colPRN
            // 
            this.colPRN.Format = "";
            this.colPRN.FormatInfo = null;
            this.colPRN.HeaderText = "Identif.";
            this.colPRN.MappingName = "PseudoCodigoRandomico";
            this.colPRN.PropertyDescriptor = null;
            // 
            // colAzimute
            // 
            this.colAzimute.Format = "";
            this.colAzimute.FormatInfo = null;
            this.colAzimute.HeaderText = "Azimute º";
            this.colAzimute.MappingName = "Azimute";
            this.colAzimute.PropertyDescriptor = null;
            // 
            // colElevac
            // 
            this.colElevac.Format = "";
            this.colElevac.FormatInfo = null;
            this.colElevac.HeaderText = "Elevação";
            this.colElevac.MappingName = "Elevacao";
            this.colElevac.PropertyDescriptor = null;
            // 
            // frmGPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.dgSatelite);
            this.Controls.Add(this.listView1);
            this.Menu = this.mainMenu1;
            this.Name = "frmGPS";
            this.Text = "GPS Info";
            this.Load += new System.EventHandler(this.frmGPS_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmGPS_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemSair;
        private System.Windows.Forms.MenuItem menuItemAbrir;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGrid dgSatelite;
        private System.Windows.Forms.DataGridTableStyle dgSateliteStyle;
        private System.Windows.Forms.DataGridTextBoxColumn colPRN;
        private System.Windows.Forms.DataGridTextBoxColumn colAzimute;
        private System.Windows.Forms.DataGridTextBoxColumn colOrient;
        private System.Windows.Forms.DataGridTextBoxColumn colElevac;
    }
}