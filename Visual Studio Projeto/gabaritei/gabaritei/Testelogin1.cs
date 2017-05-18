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
    public partial class Testelogin1 : Form
    {
        public Testelogin1()
        {
            InitializeComponent();
        }

        private void Testelogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GABARITEIDataSet.loginn' table. You can move, or remove it, as needed.
            this.loginnTableAdapter.Fill(this.GABARITEIDataSet.loginn);

        }
    }
}
