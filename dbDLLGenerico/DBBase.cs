using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dbDLLConfiguracao;

namespace dbDLLGenerico
{
    public class DBBase
    {
        public void ExecutaInstrucaoNaBase(string QuerySQL)
        {

            Configuracao conf = new Configuracao();

            string strConxao = conf.StrConfiguracao;
            "Data Source=LAPTOP-8C3VQ7PF\SQLEXPRESS;Initial Catalog=PIM_BlockChain;Integrated Security=True";
            string Query = QuerySQL;
            SqlConnection con = new SqlConnection(strConxao);
            SqlCommand sqlCommand = new SqlCommand(Query, con);

            try
            {
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
                erro += "   !!!";
            }
            finally
            {
                con.Close();
            }

        }
    }
}