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
    public partial class FormAlterarCadastroCliente : Form
    {
        string Telefone, Nome, Logon, Email, Endereco, UF, Status;
        public FormAlterarCadastroCliente()
        {
            InitializeComponent();
        }

        private void LinkLblLogonCli_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btn_Verificador_Click(object sender, EventArgs e)
        {
           
          
        }

        private void checkStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (checkStatus.Checked)
            {
                comboStatus.Enabled = true;
            }
            else
            {
                comboStatus.Enabled = false;
            }
        }

        private void checkNome_CheckedChanged(object sender, EventArgs e)
        {
            if(checkNome.Enabled == true) { 
                txtNameCadCli.Enabled = true;
            }
            else
            {
                txtNameCadCli.Enabled = false;
            }


        }

        private void checkLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLogin.Enabled == true)
            {
                txtLogonCadCli.Enabled = true;
            }
            else
            {
                txtLogonCadCli.Enabled = false;
            }
        }

        private void txtEmailCadCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkEmail_CheckedChanged(object sender, EventArgs e)
        {
            if(checkEmail.Enabled == true) { 
                txtEmailCadCli.Enabled = true;
            }
            else
            {
                txtEmailCadCli.Enabled = false;
            }
        }

        private void checkTelefone_CheckedChanged(object sender, EventArgs e)
        {
            if(checkEmail.Enabled == true)
            {
                txtTelefone.Enabled = true;
            }
            else
            {
                txtTelefone.Enabled = false;
            }
            
        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {

            string strConexao =
                    "Data Source =LAPTOP-8C3VQ7PF\\SQLEXPRESS; " + "Initial Catalog=PIM_BlockChain;" + "Integrated Security=True;";

          
            Telefone = txtTelefone.Text;
            Email = txtEmailCadCli.Text;
            Logon = txtLogonCadCli.Text;
            Nome = txtNameCadCli.Text;
            Endereco = txtEndereco.Text;
            UF = comboUF.Text;
            Status = comboStatus.Text;

            if (checkEmail.Checked == true)
            {
                string cmdAtualizar = "UPDATE Cliente SET Email = '" + Email + "' WHERE IDCliente = '" + txtID.Text + "'";
                SqlConnection con = new SqlConnection(strConexao);
                SqlDataAdapter da = new SqlDataAdapter(cmdAtualizar, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }

            if (checkLogin.Checked == true)
            {
                string cmdAtualizar = "UPDATE Cliente SET Login = '" + Logon + "' WHERE IDCliente = '" + txtID.Text + "'";
                SqlConnection con = new SqlConnection(strConexao);
                SqlDataAdapter da = new SqlDataAdapter(cmdAtualizar, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }

            if (checkNome.Checked == true)
            {
                string cmdAtualizar = "UPDATE Cliente SET Nome = '" + Nome + "' WHERE IDCliente = '" + txtID.Text + "'";
                SqlConnection con = new SqlConnection(strConexao);
                SqlDataAdapter da = new SqlDataAdapter(cmdAtualizar, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }

            if (checkTelefone.Checked == true)
            {
                string cmdAtualizar = "UPDATE Cliente SET Telefone = '" + Telefone + "' WHERE IDCliente = '" + txtID.Text + "'";
                SqlConnection con = new SqlConnection(strConexao);
                SqlDataAdapter da = new SqlDataAdapter(cmdAtualizar, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }

            if (checkEndereco.Checked == true)
            {
                string cmdAtualizar = "UPDATE Cliente SET Endereco = '" + Endereco + "' WHERE IDCliente = '" + txtID.Text + "'";
                SqlConnection con = new SqlConnection(strConexao);
                SqlDataAdapter da = new SqlDataAdapter(cmdAtualizar, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }

            if (checkUF.Checked == true)
            {
                string cmdAtualizar = "UPDATE Cliente SET Estado = '" + UF + "' WHERE IDCliente = '" + txtID.Text + "'";
                SqlConnection con = new SqlConnection(strConexao);
                SqlDataAdapter da = new SqlDataAdapter(cmdAtualizar, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }

            if (checkStatus.Checked == true)
            {
                string cmdAtualizar = "UPDATE Cliente SET Status = '" + Status + "' WHERE IDCliente = '" + txtID.Text + "'";
                SqlConnection con = new SqlConnection(strConexao);
                SqlDataAdapter da = new SqlDataAdapter(cmdAtualizar, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }

            MessageBox.Show("Cadastro alterado com sucesso.");
            txtEmailCadCli.Clear();
            txtID.Clear();
            txtLogonCadCli.Clear();
            txtNameCadCli.Clear();
            txtTelefone.Clear();
            txtEndereco.Clear();
            comboUF.Items.Clear();
            comboStatus.Items.Clear();
        }
    }
}
