﻿namespace Dot.Net._6.WF.Calendario.Senac
{
    partial class CadastroUsuario
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSenha = new TextBox();
            txtCpf = new TextBox();
            txtUsuario = new TextBox();
            txtId = new TextBox();
            chkAtivo = new CheckBox();
            chkAdministrador = new CheckBox();
            btnAdicionarUsuario = new Button();
            btnAlterar = new Button();
            GridConsultarUsuario = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btnExcluir = new Button();
            panel1 = new Panel();
            btnVoltaAgenda = new Button();
            dtpDataNascimento = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)GridConsultarUsuario).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(91, 29);
            label1.Name = "label1";
            label1.Size = new Size(33, 22);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(124, 74);
            label2.Name = "label2";
            label2.Size = new Size(75, 22);
            label2.TabIndex = 1;
            label2.Text = "Usuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(469, 72);
            label3.Name = "label3";
            label3.Size = new Size(45, 22);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(123, 138);
            label4.Name = "label4";
            label4.Size = new Size(177, 22);
            label4.TabIndex = 3;
            label4.Text = "Data de Nascimento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(469, 139);
            label5.Name = "label5";
            label5.Size = new Size(63, 22);
            label5.TabIndex = 4;
            label5.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.HighlightText;
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtSenha.Location = new Point(469, 161);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '•';
            txtSenha.Size = new Size(265, 29);
            txtSenha.TabIndex = 3;
            txtSenha.KeyPress += txtSenha_KeyPress;
            // 
            // txtCpf
            // 
            txtCpf.BackColor = SystemColors.HighlightText;
            txtCpf.BorderStyle = BorderStyle.FixedSingle;
            txtCpf.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtCpf.Location = new Point(469, 95);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(265, 29);
            txtCpf.TabIndex = 1;
            txtCpf.TextChanged += txtCpf_TextChanged;
            txtCpf.KeyDown += txtCpf_KeyDown;
            txtCpf.KeyPress += txtCpf_KeyPress;
            txtCpf.Leave += txtCpf_Leave;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.HighlightText;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.Location = new Point(125, 95);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(265, 29);
            txtUsuario.TabIndex = 0;
            txtUsuario.KeyPress += TextOnly;
            // 
            // txtId
            // 
            txtId.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtId.Location = new Point(129, 25);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(67, 29);
            txtId.TabIndex = 7;
            txtId.TextAlign = HorizontalAlignment.Center;
            txtId.Visible = false;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            chkAtivo.Location = new Point(125, 201);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(75, 26);
            chkAtivo.TabIndex = 5;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // chkAdministrador
            // 
            chkAdministrador.AutoSize = true;
            chkAdministrador.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            chkAdministrador.Location = new Point(223, 201);
            chkAdministrador.Name = "chkAdministrador";
            chkAdministrador.Size = new Size(149, 26);
            chkAdministrador.TabIndex = 4;
            chkAdministrador.Text = "Administrador";
            chkAdministrador.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarUsuario
            // 
            btnAdicionarUsuario.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionarUsuario.Location = new Point(123, 594);
            btnAdicionarUsuario.Name = "btnAdicionarUsuario";
            btnAdicionarUsuario.Size = new Size(110, 40);
            btnAdicionarUsuario.TabIndex = 6;
            btnAdicionarUsuario.Text = "Adicionar";
            btnAdicionarUsuario.UseVisualStyleBackColor = true;
            btnAdicionarUsuario.Click += btnSalvarUsuario_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterar.Location = new Point(298, 594);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(110, 40);
            btnAlterar.TabIndex = 10;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // GridConsultarUsuario
            // 
            GridConsultarUsuario.AllowUserToAddRows = false;
            GridConsultarUsuario.AllowUserToDeleteRows = false;
            GridConsultarUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridConsultarUsuario.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column7, Column6 });
            GridConsultarUsuario.GridColor = SystemColors.ActiveCaption;
            GridConsultarUsuario.Location = new Point(1, 236);
            GridConsultarUsuario.Name = "GridConsultarUsuario";
            GridConsultarUsuario.ReadOnly = true;
            GridConsultarUsuario.RowHeadersWidth = 51;
            GridConsultarUsuario.RowTemplate.Height = 29;
            GridConsultarUsuario.ShowCellToolTips = false;
            GridConsultarUsuario.Size = new Size(893, 300);
            GridConsultarUsuario.StandardTab = true;
            GridConsultarUsuario.TabIndex = 8;
            GridConsultarUsuario.CellClick += GridConsultarUsuario_CellClick;
            GridConsultarUsuario.CellFormatting += GridConsultarUsuario_CellFormatting;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "#";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 47;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Usuário";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "CPF";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            Column4.DefaultCellStyle = dataGridViewCellStyle1;
            Column4.HeaderText = "Data de Nascimento";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Senha";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.HeaderText = "Ativo";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Administrador";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.Location = new Point(485, 594);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 40);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.Controls.Add(btnVoltaAgenda);
            panel1.Controls.Add(dtpDataNascimento);
            panel1.Controls.Add(GridConsultarUsuario);
            panel1.Controls.Add(txtCpf);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(chkAdministrador);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(chkAtivo);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(btnAdicionarUsuario);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(btnAlterar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-2, -3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.MaximumSize = new Size(2194, 1439);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 696);
            panel1.TabIndex = 13;
            // 
            // btnVoltaAgenda
            // 
            btnVoltaAgenda.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltaAgenda.Location = new Point(667, 594);
            btnVoltaAgenda.Name = "btnVoltaAgenda";
            btnVoltaAgenda.Size = new Size(110, 40);
            btnVoltaAgenda.TabIndex = 16;
            btnVoltaAgenda.Text = "Sair";
            btnVoltaAgenda.UseVisualStyleBackColor = true;
            btnVoltaAgenda.Click += btnVoltaAgenda_Click;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = DateTimePickerFormat.Custom;
            dtpDataNascimento.Location = new Point(125, 161);
            dtpDataNascimento.Margin = new Padding(3, 4, 3, 4);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(265, 27);
            dtpDataNascimento.TabIndex = 15;
            dtpDataNascimento.Value = new DateTime(2024, 1, 13, 0, 0, 0, 0);
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(894, 695);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CadastroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CADASTRO DE USUÁRIO";
            FormClosing += CadastroUsuario_FormClosing;
            Load += FrmCadastroUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)GridConsultarUsuario).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;

        private TextBox txtSenha;
        private TextBox txtCpf;
        private TextBox txtUsuario;
        private TextBox txtId;
        private CheckBox chkAtivo;
        private CheckBox chkAdministrador;
        private Button btnAdicionarUsuario;
        private Button btnAlterar;
        private DataGridView GridConsultarUsuario;
        private Button btnExcluir;
        private Panel panel1;
        private DateTimePicker dtpDataNascimento;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column6;
        private Button btnVoltaAgenda;
    }
}