﻿namespace Dot.Net._6.WF.Calendario.Senac
{
    partial class AgendaCursos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendaCursos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lbl = new Label();
            txtId = new TextBox();
            dtpFim = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            cmbCurso = new ComboBox();
            txtMeta = new TextBox();
            txtSala = new TextBox();
            txtTurma = new TextBox();
            txtRealizado = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label4 = new Label();
            label1 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            exportarToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            limparToolStripMenuItem = new ToolStripMenuItem();
            deletarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarCursoToolStripMenuItem = new ToolStripMenuItem();
            cadastrarUsuárioToolStripMenuItem1 = new ToolStripMenuItem();
            controleToolStripMenuItem = new ToolStripMenuItem();
            acessoToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            txtPesquisar = new TextBox();
            cmbHorario = new ComboBox();
            clbDias = new CheckedListBox();
            mtbValor = new MaskedTextBox();
            btnSair = new Button();
            gridCurso = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            ColunaCurso = new DataGridViewTextBoxColumn();
            ColunaCursoInicio = new DataGridViewTextBoxColumn();
            ColunaCursoFim = new DataGridViewTextBoxColumn();
            ColunaCursoDias = new DataGridViewTextBoxColumn();
            ColunaCursoHorario = new DataGridViewTextBoxColumn();
            ColunaCursoMeta = new DataGridViewTextBoxColumn();
            ColunaCursoRealizado = new DataGridViewTextBoxColumn();
            ColunaCursoValor = new DataGridViewTextBoxColumn();
            ColunaCursoTurma = new DataGridViewTextBoxColumn();
            ColunaCursoSala = new DataGridViewTextBoxColumn();
            btnExportar = new Button();
            btnAdicionar = new Button();
            btnLimparCampos = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCurso).BeginInit();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.Location = new Point(267, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(26, 18);
            lbl.TabIndex = 35;
            lbl.Text = "ID:";
            lbl.Visible = false;
            // 
            // txtId
            // 
            txtId.Location = new Point(3, 3);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(150, 23);
            txtId.TabIndex = 34;
            txtId.Visible = false;
            // 
            // dtpFim
            // 
            dtpFim.CalendarMonthBackground = SystemColors.HighlightText;
            dtpFim.CustomFormat = "dd-MM-yyyy";
            dtpFim.Dock = DockStyle.Top;
            dtpFim.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFim.Format = DateTimePickerFormat.Custom;
            dtpFim.Location = new Point(562, 109);
            dtpFim.MaxDate = new DateTime(2999, 12, 31, 0, 0, 0, 0);
            dtpFim.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpFim.Name = "dtpFim";
            dtpFim.Size = new Size(286, 25);
            dtpFim.TabIndex = 3;
            dtpFim.Value = new DateTime(2024, 1, 8, 0, 0, 0, 0);
            // 
            // dtpInicio
            // 
            dtpInicio.CalendarMonthBackground = SystemColors.HighlightText;
            dtpInicio.CustomFormat = "dd-MM-yyyy";
            dtpInicio.Dock = DockStyle.Top;
            dtpInicio.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.Location = new Point(267, 109);
            dtpInicio.MaxDate = new DateTime(2999, 12, 31, 0, 0, 0, 0);
            dtpInicio.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(289, 25);
            dtpInicio.TabIndex = 2;
            dtpInicio.Value = new DateTime(2024, 1, 8, 0, 0, 0, 0);
            // 
            // cmbCurso
            // 
            cmbCurso.BackColor = SystemColors.HighlightText;
            cmbCurso.Dock = DockStyle.Fill;
            cmbCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCurso.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCurso.FormattingEnabled = true;
            cmbCurso.Items.AddRange(new object[] { "Tecnologia da Informação" });
            cmbCurso.Location = new Point(3, 109);
            cmbCurso.Name = "cmbCurso";
            cmbCurso.Size = new Size(258, 26);
            cmbCurso.TabIndex = 1;
            cmbCurso.KeyPress += TextOnly;
            // 
            // txtMeta
            // 
            txtMeta.BackColor = SystemColors.HighlightText;
            txtMeta.BorderStyle = BorderStyle.FixedSingle;
            txtMeta.Dock = DockStyle.Fill;
            txtMeta.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMeta.Location = new Point(3, 167);
            txtMeta.Name = "txtMeta";
            txtMeta.Size = new Size(258, 25);
            txtMeta.TabIndex = 6;
            txtMeta.KeyPress += NumbersOnly;
            // 
            // txtSala
            // 
            txtSala.BackColor = SystemColors.HighlightText;
            txtSala.BorderStyle = BorderStyle.FixedSingle;
            txtSala.Dock = DockStyle.Top;
            txtSala.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSala.Location = new Point(1137, 167);
            txtSala.Name = "txtSala";
            txtSala.Size = new Size(288, 25);
            txtSala.TabIndex = 10;
            // 
            // txtTurma
            // 
            txtTurma.BackColor = SystemColors.HighlightText;
            txtTurma.BorderStyle = BorderStyle.FixedSingle;
            txtTurma.Dock = DockStyle.Top;
            txtTurma.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTurma.Location = new Point(854, 167);
            txtTurma.Name = "txtTurma";
            txtTurma.Size = new Size(277, 25);
            txtTurma.TabIndex = 9;
            txtTurma.KeyPress += NumbersOnly;
            // 
            // txtRealizado
            // 
            txtRealizado.BackColor = SystemColors.HighlightText;
            txtRealizado.BorderStyle = BorderStyle.FixedSingle;
            txtRealizado.Dock = DockStyle.Top;
            txtRealizado.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtRealizado.Location = new Point(267, 167);
            txtRealizado.Name = "txtRealizado";
            txtRealizado.Size = new Size(289, 25);
            txtRealizado.TabIndex = 7;
            txtRealizado.KeyPress += NumbersOnly;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Top;
            label12.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(1135, 148);
            label12.Margin = new Padding(1, 8, 3, 0);
            label12.Name = "label12";
            label12.Size = new Size(290, 16);
            label12.TabIndex = 11;
            label12.Text = "Sala:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Top;
            label11.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(852, 148);
            label11.Margin = new Padding(1, 8, 3, 0);
            label11.Name = "label11";
            label11.Size = new Size(279, 16);
            label11.TabIndex = 10;
            label11.Text = "Turma:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Top;
            label10.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(1135, 91);
            label10.Margin = new Padding(1, 25, 3, 0);
            label10.Name = "label10";
            label10.Size = new Size(290, 15);
            label10.TabIndex = 9;
            label10.Text = "Horário:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Top;
            label9.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(560, 148);
            label9.Margin = new Padding(1, 8, 3, 0);
            label9.Name = "label9";
            label9.Size = new Size(288, 16);
            label9.TabIndex = 8;
            label9.Text = "Valor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(560, 91);
            label4.Margin = new Padding(1, 25, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(288, 15);
            label4.TabIndex = 21;
            label4.Text = "Fim:";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1, 91);
            label1.Margin = new Padding(1, 25, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(260, 15);
            label1.TabIndex = 0;
            label1.Text = "Curso:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(265, 148);
            label7.Margin = new Padding(1, 8, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(291, 16);
            label7.TabIndex = 6;
            label7.Text = "Matriculados:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1, 148);
            label6.Margin = new Padding(1, 8, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(260, 16);
            label6.TabIndex = 5;
            label6.Text = "Meta de Alunos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(265, 91);
            label3.Margin = new Padding(1, 25, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(291, 15);
            label3.TabIndex = 0;
            label3.Text = "Início:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(852, 91);
            label5.Margin = new Padding(1, 25, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(279, 15);
            label5.TabIndex = 4;
            label5.Text = "Dias:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem, cadastrarToolStripMenuItem, controleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1428, 24);
            menuStrip1.TabIndex = 29;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem, exportarToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(59, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.Image = (Image)resources.GetObject("adicionarToolStripMenuItem.Image");
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            adicionarToolStripMenuItem.Size = new Size(164, 22);
            adicionarToolStripMenuItem.Text = "Adicionar";
            adicionarToolStripMenuItem.Click += adicionarToolStripMenuItem_Click;
            // 
            // exportarToolStripMenuItem
            // 
            exportarToolStripMenuItem.Image = (Image)resources.GetObject("exportarToolStripMenuItem.Image");
            exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            exportarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            exportarToolStripMenuItem.Size = new Size(164, 22);
            exportarToolStripMenuItem.Text = "Exportar";
            exportarToolStripMenuItem.Click += exportarToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Image = (Image)resources.GetObject("sairToolStripMenuItem.Image");
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            sairToolStripMenuItem.Size = new Size(164, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { limparToolStripMenuItem, deletarToolStripMenuItem });
            editarToolStripMenuItem.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point);
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // limparToolStripMenuItem
            // 
            limparToolStripMenuItem.Image = (Image)resources.GetObject("limparToolStripMenuItem.Image");
            limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            limparToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            limparToolStripMenuItem.Size = new Size(184, 22);
            limparToolStripMenuItem.Text = "Limpar";
            limparToolStripMenuItem.Click += limparToolStripMenuItem_Click;
            // 
            // deletarToolStripMenuItem
            // 
            deletarToolStripMenuItem.Image = (Image)resources.GetObject("deletarToolStripMenuItem.Image");
            deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            deletarToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.Delete;
            deletarToolStripMenuItem.Size = new Size(184, 22);
            deletarToolStripMenuItem.Text = "Excluir";
            deletarToolStripMenuItem.Click += excluirToolStripMenuItem_Click;
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarCursoToolStripMenuItem, cadastrarUsuárioToolStripMenuItem1 });
            cadastrarToolStripMenuItem.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(65, 20);
            cadastrarToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastrarCursoToolStripMenuItem
            // 
            cadastrarCursoToolStripMenuItem.Image = (Image)resources.GetObject("cadastrarCursoToolStripMenuItem.Image");
            cadastrarCursoToolStripMenuItem.Name = "cadastrarCursoToolStripMenuItem";
            cadastrarCursoToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
            cadastrarCursoToolStripMenuItem.Size = new Size(204, 22);
            cadastrarCursoToolStripMenuItem.Text = "Cadastrar curso";
            cadastrarCursoToolStripMenuItem.Click += cadastrarCursoToolStripMenuItem_Click;
            // 
            // cadastrarUsuárioToolStripMenuItem1
            // 
            cadastrarUsuárioToolStripMenuItem1.Image = (Image)resources.GetObject("cadastrarUsuárioToolStripMenuItem1.Image");
            cadastrarUsuárioToolStripMenuItem1.Name = "cadastrarUsuárioToolStripMenuItem1";
            cadastrarUsuárioToolStripMenuItem1.ShortcutKeys = Keys.Alt | Keys.E;
            cadastrarUsuárioToolStripMenuItem1.Size = new Size(204, 22);
            cadastrarUsuárioToolStripMenuItem1.Text = "Cadastrar usuário";
            cadastrarUsuárioToolStripMenuItem1.Click += cadastrarUsuárioToolStripMenuItem1_Click;
            // 
            // controleToolStripMenuItem
            // 
            controleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acessoToolStripMenuItem });
            controleToolStripMenuItem.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point);
            controleToolStripMenuItem.Name = "controleToolStripMenuItem";
            controleToolStripMenuItem.Size = new Size(64, 20);
            controleToolStripMenuItem.Text = "Controle";
            // 
            // acessoToolStripMenuItem
            // 
            acessoToolStripMenuItem.Image = (Image)resources.GetObject("acessoToolStripMenuItem.Image");
            acessoToolStripMenuItem.Name = "acessoToolStripMenuItem";
            acessoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            acessoToolStripMenuItem.Size = new Size(156, 22);
            acessoToolStripMenuItem.Text = "Acesso";
            acessoToolStripMenuItem.Click += acessoToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(gridCurso);
            panel1.Controls.Add(btnExportar);
            panel1.Controls.Add(btnAdicionar);
            panel1.Controls.Add(menuStrip1);
            panel1.Controls.Add(btnLimparCampos);
            panel1.Controls.Add(btnAlterar);
            panel1.Controls.Add(btnExcluir);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(1680, 1050);
            panel1.MinimumSize = new Size(900, 600);
            panel1.Name = "panel1";
            panel1.Size = new Size(1430, 642);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.1669235F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.8330765F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 292F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 283F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 293F));
            tableLayoutPanel1.Controls.Add(txtMeta, 0, 5);
            tableLayoutPanel1.Controls.Add(label12, 4, 4);
            tableLayoutPanel1.Controls.Add(label2, 4, 0);
            tableLayoutPanel1.Controls.Add(txtSala, 4, 5);
            tableLayoutPanel1.Controls.Add(txtPesquisar, 4, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(cmbCurso, 0, 3);
            tableLayoutPanel1.Controls.Add(lbl, 1, 0);
            tableLayoutPanel1.Controls.Add(cmbHorario, 4, 3);
            tableLayoutPanel1.Controls.Add(txtId, 0, 0);
            tableLayoutPanel1.Controls.Add(label11, 3, 4);
            tableLayoutPanel1.Controls.Add(clbDias, 3, 3);
            tableLayoutPanel1.Controls.Add(txtTurma, 3, 5);
            tableLayoutPanel1.Controls.Add(txtRealizado, 1, 5);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(label9, 2, 4);
            tableLayoutPanel1.Controls.Add(mtbValor, 2, 5);
            tableLayoutPanel1.Controls.Add(label7, 1, 4);
            tableLayoutPanel1.Controls.Add(dtpInicio, 1, 3);
            tableLayoutPanel1.Controls.Add(label3, 1, 2);
            tableLayoutPanel1.Controls.Add(dtpFim, 2, 3);
            tableLayoutPanel1.Controls.Add(label4, 2, 2);
            tableLayoutPanel1.Controls.Add(label5, 3, 2);
            tableLayoutPanel1.Controls.Add(label10, 4, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.Size = new Size(1428, 192);
            tableLayoutPanel1.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1134, 10);
            label2.Margin = new Padding(0, 10, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(291, 18);
            label2.TabIndex = 37;
            label2.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            txtPesquisar.BackColor = SystemColors.HighlightText;
            txtPesquisar.BorderStyle = BorderStyle.FixedSingle;
            txtPesquisar.Dock = DockStyle.Top;
            txtPesquisar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPesquisar.Location = new Point(1137, 32);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(288, 25);
            txtPesquisar.TabIndex = 36;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged_1;
            txtPesquisar.KeyPress += txtPesquisar_KeyPress_1;
            // 
            // cmbHorario
            // 
            cmbHorario.BackColor = SystemColors.HighlightText;
            cmbHorario.Dock = DockStyle.Top;
            cmbHorario.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbHorario.FormattingEnabled = true;
            cmbHorario.Items.AddRange(new object[] { "7:30 às 12:00", "8:00 às 12:00", "9:15 às 12:15", "13:30 às 17:30", "14:00 às 17:00", "14:00 às 17:30", "18:00 às 22:30", "19:00 às 22:30" });
            cmbHorario.Location = new Point(1137, 109);
            cmbHorario.Name = "cmbHorario";
            cmbHorario.Size = new Size(288, 26);
            cmbHorario.TabIndex = 5;
            // 
            // clbDias
            // 
            clbDias.Dock = DockStyle.Top;
            clbDias.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            clbDias.FormattingEnabled = true;
            clbDias.Location = new Point(854, 108);
            clbDias.Margin = new Padding(3, 2, 3, 2);
            clbDias.Name = "clbDias";
            clbDias.Size = new Size(277, 24);
            clbDias.TabIndex = 1;
            // 
            // mtbValor
            // 
            mtbValor.Dock = DockStyle.Top;
            mtbValor.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            mtbValor.Location = new Point(562, 167);
            mtbValor.Mask = "$00,000,00";
            mtbValor.Name = "mtbValor";
            mtbValor.Size = new Size(286, 25);
            mtbValor.TabIndex = 8;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom;
            btnSair.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.Location = new Point(1082, 580);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(96, 30);
            btnSair.TabIndex = 38;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // gridCurso
            // 
            gridCurso.AllowUserToAddRows = false;
            gridCurso.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gridCurso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridCurso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridCurso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCurso.BackgroundColor = Color.LightGray;
            gridCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCurso.Columns.AddRange(new DataGridViewColumn[] { Column1, ColunaCurso, ColunaCursoInicio, ColunaCursoFim, ColunaCursoDias, ColunaCursoHorario, ColunaCursoMeta, ColunaCursoRealizado, ColunaCursoValor, ColunaCursoTurma, ColunaCursoSala });
            gridCurso.Location = new Point(-1, 217);
            gridCurso.MaximumSize = new Size(1920, 900);
            gridCurso.Name = "gridCurso";
            gridCurso.ReadOnly = true;
            gridCurso.RowHeadersWidth = 51;
            gridCurso.RowTemplate.Height = 25;
            gridCurso.Size = new Size(1429, 315);
            gridCurso.TabIndex = 17;
            gridCurso.CellClick += gridCurso_CellClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "#";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 39;
            // 
            // ColunaCurso
            // 
            ColunaCurso.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColunaCurso.HeaderText = "Curso";
            ColunaCurso.MinimumWidth = 6;
            ColunaCurso.Name = "ColunaCurso";
            ColunaCurso.ReadOnly = true;
            ColunaCurso.Width = 63;
            // 
            // ColunaCursoInicio
            // 
            ColunaCursoInicio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            ColunaCursoInicio.DefaultCellStyle = dataGridViewCellStyle2;
            ColunaCursoInicio.HeaderText = "Início";
            ColunaCursoInicio.MinimumWidth = 6;
            ColunaCursoInicio.Name = "ColunaCursoInicio";
            ColunaCursoInicio.ReadOnly = true;
            // 
            // ColunaCursoFim
            // 
            ColunaCursoFim.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            ColunaCursoFim.DefaultCellStyle = dataGridViewCellStyle3;
            ColunaCursoFim.HeaderText = "Fim";
            ColunaCursoFim.MinimumWidth = 6;
            ColunaCursoFim.Name = "ColunaCursoFim";
            ColunaCursoFim.ReadOnly = true;
            // 
            // ColunaCursoDias
            // 
            ColunaCursoDias.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoDias.HeaderText = "Dias";
            ColunaCursoDias.MinimumWidth = 6;
            ColunaCursoDias.Name = "ColunaCursoDias";
            ColunaCursoDias.ReadOnly = true;
            // 
            // ColunaCursoHorario
            // 
            ColunaCursoHorario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoHorario.HeaderText = "Horário";
            ColunaCursoHorario.MinimumWidth = 6;
            ColunaCursoHorario.Name = "ColunaCursoHorario";
            ColunaCursoHorario.ReadOnly = true;
            // 
            // ColunaCursoMeta
            // 
            ColunaCursoMeta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoMeta.HeaderText = "Meta de Alunos";
            ColunaCursoMeta.MinimumWidth = 6;
            ColunaCursoMeta.Name = "ColunaCursoMeta";
            ColunaCursoMeta.ReadOnly = true;
            // 
            // ColunaCursoRealizado
            // 
            ColunaCursoRealizado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoRealizado.HeaderText = "Matriculados";
            ColunaCursoRealizado.MinimumWidth = 6;
            ColunaCursoRealizado.Name = "ColunaCursoRealizado";
            ColunaCursoRealizado.ReadOnly = true;
            // 
            // ColunaCursoValor
            // 
            ColunaCursoValor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoValor.HeaderText = "Valor";
            ColunaCursoValor.MinimumWidth = 6;
            ColunaCursoValor.Name = "ColunaCursoValor";
            ColunaCursoValor.ReadOnly = true;
            // 
            // ColunaCursoTurma
            // 
            ColunaCursoTurma.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoTurma.HeaderText = "Turma";
            ColunaCursoTurma.MinimumWidth = 6;
            ColunaCursoTurma.Name = "ColunaCursoTurma";
            ColunaCursoTurma.ReadOnly = true;
            // 
            // ColunaCursoSala
            // 
            ColunaCursoSala.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoSala.HeaderText = "Sala";
            ColunaCursoSala.MinimumWidth = 6;
            ColunaCursoSala.Name = "ColunaCursoSala";
            ColunaCursoSala.ReadOnly = true;
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Bottom;
            btnExportar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportar.Location = new Point(914, 580);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(96, 30);
            btnExportar.TabIndex = 15;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Bottom;
            btnAdicionar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionar.Location = new Point(250, 580);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(96, 30);
            btnAdicionar.TabIndex = 11;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click_1;
            // 
            // btnLimparCampos
            // 
            btnLimparCampos.Anchor = AnchorStyles.Bottom;
            btnLimparCampos.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimparCampos.Location = new Point(416, 580);
            btnLimparCampos.Name = "btnLimparCampos";
            btnLimparCampos.Size = new Size(96, 30);
            btnLimparCampos.TabIndex = 12;
            btnLimparCampos.Text = "Limpar";
            btnLimparCampos.UseVisualStyleBackColor = true;
            btnLimparCampos.Click += btnLimparCampos_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Anchor = AnchorStyles.Bottom;
            btnAlterar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterar.Location = new Point(746, 580);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(96, 30);
            btnAlterar.TabIndex = 14;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom;
            btnExcluir.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.Location = new Point(577, 580);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(96, 30);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click_1;
            // 
            // AgendaCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1430, 642);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1682, 1043);
            MinimumSize = new Size(900, 592);
            Name = "AgendaCursos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AGENDA DE CURSOS";
            FormClosing += Agenda_de_Curso_FormClosing;
            Load += Agenda_de_Curso_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridCurso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtMeta;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox txtSala;
        private TextBox txtTurma;
        private TextBox txtRealizado;
        private TextBox textBox1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label4;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label5;
        private ComboBox cmbCurso;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem limparToolStripMenuItem;
        private ToolStripMenuItem deletarToolStripMenuItem;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFim;
        private Label lbl;
        private TextBox txtId;
        private ToolStripMenuItem exportarToolStripMenuItem;
        private Panel panel1;
        private Button btnExportar;
        private Button btnAdicionar;
        private Button btnLimparCampos;
        private Button btnAlterar;
        private Button btnExcluir;
        private MaskedTextBox mtbValor;
        private DataGridView gridCurso;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem cadastrarCursoToolStripMenuItem;
        private ToolStripMenuItem cadastrarUsuárioToolStripMenuItem1;
        private ComboBox cmbHorario;
        private ToolStripMenuItem controleToolStripMenuItem;
        private ToolStripMenuItem acessoToolStripMenuItem;
        private Label label2;
        private TextBox txtPesquisar;
        private CheckedListBox clbDias;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ColunaCurso;
        private DataGridViewTextBoxColumn ColunaCursoInicio;
        private DataGridViewTextBoxColumn ColunaCursoFim;
        private DataGridViewTextBoxColumn ColunaCursoDias;
        private DataGridViewTextBoxColumn ColunaCursoHorario;
        private DataGridViewTextBoxColumn ColunaCursoMeta;
        private DataGridViewTextBoxColumn ColunaCursoRealizado;
        private DataGridViewTextBoxColumn ColunaCursoValor;
        private DataGridViewTextBoxColumn ColunaCursoTurma;
        private DataGridViewTextBoxColumn ColunaCursoSala;
        private Button btnSair;
        private TableLayoutPanel tableLayoutPanel1;
    }
}