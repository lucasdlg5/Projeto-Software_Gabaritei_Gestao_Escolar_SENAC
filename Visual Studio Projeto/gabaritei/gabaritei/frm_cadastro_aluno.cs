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
    public partial class frm_cadastro_aluno : Form
    {
        public frm_cadastro_aluno()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            ////FAZ COM QUE PEGUE A DATA ATUAL DO COMPUTADOR
            //textBox3.Text = DateTime.Now.ToShortDateString();
        }

        private void cadastro_alu_certo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GABARITEIDataSet.aluno_telefone' table. You can move, or remove it, as needed.
            //this.aluno_telefoneTableAdapter.Fill(this.GABARITEIDataSet.aluno_telefone);
            //// TODO: This line of code loads data into the 'GABARITEIDataSet.aluno_telefone' table. You can move, or remove it, as needed.
            //this.aluno_telefoneTableAdapter.Fill(this.GABARITEIDataSet.aluno_telefone);
            //// TODO: This line of code loads data into the 'gABARITEIDataSet1.tipo_responsavel' table. You can move, or remove it, as needed.
            //this.tipo_responsavelTableAdapter.Fill(this.gABARITEIDataSet1.tipo_responsavel);
            //// TODO: This line of code loads data into the 'gABARITEIDataSet1.aluno_reponsavel' table. You can move, or remove it, as needed.
            //this.aluno_reponsavelTableAdapter.Fill(this.gABARITEIDataSet1.aluno_reponsavel);
            //// TODO: This line of code loads data into the 'gABARITEIDataSet1.view_cadastro_resp' table. You can move, or remove it, as needed.
            //this.view_cadastro_respTableAdapter.Fill(this.gABARITEIDataSet1.view_cadastro_resp);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.view_cadastro_resp' table. You can move, or remove it, as needed.
            //this.view_cadastro_respTableAdapter.Fill(this.GABARITEIDataSet.view_cadastro_resp);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.reponsavel' table. You can move, or remove it, as needed.
            //this.reponsavelTableAdapter.Fill(this.GABARITEIDataSet.reponsavel);
            //// TODO: This line of code loads data into the 'GABARITEIDataSet.View_tipo_telefone_responsavel' table. You can move, or remove it, as needed.
            //this.view_tipo_telefone_responsavelTableAdapter.Fill(this.GABARITEIDataSet.View_tipo_telefone_responsavel);
            //// TODO: This line of code loads data into the 'GABARITEIDataSet.tipo_telefone' table. You can move, or remove it, as needed.
            //this.tipo_telefoneTableAdapter.Fill(this.GABARITEIDataSet.tipo_telefone);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.cmb_tipotelefone' table. You can move, or remove it, as needed.




            // TODO: This line of code loads data into the 'GABARITEIDataSet.view_lsita_resp' table. You can move, or remove it, as needed.
            //this.view_lsita_respTableAdapter.Fill(this.GABARITEIDataSet.view_lsita_resp);





            // TODO: This line of code loads data into the 'GABARITEIDataSet.end_residencial' table. You can move, or remove it, as needed.
            //this.end_residencialTableAdapter.Fill(this.GABARITEIDataSet.end_residencial);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.cidade' table. You can move, or remove it, as needed.
            this.cidadeTableAdapter.Fill(this.GABARITEIDataSet.cidade);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.logradouro' table. You can move, or remove it, as needed.
            //this.logradouroTableAdapter.Fill(this.GABARITEIDataSet.logradouro);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.tb_matricula' table. You can move, or remove it, as needed.
            //this.tb_matriculaTableAdapter.Fill(this.GABARITEIDataSet.tb_matricula);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.turma' table. You can move, or remove it, as needed.
            //this.turmaTableAdapter.Fill(this.GABARITEIDataSet.turma);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.aluno' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'GABARITEIDataSet.telefone_responsavel' table. You can move, or remove it, as needed.
            //carrega os dados da tabela ao carregar o form (pode-se colocar no botão para recarregar os dados)
            //this.telefone_responsavelTableAdapter.Fill(this.GABARITEIDataSet.telefone_responsavel);
            //// TODO: This line of code loads data into the 'GABARITEIDataSet.tipo_responsavel' table. You can move, or remove it, as needed.
            //this.tipo_responsavelTableAdapter.Fill(this.GABARITEIDataSet.tipo_responsavel);
            //// TODO: This line of code loads data into the 'GABARITEIDataSet.tipo_telefone' table. You can move, or remove it, as needed.
            //this.tipo_telefoneTableAdapter.Fill(this.GABARITEIDataSet.tipo_telefone);
            //// TODO: This line of code loads data into the 'GABARITEIDataSet.end_residencial' table. You can move, or remove it, as needed.
            //this.end_residencialTableAdapter.Fill(this.GABARITEIDataSet.end_residencial);
            //// TODO: This line of code loads data into the 'GABARITEIDataSet.cidade' table. You can move, or remove it, as needed.
            //this.cidadeTableAdapter.Fill(this.GABARITEIDataSet.cidade);
            //this.aluno_telefoneTableAdapter.Fill(this.GABARITEIDataSet.aluno_telefone);



            // TODO: This line of code loads data into the 'GABARITEIDataSet.aluno_telefone' table. You can move, or remove it, as needed.
            //this.aluno_telefoneTableAdapter.Fill(this.GABARITEIDataSet.aluno_telefone);
            //// TODO: This line of code loads data into the 'GABARITEIDataSet.aluno_reponsavel' table. You can move, or remove it, as needed.
            //this.aluno_reponsavelTableAdapter.Fill(this.GABARITEIDataSet.aluno_reponsavel);
            //// TODO: This line of code loads data into the 'GABARITEIDataSet.logradouro' table. You can move, or remove it, as needed.
            //this.logradouroTableAdapter.Fill(this.GABARITEIDataSet.logradouro);
            //// TODO: This line of code loads data into the 'GABARITEIDataSet.bairro' table. You can move, or remove it, as needed.
            //this.bairroTableAdapter.Fill(this.GABARITEIDataSet.bairro);




            // TODO: This line of code loads data into the 'GABARITEIDataSet.reponsavel' table. You can move, or remove it, as needed.
            //this.reponsavelTableAdapter.Fill(this.GABARITEIDataSet.reponsavel);
            //// TODO: This line of code loads data into the 'GABARITEIDataSet.aluno' table. You can move, or remove it, as needed.

            ////DESCOMENTAR ESTA LINHA | DESCOMENTAR ESTA LINHA |DESCOMENTAR ESTA LINHA |DESCOMENTAR ESTA LINHA |
            this.alunoTableAdapter.Fill(this.GABARITEIDataSet.aluno);
            ////DESCOMENTAR ESTA LINHA | DESCOMENTAR ESTA LINHA |DESCOMENTAR ESTA LINHA |DESCOMENTAR ESTA LINHA |

            //Condição IF para a adição de uma nova linha na tabela CASO o valor armazenado em
            //v_alunocd seja 0 (caso não cliquemos em uma linha na form, e selecionarmos um codigo
            //da tabela e fosse clicado em EDITAR, verificará essa contagem.
            //Se for 0, Fará um novo registro,
            //Senão entrará no registro do cógico selecionado para editar

            textBox3.Text = DateTime.Now.ToShortDateString().ToString();
            
            if (classe_PUBLICA.v_alunocd == "0")
            {
                //alunotelefoneBindingSource.AddNew();
                alunoBindingSource.AddNew();
                //endresidencialBindingSource.AddNew();
                //reponsavelBindingSource.AddNew();

                //FAZ COM QUE PEGUE A DATA ATUAL DO COMPUTADOR

                //alunoBindingSource.AddNew();
                //reponsavelBindingSource.AddNew();

            }

            else
            {

                //alunoBindingSource.Filter = "[Nome do aluno]  = " + classe_PUBLICA.v_alunocd3;
                //classe_PUBLICA.v_alunocd = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                //alunoBindingSource.Filter = "alu_cd  = " + classe_PUBLICA.v_alunocd;
                alunoBindingSource.Filter = "alu_cd = " + classe_PUBLICA.v_alunocd;
               
                //alunoBindingSource.Filter = "resp_cd  = " + classe_PUBLICA.v_responcd;
                //alunoBindingSource.Filter = "alu_cd  = " + classe_PUBLICA.v_responcd;
                //endresidencialBindingSource.Filter = "alu_cd  = " + classe_PUBLICA.v_alunocd;
                //alunotelefoneBindingSource.Filter = "alu_cd = " + classe_PUBLICA.v_alunocd;

                //endresidencialBindingSource.Filter = "end_cd  = " + classe_PUBLICA.v_alunocd;
                //alunotelefoneBindingSource.Filter = "alut_cd = " + classe_PUBLICA.v_alunocd;
                //FAZ COM QUE PEGUE A DATA ATUAL DO COMPUTADOR
                //textBox3.Text = DateTime.Now.ToShortDateString();

                //Faz o filtro dentro do Bindingsource, em que, na coluna ALU_CD da tabela ALUNO
                // será "=" somado ao resto ( classe_PUBLICA.v_alunocd é o que verificará a contagem) 

                //DESCOMENTAR ESTA LINHA | DESCOMENTAR ESTA LINHA |DESCOMENTAR ESTA LINHA |DESCOMENTAR ESTA LINHA |


                //reponsavelBindingSource.Filter = "resp_cd  = " + classe_PUBLICA.v_responcd;


                //alunoBindingSource.Filter = "alu_cd  = " + classe_PUBLICA.v_alunocd;
                //telefoneresponsavelBindingSource.Filter = "alut_cd  = " + classe_PUBLICA.v_alutcd;
                //DESCOMENTAR ESTA LINHA | DESCOMENTAR ESTA LINHA |DESCOMENTAR ESTA LINHA |DESCOMENTAR ESTA LINHA |
            }
            //txb_nome_aluno_cad_aluno.Text = DateTime.Now.ToShortDateString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //CANCELAR
            this.Visible = false;
            habilitar_campos(true);
            // (NOMEDOBANCODEDADOS).CancelEdit();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CANCELAR
            this.Visible = false;
            habilitar_campos(true);
            // (NOMEDOBANCODEDADOS).CancelEdit();


        }

        private void habilitar_campos(Boolean v_opcao)
        {

            tbp_aluno_cad_aluno.Enabled = !v_opcao;

            // .Enabled = !v_opcao;

        }

        private void btn_salvar_cad_aluno_Click(object sender, EventArgs e)
        {

            //(NOMEDOBANCODEDADOS) livroBindingSource.EndEdit();
            //(NOMEDOBANCODEDADOS) livroTableAdapter.Update((NOMEDOBANCODEDADOS) bibliotecaDataSet);
            //string v_codigo = txb_codigo.Text;
            //(NOMEDOBANCODEDADOS) livroTableAdapter.Fill((NOMEDOBANCODEDADOS) bibliotecaDataSet.livro);

            //// Faz a busca no banco, a coluna que for colocada (liv_cd)
            //int v_posicao = (NOMEDOBANCODEDADOS) livroBindingSource.Find("(COLUNADECODICODOBANCODEDADOS) liv_cd", txb_codigo.Text);
            ////
            //(NOMEDOBANCODEDADOS) livroBindingSource.Position = v_posicao;
            habilitar_campos(true);
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void btn_novo_cad_aluno_Click(object sender, EventArgs e)
        {
            //(COLOCAROBANCODEDADOS) livroBindingSource.EndEdit();
            //(COLOCAROBANCODEDADOS) livroTableAdapter.Update((COLOCARBANCODEDADOS)bibliotecaDataSet);
            //(COLOCAROBANCODEDADOS) livroTableAdapter.Fill((COLOCARBANCODEDADOS)bibliotecaDataSet.livro);
            habilitar_campos(false);
            // (NOMEDOBANCODEDADOS) livroBindingSource.AddNew();


        }

        private void btn_salvar_cad_responsaveis_Click(object sender, EventArgs e)
        {
            //(NOMEDOBANCODEDADOS) livroBindingSource.EndEdit();
            //(NOMEDOBANCODEDADOS) livroTableAdapter.Update((NOMEDOBANCODEDADOS) bibliotecaDataSet);
            //string v_codigo = txb_codigo.Text;
            //(NOMEDOBANCODEDADOS) livroTableAdapter.Fill((NOMEDOBANCODEDADOS) bibliotecaDataSet.livro);

            //// Faz a busca no banco, a coluna que for colocada (liv_cd)
            //int v_posicao = (NOMEDOBANCODEDADOS) livroBindingSource.Find("(COLUNADECODICODOBANCODEDADOS) liv_cd", txb_codigo.Text);
            ////
            //(NOMEDOBANCODEDADOS) livroBindingSource.Position = v_posicao;
            habilitar_campos(true);
            this.Visible = false;
        }

        private void btn_novo_cad_responsaveis_Click(object sender, EventArgs e)
        {
            //(COLOCAROBANCODEDADOS) livroBindingSource.EndEdit();
            //(COLOCAROBANCODEDADOS) livroTableAdapter.Update((COLOCARBANCODEDADOS)bibliotecaDataSet);
            //(COLOCAROBANCODEDADOS) livroTableAdapter.Fill((COLOCARBANCODEDADOS)bibliotecaDataSet.livro);
            habilitar_campos(false);
            // (NOMEDOBANCODEDADOS) livroBindingSource.AddNew();


        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btn_salvar_cad_aluno_Click_1(object sender, EventArgs e)
        {

           





            //PRIMEIRO METODO De VALIDAÇÃO De CAMPOS
            //string nome = this.txb_nome_aluno_cad_aluno.Text.TrimEnd();
            //if (string.IsNullOrEmpty(nome))
            //{ this.errorProvider1.SetError(this.txb_nome_aluno_cad_aluno," O Nome é obrigatório!"); }



            //Segundo metodo de validação de campos

            // NOME DO ALUNO
            errorProvider1.Clear();
            if (txb_nome_aluno_cad_aluno.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txb_nome_aluno_cad_aluno, "O Preenchimento é obrigatório!!");
                txb_nome_aluno_cad_aluno.Focus();
                toolTip1.SetToolTip(txb_nome_aluno_cad_aluno, "Preencha este campo com o NOME do Aluno");
                txb_nome_aluno_cad_aluno.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //RG DO ALUNO
            errorProvider1.Clear();
            if (mtb_rg_aluno_cad_aluno.MaskFull == false)
            {
                errorProvider1.SetError(mtb_rg_aluno_cad_aluno, "O Preenchimento é obrigatório!!");
                mtb_rg_aluno_cad_aluno.Focus();
                toolTip1.SetToolTip(mtb_rg_aluno_cad_aluno, "Preencha este campo com o NOME do Aluno");
                mtb_rg_aluno_cad_aluno.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //RUA ENDEREÇO ALUNO
            errorProvider1.Clear();
            if (txb_rua_end_cad_aluno.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txb_rua_end_cad_aluno, "O Preenchimento é obrigatório!!");
                txb_rua_end_cad_aluno.Focus();
                toolTip1.SetToolTip(txb_rua_end_cad_aluno, "Preencha este campo com o ENDEREÇO DE RUA do Aluno");
                txb_rua_end_cad_aluno.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //SEXO
            errorProvider1.Clear();
            if (cmb_aluno_cad_aluno.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(cmb_aluno_cad_aluno, "O Preenchimento é obrigatório!!");
                cmb_aluno_cad_aluno.Focus();
                toolTip1.SetToolTip(cmb_aluno_cad_aluno, "Preencha este campo com o SEXO do Aluno");
                cmb_aluno_cad_aluno.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //UF RG
            errorProvider1.Clear();
            if (cmb_UF_cad_aluno.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(cmb_UF_cad_aluno, "O Preenchimento é obrigatório!!");
                cmb_UF_cad_aluno.Focus();
                toolTip1.SetToolTip(cmb_UF_cad_aluno, "Preencha este campo com o UF DO RG do Aluno");
                cmb_UF_cad_aluno.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //ORG EXP.
            errorProvider1.Clear();
            if (textBox11.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox11, "O Preenchimento é obrigatório!!");
                textBox11.Focus();
                toolTip1.SetToolTip(textBox11, "Preencha este campo com o ORG. EXP. do Aluno");
                textBox11.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //DATA NASCIMENTO
            errorProvider1.Clear();
            if (maskedTextBox2.MaskFull == false)
            {
                errorProvider1.SetError(maskedTextBox2, "O Preenchimento é obrigatório!!");
                maskedTextBox2.Focus();
                toolTip1.SetToolTip(maskedTextBox2, "Preencha este campo com a DATA DE NASCIMENTO do Aluno");
                maskedTextBox2.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //CPF
            errorProvider1.Clear();
            if (mtb_cpf_aluno_cad_aluno.MaskFull == false)
            {
                errorProvider1.SetError(mtb_cpf_aluno_cad_aluno, "O Preenchimento é obrigatório!!");
                mtb_cpf_aluno_cad_aluno.Focus();
                toolTip1.SetToolTip(mtb_cpf_aluno_cad_aluno, "Preencha este campo com o CPF do Aluno");
                mtb_cpf_aluno_cad_aluno.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //DATA INSCRIÇÃO ALUNO
            errorProvider1.Clear();
            if (textBox3.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox3, "O Preenchimento é obrigatório!!");
                textBox3.Focus();
                toolTip1.SetToolTip(textBox3, "Preencha este campo com a INSCRIÇÃO DO ALUNO do Aluno");
                textBox3.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //CIDADE
            errorProvider1.Clear();
            if (cmb_cid_end_cad_aluno.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(cmb_cid_end_cad_aluno, "O Preenchimento é obrigatório!!");
                cmb_cid_end_cad_aluno.Focus();
                toolTip1.SetToolTip(cmb_cid_end_cad_aluno, "Preencha este campo com q CIDADE do Aluno");
                cmb_cid_end_cad_aluno.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //BAIRRO
            errorProvider1.Clear();
            if (txb_bairro_end_cad_aluno.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txb_bairro_end_cad_aluno, "O Preenchimento é obrigatório!!");
                txb_bairro_end_cad_aluno.Focus();
                toolTip1.SetToolTip(txb_bairro_end_cad_aluno, "Preencha este campo com o BAIRRO do Aluno");
                txb_bairro_end_cad_aluno.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //EMAIL
            errorProvider1.Clear();
            if (txb_email_contato_cad_aluno.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txb_email_contato_cad_aluno, "O Preenchimento é obrigatório!!");
                txb_email_contato_cad_aluno.Focus();
                toolTip1.SetToolTip(txb_email_contato_cad_aluno, "Preencha este campo com o EMAIL do Aluno");
                txb_email_contato_cad_aluno.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //COMPLEMENTO
            errorProvider1.Clear();
            if (txb_complemento_end_cad_aluno.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txb_complemento_end_cad_aluno, "O Preenchimento é obrigatório!!");
                txb_complemento_end_cad_aluno.Focus();
                toolTip1.SetToolTip(txb_complemento_end_cad_aluno, "Preencha este campo com o COMPLEMENTO do Aluno");
                txb_complemento_end_cad_aluno.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //NUMERO CASA
            errorProvider1.Clear();
            if (txb_no_end_cad_aluno.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txb_no_end_cad_aluno, "O Preenchimento é obrigatório!!");
                txb_no_end_cad_aluno.Focus();
                toolTip1.SetToolTip(txb_no_end_cad_aluno, "Preencha este campo com o N. DA CASA do Aluno");
                txb_no_end_cad_aluno.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }



            //CEP
            errorProvider1.Clear();
            if (maskedTextBox4.MaskFull == false)
            {
                errorProvider1.SetError(maskedTextBox4, "O Preenchimento é obrigatório!!");
                maskedTextBox4.Focus();
                toolTip1.SetToolTip(maskedTextBox4, "Preencha este campo com o CEP do Aluno");
                maskedTextBox4.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            else
            {



                alunoBindingSource.EndEdit();
                alunoTableAdapter.Update(GABARITEIDataSet);
                alunoTableAdapter.Fill(GABARITEIDataSet.aluno);
                alunoBindingSource.MoveLast();
                //string v_codigo = txb_codigo_aluno_cad_aluno.Text;
                ////// Faz a busca no banco, a coluna que for colocada (liv_cd)
                //int v_posicao = alunoBindingSource.Find("alu_cd", txb_codigo_aluno_cad_aluno.Text);
                //alunoBindingSource.Position = v_posicao;
                //habilitar_campos(true);
                //this.Visible = false;

                cidadeBindingSource.EndEdit();
               cidadeTableAdapter.Update(GABARITEIDataSet);
                cidadeTableAdapter.Fill(GABARITEIDataSet.cidade);

                //endresidencialBindingSource.EndEdit();
                ////end_residencialTableAdapter.Update(GABARITEIDataSet);
                ////string v_codigo = txb_codigo_aluno_cad_aluno.Text;
                //end_residencialTableAdapter.Fill(GABARITEIDataSet.end_residencial);
                //////// Faz a busca no banco, a coluna que for colocada (liv_cd)
                ////int v_posicao = alunoBindingSource.Find("alu_cd", txb_codigo_aluno_cad_aluno.Text);
                ////alunoBindingSource.Position = v_posicao;
                ////habilitar_campos(true);
                ////this.Visible = false;

                //logradouroBindingSource.EndEdit();
                //logradouroTableAdapter.Update(GABARITEIDataSet);
                ////string v_codigo = txb_codigo_aluno_cad_aluno.Text;
                //logradouroTableAdapter.Fill(GABARITEIDataSet.logradouro);
                ////// Faz a busca no banco, a coluna que for colocada (liv_cd)
                //int v_posicao = alunoBindingSource.Find("alu_cd", txb_codigo_aluno_cad_aluno.Text);
                //alunoBindingSource.Position = v_posicao;
                //habilitar_campos(true);


                //classe_PUBLICA.v_alunocd4 = "1";
                //alunoBindingSource.Filter = "alu_cd  = " + classe_PUBLICA.v_alunocd4;

                classe_PUBLICA.v_alunocd4 = txb_codigo_aluno_cad_aluno.Text;
                Form v_responsavel = new frm_cadastro_aluno_responsavel();
                v_responsavel.Show();

                this.Close();
            }

        }

        private void btn_novo_cad_aluno_Click_1(object sender, EventArgs e)
        {
            // NOME DO ALUNO
            errorProvider1.Clear();
            if (txb_nome_aluno_cad_aluno.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txb_nome_aluno_cad_aluno, "O Preenchimento é obrigatório!!");
                txb_nome_aluno_cad_aluno.Focus();
                toolTip1.SetToolTip(txb_nome_aluno_cad_aluno, "Preencha este campo com o NOME do Aluno");
                txb_nome_aluno_cad_aluno.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //RG DO ALUNO
            errorProvider1.Clear();
            if (mtb_rg_aluno_cad_aluno.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(mtb_rg_aluno_cad_aluno, "O Preenchimento é obrigatório!!");
                mtb_rg_aluno_cad_aluno.Focus();
                toolTip1.SetToolTip(mtb_rg_aluno_cad_aluno, "Preencha este campo com o NOME do Aluno");
                mtb_rg_aluno_cad_aluno.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            //RUA ENDEREÇO ALUNO
            errorProvider1.Clear();
            if (txb_rua_end_cad_aluno.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txb_rua_end_cad_aluno, "O Preenchimento é obrigatório!!");
                txb_rua_end_cad_aluno.Focus();
                toolTip1.SetToolTip(txb_rua_end_cad_aluno, "Preencha este campo com o ENDEREÇO DE RUA do Aluno");
                txb_rua_end_cad_aluno.Focus();
                return;
                ////MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            else
            {

                alunoBindingSource.EndEdit();
                alunoTableAdapter.Update(GABARITEIDataSet);
                string v_codigo = txb_codigo_aluno_cad_aluno.Text;
                alunoTableAdapter.Fill(GABARITEIDataSet.aluno);
                //// Faz a busca no banco, a coluna que for colocada (liv_cd)
                int v_posicao = alunoBindingSource.Find("alu_cd", txb_codigo_aluno_cad_aluno.Text);
                alunoBindingSource.Position = v_posicao;
                //habilitar_campos(true);
                alunoBindingSource.AddNew();
                //this.Visible = false;
            }
        }

        private void btn_cancelar_cad_aluno_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //CANCELAR
            this.Visible = false;
            habilitar_campos(true);
            // (NOMEDOBANCODEDADOS).CancelEdit();
        }

        private void txb_nome_aluno_cad_aluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_RespLegal_pai_responsaveis_cad_aluno_CheckedChanged(object sender, EventArgs e)
        {

            //gp_pai_responsaveis_cad_aluno.Visible = cb_RespLegal_pai_responsaveis_cad_aluno.Checked;
            //crt_princ_alun_graf.Visible = chb_princ_alun_indice.Checked;

            ////o Ponto de exclamação fez com que executasse o inverso
            //groupBox3.Visible = !chb_princ_alun_indice.Checked;
        }

        private void cb_RespLegal_mae_responsaveis_cad_aluno_CheckedChanged(object sender, EventArgs e)
        {
            ////gp_mae_responsaveis_cad_aluno.Visible = cb_RespLegal_mae_responsaveis_cad_aluno.Checked;
            //txb_pai_responsaveis_cad_aluno.Enabled = !cb_RespLegal_mae_responsaveis_cad_aluno.Checked;
            //mtb_rg_pai_responsaveis_cad_aluno.Enabled = !cb_RespLegal_mae_responsaveis_cad_aluno.Checked;
            //mtb_nascimento_pai_responsaveis_cad_aluno.Enabled = !cb_RespLegal_mae_responsaveis_cad_aluno.Checked;
            //mtb_celualar_pai_responsaveis_cad_aluno.Enabled = !cb_RespLegal_mae_responsaveis_cad_aluno.Checked;
            //mtb_cpf_pai_responsaveis_cad_aluno.Enabled = !cb_RespLegal_mae_responsaveis_cad_aluno.Checked;

            ////tornar o check box DESABILITADO ao habilitar o check box da Mãe responsável legal
            //cb_RespLegal_pai_responsaveis_cad_aluno.Enabled = !cb_RespLegal_mae_responsaveis_cad_aluno.Checked;
        }

        private void cb_RespLegal_pai_responsaveis_cad_aluno_CheckedChanged_1(object sender, EventArgs e)
        {
            //txb_mae_mae_responsaveis_cad_aluno.Enabled = !cb_RespLegal_pai_responsaveis_cad_aluno.Checked;
            //mtb_rg_mae_responsaveis_cad_aluno.Enabled = !cb_RespLegal_pai_responsaveis_cad_aluno.Checked;
            //mtb_cpf_mae_responsaveis_cad_aluno.Enabled = !cb_RespLegal_pai_responsaveis_cad_aluno.Checked;
            //mtb_DatNasc_mae_responsaveis_cad_aluno.Enabled = !cb_RespLegal_pai_responsaveis_cad_aluno.Checked;
            //mtb_celular_mae_responsaveis_cad_aluno.Enabled = !cb_RespLegal_pai_responsaveis_cad_aluno.Checked;

            ////tornar o check box DESABILITADO ao habilitar o check box do Pai responsável legal
            //cb_RespLegal_mae_responsaveis_cad_aluno.Enabled = !cb_RespLegal_pai_responsaveis_cad_aluno.Checked;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            habilitar_campos(false);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txb_nome_aluno_cad_aluno_Validating(object sender, CancelEventArgs e)
        {

        }

        private void btn_salvar_cad_aluno_Validating(object sender, CancelEventArgs e)
        {

        }

        private void mtb_rg_aluno_cad_aluno_Validating(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //RESPONSAVEL
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

            //TELEFONE RESPONSAVEL
            //errorProvider1.Clear();
            //if (maskedTextBox3.Text.Trim().Length == 0)
            //{
            //    errorProvider1.SetError(maskedTextBox3, "A Senha é obrigatória!!");
            //    maskedTextBox3.Focus();
            //    toolTip1.SetToolTip(maskedTextBox3, "teste");
            //    maskedTextBox3.Focus();
            //    return;
            //    //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            //}

            //CPF 
            //errorProvider1.Clear();
            //if (maskedTextBox1.Text.Trim().Length == 0)
            //{
            //    errorProvider1.SetError(maskedTextBox1, "A Senha é obrigatória!!");
            //    maskedTextBox1.Focus();
            //    toolTip1.SetToolTip(maskedTextBox1, "teste");
            //    maskedTextBox1.Focus();
            //    return;
            //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            //}

            //TIPO RESPONSAVEL
            //errorProvider1.Clear();
            //if (comboBox1.Text.Trim().Length == 0)
            //{
            //    errorProvider1.SetError(comboBox1, "A Senha é obrigatória!!");
            //    comboBox1.Focus();
            //    toolTip1.SetToolTip(comboBox1, "teste");
            //    comboBox1.Focus();
            //    return;
            //    //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            //}

            //else
            //{

            ////teste
            //reponsavelBindingSource.EndEdit();
            //reponsavelTableAdapter.Update(GABARITEIDataSet);
            //string v_codigo = textBox5.Text;
            //reponsavelTableAdapter.Fill(GABARITEIDataSet.reponsavel);
            ////// Faz a busca no banco, a coluna que for colocada (liv_cd)
            //int v_posicao = reponsavelBindingSource.Find("resp_cd", v_codigo);
            //reponsavelBindingSource.Position = v_posicao;
            ////habilitar_campos(true);
            //reponsavelBindingSource.AddNew();
            ////this.Visible = false;

            ////teste
            //this.view_tipo_telefone_responsavelTableAdapter.Fill(this.GABARITEIDataSet.View_tipo_telefone_responsavel);
            //this.view_lsita_respTableAdapter.Fill(this.GABARITEIDataSet.view_lsita_resp);





            //}
        }

        private void txb_codigo_aluno_cad_aluno_TextChanged(object sender, EventArgs e)
        {
            //classe_PUBLICA.v_alunocd4 = alunoBindingSource.Position.ToString();

            //this.view_cadastro_respTableAdapter.Fill(this.GABARITEIDataSet.view_cadastro_resp);
            //alunotelefoneBindingSource.Filter = "alu_cd = " + classe_PUBLICA.v_alunocd;
        }

        private void mtb_datInscr_aluno_cad_aluno_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //DateTime.Now.ToShortDateString();
            // mtb_datInscr_aluno_cad_aluno.Text = DateTime.Now.ToLongTimeString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbp_responsaveis_cad_aluno_Selected(object sender, TabControlEventArgs e)
        {
            ////FAZ COM QUE PEGUE A DATA ATUAL DO COMPUTADOR
            //textBox3.Text = DateTime.Now.ToShortDateString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ////FAZ COM QUE PEGUE A DATA ATUAL DO COMPUTADOR
            //textBox3.Text = DateTime.Now.ToLongTimeString();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = DateTime.Now.ToShortDateString();
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {





            //this.aluno_telefoneTableAdapter.Fill(this.GABARITEIDataSet.aluno_telefone);


            //alunotelefoneBindingSource.EndEdit();
            //aluno_telefoneTableAdapter.Update(GABARITEIDataSet);
            //string v_codigo = textBox6.Text;
            //aluno_telefoneTableAdapter.Fill(GABARITEIDataSet.aluno_telefone);
            //// Faz a busca no banco, a coluna que for colocada (liv_cd)
            //int v_posicao = alunotelefoneBindingSource.Find("alut_cd", textBox6.Text);
            //alunotelefoneBindingSource.Position = v_posicao;
            //alunotelefoneBindingSource.AddNew();

            //textBox1.Text = "";

            //textBox1.Text = "";
            //this.aluno_telefoneTableAdapter.Fill(this.GABARITEIDataSet.aluno_telefone);

            //alunotelefoneBindingSource.EndEdit();
            //aluno_telefoneTableAdapter.Update(GABARITEIDataSet);
            //alunotelefoneBindingSource.AddNew();
            //this.aluno_telefoneTableAdapter.Fill(this.GABARITEIDataSet.aluno_telefone);
        }

        private void tbp_responsaveis_cad_aluno_Click(object sender, EventArgs e)
        {
            //classe_PUBLICA.v_responcd = "0";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //classe_PUBLICA.v_alunocd = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); 

            //this.view_cadastro_respTableAdapter.Fill(this.GABARITEIDataSet.view_cadastro_resp);
            //viewcadastrorespBindingSource.Filter = "alu_cd = " + classe_PUBLICA.v_alunocd;
        }

        private void alunotelefoneBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //telefoneresponsavelBindingSource.EndEdit();
            //telefone_responsavelTableAdapter.Update(GABARITEIDataSet);
            //string v_codigo = textBox7.Text;
            //telefone_responsavelTableAdapter.Fill(GABARITEIDataSet.telefone_responsavel);
            ////// Faz a busca no banco, a coluna que for colocada (liv_cd)
            //int v_posicao = telefoneresponsavelBindingSource.Find("tp_cd", v_codigo);
            //telefoneresponsavelBindingSource.Position = v_posicao;
            ////habilitar_campos(true);
            //telefoneresponsavelBindingSource.AddNew();
            ////this.Visible = false;
            //this.tipo_telefoneTableAdapter.Fill(this.GABARITEIDataSet.tipo_telefone);
            //this.telefone_responsavelTableAdapter.Fill(this.GABARITEIDataSet.telefone_responsavel);

            //tipotelefoneBindingSource.EndEdit();
            //tipo_telefoneTableAdapter.Update(GABARITEIDataSet);
            ////string v_codigo1 = textBox8.Text;
            //tipo_telefoneTableAdapter.Fill(GABARITEIDataSet.tipo_telefone);
            ////// Faz a busca no banco, a coluna que for colocada (liv_cd)
            //int v_posicao1 = tipotelefoneBindingSource.Find("ttel_cd", v_codigo1);
            //tipotelefoneBindingSource.Position = v_posicao1;
            ////habilitar_campos(true);
            //tipotelefoneBindingSource.AddNew();
            ////this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            classe_PUBLICA.v_cadtelcd = "0";
            Form v_categoriatel = new frm_cadastro_categoria_telefone();
            v_categoriatel.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //classe_PUBLICA.v_dvrespcd = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ////frm_janela_nota_aluno_indv nota_aluno_individual = new frm_janela_nota_aluno_indv();
            ////nota_aluno_individual.Show();
            //this.tipo_telefoneTableAdapter.Fill(this.GABARITEIDataSet.tipo_telefone);


        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //classe_PUBLICA.v_dvrespcd = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ////frm_janela_nota_aluno_indv nota_aluno_individual = new frm_janela_nota_aluno_indv();
            ////nota_aluno_individual.Show();
            //this.tipo_telefoneTableAdapter.Fill(this.GABARITEIDataSet.tipo_telefone);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count == 0)
            //{ classe_PUBLICA.v_dvrespcd = "0"; }
            //else
            //{ classe_PUBLICA.v_dvrespcd = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();}

            //frm_janela_nota_aluno_indv nota_aluno_individual = new frm_janela_nota_aluno_indv();
            //nota_aluno_individual.Show();
            //this.view_tipo_telefone_responsavelTableAdapter.Fill(this.GABARITEIDataSet.View_tipo_telefone_responsavel);
            //viewtipotelefoneresponsavelBindingSource.Filter = "resp_cd = " + classe_PUBLICA.v_dvrespcd;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            classe_PUBLICA.v_respcontcd = "0";
            Form v_cadastroresp = new frm_cadastro_responsavel();
            v_cadastroresp.ShowDialog();



        }

        private void button7_Click(object sender, EventArgs e)
        {
            classe_PUBLICA.v_trespcd = "0";
            Form v_tiporesp = new frm_cadastro_tipo_respon();
            v_tiporesp.ShowDialog();
        }

        private void cmb_UF_cad_aluno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Form v_responsavel = new pipoca();
            //v_responsavel.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            //alunotelefoneBindingSource.EndEdit();
            //aluno_telefoneTableAdapter.Update(GABARITEIDataSet);
            ////string v_codigo = textBox1.Text;
            //aluno_telefoneTableAdapter.Fill(GABARITEIDataSet.aluno_telefone);
            ////// Faz a busca no banco, a coluna que for colocada (liv_cd)
            ////int v_posicao = alunotelefoneBindingSource.Find("alut_cd", textBox1.Text);
            ////alunotelefoneBindingSource.Position = v_posicao;
            //alunotelefoneBindingSource.AddNew();

            ////textBox1.Text = "";

            ////textBox1.Text = "";
            ////this.aluno_telefoneTableAdapter.Fill(this.GABARITEIDataSet.aluno_telefone);

            ////alunotelefoneBindingSource.EndEdit();
            ////aluno_telefoneTableAdapter.Update(GABARITEIDataSet);
            ////alunotelefoneBindingSource.AddNew();
            //this.aluno_telefoneTableAdapter.Fill(this.GABARITEIDataSet.aluno_telefone);
        }

        private void button2_Click_4(object sender, EventArgs e)
        {
            //this.aluno_telefoneTableAdapter.Fill(this.GABARITEIDataSet.aluno_telefone);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //classe_PUBLICA.v_alunocd4 = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();

            //this.view_cadastro_respTableAdapter.Fill(this.GABARITEIDataSet.view_cadastro_resp);
            //viewcadastrorespBindingSource.Filter = "alu_cd = " + classe_PUBLICA.v_alunocd;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}