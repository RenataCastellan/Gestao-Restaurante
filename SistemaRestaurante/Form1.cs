using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaRestaurante.Formularios;


namespace SistemaRestaurante
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCasdatrar_Click(object sender, EventArgs e)
        {
            FormCadastrarCliente form = new FormCadastrarCliente();
            form.ShowDialog();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            FormAtualizarCliente form = new FormAtualizarCliente();
            form.ShowDialog();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            FormConsultarCliente form = new FormConsultarCliente();
            form.ShowDialog();
        }

        private void btExluir_Click(object sender, EventArgs e)
        {
            FormExcluirCliente form = new FormExcluirCliente();
            form.ShowDialog();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            FormListarCliente form = new FormListarCliente();
            form.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
