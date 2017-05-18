using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;






//INSERIR NO BOTÃO PARA O BOTAO
//Mostra as notas dos alunos ao acessar A LISTA
//Form v_janela_nota_aluno_indv = new janela_nota_aluno_indv();
//v_janela_nota_aluno_indv.Show();








namespace gabaritei
{
    public partial class frm_janela_nota_aluno_indv : Form
    {
        public frm_janela_nota_aluno_indv()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void janela_nota_aluno_indv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GABARITEIDataSet.view_aluno_nota' table. You can move, or remove it, as needed.
            //this.view_aluno_notaTableAdapter.Fill(this.GABARITEIDataSet.view_aluno_nota);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.view_aluno_nota' table. You can move, or remove it, as needed.
            //this.view_aluno_notaTableAdapter.Fill(this.GABARITEIDataSet.view_aluno_nota);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.aluno' table. You can move, or remove it, as needed.
            this.alunoTableAdapter.Fill(this.GABARITEIDataSet.aluno);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.view_aluno_nota' table. You can move, or remove it, as needed.
            //this.view_aluno_notaTableAdapter.Fill(this.GABARITEIDataSet.view_aluno_nota);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.view_aluno_nota' table. You can move, or remove it, as needed.
            //this.view_aluno_notaTableAdapter.Fill(this.GABARITEIDataSet.view_aluno_nota);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.view_lista_aluno' table. You can move, or remove it, as needed.
            //this.view_lista_alunoTableAdapter.Fill(this.GABARITEIDataSet.view_lista_aluno);
            //// TODO: This line of code loads data into the 'GABARITEIDataSet.nota_falta' table. You can move, or remove it, as needed.
            //this.nota_faltaTableAdapter.Fill(this.GABARITEIDataSet.nota_falta);
            //tabControl1.Visible = radioButton1.Checked;
            //tabControl2.Visible = radioButton2.Checked;

            //label3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            //label59.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //label10.Text = viewalunonotaBindingSource.Sort = "ano desc";

            alunoBindingSource.Filter = "alu_cd = " + classe_PUBLICA.v_alunocd;
            //view_aluno_notaTableAdapter.Fill(GABARITEIDataSet.view_aluno_nota);
            //viewalunonotaBindingSource.Filter = "alu_cd = " + classe_PUBLICA.v_alunocd; 
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            //tabControl1.Visible = radioButton1.Checked;
            //  TIRAR errado // tabPage1.Visible = radioButton1.Checked;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            // Tirar this.Visible = false; //radioButton1.Checked = false;

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Tirar tabControl1.Visible = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Tirar tabControl2.Visible = radioButton2.Checked;
            //tabControl2.Visible = radioButton2.Checked;

        }

        //String v_teste2;
        private void textBox53_TextChanged(object sender, EventArgs e)
        {

            //    Tirar        v_teste2 = textBox10.Text;
            //   Tirar   textBox53.Text = v_teste2;
            // Henr // textBox10.Text = textBox53.Text;
        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

           
            //viewalunonotaBindingSource.Filter = "[Nome do aluno]  = " + classe_PUBLICA.v_alunocd3;
            //
            frm_cadastro_aluno cadastro = new frm_cadastro_aluno();
            cadastro.Show();
            this.Close();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //viewalunonotaBindingSource.Filter = "[Nome da turma]  = " + label3.Text;
            //label3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
           
        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form v_materiaalno = new frm_cadastro_aluno_materia();
            v_materiaalno.ShowDialog();
        }
    }
}

