using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabalho_base_dados.Model;

namespace trabalho_base_dados.Controller
{
    class ClienteController
    {
        public List<Cliente> GetClientes(string CLIENTE_NOME)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("QuintaDaNelsada")) 
                ("InserirCliente)

        }
    }
}
