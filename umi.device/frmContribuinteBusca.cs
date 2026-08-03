using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umi.device.business;

namespace umi.device
{
    public partial class frmContribuinteBusca : frmBusiness
    {
        #region Atributos

        private wsumi.Contribuinte[] contribListRemoto;

        #endregion

        #region Propriedades

        public string strFiltro
        {
            get { return txtFiltro.Text.Trim(); }
        }

        #endregion 

        #region Construtor

        public frmContribuinteBusca()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void frmContribuinteBusca_Load(object sender, EventArgs e)
        {
            try
            {
                inicializarForm();
            }
            catch (Exception)
            {
                msgExclamacao("Falha inicializando formulário.");
                //TODO: trace frmContribuinteBusca.frmContribuinteBusca_Load()
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
                exibirStatus(statusBar1, "Buscando informações...");
                buscarContribuinte();
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
                Cursor.Current = System.Windows.Forms.Cursors.Default;
            }
        }

        private void menuItemAtualizarBase_Click(object sender, EventArgs e)
        {
            //declara uma lista para conter os contribuintes
            //que ainda não se encontram na base de dados local:
            db.ContribuinteList contribAtualizar = listarContribuintesDesatualizados();
            
            if (contribAtualizar.Count <= 0) 
            { 
                msgExclamacao("Base de dados já atualizada."); 
            }
            else 
            { 
                atualizarBase(contribAtualizar); 
            }
        }

