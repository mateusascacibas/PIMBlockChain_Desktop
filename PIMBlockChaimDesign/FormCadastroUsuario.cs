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
    public partial class FormCadastroUsuario : Form
    {

        String Nome, CPF, Endereco, Telefone, Cargo, Sexo, Login, Senha, Email, Estado;
        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        private void LinkLblLogon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormMenuDoADM menu = new FormMenuDoADM();
            this.Close();
        }

        private void comboStateCad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioOutroCad_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOutroCad.Checked)
            {
                txtOutroCad.Visible = true;
                lblQualCad.Visible = true;
            }
            else
            {
                txtOutroCad.Visible = false;
                lblQualCad.Visible = false;
            }
        }

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
           
        }

        private void radioFemaleCad_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOutroCad.Checked)
            {
                txtOutroCad.Visible = true;
                lblQualCad.Visible = true;
            }
            else
            {
                txtOutroCad.Visible = false;
                lblQualCad.Visible = false;
            }
        }

        private void radioMaleCad_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOutroCad.Checked)
            {
                txtOutroCad.Visible = true;
                lblQualCad.Visible = true;
            }
            else
            {
                txtOutroCad.Visible = false;
                lblQualCad.Visible = false;
            }
        }

        private void radioNãoDizerCad_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOutroCad.Checked)
            {
                txtOutroCad.Visible = true;
                lblQualCad.Visible = true;
            }
            else
            {
                txtOutroCad.Visible = false;
                lblQualCad.Visible = false;
            }
        }

        private void comboCargoCad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if (radioMaleCad.Checked)
            {
                Sexo = "Masculino";
            }
            else if (radioFemaleCad.Checked)
            {
                Sexo = "Feminino";
            }
            else if (radioOutroCad.Checked)
            {
                Sexo = txtOutroCad.Text;
            }
            else if (radioNãoDizerCad.Checked) 
            {
                Sexo = "NAN";
            }
            else
            {
                MessageBox.Show("Selecione um sexo.");
            }

            Nome = txtNameCad.Text;
            CPF = txtCPF.Text;
            Endereco = txtboxEndereco.Text;
            Telefone = txtTelefone.Text;
            Cargo = comboCargoCad.Text;
            Login = txtLogonCad.Text;
            Senha = txtCPF.Text;
            Email = txtEmailCad.Text;
            Estado = txtUF.Text;
            DateTime thisDay = DateTime.Today;

            string strConexao = "Data Source =LAPTOP-8C3VQ7PF\\SQLEXPRESS; " + "Initial Catalog=PIM_BlockChain;" + "Integrated Security=True;";
            SqlConnection con = new SqlConnection(strConexao);
          
            //string cmdInserir = "INSERT INTO Funcionario values(" + Nome + "," + CPF + "," + Endereco + "," + Telefone + "," + Cargo + ",  Masculino  ," + Login + "," + Senha + "," + Email + "," + Estado + ",  20/12/2001)";
            string cmdInserir = "insert into Funcionario values ('" + Nome + "','"+ CPF + "', '" + Endereco + "', '"+ Telefone + "', '" + Cargo +"','" + Sexo + "', '" + Login + "', '" + Senha + "', '" + Email+ "', '" + Estado + "','" +  thisDay + "');";
            SqlDataAdapter da = new SqlDataAdapter(cmdInserir, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show("Usuario cadastrado com sucesso.");
            txtNameCad.Text = "";
            txtCPF.Text = "";
            txtboxEndereco.Text = "";
            txtTelefone.Text = "";
            comboCargoCad.Text = "";
            txtLogonCad.Text = "";
            txtEmailCad.Text = "";
            txtUF.Text = "";

            txtOutroCad.Text = "";

            

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
