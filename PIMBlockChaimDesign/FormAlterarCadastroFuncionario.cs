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
    
    public partial class FormAlterarCadastroFuncionario : Form
    {
        string cargo, Telefone, Nome, Logon, Email, Endereco, UF;
        public FormAlterarCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void LinkLblLogon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void checkNome_CheckedChanged(object sender, EventArgs e)
        {
            if(checkNome.Checked == true) { 
                txtNameCad.Enabled = true;
               

            }
            else
            {
                txtNameCad.Enabled = false;
            }
        }

        private void checkLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLogin.Checked) { 
                txtLogonCad.Enabled = true;
               
            }
            else{
                txtLogonCad.Enabled = false;
            }
        }

        private void groupBoxCad_Enter(object sender, EventArgs e)
        {

        }

        private void checkEndereco_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEndereco.Checked)
            {
                txtEndereco.Enabled = true;

            }
            else
            {
                txtEndereco.Enabled = false;
            }
        }

        private void FormAlterarCadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void txtLogonCad_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkUF_CheckedChanged(object sender, EventArgs e)
        {
            if (checkUF.Checked)
            {
                comboUF.Enabled = true;

            }
            else
            {
                comboUF.Enabled = false;
            }
        }

        private void checkEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEmail.Checked) { 
                txtEmailCad.Enabled = true;
                
            }
            else
            {
                txtEmailCad.Enabled = false;
            }
        }

        private void checkTelefone_CheckedChanged(object sender, EventArgs e)
        {
            if(checkTelefone.Checked == true) { 
                txtTelefone.Enabled = true;
                
            }
            else
            {
                txtTelefone.Enabled = false;
            }
        }

        private void checkCPF_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkCargo_CheckedChanged(object sender, EventArgs e)
        {
            if(checkCargo.Checked == true) { 
                comboCargoCad.Enabled = true;
               
            }
            else
            {
                comboCargoCad.Enabled = false;
            }
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            string strConexao =
                    "Data Source =LAPTOP-8C3VQ7PF\\SQLEXPRESS; " + "Initial Catalog=PIM_BlockChain;" + "Integrated Security=True;";
           
            cargo = comboCargoCad.Text;
            Telefone = txtTelefone.Text;
            Email = txtEmailCad.Text;
            Logon = txtLogonCad.Text;
            Nome = txtNameCad.Text;
            Endereco = txtEndereco.Text;
            UF = comboUF.Text; 





            if (checkCargo.Checked == true)
            {   
                string cmdAtualizar = "UPDATE Funcionario SET Cargo = '" + cargo + "' WHERE ID_Func = '" + txtID.Text + "'";
                SqlConnection con = new SqlConnection(strConexao);
                SqlDataAdapter da = new SqlDataAdapter(cmdAtualizar, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }

        

            if(checkEmail.Checked == true)
            {
                string cmdAtualizar = "UPDATE Funcionario SET Email = '" + Email + "' WHERE ID_Func = '" + txtID.Text + "'";
                SqlConnection con = new SqlConnection(strConexao);
                SqlDataAdapter da = new SqlDataAdapter(cmdAtualizar, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }

            if(checkLogin.Checked == true)
            {
                string cmdAtualizar = "UPDATE Funcionario SET Login = '" + Logon + "' WHERE ID_Func = '" + txtID.Text + "'";
                SqlConnection con = new SqlConnection(strConexao);
                SqlDataAdapter da = new SqlDataAdapter(cmdAtualizar, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }

            if(checkNome.Checked == true)
            {
                string cmdAtualizar = "UPDATE Funcionario SET Nome = '" + Nome + "' WHERE ID_Func = '" + txtID.Text + "'";
                SqlConnection con = new SqlConnection(strConexao);
                SqlDataAdapter da = new SqlDataAdapter(cmdAtualizar, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }

            if(checkTelefone.Checked == true)
            {
                string cmdAtualizar = "UPDATE Funcionario SET Telefone = '" + Telefone + "' WHERE ID_Func = '" + txtID.Text + "'";
                SqlConnection con = new SqlConnection(strConexao);
                SqlDataAdapter da = new SqlDataAdapter(cmdAtualizar, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }

            if (checkEndereco.Checked == true)
            {
                string cmdAtualizar = "UPDATE Funcionario SET Endereco = '" + Endereco + "' WHERE ID_Func = '" + txtID.Text + "'";
                SqlConnection con = new SqlConnection(strConexao);
                SqlDataAdapter da = new SqlDataAdapter(cmdAtualizar, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }

            if (checkUF.Checked == true)
            {
                string cmdAtualizar = "UPDATE Funcionario SET Estado = '" + UF + "' WHERE ID_Func = '" + txtID.Text + "'";
                SqlConnection con = new SqlConnection(strConexao);
                SqlDataAdapter da = new SqlDataAdapter(cmdAtualizar, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }


            MessageBox.Show("Cadastro alterado com sucesso.");
           
            txtEmailCad.Clear();
            txtID.Clear();
            txtLogonCad.Clear();
            txtNameCad.Clear();
            txtTelefone.Clear();
            comboCargoCad.Items.Clear();
            txtEndereco.Clear();
            comboUF.Items.Clear();
        }
    }
}
