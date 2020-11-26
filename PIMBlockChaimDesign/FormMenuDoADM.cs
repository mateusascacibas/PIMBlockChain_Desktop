using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMBlockChaimDesign
{
    public partial class FormMenuDoADM : Form
    {
        public FormMenuDoADM()
        {
            InitializeComponent();
            label2.Text = Form1.nome;
        }

        private void btnUserCad_Click(object sender, EventArgs e)
        {
            FormCadastroUsuario cadastro = new FormCadastroUsuario();
            cadastro.Show();
        }

        private void btnFINSessao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            FormConsultarUsuario consulta = new FormConsultarUsuario();
            consulta.Show();
        }

        private void cadastrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroUsuario cadastro = new FormCadastroUsuario();
            cadastro.Show();
        }

        private void consultarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarUsuario ConsultaUser= new FormConsultarUsuario();
            ConsultaUser.Show();
        }

        private void btnConsultaFinancas_Click(object sender, EventArgs e)
        {
            FormConsultaFinancas ConsultaFinanca = new FormConsultaFinancas();
            ConsultaFinanca.Show();
        }

        private void groupBoxMenu_Enter(object sender, EventArgs e)
        {

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            FormCadastroCliente cadCli = new FormCadastroCliente();
            cadCli.Show();
        }

        private void btnConsultaCliente_Click(object sender, EventArgs e)
        {
            FormConsultarCliente conCli = new FormConsultarCliente();
            conCli.Show();
        }

        private void FormMenuDoADM_Load(object sender, EventArgs e)
        {

        }

        private void caToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroUsuario cadastro = new FormCadastroUsuario();
            cadastro.Show();

        }

        private void consultarUsuarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormConsultarUsuario consulta = new FormConsultarUsuario();
            consulta.Show();
        }

        private void consultarFinançasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaFinancas ConsultaFinanca = new FormConsultaFinancas();
            ConsultaFinanca.Show();
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroCliente cadCli = new FormCadastroCliente();
            cadCli.Show();
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarCliente conCli = new FormConsultarCliente();
            conCli.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

                if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                new Form1().Show();
                }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new Form1().Show();
            }
        }
    }
}
