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
    public partial class frm_relatorios_turmas : Form
    {
        public frm_relatorios_turmas()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {


            // Determine which item was clicked/activated.
            MessageBox.Show("You clicked " + listView1.SelectedItems[0].Text );
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
