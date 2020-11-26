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
    public partial class FormConsultarUsuario : Form
    {
        public FormConsultarUsuario()
        {
            InitializeComponent();
        }

        private void radioButtonFiltroSim_CheckedChanged(object sender, EventArgs e)
        {
            labelPor.Visible = true;
            labelFiltro.Visible = true;
            comboBoxFiltros.Visible = true;
            textBoxFiltro.Visible = true;
        }

        private void radioButtonFiltroNao_CheckedChanged(object sender, EventArgs e)
        {
            labelPor.Visible = false;
            labelFiltro.Visible = false;
            comboBoxFiltros.Visible = false;
            textBoxFiltro.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblPorOrd.Visible = true;
            comboBoxOrdem.Visible = true;
            lblFormaOrd.Visible = true;
            comboBoxFormaOrd.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblPorOrd.Visible = false;
            comboBoxOrdem.Visible = false;
            lblFormaOrd.Visible = false;
            comboBoxFormaOrd.Visible = false;
        }

        private void groupBoxProp_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxOrdem_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void dateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (comboBoxFiltros.SelectedIndex == 3)
            {
                
            }
            else
            {
           
            }
        }

        private void btnAlterarCad_Click(object sender, EventArgs e)
        {
            FormAlterarCadastroFuncionario alterar = new FormAlterarCadastroFuncionario();
            alterar.Show();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string strConexao =
                  "Data Source =LAPTOP-8C3VQ7PF\\SQLEXPRESS; " + "Initial Catalog=PIM_BlockChain;" + "Integrated Security=True;";


            if (radioButtonFiltroSim.Checked && textBoxFiltro.Text != "")
            {

                int Selecionado = comboBoxFiltros.FindString(comboBoxFiltros.Text);

                if (Selecionado == 0)
                {
                    string nome = textBoxFiltro.Text;
                    string cmdConsultar = "Select * from Funcionario where Nome = '" + nome + "'";
                    SqlConnection con = new SqlConnection(strConexao);
                    SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewUsuarioConsulta.DataSource = dt;
                }
                else if (Selecionado == 1)
                {
                    string CPF = textBoxFiltro.Text;
                    string cmdConsultar = "Select * from Funcionario where Cargo = '" + CPF + "'";
                    SqlConnection con = new SqlConnection(strConexao);
                    SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewUsuarioConsulta.DataSource = dt;
                }
                else if (Selecionado == 2)
                {
                    string Sexo = textBoxFiltro.Text;
                    string cmdConsultar = "Select * from Funcionario where Sexo = '" + Sexo + "'";
                    SqlConnection con = new SqlConnection(strConexao);
                    SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewUsuarioConsulta.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Selecione um item para filtro");
                }
            }

            else if (radioButtonFiltroNao.Checked)
            {
                string cmdConsultar = "Select * from Funcionario";
                SqlConnection con = new SqlConnection(strConexao);
                SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewUsuarioConsulta.DataSource = dt;
            }

            else
            {
                MessageBox.Show("Digite algo para filtrar.");
            }

            if (radioButtonSim.Checked)
            {
                int SelecionadoOrder = comboBoxOrdem.FindString(comboBoxOrdem.Text);

                if (radioButtonSim.Checked)
                {
                    int SelecionadoForma = comboBoxFormaOrd.FindString(comboBoxFormaOrd.Text);

                    if (SelecionadoOrder == 0)
                    {
                        if (SelecionadoForma == 0)
                        {
                            string cmdConsultar = "Select * from Funcionario ORDER BY Nome ASC";
                            SqlConnection con = new SqlConnection(strConexao);
                            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewUsuarioConsulta.DataSource = dt;
                        }
                        else if (SelecionadoForma == 1)
                        {
                            string cmdConsultar = "Select * from Funcionario ORDER BY Nome DESC";
                            SqlConnection con = new SqlConnection(strConexao);
                            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewUsuarioConsulta.DataSource = dt;
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
                            string cmdConsultar = "Select * from Funcionario ORDER BY Login ASC";
                            SqlConnection con = new SqlConnection(strConexao);
                            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewUsuarioConsulta.DataSource = dt;
                        }
                        else if (SelecionadoForma == 1)
                        {
                            string cmdConsultar = "Select * from Funcionario ORDER BY Login DESC";
                            SqlConnection con = new SqlConnection(strConexao);
                            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewUsuarioConsulta.DataSource = dt;
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
                            string cmdConsultar = "Select * from Funcionario ORDER BY Sexo ASC";
                            SqlConnection con = new SqlConnection(strConexao);
                            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewUsuarioConsulta.DataSource = dt;
                        }
                        else if (SelecionadoForma == 1)
                        {
                            string cmdConsultar = "Select * from Funcionario ORDER BY Sexo DESC";
                            SqlConnection con = new SqlConnection(strConexao);
                            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewUsuarioConsulta.DataSource = dt;
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
                            string cmdConsultar = "Select * from Funcionario ORDER BY Data_Cadastro ASC";
                            SqlConnection con = new SqlConnection(strConexao);
                            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewUsuarioConsulta.DataSource = dt;
                        }
                        else if (SelecionadoForma == 1)
                        {
                            string cmdConsultar = "Select * from Funcionario ORDER BY Data_Cadastro DESC";
                            SqlConnection con = new SqlConnection(strConexao);
                            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewUsuarioConsulta.DataSource = dt;
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
                            string cmdConsultar = "Select * from Funcionario ORDER BY Cargo ASC";
                            SqlConnection con = new SqlConnection(strConexao);
                            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewUsuarioConsulta.DataSource = dt;
                        }
                        else if (SelecionadoForma == 1)
                        {
                            string cmdConsultar = "Select * from Funcionario ORDER BY Cargo DESC";
                            SqlConnection con = new SqlConnection(strConexao);
                            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewUsuarioConsulta.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Selecione um método de ordenação");
                        }
                    }

                }
            }


        }

        private void btnExcluirCad_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaAtual = dataGridViewUsuarioConsulta.CurrentRow; 
            // vamos exibir o índice da linha atual
            string indice = linhaAtual.Cells[0].Value.ToString();
            string strConexao =
                    "Data Source =LAPTOP-8C3VQ7PF\\SQLEXPRESS; " + "Initial Catalog=PIM_BlockChain;" + "Integrated Security=True;";
            SqlConnection con = new SqlConnection(strConexao);
            string cmdConsultar = "DELETE from Funcionario where ID_Func = " + indice;
            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show("Usuario deletado com sucesso.");
        }
            

        }
    }

