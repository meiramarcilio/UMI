using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace umi.device.db
{
    public class SQLiteBlocks
    {
        public static IDataReader ExecuteReader(string strConnectionString, string strCommandText, object[] parameterValues)
        {
            if (strConnectionString == string.Empty) { throw new Exception("String de Conexão vazia."); }
            if (strCommandText == string.Empty) { throw new Exception("Texto do Comando (query) vazia."); }
            
            //cria objeto Connection
            SQLiteConnection conn = new SQLiteConnection(strConnectionString);
            
            //cria objeto Command:
            SQLiteCommand comm = new SQLiteCommand(strCommandText, conn);
            
            try
            {
                //Abre conexão:
                conn.Open();

                //Adiciona parâmetros:                
                if (parameterValues != null && parameterValues.Length > 0)
                {
                    SQLiteParameter param = new SQLiteParameter();
                    foreach (object value in parameterValues)
                    {
                        param = new SQLiteParameter();
                        param.Value = value;
                        comm.Parameters.Add(param);
                    }
                }

                //executa consulta:
                return comm.ExecuteReader();
            }
            catch (SQLiteException)
            {
                throw;
            }
            finally
            {
                //Fecha conexão se aberta:
                if (conn.State == ConnectionState.Open) { conn.Clone(); }
            }
        }

        public static int ExecuteNonQuery(string strConnectionString, string strCommandText, object[] parameterValues)
        {
            if (strConnectionString == string.Empty) { throw new Exception("String de Conexão vazia."); }
            if (strCommandText == string.Empty) { throw new Exception("Texto do Comando (query) vazia."); }
            
            //cria objeto Connection
            SQLiteConnection conn = new SQLiteConnection(strConnectionString);
            
            //cria objeto Command:
            SQLiteCommand comm = new SQLiteCommand(strCommandText, conn);
            
            try
            {
                //Abre conexão:
                conn.Open();

                //Adiciona parâmetros:                
                if (parameterValues != null && parameterValues.Length > 0)
                {
                    SQLiteParameter param = new SQLiteParameter();
                    foreach (object value in parameterValues)
                    {
                        param = new SQLiteParameter();
                        param.Value = value;
                        comm.Parameters.Add(param);
                    }
                }

                //executa consulta:
                return comm.ExecuteNonQuery();
            }
            catch (SQLiteException)
            {
                throw;
            }
            finally
            {
                //Fecha conexão se aberta:
                if (conn.State == ConnectionState.Open) { conn.Clone(); }
            }
        }

        public static object ExecuteScalar(string strConnectionString, string strCommandText, object[] parameterValues)
        {
            if (strConnectionString == string.Empty) { throw new Exception("String de Conexão vazia."); }
            if (strCommandText == string.Empty) { throw new Exception("Texto do Comando (query) vazia."); }

            //cria objeto Connection
            SQLiteConnection conn = new SQLiteConnection(strConnectionString);

            //cria objeto Command:
            SQLiteCommand comm = new SQLiteCommand(strCommandText, conn);

            try
            {
                //Abre conexão:
                conn.Open();

                //Adiciona parâmetros:                
                if (parameterValues != null && parameterValues.Length > 0) 
                {
                    SQLiteParameter param = new SQLiteParameter();
                    foreach (object value in parameterValues)
                    {
                        param = new SQLiteParameter();
                        param.Value = value;
                        comm.Parameters.Add(param);                        
                    }
                }

                //executa consulta:
                return comm.ExecuteScalar();
            }
            catch (SQLiteException)
            {
                throw;
            }
            finally
            {
                //Fecha conexão se aberta:
                if (conn.State == ConnectionState.Open) { conn.Clone(); }
            }
        }        
    }
}
