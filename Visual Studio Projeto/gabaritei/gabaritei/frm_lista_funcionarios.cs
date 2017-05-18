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
    public partial class frm_lista_funcionarios : Form
    {
        public frm_lista_funcionarios()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_pesquisar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GABARITEIDataSet.view_lista_funcionario' table. You can move, or remove it, as needed.
            this.view_lista_funcionarioTableAdapter.Fill(this.GABARITEIDataSet.view_lista_funcionario);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.GABARITEIDataSet.funcionario);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.view_lista_funcionario' table. You can move, or remove it, as needed.
            //this.view_lista_funcionarioTableAdapter.Fill(this.GABARITEIDataSet.view_lista_funcionario);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.view_lista_funcionario' table. You can move, or remove it, as needed.
            //this.view_lista_funcionarioTableAdapter.Fill(this.GABARITEIDataSet.view_lista_funcionario);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.funcionario' table. You can move, or remove it, as needed.
 
            // TODO: This line of code loads data into the 'GABARITEIDataSet.funcionario' table. You can move, or remove it, as needed.
 
            // TODO: This line of code loads data into the 'GABARITEIDataSet.responsavelA' table. You can move, or remove it, as needed.
            //this.responsavelATableAdapter.Fill(this.GABARITEIDataSet.resp_responsavel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //habilitar_campos(false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_cadastro_funcionario v_cadastrologuin = new frm_cadastro_funcionario();
            v_cadastrologuin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string v_pequisa = "1=1 ";
            if (textBox1.Text.Length > 0)
            {
                v_pequisa += string.Format(" and [fun_nm] like '%{0}%'", textBox1.Text);
            }

            if (textBox2.Text.Length > 0)
            {
                v_pequisa += string.Format(" and [cargo_cd] = {0}", textBox2.Text);
            }

            viewlistafuncionarioBindingSource.Filter = v_pequisa;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            classe_PUBLICA.v_funcd = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            frm_cadastro_funcionario v_editar = new frm_cadastro_funcionario();
            v_editar.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //classe_PUBLICA.v_funcd = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //frm_cadastro_abertura_turmas v_aturmas = new frm_cadastro_abertura_turmas();
            //v_aturmas.ShowDialog();

            //classe_PUBLICA.v_funcd = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //frm_cadastro_abertura_turmas v_aturmas = new frm_cadastro_abertura_turmas();
            //v_aturmas.ShowDialog();

            //classe_PUBLICA.v_funcd = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //frm_cadastro_abertura_turmas v_aturmas = new frm_cadastro_abertura_turmas();
            //v_aturmas.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string v_codigo;
            //v_codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //Int32 v_posicao;
            //v_posicao = funcionarioBindingSource.Find("fun_cd", v_codigo);
            //funcionarioBindingSource.Position = v_posicao;
            //frm_tela_de_cadastro_login v_cadlogin = new frm_tela_de_cadastro_login();
            //v_cadlogin.ShowDialog();

            classe_PUBLICA.v_funcd = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Form v_aturmas = new frm_cadastro_funcionario();
            v_aturmas.ShowDialog();

            //classe_PUBLICA.v_funcd = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //frm_tela_de_cadastro_login v_aturmas = new frm_tela_de_cadastro_login();
            //v_aturmas.ShowDialog();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form v_relatoriofuncionarios = new frm_relatorio_funcionario();
            v_relatoriofuncionarios.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //FAZ COM QUE AO PRESSIONAR O ENTER (TECLA 13) FAÇA EXECUTAR ABAIXO
            if (e.KeyChar == 13)
            {
                string v_pequisa = "1=1 ";
                if (textBox1.Text.Length > 0)
                {
                    v_pequisa += string.Format(" and [fun_nm] like '%{0}%'", textBox1.Text);
                }

                if (textBox2.Text.Length > 0)
                {
                    v_pequisa += string.Format(" and [cargo_cd] = {0}", textBox2.Text);
                }

                viewlistafuncionarioBindingSource.Filter = v_pequisa;
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
                    v_pequisa += string.Format(" and [fun_nm] like '%{0}%'", textBox1.Text);
                }

                if (textBox2.Text.Length > 0)
                {
                    v_pequisa += string.Format(" and [cargo_cd] = {0}", textBox2.Text);
                }

                viewlistafuncionarioBindingSource.Filter = v_pequisa;
            }
        }
    }
}
