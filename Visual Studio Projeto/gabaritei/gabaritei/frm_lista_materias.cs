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
    public partial class frm_lista_materias : Form
    {
        public frm_lista_materias()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            classe_PUBLICA.v_cmateriacd = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            frm_cadastro_materias v_aturmas = new frm_cadastro_materias();
            v_aturmas.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            string v_pequisa = "1=1 ";
            if (textBox1.Text.Length > 0)
            {
                v_pequisa += string.Format(" and [Nome da matéria] like '%{0}%'", textBox1.Text);
            }

            if (textBox2.Text.Length > 0)
            {
                v_pequisa += string.Format(" and mat_cd = {0}", textBox2.Text);
            }
            viewcadastromateriaBindingSource.Filter = v_pequisa;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_lista_materias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GABARITEIDataSet.View_triview_turma' table. You can move, or remove it, as needed.
            this.view_triview_turmaTableAdapter.Fill(this.GABARITEIDataSet.View_triview_turma);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.View_triview_ano' table. You can move, or remove it, as needed.
            this.view_triview_anoTableAdapter.Fill(this.GABARITEIDataSet.View_triview_ano);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.view_cadastro_materia' table. You can move, or remove it, as needed.
            this.view_cadastro_materiaTableAdapter.Fill(this.GABARITEIDataSet.view_cadastro_materia);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.view_cadastro_materia' table. You can move, or remove it, as needed.
            this.view_cadastro_materiaTableAdapter.Fill(this.GABARITEIDataSet.view_cadastro_materia);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.materia' table. You can move, or remove it, as needed.
            //this.materiaTableAdapter.Fill(this.GABARITEIDataSet.materia);
            //// TODO: This line of code loads data into the 'GABARITEIDataSet.materia' table. You can move, or remove it, as needed.
            //this.materiaTableAdapter.Fill(this.GABARITEIDataSet.materia);

            //DataRowView v_atual;




            //for (int i = 0; i < viewtriviewanoBindingSource.Count; i++)
            //{
            //    //A variavel da posição I será mudada para cada tipo de tabela
            //    viewtriviewanoBindingSource.Position = i;

            //    //Tabela para ser exibida, que deve ser criada propriamente para a treeview, com os campos
            //    v_atual = (DataRowView)viewtriviewanoBindingSource[0];
            //    //em parenteses no colchete, o v_atual[?] deve ser alterado de acordo com a hierarquia do nó
            //    tvw_list_alun_dados.Nodes.Add(i.ToString(), v_atual[0].ToString());

            //    //Campo da coluna da tabela ou View para ser exibido no primeiro nó, sendo filtrado
            //    //viewtriviewturmaBindingSource.Filter = "ano = " + v_atual[0].ToString();
            //    //viewtriviewturmaBindingSource.Filter = "ano = " + v_atual[0].ToString();

            //    //Campo da coluna que será exibita o nome
            //    viewtriviewturmaBindingSource.Sort = "nome";

            //    viewtriviewanoBindingSource.Sort = "ano desc";







            //    //Sub-lista para turmas
            //    for (int j = 0; j < viewtriviewturmaBindingSource.Count; j++)
            //    {
            //        //A variavel da posição I será mudada para cada tipo de tabela
            //        viewtriviewturmaBindingSource.Position = j;

            //        //Tabela para ser exibida, que deve ser criada propriamente para a treeview, com os campos
            //        //v_atual = (DataRowView)viewtriviewturmaBindingSource[0];
            //        v_atual = (DataRowView)viewtriviewturmaBindingSource[0];

            //        tvw_list_alun_dados.Nodes[i].Nodes.Add(v_atual[0].ToString(), v_atual[1].ToString());
            //        //tvw_list_alun_dados.Nodes[i].Nodes.Add(v_atual[0].ToString(), v_atual[1].ToString());


            //    }
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_adicao_materias v_materias = new frm_adicao_materias();
            v_materias.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //habilitar_campos(false);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            classe_PUBLICA.v_cmateriacd = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            frm_cadastro_materias v_aturmas = new frm_cadastro_materias();
            v_aturmas.ShowDialog();
        }

        private void rtxb_list_alun_dados_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_list_alun_dados_Click(object sender, EventArgs e)
        {

        }

        private void tvw_list_alun_dados_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tvw_list_alun_dados_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {


        }

        private void tvw_list_alun_dados_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            //string v_ano = tvw_list_alun_dados.SelectedNode.Text;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //FAZ COM QUE AO PRESSIONAR O ENTER (TECLA 13) FAÇA EXECUTAR ABAIXO
            if (e.KeyChar == 13)
            {

                string v_pequisa = "1=1 ";
                if (textBox1.Text.Length > 0)
                {
                    v_pequisa += string.Format(" and [Nome da matéria] like '%{0}%'", textBox1.Text);
                }

                if (textBox2.Text.Length > 0)
                {
                    v_pequisa += string.Format(" and mat_cd = {0}", textBox2.Text);
                }
                viewcadastromateriaBindingSource.Filter = v_pequisa;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //FAZ COM QUE AO PRESSIONAR O ENTER (TECLA 13) FAÇA EXECUTAR ABAIXO
            if (e.KeyChar == 13)
            {

                string v_pequisa = "1=1 ";
                if (textBox1.Text.Length > 0)
                {
                    v_pequisa += string.Format(" and [Nome da matéria] like '%{0}%'", textBox1.Text);
                }

                if (textBox2.Text.Length > 0)
                {
                    v_pequisa += string.Format(" and mat_cd = {0}", textBox2.Text);
                }
                viewcadastromateriaBindingSource.Filter = v_pequisa;
            }
        }
    }
}
