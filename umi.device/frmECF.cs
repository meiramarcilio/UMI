using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umi.device.wsumi;
using umi.device.business;

namespace umi.device
{
    public partial class frmECF : frmBusiness
    {
        #region Atributos

        private ECFEquipamento[] ecf = null;
        private ECFLacre[] lacre = null;

        #endregion

        #region Propriedades

        public string strFiltro
        {
            get { return txtFiltro.Text.Trim(); }
        }

        #endregion

        #region Construtor

        public frmECF()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void frmECF_Load(object sender, EventArgs e)
        {
            inicializarForm();
        }        

        private void menuItemVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItemProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                switch (cbbCriterio.SelectedIndex)
                {
                    case 0: //Inscrição Estadual                        
                        this.listarEquipamentos();
                        break;
                    case 1: //Número de Série                        
                        this.lerEquipamentoNumSerie();
                        break;
                    case 2: //Lacre                        
                        this.lerLacre();
                        break;
                    default:
                        msgExclamacao("Selecione um Critério.");
                        break;
                }
            }
            catch (System.Net.WebException ex)
            {
                msgAtencao(util.webserviceErrorMsg(ex.Message));
            }
            catch (Exception ex)
            {
                msgAtencao(ex.Message);
            }
            finally
            {
                exibirStatus(statusBar1, STATUSBAR_TEXTO_PADRAO);
                Cursor.Current = Cursors.Default;
            }
        }

        private void dgEquipamentos_DoubleClick(object sender, EventArgs e)
        {
            //Só detalha quando a consulta for pelos critérios 
            //de Inscrição Estadual e Número de Série
            if (cbbCriterio.SelectedIndex < 2)
            {
                detalharEquipamento();
            }
        }

        #endregion

        #region Métodos

        private void inicializarForm()
        {
            exibirStatus(statusBar1, STATUSBAR_TEXTO_PADRAO);
            cbbCriterio.SelectedIndex = 0;
            txtFiltro.Focus();
        }

        private void listarEquipamentos()
        {            
            if (strFiltro == string.Empty || !util.isNumber(strFiltro)) { msgExclamacao("Inscrição Estadual inválida."); return; }
            exibirStatus(statusBar1, "Procurando ECF pela Inscrição Estadual...");
            ecf = listarECFEquipamento(strFiltro);
            ECFEquipamentoBindingSource.DataSource = ecf; //seta o databind
            dgECFEquipamentos.TableStyles.Clear(); //limpa estilos existentes
            dgECFEquipamentos.TableStyles.Add(dgECFEquipStyle); //seta o estilo
            dgECFEquipamentos.DataSource = ECFEquipamentoBindingSource; //seta datasource
            if (ecf == null || ecf.Length <= 0) { msgAtencao("Nenhum ECF encontrado."); }
        }

        private void lerEquipamentoNumSerie()
        {            
            if (strFiltro == string.Empty) { msgExclamacao("Informe o Número de Série."); return; }
            exibirStatus(statusBar1, "Procurando ECF pelo Número de Série...");
            ecf = lerECFEquipamento(strFiltro);
            ECFEquipamentoBindingSource.DataSource = ecf; //seta o databind
            dgECFEquipamentos.TableStyles.Clear(); //limpa estilos existentes
            dgECFEquipamentos.TableStyles.Add(dgECFEquipStyle); //seta o estilo
            dgECFEquipamentos.DataSource = ECFEquipamentoBindingSource; //seta datasource
            if (ecf == null || ecf.Length <= 0) { msgAtencao("Nenhum ECF encontrado."); }
        }        

        private void lerLacre()
        {            
            if (strFiltro == string.Empty) { msgExclamacao("Informe o Número do Lacre."); return; }
            exibirStatus(statusBar1, "Procurando Lacre...");
            lacre = lerECFLacre(Convert.ToInt64(strFiltro));
            ECFLacreBindingSource.DataSource = lacre; //seta o databind
            dgECFEquipamentos.TableStyles.Clear(); //limpa estilos existentes
            dgECFEquipamentos.TableStyles.Add(dgECFEquipLacreStyle); //seta o estilo
            dgECFEquipamentos.DataSource = ECFLacreBindingSource; //seta datasource
            if (lacre == null || lacre.Length <= 0) { msgAtencao("Nenhum Lacre encontrado."); }
        }

        private void detalharEquipamento()
        {
            frmECFDetalhar frm = new frmECFDetalhar(ecf[dgECFEquipamentos.CurrentRowIndex]);
            frm.ShowDialog();
            frm.Dispose();
        }

        #endregion        
    }
}