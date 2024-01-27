using Microsoft.VisualBasic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using ClosedXML.Excel;
using OfficeOpenXml;
using System.IO.Pipes;
using System.IO.Pipelines;
using DocumentFormat.OpenXml.Vml;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Dot.Net._6.WF.Calendario.Senac.Migrations;
using System.Globalization;
using System.Collections.ObjectModel;


namespace Dot.Net._6.WF.Calendario.Senac
{

    public partial class Agenda_de_Curso : Form
    {
        private List<string> diasSelecionados = new List<string>();

        public Agenda_de_Curso()
        {
            InitializeComponent();

            clbDias.Items.AddRange(new object[]
        {
            "Segunda-feira",
            "Ter�a-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira",
            "S�bado"
        });
            clbDias.CheckOnClick = true;
        }

        private void iAdicionar()
        {
         
            if (CamposObrigatorios())
                return;

            var nome = cmbCurso.Text;
            var inicio = dtpInicio.Value;
            var fim = dtpFim.Value;
            var meta = txtMeta.Text;
            var horario = cmbHorario.Text;
            var realizado = txtRealizado.Text;
            var valor = mtbValor.Text;
            var turma = txtTurma.Text;
            var sala = txtSala.Text;

            using (var bd = new BancoDeDados())
            {
                if (CursoExistente(bd, turma, sala, horario, inicio))
                    return;

                diasSelecionados = clbDias.CheckedItems.OfType<string>().ToList();

                var curso = new AgendaCurso()
                {
                    Nome = cmbCurso.Text,
                    Inicio = dtpInicio.Value.Date,
                    Fim = dtpFim.Value.Date,
                    Dias = string.Join(", ", diasSelecionados),
                    Horario = cmbHorario.Text,
                    Meta = txtMeta.Text,
                    Realizado = txtRealizado.Text,
                    Valor = mtbValor.Text,
                    Turma = txtTurma.Text,
                    Sala = txtSala.Text,
                };

                AdicionarHistorico(bd, nome);
                AdicionarCurso(bd, curso);
               
                LimparCheckBoxes(); 

                MessageBox.Show("Curso adicionado com sucesso.",
                    "Agenda de Cursos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtPesquisar.Text = "";
                Listar();
                LimparCampos();
            }

        }

       
        private void AdicionarHistorico(BancoDeDados bd, string nome)
        {
            bd.Historicos.Add(new Historico
            {
                Login = Autenticacao.UsuarioAtual?.Login,
                DataHora = DateTime.Now,
                Alteracao = "Adi��o de Curso",
                Detalhes = $"Adicionado curso: {nome}"
            });
        }
      

        private void LimparCheckBoxes()
        {
           
            foreach (int index in clbDias.CheckedIndices)
            {
                clbDias.SetItemChecked(index, false);
            }
        }

        private bool CamposObrigatorios()
        {
            if (string.IsNullOrEmpty(cmbCurso.Text)
                || dtpInicio.Value == DateTime.MinValue
                || dtpFim.Value == DateTime.MinValue
                || dtpFim.Value.Date < dtpInicio.Value.Date
                || !clbDias.CheckedItems.OfType<object>().Any()
                || string.IsNullOrEmpty(cmbHorario.Text)
                || string.IsNullOrEmpty(txtMeta.Text)
                || string.IsNullOrEmpty(txtRealizado.Text)
                || string.IsNullOrWhiteSpace(mtbValor.Text)
                || string.IsNullOrEmpty(txtTurma.Text)
                || string.IsNullOrEmpty(txtSala.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigat�rios.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        private bool CursoExistente(BancoDeDados bd, string turma, string sala, string horario, DateTime inicio)
        {
            var cursoExistente = bd.AgendaCursos
                .Any(c =>
                    c.Turma == turma &&
                    c.Sala == sala &&
                    c.Horario == horario &&
                    c.Inicio.Date == inicio.Date);

            if (cursoExistente)
            {
                MessageBox.Show("J� existe um curso na mesma turma, sala ou hor�rio. N�o � poss�vel adicionar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void AdicionarCurso(BancoDeDados bd, AgendaCurso curso)
        {
            bd.AgendaCursos.Add(curso);
            bd.SaveChanges();
        }


        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            iAdicionar();

        }

        private void Listar()
        {
            gridCurso.Rows.Clear();

            using (var bd = new BancoDeDados())
            {
                var cursos = bd.AgendaCursos.ToList();


                foreach (var curso in cursos)
                {
                    gridCurso.Rows.Add(
                        curso.Id,
                        curso.Nome,
                        curso.Inicio,
                        curso.Fim,
                        curso.Dias,
                        curso.Horario,
                        curso.Meta,
                        curso.Realizado,
                        curso.Valor,
                        curso.Turma,
                        curso.Sala);
                }
            }
        }


        private void LimparCampos()
        {
            txtId.Text = String.Empty;
            cmbCurso.Text = String.Empty; cmbCurso.SelectedIndex = -1;
            dtpInicio.Text = String.Empty;
            dtpFim.Text = String.Empty;
            clbDias.Text = String.Empty;
            cmbHorario.Text = String.Empty;
            txtMeta.Text = String.Empty;
            txtRealizado.Text = String.Empty;
            mtbValor.Text = String.Empty;
            txtTurma.Text = String.Empty;
            txtSala.Text = String.Empty;

            LimparCheckBoxes();

        }

        private void iExcluir()
        {
            if (!Autenticacao.UsuarioTemPermissaoAdministrador())
            {
                MessageBox.Show("Voc� n�o tem permiss�o para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Informe o curso antes de tentar excluir.");
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Deseja realmente excluir?", "Confirma��o", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    using (var bd = new BancoDeDados())
                    {
                        try
                        {
                            var curso = bd.AgendaCursos.FirstOrDefault(w => w.Id == Convert.ToInt32(txtId.Text));

                            if (curso != null)
                            {
                                AdicionarHistoricoExclusao(bd, curso);

                                bd.AgendaCursos.Remove(curso);
                                bd.SaveChanges();
                                Listar();
                                LimparCampos();
                            }
                            else
                            {
                                MessageBox.Show("Curso n�o encontrado. Verifique o curso informado.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao excluir: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void AdicionarHistoricoExclusao(BancoDeDados bd, AgendaCurso curso)
        {
            bd.Historicos.Add(new Historico
            {
                Login = Autenticacao.UsuarioAtual?.Login,
                DataHora = DateTime.Now,
                Alteracao = "Exclus�o de Curso",
                Detalhes = $"Exclu�do do curso: {curso.Id}, Nome: {curso.Nome}, In�cio: {curso.Inicio}, Fim: {curso.Fim}"

            });
        }
        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            iExcluir();

        }

        private void Agenda_de_Curso_Load(object sender, EventArgs e)
        {
            CarregarCombos();
            Listar();
        }

        public void CarregarCombos()
        {
            using (var bd = new BancoDeDados())
            {
                var cursos = bd.Cursos.ToList();

                cmbCurso.DataSource = cursos;
                cmbCurso.DisplayMember = "Nome";
                cmbCurso.ValueMember = "Id";
                cmbCurso.SelectedIndex = -1;


            }
        }

        private void iAlterar()
        {
            if (!Autenticacao.UsuarioTemPermissaoAdministrador())
            {
                MessageBox.Show("Voc� n�o tem permiss�o para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var bd = new BancoDeDados())
            {
                var curso = bd.AgendaCursos
                    .Where(w => w.Id == Convert.ToInt32(txtId.Text))
                    .FirstOrDefault();

                if (curso != null)
                {
                    if (dtpFim.Value.Date < dtpInicio.Value.Date)
                    {
                        MessageBox.Show("A 'Data de Fim' deve ser posterior ao dia de In�cio.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string nomeOriginal = curso.Nome;
                    DateTime inicioOriginal = curso.Inicio;
                    DateTime fimOriginal = curso.Fim;
                    string diasOriginal = curso.Dias;
                    string horarioOriginal = curso.Horario;
                    string metaOriginal = curso.Meta;
                    string realizadoOriginal = curso.Realizado;
                    string valorOriginal = curso.Valor;
                    string turmaOriginal = curso.Turma;
                    string salaOriginal = curso.Sala;

                    curso.Nome = cmbCurso.Text;
                    curso.Inicio = dtpInicio.Value.Date;
                    curso.Fim = dtpFim.Value.Date;

                    var diasSelecionados = clbDias.CheckedItems.OfType<string>().ToList();
                    curso.Dias = string.Join(", ", diasSelecionados);

                    
                    curso.Horario = cmbHorario.Text;
                    curso.Meta = txtMeta.Text;
                    curso.Realizado = txtRealizado.Text;
                    curso.Valor = Convert.ToString(mtbValor.Text);
                    curso.Turma = txtTurma.Text;
                    curso.Sala = txtSala.Text;

                   

                    var mesmoHorario = bd.AgendaCursos
                        .Any(c =>
                            c.Id != curso.Id &&
                            c.Turma == curso.Turma &&
                            c.Sala == curso.Sala &&
                            c.Horario == curso.Horario &&
                            c.Inicio.Date == curso.Inicio.Date);
                  
                   

                    if (mesmoHorario)
                    {
                        MessageBox.Show("J� existe um curso na mesma turma e sala nos hor�rios espec�ficos. N�o � poss�vel alterar.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        curso.Nome = nomeOriginal;
                        curso.Inicio = inicioOriginal;
                        curso.Fim = fimOriginal;
                        curso.Dias = diasOriginal;
                        curso.Horario = horarioOriginal;
                        curso.Meta = metaOriginal;
                        curso.Realizado = realizadoOriginal;
                        curso.Valor = valorOriginal;
                        curso.Turma = turmaOriginal;
                        curso.Sala = salaOriginal;

                        return;
                    }


                    AdicionarHistorico(bd, nomeOriginal, curso.Nome, "Nome do Curso");
                    AdicionarHistorico(bd, inicioOriginal.ToString(), curso.Inicio.ToString(), "Data de In�cio");
                    AdicionarHistorico(bd, fimOriginal.ToString(), curso.Fim.ToString(), "Data de Fim");
                    AdicionarHistorico(bd, diasOriginal.ToString(), curso.Dias.ToString(), "Dias");
                    AdicionarHistorico(bd, horarioOriginal, curso.Horario, "Hor�rio");
                    AdicionarHistorico(bd, metaOriginal, curso.Meta, "Meta de Alunos");
                    AdicionarHistorico(bd, realizadoOriginal, curso.Realizado, "Matriculados");
                    AdicionarHistorico(bd, valorOriginal, curso.Valor, "Valor");
                    AdicionarHistorico(bd, turmaOriginal, curso.Turma, "Turma");
                    AdicionarHistorico(bd, salaOriginal, curso.Sala, "Sala");

                    
                    DialogResult resultado = MessageBox.Show("Deseja realmente alterar?", "Agenda de Cursos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        bd.SaveChanges();
                        Listar();
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Altera��o cancelada pelo usu�rio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void AdicionarHistorico(BancoDeDados bd, string valorAntigo, string valorNovo, string nomeCampo)
        {
            if (valorAntigo != valorNovo)
            {
                bd.Historicos.Add(new Historico
                {
                    Login = Autenticacao.UsuarioAtual?.Login,
                    DataHora = DateTime.Now,
                    Alteracao = $"Altera��o de {nomeCampo}",
                    Detalhes = $"Valor antigo: {valorAntigo}, Novo valor: {valorNovo}"
                });
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            iAlterar();
        }

        private void NumbersOnly(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }

            else
            {

                if (e.KeyChar >= '0' && e.KeyChar <= '9')
                {

                    e.Handled = false;

                }

                else
                {

                    MessageBox.Show("Digite apenas n�meros", "Erro: Apenas n�meros", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    e.Handled = true;
                }
            }


        }
        private void LogOut()
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }
       

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iAdicionar();
        }


        private void Sair()
        {
            DialogResult iSair = MessageBox.Show("Deseja fechar o programa?",
                                                   "Agenda de Cursos",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

            if (iSair == DialogResult.Yes)
            {                           

                LogOut();
                this.Hide();
            }
        }
    
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sair();
               
        }
    


        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void iExportar()
        {
            using (var bd = new BancoDeDados())
            {

                var todosCursos = bd.AgendaCursos.ToList();

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage excelPackage = new ExcelPackage())
                {

                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Cursos");

                    worksheet.Cells[1, 1].Value = "ID";
                    worksheet.Cells[1, 2].Value = "Curso";
                    worksheet.Cells[1, 3].Value = "Inicio";
                    worksheet.Cells[1, 4].Value = "Fim";
                    worksheet.Cells[1, 5].Value = "Dias";
                    worksheet.Cells[1, 6].Value = "Horario";
                    worksheet.Cells[1, 7].Value = "Meta de Alunos";
                    worksheet.Cells[1, 8].Value = "Matriculados";
                    worksheet.Cells[1, 9].Value = "Valor";
                    worksheet.Cells[1, 10].Value = "Turma";
                    worksheet.Cells[1, 11].Value = "Sala";

                    int row = 2;
                    foreach (var curso in todosCursos)
                    {
                        worksheet.Cells[row, 1].Value = curso.Id;
                        worksheet.Cells[row, 2].Value = curso.Nome;
                        worksheet.Cells[row, 3].Value = curso.Inicio.ToString("dd-MM-yyyy");
                        worksheet.Cells[row, 4].Value = curso.Fim.ToString("dd-MM-yyyy");
                        worksheet.Cells[row, 5].Value = curso.Dias;
                        worksheet.Cells[row, 6].Value = curso.Horario;
                        worksheet.Cells[row, 7].Value = curso.Meta;
                        worksheet.Cells[row, 8].Value = curso.Realizado;
                        worksheet.Cells[row, 9].Value = curso.Valor;
                        worksheet.Cells[row, 10].Value = curso.Turma;
                        worksheet.Cells[row, 11].Value = curso.Sala;

                        row++;
                    }


                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = "Agenda de Cursos.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        excelPackage.SaveAs(new FileInfo(saveFileDialog.FileName));
                    }
                    MessageBox.Show("Exportado com sucesso.", "Agenda de Cursos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                bd.SaveChanges();
                LimparCampos();

            }
        }



        private void btnExportar_Click(object sender, EventArgs e)
        {
            iExportar();
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iExportar();
        }

        private void gridCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtId.Text = gridCurso.CurrentRow.Cells[0].Value.ToString();
            cmbCurso.Text = gridCurso.CurrentRow.Cells[1].Value.ToString();
            dtpInicio.Text = gridCurso.CurrentRow.Cells[2].Value.ToString();
            dtpFim.Text = gridCurso.CurrentRow.Cells[3].Value.ToString();
            clbDias.Text = gridCurso.CurrentRow.Cells[4].Value.ToString();
            cmbHorario.Text = gridCurso.CurrentRow.Cells[5].Value.ToString();
            txtMeta.Text = gridCurso.CurrentRow.Cells[6].Value.ToString();
            txtRealizado.Text = gridCurso.CurrentRow.Cells[7].Value.ToString();
            mtbValor.Text = gridCurso.CurrentRow.Cells[8].Value.ToString();
            txtTurma.Text = gridCurso.CurrentRow.Cells[9].Value.ToString();
            txtSala.Text = gridCurso.CurrentRow.Cells[10].Value.ToString();


        }




        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iExcluir();
        }

        private void TextOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !
                    char.IsLetter(e.KeyChar) && !
                    char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Digite apenas letras.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void cadastrarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCurso cadastroCurso = new CadastroCurso(this);

            cadastroCurso.Show();
            this.Hide();
        }


        private void cadastrarUsu�rioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Autenticacao.UsuarioTemPermissaoAdministrador())
            {
                CadastroUsuario cadastroUsuario = new CadastroUsuario();
                cadastroUsuario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Voc� n�o tem acesso administrador.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void acessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Autenticacao.UsuarioTemPermissaoAdministrador())
            {
                ControleAcesso controleAcesso = new ControleAcesso();
                controleAcesso.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Voc� n�o tem acesso administrador.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



        private void PesquisarCurso(string Pesquisa)
        {
            using (var bd = new BancoDeDados())
            {
                if (!string.IsNullOrEmpty(Pesquisa))
                {
                    var resultados = bd.AgendaCursos
                        .Where(c => c.Nome.ToUpper().Contains(Pesquisa.ToUpper()))
                        .ToList();

                    gridCurso.Columns.Clear();

                    if (gridCurso.Columns.Count == 0)
                    {
                        gridCurso.Columns.Add("Id", "ID");
                        gridCurso.Columns.Add("Nome", "Nome");
                        gridCurso.Columns.Add("Inicio", "In�cio");
                        gridCurso.Columns.Add("Fim", "Fim");
                        gridCurso.Columns.Add("Dias", "Dias");
                        gridCurso.Columns.Add("Horario", "Hor�rio");
                        gridCurso.Columns.Add("Meta", "Meta");
                        gridCurso.Columns.Add("Realizado", "Realizado");
                        gridCurso.Columns.Add("Valor", "Valor");
                        gridCurso.Columns.Add("Turma", "Turma");
                        gridCurso.Columns.Add("Sala", "Sala");
                    }

                    foreach (var curso in resultados)
                    {
                        gridCurso.Rows.Add(
                            curso.Id,
                            curso.Nome,
                            curso.Inicio,
                            curso.Fim,
                            curso.Dias,
                            curso.Horario,
                            curso.Meta,
                            curso.Realizado,
                            curso.Valor,
                            curso.Turma,
                            curso.Sala);
                    }
                }
                else
                {
                    ListaTudo();
                }
            }
        }

        private void ListaTudo()
        {
            Listar();
        }


        private void Agenda_de_Curso_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult iSair = MessageBox.Show("Deseja realmente sair?",
                                                    "Agenda de Cursos",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                if (iSair == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {

                    LogOut();
                    this.Hide();
                }
            }
        }


        private void txtPesquisar_TextChanged_1(object sender, EventArgs e)
        {
            PesquisarCurso(txtPesquisar.Text);
        }

        private void txtPesquisar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                PesquisarCurso(txtPesquisar.Text);
            }
        }


    }
}


        











