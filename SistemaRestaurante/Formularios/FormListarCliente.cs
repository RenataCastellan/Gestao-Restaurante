using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaRestaurante.DAO;
using SistemaRestaurante.Models;

namespace SistemaRestaurante.Formularios
{
    public partial class FormListarCliente: Form
    {
        public FormListarCliente()
        {
            InitializeComponent();
        }

        private void FormListarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                List<Cliente> listaCliente = ClienteDAO.ListarCliente();

                if (listaCliente == null || listaCliente.Count == 0)
                {
                    MessageBox.Show("Nenhum cliente encontrado");
                }
                else
                {
                    dtGridViewCliente.Rows.Clear();
                }

                foreach (Cliente cliente in listaCliente)
                {
                    dtGridViewCliente.Rows.Add(cliente.nome, cliente.cpf, cliente.dataNascimento.ToString("dd/MM/yyyy"), cliente.telefone, cliente.email);

                }

                dtGridViewCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtGridViewCliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dtGridViewCliente.AllowUserToResizeRows = false;
                dtGridViewCliente.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar cliente: " + ex.Message);
            }
        }
    }
}
