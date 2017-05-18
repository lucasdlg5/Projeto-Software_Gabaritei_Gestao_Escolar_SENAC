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
    public partial class frm_relatorios_principal : Form
    {
        public frm_relatorios_principal()
        {
            InitializeComponent();
        }

        private void frm_principal_relatorios_Load(object sender, EventArgs e)
        {

            // this.reportViewer1.RefreshReport();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

            //MessageBox.Show(listView1.SelectedItems[0].Index.ToString());
            if (listView1.SelectedItems[0].Index.ToString() == "0")
            {

            }
            switch (listView1.SelectedItems[0].Index)
            {
                case (0):
                     Form v_testelog = new testeloguin();
                    v_testelog.ShowDialog();
                    break;
                    //frm_relatorios_alunos v_re_alu = new frm_relatorios_alunos();
                    //v_re_alu.ShowDialog();
                    break;

                case (1):
                                       
                    frm_relatorio_funcionario v_re_fun = new frm_relatorio_funcionario();
                    v_re_fun.ShowDialog();
                    break;
                case (2):
                    frm_relatorios_professores v_re_prof = new frm_relatorios_professores();
                    v_re_prof.ShowDialog();
                    break;
                case (3):
                    frm_relatorios_turmas v_re_turm = new frm_relatorios_turmas();
                    v_re_turm.ShowDialog();
                    break;
                //outro caso 
                default:
                    frm_relatorios_materias v_re_mat = new frm_relatorios_materias();
                    v_re_mat.ShowDialog();
                    break;

              
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DockChanged(object sender, EventArgs e)
        {

        }
    }
}
