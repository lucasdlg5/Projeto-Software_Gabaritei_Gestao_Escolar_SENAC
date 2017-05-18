using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gabaritei
{
    public partial class frm_funcionarios_lista : Form
    {
        public frm_funcionarios_lista()
        {
            InitializeComponent();
        }

        private void Alunos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GABARITEIDataSet.view_aluno_turma' table. You can move, or remove it, as needed.
            this.view_aluno_turmaTableAdapter.Fill(this.GABARITEIDataSet.view_aluno_turma);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.view_aluno_turma' table. You can move, or remove it, as needed.
            this.view_aluno_turmaTableAdapter.Fill(this.GABARITEIDataSet.view_aluno_turma);

        }

        private void cmb_alunos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //PESQUISAR
            errorProvider1.Clear();
            if (txb_pesquisa_alunos.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txb_pesquisa_alunos, "A Senha é obrigatória!!");
                txb_pesquisa_alunos.Focus();
                toolTip1.SetToolTip(txb_pesquisa_alunos, "teste");
                txb_pesquisa_alunos.Focus();
                return;
                //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void alterar_alunos_Click(object sender, EventArgs e)
        {
            //habilitar_campos

            //ou
        }
    }
}
