using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroEventoProway
{
    public partial class Form1 : Form
    {

        List<Cadastro> cadastro = new List<Cadastro>();

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            tbCadastro.SelectedIndex = 1;
        }

        private void btnCafe_Click(object sender, EventArgs e)
        {
            tbCadastro.SelectedIndex = 2;
        }

        private void btnSala_Click(object sender, EventArgs e)
        {
            tbCadastro.SelectedIndex = 3;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Informe seu nome completo!!");
                return;
            }

            Cadastro cadastro = new Cadastro();
            cadastro.Nome = txtNome.Text;
            cadastro.Nascimento = mtbNascimento.Text;
            cadastro.Sala = Convert.ToInt32(nudSala.Text);
            dgvLista.Rows.Add(new Object[] { cadastro.Nome,cadastro.Nascimento, cadastro.Sala });
            LimparCampos();

            tbCadastro.SelectedIndex = 0;
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            mtbNascimento.Text = "";
        }
    }
}
