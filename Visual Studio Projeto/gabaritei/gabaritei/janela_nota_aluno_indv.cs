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
    public partial class janela_nota_aluno_indv : Form
    {
        public janela_nota_aluno_indv()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void janela_nota_aluno_indv_Load(object sender, EventArgs e)
        {
            tabControl1.Visible = radioButton1.Checked;
            tabControl2.Visible = radioButton2.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            tabControl1.Visible = radioButton1.Checked;
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
            tabControl2.Visible = radioButton2.Checked;

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
            this.Visible = false;
            frm_cadastro_aluno cadastro = new frm_cadastro_aluno();
            cadastro.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

