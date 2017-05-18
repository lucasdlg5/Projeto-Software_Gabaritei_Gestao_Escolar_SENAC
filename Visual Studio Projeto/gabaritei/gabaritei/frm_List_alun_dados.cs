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
    public partial class frm_list_alun_dados : Form
    {
        public frm_list_alun_dados()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lista_alunos_dados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GABARITEIDataSet.view_lista_aluno' table. You can move, or remove it, as needed.
            this.view_lista_alunoTableAdapter.Fill(this.GABARITEIDataSet.view_lista_aluno);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.view_lista_aluno' table. You can move, or remove it, as needed.
            this.view_lista_alunoTableAdapter.Fill(this.GABARITEIDataSet.view_lista_aluno);
            //// TODO: This line of code loads data into the 'GABARITEIDataSet.aluno' table. You can move, or remove it, as needed.
            //this.alunoTableAdapter.Fill(this.GABARITEIDataSet.aluno);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.View_triview_ano' table. You can move, or remove it, as needed.
            this.view_triview_anoTableAdapter.Fill(this.GABARITEIDataSet.View_triview_ano);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.View_triview_turma' table. You can move, or remove it, as needed.
            this.view_triview_turmaTableAdapter.Fill(this.GABARITEIDataSet.View_triview_turma);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.view_lista_aluno' table. You can move, or remove it, as needed.

            //this.view_lista_alunoTableAdapter.Fill(this.GABARITEIDataSet.view_lista_aluno);

            //this.view_lista_alunoTableAdapter.Fill(this.GABARITEIDataSet.view_lista_aluno);


            //turmaBindingSource.Filter = "tur_cd  = " + classe_PUBLICA.v_turmascd;
            // TODO: This line of code loads data into the 'GABARITEIDataSet.aluno' table. You can move, or remove it, as needed.

            //Será feito a alteração da ordem que será exibida o ano, de forma decrescente
            //viewtriviewanoBindingSource.Sort = "ano desc";
            //classe_PUBLICA.v_bturmascd = viewtriviewturmaBindingSource.Current  ;


            ////variavel utilizada para todas as condições
            //DataRowView v_atual;




            //for (int i = 0; i < viewtriviewanoBindingSource.Count; i++)
            //{
            //    //A variavel da posição I será mudada para cada tipo de tabela
            //    viewtriviewanoBindingSource.Position = i;

            //    //Tabela para ser exibida, que deve ser criada propriamente para a treeview, com os campos
            //    v_atual = (DataRowView)viewtriviewanoBindingSource[0];
            //    //em parenteses no colchete, o v_atual[?] deve ser alterado de acordo com a hierarquia do nó
            //    tvw_list_alun_dados.Nodes.Add(i.ToString(),v_atual[0].ToString());

            //    //Campo da coluna da tabela ou View para ser exibido no primeiro nó, sendo filtrado
            //    //viewtriviewturmaBindingSource.Filter = "ano = " + v_atual[0].ToString();
            //    //viewtriviewturmaBindingSource.Filter = "ano = " + v_atual[0].ToString();

            //    //Campo da coluna que será exibita o nome
            //    viewtriviewturmaBindingSource.Sort = "nome";

            //    viewtriviewanoBindingSource.Sort = "ano desc";

            //    //v_atual deverá ser a coluna da turma
            //    //viewtriviewturmaBindingSource.Filter = "ano = " + textBox2;
            //        //+ ;




            //    //Sub-lista para turmas
            //    for (int j = 0; j < viewtriviewturmaBindingSource.Count; j++)
            //    {
            //        //A variavel da posição I será mudada para cada tipo de tabela
            //        viewtriviewturmaBindingSource.Position = j;

            //        //Tabela para ser exibida, que deve ser criada propriamente para a treeview, com os campos
            //        //v_atual = (DataRowView)viewtriviewturmaBindingSource[0];
            //        v_atual = (DataRowView)viewtriviewturmaBindingSource[j];

            //        tvw_list_alun_dados.Nodes[i].Nodes.Add(v_atual[0].ToString(), v_atual[1].ToString());
            //        //tvw_list_alun_dados.Nodes[i].Nodes.Add(v_atual[0].ToString(), v_atual[1].ToString());


            //    }



            //}

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmb_list_alun_dados_turmas.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //frm_principal teste2 = new frm_principal();
            //teste2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            classe_PUBLICA.v_alutcd = "0";
            classe_PUBLICA.v_alunocd = "0";
            classe_PUBLICA.v_responcd = "0";
            frm_cadastro_aluno cadastro_aluno = new frm_cadastro_aluno();
            cadastro_aluno.ShowDialog();
            //this.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            classe_PUBLICA.v_alunocd = dgv_list_alun_dados.SelectedRows[0].Cells[0].Value.ToString();
            //classe_PUBLICA.v_responcd = dgv_list_alun_dados.SelectedRows[0].Cells[0].Value.ToString();
            //frm_janela_nota_aluno_indv nota_aluno_individual = new frm_janela_nota_aluno_indv();
            //nota_aluno_individual.Show();
            frm_janela_nota_aluno_indv nota_aluno_cadastro = new frm_janela_nota_aluno_indv();
            nota_aluno_cadastro.Show();


        }

        private void btn_list_alun_dados_Click(object sender, EventArgs e)
        {

        }

        private void tvw_list_alun_dados_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

                string v_pequisa = "1=1 ";
                if (textBox1.Text.Length > 0)
                {
                    v_pequisa += string.Format(" and [Nome] like '%{0}%'", textBox1.Text);
                }


                viewlistaalunoBindingSource.Filter = v_pequisa;
            

            //if (MessageBox.Show("Deseja excluir o registro", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{ 
            //livroBindingSource.RemoveCurrent();
            //livroTableAdapter.Update(bibliotecaDataSet);
            //}
        }

        private void dgv_list_alun_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewtriviewturmaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //FAZ COM QUE AO PRESSIONAR O ENTER (TECLA 13) FAÇA EXECUTAR ABAIXO
            if (e.KeyChar == 13)
            {

                string v_pequisa = "1=1 ";
                if (textBox1.Text.Length > 0)
                {
                    v_pequisa += string.Format(" and [Nome] like '%{0}%'", textBox1.Text);
                }


                viewlistaalunoBindingSource.Filter = v_pequisa;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form v_relatorioaluno = new frm_relatorios_alunos();
            v_relatorioaluno.ShowDialog();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //FAZ COM QUE AO PRESSIONAR O ENTER (TECLA 13) FAÇA EXECUTAR ABAIXO
            if (e.KeyChar == 13)
            {

                string v_pequisa = "1=1 ";
                if (textBox1.Text.Length > 0)
                {
                    v_pequisa += string.Format(" and [Nome] like '%{0}%'", textBox1.Text);
                }


                viewlistaalunoBindingSource.Filter = v_pequisa;
            }
        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //FAZ COM QUE AO PRESSIONAR O ENTER (TECLA 13) FAÇA EXECUTAR ABAIXO
            if (e.KeyChar == 13)
            {

                string v_pequisa = "1=1 ";
                if (textBox1.Text.Length > 0)
                {
                    v_pequisa += string.Format(" and [Nome] like '%{0}%'", textBox1.Text);
                }



                viewlistaalunoBindingSource.Filter = v_pequisa;
            }
        }

        private void dgv_list_alun_dados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            classe_PUBLICA.v_alunocd = dgv_list_alun_dados.SelectedRows[0].Cells[0].Value.ToString();
            //classe_PUBLICA.v_responcd = dgv_list_alun_dados.SelectedRows[0].Cells[0].Value.ToString();
            //frm_janela_nota_aluno_indv nota_aluno_individual = new frm_janela_nota_aluno_indv();
            //nota_aluno_individual.Show();
            frm_janela_nota_aluno_indv nota_aluno_cadastro = new frm_janela_nota_aluno_indv();
            nota_aluno_cadastro.Show();
        }
    }
}
