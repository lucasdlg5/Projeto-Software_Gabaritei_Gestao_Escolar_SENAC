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
    public partial class frm_cadastrar_cargo : Form
    {
        public frm_cadastrar_cargo()
        {
            InitializeComponent();
        }

        private void frm_cadastrar_cargo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gABARITEIDataSet.cargo' table. You can move, or remove it, as needed.
            this.cargoTableAdapter.Fill(this.gABARITEIDataSet.cargo);

            if (classe_PUBLICA.v_cargocd == "0")
            {
                cargoBindingSource.AddNew();


            }
            else
            {

                cargoBindingSource.Filter = "cargo_cd  = " + classe_PUBLICA.v_cargocd;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //NOME DO CARGO
            errorProvider1.Clear();
            if (textBox1.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox1, "O Preenchimento é obrigatório!!");
                textBox1.Focus();
                toolTip1.SetToolTip(textBox1, "Preencha este campo com o NOME DO CARGO");
                textBox1.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            else
            {
                cargoBindingSource.EndEdit();
                cargoTableAdapter.Update(gABARITEIDataSet);
                cargoTableAdapter.Fill(gABARITEIDataSet.cargo);
                cargoBindingSource.AddNew();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
