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
            groupBox1 = new GroupBox();
            picSenha = new PictureBox();
            pictureBox3 = new PictureBox();
            btnCancelar = new Button();
            btnEntrar = new Button();
            picLoading = new PictureBox();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLoading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(picSenha);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnEntrar);
            groupBox1.Controls.Add(picLoading);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(-4, -10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(774, 475);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // picSenha
            // 
            picSenha.BackColor = SystemColors.ButtonHighlight;
            picSenha.Cursor = Cursors.Hand;
            picSenha.Image = Properties.Resources.hide;
            picSenha.Location = new Point(255, 311);
            picSenha.Name = "picSenha";
            picSenha.Size = new Size(34, 37);
            picSenha.SizeMode = PictureBoxSizeMode.CenterImage;
            picSenha.TabIndex = 24;
            picSenha.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(262, 257);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ButtonHighlight;
            btnCancelar.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(289, 354);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(74, 27);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.ButtonHighlight;
            btnEntrar.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntrar.Location = new Point(398, 354);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(71, 27);
            btnEntrar.TabIndex = 21;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // picLoading
            // 
            picLoading.BackColor = Color.White;
            picLoading.Image = (Image)resources.GetObject("picLoading.Image");
            picLoading.Location = new Point(255, 354);
            picLoading.Name = "picLoading";
            picLoading.Size = new Size(254, 105);
            picLoading.SizeMode = PictureBoxSizeMode.Zoom;
            picLoading.TabIndex = 20;
            picLoading.TabStop = false;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(289, 313);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '•';
            txtSenha.Size = new Size(180, 33);
            txtSenha.TabIndex = 1;
            txtSenha.KeyPress += txtSenha_KeyPress;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(289, 257);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(180, 31);
            txtUsuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Historic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(289, 237);
            label1.Name = "label1";
            label1.Size = new Size(56, 19);
            label1.TabIndex = 17;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Historic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(289, 291);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 18;
            label2.Text = "Senha";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(-9, -46);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(805, 562);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 461);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "TelaLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Senac ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLoading).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox picLoading;
        private Button btnCancelar;
        private Button btnEntrar;
        private PictureBox pictureBox3;
        private PictureBox picSenha;
    }
}