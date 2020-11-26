namespace PIMBlockChaimDesign
{
    partial class FormConsultarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultarCliente));
            this.linkMenuCli = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewClienteConsulta = new System.Windows.Forms.DataGridView();
            this.btnExcluirCadCli = new System.Windows.Forms.Button();
            this.btnAlterarCadCli = new System.Windows.Forms.Button();
            this.groupBoxPropCli = new System.Windows.Forms.GroupBox();
            this.btnPesquisaCli = new System.Windows.Forms.Button();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.labelPor = new System.Windows.Forms.Label();
            this.radioButtonFiltroNao = new System.Windows.Forms.RadioButton();
            this.comboBoxFiltrosCli = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFiltroCli = new System.Windows.Forms.TextBox();
            this.radioButtonFiltroSim = new System.Windows.Forms.RadioButton();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFormaOrdCli = new System.Windows.Forms.Label();
            this.comboBoxOrdFormaCli = new System.Windows.Forms.ComboBox();
            this.lblOrdem = new System.Windows.Forms.Label();
            this.radioButtonNaoCli = new System.Windows.Forms.RadioButton();
            this.lblPorOrd = new System.Windows.Forms.Label();
            this.comboBoxOrdemCli = new System.Windows.Forms.ComboBox();
            this.radioButtonSimCli = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienteConsulta)).BeginInit();
            this.groupBoxPropCli.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkMenuCli
            // 
            this.linkMenuCli.AutoSize = true;
            this.linkMenuCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkMenuCli.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkMenuCli.Location = new System.Drawing.Point(6, 242);
            this.linkMenuCli.Name = "linkMenuCli";
            this.linkMenuCli.Size = new System.Drawing.Size(117, 20);
            this.linkMenuCli.TabIndex = 20;
            this.linkMenuCli.TabStop = true;
            this.linkMenuCli.Text = "Voltar ao Menu";
            this.linkMenuCli.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMenuCli_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkMenuCli);
            this.groupBox2.Controls.Add(this.dataGridViewClienteConsulta);
            this.groupBox2.Controls.Add(this.btnExcluirCadCli);
            this.groupBox2.Controls.Add(this.btnAlterarCadCli);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(287, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 269);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grade de pesquisa";
            // 
            // dataGridViewClienteConsulta
            // 
            this.dataGridViewClienteConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClienteConsulta.Location = new System.Drawing.Point(119, 19);
            this.dataGridViewClienteConsulta.Name = "dataGridViewClienteConsulta";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewClienteConsulta.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewClienteConsulta.Size = new System.Drawing.Size(547, 150);
            this.dataGridViewClienteConsulta.TabIndex = 1;
            // 
            // btnExcluirCadCli
            // 
            this.btnExcluirCadCli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluirCadCli.BackgroundImage")));
            this.btnExcluirCadCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluirCadCli.FlatAppearance.BorderSize = 0;
            this.btnExcluirCadCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCadCli.ForeColor = System.Drawing.Color.Black;
            this.btnExcluirCadCli.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExcluirCadCli.Location = new System.Drawing.Point(407, 175);
            this.btnExcluirCadCli.Name = "btnExcluirCadCli";
            this.btnExcluirCadCli.Size = new System.Drawing.Size(179, 88);
            this.btnExcluirCadCli.TabIndex = 13;
            this.btnExcluirCadCli.UseVisualStyleBackColor = true;
            this.btnExcluirCadCli.Click += new System.EventHandler(this.btnExcluirCadCli_Click);
            // 
            // btnAlterarCadCli
            // 
            this.btnAlterarCadCli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterarCadCli.BackgroundImage")));
            this.btnAlterarCadCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlterarCadCli.FlatAppearance.BorderSize = 0;
            this.btnAlterarCadCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarCadCli.ForeColor = System.Drawing.Color.Black;
            this.btnAlterarCadCli.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAlterarCadCli.Location = new System.Drawing.Point(188, 174);
            this.btnAlterarCadCli.Name = "btnAlterarCadCli";
            this.btnAlterarCadCli.Size = new System.Drawing.Size(185, 88);
            this.btnAlterarCadCli.TabIndex = 12;
            this.btnAlterarCadCli.UseVisualStyleBackColor = true;
            this.btnAlterarCadCli.Click += new System.EventHandler(this.btnAlterarCadCli_Click);
            // 
            // groupBoxPropCli
            // 
            this.groupBoxPropCli.Controls.Add(this.btnPesquisaCli);
            this.groupBoxPropCli.Controls.Add(this.groupBoxFilter);
            this.groupBoxPropCli.Controls.Add(this.groupBox1);
            this.groupBoxPropCli.ForeColor = System.Drawing.Color.White;
            this.groupBoxPropCli.Location = new System.Drawing.Point(287, 189);
            this.groupBoxPropCli.Name = "groupBoxPropCli";
            this.groupBoxPropCli.Size = new System.Drawing.Size(776, 190);
            this.groupBoxPropCli.TabIndex = 17;
            this.groupBoxPropCli.TabStop = false;
            this.groupBoxPropCli.Text = "Propriedades";
            // 
            // btnPesquisaCli
            // 
            this.btnPesquisaCli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisaCli.BackgroundImage")));
            this.btnPesquisaCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisaCli.FlatAppearance.BorderSize = 0;
            this.btnPesquisaCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisaCli.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisaCli.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPesquisaCli.Location = new System.Drawing.Point(498, 127);
            this.btnPesquisaCli.Name = "btnPesquisaCli";
            this.btnPesquisaCli.Size = new System.Drawing.Size(192, 57);
            this.btnPesquisaCli.TabIndex = 15;
            this.btnPesquisaCli.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisaCli.UseVisualStyleBackColor = true;
            this.btnPesquisaCli.Click += new System.EventHandler(this.btnPesquisaCli_Click);
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.labelPor);
            this.groupBoxFilter.Controls.Add(this.radioButtonFiltroNao);
            this.groupBoxFilter.Controls.Add(this.comboBoxFiltrosCli);
            this.groupBoxFilter.Controls.Add(this.label1);
            this.groupBoxFilter.Controls.Add(this.textBoxFiltroCli);
            this.groupBoxFilter.Controls.Add(this.radioButtonFiltroSim);
            this.groupBoxFilter.Controls.Add(this.labelFiltro);
            this.groupBoxFilter.Location = new System.Drawing.Point(20, 19);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(453, 117);
            this.groupBoxFilter.TabIndex = 14;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filtro";
            // 
            // labelPor
            // 
            this.labelPor.AutoSize = true;
            this.labelPor.Location = new System.Drawing.Point(15, 46);
            this.labelPor.Name = "labelPor";
            this.labelPor.Size = new System.Drawing.Size(23, 13);
            this.labelPor.TabIndex = 8;
            this.labelPor.Text = "Por";
            this.labelPor.Visible = false;
            // 
            // radioButtonFiltroNao
            // 
            this.radioButtonFiltroNao.AutoSize = true;
            this.radioButtonFiltroNao.Checked = true;
            this.radioButtonFiltroNao.Location = new System.Drawing.Point(98, 19);
            this.radioButtonFiltroNao.Name = "radioButtonFiltroNao";
            this.radioButtonFiltroNao.Size = new System.Drawing.Size(45, 17);
            this.radioButtonFiltroNao.TabIndex = 7;
            this.radioButtonFiltroNao.TabStop = true;
            this.radioButtonFiltroNao.Text = "Não";
            this.radioButtonFiltroNao.UseVisualStyleBackColor = true;
            this.radioButtonFiltroNao.CheckedChanged += new System.EventHandler(this.radioButtonFiltroNao_CheckedChanged);
            // 
            // comboBoxFiltrosCli
            // 
            this.comboBoxFiltrosCli.FormattingEnabled = true;
            this.comboBoxFiltrosCli.Items.AddRange(new object[] {
            "Nome",
            "CPF",
            "Sexo",
            "Intervalo de datas"});
            this.comboBoxFiltrosCli.Location = new System.Drawing.Point(50, 40);
            this.comboBoxFiltrosCli.Name = "comboBoxFiltrosCli";
            this.comboBoxFiltrosCli.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltrosCli.TabIndex = 0;
            this.comboBoxFiltrosCli.Visible = false;
            this.comboBoxFiltrosCli.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltrosCli_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar";
            // 
            // textBoxFiltroCli
            // 
            this.textBoxFiltroCli.Location = new System.Drawing.Point(238, 40);
            this.textBoxFiltroCli.Name = "textBoxFiltroCli";
            this.textBoxFiltroCli.Size = new System.Drawing.Size(192, 20);
            this.textBoxFiltroCli.TabIndex = 4;
            this.textBoxFiltroCli.Visible = false;
            // 
            // radioButtonFiltroSim
            // 
            this.radioButtonFiltroSim.AutoSize = true;
            this.radioButtonFiltroSim.Location = new System.Drawing.Point(50, 19);
            this.radioButtonFiltroSim.Name = "radioButtonFiltroSim";
            this.radioButtonFiltroSim.Size = new System.Drawing.Size(42, 17);
            this.radioButtonFiltroSim.TabIndex = 6;
            this.radioButtonFiltroSim.Text = "Sim";
            this.radioButtonFiltroSim.UseVisualStyleBackColor = true;
            this.radioButtonFiltroSim.CheckedChanged += new System.EventHandler(this.radioButtonFiltroSim_CheckedChanged);
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Location = new System.Drawing.Point(177, 43);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(57, 13);
            this.labelFiltro.TabIndex = 5;
            this.labelFiltro.Text = "Digite aqui";
            this.labelFiltro.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFormaOrdCli);
            this.groupBox1.Controls.Add(this.comboBoxOrdFormaCli);
            this.groupBox1.Controls.Add(this.lblOrdem);
            this.groupBox1.Controls.Add(this.radioButtonNaoCli);
            this.groupBox1.Controls.Add(this.lblPorOrd);
            this.groupBox1.Controls.Add(this.comboBoxOrdemCli);
            this.groupBox1.Controls.Add(this.radioButtonSimCli);
            this.groupBox1.Location = new System.Drawing.Point(498, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 107);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenar";
            // 
            // lblFormaOrdCli
            // 
            this.lblFormaOrdCli.AutoSize = true;
            this.lblFormaOrdCli.Location = new System.Drawing.Point(6, 64);
            this.lblFormaOrdCli.Name = "lblFormaOrdCli";
            this.lblFormaOrdCli.Size = new System.Drawing.Size(36, 13);
            this.lblFormaOrdCli.TabIndex = 13;
            this.lblFormaOrdCli.Text = "Forma";
            this.lblFormaOrdCli.Visible = false;
            // 
            // comboBoxOrdFormaCli
            // 
            this.comboBoxOrdFormaCli.FormattingEnabled = true;
            this.comboBoxOrdFormaCli.Items.AddRange(new object[] {
            "Crescente",
            "Decrescente"});
            this.comboBoxOrdFormaCli.Location = new System.Drawing.Point(47, 61);
            this.comboBoxOrdFormaCli.Name = "comboBoxOrdFormaCli";
            this.comboBoxOrdFormaCli.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrdFormaCli.TabIndex = 12;
            this.comboBoxOrdFormaCli.Visible = false;
            // 
            // lblOrdem
            // 
            this.lblOrdem.AutoSize = true;
            this.lblOrdem.Location = new System.Drawing.Point(15, 16);
            this.lblOrdem.Name = "lblOrdem";
            this.lblOrdem.Size = new System.Drawing.Size(45, 13);
            this.lblOrdem.TabIndex = 9;
            this.lblOrdem.Text = "Ordenar";
            // 
            // radioButtonNaoCli
            // 
            this.radioButtonNaoCli.AutoSize = true;
            this.radioButtonNaoCli.Checked = true;
            this.radioButtonNaoCli.Location = new System.Drawing.Point(114, 14);
            this.radioButtonNaoCli.Name = "radioButtonNaoCli";
            this.radioButtonNaoCli.Size = new System.Drawing.Size(45, 17);
            this.radioButtonNaoCli.TabIndex = 11;
            this.radioButtonNaoCli.TabStop = true;
            this.radioButtonNaoCli.Text = "Não";
            this.radioButtonNaoCli.UseVisualStyleBackColor = true;
            this.radioButtonNaoCli.CheckedChanged += new System.EventHandler(this.radioButtonNaoCli_CheckedChanged);
            // 
            // lblPorOrd
            // 
            this.lblPorOrd.AutoSize = true;
            this.lblPorOrd.Location = new System.Drawing.Point(18, 38);
            this.lblPorOrd.Name = "lblPorOrd";
            this.lblPorOrd.Size = new System.Drawing.Size(23, 13);
            this.lblPorOrd.TabIndex = 3;
            this.lblPorOrd.Text = "Por";
            this.lblPorOrd.Visible = false;
            // 
            // comboBoxOrdemCli
            // 
            this.comboBoxOrdemCli.FormattingEnabled = true;
            this.comboBoxOrdemCli.Items.AddRange(new object[] {
            "Nome",
            "Usuario",
            "Sexo",
            "Data Cadastro",
            "Status"});
            this.comboBoxOrdemCli.Location = new System.Drawing.Point(47, 34);
            this.comboBoxOrdemCli.Name = "comboBoxOrdemCli";
            this.comboBoxOrdemCli.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrdemCli.TabIndex = 2;
            this.comboBoxOrdemCli.Visible = false;
            // 
            // radioButtonSimCli
            // 
            this.radioButtonSimCli.AutoSize = true;
            this.radioButtonSimCli.Location = new System.Drawing.Point(66, 14);
            this.radioButtonSimCli.Name = "radioButtonSimCli";
            this.radioButtonSimCli.Size = new System.Drawing.Size(42, 17);
            this.radioButtonSimCli.TabIndex = 10;
            this.radioButtonSimCli.Text = "Sim";
            this.radioButtonSimCli.UseVisualStyleBackColor = true;
            this.radioButtonSimCli.CheckedChanged += new System.EventHandler(this.radioButtonSimCli_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1267, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto Thin", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(5)))), ((int)(((byte)(115)))));
            this.label2.Location = new System.Drawing.Point(455, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 65);
            this.label2.TabIndex = 20;
            this.label2.Text = "Consultar Cliente";
            // 
            // FormConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1267, 691);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxPropCli);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsultarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar dados de cliente";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienteConsulta)).EndInit();
            this.groupBoxPropCli.ResumeLayout(false);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkMenuCli;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewClienteConsulta;
        private System.Windows.Forms.Button btnExcluirCadCli;
        private System.Windows.Forms.Button btnAlterarCadCli;
        private System.Windows.Forms.GroupBox groupBoxPropCli;
        private System.Windows.Forms.Button btnPesquisaCli;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Label labelPor;
        private System.Windows.Forms.RadioButton radioButtonFiltroNao;
        private System.Windows.Forms.ComboBox comboBoxFiltrosCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFiltroCli;
        private System.Windows.Forms.RadioButton radioButtonFiltroSim;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOrdem;
        private System.Windows.Forms.RadioButton radioButtonNaoCli;
        private System.Windows.Forms.Label lblPorOrd;
        private System.Windows.Forms.ComboBox comboBoxOrdemCli;
        private System.Windows.Forms.RadioButton radioButtonSimCli;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Label lblFormaOrdCli;
        private System.Windows.Forms.ComboBox comboBoxOrdFormaCli;
        private System.Windows.Forms.Label label2;
    }
}