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
    public class FuncionarioController
    {
        public FuncionarioController()
        {

        }
        // todos os clientes simples
        public List<Funcionario> GetFuncionario()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("QuintaDaNelsada")))
            {
                try
                {
                    //var output = connection.Query<Cliente>("select * from Cliente").ToList();
                    var output = connection.Query<Funcionarios>($"dbo.VerTodosFuncionarios").ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        // todos os clientes 3 tabelas
        public List<FuncionarioMoradaContacto> GetFuncionariosTotal()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("QuintaDaNelsada")))
            {
                try
                {
                    //var output = connection.Query<Cliente>("select * from Cliente").ToList();
                    var output = connection.Query<FuncionarioMoradaContacto>($"dbo.InfoCompletaFuncionarios").ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        // Adiciona um cliente e actualiza a tabela
        public List<Funcionario> AddFuncionario(string nome, int nif, DateTime data)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("QuintaDaNelsada")))
                {
                    var output = connection.Query<Funcionario>("dbo.InserirFuncionario @FUNCIONARIO_NOME,@FUNCIONARIO_VALIDADE_CONTRATO,@FUNCIONARIO_BI, @FUNCIONARIO_NIF, @FUNCIONARIO_SALARIO,@CARGO_ID",
                        new
                        {
                            CLIENTE_NOME = nome,
                            CLIENTE_NIF = nif,
                            CLIENTE_DATA_1_CONTACTO = data
                        }
                        ).ToList();
                    output = connection.Query<Funcionario>("dbo.VerTodosFuncionarios").ToList();
                    return output;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro a Inserir");
                return null;
            }
        }
        public List<Funcionario> DeleteFuncionario(int id)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("QuintaDaNelsada")))
                {
                    var output = connection.Query<Funcionario>("dbo.ApagarFuncionario @FUNCIONARIO_ID",
                        new
                        {
                            CLIENTE_ID = id
                        }
                        ).ToList();
                    output = connection.Query<Funcionario>("dbo.VerTodosFuncionarios").ToList();
                    return output;
                }
            }
            catch (Exception ex)
            
                MessageBox.Show("Erro a Inserir");
            }
            return null;
        }
    }
}
