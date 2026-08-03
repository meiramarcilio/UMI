using System;
using System.Data;
using System.Windows.Forms;
using umi.device;

namespace umi.device.business
{    
    /// <summary>
    /// Classe das regras de neg�cios do projeto umi.device
    /// </summary>
	public class frmBusiness : Form
    {
        #region Atributos

        //Atributos Privados:
        private string strWsErro = string.Empty;

        //Atributos Herd�veis:
        protected wsumi.service wssrv = new wsumi.service();
        
        //Atributos Privados Est�ticos:
        private static string strTicket = string.Empty;
        private static string strUsuarioNome = string.Empty;
        private static bool boolUsuarioLogadoRemoto = false;
        private static bool boolUsuarioLogadoLocal = false;        
        private static GPS.Gps gps = null;

        #endregion

        #region Propriedades

        /// <summary>
        /// Nome do usu�rio logado
        /// </summary>
        protected static string USUARIO_NOME
        {
            get { return strUsuarioNome; }
        }

        /// <summary>
        /// Informa se o usu�rio est� logado remotamente.
        /// Se sim, significa que as consultas on-line est�o dispon�veis.
        /// </summary>
        protected static bool USUARIO_LOGADO_REMOTO
        {
            get { return boolUsuarioLogadoRemoto; }
        }

        /// <summary>
        /// Informa se o usu�rio est� logado localmente (pela base de dados local).
        /// Se sim, somente est�o dispon�veis consultas � base de dados local.
        /// </summary>
        protected static bool USUARIO_LOGADO_LOCAL
        {
            get { return boolUsuarioLogadoLocal; }
        }

        /// <summary>
        /// Informa se o usu�rio est� logado, seja local ou remotamente.
        /// </summary>
        protected static bool USUARIO_LOGADO
        {
            get { return (boolUsuarioLogadoLocal || boolUsuarioLogadoRemoto); }
        }

        /// <summary>
        /// Retorna um texto padr�o (:: on-line/off-line :: USUARIO_NOME)
        /// </summary>
        protected static string STATUSBAR_TEXTO_PADRAO
        {
            get { return String.Format(":: {0} :: " + USUARIO_NOME, (USUARIO_LOGADO_REMOTO ? "on-line" : "off-line")); }
        }

        #endregion

        #region M�todos Auxiliares

        /// <summary>
        /// Verifica se h� mensagem de exce��o do webservice.
        /// Se houver, a mensagem ser� exibida; Por�m se a mensagem for
        /// de 'Ticket expirado', ser� exibida a tela de Login.
        /// </summary>
        protected void checarExcecaoWs()
        {
            string strMsg = strWsErro;             
            
            if (strMsg != string.Empty) 
            {
                strWsErro = string.Empty; //limpa a mensagem atual;

                if (strMsg == "Ticket expirado.")
                {
                    Cursor.Current = Cursors.Default; //seta o cursor para o padr�o
                    msgExclamacao("Sess�o expirada.");
                    logout();
                    frmLogin frm = new frmLogin();
                    while (frm.DialogResult != DialogResult.Yes)
                    {
                        frm.ShowDialog();
                    }
                    frm.Dispose();
                }
                else
                {
                    throw new System.Net.WebException(strMsg);
                }
            }
        }

        /// <summary>
        /// Verifica se h� mensagem de exce��o do webservice.
        /// Se houver, a mensagem ser� exibida; Por�m se a mensagem for
        /// de 'Ticket expirado', ser� exibida a tela de Login.
        /// </summary>
        /// <returns>true => se houver valor no atributo "strWsErro", e a mensagem � exibida;
        /// false => n�o h� valor no atributo "strWsErro".
        /// </returns>
        protected bool checarExcecaoWs2()
        {
            string strMensagemExibir = strWsErro;

            if (strMensagemExibir != string.Empty)
            {
                strWsErro = string.Empty; //limpa a mensagem atual;

                if (strMensagemExibir == "Ticket expirado")
                {
                    Cursor.Current = Cursors.Default; //seta o cursor para o padr�o
                    msgExclamacao("Sess�o expirada.");
                    logout();
                    //For�a o usu�rio a fazer o login, novamente
                    frmLogin frm = new frmLogin();
                    while (frm.DialogResult != DialogResult.Yes)
                    {
                        frm.ShowDialog();
                    }
                    frm.Dispose();

                    return false;
                }
                else
                {
                    msgExclamacao(strMensagemExibir);
                    return true;
                }                
            }

            return false;
        }

