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
    public partial class frm_adicao_materias : Form
    {
        public frm_adicao_materias()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_cadastro_materias v_cadastromaterias = new frm_cadastro_materias();
            v_cadastromaterias.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Deseja excluir o registro", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{ 
            //livroBindingSource.RemoveCurrent();
            //livroTableAdapter.Update(bibliotecaDataSet);
            //}
        }

        private void frm_adicao_materias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GABARITEIDataSet.view_cadastro_materia' table. You can move, or remove it, as needed.
            this.view_cadastro_materiaTableAdapter.Fill(this.GABARITEIDataSet.view_cadastro_materia);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.turma_materia_horario' table. You can move, or remove it, as needed.
            this.turma_materia_horarioTableAdapter.Fill(this.GABARITEIDataSet.turma_materia_horario);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.tr_bi_sl' table. You can move, or remove it, as needed.
            this.tr_bi_slTableAdapter.Fill(this.GABARITEIDataSet.tr_bi_sl);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.turma' table. You can move, or remove it, as needed.
            this.turmaTableAdapter.Fill(this.GABARITEIDataSet.turma);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.materia' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'GABARITEIDataSet.materia' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'GABARITEIDataSet.mat_materia' table. You can move, or remove it, as needed.
            //this.mat_materiaTableAdapter.Fill(this.GABARITEIDataSet.mat_materia);

            if (classe_PUBLICA.v_turmascd == "0")
            {

                ////Move para o ultimo código
                //turmaBindingSource.MoveLast();
                
                //turmaBindingSource.MoveFirst();
                //Pega o primeiro código (chave primaria) 
                turmaTableAdapter.Fill(GABARITEIDataSet.turma);
                


                return;

            }
            else
            {
                turmaBindingSource.Filter = "tur_cd  = " + classe_PUBLICA.v_turmascd;
            }









            //  turmaBindingSource.Filter = "tur_cd  = " + classe_PUBLICA.v_turmascd;
            ////Pega o primeiro código (chave primaria) 
            //turmaTableAdapter.Fill(GABARITEIDataSet.turma);

            //////Move para o ultimo código
            //turmaBindingSource.MoveLast();

     


            //if (classe_PUBLICA.v_turmascd == "0")
            //{
            //    //Pega o primeiro código (chave primaria) 
            //    turmaTableAdapter.Fill(GABARITEIDataSet.turma);

            //    ////Move para o ultimo código
            //    turmaBindingSource.MoveLast();

            //}
            //else
            //{
            //    turmaBindingSource.Filter = "tur_cd  = " + classe_PUBLICA.v_turmascd;
            //}

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //////Pega o primeiro código (chave primaria) 
            //turmaTableAdapter.Fill(GABARITEIDataSet.turma);

            //////Move para o ultimo código
            //turmaBindingSource.MoveLast();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //classe_PUBLICA.v_alunocd = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            //this.turmaTableAdapter.Fill(this.GABARITEIDataSet.turma);
            turmaBindingSource.Filter = "tur_cd  = " + classe_PUBLICA.v_turmascd;

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //classe_PUBLICA.v_cmateriacd = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ////frm_cadastro_abertura_turmas v_aturmas = new frm_cadastro_abertura_turmas();
            ////v_aturmas.ShowDialog();
            //Form v_aturmas = new frm_cadastro_materias();
            //v_aturmas.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            classe_PUBLICA.v_cmateriacd = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //frm_cadastro_abertura_turmas v_aturmas = new frm_cadastro_abertura_turmas();
            //v_aturmas.ShowDialog();
            Form v_aturmas = new frm_cadastro_materias();
            v_aturmas.ShowDialog();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
