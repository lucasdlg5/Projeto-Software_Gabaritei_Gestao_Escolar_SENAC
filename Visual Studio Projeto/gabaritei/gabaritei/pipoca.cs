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
    public partial class pipoca : Form
    {
        public pipoca()
        {
            InitializeComponent();
        }

        private void pipoca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gABARITEIDataSet.tipo_telefone' table. You can move, or remove it, as needed.
            this.tipo_telefoneTableAdapter.Fill(this.gABARITEIDataSet.tipo_telefone);
            // TODO: This line of code loads data into the 'gABARITEIDataSet.aluno' table. You can move, or remove it, as needed.
            this.alunoTableAdapter.Fill(this.gABARITEIDataSet.aluno);
            // TODO: This line of code loads data into the 'gABARITEIDataSet.aluno_telefone' table. You can move, or remove it, as needed.
            this.aluno_telefoneTableAdapter.Fill(this.gABARITEIDataSet.aluno_telefone);

        }
    }
}
