﻿using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRestaurante.Data;
using SistemaRestaurante.Models;
using System.Windows.Forms;

namespace SistemaRestaurante.DAO
{
    internal class ClienteDAO
    {

        public void Cadastrar(Cliente cliente)
        {
            try
            {

                string sql = "INSERT INTO Cliente (nome_cli, cpf_cli, dataNascimento_cli, telefone_cli, email_cli, preferenciasAlimentares_cli) VALUES (@nome_cli, @cpf_cli, @dataNascimento_cli, @telefone_cli, @email_cli, @preferenciasAlimentares_cli)";


                MySqlCommand command = new MySqlCommand(sql, Conexao.Conectar());
                command.Parameters.AddWithValue("@nome_cli", cliente.nome);
                command.Parameters.AddWithValue("@cpf_cli", cliente.cpf);
                command.Parameters.AddWithValue("@dataNascimento_cli", cliente.dataNascimento);
                command.Parameters.AddWithValue("@telefone_cli", cliente.telefone);
                command.Parameters.AddWithValue("@email_cli", cliente.email);
                command.Parameters.AddWithValue("@preferenciasAlimentares_cli", cliente.preferencias);

                command.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizadao com sucesso");

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar o cliente: " + ex.Message);
            }
        }

        public static List<Cliente> BuscarCliente()
        {
            List<Cliente> lista = new List<Cliente>();
            string sql = "SELECT * FROM Cliente";

            try
            {

                MySqlCommand command = new MySqlCommand(sql, Conexao.Conectar());
                MySqlDataReader dados = command.ExecuteReader();

                while (dados.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.nome = dados["nome_cli"].ToString();
                    cliente.cpf = dados["cpf_cli"].ToString();
                    cliente.dataNascimento = Convert.ToDateTime(dados["dataNascimento_cli"]);
                    cliente.telefone = dados["telefone_cli"].ToString();
                    cliente.email = dados["email_cli"].ToString();
                    cliente.preferencias = dados["preferenciasAlimentares_cli"].ToString();

                    lista.Add(cliente);
                }

                dados.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            return lista;
            
        }
    }

}
