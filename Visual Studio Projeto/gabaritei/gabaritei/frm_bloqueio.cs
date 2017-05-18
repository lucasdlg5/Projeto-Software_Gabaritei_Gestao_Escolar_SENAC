using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Bloqueio
using System.Diagnostics;
//Bloqueio

namespace gabaritei
{
    public partial class frm_bloqueio : Form
    {
        public frm_bloqueio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _nomeArquivo = "Rundll32.exe";
            string _argumentos = "User32.dll, LockWorkStation";
            ProcessStartInfo _inicioInfo = new ProcessStartInfo(_nomeArquivo, _argumentos);
            Process.Start(_inicioInfo);
            this.Close();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Visible = false;
            //frm_principal teste2 = new frm_principal();
           // teste2.ShowDialog();
        }
    }
}
