namespace PIMBlockChaimDesign
{
    partial class FormAlterarCadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlterarCadastroFuncionario));
            this.groupBoxCad = new System.Windows.Forms.GroupBox();
            this.comboUF = new System.Windows.Forms.ComboBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.comboCargoCad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureNameCad = new System.Windows.Forms.PictureBox();
            this.pictureEmailCad = new System.Windows.Forms.PictureBox();
            this.picturePhoneCad = new System.Windows.Forms.PictureBox();
            this.txtNameCad = new System.Windows.Forms.TextBox();
            this.txtLogonCad = new System.Windows.Forms.TextBox();
            this.lblLogon = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmailCad = new System.Windows.Forms.Label();
            this.txtEmailCad = new System.Windows.Forms.TextBox();
            this.lblPhoneCad = new System.Windows.Forms.Label();
            this.btnCad = new System.Windows.Forms.Button();
            this.LinkLblLogon = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkUF = new System.Windows.Forms.CheckBox();
            this.checkEndereco = new System.Windows.Forms.CheckBox();
            this.checkCargo = new System.Windows.Forms.CheckBox();
            this.checkTelefone = new System.Windows.Forms.CheckBox();
            this.checkEmail = new System.Windows.Forms.CheckBox();
            this.checkLogin = new System.Windows.Forms.CheckBox();
            this.checkNome = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxCad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNameCad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmailCad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoneCad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCad
            // 
            this.groupBoxCad.Controls.Add(this.comboUF);
            this.groupBoxCad.Controls.Add(this.lblUF);
            this.groupBoxCad.Controls.Add(this.lblEndereco);
            this.groupBoxCad.Controls.Add(this.txtEndereco);
            this.groupBoxCad.Controls.Add(this.txtTelefone);
            this.groupBoxCad.Controls.Add(this.comboCargoCad);
            this.groupBoxCad.Controls.Add(this.label1);
            this.groupBoxCad.Controls.Add(this.pictureNameCad);
            this.groupBoxCad.Controls.Add(this.pictureEmailCad);
            this.groupBoxCad.Controls.Add(this.picturePhoneCad);
            this.groupBoxCad.Controls.Add(this.txtNameCad);
            this.groupBoxCad.Controls.Add(this.txtLogonCad);
            this.groupBoxCad.Controls.Add(this.lblLogon);
            this.groupBoxCad.Controls.Add(this.lblName);
            this.groupBoxCad.Controls.Add(this.lblEmailCad);
            this.groupBoxCad.Controls.Add(this.txtEmailCad);
            this.groupBoxCad.Controls.Add(this.lblPhoneCad);
            this.groupBoxCad.Controls.Add(this.btnCad);
            this.groupBoxCad.Controls.Add(this.LinkLblLogon);
            this.groupBoxCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCad.ForeColor = System.Drawing.Color.White;
            this.groupBoxCad.Location = new System.Drawing.Point(354, 300);
            this.groupBoxCad.Name = "groupBoxCad";
            this.groupBoxCad.Size = new System.Drawing.Size(628, 336);
            this.groupBoxCad.TabIndex = 30;
            this.groupBoxCad.TabStop = false;
            this.groupBoxCad.Text = "Dados Cadastrais";
            this.groupBoxCad.Enter += new System.EventHandler(this.groupBoxCad_Enter);
            // 
            // comboUF
            // 
            this.comboUF.Enabled = false;
            this.comboUF.FormattingEnabled = true;
            this.comboUF.Location = new System.Drawing.Point(478, 172);
            this.comboUF.Name = "comboUF";
            this.comboUF.Size = new System.Drawing.Size(47, 28);
            this.comboUF.TabIndex = 44;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.Location = new System.Drawing.Point(441, 175);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(31, 20);
            this.lblUF.TabIndex = 43;
            this.lblUF.Text = "UF";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(67, 172);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(78, 20);
            this.lblEndereco.TabIndex = 41;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(144, 172);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(277, 26);
            this.txtEndereco.TabIndex = 40;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Location = new System.Drawing.Point(107, 89);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 26);
            this.txtTelefone.TabIndex = 38;
            // 
            // comboCargoCad
            // 
            this.comboCargoCad.Enabled = false;
            this.comboCargoCad.FormattingEnabled = true;
            this.comboCargoCad.Items.AddRange(new object[] {
            "ADM",
            "Usuario"});
            this.comboCargoCad.Location = new System.Drawing.Point(384, 52);
            this.comboCargoCad.Name = "comboCargoCad";
            this.comboCargoCad.Size = new System.Drawing.Size(121, 28);
            this.comboCargoCad.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cargo";
            // 
            // pictureNameCad
            // 
            this.pictureNameCad.Image = ((System.Drawing.Image)(resources.GetObject("pictureNameCad.Image")));
            this.pictureNameCad.Location = new System.Drawing.Point(21, 22);
            this.pictureNameCad.Name = "pictureNameCad";
            this.pictureNameCad.Size = new System.Drawing.Size(14, 20);
            this.pictureNameCad.TabIndex = 31;
            this.pictureNameCad.TabStop = false;
            // 
            // pictureEmailCad
            // 
            this.pictureEmailCad.Image = ((System.Drawing.Image)(resources.GetObject("pictureEmailCad.Image")));
            this.pictureEmailCad.Location = new System.Drawing.Point(29, 56);
            this.pictureEmailCad.Name = "pictureEmailCad";
            this.pictureEmailCad.Size = new System.Drawing.Size(16, 16);
            this.pictureEmailCad.TabIndex = 29;
            this.pictureEmailCad.TabStop = false;
            // 
            // picturePhoneCad
            // 
            this.picturePhoneCad.Image = ((System.Drawing.Image)(resources.GetObject("picturePhoneCad.Image")));
            this.picturePhoneCad.Location = new System.Drawing.Point(16, 94);
            this.picturePhoneCad.Name = "picturePhoneCad";
            this.picturePhoneCad.Size = new System.Drawing.Size(16, 16);
            this.picturePhoneCad.TabIndex = 28;
            this.picturePhoneCad.TabStop = false;
            // 
            // txtNameCad
            // 
            this.txtNameCad.Enabled = false;
            this.txtNameCad.Location = new System.Drawing.Point(101, 19);
            this.txtNameCad.Name = "txtNameCad";
            this.txtNameCad.Size = new System.Drawing.Size(226, 26);
            this.txtNameCad.TabIndex = 4;
            // 
            // txtLogonCad
            // 
            this.txtLogonCad.Enabled = false;
            this.txtLogonCad.Location = new System.Drawing.Point(384, 19);
            this.txtLogonCad.Name = "txtLogonCad";
            this.txtLogonCad.Size = new System.Drawing.Size(226, 26);
            this.txtLogonCad.TabIndex = 0;
            this.txtLogonCad.TextChanged += new System.EventHandler(this.txtLogonCad_TextChanged);
            // 
            // lblLogon
            // 
            this.lblLogon.AutoSize = true;
            this.lblLogon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogon.Location = new System.Drawing.Point(330, 22);
            this.lblLogon.Name = "lblLogon";
            this.lblLogon.Size = new System.Drawing.Size(48, 20);
            this.lblLogon.TabIndex = 2;
            this.lblLogon.Text = "Login";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(41, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nome";
            // 
            // lblEmailCad
            // 
            this.lblEmailCad.AutoSize = true;
            this.lblEmailCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCad.Location = new System.Drawing.Point(47, 54);
            this.lblEmailCad.Name = "lblEmailCad";
            this.lblEmailCad.Size = new System.Drawing.Size(48, 20);
            this.lblEmailCad.TabIndex = 7;
            this.lblEmailCad.Text = "Email";
            // 
            // txtEmailCad
            // 
            this.txtEmailCad.Enabled = false;
            this.txtEmailCad.Location = new System.Drawing.Point(101, 51);
            this.txtEmailCad.Name = "txtEmailCad";
            this.txtEmailCad.Size = new System.Drawing.Size(226, 26);
            this.txtEmailCad.TabIndex = 8;
            // 
            // lblPhoneCad
            // 
            this.lblPhoneCad.AutoSize = true;
            this.lblPhoneCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneCad.Location = new System.Drawing.Point(31, 92);
            this.lblPhoneCad.Name = "lblPhoneCad";
            this.lblPhoneCad.Size = new System.Drawing.Size(71, 20);
            this.lblPhoneCad.TabIndex = 9;
            this.lblPhoneCad.Text = "Telefone";
            // 
            // btnCad
            // 
            this.btnCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.btnCad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCad.BackgroundImage")));
            this.btnCad.FlatAppearance.BorderSize = 0;
            this.btnCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCad.ForeColor = System.Drawing.Color.Black;
            this.btnCad.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCad.Location = new System.Drawing.Point(216, 218);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(191, 84);
            this.btnCad.TabIndex = 12;
            this.btnCad.UseVisualStyleBackColor = false;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // LinkLblLogon
            // 
            this.LinkLblLogon.AutoSize = true;
            this.LinkLblLogon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLblLogon.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LinkLblLogon.Location = new System.Drawing.Point(6, 313);
            this.LinkLblLogon.Name = "LinkLblLogon";
            this.LinkLblLogon.Size = new System.Drawing.Size(164, 20);
            this.LinkLblLogon.TabIndex = 13;
            this.LinkLblLogon.TabStop = true;
            this.LinkLblLogon.Text = "Voltar para a consulta";
            this.LinkLblLogon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblLogon_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1267, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkUF);
            this.groupBox1.Controls.Add(this.checkEndereco);
            this.groupBox1.Controls.Add(this.checkCargo);
            this.groupBox1.Controls.Add(this.checkTelefone);
            this.groupBox1.Controls.Add(this.checkEmail);
            this.groupBox1.Controls.Add(this.checkLogin);
            this.groupBox1.Controls.Add(this.checkNome);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(354, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 50);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // checkUF
            // 
            this.checkUF.AutoSize = true;
            this.checkUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkUF.Location = new System.Drawing.Point(320, 19);
            this.checkUF.Name = "checkUF";
            this.checkUF.Size = new System.Drawing.Size(50, 24);
            this.checkUF.TabIndex = 7;
            this.checkUF.Text = "UF";
            this.checkUF.UseVisualStyleBackColor = true;
            this.checkUF.CheckedChanged += new System.EventHandler(this.checkUF_CheckedChanged);
            // 
            // checkEndereco
            // 
            this.checkEndereco.AutoSize = true;
            this.checkEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEndereco.Location = new System.Drawing.Point(205, 19);
            this.checkEndereco.Name = "checkEndereco";
            this.checkEndereco.Size = new System.Drawing.Size(97, 24);
            this.checkEndereco.TabIndex = 6;
            this.checkEndereco.Text = "Endereço";
            this.checkEndereco.UseVisualStyleBackColor = true;
            this.checkEndereco.CheckedChanged += new System.EventHandler(this.checkEndereco_CheckedChanged);
            // 
            // checkCargo
            // 
            this.checkCargo.AutoSize = true;
            this.checkCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCargo.Location = new System.Drawing.Point(388, 19);
            this.checkCargo.Name = "checkCargo";
            this.checkCargo.Size = new System.Drawing.Size(71, 24);
            this.checkCargo.TabIndex = 5;
            this.checkCargo.Text = "Cargo";
            this.checkCargo.UseVisualStyleBackColor = true;
            this.checkCargo.CheckedChanged += new System.EventHandler(this.checkCargo_CheckedChanged);
            // 
            // checkTelefone
            // 
            this.checkTelefone.AutoSize = true;
            this.checkTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTelefone.Location = new System.Drawing.Point(465, 19);
            this.checkTelefone.Name = "checkTelefone";
            this.checkTelefone.Size = new System.Drawing.Size(90, 24);
            this.checkTelefone.TabIndex = 3;
            this.checkTelefone.Text = "Telefone";
            this.checkTelefone.UseVisualStyleBackColor = true;
            this.checkTelefone.CheckedChanged += new System.EventHandler(this.checkTelefone_CheckedChanged);
            // 
            // checkEmail
            // 
            this.checkEmail.AutoSize = true;
            this.checkEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEmail.Location = new System.Drawing.Point(113, 19);
            this.checkEmail.Name = "checkEmail";
            this.checkEmail.Size = new System.Drawing.Size(67, 24);
            this.checkEmail.TabIndex = 2;
            this.checkEmail.Text = "Email";
            this.checkEmail.UseVisualStyleBackColor = true;
            this.checkEmail.CheckedChanged += new System.EventHandler(this.checkEmail_CheckedChanged);
            // 
            // checkLogin
            // 
            this.checkLogin.AutoSize = true;
            this.checkLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLogin.Location = new System.Drawing.Point(561, 19);
            this.checkLogin.Name = "checkLogin";
            this.checkLogin.Size = new System.Drawing.Size(67, 24);
            this.checkLogin.TabIndex = 1;
            this.checkLogin.Text = "Login";
            this.checkLogin.UseVisualStyleBackColor = true;
            this.checkLogin.CheckedChanged += new System.EventHandler(this.checkLogin_CheckedChanged);
            // 
            // checkNome
            // 
            this.checkNome.AutoSize = true;
            this.checkNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNome.Location = new System.Drawing.Point(28, 19);
            this.checkNome.Name = "checkNome";
            this.checkNome.Size = new System.Drawing.Size(70, 24);
            this.checkNome.TabIndex = 0;
            this.checkNome.Text = "Nome";
            this.checkNome.UseVisualStyleBackColor = true;
            this.checkNome.CheckedChanged += new System.EventHandler(this.checkNome_CheckedChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(688, 203);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(153, 20);
            this.txtID.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(484, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Entre com o ID do Funcionário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto Thin", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(5)))), ((int)(((byte)(115)))));
            this.label3.Location = new System.Drawing.Point(285, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(826, 65);
            this.label3.TabIndex = 39;
            this.label3.Text = "Alterar dados Funcionário/Usuário";
            // 
            // FormAlterarCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1267, 691);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCad);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAlterarCadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAlterarCadastroFuncionario";
            this.Load += new System.EventHandler(this.FormAlterarCadastroFuncionario_Load);
            this.groupBoxCad.ResumeLayout(false);
            this.groupBoxCad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNameCad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmailCad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoneCad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCad;
        private System.Windows.Forms.ComboBox comboCargoCad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureNameCad;
        private System.Windows.Forms.PictureBox pictureEmailCad;
        private System.Windows.Forms.PictureBox picturePhoneCad;
        private System.Windows.Forms.TextBox txtNameCad;
        private System.Windows.Forms.TextBox txtLogonCad;
        private System.Windows.Forms.Label lblLogon;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmailCad;
        private System.Windows.Forms.TextBox txtEmailCad;
        private System.Windows.Forms.Label lblPhoneCad;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.LinkLabel LinkLblLogon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkCargo;
        private System.Windows.Forms.CheckBox checkTelefone;
        private System.Windows.Forms.CheckBox checkEmail;
        private System.Windows.Forms.CheckBox checkLogin;
        private System.Windows.Forms.CheckBox checkNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboUF;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.CheckBox checkUF;
        private System.Windows.Forms.CheckBox checkEndereco;
        private System.Windows.Forms.Label label3;
    }
}