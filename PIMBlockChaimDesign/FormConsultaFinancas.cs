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
    public partial class FormConsultaFinancas : Form
    {
        public FormConsultaFinancas()
        {
            InitializeComponent();
        }

        private void linkLabelMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void comboBoxFiltrosCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePickerFimCli_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonSimCli_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }

        private void radioButtonNaoCli_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }

        private void radioButtonFiltroSim_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButtonFiltroNao_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_Verificador_Click(object sender, EventArgs e)
        {
           
            
        }

        private void FormConsultaFinancas_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultaFinanca_Click(object sender, EventArgs e)
        {
            
            string strConexao =
                    "Data Source =LAPTOP-8C3VQ7PF\\SQLEXPRESS; " + "Initial Catalog=PIM_BlockChain;" + "Integrated Security=True;";
            SqlConnection con = new SqlConnection(strConexao);
            string cmdConsultar = "SELECT Cliente.Nome, Transacao.tipo_criptoativo, Transacao.qtd_criptoativos, Transacao.cotacao_compra from Transacao INNER JOIN Cliente on Cliente.IDCliente = " + txtNomeConsultaFin.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewClienteConsulta.DataSource = dt;
        }

        private void dataGridViewClienteConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
