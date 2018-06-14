﻿using System;
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
    public class FornecedorController
    {
        public FornecedorController()
        {

        }
        // todos os clientes simples
        public List<Fornecedor> GetFornecedor()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("QuintaDaNelsada")))
            {
                try
                {
                    //var output = connection.Query<Cliente>("select * from Cliente").ToList();
                    var output = connection.Query<Cliente>($"dbo.VerTodosfornecedores").ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        // todos os clientes 3 tabelas
        public List<ClienteMoradaContacto> GetFornecedoresTotal()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("QuintaDaNelsada")))
            {
                try
                {
                    //var output = connection.Query<Cliente>("select * from Cliente").ToList();
                    var output = connection.Query<ClienteMoradaContacto>($"dbo.InfoCompletaforncedor").ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        // Adiciona um cliente e actualiza a tabela
        public List<Cliente> AddFornecedor(string nome, int nif, DateTime data)
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
        public List<Cliente> DeleteCliente(int id)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("QuintaDaNelsada")))
                {
                    var output = connection.Query<Cliente>("dbo.ApagarCliente @FORNECEDOR_ID",
                        new
                        {
                            CLIENTE_ID = id
                        }
                        ).ToList();
                    output = connection.Query<Cliente>("dbo.VerTodosFornecedores").ToList();
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