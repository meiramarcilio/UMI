using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umi.device.business;
using System.Threading;

namespace umi.device
{
    public partial class frmAtualizarBase : frmBusiness
    {
        #region Atributos

        private db.ContribuinteList contribListLocal;
        private BackgroundWorker backgroundWorker1;

        #endregion

        #region Construtor

        public frmAtualizarBase(db.ContribuinteList c)
        {
            InitializeComponent();
            contribListLocal = c;
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            InitializeBackgoundWorker();
        }

        #endregion

        #region Eventos

        private void frmAtualizarBase_Load(object sender, EventArgs e)
        {
            try
            {
                inicializarForm();
            }
            catch (Exception)
            {
                msgAtencao("Falha inicializando formulário.");
                //TODO: trace frmAtualizarBase.frmAtualizarBase_Load();
            }
        }

        private void menuItemVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItemAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                this.progressBar1.Visible = true;
                this.lblProgresso.Visible = true;
                this.menuItemAtualizar.Enabled = false;

                exibirStatus(statusBar1, "Atualizando dados...");

                // Inicia processamento assíncrono
                backgroundWorker1.RunWorkerAsync();
            }
            catch (Exception)
            {
                this.progressBar1.Visible = false;
                this.lblProgresso.Visible = false;
                msgAtencao("Falha atualizando Base de Dados Local");
                //TODO: trace frmAtualizarBase.btnExecutar_Click();
            }
            finally
            {
                exibirStatus(statusBar1, STATUSBAR_TEXTO_PADRAO);
                this.menuItemAtualizar.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
        }

        #endregion

        #region Métodos

        private void inicializarForm()
        {
            statusBar1.Text = STATUSBAR_TEXTO_PADRAO;
            lblNumRegBase.Text = "0";
            lblNumRegAtual.Text = "0";
            if (contribListLocal != null)
            {
                string count = contarContribuintes().ToString();
                lblNumRegAtual.Text = contribListLocal.Count.ToString();
                lblNumRegBase.Text = (count != string.Empty) ? count : "0";
            }
        }

        #endregion

        #region BackGroundWorker Events

        // Set up the BackgroundWorker object by 
        // attaching event handlers. 
        private void InitializeBackgoundWorker()
        {
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.WorkerReportsProgress = true;
        }

        // This event handler is where the actual,
        // potentially time-consuming work is done.
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Get the BackgroundWorker that raised this event.
            BackgroundWorker worker = sender as BackgroundWorker;

            // Assign the result of the computation
            // to the Result property of the DoWorkEventArgs
            // object. This is will be available to the 
            // RunWorkerCompleted eventhandler.
            e.Result = atualizarContribuinte(contribListLocal, backgroundWorker1);
        }

        // This event handler deals with the results of the
        // background operation.
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // First, handle the case where an exception was thrown.
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                // Next, handle the case where the user canceled 
                // the operation.
                // Note that due to a race condition in 
                // the DoWork event handler, the Cancelled
                // flag may not have been set, even though
                // CancelAsync was called.
                MessageBox.Show("Cancelado");
            }
            else
            {
                // Finally, handle the case where the operation 
                // succeeded.
                MessageBox.Show(String.Format("{0} registros atualizados.", e.Result.ToString()));
                this.Close();
            }

            // Enable the Start button.
            menuItemAtualizar.Enabled = true;
        }

        // This event handler updates the progress bar.
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.lblProgresso.Text = String.Format("{0}%", e.ProgressPercentage.ToString());
            this.progressBar1.Value = e.ProgressPercentage;
        }

        #endregion                

    }
}