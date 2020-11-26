namespace PIMBlockChaimDesign
{
    partial class FormAlterarCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlterarCadastroCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkStatus = new System.Windows.Forms.CheckBox();
            this.checkEndereco = new System.Windows.Forms.CheckBox();
            this.checkUF = new System.Windows.Forms.CheckBox();
            this.checkTelefone = new System.Windows.Forms.CheckBox();
            this.checkEmail = new System.Windows.Forms.CheckBox();
            this.checkLogin = new System.Windows.Forms.CheckBox();
            this.checkNome = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LinkLblLogonCli = new System.Windows.Forms.LinkLabel();
            this.btnCadCli = new System.Windows.Forms.Button();
            this.lblPhoneCad = new System.Windows.Forms.Label();
            this.txtEmailCadCli = new System.Windows.Forms.TextBox();
            this.lblEmailCad = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLogon = new System.Windows.Forms.Label();
            this.txtLogonCadCli = new System.Windows.Forms.TextBox();
            this.txtNameCadCli = new System.Windows.Forms.TextBox();
            this.picturePhoneCad = new System.Windows.Forms.PictureBox();
            this.pictureEmailCad = new System.Windows.Forms.PictureBox();
            this.pictureNameCad = new System.Windows.Forms.PictureBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.comboUF = new System.Windows.Forms.ComboBox();
            this.groupBoxCad = new System.Windows.Forms.GroupBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoneCad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmailCad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNameCad)).BeginInit();
            this.groupBoxCad.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkStatus);
            this.groupBox1.Controls.Add(this.checkEndereco);
            this.groupBox1.Controls.Add(this.checkUF);
            this.groupBox1.Controls.Add(this.checkTelefone);
            this.groupBox1.Controls.Add(this.checkEmail);
            this.groupBox1.Controls.Add(this.checkLogin);
            this.groupBox1.Controls.Add(this.checkNome);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(389, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 50);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // checkStatus
            // 
            this.checkStatus.AutoSize = true;
            this.checkStatus.BackColor = System.Drawing.Color.Transparent;
            this.checkStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkStatus.Location = new System.Drawing.Point(205, 19);
            this.checkStatus.Name = "checkStatus";
            this.checkStatus.Size = new System.Drawing.Size(75, 24);
            this.checkStatus.TabIndex = 6;
            this.checkStatus.Text = "Status";
            this.checkStatus.UseVisualStyleBackColor = false;
            this.checkStatus.CheckedChanged += new System.EventHandler(this.checkStatus_CheckedChanged);
            // 
            // checkEndereco
            // 
            this.checkEndereco.AutoSize = true;
            this.checkEndereco.BackColor = System.Drawing.Color.Transparent;
            this.checkEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEndereco.Location = new System.Drawing.Point(450, 19);
            this.checkEndereco.Name = "checkEndereco";
            this.checkEndereco.Size = new System.Drawing.Size(97, 24);
            this.checkEndereco.TabIndex = 5;
            this.checkEndereco.Text = "Endereco";
            this.checkEndereco.UseVisualStyleBackColor = false;
            // 
            // checkUF
            // 
            this.checkUF.AutoSize = true;
            this.checkUF.BackColor = System.Drawing.Color.Transparent;
            this.checkUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkUF.Location = new System.Drawing.Point(161, 19);
            this.checkUF.Name = "checkUF";
            this.checkUF.Size = new System.Drawing.Size(50, 24);
            this.checkUF.TabIndex = 4;
            this.checkUF.Text = "UF";
            this.checkUF.UseVisualStyleBackColor = false;
            // 
            // checkTelefone
            // 
            this.checkTelefone.AutoSize = true;
            this.checkTelefone.BackColor = System.Drawing.Color.Transparent;
            this.checkTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTelefone.Location = new System.Drawing.Point(354, 19);
            this.checkTelefone.Name = "checkTelefone";
            this.checkTelefone.Size = new System.Drawing.Size(90, 24);
            this.checkTelefone.TabIndex = 3;
            this.checkTelefone.Text = "Telefone";
            this.checkTelefone.UseVisualStyleBackColor = false;
            this.checkTelefone.CheckedChanged += new System.EventHandler(this.checkTelefone_CheckedChanged);
            // 
            // checkEmail
            // 
            this.checkEmail.AutoSize = true;
            this.checkEmail.BackColor = System.Drawing.Color.Transparent;
            this.checkEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEmail.Location = new System.Drawing.Point(88, 19);
            this.checkEmail.Name = "checkEmail";
            this.checkEmail.Size = new System.Drawing.Size(67, 24);
            this.checkEmail.TabIndex = 2;
            this.checkEmail.Text = "Email";
            this.checkEmail.UseVisualStyleBackColor = false;
            this.checkEmail.CheckedChanged += new System.EventHandler(this.checkEmail_CheckedChanged);
            // 
            // checkLogin
            // 
            this.checkLogin.AutoSize = true;
            this.checkLogin.BackColor = System.Drawing.Color.Transparent;
            this.checkLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLogin.Location = new System.Drawing.Point(286, 19);
            this.checkLogin.Name = "checkLogin";
            this.checkLogin.Size = new System.Drawing.Size(67, 24);
            this.checkLogin.TabIndex = 1;
            this.checkLogin.Text = "Login";
            this.checkLogin.UseVisualStyleBackColor = false;
            this.checkLogin.CheckedChanged += new System.EventHandler(this.checkLogin_CheckedChanged);
            // 
            // checkNome
            // 
            this.checkNome.AutoSize = true;
            this.checkNome.BackColor = System.Drawing.Color.Transparent;
            this.checkNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNome.Location = new System.Drawing.Point(12, 19);
            this.checkNome.Name = "checkNome";
            this.checkNome.Size = new System.Drawing.Size(70, 24);
            this.checkNome.TabIndex = 0;
            this.checkNome.Text = "Nome";
            this.checkNome.UseVisualStyleBackColor = false;
            this.checkNome.CheckedChanged += new System.EventHandler(this.checkNome_CheckedChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(652, 209);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(219, 20);
            this.txtID.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(452, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Entre com o ID do Cliente:";
            // 
            // LinkLblLogonCli
            // 
            this.LinkLblLogonCli.AutoSize = true;
            this.LinkLblLogonCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLblLogonCli.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LinkLblLogonCli.Location = new System.Drawing.Point(6, 278);
            this.LinkLblLogonCli.Name = "LinkLblLogonCli";
            this.LinkLblLogonCli.Size = new System.Drawing.Size(164, 20);
            this.LinkLblLogonCli.TabIndex = 13;
            this.LinkLblLogonCli.TabStop = true;
            this.LinkLblLogonCli.Text = "Voltar para a consulta";
            this.LinkLblLogonCli.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblLogonCli_LinkClicked);
            // 
            // btnCadCli
            // 
            this.btnCadCli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadCli.BackgroundImage")));
            this.btnCadCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadCli.FlatAppearance.BorderSize = 0;
            this.btnCadCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadCli.ForeColor = System.Drawing.Color.Black;
            this.btnCadCli.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCadCli.Location = new System.Drawing.Point(181, 187);
            this.btnCadCli.Name = "btnCadCli";
            this.btnCadCli.Size = new System.Drawing.Size(185, 92);
            this.btnCadCli.TabIndex = 12;
            this.btnCadCli.UseVisualStyleBackColor = true;
            this.btnCadCli.Click += new System.EventHandler(this.btnCadCli_Click);
            // 
            // lblPhoneCad
            // 
            this.lblPhoneCad.AutoSize = true;
            this.lblPhoneCad.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneCad.Location = new System.Drawing.Point(28, 93);
            this.lblPhoneCad.Name = "lblPhoneCad";
            this.lblPhoneCad.Size = new System.Drawing.Size(71, 20);
            this.lblPhoneCad.TabIndex = 9;
            this.lblPhoneCad.Text = "Telefone";
            // 
            // txtEmailCadCli
            // 
            this.txtEmailCadCli.Enabled = false;
            this.txtEmailCadCli.Location = new System.Drawing.Point(92, 59);
            this.txtEmailCadCli.Name = "txtEmailCadCli";
            this.txtEmailCadCli.Size = new System.Drawing.Size(226, 20);
            this.txtEmailCadCli.TabIndex = 8;
            this.txtEmailCadCli.TextChanged += new System.EventHandler(this.txtEmailCadCli_TextChanged);
            // 
            // lblEmailCad
            // 
            this.lblEmailCad.AutoSize = true;
            this.lblEmailCad.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCad.Location = new System.Drawing.Point(35, 59);
            this.lblEmailCad.Name = "lblEmailCad";
            this.lblEmailCad.Size = new System.Drawing.Size(48, 20);
            this.lblEmailCad.TabIndex = 7;
            this.lblEmailCad.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(35, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nome";
            // 
            // lblLogon
            // 
            this.lblLogon.AutoSize = true;
            this.lblLogon.BackColor = System.Drawing.Color.Transparent;
            this.lblLogon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogon.Location = new System.Drawing.Point(324, 28);
            this.lblLogon.Name = "lblLogon";
            this.lblLogon.Size = new System.Drawing.Size(48, 20);
            this.lblLogon.TabIndex = 2;
            this.lblLogon.Text = "Login";
            // 
            // txtLogonCadCli
            // 
            this.txtLogonCadCli.Enabled = false;
            this.txtLogonCadCli.Location = new System.Drawing.Point(378, 30);
            this.txtLogonCadCli.Name = "txtLogonCadCli";
            this.txtLogonCadCli.Size = new System.Drawing.Size(159, 20);
            this.txtLogonCadCli.TabIndex = 0;
            // 
            // txtNameCadCli
            // 
            this.txtNameCadCli.Enabled = false;
            this.txtNameCadCli.Location = new System.Drawing.Point(92, 30);
            this.txtNameCadCli.Name = "txtNameCadCli";
            this.txtNameCadCli.Size = new System.Drawing.Size(226, 20);
            this.txtNameCadCli.TabIndex = 4;
            // 
            // picturePhoneCad
            // 
            this.picturePhoneCad.Image = ((System.Drawing.Image)(resources.GetObject("picturePhoneCad.Image")));
            this.picturePhoneCad.Location = new System.Drawing.Point(11, 95);
            this.picturePhoneCad.Name = "picturePhoneCad";
            this.picturePhoneCad.Size = new System.Drawing.Size(16, 16);
            this.picturePhoneCad.TabIndex = 28;
            this.picturePhoneCad.TabStop = false;
            // 
            // pictureEmailCad
            // 
            this.pictureEmailCad.Image = ((System.Drawing.Image)(resources.GetObject("pictureEmailCad.Image")));
            this.pictureEmailCad.Location = new System.Drawing.Point(20, 61);
            this.pictureEmailCad.Name = "pictureEmailCad";
            this.pictureEmailCad.Size = new System.Drawing.Size(16, 16);
            this.pictureEmailCad.TabIndex = 29;
            this.pictureEmailCad.TabStop = false;
            // 
            // pictureNameCad
            // 
            this.pictureNameCad.Image = ((System.Drawing.Image)(resources.GetObject("pictureNameCad.Image")));
            this.pictureNameCad.Location = new System.Drawing.Point(23, 30);
            this.pictureNameCad.Name = "pictureNameCad";
            this.pictureNameCad.Size = new System.Drawing.Size(16, 16);
            this.pictureNameCad.TabIndex = 31;
            this.pictureNameCad.TabStop = false;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Location = new System.Drawing.Point(100, 93);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 32;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(127, 139);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(226, 20);
            this.txtEndereco.TabIndex = 45;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(43, 137);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(78, 20);
            this.lblEndereco.TabIndex = 46;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.BackColor = System.Drawing.Color.Transparent;
            this.lblUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.Location = new System.Drawing.Point(363, 139);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(31, 20);
            this.lblUF.TabIndex = 47;
            this.lblUF.Text = "UF";
            // 
            // comboUF
            // 
            this.comboUF.Enabled = false;
            this.comboUF.FormattingEnabled = true;
            this.comboUF.Location = new System.Drawing.Point(401, 138);
            this.comboUF.Name = "comboUF";
            this.comboUF.Size = new System.Drawing.Size(47, 21);
            this.comboUF.TabIndex = 48;
            // 
            // groupBoxCad
            // 
            this.groupBoxCad.Controls.Add(this.comboStatus);
            this.groupBoxCad.Controls.Add(this.lblStatus);
            this.groupBoxCad.Controls.Add(this.comboUF);
            this.groupBoxCad.Controls.Add(this.lblUF);
            this.groupBoxCad.Controls.Add(this.lblEndereco);
            this.groupBoxCad.Controls.Add(this.txtEndereco);
            this.groupBoxCad.Controls.Add(this.txtTelefone);
            this.groupBoxCad.Controls.Add(this.pictureNameCad);
            this.groupBoxCad.Controls.Add(this.pictureEmailCad);
            this.groupBoxCad.Controls.Add(this.picturePhoneCad);
            this.groupBoxCad.Controls.Add(this.txtNameCadCli);
            this.groupBoxCad.Controls.Add(this.txtLogonCadCli);
            this.groupBoxCad.Controls.Add(this.lblLogon);
            this.groupBoxCad.Controls.Add(this.lblName);
            this.groupBoxCad.Controls.Add(this.lblEmailCad);
            this.groupBoxCad.Controls.Add(this.txtEmailCadCli);
            this.groupBoxCad.Controls.Add(this.lblPhoneCad);
            this.groupBoxCad.Controls.Add(this.btnCadCli);
            this.groupBoxCad.Controls.Add(this.LinkLblLogonCli);
            this.groupBoxCad.ForeColor = System.Drawing.Color.White;
            this.groupBoxCad.Location = new System.Drawing.Point(389, 329);
            this.groupBoxCad.Name = "groupBoxCad";
            this.groupBoxCad.Size = new System.Drawing.Size(548, 305);
            this.groupBoxCad.TabIndex = 31;
            this.groupBoxCad.TabStop = false;
            this.groupBoxCad.Text = "Dados Cadastrais";
            // 
            // comboStatus
            // 
            this.comboStatus.Enabled = false;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Inativo"});
            this.comboStatus.Location = new System.Drawing.Point(367, 92);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(77, 21);
            this.comboStatus.TabIndex = 50;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(310, 93);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 20);
            this.lblStatus.TabIndex = 49;
            this.lblStatus.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto Thin", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(5)))), ((int)(((byte)(115)))));
            this.label3.Location = new System.Drawing.Point(406, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(511, 65);
            this.label3.TabIndex = 41;
            this.label3.Text = "Alterar dados Cliente";
            // 
            // FormAlterarCadastroCliente
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlterarCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar cadastro de cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoneCad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmailCad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNameCad)).EndInit();
            this.groupBoxCad.ResumeLayout(false);
            this.groupBoxCad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkNome;
        private System.Windows.Forms.CheckBox checkTelefone;
        private System.Windows.Forms.CheckBox checkEmail;
        private System.Windows.Forms.CheckBox checkLogin;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox checkEndereco;
        private System.Windows.Forms.CheckBox checkUF;
        private System.Windows.Forms.CheckBox checkStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel LinkLblLogonCli;
        private System.Windows.Forms.Button btnCadCli;
        private System.Windows.Forms.Label lblPhoneCad;
        private System.Windows.Forms.TextBox txtEmailCadCli;
        private System.Windows.Forms.Label lblEmailCad;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLogon;
        private System.Windows.Forms.TextBox txtLogonCadCli;
        private System.Windows.Forms.TextBox txtNameCadCli;
        private System.Windows.Forms.PictureBox picturePhoneCad;
        private System.Windows.Forms.PictureBox pictureEmailCad;
        private System.Windows.Forms.PictureBox pictureNameCad;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.ComboBox comboUF;
        private System.Windows.Forms.GroupBox groupBoxCad;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
    }
}