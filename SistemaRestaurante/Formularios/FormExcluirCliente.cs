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
    public partial class FormExcluirCliente: Form
    {
        public FormExcluirCliente()
        {
            InitializeComponent();
        }

        private List<Cliente> lista = new List<Cliente>();

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

        private void FormExcluirCliente_Load(object sender, EventArgs e)
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

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (cbBuscarCliente.SelectedItem != null)
            {
                string nomeSelecionado = cbBuscarCliente.SelectedItem.ToString();
                Cliente cliente = lista.FirstOrDefault(c => c.nome == nomeSelecionado);

                if (cliente != null)
                {
                    DialogResult resultado = MessageBox.Show($"Tem certeza que deseja excluir o cliente {cliente.nome}?", "Confirmar Exclusão", MessageBoxButtons.YesNo);
                    
                    if (resultado == DialogResult.Yes)
                    {
                        bool sucesso = ClienteDAO.ExcluirCliente(cliente);
                        
                        if (sucesso)
                        {
                            lista.Remove(cliente);
                            cbBuscarCliente.Items.Remove(cliente.nome);
                            txtNome.Clear();
                            txtDataNasc.Clear();
                            txtTelefone.Clear();
                            txtEmail.Clear();
                            txtPreferencias.Clear();
                            txtCpf.Clear();
                            MessageBox.Show("Cliente excluído com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Erro ao excluir o cliente");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado.");
                }

            }
            else
            {
                MessageBox.Show("Selecione um cliente para excluir.");
            }
        }
    }
}
