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
    public partial class frm_cadastro_funcionario : Form
    {
        public frm_cadastro_funcionario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Para travar os campos, foi somente para teste
            //NAO HABILITAR
            //habilitar_campos(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //CARGO
            errorProvider1.Clear();
            if (comboBox2.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(comboBox2, "O Preenchimento é obrigatório!!");
                comboBox2.Focus();
                toolTip1.SetToolTip(comboBox2, "Preencha este campo com o CARGO do responsável");
                comboBox2.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //DATA DE CADASTRO
            errorProvider1.Clear();
            if (textBox12.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox12, "O Preenchimento é obrigatório!!");
                textBox12.Focus();
                toolTip1.SetToolTip(textBox12, "Preencha este campo com a DATA DE CADASTRO");
                textBox12.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //NOME
            errorProvider1.Clear();
            if (textBox2.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox2, "O Preenchimento é obrigatório!!");
                textBox2.Focus();
                toolTip1.SetToolTip(textBox2, "Preencha este campo com o NOME do funcionário");
                textBox2.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //RG 
            errorProvider1.Clear();
            if (maskedTextBox1.MaskFull == false)
            {
                errorProvider1.SetError(maskedTextBox1, "O Preenchimento é obrigatório!!");
                maskedTextBox1.Focus();
                toolTip1.SetToolTip(maskedTextBox1, "Preencha este campo com o RG do funcionário");
                maskedTextBox1.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //UF
            errorProvider1.Clear();
            if (textBox4.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox4, "O Preenchimento é obrigatório!!");
                textBox4.Focus();
                toolTip1.SetToolTip(textBox4, "Preencha este campo com o UF do funcionário");
                textBox4.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //CPF
            errorProvider1.Clear();
            if (maskedTextBox2.MaskFull == false)
            {
                errorProvider1.SetError(maskedTextBox2, "O Preenchimento é obrigatório!!");
                maskedTextBox2.Focus();
                toolTip1.SetToolTip(maskedTextBox2, "Preencha este campo com o CPF do funcionário");
                maskedTextBox2.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //ORG. EXP
            errorProvider1.Clear();
            if (textBox11.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox11, "O Preenchimento é obrigatório!!");
                textBox11.Focus();
                toolTip1.SetToolTip(textBox11, "Preencha este campo com o ORG. EXP. do funcionário");
                textBox11.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }


            //SEXO
            errorProvider1.Clear();
            if (textBox13.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox13, "O Preenchimento é obrigatório!!");
                textBox13.Focus();
                toolTip1.SetToolTip(textBox13, "Preencha este campo com o SEXO do funcionario");
                textBox13.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //DATA DE NASCIMENTO
            errorProvider1.Clear();
            if (maskedTextBox4.MaskFull == false)
            {
                errorProvider1.SetError(maskedTextBox4, "O Preenchimento é obrigatório!!");
                maskedTextBox4.Focus();
                toolTip1.SetToolTip(maskedTextBox4, "Preencha este campo com a DATA DE NASCIMENTO do funcionário");
                maskedTextBox4.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //TELEFONE
            errorProvider1.Clear();
            if (maskedTextBox5.MaskFull == false)
            {
                errorProvider1.SetError(maskedTextBox5, "O Preenchimento é obrigatório!!");
                maskedTextBox5.Focus();
                toolTip1.SetToolTip(maskedTextBox5, "Preencha este campo com o TELEFONE do funcionário");
                maskedTextBox5.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //CEP
            errorProvider1.Clear();
            if (maskedTextBox6.MaskFull == false)
            {
                errorProvider1.SetError(maskedTextBox6, "O Preenchimento é obrigatório!!");
                maskedTextBox6.Focus();
                toolTip1.SetToolTip(maskedTextBox6, "Preencha este campo com o CEP do funcionário");
                maskedTextBox6.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //CIDADE
            errorProvider1.Clear();
            if (comboBox5.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(comboBox5, "O Preenchimento é obrigatório!!");
                comboBox5.Focus();
                toolTip1.SetToolTip(comboBox5, "Preencha este campo com a CIDADE do funcionário");
                comboBox5.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //RUA
            errorProvider1.Clear();
            if (textBox8.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox8, "O Preenchimento é obrigatório!!");
                textBox8.Focus();
                toolTip1.SetToolTip(textBox8, "Preencha este campo com a RUA do funcionário");
                textBox8.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //BAIRRO
            //errorProvider1.Clear();
            //if (comboBox6.Text.Trim().Length == 0)
            //{
            //    errorProvider1.SetError(comboBox6, "O Preenchimento é obrigatório!!");
            //    comboBox6.Focus();
            //    toolTip1.SetToolTip(comboBox6, "Preencha este campo com o BAIRRO do funcionário");
            //    comboBox6.Focus();
            //    return;
            //    ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            //}

            //N
            errorProvider1.Clear();
            if (textBox9.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox9, "O Preenchimento é obrigatório!!");
                textBox9.Focus();
                toolTip1.SetToolTip(textBox9, "Preencha este campo com o N do funcionário");
                textBox9.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //COMPLEMENTO
            errorProvider1.Clear();
            if (textBox10.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox10, "O Preenchimento é obrigatório!!");
                textBox10.Focus();
                toolTip1.SetToolTip(textBox10, "Preencha este campo com o COMPLEMENTO do funcionário");
                textBox10.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }



            ////NOME
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

            ////CARGO
            //errorProvider1.Clear();
            //if (comboBox2.Text.Trim().Length == 0)
            //{
            //    errorProvider1.SetError(comboBox2, "A Senha é obrigatória!!");
            //    comboBox2.Focus();
            //    toolTip1.SetToolTip(comboBox2, "teste");
            //    comboBox2.Focus();
            //    return;
            //    //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            //}

            ////RG
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

            ////TELEFONE
            //errorProvider1.Clear();
            //if (maskedTextBox5.Text.Trim().Length == 0)
            //{
            //    errorProvider1.SetError(maskedTextBox5, "A Senha é obrigatória!!");
            //    maskedTextBox5.Focus();
            //    toolTip1.SetToolTip(maskedTextBox5, "teste");
            //    maskedTextBox5.Focus();
            //    return;
            //    //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            //}


            ////USUARIO
            //errorProvider1.Clear();
            //if (textBox5.Text.Trim().Length == 0)
            //{
            //    errorProvider1.SetError(textBox5, "A Senha é obrigatória!!");
            //    textBox5.Focus();
            //    toolTip1.SetToolTip(textBox5, "teste");
            //    textBox5.Focus();
            //    return;
            //    //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            //}


            ////SENHA
            //errorProvider1.Clear();
            //if (textBox6.Text.Trim().Length == 0)
            //{
            //    errorProvider1.SetError(textBox6, "A Senha é obrigatória!!");
            //    textBox6.Focus();
            //    toolTip1.SetToolTip(textBox6, "teste");
            //    textBox6.Focus();
            //    return;
            //    //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            //}


            ////TIPO DE USUARIO
            //errorProvider1.Clear();
            //if (comboBox3.Text.Trim().Length == 0)
            //{
            //    errorProvider1.SetError(comboBox3, "A Senha é obrigatória!!");
            //    comboBox3.Focus();
            //    toolTip1.SetToolTip(comboBox3, "teste");
            //    comboBox3.Focus();
            //    return;
            //    //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            //}


            ////SITUAÇÃO DO CADASTRO
            //errorProvider1.Clear();
            //if (comboBox4.Text.Trim().Length == 0)
            //{
            //    errorProvider1.SetError(comboBox4, "A Senha é obrigatória!!");
            //    comboBox4.Focus();
            //    toolTip1.SetToolTip(comboBox4, "teste");
            //    comboBox4.Focus();
            //    return;
            //    //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            //}

            

            else
            {
                // Funcionario
                funcionarioBindingSource.EndEdit();
                funcionarioTableAdapter.Update(GABARITEIDataSet);
                //string v_codigo = textBox1.Text;


                //Pega o primeiro código (chave primaria) 
                funcionarioTableAdapter.Fill(GABARITEIDataSet.funcionario);

                //Move para o ultimo código
                funcionarioBindingSource.MoveLast();



                logradouroBindingSource.EndEdit();
                logradouroTableAdapter.Update(GABARITEIDataSet); 
                logradouroTableAdapter.Fill(GABARITEIDataSet.logradouro);

                //// Faz a busca no banco, a coluna que for colocada (liv_cd)
                //int v_posicao = funcionarioBindingSource.Find("fun_cd", v_codigo);
                //funcionarioBindingSource.Position = v_posicao;
                //habilitar_campos(true);
                this.Visible = false;

                classe_PUBLICA.v_cafuncd = "0";

                //LOGIN
                //loginnBindingSource.EndEdit();
                //loginnTableAdapter.Update(GABARITEIDataSet);
                ////string v_codigo2 = textBox14.Text;
                //loginnTableAdapter.Fill(GABARITEIDataSet.loginn);
                //loginnBindingSource.MoveLast();
                //////// Faz a busca no banco, a coluna que for colocada (liv_cd)
                ////int v_posicao2 = loginnBindingSource.Find("loginn", v_codigo2);
                ////loginnBindingSource.Position = v_posicao2;
                //habilitar_campos(true);
                //this.Visible = false;

                if (MessageBox.Show("Você deseja fazer uma conta de loguin para este usuário?", "Criação de conta do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   
                    Form v_cadastrofun = new frm_cadastro_login();
                    v_cadastrofun.ShowDialog();
                }


                //try
                //{
                //    this.Validate();
                //    this.funcionarioBindingSource.EndEdit();
                //    this.funcionarioTableAdapter.Update(this.GABARITEIDataSet.funcionario);
                //    MessageBox.Show("Update successful");
                //}
                //catch (System.Exception ex)
                //{
                //    MessageBox.Show("Update failed");
                //}


                //Login
                //loginnBindingSource.EndEdit();
                //loginnTableAdapter.Update(GABARITEIDataSet);
                //string v_codigo = textBox11.Text;
                //loginnTableAdapter.Fill(GABARITEIDataSet.loginn);
                ////// Faz a busca no banco, a coluna que for colocada (liv_cd)
                //int v_posicao = loginnBindingSource.Find("loginn", textBox11.Text);
                //loginnBindingSource.Position = v_posicao;
                //habilitar_campos(true);
                //this.Visible = false;
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Para travar os campos, foi somente para teste
            //NAO HABILITAR
            //this.Visible = false;

            //CANCELAR
            this.Close();
            //this.Visible = false;
            habilitar_campos(true);
            // (NOMEDOBANCODEDADOS).CancelEdit();
        }

        private void tela_de_cadastro_login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GABARITEIDataSet.end_residencial' table. You can move, or remove it, as needed.
            this.end_residencialTableAdapter.Fill(this.GABARITEIDataSet.end_residencial);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.logradouro' table. You can move, or remove it, as needed.
            this.logradouroTableAdapter.Fill(this.GABARITEIDataSet.logradouro);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.cidade' table. You can move, or remove it, as needed.
            this.cidadeTableAdapter.Fill(this.GABARITEIDataSet.cidade);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.cargo' table. You can move, or remove it, as needed.
            this.cargoTableAdapter.Fill(this.GABARITEIDataSet.cargo);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.funcionario' table. You can move, or remove it, as needed.
 
            // TODO: This line of code loads data into the 'GABARITEIDataSet.loginn' table. You can move, or remove it, as needed.
            this.loginnTableAdapter.Fill(this.GABARITEIDataSet.loginn);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.bairro' table. You can move, or remove it, as needed.
            //this.bairroTableAdapter.Fill(this.GABARITEIDataSet.bairro);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.end_residencial' table. You can move, or remove it, as needed.
            this.end_residencialTableAdapter.Fill(this.GABARITEIDataSet.end_residencial);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.logradouro' table. You can move, or remove it, as needed.
            this.logradouroTableAdapter.Fill(this.GABARITEIDataSet.logradouro);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.cidade' table. You can move, or remove it, as needed.
            this.cidadeTableAdapter.Fill(this.GABARITEIDataSet.cidade);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.end_residencial' table. You can move, or remove it, as needed.
            this.end_residencialTableAdapter.Fill(this.GABARITEIDataSet.end_residencial);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.cargo' table. You can move, or remove it, as needed.
            this.cargoTableAdapter.Fill(this.GABARITEIDataSet.cargo);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.funcionario' table. You can move, or remove it, as needed.
            //this.funcionarioTableAdapter.Fill(this.GABARITEIDataSet.funcionario);




            //FAZ COM QUE PEGUE A DATA ATUAL DO COMPUTADOR
            textBox12.Text = DateTime.Now.ToShortDateString();







            // TODO: This line of code loads data into the 'GABARITEIDataSet.aluno' table. You can move, or remove it, as needed.
            //this.alunoTableAdapter.Fill(this.GABARITEIDataSet.aluno);
            //// TODO: This line of code loads data into the 'GABARITEIDataSet.loginn' table. You can move, or remove it, as needed.
            //this.loginnTableAdapter.Fill(this.GABARITEIDataSet.loginn);
            //// TODO: This line of code loads data into the 'GABARITEIDataSet.cargo' table. You can move, or remove it, as needed.
            //this.cargoTableAdapter.Fill(this.GABARITEIDataSet.cargo);
            //// TODO: This line of code loads data into the 'GABARITEIDataSet.funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.GABARITEIDataSet.funcionario);




            if (classe_PUBLICA.v_funcd == "0")
            {
                funcionarioBindingSource.AddNew();
                loginnBindingSource.AddNew();
                endresidencialBindingSource.AddNew();
                //FAZ COM QUE PEGUE A DATA ATUAL DO COMPUTADOR

            }
            else
            {
                //FAZ COM QUE PEGUE A DATA ATUAL DO COMPUTADOR
                //textBox3.Text = DateTime.Now.ToShortDateString();

                //Faz o filtro dentro do Bindingsource, em que, na coluna ALU_CD da tabela ALUNO
                // será "=" somado ao resto ( classe_PUBLICA.v_alunocd é o que verificará a contagem) 

                //DESCOMENTAR ESTA LINHA | DESCOMENTAR ESTA LINHA |DESCOMENTAR ESTA LINHA |DESCOMENTAR ESTA LINHA |
                funcionarioBindingSource.Filter = "fun_cd  = " + classe_PUBLICA.v_funcd;
                //loginnBindingSource.Filter = "loginn = " + classe_PUBLICA.v_funcd;
                //endresidencialBindingSource.Filter = "end_cd  = " + classe_PUBLICA.v_funcd;
                //DESCOMENTAR ESTA LINHA | DESCOMENTAR ESTA LINHA |DESCOMENTAR ESTA LINHA |DESCOMENTAR ESTA LINHA |
            }
        }
        private void habilitar_campos(Boolean v_opcao)
        {
            // Para travar os campos, foi somente para teste
            //NAO HABILITAR
            //gb_DadosPessoais_cad_fun.Enabled = !v_opcao;
            //gb_CadLogin_cad_fun.Enabled = !v_opcao;

        }

        private void btn_limpar_cad_fun_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "";
            textBox2.Text = "";
            textBox12.Text = "";
            maskedTextBox1.Text = "";
            textBox4.Text = "";
            maskedTextBox2.Text = "";
            textBox11.Text = "";
            textBox13.Text = "";
            maskedTextBox4.Text = "";
            //textBox3.Text = "";
            maskedTextBox5.Text = "";
            //maskedTextBox3.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            maskedTextBox6.Text = "";
            //comboBox6.Text = "";
            textBox10.Text = "";
            comboBox5.Text = "";



            habilitar_campos(false);
            // (NOMEDOBANCODEDADOS) livroBindingSource.AddNew();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //NOME
            errorProvider1.Clear();
            if (textBox2.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox2, "A Senha é obrigatória!!");
                textBox2.Focus();
                toolTip1.SetToolTip(textBox2, "teste");
                textBox2.Focus();
                return;
                //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //CARGO
            errorProvider1.Clear();
            if (comboBox2.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(comboBox2, "A Senha é obrigatória!!");
                comboBox2.Focus();
                toolTip1.SetToolTip(comboBox2, "teste");
                comboBox2.Focus();
                return;
                //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //RG
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

            //TELEFONE
            errorProvider1.Clear();
            if (maskedTextBox5.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(maskedTextBox5, "A Senha é obrigatória!!");
                maskedTextBox5.Focus();
                toolTip1.SetToolTip(maskedTextBox5, "teste");
                maskedTextBox5.Focus();
                return;
                //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }


            ////USUARIO
            //errorProvider1.Clear();
            //if (textBox5.Text.Trim().Length == 0)
            //{
            //    errorProvider1.SetError(textBox5, "A Senha é obrigatória!!");
            //    textBox5.Focus();
            //    toolTip1.SetToolTip(textBox5, "teste");
            //    textBox5.Focus();
            //    return;
            //    //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            //}


            ////SENHA
            //errorProvider1.Clear();
            //if (textBox6.Text.Trim().Length == 0)
            //{
            //    errorProvider1.SetError(textBox6, "A Senha é obrigatória!!");
            //    textBox6.Focus();
            //    toolTip1.SetToolTip(textBox6, "teste");
            //    textBox6.Focus();
            //    return;
            //    //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            //}


            ////TIPO DE USUARIO
            //errorProvider1.Clear();
            //if (comboBox3.Text.Trim().Length == 0)
            //{
            //    errorProvider1.SetError(comboBox3, "A Senha é obrigatória!!");
            //    comboBox3.Focus();
            //    toolTip1.SetToolTip(comboBox3, "teste");
            //    comboBox3.Focus();
            //    return;
            //    //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            //}


            ////SITUAÇÃO DO CADASTRO
            //errorProvider1.Clear();
            //if (comboBox4.Text.Trim().Length == 0)
            //{
            //    errorProvider1.SetError(comboBox4, "A Senha é obrigatória!!");
            //    comboBox4.Focus();
            //    toolTip1.SetToolTip(comboBox4, "teste");
            //    comboBox4.Focus();
            //    return;
            //    //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            //}



            else
            {

                //// Funcionario
                funcionarioBindingSource.EndEdit();
                funcionarioTableAdapter.Update(GABARITEIDataSet);
                //string v_codigo = textBox1.Text;
                //funcionarioTableAdapter.Fill(GABARITEIDataSet.funcionario);
                ////// Faz a busca no banco, a coluna que for colocada (liv_cd)
                //int v_posicao = funcionarioBindingSource.Find("fun_cd", textBox1.Text);
                //funcionarioBindingSource.Position = v_posicao;
                //habilitar_campos(true);
                //this.Visible = false;
                funcionarioBindingSource.AddNew();

                //Cidade

                //Login

                loginnBindingSource.EndEdit();
                loginnTableAdapter.Update(GABARITEIDataSet);
                //string v_codigo2 = textBox14.Text;
                //loginnTableAdapter.Fill(GABARITEIDataSet.loginn);
                ////// Faz a busca no banco, a coluna que for colocada (liv_cd)
                //int v_posicao2 = loginnBindingSource.Find("loginn", v_codigo2);
                //loginnBindingSource.Position = v_posicao2;
                //habilitar_campos(true);
                //this.Visible = false;
                loginnBindingSource.AddNew();
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //testeloguin v_testeloguin = new testeloguin();
            //v_testeloguin.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox12_Click(object sender, EventArgs e)
        {
            textBox12.Text = DateTime.Now.ToShortDateString();
        }

        private void gb_DadosPessoais_cad_fun_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            




        }
    }
}
