using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// teste bloqueio

//Já tem no programa
//using System;
//using System.Windows.Forms;


using System.Diagnostics;

//fim teste bloqueio


namespace gabaritei
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {

            // com conflito


                      //Variavel do formulario Splash
                      //Form teste1 = new frm_principal();
                      //Abrir a janela do Splash, fazendo com que ela seja a principal, com que não funcione até que feche a janela
                      // teste1.ShowDialog();


            // com conflito

            //Inicializar os componentes
           InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void principal_Load(object sender, EventArgs e)
        {
            frm_login v_tela_login = new frm_login();
            v_tela_login.ShowDialog();
         //ERRADO, LUGAR ERRADO
         //if (this.WindowState == FormWindowState.Minimized)
         //   {
         //       this.Hide();
         //   }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void tIBT14ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trdeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lançamentoDePresençaToolStripMenuItem_Click(object sender, EventArgs e)
        {


            //ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR 

            //this.Visible = false;
            frm_prof_lanc_presenc teste1 = new frm_prof_lanc_presenc();
            teste1.ShowDialog();

            //ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR ARRUMAR 
   
            
     /*     Boolean v_teste1;
            if (v_teste1 = false) ;
            {
                this.Visible = false;
                professores_lancamento_de_presenca = new professores_lancamento_de_presenca();
                new professores_lancamento_de_presenca.ShowDialog();
            } 
    */
           // Form v_lancamentodepresenca = new frm_prof_lanc_presenc();
           // v_lancamentodepresenca.Show();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            //this.Visible = false;
            //Form v_turmas = new frm_turmas();
            //v_turmas.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_alunos_Click(object sender, EventArgs e)
        {

            
          // antigo Form v_lista_alunos_dados = new frm_list_alun_dados();
          // antigo  v_lista_alunos_dados.Show();

            //this.Visible = false;
            //frm_list_alun_dados teste4 = new frm_list_alun_dados();
            //teste4.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
              
           // crt_princ_alun_graf.Visible = chb_princ_alun_indice.Checked;

            //o Ponto de exclamação fez com que executasse o inverso
            //groupBox3.Visible = !chb_princ_alun_indice.Checked;

            //ERRADO FAZ COM QUE A JANELA TENHA A PROPRIEDADE IsMDIContainer AO CLICAR NO BOTÃO
            //this.IsMDIContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  this.Visible = false;
            frm_prof_lanc_presenc teste1 = new frm_prof_lanc_presenc();
            teste1.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {

        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_curso teste5 = new frm_curso();
            teste5.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_curso teste2 = new frm_curso();
            teste2.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frm_bloqueio teste6 = new frm_bloqueio();
            teste6.ShowDialog();


           //Testar  MessageBox.Show("teste1", "teste2", MessageBoxButtons.YesNo);
            //bloqueio

                        //string _nomeArquivo = "Rundll32.exe";
                        //string _argumentos = "User32.dll, LockWorkStation";
                        //ProcessStartInfo _inicioInfo = new ProcessStartInfo(_nomeArquivo, _argumentos);
                        //Process.Start(_inicioInfo);
                        //this.Close();

            //bloqueio
        }

        private void tsb_princ_btn_sobre_Click(object sender, EventArgs e)
        {
            
            frm_sobre teste3 = new frm_sobre();
            teste3.ShowDialog();
        }

        private void cadastroDeAlunosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //PARA ABRIR A JANELA CADASTRO DE ALUNOS
            //Form v_janela_nota_aluno_indv = new janela_nota_aluno_indv();
            //v_janela_nota_aluno_indv.Show();
        }

        private void alunosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //this.Visible = false;
            frm_list_alun_dados teste4 = new frm_list_alun_dados();
            teste4.ShowDialog();
        }

        private void turmasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //this.Visible = false;
            Form v_turmas = new frm_turmas();
            v_turmas.Show();
        }

        private void tsb_princ_btn_calendario_Click(object sender, System.EventArgs e)
        {

        }

        private void cadastroDeFuncionariosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            tela_de_cadastro_login teste7 = new tela_de_cadastro_login();
            teste7.ShowDialog();

        

            // teste
            //quanbdo o botão for clicado, fazer a condição
            //string v_testa;
            //v_testa = tela_de_cadastro_login;
            //if (v_testa)

          

            ////teste
        }

        private void cadastroDeAlunosToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {

            frm_cadastro_aluno v_cadastro = new frm_cadastro_aluno();
            v_cadastro.Show();



        }

        private void button1_Click_1(object sender, System.EventArgs e)
        {
            tela_de_cadastro_login teste7 = new tela_de_cadastro_login();
            teste7.ShowDialog();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Form v_janela_nota_aluno_indv = new janela_nota_aluno_indv();
            v_janela_nota_aluno_indv.Show();
        }

        private void listaDeCadastradosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            frm_list_alun_dados teste4 = new frm_list_alun_dados();
            teste4.ShowDialog();
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            Form v_turmas = new frm_turmas();
            v_turmas.Show();
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            frm_prof_lanc_presenc teste1 = new frm_prof_lanc_presenc();
            teste1.ShowDialog();
        }

        private void tsb_princ_btn_lanc_notas_Click(object sender, System.EventArgs e)
        {

        }

        private void button9_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            frm_curso teste2 = new frm_curso();
            teste2.ShowDialog();
        }

        private void button10_Click(object sender, System.EventArgs e)
        {
            frm_bloqueio teste6 = new frm_bloqueio();
            teste6.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, System.EventArgs e)
        {

        }

        private void button11_Click(object sender, System.EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {


        }

        private void teste1ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //RestaurarApp();
        }








        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        private void testeBalãoNotificaçãoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
                        // Faz com que abra um balão dizendo que o programa ainda está em execução
            //Fazer com que funcione assim que a opção de "Minimizar à bandeja" seja clicada
            //mostrando a mensagem de que ainda está sendo executado
            // OK   OK   OK   OK   OK   OK   OK   OK   OK   OK   OK   OK   OK   OK   OK   
            // Linha comentada abaixo movida para a linha do principal_Resize
            //Ao minimizar, é mostrado o balão
         //   notifyIcon1.ShowBalloonTip(10000, "Gabaritei - Gestão Escolar", "O programa ainda está em execução, para encerrar, clique com o botão Direito no ícone", ToolTipIcon.Info);

        }
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR









        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        private void sairDoProgramaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR






        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
    // TESTE TESTE TESTE MINIMIZE TO TRAY


        //fazer com que ao restaurar o programa, retorne na tela de login
        private void RestaurarApp()
        {
             if (!this.Visible)
            {
                this.Show();
                this.WindowState = FormWindowState.Maximized;
                frm_login login = new frm_login();
                login.ShowDialog();
            }


        }
    // TESTE TESTE TESTE MINIMIZE TO TRAY
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR












        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        
        // fazer com que esta propriedade funcione ao clicar o botãop para minimizar na bandeija
        // do formulário Logout
        // e que ao restaurar o programa, retorne na tela de Login
        private void principal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.ShowBalloonTip(10000, "Gabaritei - Gestão Escolar", "O programa ainda está em execução, para encerrar, clique com o botão Direito no ícone", ToolTipIcon.Info);

                this.Hide();
            }

        }

        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR













        private void notifyIcon1_MouseDoubleClick_1(object sender, System.Windows.Forms.MouseEventArgs e)
        {
        
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }










        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        private void restaurarProgramaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            RestaurarApp();
        }
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR

















        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        private void notifyIcon1_MouseDoubleClick_2(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            RestaurarApp();
        }
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR










        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            RestaurarApp();
            // contextMenuStrip1.Show();
          //  contextMenuStrip1.Show(PointToScreen(e.Location));

        }
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR
        // teste teste teste teste teste teste  MINIMIOZAR A JANELA AO CLICAR MINIMIZAR


        private void toolStripButton5_Click(object sender, EventArgs e)
        {

            logout v_logout = new logout();
            v_logout.ShowDialog();
            if (classe_PUBLICA.v_logout == true)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void cadastroDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadastro_turmas cadastro_turmas = new frm_cadastro_turmas();
            cadastro_turmas.ShowDialog();
        }

        private void detalhesDoAlunoNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form v_janela_nota_aluno_indv = new janela_nota_aluno_indv();
            v_janela_nota_aluno_indv.Show();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void listaDeFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frm_utilitarios utilitarios = new frm_utilitarios();
            utilitarios.ShowDialog();

        }




        }
    
    }



//Por alguma razão, essa chave está ficando vermelho após escrever os códigos para que o sistema minimizasse na barra de tarefas :(
//}
