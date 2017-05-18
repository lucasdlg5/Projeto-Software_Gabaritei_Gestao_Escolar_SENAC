using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace gabaritei
{
    public partial class frm_login : Form
    {
        public frm_login()
        {

            InitializeComponent();
        }
        Boolean v_fechar = false;
        private void button2_Click(object sender, EventArgs e)
        {


            //TOLTIP teste LOGIN INVALIDO
            errorProvider1.Clear();
            if (txb_login_usuario.Text.Trim().Equals(""))
            {
                errorProvider1.SetError(txb_login_usuario, "A Senha é obrigatória!!");
                txb_login_senha.Focus();
                toolTip1.SetToolTip(txb_login_usuario, "teste");
                return;
                //MessageBox.Show("Teste2 envio \"" + txb_login_usuario.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }

            errorProvider1.Clear();
            if (txb_login_senha.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txb_login_senha, "A Senha é obrigatória!!");
                txb_login_usuario.Focus();
                toolTip1.SetToolTip(txb_login_senha, "teste");
                txb_login_senha.Focus();
                return;
                //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
            }
            loginnBindingSource.Filter =string.Format("cadloginn = '{0}'",txb_login_usuario.Text) ;
            if ((txb_login_usuario.Text.ToUpper() == textBox1.Text.ToUpper()) && (txb_login_senha.Text == textBox2.Text))
            {
                //this.Visible = false;
                //frm_principal teste1 = new frm_principal();
                //teste1.ShowDialog();
                v_fechar = true;
                this.Close();
                
                //frm_principal v_tela_login = new frm_principal();
                //v_tela_login.ShowDialog();
            }
            //else
            //    MessageBox.Show("Usuário ou Senha Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);




            // TOLTIP teste SENHA INVALIDO

            classe_PUBLICA.v_usuario = txb_login_usuario.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            v_fechar = true;
            Application.Exit();
            //this.Visible = false;
            //frm_principal teste1 = new frm_principal();
            //teste1.ShowDialog();
            
        }





        //  bool teste = true;

        //fazer com que a aplicação seja encerrada caso a janela seja fechada
        private void login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GABARITEIDataSet.loginn' table. You can move, or remove it, as needed.
            this.loginnTableAdapter.Fill(this.GABARITEIDataSet.loginn);
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

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void txb_login_senha_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txb_login_senha_KeyPress(object sender, KeyPressEventArgs e)
        {

            //FAZ COM QUE AO PRESSIONAR O ENTER (TECLA 13) FAÇA EXECUTAR ABAIXO
            if (e.KeyChar == 13)
            {
                //TOLTIP teste LOGIN INVALIDO
                errorProvider1.Clear();
                if (txb_login_usuario.Text.Trim().Equals(""))
                {
                    errorProvider1.SetError(txb_login_usuario, "A Senha é obrigatória!!");
                    txb_login_senha.Focus();
                    toolTip1.SetToolTip(txb_login_usuario, "teste");
                    return;
                    //MessageBox.Show("Teste2 envio \"" + txb_login_usuario.Text + "\".", "Teste3", MessageBoxButtons.OK);
                }

                errorProvider1.Clear();
                if (txb_login_senha.Text.Trim().Length == 0)
                {
                    errorProvider1.SetError(txb_login_senha, "A Senha é obrigatória!!");
                    txb_login_usuario.Focus();
                    toolTip1.SetToolTip(txb_login_senha, "teste");
                    txb_login_senha.Focus();
                    return;
                    //MessageBox.Show("Teste2 envio \"" + txb_login_senha.Text + "\".", "Teste3", MessageBoxButtons.OK);
                }


                loginnBindingSource.Filter = string.Format("cadloginn = '{0}'", txb_login_usuario.Text);
                if ((txb_login_usuario.Text.ToUpper() == textBox1.Text.ToUpper()) && (txb_login_senha.Text == textBox2.Text))
                //if ((txb_login_usuario.Text == "admin") && (txb_login_senha.Text == "123"))
                {
                    //this.Visible = false;
                    //frm_principal teste1 = new frm_principal();
                    //teste1.ShowDialog();
                    v_fechar = true;
                    this.Close();
                    
                    //frm_principal v_tela_login = new frm_principal();
                    //v_tela_login.ShowDialog();
                }
                //else
                //    MessageBox.Show("Usuário ou Senha Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);




                // TOLTIP teste SENHA INVALIDO

                classe_PUBLICA.v_usuario = txb_login_usuario.Text;
            }
        }

        private void frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (v_fechar == false)
            {
                e.Cancel = true;
            }
        }
    }
}
//}
//}
