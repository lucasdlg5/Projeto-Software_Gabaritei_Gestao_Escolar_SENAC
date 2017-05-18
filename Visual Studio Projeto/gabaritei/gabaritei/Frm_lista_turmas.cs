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
    public partial class Frm_lista_turmas : Form
    {
        public Frm_lista_turmas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //classe_PUBLICA.v_funcd = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //frm_cadastro_abertura_turmas v_aturmas = new frm_cadastro_abertura_turmas();
            //v_aturmas.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            classe_PUBLICA.v_turmascd = "0";
            frm_cadastro_abertura_turmas v_abertura = new frm_cadastro_abertura_turmas();
            v_abertura.Show();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //habilitar_campos(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string v_pequisa = "1=1 ";
            if (textBox1.Text.Length > 0)
            {
                v_pequisa += string.Format(" and [Nome da turma] like '%{0}%'", textBox1.Text);
            }

            if (textBox2.Text.Length > 0)
            {
                v_pequisa += string.Format(" and [Código da turma] = {0}", textBox2.Text);
            }
            viewlistadeturmasBindingSource.Filter = v_pequisa;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_lista_turmas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GABARITEIDataSet.View_triview_ano' table. You can move, or remove it, as needed.
            this.view_triview_anoTableAdapter.Fill(this.GABARITEIDataSet.View_triview_ano);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.view_lista_de_turmas' table. You can move, or remove it, as needed.
            this.view_lista_de_turmasTableAdapter.Fill(this.GABARITEIDataSet.view_lista_de_turmas);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.cmb_turmaa' table. You can move, or remove it, as needed.
            //this.cmb_turmaaTableAdapter.Fill(this.GABARITEIDataSet.cmb_turmaa);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.view_lista_de_turmas' table. You can move, or remove it, as needed.
            this.view_lista_de_turmasTableAdapter.Fill(this.GABARITEIDataSet.view_lista_de_turmas);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.turma' table. You can move, or remove it, as needed.
            //this.turmaTableAdapter.Fill(this.GABARITEIDataSet.turma);


            //DataRowView v_atual;




            //for (int i = 0; i < viewtriviewanoBindingSource.Count; i++)
            //{
            //    //A variavel da posição I será mudada para cada tipo de tabela
            //    viewtriviewanoBindingSource.Position = i;

            //    //Tabela para ser exibida, que deve ser criada propriamente para a treeview, com os campos
            //    //v_atual = (DataRowView)viewtriviewanoBindingSource[0];
            //    //em parenteses no colchete, o v_atual[?] deve ser alterado de acordo com a hierarquia do nó
            //    //tvw_list_alun_dados.Nodes.Add(i.ToString(), v_atual[0].ToString());

            //    //Campo da coluna da tabela ou View para ser exibido no primeiro nó, sendo filtrado
            //    //viewtriviewturmaBindingSource.Filter = "ano = " + v_atual[0].ToString();
            //    //viewtriviewturmaBindingSource.Filter = "ano = " + v_atual[0].ToString();

            //    ////Campo da coluna que será exibita o nome
            //    //viewtriviewturmaBindingSource.Sort = "nome";

            //    viewtriviewanoBindingSource.Sort = "ano desc";

            //}
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            classe_PUBLICA.v_turmascd = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //frm_cadastro_abertura_turmas v_aturmas = new frm_cadastro_abertura_turmas();
            //v_aturmas.ShowDialog();
            Form v_aturmas = new frm_adicao_materias();
            v_aturmas.ShowDialog();
        }

        private void tvw_list_alun_dados_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Atualizar(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.view_lista_de_turmasTableAdapter.Fill(this.GABARITEIDataSet.view_lista_de_turmas);
            this.view_triview_anoTableAdapter.Fill(this.GABARITEIDataSet.View_triview_ano);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form v_relatorioturmas = new frm_relatorios_turmas();
            v_relatorioturmas.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //FAZ COM QUE AO PRESSIONAR O ENTER (TECLA 13) FAÇA EXECUTAR ABAIXO
            if (e.KeyChar == 13)
            {
                string v_pequisa = "1=1 ";
                if (textBox1.Text.Length > 0)
                {
                    v_pequisa += string.Format(" and [Nome da turma] like '%{0}%'", textBox1.Text);
                }

                if (textBox2.Text.Length > 0)
                {
                    v_pequisa += string.Format(" and [Código da turma] = {0}", textBox2.Text);
                }
                viewlistadeturmasBindingSource.Filter = v_pequisa;
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
                    v_pequisa += string.Format(" and [Nome da turma] like '%{0}%'", textBox1.Text);
                }

                if (textBox2.Text.Length > 0)
                {
                    v_pequisa += string.Format(" and [Código da turma] = {0}", textBox2.Text);
                }
                viewlistadeturmasBindingSource.Filter = v_pequisa;
            }
        }
    }
}
