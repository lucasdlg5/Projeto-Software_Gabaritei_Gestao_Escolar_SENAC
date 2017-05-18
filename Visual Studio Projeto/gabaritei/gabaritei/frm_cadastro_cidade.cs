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
    public partial class frm_cadastro_cidade : Form
    {
        public frm_cadastro_cidade()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_cadastro_cidade_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gABARITEIDataSet.cidade' table. You can move, or remove it, as needed.
            this.cidadeTableAdapter.Fill(this.gABARITEIDataSet.cidade);

            if (classe_PUBLICA.v_cidadecd == "0")
            {


                cidadeBindingSource.AddNew();



            }

            else
            {

                cidadeBindingSource.EndEdit();
                cidadeTableAdapter.Update(gABARITEIDataSet);
                cidadeTableAdapter.Fill(gABARITEIDataSet.cidade);
                cidadeBindingSource.AddNew();
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CIDADE
            errorProvider1.Clear();
            if (textBox1.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox1, "O Preenchimento é obrigatório!!");
                textBox1.Focus();
                toolTip1.SetToolTip(textBox1, "Preencha este campo com a CIDADE");
                textBox1.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            else
            {
                cidadeBindingSource.EndEdit();
                cidadeTableAdapter.Update(gABARITEIDataSet);
                cidadeTableAdapter.Fill(gABARITEIDataSet.cidade);
                cidadeBindingSource.AddNew();

                this.Close();
            }
        }
    }
}
