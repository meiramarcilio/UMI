using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umi.device.business;
using umi.device.wsumi;

namespace umi.device
{
    public partial class frmContribuinteDetalhar : frmBusiness
    {
        #region Atributos

        private ECFEquipamento[] ecf;
        private NotaFiscalSaida[] nfsaid;
        private NotaFiscalEntrada[] nfentr;
        private Contribuinte contrib;

        /// <summary>
        /// Array das Tabs que permitem Busca (botão Procurar habilitado)
        /// </summary>
        ArrayList tabsProcurar = new ArrayList();

        #endregion

        #region Construtor

        public frmContribuinteDetalhar(Contribuinte c)
        {
            InitializeComponent();

            contrib = c;            
        }

        #endregion        

        #region Eventos

        private void frmContribuinteDetalhar_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                inicializarForm();
            }
            catch (Exception ex)
            {
                msgAtencao(util.webserviceErrorMsg(ex.Message));
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void menuItemVisualizar_Click(object sender, EventArgs e)
        {
            if (lstDados.SelectedIndices.Count > 0)
            {
                frmDetalharListViewItem frm = new frmDetalharListViewItem(lstDados.Items[lstDados.SelectedIndices[0]]);
                frm.ShowDialog();
                frm.Dispose();
            }
        }

        private void menuItemVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            menuItemProcurar.Enabled = tabsProcurar.Contains(tabControl1.TabPages[tabControl1.SelectedIndex].Name);
        }

        private void dgECFEquipamento_DoubleClick(object sender, EventArgs e)
        {
            this.detalharECF();
        }

