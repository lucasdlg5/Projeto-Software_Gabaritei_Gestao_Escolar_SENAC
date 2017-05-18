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
    public partial class frm_lançamento_notas : Form
    {
        public frm_lançamento_notas()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frm_notas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GABARITEIDataSet.view_triview_materia' table. You can move, or remove it, as needed.
        
            // TODO: This line of code loads data into the 'GABARITEIDataSet.View_triview_ano' table. You can move, or remove it, as needed.
            this.view_triview_anoTableAdapter.Fill(this.GABARITEIDataSet.View_triview_ano);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.View_triview_turma' table. You can move, or remove it, as needed.
            this.view_triview_turmaTableAdapter.Fill(this.GABARITEIDataSet.View_triview_turma);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.view_lancamento_notas' table. You can move, or remove it, as needed.
            this.view_lancamento_notasTableAdapter.Fill(this.GABARITEIDataSet.view_lancamento_notas);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.nota_falta' table. You can move, or remove it, as needed.
            this.nota_faltaTableAdapter.Fill(this.GABARITEIDataSet.nota_falta);

            if (classe_PUBLICA.v_lnotascd == "0")
            {
                notafaltaBindingSource.AddNew();
            }
            else
            {
                notafaltaBindingSource.Filter = "nf_cd  = " + classe_PUBLICA.v_lnotascd;
            }

            DataRowView v_atual;
            for (int i = 0; i < viewtriviewanoBindingSource.Count; i++)
            {
                //A variavel da posição I será mudada para cada tipo de tabela
                viewtriviewanoBindingSource.Position = i;
                //Tabela para ser exibida, que deve ser criada propriamente para a treeview, com os campos
                v_atual = (DataRowView)viewtriviewanoBindingSource[0];
                //em parenteses no colchete, o v_atual[?] deve ser alterado de acordo com a hierarquia do nó
                tvw_prof_lanc_presenc.Nodes.Add(i.ToString(), v_atual[0].ToString());
                //Campo da coluna da tabela ou View para ser exibido no primeiro nó, sendo filtrado
                //viewtriviewturmaBindingSource.Filter = "ano = " + v_atual[0].ToString();
                //viewtriviewturmaBindingSource.Filter = "ano = " + v_atual[0].ToString();
                //Campo da coluna que será exibita o nome
                viewtriviewturmaBindingSource.Sort = "nome";
                viewtriviewanoBindingSource.Sort = "ano desc";







                //Sub-lista para turmas
                for (int j = 0; j < viewtriviewturmaBindingSource.Count; j++)
                {
                    //A variavel da posição I será mudada para cada tipo de tabela
                    viewtriviewturmaBindingSource.Position = j;

                    //Tabela para ser exibida, que deve ser criada propriamente para a treeview, com os campos
                    //v_atual = (DataRowView)viewtriviewturmaBindingSource[0];
                    v_atual = (DataRowView)viewtriviewturmaBindingSource[0];

                    tvw_prof_lanc_presenc.Nodes[i].Nodes.Add(v_atual[0].ToString(), v_atual[1].ToString());
                    //tvw_list_alun_dados.Nodes[i].Nodes.Add(v_atual[0].ToString(), v_atual[1].ToString());


                }


                //for (int k = 0; k < viewtriviewmateriaBindingSource.Count; k++)
                //{
                //    //A variavel da posição I será mudada para cada tipo de tabela
                //    viewtriviewmateriaBindingSource.Position = k;

                //    //Tabela para ser exibida, que deve ser criada propriamente para a treeview, com os campos
                //    //v_atual = (DataRowView)viewtriviewturmaBindingSource[0];
                //    v_atual = (DataRowView)viewtriviewmateriaBindingSource[0];

                //    tvw_prof_lanc_presenc.Nodes[k].Nodes[k].Nodes.Add(v_atual[0].ToString(), v_atual[1].ToString());



                //}

            }
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //habilitar_campos(true);
            //livroBindingSource.CancelEdit();
            this.Close();

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            //viewlancamentonotasBindingSource.EndEdit();
            //view_lancamento_notasTableAdapter.Fill(GABARITEIDataSet.view_lancamento_notas);

            notafaltaBindingSource.EndEdit();
            nota_faltaTableAdapter.Update(GABARITEIDataSet);
            nota_faltaTableAdapter.Fill(GABARITEIDataSet.nota_falta);

            //livroBindingSource.EndEdit();
            //livroTableAdapter.Update(bibliotecaDataSet);
            //string v_codigo = txb_codigo.Text;
            //livroTableAdapter.Fill(bibliotecaDataSet.livro);

            //// Faz a busca no banco, a coluna que for colocada (liv_cd)
            //int v_posicao = livroBindingSource.Find("liv_cd", txb_codigo.Text);
            ////
            //livroBindingSource.Position = v_posicao;
            //habilitar_campos(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //habilitar_campos(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
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

            else
            {
                this.nota_faltaTableAdapter.Fill(this.GABARITEIDataSet.nota_falta);


            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBox28.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox28, "A Senha é obrigatória!!");
                textBox28.Focus();
                toolTip1.SetToolTip(textBox28, "teste");
                textBox28.Focus();
                return;
                //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            else
            {

            }
        }

        private void btn_prof_lanc_presenc_Click(object sender, EventArgs e)
        {

        }
    }
}
