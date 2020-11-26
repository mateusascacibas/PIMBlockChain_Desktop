namespace PIMBlockChaimDesign
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogon = new System.Windows.Forms.Label();
            this.btnLogon = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pictureLogon = new System.Windows.Forms.PictureBox();
            this.groupBoxLogon = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogon)).BeginInit();
            this.groupBoxLogon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(158, 251);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(109, 37);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Senha";
            // 
            // lblLogon
            // 
            this.lblLogon.AutoSize = true;
            this.lblLogon.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogon.Location = new System.Drawing.Point(171, 188);
            this.lblLogon.Name = "lblLogon";
            this.lblLogon.Size = new System.Drawing.Size(96, 37);
            this.lblLogon.TabIndex = 10;
            this.lblLogon.Text = "Login";
            this.lblLogon.Click += new System.EventHandler(this.lblLogon_Click);
            // 
            // btnLogon
            // 
            this.btnLogon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogon.BackgroundImage")));
            this.btnLogon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogon.FlatAppearance.BorderSize = 0;
            this.btnLogon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogon.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogon.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLogon.Location = new System.Drawing.Point(12, 349);
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.Size = new System.Drawing.Size(180, 83);
            this.btnLogon.TabIndex = 8;
            this.btnLogon.UseVisualStyleBackColor = true;
            this.btnLogon.Click += new System.EventHandler(this.btnLogon_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(98, 291);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(223, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(98, 228);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(223, 20);
            this.txtUser.TabIndex = 6;
            // 
            // pictureLogon
            // 
            this.pictureLogon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureLogon.BackgroundImage")));
            this.pictureLogon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureLogon.Location = new System.Drawing.Point(156, 29);
            this.pictureLogon.Name = "pictureLogon";
            this.pictureLogon.Size = new System.Drawing.Size(124, 123);
            this.pictureLogon.TabIndex = 12;
            this.pictureLogon.TabStop = false;
            // 
            // groupBoxLogon
            // 
            this.groupBoxLogon.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxLogon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxLogon.Controls.Add(this.btnSair);
            this.groupBoxLogon.Controls.Add(this.txtUser);
            this.groupBoxLogon.Controls.Add(this.txtPassword);
            this.groupBoxLogon.Controls.Add(this.pictureLogon);
            this.groupBoxLogon.Controls.Add(this.btnLogon);
            this.groupBoxLogon.Controls.Add(this.lblPassword);
            this.groupBoxLogon.Controls.Add(this.lblLogon);
            this.groupBoxLogon.ForeColor = System.Drawing.Color.Transparent;
            this.groupBoxLogon.Location = new System.Drawing.Point(449, 134);
            this.groupBoxLogon.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxLogon.Name = "groupBoxLogon";
            this.groupBoxLogon.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxLogon.Size = new System.Drawing.Size(429, 451);
            this.groupBoxLogon.TabIndex = 14;
            this.groupBoxLogon.TabStop = false;
            this.groupBoxLogon.Text = "Logon";
            this.groupBoxLogon.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(230, 349);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(180, 83);
            this.btnSair.TabIndex = 14;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1267, 691);
            this.Controls.Add(this.groupBoxLogon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogon)).EndInit();
            this.groupBoxLogon.ResumeLayout(false);
            this.groupBoxLogon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogon;
        private System.Windows.Forms.Button btnLogon;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.PictureBox pictureLogon;
        private System.Windows.Forms.GroupBox groupBoxLogon;
        private System.Windows.Forms.Button btnSair;
    }
}

