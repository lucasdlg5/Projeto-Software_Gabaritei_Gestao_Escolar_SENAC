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
    public partial class frm_logout : Form
    {
        public frm_logout()
        {
            InitializeComponent();
        }

        private void logout_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            classe_PUBLICA.v_logout = true;
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //frm_principal teste2 = new frm_principal();
            //teste2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            







            //Faz com que a janela fique em primeiro plano, 
            //e que a janela principal funcionará somente se ela for fechada, 

            //Há um problema, ao voltar para a tela de loguin, ao se fazer o logon novamente,
            //será aberta uma nova janela principal
            //entao deve-se fechar a janela principal ao clicar este botão
            this.Visible = false;
            frm_login v_tela_login = new frm_login();
            v_tela_login.ShowDialog();

            
           
        }
    }
}
