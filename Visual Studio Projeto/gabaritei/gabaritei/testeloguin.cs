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
    public partial class testeloguin : Form
    {
        public testeloguin()
        {
            InitializeComponent();
        }

        private void testeloguin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GABARITEIDataSet.aluno' table. You can move, or remove it, as needed.
            this.alunoTableAdapter.Fill(this.GABARITEIDataSet.aluno);
            // TODO: This line of code loads data into the 'GABARITEIDataSet.aluno' table. You can move, or remove it, as needed.
 
            // TODO: This line of code loads data into the 'GABARITEIDataSet.loginn' table. You can move, or remove it, as needed.
            //this.loginnTableAdapter.Fill(this.GABARITEIDataSet.loginn);

            this.reportViewer1.RefreshReport();
        }
    }
}
