using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Models
{
    public class Cliente
    {
        public int id_cliente;
        public string nome;
        public string cpf;
        public DateTime dataNascimento;
        public string telefone;
        public string email;
        public string preferencias;
    }
}
