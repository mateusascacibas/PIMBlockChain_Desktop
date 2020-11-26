namespace PIMBlockChaimDesign
{
    partial class FormConsultarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultarUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxProp = new System.Windows.Forms.GroupBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.labelPor = new System.Windows.Forms.Label();
            this.radioButtonFiltroNao = new System.Windows.Forms.RadioButton();
            this.comboBoxFiltros = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.radioButtonFiltroSim = new System.Windows.Forms.RadioButton();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFormaOrd = new System.Windows.Forms.Label();
            this.comboBoxFormaOrd = new System.Windows.Forms.ComboBox();
            this.lblOrdem = new System.Windows.Forms.Label();
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            this.lblPorOrd = new System.Windows.Forms.Label();
            this.comboBoxOrdem = new System.Windows.Forms.ComboBox();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.btnAlterarCad = new System.Windows.Forms.Button();
            this.btnExcluirCad = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFinançasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewUsuarioConsulta = new System.Windows.Forms.DataGridView();
            this.linkMenu = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxProp.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarioConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxProp
            // 
            this.groupBoxProp.Controls.Add(this.btnPesquisa);
            this.groupBoxProp.Controls.Add(this.groupBoxFilter);
            this.groupBoxProp.Controls.Add(this.groupBox1);
            this.groupBoxProp.ForeColor = System.Drawing.Color.White;
            this.groupBoxProp.Location = new System.Drawing.Point(278, 181);
            this.groupBoxProp.Name = "groupBoxProp";
            this.groupBoxProp.Size = new System.Drawing.Size(776, 181);
            this.groupBoxProp.TabIndex = 0;
            this.groupBoxProp.TabStop = false;
            this.groupBoxProp.Text = "Propriedades";
            this.groupBoxProp.Enter += new System.EventHandler(this.groupBoxProp_Enter);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.btnPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.BackgroundImage")));
            this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisa.FlatAppearance.BorderSize = 0;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPesquisa.Location = new System.Drawing.Point(519, 127);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(192, 48);
            this.btnPesquisa.TabIndex = 15;
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.labelPor);
            this.groupBoxFilter.Controls.Add(this.radioButtonFiltroNao);
            this.groupBoxFilter.Controls.Add(this.comboBoxFiltros);
            this.groupBoxFilter.Controls.Add(this.label1);
            this.groupBoxFilter.Controls.Add(this.textBoxFiltro);
            this.groupBoxFilter.Controls.Add(this.radioButtonFiltroSim);
            this.groupBoxFilter.Controls.Add(this.labelFiltro);
            this.groupBoxFilter.Location = new System.Drawing.Point(20, 19);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(453, 120);
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
            // comboBoxFiltros
            // 
            this.comboBoxFiltros.FormattingEnabled = true;
            this.comboBoxFiltros.Items.AddRange(new object[] {
            "Nome",
            "Cargo",
            "Sexo",
            "Intervalo de datas"});
            this.comboBoxFiltros.Location = new System.Drawing.Point(50, 40);
            this.comboBoxFiltros.Name = "comboBoxFiltros";
            this.comboBoxFiltros.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltros.TabIndex = 0;
            this.comboBoxFiltros.Visible = false;
            this.comboBoxFiltros.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltros_SelectedIndexChanged);
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
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(238, 40);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(192, 20);
            this.textBoxFiltro.TabIndex = 4;
            this.textBoxFiltro.Visible = false;
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
            this.groupBox1.Controls.Add(this.lblFormaOrd);
            this.groupBox1.Controls.Add(this.comboBoxFormaOrd);
            this.groupBox1.Controls.Add(this.lblOrdem);
            this.groupBox1.Controls.Add(this.radioButtonNao);
            this.groupBox1.Controls.Add(this.lblPorOrd);
            this.groupBox1.Controls.Add(this.comboBoxOrdem);
            this.groupBox1.Controls.Add(this.radioButtonSim);
            this.groupBox1.Location = new System.Drawing.Point(498, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 107);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenar";
            // 
            // lblFormaOrd
            // 
            this.lblFormaOrd.AutoSize = true;
            this.lblFormaOrd.Location = new System.Drawing.Point(6, 64);
            this.lblFormaOrd.Name = "lblFormaOrd";
            this.lblFormaOrd.Size = new System.Drawing.Size(36, 13);
            this.lblFormaOrd.TabIndex = 13;
            this.lblFormaOrd.Text = "Forma";
            this.lblFormaOrd.Visible = false;
            // 
            // comboBoxFormaOrd
            // 
            this.comboBoxFormaOrd.FormattingEnabled = true;
            this.comboBoxFormaOrd.Items.AddRange(new object[] {
            "Crescente",
            "Descrecente"});
            this.comboBoxFormaOrd.Location = new System.Drawing.Point(47, 61);
            this.comboBoxFormaOrd.Name = "comboBoxFormaOrd";
            this.comboBoxFormaOrd.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFormaOrd.TabIndex = 12;
            this.comboBoxFormaOrd.Visible = false;
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
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Checked = true;
            this.radioButtonNao.Location = new System.Drawing.Point(114, 14);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(45, 17);
            this.radioButtonNao.TabIndex = 11;
            this.radioButtonNao.TabStop = true;
            this.radioButtonNao.Text = "Não";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            this.radioButtonNao.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            // comboBoxOrdem
            // 
            this.comboBoxOrdem.FormattingEnabled = true;
            this.comboBoxOrdem.Items.AddRange(new object[] {
            "Nome",
            "Usuario",
            "Sexo",
            "Data Cadastro",
            "Cargo",
            "Status"});
            this.comboBoxOrdem.Location = new System.Drawing.Point(47, 34);
            this.comboBoxOrdem.Name = "comboBoxOrdem";
            this.comboBoxOrdem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrdem.TabIndex = 2;
            this.comboBoxOrdem.Visible = false;
            this.comboBoxOrdem.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrdem_SelectedIndexChanged);
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Location = new System.Drawing.Point(66, 14);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(42, 17);
            this.radioButtonSim.TabIndex = 10;
            this.radioButtonSim.Text = "Sim";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            this.radioButtonSim.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnAlterarCad
            // 
            this.btnAlterarCad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterarCad.BackgroundImage")));
            this.btnAlterarCad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlterarCad.FlatAppearance.BorderSize = 0;
            this.btnAlterarCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarCad.ForeColor = System.Drawing.Color.Black;
            this.btnAlterarCad.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAlterarCad.Location = new System.Drawing.Point(403, 175);
            this.btnAlterarCad.Name = "btnAlterarCad";
            this.btnAlterarCad.Size = new System.Drawing.Size(186, 95);
            this.btnAlterarCad.TabIndex = 12;
            this.btnAlterarCad.UseVisualStyleBackColor = true;
            this.btnAlterarCad.Click += new System.EventHandler(this.btnAlterarCad_Click);
            // 
            // btnExcluirCad
            // 
            this.btnExcluirCad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluirCad.BackgroundImage")));
            this.btnExcluirCad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluirCad.FlatAppearance.BorderSize = 0;
            this.btnExcluirCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCad.ForeColor = System.Drawing.Color.Black;
            this.btnExcluirCad.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExcluirCad.Location = new System.Drawing.Point(583, 175);
            this.btnExcluirCad.Name = "btnExcluirCad";
            this.btnExcluirCad.Size = new System.Drawing.Size(178, 79);
            this.btnExcluirCad.TabIndex = 13;
            this.btnExcluirCad.UseVisualStyleBackColor = true;
            this.btnExcluirCad.Click += new System.EventHandler(this.btnExcluirCad_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1267, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuarioToolStripMenuItem,
            this.consultarUsuarioToolStripMenuItem,
            this.consultarFinançasToolStripMenuItem,
            this.cadastrarClienteToolStripMenuItem,
            this.consultarClienteToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // cadastrarUsuarioToolStripMenuItem
            // 
            this.cadastrarUsuarioToolStripMenuItem.Name = "cadastrarUsuarioToolStripMenuItem";
            this.cadastrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cadastrarUsuarioToolStripMenuItem.Text = "Cadastrar Usuario";
            // 
            // consultarUsuarioToolStripMenuItem
            // 
            this.consultarUsuarioToolStripMenuItem.Name = "consultarUsuarioToolStripMenuItem";
            this.consultarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.consultarUsuarioToolStripMenuItem.Text = "Consultar Usuario";
            // 
            // consultarFinançasToolStripMenuItem
            // 
            this.consultarFinançasToolStripMenuItem.Name = "consultarFinançasToolStripMenuItem";
            this.consultarFinançasToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.consultarFinançasToolStripMenuItem.Text = "Consultar Finanças";
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cadastrarClienteToolStripMenuItem.Text = "Cadastrar Cliente";
            // 
            // consultarClienteToolStripMenuItem
            // 
            this.consultarClienteToolStripMenuItem.Name = "consultarClienteToolStripMenuItem";
            this.consultarClienteToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.consultarClienteToolStripMenuItem.Text = "Consultar Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewUsuarioConsulta);
            this.groupBox2.Controls.Add(this.linkMenu);
            this.groupBox2.Controls.Add(this.btnExcluirCad);
            this.groupBox2.Controls.Add(this.btnAlterarCad);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(278, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 280);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grade de pesquisa";
            // 
            // dataGridViewUsuarioConsulta
            // 
            this.dataGridViewUsuarioConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarioConsulta.Location = new System.Drawing.Point(20, 19);
            this.dataGridViewUsuarioConsulta.Name = "dataGridViewUsuarioConsulta";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewUsuarioConsulta.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewUsuarioConsulta.Size = new System.Drawing.Size(750, 150);
            this.dataGridViewUsuarioConsulta.TabIndex = 17;
            // 
            // linkMenu
            // 
            this.linkMenu.AutoSize = true;
            this.linkMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkMenu.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkMenu.Location = new System.Drawing.Point(6, 257);
            this.linkMenu.Name = "linkMenu";
            this.linkMenu.Size = new System.Drawing.Size(117, 20);
            this.linkMenu.TabIndex = 16;
            this.linkMenu.TabStop = true;
            this.linkMenu.Text = "Voltar ao Menu";
            this.linkMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMenu_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto Thin", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(5)))), ((int)(((byte)(115)))));
            this.label2.Location = new System.Drawing.Point(452, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 65);
            this.label2.TabIndex = 16;
            this.label2.Text = "Consultar Usuário";
            // 
            // FormConsultarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1267, 691);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxProp);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormConsultarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Usuario";
            this.groupBoxProp.ResumeLayout(false);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarioConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProp;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Label lblPorOrd;
        private System.Windows.Forms.ComboBox comboBoxOrdem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFiltros;
        private System.Windows.Forms.Label labelPor;
        private System.Windows.Forms.RadioButton radioButtonFiltroNao;
        private System.Windows.Forms.RadioButton radioButtonFiltroSim;
        private System.Windows.Forms.RadioButton radioButtonNao;
        private System.Windows.Forms.RadioButton radioButtonSim;
        private System.Windows.Forms.Label lblOrdem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAlterarCad;
        private System.Windows.Forms.Button btnExcluirCad;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkMenu;
        private System.Windows.Forms.Label lblFormaOrd;
        private System.Windows.Forms.ComboBox comboBoxFormaOrd;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFinançasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClienteToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewUsuarioConsulta;
        private System.Windows.Forms.Label label2;
    }
}