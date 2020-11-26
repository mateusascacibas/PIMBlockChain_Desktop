namespace PIMBlockChaimDesign
{
    partial class FormConsultaFinancas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaFinancas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNomeConsultaFin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultaFinanca = new System.Windows.Forms.Button();
            this.linkLabelMenu = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewClienteConsulta = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienteConsulta)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeConsultaFin
            // 
            this.txtNomeConsultaFin.Location = new System.Drawing.Point(616, 356);
            this.txtNomeConsultaFin.Name = "txtNomeConsultaFin";
            this.txtNomeConsultaFin.Size = new System.Drawing.Size(210, 20);
            this.txtNomeConsultaFin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Artifakt Element", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(5)))), ((int)(((byte)(115)))));
            this.label1.Location = new System.Drawing.Point(389, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o ID do Cliente:";
            // 
            // btnConsultaFinanca
            // 
            this.btnConsultaFinanca.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultaFinanca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultaFinanca.BackgroundImage")));
            this.btnConsultaFinanca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConsultaFinanca.FlatAppearance.BorderSize = 0;
            this.btnConsultaFinanca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaFinanca.Location = new System.Drawing.Point(604, 382);
            this.btnConsultaFinanca.Name = "btnConsultaFinanca";
            this.btnConsultaFinanca.Size = new System.Drawing.Size(184, 93);
            this.btnConsultaFinanca.TabIndex = 2;
            this.btnConsultaFinanca.UseVisualStyleBackColor = false;
            this.btnConsultaFinanca.Click += new System.EventHandler(this.btnConsultaFinanca_Click);
            // 
            // linkLabelMenu
            // 
            this.linkLabelMenu.AutoSize = true;
            this.linkLabelMenu.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkLabelMenu.Location = new System.Drawing.Point(188, 130);
            this.linkLabelMenu.Name = "linkLabelMenu";
            this.linkLabelMenu.Size = new System.Drawing.Size(78, 13);
            this.linkLabelMenu.TabIndex = 3;
            this.linkLabelMenu.TabStop = true;
            this.linkLabelMenu.Text = "Voltar ao menu";
            this.linkLabelMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMenu_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridViewClienteConsulta);
            this.groupBox2.Controls.Add(this.linkLabelMenu);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(454, 471);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 158);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grade de pesquisa";
            // 
            // dataGridViewClienteConsulta
            // 
            this.dataGridViewClienteConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClienteConsulta.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewClienteConsulta.Location = new System.Drawing.Point(22, 19);
            this.dataGridViewClienteConsulta.Name = "dataGridViewClienteConsulta";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewClienteConsulta.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewClienteConsulta.Size = new System.Drawing.Size(401, 99);
            this.dataGridViewClienteConsulta.TabIndex = 1;
            this.dataGridViewClienteConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClienteConsulta_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1267, 24);
            this.menuStrip1.TabIndex = 25;
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(5)))), ((int)(((byte)(115)))));
            this.label2.Location = new System.Drawing.Point(443, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(497, 61);
            this.label2.TabIndex = 26;
            this.label2.Text = "Consultar Finanças";
            // 
            // FormConsultaFinancas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1267, 691);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnConsultaFinanca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeConsultaFin);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormConsultaFinancas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar finanças";
            this.Load += new System.EventHandler(this.FormConsultaFinancas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienteConsulta)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeConsultaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultaFinanca;
        private System.Windows.Forms.LinkLabel linkLabelMenu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewClienteConsulta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}