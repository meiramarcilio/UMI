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
    public partial class frmECFDetalhar : frmBusiness
    {
        #region Atributos

        ECFEquipamento equip = null;

        #endregion

        #region Construtor

        public frmECFDetalhar(ECFEquipamento e)
        {
            InitializeComponent();
            equip = e;            
        }

        #endregion

        #region Eventos

        private void menuItemVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmECFDetalhar_Load(object sender, EventArgs e)
        {
            inicializarForm();
        }

        #endregion

        #region Métodos

        private void inicializarForm()
        {
            if (equip == null)
            {
                msgExcecao("Falha ao exibir detalhes do ECF.\nTente selecionar novamente.");
                this.Close();
            }

            System.Text.StringBuilder sbLacres = new System.Text.StringBuilder("");
            string strLacres = string.Empty;

            lstDetalhes.Items.Add(new ListViewItem(new string[] { "Insc. Estad.", equip.INSCRICAO_ESTADUAL }));
            lstDetalhes.Items.Add(new ListViewItem(new string[] { "Razão Social", equip.NM_FORMAL }));
            lstDetalhes.Items.Add(new ListViewItem(new string[] { "CNAE Prim.", equip.CD_CNAE_FISCAL_PRIM }));
            lstDetalhes.Items.Add(new ListViewItem(new string[] { "CNAE Sec.", equip.CD_CNAE_FISCAL_SECU }));
            lstDetalhes.Items.Add(new ListViewItem(new string[] { "Caixa", equip.NU_CAIXA.ToString() }));
            lstDetalhes.Items.Add(new ListViewItem(new string[] { "Equipamento", equip.DS_EQUIPAMENTO }));
            lstDetalhes.Items.Add(new ListViewItem(new string[] { "Marca", equip.DS_MARCA }));
            lstDetalhes.Items.Add(new ListViewItem(new string[] { "Modelo", equip.DS_MODELO }));
            lstDetalhes.Items.Add(new ListViewItem(new string[] { "Versão", equip.SG_VERSAO }));
            lstDetalhes.Items.Add(new ListViewItem(new string[] { "Série", equip.NU_SERIE }));
            lstDetalhes.Items.Add(new ListViewItem(new string[] { "Situacao", equip.ST_EQUIPAMENTO_CONTRIB_DESC }));
            lstDetalhes.Items.Add(new ListViewItem(new string[] { "Início Uso", (equip.DT_INICIO != null) ? equip.DT_INICIO.ToString() : "" }));
            lstDetalhes.Items.Add(new ListViewItem(new string[] { "Final Uso", (equip.DT_FIM != null) ? equip.DT_FIM.ToString() : "" }));

            //Lista os Lacres Externos:
            if (equip.LACRES_EXTERNOS != null)
            {
                foreach (wsumi.ECFLacre lac in equip.LACRES_EXTERNOS) sbLacres.Append(lac.NU_LACRE + ",");
            }
            strLacres = sbLacres.ToString();
            lstDetalhes.Items.Add(new ListViewItem(new string[] { "Lacres Externos", strLacres.Length <= 0 ? string.Empty : strLacres.Substring(0, strLacres.Length - 1) }));

            //limpa a string builder:
            sbLacres = new System.Text.StringBuilder("");

            //Lista os Lacres Internos:
            if (equip.LACRES_INTERNOS != null)
            {
                foreach (wsumi.ECFLacre lac in equip.LACRES_INTERNOS) sbLacres.Append(lac.NU_LACRE + ",");
            }
            strLacres = sbLacres.ToString();
            lstDetalhes.Items.Add(new ListViewItem(new string[] { "Lacres Internos", strLacres.Length <= 0 ? string.Empty : strLacres.Substring(0, strLacres.Length - 1) }));
        }

        #endregion
    }
}