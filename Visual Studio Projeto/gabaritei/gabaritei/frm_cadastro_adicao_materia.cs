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
    public partial class frm_cadastro_adicao_materia : Form
    {
        public frm_cadastro_adicao_materia()
        {
            InitializeComponent();
        }

        private void frm_cadastro_adicao_materia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gABARITEIDataSet.materia' table. You can move, or remove it, as needed.
            this.materiaTableAdapter.Fill(this.gABARITEIDataSet.materia);
            
            if (classe_PUBLICA.v_acmateriacd2 == "0")
            {
                materiaBindingSource.AddNew();


            }
            else
            {

                materiaBindingSource.Filter = "mat_cd  = " + classe_PUBLICA.v_acmateriacd2;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //MATERIA
            errorProvider1.Clear();
            if (textBox1.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox1, "O Preenchimento é obrigatório!!");
                textBox1.Focus();
                toolTip1.SetToolTip(textBox1, "Preencha este campo com a MATÉRIA nova");
                textBox1.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            else
            {
                materiaBindingSource.EndEdit();
                materiaTableAdapter.Update(gABARITEIDataSet);
                materiaTableAdapter.Fill(gABARITEIDataSet.materia);
                materiaBindingSource.AddNew();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
