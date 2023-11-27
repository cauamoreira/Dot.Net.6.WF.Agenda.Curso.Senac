using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dot.Net._6.WF.Calendario.Senac
{
    public partial class Agenda_de_Curso : Form
    {
        public Agenda_de_Curso()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var nome = txtCurso.Text;
            var mes = txtMes.Text;

            using (var bd = new BancoDeDados())
            {
                var curso = new Curso()
                {
                    //gridCurso.Rows.Add(txtCurso.Text, txtMes.Text, txtInicio.Text, txtFim.Text, txtDias.Text,
                    // txtMeta.Text, txtRealizado.Text, txtTurno.Text, txtValor.Text, txtHorario.Text, txtTurma.Text, txtSala.Text);
                    Nome = nome,
                    Mes = mes,
            };

            // adicionando a cole��o clientes com um novo cliente
            // banco de dados.Clientes.Adicionar
            bd.Cursos.Add(curso);

            // salva as altera��es no banco
            bd.SaveChanges();

            gridCurso.DataSource = bd.Cursos.ToList();
        }

    }



    private void iLimpar()
        {
            int numRows = gridCurso.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                try
                {
                    int max = gridCurso.Rows.Count - 1;
                    gridCurso.Rows.Remove(gridCurso.Rows[max]);

                }

                catch (Exception exe)
                {
                    MessageBox.Show("Apagar tudo?" + exe, "Apagar todos os dados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            iLimpar();
        }
        private void iDeletar()
        {
            foreach (DataGridViewRow item in this.gridCurso.SelectedRows)
            {
                gridCurso.Rows.RemoveAt(item.Index);
            }
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            iDeletar();
        }
        
        
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var bd = new BancoDeDados())
            {
                // BUSCA NO BANCO O PRIMEIRO CLIENTE
                var curso = bd.Cursos.First();
                // SETA AS PROPRIEDADES DE ACORDO COM OS CAMPOS DA TELA
                curso.Nome = txtCurso.Text;
                curso.Mes = txtMes.Text;
                

                // SALVA AS ALTERA��ES
                bd.SaveChanges();
                gridCurso.DataSource = bd.Cursos.ToList();
            }

        }   
        
    




        Bitmap bitmap;
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            int heigt = gridCurso.Height;
            gridCurso.Height = gridCurso.RowCount * gridCurso.RowTemplate.Height * 2;
            bitmap = new Bitmap(gridCurso.Width, gridCurso.Height);
            gridCurso.DrawToBitmap(bitmap, new Rectangle(0, 0, gridCurso.Width, gridCurso.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
        private void iSair()
        {
            DialogResult iSair;
            iSair = MessageBox.Show("Voc� est� prestes a fechar. Tem certeza?", "Agenda de Cursos", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (iSair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            iSair();
        }

        private void NumbersOnly(object sender, KeyPressEventArgs e)
        {
            // Valida se a tecla pressionada � um n�mero.
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                // Permite a entrada do caractere.
                e.Handled = false;
            }
            else
            {
                // Exibe uma mensagem de erro.
                MessageBox.Show("Digite apenas n�meros", "Erro: Apenas n�meros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Bloqueia a entrada do caractere.
                e.Handled = true;
            }
        }

    }
}

