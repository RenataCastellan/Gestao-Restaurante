using SistemaRestaurante.DAO;
using SistemaRestaurante.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRestaurante.Formularios
{
    public partial class FormAtualizarCliente: Form
    {
        public FormAtualizarCliente()
        {
            InitializeComponent();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {

        }

        private List<Cliente> lista = new List<Cliente>();

        private void btAtualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cbBuscarCliente.SelectedItem != null)
                {
                    string nomeSelecionado = cbBuscarCliente.SelectedItem.ToString();
                    Cliente cliente = lista.FirstOrDefault(c => c.nome == nomeSelecionado);

                    if (cliente != null)
                    {
                        cliente.nome = txtNome.Text;
                        cliente.dataNascimento = Convert.ToDateTime(txtDataNasc.Text);
                        cliente.telefone = txtTelefone.Text;
                        cliente.email = txtEmail.Text;
                        cliente.cpf = txtCpf.Text;
                        cliente.preferencias= txtPreferencias.Text;

                        ClienteDAO.AtualizarCliente(cliente);
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado");
                    }

                }
                else
                {
                    MessageBox.Show("Selecione um cliente para atualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar atualizar o cliente" + ex.Message);
            }
        }

        private void cbBuscarCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            if (cbBuscarCliente.SelectedItem != null)
            {
                string nomeSelecionado = cbBuscarCliente.SelectedItem.ToString();
                Cliente cliente = lista.FirstOrDefault(c => c.nome == nomeSelecionado);

                if (cliente != null)
                {
                    txtNome.Text = cliente.nome;
                    txtDataNasc.Text = cliente.dataNascimento.ToString("dd/MM/yyyy");
                    txtTelefone.Text = cliente.telefone;
                    txtEmail.Text = cliente.email;
                    txtPreferencias.Text = cliente.preferencias;
                    txtCpf.Text = cliente.cpf;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado");
                }
            }
            else
            {
                MessageBox.Show("Selecione um nome para consultar");
            }
        }

        private void FormAtualizarCliente_Load(object sender, EventArgs e)
        {
            try
            {

                lista = ClienteDAO.BuscarCliente();

                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("Nenhum cliente encontrado.");
                    return;
                }

                cbBuscarCliente.Items.Clear();

                foreach (Cliente cliente in lista)
                {
                    cbBuscarCliente.Items.Add(cliente.nome);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes" + ex.Message);
            }
        }
    }
}
