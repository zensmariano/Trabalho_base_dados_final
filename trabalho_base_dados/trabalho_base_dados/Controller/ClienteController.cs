using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabalho_base_dados.Model;
using Dapper;
using System.Windows.Forms;

namespace trabalho_base_dados.Controller
{
    public class ClienteController
    {
        public ClienteController()
        {

        }
        // todos os clientes simples
        public List<Cliente> GetClientes()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("QuintaDaNelsada")))
            {
                try
                {
                    //var output = connection.Query<Cliente>("select * from Cliente").ToList();
                    var output = connection.Query<Cliente>($"dbo.VerTodosClientes").ToList();
                    return output;
                }
                catch(Exception ex)
                {
                    return null;
                }
            }
        }
        // todos os clientes 3 tabelas
        public List<Cliente> GetClientesTotal()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("QuintaDaNelsada")))
            {
                try
                {
                    //var output = connection.Query<Cliente>("select * from Cliente").ToList();
                    var output = connection.Query<Cliente>($"dbo.InfoCompletaCliente").ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        // Adiciona um cliente e actualiza a tabela
        public List<Cliente> AddClient(string nome, int nif, DateTime data)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("QuintaDaNelsada")))
                {
                    var output = connection.Query<Cliente>("dbo.InserirCliente @CLIENTE_NOME, @CLIENTE_NIF, @CLIENTE_DATA_1_CONTACTO",
                        new
                        {
                            CLIENTE_NOME = nome,
                            CLIENTE_NIF = nif,
                            CLIENTE_DATA_1_CONTACTO = data
                        }
                        ).ToList();
                    output = connection.Query<Cliente>("dbo.VerTodosClientes").ToList();
                    return output;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro a Inserir");
                return null;
            }
        }
        // Deleta um cliente
        public List<Cliente> DeleteCliente(int id)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("QuintaDaNelsada")))
                {
                    var output = connection.Query<Cliente>("dbo.ApagarCliente @CLIENTE_ID",
                        new
                        {
                            CLIENTE_ID = id
                        }
                        ).ToList();
                    output = connection.Query<Cliente>("dbo.VerTodosClientes").ToList();
                    return output;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro a Inserir");
            }
            return null;
        }
        // Altera um cliente
        public List<Cliente> AlterarCliente(int id,string nome, int nif)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("QuintaDaNelsada")))
                {
                    var output = connection.Query<Cliente>($"dbo.ActualizarCliente @CLIENTE_ID, @CLIENTE_NOME, @CLIENTE_NIF",
                        new
                        {
                            CLIENTE_ID = id,
                            CLIENTE_NOME = nome,
                            CLIENTE_NIF = nif
                        }
                        ).ToList();
                    return output;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro a Inserir");
            }
            return null;
        }
        // cria uma morada pra um cliente
        public List<Cliente> CriarMorada(int clienteID, string rua, int cp)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("QuintaDaNelsada")))
                {
                    var output = connection.Query<Cliente>($"dbo.CriarMoradaCliente @CC_ID,@CLIENTE_ID,@RUA",
                        new
                        {
                            CLIENTE_ID = clienteID,
                            CC_ID = cp,
                            RUA = rua   
                        }
                        ).ToList();
                    return output;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro a Inserir");
            }
            return null;
        }
    }
}