        private void dgNFSaida_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                this.detalharNFSaida();
            }
            catch (Exception ex)
            {
                msgAtencao(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void dgNFEntrada_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                this.detalharNFEntrada();
            }
            catch (Exception ex)
            {
                msgAtencao(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void menuItemProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                switch (tabControl1.TabPages[tabControl1.SelectedIndex].Name)
                {
                    case "tabRecolh":
                        exibirStatus(statusBar1, "Procurando Recolhimento...");
                        this.listarRecolhimento();
                        break;
                    case "tabNFSaida":
                        exibirStatus(statusBar1, "Procurando Notas de Saída...");
                        this.listarNFSaida();
                        break;
                    case "tabNFEntr":
                        exibirStatus(statusBar1, "Procurando Notas de Entrada...");
                        this.listarNFEntrada();
                        break;
                    case "tabPend":
                        msgExclamacao("Funcionalidade em desenvolvimento.");
                        //TODO: listarPendencias();
                        break;
                    default:
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

        #endregion

        #region Métodos

        /// <summary>
        /// Inicializa formulário
        /// </summary>
        private void inicializarForm()
        {
            if (contrib == null)
            {
                msgExcecao("Falha ao exibir detalhes do contribuinte.\nTente selecionar o contribuinte novamente.");
                this.Close();
                return;
            }
            statusBar1.Text = STATUSBAR_TEXTO_PADRAO;            

            //Preenche o ArrayList dos nomes das tabs que permitem busca:
            tabsProcurar.Add(tabRecolh.Name);
            tabsProcurar.Add(tabNFSaida.Name);
            tabsProcurar.Add(tabNFEntr.Name);
            tabsProcurar.Add(tabPend.Name);

            //datas dos DateTimePickers
            DateTime agora = DateTime.Now;
            dtpFimPendencia.Value = agora;
            dtpFimRecolhimento.Value = agora;
            dtpNFSaidaFim.Value = agora;
            dtpNFEntradaFim.Value = agora;
            dtpInicioPendencia.Value = agora.AddDays(-5);
            dtpInicioRecolhimento.Value = agora.AddDays(-5);
            dtpNFSaidaInicio.Value = agora.AddDays(-5);
            dtpNFEntradaInicio.Value = agora.AddDays(-5);

            //exibir informações do contribuinte
            ler();
        }

        /// <summary>
        /// Ler mais informações do contribuinte
        /// </summary>
        private void ler()
        {
            lstDados.Items.Clear();

            lblRazaoSocial.Text = contrib.NM_FORMAL;

            lstDados.Items.Add(new ListViewItem("Insc. Estadual")).SubItems.Add(string.Format("{0:00000000-0}", Convert.ToInt64(contrib.INSCRICAO_ESTADUAL.PadLeft(9, '0'))));
            lstDados.Items.Add(new ListViewItem("CNPJ")).SubItems.Add(string.Format((contrib.NU_CNPJ.Length == 11 ? @"{0:000\.000\.000-00}" : @"{0:00\.000\.000\/0000-00}"), Convert.ToDouble(contrib.NU_CNPJ)));
            lstDados.Items.Add(new ListViewItem("Situação")).SubItems.Add(contrib.SITUACAO.ToUpper());
            lstDados.Items.Add(new ListViewItem("Atualizado em")).SubItems.Add(contrib.DT_ULTIMA_ATUALIZACAO != null ? contrib.DT_ULTIMA_ATUALIZACAO.ToString() : string.Empty);                        
            lstDados.Items.Add(new ListViewItem("Logadouro")).SubItems.Add(string.Format("{0} {1}, {2} - {3}",
                contrib.ENDERECO[0].CD_TIPO_LOGRADOURO_CS,
                contrib.ENDERECO[0].NM_LOGRADOURO_CS,
                contrib.ENDERECO[0].NU_LOGRADOURO_CS,
                contrib.ENDERECO[0].NM_BAIRRO_CS));
            lstDados.Items.Add(new ListViewItem("Município")).SubItems.Add(contrib.ENDERECO[0].NM_MUNICIPIO);
            lstDados.Items.Add(new ListViewItem("UF")).SubItems.Add(contrib.ENDERECO[0].NM_UF_CS);
            lstDados.Items.Add(new ListViewItem("CEP")).SubItems.Add(string.Format("{0:00000-000}", contrib.ENDERECO[0].NU_CEP_CS));
            lstDados.Items.Add(new ListViewItem("Telefone")).SubItems.Add(string.Format("{0} {1}", contrib.ENDERECO[0].NU_DDD_TELEFONE, contrib.ENDERECO[0].NU_TELEFONE));
            lstDados.Items.Add(new ListViewItem("CNAE Prim.")).SubItems.Add(string.Format("{0}-{1}", contrib.CD_CNAE_FISCAL_PRIM, contrib.DS_CNAE_FISCAL_PRIM));
            lstDados.Items.Add(new ListViewItem("CNAE Sec.")).SubItems.Add(string.Format("{0}-{1}", contrib.CD_CNAE_FISCAL_SECU, contrib.DS_CNAE_FISCAL_SECU));
            lstDados.Items.Add(new ListViewItem("Natureza Jur.")).SubItems.Add(contrib.DS_NATUREZA_JURIDICA);
            lstDados.Items.Add(new ListViewItem("Tipo")).SubItems.Add(contrib.DS_TIPO_CONTRIBUINTE);
            lstDados.Items.Add(new ListViewItem("Condição")).SubItems.Add((contrib.CREDENCIADO ? "***CREDENCIADO***" : "***NÃO CREDENCIADO***"));
            lstDados.Items.Add(new ListViewItem("Forma Pag.")).SubItems.Add(contrib.DS_FORMA_PAGAMENTO);
            lstDados.Items.Add(new ListViewItem("URT")).SubItems.Add(contrib.ENDERECO[0].SG_ORGAO);
            lstDados.Items.Add(new ListViewItem("Sit. Fiscal")).SubItems.Add(contrib.SITUACAOFISCAL);
            lstDados.Items.Add(new ListViewItem("Observações")).SubItems.Add(contrib.OBSERVACAO);

            //lê os sócios:
            socioBindingSource.DataSource = listarSocios(contrib.INSCRICAO_ESTADUAL);

            //lê as ocorrências:
            ocorrenciaBindingSource.DataSource = listarOcorrenciasFiscais(contrib.INSCRICAO_ESTADUAL);

            //listar as ECF:
            ecf = listarECFEquipamento(contrib.INSCRICAO_ESTADUAL);
            eCFEquipamentoBindingSource.DataSource = ecf;
        }

        private void listarRecolhimento()
        {
            //lê o recolhimento:
            recolhimentoBindingSource.DataSource = listarRecolhimento(contrib.INSCRICAO_ESTADUAL, dtpInicioRecolhimento.Value, dtpFimRecolhimento.Value);
        }

        /// <summary>
        /// Consulta no banco notas fiscais de saída do contribuinte
        /// </summary>
        private void listarNFSaida()
        {
            //lista notas fiscais de saída:
            nfsaid = listarNFSaida(contrib.INSCRICAO_ESTADUAL, dtpNFSaidaInicio.Value, dtpNFSaidaFim.Value);
            notaFiscalSaidaBindingSource.DataSource = nfsaid;
        }

        /// <summary>
        /// Consulta no banco notas fiscais de entrada do contribuinte
        /// </summary>
        private void listarNFEntrada()
        {
            //lista notas fiscais de entrada:
            nfentr = listarNFEntrada(contrib.INSCRICAO_ESTADUAL, dtpNFEntradaInicio.Value, dtpNFEntradaFim.Value);
            notaFiscalEntradaBindingSource.DataSource = nfentr;
        }

        private void detalharNFSaida()
        {
            frmNotaFiscalDetalhar frm = new frmNotaFiscalDetalhar(contrib.NM_FORMAL, nfsaid[dgNFSaida.CurrentRowIndex], null);            
            frm.ShowDialog();
            frm.Dispose();
        }

        private void detalharNFEntrada()
        {
            frmNotaFiscalDetalhar frm = new frmNotaFiscalDetalhar(contrib.NM_FORMAL, null, nfentr[dgNFEntrada.CurrentRowIndex]);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void detalharECF()
        {
            frmECFDetalhar frm = new frmECFDetalhar(this.ecf[dgECFEquipamentos.CurrentRowIndex]);
            frm.ShowDialog();
            frm.Dispose();
        }        

        #endregion                        
    }
}