        private void menuItemVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItemProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
                exibirStatus(statusBar1, "Buscando informações...");
                buscarContribuinte();
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
                Cursor.Current = System.Windows.Forms.Cursors.Default;
            }
        }

        private void dgResultados_DoubleClick(object sender, EventArgs e)
        {
            detalharContribuinte();
        }

        #endregion 
       
        #region Métodos

        private void inicializarForm()
        {
            statusBar1.Text = STATUSBAR_TEXTO_PADRAO;
            cbbTipoBusca.SelectedIndex = 0;
        }

        /// <summary>
        /// Se estiver logado, tenta fazer a busca Remota (via webservice);
        /// senão faz a busca no DB off-line.
        /// </summary>
        private void buscarContribuinte()
        {
            if (strFiltro == String.Empty) { msgExclamacao("Informe uma \nInscrição Estadual, \nCNPJ, \nCNPJ Base \nou CPF do Sócio."); return; }

            //1o Tenta localizar remotamente (via webservice)
            if (buscarContribuinteRemoto())
            {
                //ser houver contribuintes desatualizados,
                //perguntar se atualiza base local
                db.ContribuinteList contribAtualizar = listarContribuintesDesatualizados();
                if (contribAtualizar.Count > 0)
                {
                    if (msgPergunta("Contribuinte(s) desatualizado(s) na base de dados local.\nAtualizar?", "Atualização"))
                    {
                        atualizarBase(contribAtualizar);
                    }
                }
                this.Refresh(); //dá um refresh na tela de Busca de Contribuintes

                //se achar um único resultado, já exibe os detalhes do contribuinte:
                if (contribListRemoto.Length == 1) detalharContribuinte();                
            }
            else
            {
                //2o Não achou remotamente, tenta localizar na base local:
                if (!buscarContribuinteLocal())
                {
                    contribuinteBindingSource.DataSource = null;
                    msgAtencao("Contribuinte não encontrado.");
                    return;
                }
            }
            menuItemProcurar.Enabled = (contribListRemoto.Length > 0);
        }

        /// <summary>
        /// Busca as informações do contribuinte pelo webservice.
        /// </summary>
        /// <returns>"true" se achou o contribuinte, e "false" se não.</returns>
        private bool buscarContribuinteRemoto()
        {
            if (USUARIO_LOGADO_REMOTO) //testa se o usuário está logado (pelo webservice)
            {
                switch (cbbTipoBusca.SelectedIndex) //atenção: observar a ordem dos items do cbbTipoBusca
                {
                    case 0:
                        contribListRemoto = lerContribuinte(strFiltro);
                        if (contribListRemoto.Length <= 0) return false;
                        break;
                    case 1:
                        contribListRemoto = lerContribuinteCNPJ(strFiltro);
                        if (contribListRemoto.Length <= 0) return false;
                        break;
                    case 2:
                        contribListRemoto = lerContribuinteCNPJBase(strFiltro);
                        if (contribListRemoto.Length <= 0) return false;
                        break;
                    case 3:
                        contribListRemoto = listarContribuinteCPFSocio(strFiltro);
                        if (contribListRemoto.Length <= 0) return false;
                        break;
                }

                //atualiza o grid com os contribuintes encontrados:
                contribuinteBindingSource.DataSource = contribListRemoto;
                dgResultados.Refresh();

                Cursor.Current = System.Windows.Forms.Cursors.Default;
                exibirStatus(statusBar1, STATUSBAR_TEXTO_PADRAO);
                return (contribListRemoto != null && contribListRemoto.Length > 0);
            }

            return false;
        }

        /// <summary>
        /// Busca as informações do contribuinte na base local.
        /// </summary>
        /// <returns>"true" se achou o contribuinte, e "false" se não.</returns>
        private bool buscarContribuinteLocal()
        {
            db.ContribuinteList contrib = null;

            switch (cbbTipoBusca.SelectedIndex) //atenção: observar a ordem dos items do cbbTipoBusca
            {
                case 0: //consulta pela Inscrição Estadual
                    contrib = lerUMIContribuinte(strFiltro);
                    break;
                case 1: //consulta pelo CNPJ
                    contrib = lerUMIContribuinteCNPJ(strFiltro);
                    break;
                case 2:
                    contrib = lerUMIContribuinteCNPJBase(strFiltro);
                    break;
                case 3: //consulta pelo CPF do sócio
                    msgAtencao("Consulta por CPF do Sócio disponível somente para usuário conectado.");
                    return false;
            }

            if ((contrib != null) && (contrib.Count > 0))
            {
                //Atualiza lista:
                contribListRemoto = new wsumi.Contribuinte[contrib.Count];
                int i = 0;
                foreach (db.Contribuinte c in contrib)
                {
                    wsumi.Contribuinte cont = new wsumi.Contribuinte();
                    cont.SQ_PESSOA = c.SQ_PESSOA;
                    cont.SQ_CONTRIBUINTE = c.SQ_CONTRIBUINTE;
                    cont.INSCRICAO_ESTADUAL = c.INSCRICAO_ESTADUAL;
                    cont.NM_FORMAL = c.NM_FORMAL;
                    cont.NU_CNPJ = c.NU_CNPJ;
                    cont.ST_CONTRIBUINTE = c.ST_CONTRIBUINTE;
                    cont.SITUACAO = c.SITUACAO;
                    cont.DT_ULTIMA_ATUALIZACAO = c.DT_ULTIMA_ATUALIZACAO;
                    contribListRemoto[i++] = cont;
                }

                contribuinteBindingSource.DataSource = contribListRemoto;

                return true;
            }

            return false;
        }

        /// <summary>
        /// Lista os contribuintes do resultado da pesquisa remota
        /// que estão desatualizados na base local
        /// </summary>
        /// <returns>lista de objetos</returns>
        private db.ContribuinteList listarContribuintesDesatualizados()
        {
            /*
             * Declara uma lista para conter os contribuintes
             * que ainda não se encontram na base de dados local, 
             * ou estão desatualizados:
            */
            db.ContribuinteList contribAtualizar = new db.ContribuinteList();

            //verifica o array de Contribuinte
            if (contribListRemoto != null)
            {

                foreach (wsumi.Contribuinte contrib in contribListRemoto)
                {
                    //Verifica se já existe e está desatualizado
                    if (desatualizado(contrib.SQ_PESSOA, contrib.SQ_CONTRIBUINTE, contrib.DT_ULTIMA_ATUALIZACAO))
                    {
                        contribAtualizar.Add(new db.Contribuinte(
                                            contrib.SQ_PESSOA,
                                            contrib.SQ_CONTRIBUINTE,
                                            contrib.INSCRICAO_ESTADUAL,
                                            contrib.NM_FORMAL,
                                            contrib.NU_CNPJ,
                                            contrib.ST_CONTRIBUINTE,
                                            contrib.SITUACAO,
                                            contrib.DT_ULTIMA_ATUALIZACAO));
                    }
                }
            }

            return contribAtualizar;
        }

        /// <summary>
        /// Detalha as informações do contribuinte.
        /// </summary>
        private void detalharContribuinte()
        {
            if (!USUARIO_LOGADO_REMOTO) { msgExclamacao("Programa off-line (desconectado)."); return; }
            if (dgResultados.CurrentRowIndex < 0) { msgExclamacao("Primeiro selecione um contribuinte"); return; }
            if (contribListRemoto == null || contribListRemoto.Length <= 0) { msgExclamacao("Nenhum contribuinte listado."); return; }
            exibirStatus(statusBar1, "Abrindo detalhes...");
            frmContribuinteDetalhar frm = new frmContribuinteDetalhar(contribListRemoto[dgResultados.CurrentRowIndex]);
            frm.ShowDialog();
            frm.Dispose();
            exibirStatus(statusBar1, STATUSBAR_TEXTO_PADRAO);
        }

        /// <summary>
        /// Exibe o formulário que atualiza a base de dados.
        /// </summary>
        /// <param name="contribListLocal">Lista de objetos de Contribuintes a atualizar na base.</param>
        private void atualizarBase(db.ContribuinteList contribListLocal)
        {
            if (contribListLocal == null || contribListLocal.Count <= 0) { msgExclamacao("Nenhum contribuinte listado/encontrado."); return; }
            frmAtualizarBase frm = new frmAtualizarBase(contribListLocal);
            frm.ShowDialog();
            frm.Dispose();
        }

        #endregion                        


    }
}