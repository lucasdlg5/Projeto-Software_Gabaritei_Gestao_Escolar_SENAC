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
    public partial class frm_cadastro_materias_horario : Form
    {
        public frm_cadastro_materias_horario()
        {
            InitializeComponent();
        }

        private void frm_cadastro_materias_horario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gABARITEIDataSet.turma' table. You can move, or remove it, as needed.
            this.turmaTableAdapter.Fill(this.gABARITEIDataSet.turma);
            // TODO: This line of code loads data into the 'gABARITEIDataSet.turma_materia_horario' table. You can move, or remove it, as needed.
            this.turma_materia_horarioTableAdapter.Fill(this.gABARITEIDataSet.turma_materia_horario);

            if (classe_PUBLICA.v_acmateriacd3 == "0")
            {
                turmaBindingSource.AddNew();
                turmamateriahorarioBindingSource.AddNew();

                //FAZ COM QUE PEGUE A DATA ATUAL DO COMPUTADOR

            }
            else
            {

                turmamateriahorarioBindingSource.Filter = "tmat_cd  = " + classe_PUBLICA.v_acmateriacd3;
                turmaBindingSource.Filter = "tur_cd =" + classe_PUBLICA.v_acmateriacd3;

            }
            textBox3.Text = classe_PUBLICA.v_acmateriacd3;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //HORÁRIO TERMINO
            errorProvider1.Clear();
            if (maskedTextBox2.MaskFull == false)
            {
                errorProvider1.SetError(maskedTextBox2, "O Preenchimento é obrigatório!!");
                maskedTextBox2.Focus();
                toolTip1.SetToolTip(maskedTextBox2, "Preencha este campo com o HORÁRIO DE TERMINO da matéria");
                maskedTextBox2.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //HORARIO INICIO
            errorProvider1.Clear();
            if (maskedTextBox1.MaskFull == false)
            {
                errorProvider1.SetError(maskedTextBox1, "O Preenchimento é obrigatório!!");
                maskedTextBox1.Focus();
                toolTip1.SetToolTip(maskedTextBox1, "Preencha este campo com o HORÁRIO DE INICIO da matéria");
                maskedTextBox1.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //Carga Horária
            errorProvider1.Clear();
            if (textBox2.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox2, "O Preenchimento é obrigatório!!");
                textBox2.Focus();
                toolTip1.SetToolTip(textBox2, "Preencha este campo com a CARGA HORÁRIA TOTAL da matéria");
                textBox2.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            else
            {
                turmamateriahorarioBindingSource.EndEdit();
                turma_materia_horarioTableAdapter.Update(gABARITEIDataSet);
                turma_materia_horarioTableAdapter.Fill(gABARITEIDataSet.turma_materia_horario);
                turmaBindingSource.AddNew();

                this.Close();

                //turmaBindingSource.EndEdit();
                //turmaTableAdapter.Update(gABARITEIDataSet);
                //turmaTableAdapter.Fill(gABARITEIDataSet.turma);
                //turmaBindingSource.AddNew();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
