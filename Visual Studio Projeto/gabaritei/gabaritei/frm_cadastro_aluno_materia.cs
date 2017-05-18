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
    public partial class frm_cadastro_aluno_materia : Form
    {
        public frm_cadastro_aluno_materia()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_cadastro_aluno_materia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gABARITEIDataSet.view_aluno_nota' table. You can move, or remove it, as needed.
            this.view_aluno_notaTableAdapter.Fill(this.gABARITEIDataSet.view_aluno_nota);
            // TODO: This line of code loads data into the 'gABARITEIDataSet.materia' table. You can move, or remove it, as needed.
            this.materiaTableAdapter.Fill(this.gABARITEIDataSet.materia);
            // TODO: This line of code loads data into the 'gABARITEIDataSet.turma_materia' table. You can move, or remove it, as needed.
            this.turma_materiaTableAdapter.Fill(this.gABARITEIDataSet.turma_materia);
            // TODO: This line of code loads data into the 'gABARITEIDataSet.turma' table. You can move, or remove it, as needed.
            this.turmaTableAdapter.Fill(this.gABARITEIDataSet.turma);
            // TODO: This line of code loads data into the 'gABARITEIDataSet.nota_falta' table. You can move, or remove it, as needed.
            this.nota_faltaTableAdapter.Fill(this.gABARITEIDataSet.nota_falta);
            // TODO: This line of code loads data into the 'gABARITEIDataSet.aluno' table. You can move, or remove it, as needed.
            this.alunoTableAdapter.Fill(this.gABARITEIDataSet.aluno);

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }
    }
}
