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
    public partial class Nota : Form
    {
        public Nota()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Portugues");
            treeView1.Nodes.Add("Matematica");
            treeView1.Nodes.Add("Geografia");
            treeView1.Nodes.Add("Biologia");
            treeView1.Nodes.Add("Quimica");
            treeView1.Nodes.Add("Fisíca");
            treeView1.Nodes.Add("Sociologia");
            treeView1.Nodes.Add("Filosofia");
            treeView1.Nodes.Add("Arte");
            treeView1.Nodes.Add("Educação Fisica");
        }

        private void Nota_Load(object sender, EventArgs e)
        {

        }
    }
}
