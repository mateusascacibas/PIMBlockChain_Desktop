using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace dbDLLConfiguracao
{
    public class Configuracao
    {
        public string StrConfiguracao { get; set; }

        /// <summary>
        /// Construtor da Classe Pega a string de conexao da base do arquivo de configuração.
        /// </summary>
        public Configuracao()
        {
            StrConfiguracao = ConfigurationManager.ConnectionStrings["PIM_BlockChain"].ConnectionString;
        }


    }
}
