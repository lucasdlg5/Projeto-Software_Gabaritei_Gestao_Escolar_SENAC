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
    public partial class frm_utilitarios : Form
    {
        public frm_utilitarios()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        private void chb_princ_alun_indice_CheckedChanged(object sender, EventArgs e)
        {
            crt_princ_alun_graf.Visible = chb_princ_alun_indice.Checked;

            //o Ponto de exclamação fez com que executasse o inverso
            groupBox3.Visible = !chb_princ_alun_indice.Checked;
        }
    }
}
