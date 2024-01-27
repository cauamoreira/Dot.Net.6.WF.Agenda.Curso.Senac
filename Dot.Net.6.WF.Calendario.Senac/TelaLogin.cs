﻿namespace Dot.Net._6.WF.Calendario.Senac
{
    public partial class TelaLogin : Form
    {

        private bool _podeVerSenha = false;

        public TelaLogin()
        {
            InitializeComponent();
            txtUsuario.Focus();
            picLoading.Hide();
            picSenha.Click += picSenha_Click;

        }

        private void AbrirFormPrincipal()
        {
            Agenda_de_Curso agenda_De_Curso = new Agenda_de_Curso();
            agenda_De_Curso.Show();
            this.Hide();
        }

        private void LimparCampos()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void TelaLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }


        private async void btnEntrar_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            picLoading.Show();
            await Task.Delay(1000);
            picLoading.Hide();

            using (var bd = new BancoDeDados())
            {
                if (!bd.Usuarios.Any())
                {
                    bd.Usuarios.Add(new Usuario
                    {
                        Login = "admin",
                        Senha = "senha1",
                        Cpf = "00000000000",
                        DataNascimento = DateTime.Now,
                        Ativo = true,
                        Administrador = true
                    });

                    bd.SaveChanges();
                }
                var usuarioExistente = bd.Usuarios.FirstOrDefault(u => u.Login == usuario);

                if (usuarioExistente != null && Autenticacao.AutenticarUsuario(usuario, senha))
                {
                    MessageBox.Show($"Bem-vindo: {usuarioExistente.Login}", "Senac", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bd.Historicos.Add(new Historico
                    {
                        Login = usuario,
                        DataHora = DateTime.Now,
                        Alteracao = $"Usuário {usuarioExistente.Login} fez login",
                        Detalhes = ""
                    });

                    bd.SaveChanges();

                    AbrirFormPrincipal();

                    ControleAcesso controleAcesso = Application.OpenForms.OfType<ControleAcesso>().FirstOrDefault();

                    if (controleAcesso != null)
                    {
                        controleAcesso.CarregarHistorico();
                    }
                }
                else
                {
                    MessageBox.Show("Falha no login. Verifique suas credenciais.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LimparCampos();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '\r')
            {
                btnEntrar_Click_1(this, new EventArgs());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            EsqueceuSenha esqueceuSenha = new EsqueceuSenha();
            esqueceuSenha.Show();
        }

        private void picSenha_Click(object sender, EventArgs e)
        {

            _podeVerSenha = !_podeVerSenha;

            if (_podeVerSenha)
            {
                picSenha.Image = Properties.Resources.esconder;
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                picSenha.Image = Properties.Resources.visualizar;
                txtSenha.PasswordChar = '\u25CF';
            }
        }

        private void TelaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult iSair = MessageBox.Show("Deseja fechar o programa?",
                                                    "Agenda de Cursos",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                if (iSair == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {

                    Application.Exit();
                    
                }
            }
        }
    }
}

















