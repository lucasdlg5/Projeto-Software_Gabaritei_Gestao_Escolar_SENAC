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
    public partial class frm_splash : Form
    {
        public frm_splash()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
        Int32 v_tempo = 0;
        private void tmr_tempo_Tick(object sender, EventArgs e)
        {
            /*
            //teste teste teste teste teste teste teste teste teste teste 
            if (pgb_splash.Value < 100)
            {
                pgb_splash.Value = pgb_splash.Value + 2;
            }
            else
            {
                tmr_splash_tempo.Enabled = false;
                login frl = new login();
                frl.Show();
                this.Visible = false;
            }

            //fim teste fim teste fim teste fim teste fim teste fim teste fim teste 
            */
            // --------------------------------------------------------------------------------------------------
           
            
            //atual

            
            v_tempo = v_tempo + 1;
            if (v_tempo > 5)
            { Close(); }
            else if (v_tempo > 2)
            { lbl_splash_mensagem.Text = "Carregando Tabelas..."; }
            else if (v_tempo > 2)
            { lbl_splash_mensagem.Text = "Iniciando Plugins..."; }
            tmr_splash_tempo.Enabled = false;

            //frm_login frl = new frm_login();
            //frl.ShowDialog();

            //frm_principal _principal = new frm_principal();
            //_principal.Show();
            //this.Visible = false;
            this.Close();
              
            //fim atual
        }

        private void lbl_carregamento_Click(object sender, EventArgs e)
        {

            //v_tempo = v_tempo + 1;
            //if (v_tempo > 5)
            //{ Close(); }
            //else if (v_tempo > 2)
            //{ lbl_splash_mensagem.Text = "Abrindo Banco de dados..."; }
            //else if (v_tempo > 2)
            //{ lbl_splash_mensagem.Text = "Iniciando Plugins..."; }
            //tmr_splash_tempo.Enabled = false;
            //frm_login frl = new frm_login();
            //frl.Show();
            //this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
