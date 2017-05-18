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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
             if ((txb_login_usuario.Text == "admin") && (txb_login_senha.Text == "123"))
            {
                //this.Visible = false;
                //frm_principal teste1 = new frm_principal();
                //teste1.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Usuário ou Senha Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Visible = false;
            //frm_principal teste1 = new frm_principal();
            //teste1.ShowDialog();
        }





        bool teste = true;

        //fazer com que a aplicação seja encerrada caso a janela seja fechada
        private void login_Load(object sender, EventArgs e)
        {
           //// frm_login teste = new frm_login();
           
           // if (teste)
           
           // {
           //     Application.Exit();
           // }












          // Form v_login = new login();
          // v_login.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          //  Form v_login = new login();
          //v_login.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
