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
    public partial class frm_cadastro_tipo_respon : Form
    {
        public frm_cadastro_tipo_respon()
        {
            InitializeComponent();
        }

        private void frm_cadastro_tipo_respon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gABARITEIDataSet.tipo_responsavel' table. You can move, or remove it, as needed.
            this.tipo_responsavelTableAdapter.Fill(this.gABARITEIDataSet.tipo_responsavel);

            if (classe_PUBLICA.v_trespcd == "0")
            {
                tiporesponsavelBindingSource.AddNew();


            }
            else
            {

                tiporesponsavelBindingSource.Filter = "tresp_cd  = " + classe_PUBLICA.v_trespcd;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //TIPO DE REPSONSÁVEL
            errorProvider1.Clear();
            if (textBox2.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox2, "O Preenchimento é obrigatório!!");
                textBox2.Focus();
                toolTip1.SetToolTip(textBox2, "Preencha este campo com o TIPO de responsável");
                textBox2.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }
            else
            {
                tiporesponsavelBindingSource.EndEdit();
                tipo_responsavelTableAdapter.Update(gABARITEIDataSet);
                //string v_codigo = textBox5.Text;
                //tipo_responsavelTableAdapter.Fill(gABARITEIDataSet.tipo_responsavel);
                //// Faz a busca no banco, a coluna que for colocada (liv_cd)
                //int v_posicao = tiporesponsavelBindingSource.Find("resp_cd", v_codigo);
                //tiporesponsavelBindingSource.Position = v_posicao;
                //habilitar_campos(true);
                tiporesponsavelBindingSource.AddNew();
                //this.Visible = false;
                this.Close();
            }
        }
    }
}
