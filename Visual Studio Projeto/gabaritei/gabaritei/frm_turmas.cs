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
    public partial class frm_turmas : Form
    {
        public frm_turmas()
        {
            InitializeComponent();
        }

        private void frm_turmas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //frm_principal teste2 = new frm_principal();
            //teste2.ShowDialog();
        }
    }
}
