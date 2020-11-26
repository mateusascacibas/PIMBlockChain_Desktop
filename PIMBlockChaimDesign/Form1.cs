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


    

    public partial class Form1 : Form
    {

        public static string nome;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLblCad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogon_Click(object sender, EventArgs e)
        {


            if (txtUser.Text == "" || txtPassword.Text == "") {
                MessageBox.Show("Digite usuario e senha.");
            }
            else { 

            string strConexao =
        "Data Source =LAPTOP-8C3VQ7PF\\SQLEXPRESS; " + "Initial Catalog=PIM_BlockChain;" + "Integrated Security=True;";
            //string cmdConsultar = "Select * from Funcionario WHERE Login = '" + txtUser.Text + "' AND Senha ='" + txtPassword.Text;
            
            SqlConnection con = new SqlConnection(strConexao);
            SqlCommand cmd = new SqlCommand("SELECT Cargo FROM Funcionario WHERE Login ='" + txtUser.Text + "' AND Senha ='" + txtPassword.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
              

              
                SqlCommand cmg = new SqlCommand("SELECT * FROM Funcionario WHERE Login ='" + txtUser.Text + "' AND Senha = '" + txtPassword.Text + "' AND Cargo = 'ADM' " , con);
                SqlDataAdapter di = new SqlDataAdapter(cmg);
                DataTable dd = new DataTable();
                di.Fill(dd);


                nome = txtUser.Text;



                if (dt.Rows.Count > 0)
                {
                    if(dd.Rows.Count > 0)
                    {
                        new FormMenuDoADM().Show();
                    }
                    else
                    {
                      
                        
                        new FormMenuFuncionario().Show();
                    }
                    

                    
                }

                else
                    MessageBox.Show("Erro em usuario ou senha.");

                txtUser.Text = "";
                txtPassword.Text = "";
            }

     

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar o programa?", "Fechar programa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


        }

        private void lblLogon_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
