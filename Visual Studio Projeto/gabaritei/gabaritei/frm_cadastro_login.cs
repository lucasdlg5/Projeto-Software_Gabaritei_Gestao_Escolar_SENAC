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
    public partial class frm_cadastro_login : Form
    {
        public frm_cadastro_login()
        {
            InitializeComponent();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_cadastro_login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GABARITEIDataSet.funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.GABARITEIDataSet.funcionario);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.loginn' table. You can move, or remove it, as needed.
            this.loginnTableAdapter.Fill(this.GABARITEIDataSet.loginn);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.tipo_de_user' table. You can move, or remove it, as needed.
            this.tipo_de_userTableAdapter.Fill(this.GABARITEIDataSet.tipo_de_user);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.loginn' table. You can move, or remove it, as needed.
            //this.loginnTableAdapter.Fill(this.GABARITEIDataSet.loginn);

            if (classe_PUBLICA.v_cafuncd == "0")
            {
                loginnBindingSource.AddNew();


            }
            else
            {

                loginnBindingSource.Filter = "loginn  = " + classe_PUBLICA.v_cafuncd;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //NOME DO FUNCIONARIO
            errorProvider1.Clear();
            if (comboBox1.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(comboBox1, "O Preenchimento é obrigatório!!");
                comboBox1.Focus();
                toolTip1.SetToolTip(comboBox1, "Preencha este campo com o NOME do funcionário");
                comboBox1.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }
            //USUÁRIO
            errorProvider1.Clear();
            if (textBox5.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox5, "O Preenchimento é obrigatório!!");
                textBox5.Focus();
                toolTip1.SetToolTip(textBox5, "Preencha este campo com o USUÁRIO");
                textBox5.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }
            //TIPO DE USUÁRIO
            errorProvider1.Clear();
            if (comboBox3.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(comboBox3, "O Preenchimento é obrigatório!!");
                comboBox3.Focus();
                toolTip1.SetToolTip(comboBox3, "Preencha este campo com o TIPO DE USUÁRIO");
                comboBox3.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }
            //SENHA
            errorProvider1.Clear();
            if (textBox6.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox6, "O Preenchimento é obrigatório!!");
                textBox6.Focus();
                toolTip1.SetToolTip(textBox6, "Preencha este campo com a SENHA DO USUÁRIO");
                textBox6.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }
            //SITUAÇÃO DO CADASTRO
            errorProvider1.Clear();
            if (comboBox4.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(comboBox4, "O Preenchimento é obrigatório!!");
                comboBox4.Focus();
                toolTip1.SetToolTip(comboBox4, "Preencha este campo com a SITUAÇÃO do cadastro");
                comboBox4.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }
            //EMAIL
            errorProvider1.Clear();
            if (textBox7.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox7, "O Preenchimento é obrigatório!!");
                textBox7.Focus();
                toolTip1.SetToolTip(textBox7, "Preencha este campo com o EMAIL");
                textBox7.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            else
            {
                loginnBindingSource.EndEdit();
                loginnTableAdapter.Update(GABARITEIDataSet);
                //string v_codigo2 = textBox14.Text;
                loginnTableAdapter.Fill(GABARITEIDataSet.loginn);
                loginnBindingSource.MoveLast();
                ////// Faz a busca no banco, a coluna que for colocada (liv_cd)
                //int v_posicao2 = loginnBindingSource.Find("loginn", v_codigo2);
                //loginnBindingSource.Position = v_posicao2;
                //habilitar_campos(true);


                funcionarioBindingSource.MoveLast();
                funcionarioBindingSource.EndEdit();
                funcionarioTableAdapter.Update(GABARITEIDataSet);
                funcionarioTableAdapter.Fill(GABARITEIDataSet.funcionario);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            funcionarioBindingSource.MoveLast();
        }
    }
}
