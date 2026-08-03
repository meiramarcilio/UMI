namespace umi.device
{
    partial class frmContatos
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
            this.menuItemOpcoes = new System.Windows.Forms.MenuItem();
            this.menuItemContSmart = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItemSelecTodos = new System.Windows.Forms.MenuItem();
            this.menuItemDescSelec = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItemExcluir = new System.Windows.Forms.MenuItem();
            this.lstContatos = new System.Windows.Forms.ListView();
            this.colNome = new System.Windows.Forms.ColumnHeader();
            this.colNumero = new System.Windows.Forms.ColumnHeader();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemSair);
            this.mainMenu1.MenuItems.Add(this.menuItemOpcoes);
            // 
            // menuItemSair
            // 
            this.menuItemSair.Text = "Sair";
            this.menuItemSair.Click += new System.EventHandler(this.menuItemSair_Click);
            // 
            // menuItemOpcoes
            // 
            this.menuItemOpcoes.MenuItems.Add(this.menuItemContSmart);
            this.menuItemOpcoes.MenuItems.Add(this.menuItem2);
            this.menuItemOpcoes.MenuItems.Add(this.menuItemSelecTodos);
            this.menuItemOpcoes.MenuItems.Add(this.menuItemDescSelec);
            this.menuItemOpcoes.MenuItems.Add(this.menuItem4);
            this.menuItemOpcoes.MenuItems.Add(this.menuItemExcluir);
            this.menuItemOpcoes.Text = "Opções";
            // 
            // menuItemContSmart
            // 
            this.menuItemContSmart.Text = "&Contatos do SmartPhone";
            this.menuItemContSmart.Click += new System.EventHandler(this.menuItemContSmart_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "-";
            // 
            // menuItemSelecTodos
            // 
            this.menuItemSelecTodos.Text = "&Selecionar Todos";
            this.menuItemSelecTodos.Click += new System.EventHandler(this.menuItemSelecTodos_Click);
            // 
            // menuItemDescSelec
            // 
            this.menuItemDescSelec.Text = "&Descartar seleção";
            this.menuItemDescSelec.Click += new System.EventHandler(this.menuItemDescSelec_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "-";
            // 
            // menuItemExcluir
            // 
            this.menuItemExcluir.Text = "&Excluir selecionados";
            this.menuItemExcluir.Click += new System.EventHandler(this.menuItemExcluir_Click);
            // 
            // lstContatos
            // 
            this.lstContatos.CheckBoxes = true;
            this.lstContatos.Columns.Add(this.colNome);
            this.lstContatos.Columns.Add(this.colNumero);
            this.lstContatos.Location = new System.Drawing.Point(0, 0);
            this.lstContatos.Name = "lstContatos";
            this.lstContatos.Size = new System.Drawing.Size(240, 246);
            this.lstContatos.TabIndex = 1;
            this.lstContatos.View = System.Windows.Forms.View.Details;
            // 
            // colNome
            // 
            this.colNome.Text = "Nome";
            this.colNome.Width = 120;
            // 
            // colNumero
            // 
            this.colNumero.Text = "Números";
            this.colNumero.Width = 200;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 246);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(240, 22);
            // 
            // frmContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.lstContatos);
            this.Menu = this.mainMenu1;
            this.Name = "frmContatos";
            this.Text = "Contatos";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmContatos_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemSair;
        private System.Windows.Forms.MenuItem menuItemOpcoes;
        private System.Windows.Forms.MenuItem menuItemContSmart;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItemSelecTodos;
        private System.Windows.Forms.MenuItem menuItemDescSelec;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItemExcluir;
        private System.Windows.Forms.ListView lstContatos;
        private System.Windows.Forms.ColumnHeader colNome;
        private System.Windows.Forms.ColumnHeader colNumero;
        private System.Windows.Forms.StatusBar statusBar1;
    }
}