using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabalho_base_dados.Properties;
using System.Configuration;


namespace trabalho_base_dados
{
    class ControllerClientes
    {
        private ObservableCollection<Cliente> clienteList;
        public ObservableCollection<Cliente> ClienteList { get => clienteList; set => clienteList = value; }

        public ControllerClientes()
        {
            ClienteList = new ObservableCollection<Cliente>();
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["QuintaDaNelsada"].ConnectionString);
            try
            {
                using (connection)
                using (SqlCommand command = new SqlCommand("Select * From Cliente", connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Cliente c1 = new Cliente {
                            Cliente_ID = Convert.ToInt32(reader["CLIENTE_ID"]),
                            Cliente_Nome = reader["CLIENTE_NOME"].ToString(),
                            Cliente_Nif = reader["CLIENTE_NIF"].ToString(),
                            Cliente_Data_1_Contacto = Convert.ToDateTime(reader["CLIENTE_DATA_1_CONTACTO"])
                        };
                        ClienteList.Add(c1);
                    }
                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                connection.Close();

            }
        }

        
    }
}