        /// <summary>
        /// L� a vers�o do Assembly.
        /// </summary>
        /// <returns>string</returns>
        protected string lerVersao()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().FullName.Split(',')[1].Trim().Replace("Version=", "");
        }

        /// <summary>
        /// Recupera o nome da aplica��o.
        /// </summary>
        /// <returns>string</returns>
        protected string lerNomeAplicacao()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().FullName.Split(',')[0].Trim();
        }

        /// <summary>
        /// Exibe uma mensagem no objeto StatusBar
        /// </summary>
        /// <param name="objeto">objeto StatusBar</param>
        /// <param name="strMensagem">string com mensagem</param>
        protected void exibirStatus(StatusBar objeto, string strMensagem)
        {
            objeto.Text = strMensagem;
            objeto.Update();
        }

        #endregion

        #region Mensagens

        protected void msgExcecao(string strMensagem)
        {
            MessageBox.Show(strMensagem, "", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
        }

        protected void msgExcecao(string strMensagem, string strTitulo)
        {
            MessageBox.Show(strMensagem, strTitulo, MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
        }

        protected void msgAtencao(string strMensagem)
        {
            MessageBox.Show(strMensagem, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
        }

        protected void msgAtencao(string strMensagem, string strTitulo)
        {
            MessageBox.Show(strMensagem, strTitulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
        }

        protected void msgExclamacao(string strMensagem)
        {
            MessageBox.Show(strMensagem, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }

        protected void msgExclamacao(string strMensagem, string strTitulo)
        {
            MessageBox.Show(strMensagem, strTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }

        protected bool msgPergunta(string strMensagem)
        {
            return (MessageBox.Show(strMensagem, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes);
        }

        protected bool msgPergunta(string strMensagem, string strTitulo)
        {
            return (MessageBox.Show(strMensagem, strTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes);
        }

        #endregion

        #region Login/logout

        /// <summary>
		/// Autentica o usu�rio pelo webservice.
		/// </summary>
        /// <param name="strLogin">Login do usu�rio</param>
		/// <param name="strSenha">Senha</param>
		/// <returns>true => autentica��o OK; false => autentica��o falhou</returns>
        protected bool login(string strLogin, string strSenha)
		{
            boolUsuarioLogadoRemoto = false; //seta valor default false
            boolUsuarioLogadoLocal = false; //seta valor default false

            conetividade conectiv = new conetividade();

            //seta o flag que diz se o usu�rio est� conectado ou n�o:
            if (conectiv.TelefoneConexoesNumero > 0 || conectiv.RedeConexoesNumero > 0)
            {                    
                boolUsuarioLogadoRemoto = loginRemoto(strLogin, strSenha);                
                //Se n�o logou remotamente, tenta logar localmente:
                /*if (!boolUsuarioLogadoRemoto)
                {
                    boolUsuarioLogadoLocal = loginLocal(strLogin, strSenha);                        
                }*/
            }
            else //usu�rio off-line
            {
                boolUsuarioLogadoLocal = loginLocal(strLogin, strSenha);
            }

            return (boolUsuarioLogadoRemoto || boolUsuarioLogadoLocal);
		}

        /// <summary>
        /// Efeuta login remotamente pelo webservice (on-line).
        /// </summary>
        /// <param name="strLogin">Login do usu�rio</param>
        /// <param name="strSenha">Senha</param>
        /// <returns>true => autentica��o OK; false => autentica��o falhou</returns>
        private bool loginRemoto(string strLogin, string strSenha)
        {
            //tenta ler o ticket de autentica��o (remotamente):
            strTicket = wssrv.lerTicketERP(strLogin, strSenha, out strWsErro);
            if (checarExcecaoWs2()) { return false; }

            //autentica��o ok, agora tenta ler os dados do usu�rio (remotamente):
            wsumi.UsuarioERP[] usuar = wssrv.lerUsuario(strTicket, strLogin, out strWsErro);
            if (checarExcecaoWs2()) { return false; }

            //recupera o nome completo do usu�rio:
            strUsuarioNome = usuar[0].NM_FORMAL;

            //atualiza o cadastro do usu�rio na base off-line:
            db.UsuarioList usuarLocal = new db.UsuarioList();
            usuarLocal.Add(new db.Usuario(usuar[0].SQ_PESSOA, usuar[0].NM_FORMAL, usuar[0].CD_USUARIO, strSenha, DateTime.Now));
            usuarLocal.salvar();

            return true;
        }

        /// <summary>
        /// Efeuta login na base local (off-line).
        /// </summary>
        /// <param name="strLogin">Login do usu�rio</param>
        /// <param name="strSenha">Senha</param>
        /// <returns>true => autentica��o OK; false => autentica��o falhou</returns>
        private bool loginLocal(string strLogin, string strSenha)
        {
            db.UsuarioList usuar = new umi.device.db.UsuarioList();
            if (usuar.login(strLogin, strSenha))
            {
                strUsuarioNome = usuar[0].NM_FORMAL;
                return true;
            }
            else
            {
                msgExclamacao("Usu�rio ou senha inv�lidos.");
                return false;
            }            
        }

        /// <summary>
        /// Efetua logoff do sistema
        /// </summary>
        protected void logout()
        {
            strUsuarioNome = string.Empty;            
            strTicket = string.Empty;
            boolUsuarioLogadoRemoto = false;
            boolUsuarioLogadoLocal = false;
        }

        #endregion

        #region Contribuinte (on-line)

        /// <summary>
        /// L� as informa��es detalhadas do Contribuinte pela Inscri��o Estadual informado.
        /// </summary>
        /// <param name="strInscricaoEstadual">Inscri��o Estadual</param>
        /// <returns>objeto</returns>
        protected wsumi.Contribuinte[] lerContribuinte(string strInscricaoEstadual)
        {
            wsumi.Contribuinte[] contrib = wssrv.lerContribuinte(strTicket, strInscricaoEstadual, out strWsErro);            
            checarExcecaoWs();            
            return contrib;
        }

        /// <summary>
        /// L� as informa��es resumidas do Contribuinte pelo CNPJ informado.
        /// </summary>
        /// <param name="strCNPJ">CNPJ do Contribuinte</param>
        /// <returns>objeto</returns>
        protected wsumi.Contribuinte[] lerContribuinteCNPJ(string strCNPJ)
        {
            wsumi.Contribuinte[] contrib = wssrv.lerContribuinteCNPJ(strTicket, strCNPJ, out strWsErro);
            checarExcecaoWs();            
            return contrib;
        }

        /// <summary>
        /// L� as informa��es resumidas do Contribuinte pelo CNPJ Base informado.
        /// </summary>
        /// <param name="strCNPJBase">CNPJ Base do Contribuinte</param>
        /// <returns>objeto</returns>
        protected wsumi.Contribuinte[] lerContribuinteCNPJBase(string strCNPJBase)
        {
            wsumi.Contribuinte[] contrib = wssrv.lerContribuinteCNPJBase(strTicket, strCNPJBase, out strWsErro);
            checarExcecaoWs();
            return contrib;            
        }

        /// <summary>
        /// Lista Contribuintes pelo CPF do S�cio.
        /// </summary>
        /// <param name="cpf">strCPF</param>
        /// <returns>objeto</returns>
        protected wsumi.Contribuinte[] listarContribuinteCPFSocio(string strCPF)
        {
            wsumi.Contribuinte[] contrib = wssrv.listarContribuinteCPFSocio(strTicket, strCPF, out strWsErro);
            checarExcecaoWs();            
            return contrib;
        }

        ///<summary>
        ///Lista os S�cios de um Contribuinte pelo N�cleo da Inscri��o Estadual
        ///</summary>
        ///<param name="strInscricaoEstadual">N�cleo da Inscri��o Estadual</param>
        ///<returns>objeto</returns>
        protected wsumi.Socio[] listarSocios(string strInscricaoEstadual)
        {
            wsumi.Socio[] soc = wssrv.listarSocios(strTicket, strInscricaoEstadual, out strWsErro);
            return soc;
        }

        /// <summary>
        /// Lista as ocorr�ncias fiscais de um Contribuinte pela Inscri��o Estadual
        /// </summary>
        /// <param name="strInscricaoEstadual">Inscri��o Estadual</param>
        /// <returns>objeto</returns>
        protected wsumi.Ocorrencia[] listarOcorrenciasFiscais(string strInscricaoEstadual)
        {
            wsumi.Ocorrencia[] oco = wssrv.listarOcorrenciasFiscais(strTicket, strInscricaoEstadual, out strWsErro);
            return oco;
        }

        /// <summary>
        /// Lista o recolhimento de um Contribuinte.
        /// </summary>
        /// <param name="strInscricaoEstadual">Inscri��o Estadual</param>
        /// <param name="dataInicial">Data Inicial do per�odo</param>
        /// <param name="dataFinal">Data Final do per�odo</param>
        /// <returns>objeto</returns>
        protected wsumi.Recolhimento[] listarRecolhimento(string strInscricaoEstadual, DateTime dataInicial, DateTime dataFinal)
        {
            wsumi.Recolhimento[] rec = null;
            if (dataFinal.Subtract(dataInicial).TotalDays > 30) { msgAtencao("O intervalo de datas n�o pode ser superior a 30 (trinta) dias."); return rec; }
            rec = wssrv.listarRecolhimento(strTicket, strInscricaoEstadual, dataInicial, dataFinal, out strWsErro);
            checarExcecaoWs2();
            if (rec.Length <= 0) { msgAtencao("Nenhum Recolhimento encontrado."); }
            return rec;
        }

        #endregion

        #region Contribuinte (off-line)

        /// <summary>
        /// L� um contribuinte da DB off-line
        /// </summary>
        /// <param name="strInscricaoEstadual">Inscri��o Estadual</param>
        /// <returns>objeto</returns>
        protected db.ContribuinteList lerUMIContribuinte(string strInscricaoEstadual)
        {
            db.ContribuinteList contrib = new db.ContribuinteList();
            contrib.lerInscricaoEstadual(strInscricaoEstadual);
            if (contrib.Count <= 0) return null;
            return contrib;
        }

        protected db.ContribuinteList lerUMIContribuinteCNPJ(string strCNPJ)
        {
            db.ContribuinteList contrib = new db.ContribuinteList();
            contrib.lerCNPJ(strCNPJ);
            if (contrib.Count <= 0) return null;
            return contrib;
        }

        protected db.ContribuinteList lerUMIContribuinteCNPJBase(string strCNPJ)
        {
            db.ContribuinteList contrib = new db.ContribuinteList();
            contrib.lerCNPJBase(strCNPJ);
            if (contrib.Count <= 0) return null;
            return contrib;
        }

        /// <summary>
        /// Conta total de Registros de Contribuinte no DB off-line
        /// </summary>
        /// <returns>N�mero de registros</returns>
        protected double contarContribuintes()
        {
            db.ContribuinteList contrib = new db.ContribuinteList();
            return contrib.contar();
        }

        /// <summary>
        /// Verifica se o Contribuinte existe e est� desatualizado
        /// </summary>
        /// <param name="lngSq_pessoa"></param>
        /// <param name="intSq_contribuinte"></param>
        /// <param name="strDt_ultima_atualizacao"></param>
        /// <returns>existe e desatualizado => true;
        /// existe e atualizado => false;
        /// n�o existe e (atualizado/desatualizado) => true</returns>
        protected bool desatualizado(long lngSq_pessoa, int intSq_contribuinte, object dtDt_ultima_atualizacao)
        {
            db.ContribuinteList contrib = new db.ContribuinteList();
            //Se n�o houver data da �ltima atualiza��o, verifica apenas se existe:
            if (dtDt_ultima_atualizacao == null){ return contrib.existe(lngSq_pessoa, intSq_contribuinte); }
            else{ return contrib.desatualizado(lngSq_pessoa, intSq_contribuinte, dtDt_ultima_atualizacao); }
        }

        /// <summary>
        /// Atualiza no DB
        /// </summary>
        /// <param name="contribListRemoto">lista de objetos Contribuinte</param>
        /// <param name="worker">objeto BackgroundWorker</param>
        /// <returns>n�mero de registros atualizados</returns>
        protected int atualizarContribuinte(db.ContribuinteList contribList, System.ComponentModel.BackgroundWorker worker)
        {
            return (contribList != null ? contribList.salvar(worker) : 0);
        }

        protected int atualizaContribuintesNovos()
        {
            // pegar ultima data no banco local.
            //TODO: refazer para novo dataset dscontribuinte
            //LocalDatabase.TdsLocalEntidadeEmpresaTableAdapters.EntidadeEmpresaTableAdapter TbAdptEntidadeEmpresa = new UMIMobile.LocalDatabase.TdsLocalEntidadeEmpresaTableAdapters.EntidadeEmpresaTableAdapter();
            //DateTime ultimaAtualizacao = Convert.ToDateTime(TbAdptEntidadeEmpresa.GetMaxDua());

            //string strUltimaAtualizacao = util.date2str(ultimaAtualizacao);

            // USAR WEBSERVICE PARA LISTAR TODOS ACIMA DESTA DATA E ATUALIZAR OU INSERIR NO BANCO LOCAL

            return 0;
        }

        protected int contribuintesAlterados()
        {
            //int res;
            //wsconsultasrn.wsconsultasrn netConsultas = new UMIMobile.wsconsultasrn.wsconsultasrn();
            // TODO: Implementar
            // netConsultas.ConsultaEmpresaContribuinteERP(strTicket,
            return 0;
        }

        #endregion

        #region ECF

        protected wsumi.ECFLacre[] lerECFLacre(long lngNumeroLacre)
        {
            wsumi.ECFLacre[] ecf = wssrv.lerECFLacre(strTicket, lngNumeroLacre, out strWsErro);
            checarExcecaoWs();
            return ecf;            
        }

        protected wsumi.ECFEquipamento[] lerECFEquipamento(string strNumeroSerie)
        {
            wsumi.ECFEquipamento[] ecf = wssrv.lerECFEquipamento(strTicket, strNumeroSerie, out strWsErro);
            checarExcecaoWs();
            return ecf;
        }

        protected wsumi.ECFEquipamento[] listarECFEquipamento(string strInscricaoEstadual)
        {
            wsumi.ECFEquipamento[] ecf = wssrv.listarECFEquipamento(strTicket, strInscricaoEstadual, out strWsErro);
            checarExcecaoWs();
            return ecf;
        }

        #endregion

        #region Notas Fiscais (Sa�da/Entrada/Eletr�nica)

        protected wsumi.NotaFiscalSaida[] listarNFSaida(string strInscricaoEstadual, DateTime dataInicial, DateTime dataFinal)
        {
            wsumi.NotaFiscalSaida[] nf = null;
            if (strInscricaoEstadual.Length <= 0) { msgAtencao("Informe a Inscri��o Estadual."); return nf; }
            if (dataFinal.Subtract(dataInicial).TotalDays > 5) { msgAtencao("O intervalo de datas n�o pode ser superior a 5 (cinco) dias."); return nf; }
            nf = wssrv.listarNotasFiscaisSaida(strTicket, strInscricaoEstadual, dataInicial, dataFinal, out strWsErro);
            if(checarExcecaoWs2()) return nf;
            if (nf.Length <= 0) { msgAtencao("Nenhuma Nota Fiscal encontrada."); }
            return nf;
        }

        protected wsumi.NotaFiscalEntrada[] listarNFEntrada(string strInscricaoEstadual, DateTime dataInicial, DateTime dataFinal)
        {
            wsumi.NotaFiscalEntrada[] nf = null;
            if (strInscricaoEstadual.Length <= 0) { msgAtencao("Informe a Inscri��o Estadual."); return nf; }
            if (dataFinal.Subtract(dataInicial).TotalDays > 5) { msgAtencao("O intervalo de datas n�o pode ser superior a 5 (cinco) dias."); return nf; }
            nf = wssrv.listarNotasFiscaisEntrada(strTicket, strInscricaoEstadual, dataInicial, dataFinal, out strWsErro);
            if (checarExcecaoWs2()) return nf;
            if (nf.Length <= 0) { msgAtencao("Nenhuma Nota Fiscal encontrada."); }
            return nf;
        }

        protected wsumi.NotaFiscalEletronica[] lerNFE(string strCNPJEmitente, long lngNumeroNota, string strCincoUltimosDigChave)
        {
            wsumi.NotaFiscalEletronica[] nf = wssrv.lerNotaFiscalEletronica(strTicket, strCNPJEmitente, lngNumeroNota, strCincoUltimosDigChave, out strWsErro);
            if(checarExcecaoWs2()) return nf;
            if (nf.Length <= 0) { msgAtencao("Nenhuma Nota Fiscal encontrada."); }
            return nf;
        }

        protected wsumi.NotaFiscalEletronica[] listarNFE(string strCNPJEmitente, DateTime dataInicial, DateTime dataFinal)
        {
            wsumi.NotaFiscalEletronica[] nf = wssrv.listarNotasFiscaisEletronicas(strTicket, strCNPJEmitente, dataInicial, dataFinal, out strWsErro);
            if (checarExcecaoWs2()) return nf;
            if (nf.Length <= 0) { msgAtencao("Nenhuma Nota Fiscal encontrada."); }
            return nf;
        }

        protected wsumi.NotaFiscalRegistro[] lerNFRegistro(long lngNumeroNota)
        {
            wsumi.NotaFiscalRegistro[] nfr = wssrv.lerNotaFiscalRegistro(strTicket, lngNumeroNota, out strWsErro);
            if (checarExcecaoWs2()) return nfr;
            return nfr;
        }

        #endregion

        #region Passes

        /// <summary>
        /// Lista Passes (Estaduais e Interestaduais) Abertos pela Placa.
        /// </summary>
        /// <param name="strPlaca">Placa do ve�culo</param>
        /// <returns>objeto</returns>
        protected wsumi.Passe[] listarPassesAbertos(string strPlaca)
        {
            wsumi.Passe[] passes = wssrv.listarPassesAbertos(strTicket, strPlaca, out strWsErro);
            checarExcecaoWs2();            
            return passes;
        }

        /// <summary>
        /// L� um Passe (Estaduais e Interestaduais) Aberto pelo N�mero.
        /// </summary>
        /// <param name="intNumero_Passe">N�mero do Passe</param>
        /// <returns>objeto</returns>
        protected wsumi.Passe[] lerPasseAberto(int intNumero_Passe)
        {
            wsumi.Passe[] passes = wssrv.lerPasseAberto(strTicket, intNumero_Passe, out strWsErro);
            checarExcecaoWs2();
            return passes;
        }               

        #endregion        
    
        #region GPS

        /// <summary>
        /// Recupera uma �nica inst�ncia (Singleton) do objeto Gps
        /// </summary>
        /// <param name="nomePorta">nome da porta serial</param>
        /// <param name="baudRate">taxa (velocidade) de transmiss�o</param>
        /// <returns>inst�ncia do objeto Gps</returns>
        public static GPS.Gps instanciaGps(string nomePorta, int baudRate)
        {
            if (gps == null) gps = new GPS.Gps(nomePorta, baudRate);
            
            return gps;
        }

        /// <summary>
        /// Recupera uma �nica inst�ncia (Singleton) do objeto Gps
        /// </summary>
        /// <returns>inst�ncia do objeto Gps</returns>
        public static GPS.Gps instanciaGps()
        {
            if (gps == null) gps = new GPS.Gps();
            
            return gps;
        }        

        /// <summary>
        /// Envia as informa��es do GPS para o webservice.
        /// </summary>
        protected void enviarGps()
        {
            wsumi.Gps[] gpsList = new umi.device.wsumi.Gps[1];
            wsumi.Gps g = new umi.device.wsumi.Gps();
            wsumi.GpsPosicao lat = new umi.device.wsumi.GpsPosicao();
            wsumi.GpsPosicao longit = new umi.device.wsumi.GpsPosicao();
            wsumi.GpsSatelite[] sats = new umi.device.wsumi.GpsSatelite[gps.Satelites.Count];

            lat.Graus = gps.Latitude.Graus;
            lat.Minutos = gps.Latitude.Minutos;
            lat.Hemisferio = gps.Latitude.Hemisferio;
            longit.Graus = gps.Longitude.Graus;
            longit.Minutos = gps.Longitude.Minutos;
            longit.Hemisferio = gps.Longitude.Hemisferio;

            g.IdDispositivo = lerIDDispositivo();
            g.Latitude = lat;
            g.Longitude = longit;
            g.Velocidade = gps.Velocidade;
            g.VelocidadeLimiteAlcancada = gps.VelocidadeLimiteAlcancada;
            g.DataHora = gps.DataHora;
            g.Orientacao = gps.Orientacao;
            g.DiluicaoHorizontal = gps.DiluicaoHorizontal;
            g.AltitudeNivelMar = gps.AltitudeNivelMar;
            g.AlturaWGS84 = gps.AlturaWGS84;            

            wssrv.registrarGPS(g, out strWsErro);
            checarExcecaoWs2();
        }

        #endregion

        #region Device

        public string lerIDDispositivo()
        {
            Device dev = new Device();
            return dev.GetDeviceID(lerNomeAplicacao());
        }

        #endregion
    }
}
