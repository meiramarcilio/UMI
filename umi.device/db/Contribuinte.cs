using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace umi.device.db
{
    [Serializable]
    public class ContribuinteList : List<Contribuinte>
    {
        #region Atributos
        
        private string strConn = string.Empty;

        #endregion

        #region Construtor

        public ContribuinteList() : base() 
        {
            //TODO: encriptar strSenha e desencriptar na connectionstring:            
            string strDbPath = string.Format("{0}{1}db{1}umidb",
                    Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase),
                    Path.DirectorySeparatorChar);
            strConn = string.Format("data source={0}; password={1}", 
                strDbPath, Properties.Resources.db_password);
        }

        #endregion

        #region Métodos customizados

        private void adicionarItems(IDataReader dr)
        {
            Clear(); //limpa os itens            
            while (dr.Read())
            {
                this.Add(new Contribuinte(
                    (DBNull.Value.Equals(dr["SQ_PESSOA"]) ? 0 : Convert.ToInt64(dr["SQ_PESSOA"])),
                        (DBNull.Value.Equals(dr["SQ_CONTRIBUINTE"]) ? 0 : Convert.ToInt32(dr["SQ_CONTRIBUINTE"])),
                        (DBNull.Value.Equals(dr["INSCRICAO_ESTADUAL"]) ? string.Empty : Convert.ToString(dr["INSCRICAO_ESTADUAL"])),
                        (DBNull.Value.Equals(dr["NM_FORMAL"]) ? string.Empty : Convert.ToString(dr["NM_FORMAL"])),
                        (DBNull.Value.Equals(dr["NU_CNPJ"]) ? string.Empty : Convert.ToString(dr["NU_CNPJ"])),                        
                        (DBNull.Value.Equals(dr["ST_CONTRIBUINTE"]) ? string.Empty : Convert.ToString(dr["ST_CONTRIBUINTE"])),
                        (DBNull.Value.Equals(dr["SITUACAO"]) ? string.Empty : Convert.ToString(dr["SITUACAO"])),
                        (DBNull.Value.Equals(dr["DT_ULTIMA_ATUALIZACAO"]) ? null : dr["DT_ULTIMA_ATUALIZACAO"])));
            }
        }

        /// <summary>
        /// Lê um Contribuinte pela Chave
        /// </summary>
        /// <param name="lngSq_pessoa">identificador da pessoa</param>
        /// <param name="intSq_contribuinte">identificador do contribuinte</param>
        public void ler(long lngSq_pessoa, int intSq_contribuinte)
        {
            using (IDataReader dr = db.SQLiteBlocks.ExecuteReader(strConn, "SELECT * FROM vwcontribuinte WHERE SQ_PESSOA=? AND SQ_CONTRIBUINTE=?",
                new object[] { lngSq_pessoa, intSq_contribuinte }))
            {
                adicionarItems(dr);
            }
        }

        /// <summary>
        /// Lê um Contribuinte pela Inscrição Estadual
        /// </summary>
        /// <param name="strInscricaoEstadual">Inscrição Estadual</param>
        public void lerInscricaoEstadual(string strInscricaoEstadual)
        {           
            using (IDataReader dr = db.SQLiteBlocks.ExecuteReader(strConn, "SELECT * FROM vwcontribuinte WHERE INSCRICAO_ESTADUAL=?", new object[] { strInscricaoEstadual }))
            {
                adicionarItems(dr);
            }
        }

        /// <summary>
        /// Lê um Contribuinte pelo CNPJ/CPF
        /// </summary>
        /// <param name="strCNPJ">CNPJ/CPF</param>
        public void lerCNPJ(string strCNPJ)
        {
            using (IDataReader dr = db.SQLiteBlocks.ExecuteReader(strConn, "SELECT * FROM vwcontribuinte WHERE NU_CNPJ=?", new object[] { strCNPJ }))
            {
                adicionarItems(dr);
            }
        }

        /// <summary>
        /// Lê um Contribuinte pelo CNPJ Base
        /// </summary>
        /// <param name="strCNPJBase">CNPJ Base</param>
        public void lerCNPJBase(string strCNPJBase)
        {
            using (IDataReader dr = db.SQLiteBlocks.ExecuteReader(strConn, "SELECT * FROM vwcontribuinte WHERE SUBSTR(NU_CNPJ, 0, 8)=?", new object[] { strCNPJBase }))
            {
                adicionarItems(dr);
            }
        }

        /// <summary>
        /// Conta total de Registros de Contribuinte no DB
        /// </summary>
        /// <returns>Número de registros</returns>
        public double contar()
        {
            object contador = db.SQLiteBlocks.ExecuteScalar(strConn, "SELECT COUNT(*) FROM vwcontribuinte", null);
            return (contador != null) ? Convert.ToDouble(contador) : 0;
            //return Convert.ToDouble(db.SQLiteBlocks.ExecuteScalar(strConn, "SELECT COUNT(*) FROM vwcontribuinte", null));
        }

        /// <summary>
        /// Verifica se o Contribuinte existe e está desatualizado
        /// </summary>
        /// <param name="lngSq_pessoa"></param>
        /// <param name="intSq_contribuinte"></param>
        /// <param name="dtDt_ultima_atualizacao"></param>
        /// <returns>existe e desatualizado => true;
        /// existe e atualizado => false;
        /// não existe e (atualizado/desatualizado) => true</returns>
        public bool desatualizado(long lngSq_pessoa, int intSq_contribuinte, object dtDt_ultima_atualizacao)
        {
            return !(Convert.ToDouble(db.SQLiteBlocks.ExecuteScalar(strConn, "SELECT COUNT(*) FROM contribuinte WHERE (SQ_PESSOA=? AND SQ_CONTRIBUINTE=?) AND (datetime(DT_ULTIMA_ATUALIZACAO)>=strftime('%Y-%m-%d %H:%M:%S', ?))",
                new object[] { lngSq_pessoa, intSq_contribuinte, DateTime.Parse(dtDt_ultima_atualizacao.ToString()).ToString("yyyy-MM-dd HH:mm:ss")})) > 0);
        }

        /// <summary>
        /// Verifica se um Contribuinte já existe no DB
        /// </summary>
        /// <param name="lngSq_pessoa"></param>
        /// <param name="intSq_contribuinte"></param>
        /// <returns>true = Contribuinte encontrado; false = não encontrado.</returns>
        public bool existe(long lngSq_pessoa, int intSq_contribuinte)
        {
            return (Convert.ToDouble(db.SQLiteBlocks.ExecuteScalar(strConn, "SELECT COUNT(*) FROM contribuinte WHERE SQ_PESSOA=? AND SQ_CONTRIBUINTE=?",
                new object[] { lngSq_pessoa, intSq_contribuinte })) > 0);
        }

        /// <summary>
        /// Salva todos os Contribuintes da lista.
        /// </summary>
        public void salvar()
        {
            foreach (Contribuinte c in this)
            {
                //Se ainda não existe no DB, então insere; senão atualiza.
                if (!existe(c.SQ_PESSOA, c.SQ_CONTRIBUINTE))
                {
                    //INSERT
                    db.SQLiteBlocks.ExecuteNonQuery(strConn, "INSERT INTO contribuinte (SQ_PESSOA, SQ_CONTRIBUINTE, INSCRICAO_ESTADUAL, NM_FORMAL, NU_CNPJ, ST_CONTRIBUINTE, DT_ULTIMA_ATUALIZACAO) VALUES (?,?,?,?,?,?,?)",
                        new object[] { c.SQ_PESSOA, c.SQ_CONTRIBUINTE, c.INSCRICAO_ESTADUAL, c.NM_FORMAL, 
                            c.NU_CNPJ, c.ST_CONTRIBUINTE, c.DT_ULTIMA_ATUALIZACAO });
                }
                else
                {
                    //UPDATE
                    db.SQLiteBlocks.ExecuteNonQuery(strConn, "UPDATE contribuinte SET NM_FORMAL=?, NU_CNPJ=?, ST_CONTRIBUINTE=?, DT_ULTIMA_ATUALIZACAO=? WHERE SQ_PESSOA=? AND SQ_CONTRIBUINTE=?",
                        new object[] { c.NM_FORMAL, c.NU_CNPJ, c.ST_CONTRIBUINTE, c.DT_ULTIMA_ATUALIZACAO,
                        c.SQ_PESSOA, c.SQ_CONTRIBUINTE });
                }
            }
        }

        /// <summary>
        /// Salva todos os Contribuintes da lista (Processamento em background)
        /// </summary>
        /// <param name="worker">objeto BackgroundWorker</param>
        public int salvar(System.ComponentModel.BackgroundWorker worker)
        {
            int atualizados = 0;
            foreach (Contribuinte c in this)
            {
                //Se ainda não existe no DB, então insere; senão atualiza.
                if (!existe(c.SQ_PESSOA, c.SQ_CONTRIBUINTE))
                {
                    //INSERT
                    db.SQLiteBlocks.ExecuteNonQuery(strConn, "INSERT INTO contribuinte (SQ_PESSOA, SQ_CONTRIBUINTE, INSCRICAO_ESTADUAL, NM_FORMAL, NU_CNPJ, ST_CONTRIBUINTE, DT_ULTIMA_ATUALIZACAO) VALUES (?,?,?,?,?,?,?)",
                        new object[] { c.SQ_PESSOA, c.SQ_CONTRIBUINTE, c.INSCRICAO_ESTADUAL, c.NM_FORMAL, 
                            c.NU_CNPJ, c.ST_CONTRIBUINTE, c.DT_ULTIMA_ATUALIZACAO });
                }
                else
                {
                    //UPDATE
                    db.SQLiteBlocks.ExecuteNonQuery(strConn, "UPDATE contribuinte SET NM_FORMAL=?, NU_CNPJ=?, ST_CONTRIBUINTE=?, DT_ULTIMA_ATUALIZACAO=? WHERE SQ_PESSOA=? AND SQ_CONTRIBUINTE=?",
                        new object[] { c.NM_FORMAL, c.NU_CNPJ, c.ST_CONTRIBUINTE, c.DT_ULTIMA_ATUALIZACAO,
                        c.SQ_PESSOA, c.SQ_CONTRIBUINTE });
                }
                atualizados++;

                //Atualiza o BackGroundWorker para atualizar o ProgressBar1
                worker.ReportProgress((atualizados / Count) * 100);
            }

            return atualizados;
        }

        #endregion
    }

    [Serializable]
    public class Contribuinte
    {
        #region Atributos

        private long lngSQ_PESSOA = 0;
        private int intSQ_CONTRIBUINTE = 0;
        private string strINSCRICAO_ESTADUAL = string.Empty;
        private string strNM_FORMAL = string.Empty;
        private string strNU_CNPJ = string.Empty;
        private string strST_CONTRIBUINTE = string.Empty;
        private string strSITUACAO = string.Empty;
        private object dtDT_ULTIMA_ATUALIZACAO = null;

        #endregion

        #region Propriedades

        public long SQ_PESSOA
        {
            set { lngSQ_PESSOA = value; }
            get { return lngSQ_PESSOA; }
        }

        public int SQ_CONTRIBUINTE
        {
            set { intSQ_CONTRIBUINTE = value; }
            get { return intSQ_CONTRIBUINTE; }
        }

        public string INSCRICAO_ESTADUAL
        {
            set { strINSCRICAO_ESTADUAL = value; }
            get { return strINSCRICAO_ESTADUAL; }
        }

        public string NM_FORMAL
        {
            set { strNM_FORMAL = value; }
            get { return strNM_FORMAL; }
        }

        public string NU_CNPJ
        {
            set { strNU_CNPJ = value; }
            get { return strNU_CNPJ; }
        }

        public string ST_CONTRIBUINTE
        {
            set { strST_CONTRIBUINTE = value; }
            get { return strST_CONTRIBUINTE; }
        }

        public string SITUACAO
        {
            set { strSITUACAO = value; }
            get { return strSITUACAO; }
        }

        public object DT_ULTIMA_ATUALIZACAO
        {
            set { dtDT_ULTIMA_ATUALIZACAO = value; }
            get { return dtDT_ULTIMA_ATUALIZACAO; }
        }

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor vazio
        /// </summary>
        public Contribuinte()
        {
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public Contribuinte(long _SQ_PESSOA, int _SQ_CONTRIBUINTE, string _INSCRICAO_ESTADUAL,
            string _NM_FORMAL, string _NU_CNPJ, string _ST_CONTRIBUINTE, string _SITUACAO,
            object _DT_ULTIMA_ATUALIZACAO)
        {
            lngSQ_PESSOA = _SQ_PESSOA;
            intSQ_CONTRIBUINTE = _SQ_CONTRIBUINTE;
            strINSCRICAO_ESTADUAL = _INSCRICAO_ESTADUAL;
            strNM_FORMAL = _NM_FORMAL;
            strNU_CNPJ = _NU_CNPJ;
            strST_CONTRIBUINTE = _ST_CONTRIBUINTE;
            strSITUACAO = _SITUACAO;
            dtDT_ULTIMA_ATUALIZACAO = _DT_ULTIMA_ATUALIZACAO;
        }

        #endregion
    }
}
