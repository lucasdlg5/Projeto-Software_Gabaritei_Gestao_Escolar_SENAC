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
    public partial class frm_prof_lanc_presenc : Form
    {
        public frm_prof_lanc_presenc()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ---------------------------------------------------------------------------------  
            // ---------------------- Turma 2013 -----------------------------------------------

            tvw_prof_lanc_presenc.Nodes.Add("Turma 2013");
            tvw_prof_lanc_presenc.Nodes[0].Nodes.Add("Turma Manhã");
            tvw_prof_lanc_presenc.Nodes[0].Nodes[0].Nodes.Add("TI-AM13");
            tvw_prof_lanc_presenc.Nodes[0].Nodes[0].Nodes.Add("TI-BM13");
            tvw_prof_lanc_presenc.Nodes[0].Nodes[0].Nodes.Add("TI-CM13");
            tvw_prof_lanc_presenc.Nodes[0].Nodes[0].Nodes.Add("TI-DM13");

            tvw_prof_lanc_presenc.Nodes[0].Nodes.Add("Turma Tarde");
            tvw_prof_lanc_presenc.Nodes[0].Nodes[1].Nodes.Add("TI-AT13");
            tvw_prof_lanc_presenc.Nodes[0].Nodes[1].Nodes.Add("TI-BT13");
            tvw_prof_lanc_presenc.Nodes[0].Nodes[1].Nodes.Add("TI-CT13");
            tvw_prof_lanc_presenc.Nodes[0].Nodes[1].Nodes.Add("TI-DT13");

            tvw_prof_lanc_presenc.Nodes[0].Nodes.Add("Turma Noite");
            tvw_prof_lanc_presenc.Nodes[0].Nodes[2].Nodes.Add("TI-AN13");
            tvw_prof_lanc_presenc.Nodes[0].Nodes[2].Nodes.Add("TI-BN13");
            tvw_prof_lanc_presenc.Nodes[0].Nodes[2].Nodes.Add("TI-CN13");
            tvw_prof_lanc_presenc.Nodes[0].Nodes[2].Nodes.Add("TI-DN13");

            // ---------------------------------------------------------------------------------
            // ---------------------- Turma 2014 -----------------------------------------------

            tvw_prof_lanc_presenc.Nodes.Add("Turma 2014");
            tvw_prof_lanc_presenc.Nodes[1].Nodes.Add("Turma Manhã");
            tvw_prof_lanc_presenc.Nodes[1].Nodes[0].Nodes.Add("TI-AM14");
            tvw_prof_lanc_presenc.Nodes[1].Nodes[0].Nodes.Add("TI-BM14");
            tvw_prof_lanc_presenc.Nodes[1].Nodes[0].Nodes.Add("TI-CM14");
            tvw_prof_lanc_presenc.Nodes[1].Nodes[0].Nodes.Add("TI-DM14");

            tvw_prof_lanc_presenc.Nodes[1].Nodes.Add("Turma Tarde");
            tvw_prof_lanc_presenc.Nodes[1].Nodes[1].Nodes.Add("TI-AT14");
            tvw_prof_lanc_presenc.Nodes[1].Nodes[1].Nodes.Add("TI-BT14");
            tvw_prof_lanc_presenc.Nodes[1].Nodes[1].Nodes.Add("TI-CT14");
            tvw_prof_lanc_presenc.Nodes[1].Nodes[1].Nodes.Add("TI-DT14");

            tvw_prof_lanc_presenc.Nodes[1].Nodes.Add("Turma Noite");
            tvw_prof_lanc_presenc.Nodes[1].Nodes[2].Nodes.Add("TI-AN14");
            tvw_prof_lanc_presenc.Nodes[1].Nodes[2].Nodes.Add("TI-BN14");
            tvw_prof_lanc_presenc.Nodes[1].Nodes[2].Nodes.Add("TI-CN14");
            tvw_prof_lanc_presenc.Nodes[1].Nodes[2].Nodes.Add("TI-DN14");
            // --------------------------------------------------------------------------------- 
            // ---------------------- Turma 2015 -----------------------------------------------
            tvw_prof_lanc_presenc.Nodes.Add("Turma 2015");
            tvw_prof_lanc_presenc.Nodes[2].Nodes.Add("Turma Manhã");
            tvw_prof_lanc_presenc.Nodes[2].Nodes[0].Nodes.Add("TI-AM15");
            tvw_prof_lanc_presenc.Nodes[2].Nodes[0].Nodes.Add("TI-BM15");
            tvw_prof_lanc_presenc.Nodes[2].Nodes[0].Nodes.Add("TI-CM15");
            tvw_prof_lanc_presenc.Nodes[2].Nodes[0].Nodes.Add("TI-DM15");

            tvw_prof_lanc_presenc.Nodes[2].Nodes.Add("Turma Tarde");
            tvw_prof_lanc_presenc.Nodes[2].Nodes[1].Nodes.Add("TI-AT15");
            tvw_prof_lanc_presenc.Nodes[2].Nodes[1].Nodes.Add("TI-BT15");
            tvw_prof_lanc_presenc.Nodes[2].Nodes[1].Nodes.Add("TI-CT15");
            tvw_prof_lanc_presenc.Nodes[2].Nodes[1].Nodes.Add("TI-DT15");

            tvw_prof_lanc_presenc.Nodes[2].Nodes.Add("Turma Noite");
            tvw_prof_lanc_presenc.Nodes[2].Nodes[2].Nodes.Add("TI-AN15");
            tvw_prof_lanc_presenc.Nodes[2].Nodes[2].Nodes.Add("TI-BN15");
            tvw_prof_lanc_presenc.Nodes[2].Nodes[2].Nodes.Add("TI-CN15");
            tvw_prof_lanc_presenc.Nodes[2].Nodes[2].Nodes.Add("TI-DN15");
            // --------------------------------------------FIM -------------------------------
        }

        private void professores_lancamento_de_presenca_Load(object sender, EventArgs e)
        {
         //   this.Visible = false;
           // frm_prof_lanc_presenc teste1 = new frm_prof_lanc_presenc();
            //teste1.ShowDialog();
        }

        private void btn_lanc_presenc_voltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
           // frm_principal teste2 = new frm_principal();
           // teste2.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
