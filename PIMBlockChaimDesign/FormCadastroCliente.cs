using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PIMBlockChaimDesign
{
    public partial class FormCadastroCliente : Form
    {



        String Nome, CPF, Endereco, Telefone, Sexo, Login, Senha, Email, Estado;

        public FormCadastroCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxCad_Enter(object sender, EventArgs e)
        {

        }

        private void LinkLblLogonCli_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {

            if (radioMaleCadCli.Checked)
            {
                Sexo = "Masculino";
            }
            else if (radioFemaleCadCli.Checked)
            {
                Sexo = "Feminino";
            }
            else if (radioOutroCadCli.Checked)
            {
                Sexo = txtOutroCadCli.Text;
            }
            else if (radioNãoDizerCadCli.Checked)
            {
                Sexo = "NAN";
            }
            else
            {
                MessageBox.Show("Selecione um sexo.");
            }

            Nome = txtNameCadCli.Text;
            CPF = txtCPF.Text;
            Endereco = txtboxEndereco.Text;
            Telefone = txtTelefone.Text;
            //sexo
            Login = txtLogonCadCli.Text;
            Senha = txtCPF.Text;
            Email = txtEmailCadCli.Text;
            Estado = txtUF.Text;
            DateTime thisDay = DateTime.Today;

            string strConexao =
                "Data Source =LAPTOP-8C3VQ7PF\\SQLEXPRESS; " + "Initial Catalog=PIM_BlockChain;" + "Integrated Security=True;";
            SqlConnection con = new SqlConnection(strConexao);
            
            //string cmdInserir = "INSERT INTO Funcionario values(" + Nome + "," + CPF + "," + Endereco + "," + Telefone + "," + Cargo + ",  Masculino  ," + Login + "," + Senha + "," + Email + "," + Estado + ",  20/12/2001)";
            string cmdInserir = "insert into Cliente values ('" + Nome + "','" + CPF + "', '" + Endereco + "', '" + Telefone + "','"  + Sexo + "', '" + Login + "', '" + Senha + "', '" + Email + "', '" + Estado + "','" + thisDay + "',  'Ativo')";
            SqlDataAdapter da = new SqlDataAdapter(cmdInserir, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show("Usuario cadastrado com sucesso.");
            txtNameCadCli.Text = "";
            txtCPF.Text = "";
            txtboxEndereco.Text = "";
            txtTelefone.Text = "";
            txtLogonCadCli.Text = "";
            txtEmailCadCli.Text = "";
            txtUF.Text = "";
            txtOutroCadCli.Text = "";
        }

        private void radioOutroCadCli_CheckedChanged(object sender, EventArgs e)
        {
            txtOutroCadCli.Visible = true;
            lblQualCad.Visible = true;
        }

        private void radioMaleCadCli_CheckedChanged(object sender, EventArgs e)
        {
            txtOutroCadCli.Visible = false;
            lblQualCad.Visible = false;
        }

        private void radioFemaleCadCli_CheckedChanged(object sender, EventArgs e)
        {
            txtOutroCadCli.Visible = false;
            lblQualCad.Visible = false;
        }

        private void radioNãoDizerCadCli_CheckedChanged(object sender, EventArgs e)
        {
            txtOutroCadCli.Visible = false;
            lblQualCad.Visible = false;
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
