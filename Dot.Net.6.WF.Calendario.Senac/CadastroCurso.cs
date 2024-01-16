﻿using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dot.Net._6.WF.Calendario.Senac
{
    public partial class CadastroCurso : Form
    {
        public CadastroCurso(Agenda_de_Curso agenda_De_Curso)
        {

            InitializeComponent();
            agenda_De_Curso = agenda_De_Curso;
            txtCadastroCurso.Focus();

        }

        private void AdicionarHistoricoNovoCurso(BancoDeDados bd, Curso curso)
        {
            bd.Historicos.Add(new Historico
            {
                Login = Autenticacao.UsuarioAtual?.Login,
                DataHora = DateTime.Now,
                Alteracao = "Adição de Curso",
                Detalhes = $"Adicionado curso: {curso.Nome}"

            });
        }

        private void AbrirFormAgendaCurso()
        {
            Agenda_de_Curso agenda_De_Curso = new Agenda_de_Curso();
            agenda_De_Curso.Show();
        }

        private void Cadastramento_de_Cursos_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            GridViewCadastroCurso.Rows.Clear();

            using (var bd = new BancoDeDados())
            {
                var Curso = bd.Cursos.ToList();

                foreach (var curso in Curso)
                {
                    GridViewCadastroCurso.Rows.Add(
                        curso.Id,
                        curso.Nome);
                }

            }
        }


        private void AdicionarHistoricoExclusaoCurso(BancoDeDados bd, Curso curso)
        {
            bd.Historicos.Add(new Historico
            {
                Login = Autenticacao.UsuarioAtual?.Login,
                DataHora = DateTime.Now,
                Alteracao = "Exclusão de Curso",
                Detalhes = $"Excluído curso: {curso.Id}, Nome: {curso.Nome}"

            });
        }
        private void GridViewCadastroCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = GridViewCadastroCurso.CurrentRow.Cells[0].Value.ToString();
            txtCadastroCurso.Text = GridViewCadastroCurso.CurrentRow.Cells[1].Value.ToString();
        }

        private void LimparCampos()
        {
            txtId.Text = String.Empty;
            txtCadastroCurso.Text = String.Empty;
        }


        private void AdicionarHistoricoAlteracaoCurso(BancoDeDados bd, Curso curso, string nomeOriginal)
        {
            bd.Historicos.Add(new Historico
            {
                Login = Autenticacao.UsuarioAtual?.Login,
                DataHora = DateTime.Now,
                Alteracao = "Alteração de Curso",
                Detalhes = $"Alterado curso: Id {curso.Id}, Nome: {nomeOriginal} para {curso.Nome}"

            });
        }

        private void btnAdicionarCurso_Click(object sender, EventArgs e)
        {
            var nome = txtCadastroCurso.Text;

            using (var bd = new BancoDeDados())
            {
                var cursoExistente = bd.Cursos.FirstOrDefault(c => c.Nome == nome);

                if (cursoExistente != null)
                {
                    MessageBox.Show("Já existe um curso com esse nome. Escolha um nome diferente.",
                                    "Cadastro de Curso", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
                else
                {
                    var novoCurso = new Curso()
                    {
                        Nome = nome,
                    };

                    AdicionarHistoricoNovoCurso(bd, novoCurso);

                    bd.Cursos.Add(novoCurso);

                    bd.SaveChanges();

                    MessageBox.Show("Curso adicionado com sucesso.",
                        "Cadastro de Curso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Listar();
                    LimparCampos();

                }
            }
        }

        private void btnSairCurso_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente sair?",
            "Alerta",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                AbrirFormAgendaCurso();
                this.Close();
            }
        }

        private void btnAlterarCurso_Click(object sender, EventArgs e)
        {
            string nome = txtCadastroCurso.Text;

            using (var bd = new BancoDeDados())
            {
                var curso = bd.Cursos.Where(w => w.Id == Convert.ToInt32(txtId.Text)).FirstOrDefault();

                if (curso != null)
                {
                    string nomeOriginal = curso.Nome;

                    curso.Nome = nome;

                    AdicionarHistoricoAlteracaoCurso(bd, curso, nomeOriginal);

                    bd.SaveChanges();

                    MessageBox.Show("Deseja alterar?", "Cadastro de Curso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    Listar();
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Curso não encontrado. Verifique o curso informado.");
                }
            }
        }

        private void btnExcluirCurso_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Deve selecionar o curso que deseja excluir.");
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    using (var bd = new BancoDeDados())
                    {
                        try
                        {
                            var curso = bd.Cursos.FirstOrDefault(w => w.Id == Convert.ToInt32(txtId.Text));

                            if (curso != null)
                            {
                                AdicionarHistoricoExclusaoCurso(bd, curso);

                                bd.Cursos.Remove(curso);
                                bd.SaveChanges();
                                Listar();
                            }
                            else
                            {
                                MessageBox.Show("Curso não encontrado. Verifique o curso informado.");
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
    }
}


