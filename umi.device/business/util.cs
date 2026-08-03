using System;

namespace umi.device.business
{
	/// <summary>
	/// Summary description for util.
	/// </summary>
	public class util
	{
		public util()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public static DateTime str2date(string datestr)
		{
            datestr = datestr.Replace("/", String.Empty);
			if (datestr.Length < 8) return new DateTime(1900, 1, 1);

			int dia = Convert.ToInt32(datestr.Substring(0, 2));
			int mes = Convert.ToInt32(datestr.Substring(2, 2));
			int ano = Convert.ToInt32(datestr.Substring(4, 4));

			DateTime dt = new DateTime(ano, mes, dia);
			return dt;
		}

		public static string date2str(DateTime d)
		{
			string str = d.Day.ToString().PadLeft(2, '0') + d.Month.ToString().PadLeft(2, '0') + d.Year.ToString();
			return str;
		}

        public static bool isNumber(string inputData)
        {
            System.Text.RegularExpressions.Regex _isNumber = new System.Text.RegularExpressions.Regex("^[0-9]+$");
            System.Text.RegularExpressions.Match m = _isNumber.Match(inputData);
            return m.Success;
        }

        public static string webserviceErrorMsg(string strMessage)
        {
            if ((strMessage != string.Empty) && (strMessage.ToLower().IndexOf("server was") >= 0))
            {
                strMessage = strMessage.ToLower().Replace("server was unable to process request. --> ", String.Empty);
                strMessage = strMessage.Replace("&#225;", "á");
                strMessage = strMessage.Replace("&#226;", "â");
                strMessage = strMessage.Replace("&#227;", "ã");
                strMessage = strMessage.Replace("&#233;", "é");
                strMessage = strMessage.Replace("&#234;", "ê");
                strMessage = strMessage.Replace("&#243;", "ó");
                strMessage = strMessage.Replace("&#244;", "ô");
                strMessage = strMessage.Replace("&#250;", "ú");
                strMessage = strMessage.Replace("&quot;", "\"");
                strMessage = strMessage.Replace("&#231;", "ç");
            }
            return strMessage;
        }

        public static void showDefaultErrorMsg(string strMessage)
        {
            if ((strMessage != string.Empty) && !(strMessage.ToLower().IndexOf("Não é possível exibir uma mensagem") >= 0))
            {
                System.Windows.Forms.MessageBox.Show(strMessage); 
                //strMessage = "Falha na aplicação.";
            }
        }        

        /// <summary>
        /// Verifica se há mensagem de exceção do webservice.
        /// Se houver, a mensagem será exibida;
        /// </summary>
        /// <param name="strMessage">Mensagem de erro</param>
        public static void checarExcecao(string strMessage)
        {
            if (strMessage != string.Empty) { throw new Exception(strMessage); }
        }
	}
}
