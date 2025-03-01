using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaRestaurante.Models;
using SistemaRestaurante.DAO;

namespace SistemaRestaurante.Formularios
{
    public partial class FormCadastrarCliente: Form
    {
        public FormCadastrarCliente()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.nome = txtNome.Text;
            cliente.cpf = txtCpf.Text;
            cliente.dataNascimento = Convert.ToDateTime(txtDataNasc.Text);
            cliente.telefone = txtTelefone.Text;
            cliente.email = txtEmail.Text;
            cliente.preferencias = txtPreferencias.Text;
            ClienteDAO insCliente = new ClienteDAO();
            insCliente.Cadastrar(cliente);


            txtNome.Clear();
            txtCpf.Clear();
            txtPreferencias.Clear();
            txtDataNasc.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtNome.Select();
        }
    }
}
