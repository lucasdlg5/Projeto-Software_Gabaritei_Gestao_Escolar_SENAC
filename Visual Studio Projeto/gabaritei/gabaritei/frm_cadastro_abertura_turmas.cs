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
    public partial class frm_cadastro_abertura_turmas : Form
    {
        public frm_cadastro_abertura_turmas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //habilitar_campos(true);
            //livroBindingSource.CancelEdit();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //NOME DA TURMA
            errorProvider1.Clear();
            if (textBox1.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox1, "O Preenchimento é obrigatório!!");
                textBox1.Focus();
                toolTip1.SetToolTip(textBox1, "Preencha este campo com o NOME DA TURMA");
                textBox1.Focus();
                return;
                //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }


            //PERIODO DISCIPLINAR
            errorProvider1.Clear();
            if (textBox3.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox3, "O Preenchimento é obrigatório!!");
                textBox3.Focus();
                toolTip1.SetToolTip(textBox3, "Preencha este campo com o PERIODO DISCIPLINAR da turma");
                textBox3.Focus();
                return;
                //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //N VAGAS
            errorProvider1.Clear();
            if (numericUpDown1.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(numericUpDown1, "O Preenchimento é obrigatório!!");
                numericUpDown1.Focus();
                toolTip1.SetToolTip(numericUpDown1, "Preencha este campo com a QUANTIDADE DE ALUNOS na turma");
                numericUpDown1.Focus();
                return;
                //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //PERIODO
            errorProvider1.Clear();
            if (comboBox1.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(comboBox1, "O Preenchimento é obrigatório!!");
                comboBox1.Focus();
                toolTip1.SetToolTip(comboBox1, "Preencha este campo com o PERIODO da turma");
                comboBox1.Focus();
                return;
                //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }


            //HORARIO INICIO
            errorProvider1.Clear();
            if (maskedTextBox1.MaskFull == false)
            {
                errorProvider1.SetError(maskedTextBox1, "O Preenchimento é obrigatório!!");
                maskedTextBox1.Focus();
                toolTip1.SetToolTip(maskedTextBox1, "Preencha este campo com a HORARIO DE INICIO");
                maskedTextBox1.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }


            //DHORARIO TERMINO
            errorProvider1.Clear();
            if (maskedTextBox2.MaskFull == false)
            {
                errorProvider1.SetError(maskedTextBox2, "O Preenchimento é obrigatório!!");
                maskedTextBox2.Focus();
                toolTip1.SetToolTip(maskedTextBox2, "Preencha este campo com a HORARIO TERMINO");
                maskedTextBox2.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }


            else
            {
                turmaBindingSource.EndEdit();
                turmaTableAdapter.Update(GABARITEIDataSet);
                string v_codigo = txb_codigo.Text;
                turmaTableAdapter.Fill(GABARITEIDataSet.turma);
                //// Faz a busca no banco, a coluna que for colocada (liv_cd)
                int v_posicao = turmaBindingSource.Find("tur_cd", txb_codigo.Text);
                turmaBindingSource.Position = v_posicao;
                //habilitar_campos(true);
                //turmaBindingSource.AddNew();
                //this.Visible = false;

                trbislBindingSource.EndEdit();
                tr_bi_slTableAdapter.Update(GABARITEIDataSet);
                tr_bi_slTableAdapter.Fill(GABARITEIDataSet.tr_bi_sl);


                frm_adicao_materias v_cadastro_turmas = new frm_adicao_materias();
                v_cadastro_turmas.Show();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
                        //NOME DA TURMA
            errorProvider1.Clear();
            if (textBox1.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox1, "A Senha é obrigatória!!");
                textBox1.Focus();
                toolTip1.SetToolTip(textBox1, "teste");
                textBox1.Focus();
                return;
                //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //DATA DE INICIO
            errorProvider1.Clear();
            if (maskedTextBox1.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(maskedTextBox1, "A Senha é obrigatória!!");
                maskedTextBox1.Focus();
                toolTip1.SetToolTip(maskedTextBox1, "teste");
                maskedTextBox1.Focus();
                return;
                //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //DATA DE TERMINO
            errorProvider1.Clear();
            if (maskedTextBox2.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(maskedTextBox2, "A Senha é obrigatória!!");
                maskedTextBox2.Focus();
                toolTip1.SetToolTip(maskedTextBox2, "teste");
                maskedTextBox2.Focus();
                return;
                //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //PERIODO DISCIPLINAR
            errorProvider1.Clear();
            if (textBox3.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox3, "A Senha é obrigatória!!");
                textBox3.Focus();
                toolTip1.SetToolTip(textBox3, "teste");
                textBox3.Focus();
                return;
                //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //N VAGAS
            errorProvider1.Clear();
            if (numericUpDown1.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(numericUpDown1, "A Senha é obrigatória!!");
                numericUpDown1.Focus();
                toolTip1.SetToolTip(numericUpDown1, "teste");
                numericUpDown1.Focus();
                return;
                //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //PERIODO
            errorProvider1.Clear();
            if (comboBox1.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(comboBox1, "A Senha é obrigatória!!");
                comboBox1.Focus();
                toolTip1.SetToolTip(comboBox1, "teste");
                comboBox1.Focus();
                return;
                //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            else
            {
                turmaBindingSource.EndEdit();
                turmaTableAdapter.Update(GABARITEIDataSet);
                string v_codigo = txb_codigo.Text;
                turmaTableAdapter.Fill(GABARITEIDataSet.turma);
                //// Faz a busca no banco, a coluna que for colocada (liv_cd)
                int v_posicao = turmaBindingSource.Find("tur_cd", txb_codigo.Text);
                turmaBindingSource.Position = v_posicao;

                //habilitar_campos(true);
                turmaBindingSource.AddNew();
                //this.Visible = false;

                //frm_adicao_materias v_cadastro_turmas = new frm_adicao_materias();
                //v_cadastro_turmas.Show();
                //this.Close();




            }
        }

        private void frm_cadastro_abertura_turmas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GABARITEIDataSet.tr_bi_sl' table. You can move, or remove it, as needed.
            this.tr_bi_slTableAdapter.Fill(this.GABARITEIDataSet.tr_bi_sl);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.turma' table. You can move, or remove it, as needed.
            this.turmaTableAdapter.Fill(this.GABARITEIDataSet.turma);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.turma' table. You can move, or remove it, as needed.
            //this.turmaTableAdapter.Fill(this.GABARITEIDataSet.turma);

            if (classe_PUBLICA.v_turmascd == "0")
            {
                turmaBindingSource.AddNew();
                trbislBindingSource.AddNew();
                //turmaBindingSource.AddNew();
                //FAZ COM QUE PEGUE A DATA ATUAL DO COMPUTADOR
                numericUpDown1.Value = 0;
            }
            else
            {
                //FAZ COM QUE PEGUE A DATA ATUAL DO COMPUTADOR
                //textBox3.Text = DateTime.Now.ToShortDateString();

                //Faz o filtro dentro do Bindingsource, em que, na coluna ALU_CD da tabela ALUNO
                // será "=" somado ao resto ( classe_PUBLICA.v_alunocd é o que verificará a contagem) 

                //DESCOMENTAR ESTA LINHA | DESCOMENTAR ESTA LINHA |DESCOMENTAR ESTA LINHA |DESCOMENTAR ESTA LINHA |
                turmaBindingSource.Filter = "tur_cd  = " + classe_PUBLICA.v_turmascd;
                trbislBindingSource.Filter = "tr_bi_sl_cd  = " + classe_PUBLICA.v_turmascd;
                //turmaBindingSource.Filter = "tur_cd =" + classe_PUBLICA.v_turmascd;
                //DESCOMENTAR ESTA LINHA | DESCOMENTAR ESTA LINHA |DESCOMENTAR ESTA LINHA |DESCOMENTAR ESTA LINHA |
            }
            textBox2.Text = classe_PUBLICA.v_turmascd;

        }
    }
}
