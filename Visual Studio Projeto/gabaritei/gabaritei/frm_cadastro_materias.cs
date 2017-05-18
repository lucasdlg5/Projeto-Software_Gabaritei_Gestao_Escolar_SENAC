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
    public partial class frm_cadastro_materias : Form
    {
        public frm_cadastro_materias()
        {
            InitializeComponent();
        }

        private void frm_cadastro_materias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GABARITEIDataSet.cmb_turmaa' table. You can move, or remove it, as needed.
            this.cmb_turmaaTableAdapter.Fill(this.GABARITEIDataSet.cmb_turmaa);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.turma_materia' table. You can move, or remove it, as needed.
            this.turma_materiaTableAdapter.Fill(this.GABARITEIDataSet.turma_materia);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.materia' table. You can move, or remove it, as needed.
            this.materiaTableAdapter.Fill(this.GABARITEIDataSet.materia);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.turma_materia_horario' table. You can move, or remove it, as needed.
            this.turma_materia_horarioTableAdapter.Fill(this.GABARITEIDataSet.turma_materia_horario);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.tr_bi_sl' table. You can move, or remove it, as needed.
            this.tr_bi_slTableAdapter.Fill(this.GABARITEIDataSet.tr_bi_sl);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.turma' table. You can move, or remove it, as needed.
            this.turmaTableAdapter.Fill(this.GABARITEIDataSet.turma);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.cargo' table. You can move, or remove it, as needed.
            this.cargoTableAdapter.Fill(this.GABARITEIDataSet.cargo);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.cmb_professor' table. You can move, or remove it, as needed.
            this.cmb_professorTableAdapter.Fill(this.GABARITEIDataSet.cmb_professor);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.turma' table. You can move, or remove it, as needed.
            this.turmaTableAdapter.Fill(this.GABARITEIDataSet.turma);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.materia' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'GABARITEIDataSet.turma_materia_horario' table. You can move, or remove it, as needed.
            this.turma_materia_horarioTableAdapter.Fill(this.GABARITEIDataSet.turma_materia_horario);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.turma_materia_horario' table. You can move, or remove it, as needed.
            //this.turma_materia_horarioTableAdapter.Fill(this.GABARITEIDataSet.turma_materia_horario);
            //// TODO: This line of code loads data into the 'GABARITEIDataSet.turma_materia' table. You can move, or remove it, as needed.
            //this.turma_materiaTableAdapter.Fill(this.GABARITEIDataSet.turma_materia);
            //// TODO: This line of code loads data into the 'GABARITEIDataSet.turma' table. You can move, or remove it, as needed.
            //this.turmaTableAdapter.Fill(this.GABARITEIDataSet.turma);
            //// TODO: This line of code loads data into the 'GABARITEIDataSet.funcionario' table. You can move, or remove it, as needed.
            //this.funcionarioTableAdapter.Fill(this.GABARITEIDataSet.funcionario);
            //// TODO: This line of code loads data into the 'GABARITEIDataSet.materia' table. You can move, or remove it, as needed.
            //this.materiaTableAdapter.Fill(this.GABARITEIDataSet.materia);

            if (classe_PUBLICA.v_cmateriacd == "0")
            {
                materiaBindingSource.AddNew();
                turmaBindingSource.AddNew();
                turmamateriaBindingSource.AddNew();
                turmamateriahorarioBindingSource.AddNew();

                //FAZ COM QUE PEGUE A DATA ATUAL DO COMPUTADOR

            }
            else
            {
                //FAZ COM QUE PEGUE A DATA ATUAL DO COMPUTADOR
                //textBox3.Text = DateTime.Now.ToShortDateString();

                //Faz o filtro dentro do Bindingsource, em que, na coluna ALU_CD da tabela ALUNO
                // será "=" somado ao resto ( classe_PUBLICA.v_alunocd é o que verificará a contagem) 

                //DESCOMENTAR ESTA LINHA | DESCOMENTAR ESTA LINHA |DESCOMENTAR ESTA LINHA |DESCOMENTAR ESTA LINHA |
                //materiaBindingSource.Filter = "mat_cd  = " + classe_PUBLICA.v_cmateriacd;
                classe_PUBLICA.v_cmateriacd = "0";
                //DESCOMENTAR ESTA LINHA | DESCOMENTAR ESTA LINHA |DESCOMENTAR ESTA LINHA |DESCOMENTAR ESTA LINHA |
                materiaBindingSource.Filter = "mat_cd  = " + classe_PUBLICA.v_cmateriacd;
                //turmaBindingSource.Filter = "tur_cd  = " + classe_PUBLICA.v_acmateriacd2;
                turmamateriahorarioBindingSource.Filter = "tmat_cd  = " + classe_PUBLICA.v_cmateriacd;
                turmamateriaBindingSource.Filter = "tur_cd  = " + classe_PUBLICA.v_cmateriacd;

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //habilitar_campos(true);
            //livroBindingSource.CancelEdit();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //VALIDAÇÃO DE DADOS

            //PROFESSOR
            errorProvider1.Clear();
            if (comboBox1.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(comboBox1, "O Preenchimento é obrigatório!!");
                comboBox1.Focus();
                toolTip1.SetToolTip(comboBox1, "Preencha este campo com o PROFESSOR");
                comboBox1.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //MATÉRIA
            errorProvider1.Clear();
            if (comboBox2.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(comboBox2, "O Preenchimento é obrigatório!!");
                comboBox2.Focus();
                toolTip1.SetToolTip(comboBox2, "Preencha este campo com a MATÉRIA");
                comboBox2.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //TURMA
            errorProvider1.Clear();
            if (comboBox3.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(comboBox3, "O Preenchimento é obrigatório!!");
                comboBox3.Focus();
                toolTip1.SetToolTip(comboBox3, "Preencha este campo com a TURMA");
                comboBox3.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //PERÍODO
            errorProvider1.Clear();
            if (textBox4.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox4, "O Preenchimento é obrigatório!!");
                textBox4.Focus();
                toolTip1.SetToolTip(textBox4, "Preencha este campo com o PERÍODO da turma");
                textBox4.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }



            //MATERIA
            //errorProvider1.Clear();
            //if (textBox3.Text.Trim().Length == 0)
            //{
            //    errorProvider1.SetError(textBox3, "A Senha é obrigatória!!");
            //    textBox3.Focus();
            //    toolTip1.SetToolTip(textBox3, "teste");
            //    textBox3.Focus();
            //    return;
            //    //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            //}


            ////HORARIO INICIO
            //errorProvider1.Clear();
            //if (maskedTextBox1.Text.Trim().Length == 0)
            //{
            //    errorProvider1.SetError(maskedTextBox1, "A Senha é obrigatória!!");
            //    maskedTextBox1.Focus();
            //    toolTip1.SetToolTip(maskedTextBox1, "teste");
            //    maskedTextBox1.Focus();
            //    return;
            //    //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            //}

            ////HORARIO TERMINO
            //errorProvider1.Clear();
            //if (maskedTextBox2.Text.Trim().Length == 0)
            //{
            //    errorProvider1.SetError(maskedTextBox2, "A Senha é obrigatória!!");
            //    maskedTextBox2.Focus();
            //    toolTip1.SetToolTip(maskedTextBox2, "teste");
            //    maskedTextBox2.Focus();
            //    return;
            //    //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            //}

            ////CARGA HORARIA
            //errorProvider1.Clear();
            //if (textBox2.Text.Trim().Length == 0)
            //{
            //    errorProvider1.SetError(textBox2, "A Senha é obrigatória!!");
            //    textBox2.Focus();
            //    toolTip1.SetToolTip(textBox2, "teste");
            //    textBox2.Focus();
            //    return;
            //    //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            //}

            else
            {


                //materiaBindingSource.EndEdit();
                //materiaTableAdapter.Update(GABARITEIDataSet);
                //string v_codigo = textBox1.Text;
                //materiaTableAdapter.Fill(GABARITEIDataSet.materia);
                //int v_posicao = materiaBindingSource.Find("mat_cd", textBox1.Text);
                //materiaBindingSource.Position = v_posicao;
                //materiaBindingSource.AddNew();

                //turmaBindingSource.EndEdit();
                //turmaTableAdapter.Update(GABARITEIDataSet);
                //turmaTableAdapter.Fill(GABARITEIDataSet.turma);
                //turmaBindingSource.AddNew();

                //turmamateriahorarioBindingSource.EndEdit();
                //turma_materia_horarioTableAdapter.Update(GABARITEIDataSet);
                //turma_materia_horarioTableAdapter.Fill(GABARITEIDataSet.turma_materia_horario);
                //turmaBindingSource.AddNew();

                turmamateriaBindingSource.EndEdit();
                turma_materiaTableAdapter.Update(GABARITEIDataSet);
                turma_materiaTableAdapter.Fill(GABARITEIDataSet.turma_materia);
                turmamateriaBindingSource.AddNew();

                classe_PUBLICA.v_acmateriacd3 = "0";
                cmbturmaaBindingSource.EndEdit();
                cmbturmaaBindingSource.AddNew();

                Form v_horariomateria = new frm_cadastro_materias_horario();
                v_horariomateria.ShowDialog();


                this.Close();


                //////////try
                //////////{
                //////////    //this.Validate();
                //////////    //this.materiaBindingSource.EndEdit();
                //////////    //this.funcionarioBindingSource.EndEdit();
                //////////    //this.turmaBindingSource.EndEdit();
                //////////    //this.turmamateriaBindingSource.EndEdit();
                //////////    //this.turmamateriahorarioBindingSource.EndEdit();
                //////////    //this.materiaTableAdapter.Update(this.GABARITEIDataSet.materia);
                //////////    //this.funcionarioTableAdapter.Update(this.GABARITEIDataSet.funcionario);
                //////////    //this.turmaTableAdapter.Update(this.GABARITEIDataSet.turma);
                //////////    //this.turma_materiaTableAdapter.Update(this.GABARITEIDataSet.turma_materia);
                //////////    //this.turma_materia_horarioTableAdapter.Update(this.GABARITEIDataSet.turma_materia_horario);

                //////////    MessageBox.Show("Update successful");


                //////////}
                //////////catch (System.Exception ex)
                //////////{
                //////////    MessageBox.Show("Update failed");
                //////////}

                ////////////MessageBox.Show("teste");
                ////////////livroBindingSource.EndEdit();
                ////////////livroTableAdapter.Update(bibliotecaDataSet);
                ////////////string v_codigo = txb_codigo.Text;
                ////////////livroTableAdapter.Fill(bibliotecaDataSet.livro);

                ////////////// Faz a busca no banco, a coluna que for colocada (liv_cd)
                ////////////int v_posicao = livroBindingSource.Find("liv_cd", txb_codigo.Text);
                //////////////
                ////////////livroBindingSource.Position = v_posicao;
                ////////////habilitar_campos(true);
            }
            // VALIDAÇÃO DE DADOS
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //VALIDAÇÃO DE DADOS
            //PROFESSOR
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

            ////MATERIA
            //errorProvider1.Clear();
            //if (textBox3.Text.Trim().Length == 0)
            //{
            //    errorProvider1.SetError(textBox3, "A Senha é obrigatória!!");
            //    textBox3.Focus();
            //    toolTip1.SetToolTip(textBox3, "teste");
            //    textBox3.Focus();
            //    return;
            //    //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            //}

            //TURMA
            errorProvider1.Clear();
            if (comboBox3.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(comboBox3, "A Senha é obrigatória!!");
                comboBox3.Focus();
                toolTip1.SetToolTip(comboBox3, "teste");
                comboBox3.Focus();
                return;
                //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            ////HORARIO INICIO
            //errorProvider1.Clear();
            //if (maskedTextBox1.Text.Trim().Length == 0)
            //{
            //    errorProvider1.SetError(maskedTextBox1, "A Senha é obrigatória!!");
            //    maskedTextBox1.Focus();
            //    toolTip1.SetToolTip(maskedTextBox1, "teste");
            //    maskedTextBox1.Focus();
            //    return;
            //    //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            //}

            ////HORARIO TERMINO
            //errorProvider1.Clear();
            //if (maskedTextBox2.Text.Trim().Length == 0)
            //{
            //    errorProvider1.SetError(maskedTextBox2, "A Senha é obrigatória!!");
            //    maskedTextBox2.Focus();
            //    toolTip1.SetToolTip(maskedTextBox2, "teste");
            //    maskedTextBox2.Focus();
            //    return;
            //    //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            //}

            ////CARGA HORARIA
            //errorProvider1.Clear();
            //if (textBox2.Text.Trim().Length == 0)
            //{
            //    errorProvider1.SetError(textBox2, "A Senha é obrigatória!!");
            //    textBox2.Focus();
            //    toolTip1.SetToolTip(textBox2, "teste");
            //    textBox2.Focus();
            //    return;
            //    //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            //}

            else
            {
                MessageBox.Show("teste1");
                //livroBindingSource.EndEdit();
                //livroTableAdapter.Update(bibliotecaDataSet);
                //livroTableAdapter.Fill(bibliotecaDataSet.livro);
                //habilitar_campos(false);
                //livroBindingSource.AddNew();
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //classe_PUBLICA.v_acmateriacd2 = "0";
            //Form v_materia = new frm_cadastro_adicao_materia();
            //v_materia.ShowDialog();
            //this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
