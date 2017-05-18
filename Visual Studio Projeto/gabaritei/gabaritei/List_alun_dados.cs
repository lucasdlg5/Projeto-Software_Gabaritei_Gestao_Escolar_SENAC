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
 

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_list_alun_dados_turmas.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //frm_principal teste2 = new frm_principal();
            //teste2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_cadastro_aluno cadastro_aluno = new frm_cadastro_aluno();
            cadastro_aluno.ShowDialog();
            //this.Visible = false;

        }
    }
}
