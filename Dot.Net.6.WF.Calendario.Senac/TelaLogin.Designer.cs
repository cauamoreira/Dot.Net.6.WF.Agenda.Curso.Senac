﻿namespace Dot.Net._6.WF.Calendario.Senac
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            panel1 = new Panel();
            picLoading = new PictureBox();
            label3 = new Label();
            txtSenha = new TextBox();
            picSenha = new PictureBox();
            txtUsuario = new TextBox();
            btnEntrar = new Button();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLoading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(picLoading);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(picSenha);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(772, 469);
            panel1.TabIndex = 26;
            // 
            // picLoading
            // 
            picLoading.BackColor = Color.White;
            picLoading.Image = (Image)resources.GetObject("picLoading.Image");
            picLoading.Location = new Point(334, 405);
            picLoading.Margin = new Padding(3, 4, 3, 4);
            picLoading.Name = "picLoading";
            picLoading.Size = new Size(76, 58);
            picLoading.SizeMode = PictureBoxSizeMode.Zoom;
            picLoading.TabIndex = 31;
            picLoading.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Microsoft PhagsPa", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(300, 323);
            label3.Name = "label3";
            label3.Size = new Size(154, 22);
            label3.TabIndex = 36;
            label3.Text = "Esqueceu a senha?";
            label3.Click += label3_Click;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.HighlightText;
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Location = new Point(263, 292);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '•';
            txtSenha.Size = new Size(253, 27);
            txtSenha.TabIndex = 28;
            txtSenha.KeyPress += txtSenha_KeyPress;
            // 
            // picSenha
            // 
            picSenha.BackColor = SystemColors.ButtonHighlight;
            picSenha.Cursor = Cursors.Hand;
            picSenha.Image = Properties.Resources.visualizar;
            picSenha.Location = new Point(229, 291);
            picSenha.Margin = new Padding(3, 4, 3, 4);
            picSenha.Name = "picSenha";
            picSenha.Size = new Size(34, 27);
            picSenha.SizeMode = PictureBoxSizeMode.Zoom;
            picSenha.TabIndex = 35;
            picSenha.TabStop = false;
            picSenha.Click += picSenha_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.HighlightText;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Location = new Point(263, 240);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(253, 27);
            txtUsuario.TabIndex = 27;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.ButtonHighlight;
            btnEntrar.Font = new Font("Microsoft PhagsPa", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrar.ForeColor = SystemColors.Desktop;
            btnEntrar.Location = new Point(321, 361);
            btnEntrar.Margin = new Padding(3, 4, 3, 4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(110, 40);
            btnEntrar.TabIndex = 32;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Image = Properties.Resources.do_utilizador;
            pictureBox3.Location = new Point(231, 239);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 34;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft PhagsPa", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(260, 220);
            label1.Name = "label1";
            label1.Size = new Size(75, 22);
            label1.TabIndex = 29;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft PhagsPa", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(263, 271);
            label2.Name = "label2";
            label2.Size = new Size(63, 22);
            label2.TabIndex = 30;
            label2.Text = "Senha:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(770, 467);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 469);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "TelaLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SENAC";
            FormClosing += TelaLogin_FormClosing;
            KeyDown += TelaLogin_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLoading).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox picLoading;
        private Label label3;
        private TextBox txtSenha;
        private PictureBox picSenha;
        private TextBox txtUsuario;
        private Button btnEntrar;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
    }
}