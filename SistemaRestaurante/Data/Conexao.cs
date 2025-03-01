using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SistemaRestaurante.Data
{
    internal static class Conexao
    {
        static MySqlConnection _conexao;
        static string strconexao = "server=localhost;port=3306;uid=root;pwd=root;database=bd_restaurante";

        public static MySqlConnection Conectar()
        {
            try
            {
                _conexao = new MySqlConnection(strconexao);
                _conexao.Open();
                Console.WriteLine("Conexão realizada com sucesso!");
                return _conexao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar" + ex.Message);
            }
        }
    }
}
