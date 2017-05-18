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
    public partial class frm_cadastro_responsavel : Form
    {
        public frm_cadastro_responsavel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //RESPONSAVEL
            errorProvider1.Clear();
            if (textBox2.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox2, "O Preenchimento é obrigatório!!");
                textBox2.Focus();
                toolTip1.SetToolTip(textBox2, "Preencha este campo com o NOME DO RESPONSÁVEL");
                textBox2.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }





            //CPF
            errorProvider1.Clear();
            if (maskedTextBox1.MaskFull == false)
            {
                errorProvider1.SetError(maskedTextBox1, "O Preenchimento é obrigatório!!");
                maskedTextBox1.Focus();
                toolTip1.SetToolTip(maskedTextBox1, "Preencha este campo com CPF do responsável");
                maskedTextBox1.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }
            else
            {
                reponsavelBindingSource.EndEdit();
                reponsavelTableAdapter.Update(gABARITEIDataSet);
                string v_codigo = textBox5.Text;
                reponsavelTableAdapter.Fill(gABARITEIDataSet.reponsavel);
                // Faz a busca no banco, a coluna que for colocada (liv_cd)
                int v_posicao = reponsavelBindingSource.Find("resp_cd", v_codigo);
                reponsavelBindingSource.Position = v_posicao;
                //habilitar_campos(true);
                reponsavelBindingSource.AddNew();
                //this.Visible = false;
                this.Close();
            }
        }

        private void frm_cadastro_responsavel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gABARITEIDataSet.reponsavel' table. You can move, or remove it, as needed.
            this.reponsavelTableAdapter.Fill(this.gABARITEIDataSet.reponsavel);

            if (classe_PUBLICA.v_respcontcd == "0")
            {
                
               reponsavelBindingSource.AddNew();


            }
            else
            {

                reponsavelBindingSource.Filter = "resp_cd  = " + classe_PUBLICA.v_respcontcd;

            }

        }
    }
}
