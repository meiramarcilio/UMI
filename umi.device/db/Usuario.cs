using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using umi.device.business;
using System.IO;

namespace umi.device.db
{
    [Serializable]
    public class UsuarioList : List<Usuario>
    {
        #region Atributos
        
        private string strConn = string.Empty;

        #endregion

        #region Construtor

        public UsuarioList() : base() 
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
                this.Add(new Usuario(
                    (DBNull.Value.Equals(dr["SQ_PESSOA"]) ? 0 : Convert.ToInt64(dr["SQ_PESSOA"])),                        
                        (DBNull.Value.Equals(dr["NM_FORMAL"]) ? string.Empty : Convert.ToString(dr["NM_FORMAL"])),
                        (DBNull.Value.Equals(dr["CD_USUARIO"]) ? string.Empty : Convert.ToString(dr["CD_USUARIO"])),
                        (DBNull.Value.Equals(dr["PASSWORD"]) ? string.Empty : Convert.ToString(dr["PASSWORD"])),
                        (DBNull.Value.Equals(dr["DT_ULTIMO_LOGIN"]) ? null : dr["DT_ULTIMO_LOGIN"])));
            }
        }

        public void ler(string strCd_usuario)
        {
            using (IDataReader dr = db.SQLiteBlocks.ExecuteReader(strConn, "SELECT * FROM usuario WHERE CD_USUARIO=?",
                new object[] { strCd_usuario }))
            {
                adicionarItems(dr);
            }
        }

        /// <summary>
        /// Verifica se um Usuário já existe no DB
        /// </summary>
        /// <param name="strCd_usuario">Código (login) do usuário</param>
        /// <returns>true = Usuário encontrado; false = não encontrado.</returns>
        public bool existe(string strCd_usuario)
        {
            return (Convert.ToDouble(db.SQLiteBlocks.ExecuteScalar(strConn, "SELECT COUNT(*) FROM usuario WHERE CD_USUARIO=?",
                new object[] { strCd_usuario })) > 0);
        }

        /// <summary>
        /// Salva todos os Usuários da lista.
        /// </summary>
        public void salvar()
        {
            foreach (Usuario u in this)
            {
                u.PASSWORD = seguranca.getMd5Hash(u.PASSWORD);

                //Se ainda não existe no DB, então insere; senão atualiza.
                if (!existe(u.CD_USUARIO))
                {
                    //INSERT
                    db.SQLiteBlocks.ExecuteNonQuery(strConn, "INSERT INTO usuario (SQ_PESSOA, NM_FORMAL, CD_USUARIO, PASSWORD, DT_ULTIMO_LOGIN) VALUES (?,?,?,?,?)",
                        new object[] { u.SQ_PESSOA, u.NM_FORMAL, u.CD_USUARIO, u.PASSWORD, u.DT_ULTIMO_LOGIN });
                }
                else
                {
                    //UPDATE
                    db.SQLiteBlocks.ExecuteNonQuery(strConn, "UPDATE usuario SET NM_FORMAL=?, PASSWORD=?, DT_ULTIMO_LOGIN=? WHERE SQ_PESSOA=?",
                        new object[] { u.NM_FORMAL, u.PASSWORD, u.DT_ULTIMO_LOGIN, u.SQ_PESSOA });
                }
            }
        }

        /// <summary>
        /// Autentica o usuário na base de dados off-line
        /// </summary>
        /// <param name="strCd_usuario">Código (login) do usuário</param>
        /// <param name="strPassword">Senha</param>
        /// <returns>true => usuário autenticado; false = não autenticado.</returns>
        public bool login(string strCd_usuario, string strPassword)
        {
            ler(strCd_usuario);

            if (Count <= 0) throw new Exception("Usuário não encontrado");
            if(!seguranca.verifyMd5Hash(strPassword, this[0].PASSWORD)) throw new Exception("Senha incorreta.");
            
            return true;
        }

        #endregion
    }

    [Serializable]
    public class Usuario
    {
        #region Atributos

        private long lngSQ_PESSOA = 0;
        private string strNM_FORMAL = string.Empty;
        private string strCD_USUARIO = string.Empty;
        private string strPASSWORD = string.Empty;
        private object dtDT_ULTIMO_LOGIN = null;

        #endregion

        #region Propriedades

        public long SQ_PESSOA
        {
            set { lngSQ_PESSOA = value; }
            get { return lngSQ_PESSOA; }
        }

        public string NM_FORMAL
        {
            set { strNM_FORMAL = value; }
            get { return strNM_FORMAL; }
        }

        public string CD_USUARIO
        {
            set { strCD_USUARIO = value; }
            get { return strCD_USUARIO; }
        }

        public string PASSWORD
        {
            set { strPASSWORD = value; }
            get { return strPASSWORD; }
        }

        public object DT_ULTIMO_LOGIN
        {
            set { dtDT_ULTIMO_LOGIN = value; }
            get { return dtDT_ULTIMO_LOGIN; }
        }

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor vazio
        /// </summary>
        public Usuario()
        {
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public Usuario(long _SQ_PESSOA, string _NM_FORMAL, string _CD_USUARIO, string _PASSWORD,
            object _DT_ULTIMO_LOGIN)
        {
            lngSQ_PESSOA = _SQ_PESSOA;
            strNM_FORMAL = _NM_FORMAL;
            strCD_USUARIO = _CD_USUARIO;
            strPASSWORD = _PASSWORD;
            dtDT_ULTIMO_LOGIN = _DT_ULTIMO_LOGIN;
        }

        #endregion
    }
}
