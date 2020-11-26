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
    public partial class FormConsultarCliente : Form
    {
        public FormConsultarCliente()
        {
            InitializeComponent();
        }

        private void linkMenuCli_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePickerInicioCli_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFiltrosCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFiltrosCli.SelectedIndex == 3)
            {
                
            }
            else
            {
                
            }
        }

        private void radioButtonSimCli_CheckedChanged(object sender, EventArgs e)
        {
            lblPorOrd.Visible = true;
            comboBoxOrdemCli.Visible = true;
            lblFormaOrdCli.Visible = true;
            comboBoxOrdFormaCli.Visible = true;
        }

        private void radioButtonNaoCli_CheckedChanged(object sender, EventArgs e)
        {
                lblPorOrd.Visible = false;
                comboBoxOrdemCli.Visible = false;
                lblFormaOrdCli.Visible = false;
                comboBoxOrdFormaCli.Visible = false;
        }

        private void radioButtonFiltroSim_CheckedChanged(object sender, EventArgs e)
        {
            labelPor.Visible = true;
            comboBoxFiltrosCli.Visible = true;
            labelFiltro.Visible = true;
            textBoxFiltroCli.Visible = true;
        }

        private void radioButtonFiltroNao_CheckedChanged(object sender, EventArgs e)
        {
            labelPor.Visible = false;
            comboBoxFiltrosCli.Visible = false;
            labelFiltro.Visible = false;
            textBoxFiltroCli.Visible = false;
        }

        private void btnAlterarCadCli_Click(object sender, EventArgs e)
        {
            FormAlterarCadastroCliente alterar = new FormAlterarCadastroCliente();
            alterar.Show();
        }

        private void btnPesquisaCli_Click(object sender, EventArgs e)
        {
            string strConexao =
                    "Data Source =LAPTOP-8C3VQ7PF\\SQLEXPRESS; " + "Initial Catalog=PIM_BlockChain;" + "Integrated Security=True;";

            if (radioButtonFiltroSim.Checked && textBoxFiltroCli.Text != "") { 

            int Selecionado = comboBoxFiltrosCli.FindString(comboBoxFiltrosCli.Text);
           
               if (Selecionado == 0)
            {
                string nome = textBoxFiltroCli.Text;
                string cmdConsultar = "Select * from Cliente where Nome = '" + nome + "'";
                SqlConnection con = new SqlConnection(strConexao);
                SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewClienteConsulta.DataSource = dt;
            }
            else if(Selecionado == 1)
            {
                string CPF = textBoxFiltroCli.Text;
                string cmdConsultar = "Select * from Cliente where CPF = '" + CPF + "'";
                SqlConnection con = new SqlConnection(strConexao);
                SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewClienteConsulta.DataSource = dt;
            }
            else if(Selecionado == 2)
            {
                string Sexo = textBoxFiltroCli.Text;
                string cmdConsultar = "Select * from Cliente where Sexo = '" + Sexo + "'";
                SqlConnection con = new SqlConnection(strConexao);
                SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewClienteConsulta.DataSource = dt;
            }
            else
            {
                    MessageBox.Show("Selecione um item para filtro");
            }
            }

            else if(radioButtonFiltroNao.Checked)
            {
                string cmdConsultar = "Select * from Cliente";
                SqlConnection con = new SqlConnection(strConexao);
                SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewClienteConsulta.DataSource = dt;
            }

            else
            {
                MessageBox.Show("Digite algo para filtrar.");
            }

            if (radioButtonSimCli.Checked)
            {
                int SelecionadoOrder = comboBoxOrdemCli.FindString(comboBoxOrdemCli.Text);

                if (radioButtonSimCli.Checked)
                {
                    int SelecionadoForma = comboBoxOrdFormaCli.FindString(comboBoxOrdFormaCli.Text);
                    
                    if (SelecionadoOrder == 0)
                    {
                        if (SelecionadoForma == 0)
                        {
                            string cmdConsultar = "Select * from Cliente ORDER BY Nome ASC";
                            SqlConnection con = new SqlConnection(strConexao);
                            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewClienteConsulta.DataSource = dt;
                        }
                        else if (SelecionadoForma == 1)
                        {
                            string cmdConsultar = "Select * from Cliente ORDER BY Nome DESC";
                            SqlConnection con = new SqlConnection(strConexao);
                            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewClienteConsulta.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Selecione um método de ordenação");
                        }
                    }
                    else if (SelecionadoOrder == 1)
                    {
                        if (SelecionadoForma == 0)
                        {
                            string cmdConsultar = "Select * from Cliente ORDER BY Login ASC";
                            SqlConnection con = new SqlConnection(strConexao);
                            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewClienteConsulta.DataSource = dt;
                        }
                        else if (SelecionadoForma == 1)
                        {
                            string cmdConsultar = "Select * from Cliente ORDER BY Login DESC";
                            SqlConnection con = new SqlConnection(strConexao);
                            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewClienteConsulta.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Selecione um método de ordenação");
                        }
                    }
                    else if (SelecionadoOrder == 2)
                    {
                        if (SelecionadoForma == 0)
                        {
                            string cmdConsultar = "Select * from Cliente ORDER BY Sexo ASC";
                            SqlConnection con = new SqlConnection(strConexao);
                            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewClienteConsulta.DataSource = dt;
                        }
                        else if (SelecionadoForma == 1)
                        {
                            string cmdConsultar = "Select * from Cliente ORDER BY Sexo DESC";
                            SqlConnection con = new SqlConnection(strConexao);
                            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewClienteConsulta.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Selecione um método de ordenação");
                        }
                    }

                    else if (SelecionadoOrder == 3)
                    {
                        if (SelecionadoForma == 0)
                        {
                            string cmdConsultar = "Select * from Cliente ORDER BY Data_Cadastro ASC";
                            SqlConnection con = new SqlConnection(strConexao);
                            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewClienteConsulta.DataSource = dt;
                        }
                        else if (SelecionadoForma == 1)
                        {
                            string cmdConsultar = "Select * from Cliente ORDER BY Data_Cadastro DESC";
                            SqlConnection con = new SqlConnection(strConexao);
                            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewClienteConsulta.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Selecione um método de ordenação");
                        }
                    }

                    else if (SelecionadoOrder == 4)
                    {
                        if (SelecionadoForma == 0)
                        {
                            string cmdConsultar = "Select * from Cliente ORDER BY Status ASC";
                            SqlConnection con = new SqlConnection(strConexao);
                            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewClienteConsulta.DataSource = dt;
                        }
                        else if (SelecionadoForma == 1)
                        {
                            string cmdConsultar = "Select * from Cliente ORDER BY Status DESC";
                            SqlConnection con = new SqlConnection(strConexao);
                            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewClienteConsulta.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Selecione um método de ordenação");
                        }
                    }

                }
                
               



            }



        }

        private void btnExcluirCadCli_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaAtual = dataGridViewClienteConsulta.CurrentRow;
            // vamos exibir o índice da linha atual
            string indice = linhaAtual.Cells[0].Value.ToString();
            string strConexao =
                    "Data Source =LAPTOP-8C3VQ7PF\\SQLEXPRESS; " + "Initial Catalog=PIM_BlockChain;" + "Integrated Security=True;";
            SqlConnection con = new SqlConnection(strConexao);
            string cmdConsultar = "DELETE from Cliente where IDCliente = " + indice;
            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show("Usuario deletado com sucesso.");
        }
    }
}
