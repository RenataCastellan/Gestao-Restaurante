using MySql.Data.MySqlClient;
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
                command.Parameters.AddWithValue("@dataNascimento_cli", cliente.dataNascimento.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@telefone_cli", cliente.telefone);
                command.Parameters.AddWithValue("@email_cli", cliente.email);
                command.Parameters.AddWithValue("@preferenciasAlimentares_cli", cliente.preferencias);

                command.ExecuteNonQuery();

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
                    cliente.id_cliente = Convert.ToInt32(dados["id_cli"]);
                    cliente.nome = dados["nome_cli"].ToString();
                    cliente.cpf = dados["cpf_cli"].ToString();
                    if (dados["dataNascimento_cli"] != DBNull.Value)
                    {
                        cliente.dataNascimento = Convert.ToDateTime(dados["dataNascimento_cli"]);
                    }
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


        public static void AtualizarCliente(Cliente cliente)
        {
            try
            {
                string sql = "UPDATE Cliente SET nome_cli = @nome_cli, cpf_cli = @cpf_cli, dataNascimento_cli = @dataNascimento_cli, " +
                     "telefone_cli = @telefone_cli, email_cli = @email_cli, preferenciasAlimentares_cli = @preferenciasAlimentares_cli " +
                     "WHERE id_cli = @id_cli";

                MySqlCommand command = new MySqlCommand(sql, Conexao.Conectar());
                command.Parameters.AddWithValue("@nome_cli", cliente.nome);
                command.Parameters.AddWithValue("@cpf_cli", cliente.cpf);
                command.Parameters.AddWithValue("@dataNascimento_cli", cliente.dataNascimento.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@telefone_cli", cliente.telefone);
                command.Parameters.AddWithValue("@email_cli", cliente.email);
                command.Parameters.AddWithValue("@preferenciasAlimentares_cli", cliente.preferencias);
                command.Parameters.AddWithValue("@id_cli", cliente.id_cliente);


                int linhasAfetadas = command.ExecuteNonQuery();
                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Cliente atualizado com sucesso!", "Atualização Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nenhuma Alteração foi realizada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o cliente: " + ex.Message);
            }
        }

        public static bool ExcluirCliente(Cliente cliente)
        {
            try
            {
                string sql = "DELETE FROM Cliente WHERE cpf_cli = @cpf_cli";
                MySqlCommand command = new MySqlCommand(sql, Conexao.Conectar());
                command.Parameters.AddWithValue("@cpf_cli", cliente.cpf);
                int linhasAfetadas = command.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o cliente: " + ex.Message);
                return false;
            }
        }

        public static List<Cliente> ListarCliente()
        {
            List<Cliente> listaCliente = new List<Cliente>();

            try
            {
                string sql = "SELECT * FROM Cliente";

                MySqlCommand command = new MySqlCommand(sql, Conexao.Conectar());
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.nome = reader["nome_cli"].ToString();
                    cliente.cpf = reader["cpf_cli"].ToString();
                    cliente.dataNascimento = Convert.ToDateTime(reader["dataNascimento_cli"]);
                    cliente.telefone = reader["telefone_cli"].ToString();
                    cliente.email = reader["email_cli"].ToString();

                    listaCliente.Add(cliente);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os clientes" + ex.Message);
            }

            return listaCliente;
        }
    }

}
