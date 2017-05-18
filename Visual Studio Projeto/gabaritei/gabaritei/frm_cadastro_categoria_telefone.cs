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
    public partial class frm_cadastro_categoria_telefone : Form
    {
        public frm_cadastro_categoria_telefone()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CATEGORIA TELEFONE
            errorProvider1.Clear();
            if (textBox2.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox2, "O Preenchimento é obrigatório!!");
                textBox2.Focus();
                toolTip1.SetToolTip(textBox2, "Preencha este campo com o TIPO DE TELEFONE. Ex: Tipo Celular");
                textBox2.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            else
            {

                tipotelefoneBindingSource.EndEdit();
                tipo_telefoneTableAdapter.Update(GABARITEIDataSet);
                //string v_codigo = textBox1.Text;
                tipo_telefoneTableAdapter.Fill(GABARITEIDataSet.tipo_telefone);
                //// Faz a busca no banco, a coluna que for colocada (liv_cd)
                //int v_posicao = tipotelefoneBindingSource.Find("ttel_cd", textBox1.Text);
                //tipotelefoneBindingSource.Position = v_posicao;
                tipotelefoneBindingSource.AddNew();
            }
        }

        private void frm_cadastro_categoria_telefone_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GABARITEIDataSet.tipo_telefone' table. You can move, or remove it, as needed.
            this.tipo_telefoneTableAdapter.Fill(this.GABARITEIDataSet.tipo_telefone);

            if (classe_PUBLICA.v_cadtelcd == "0")
            {
                tipotelefoneBindingSource.AddNew();


            }
            else
            {

                tipotelefoneBindingSource.Filter = "alut_cd  = " + classe_PUBLICA.v_cadtelcd;

            }

        }
    }
}
