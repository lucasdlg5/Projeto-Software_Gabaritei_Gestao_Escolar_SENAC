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
            Form splash = new frm_splash();
            splash.ShowDialog();
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
            //teste MDI Fundo Cor
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    //control.BackColor = Color.Gainsboro;
                    control.BackColor = Color.WhiteSmoke;
                    break;
                }
            }

            //teste MDI Fundo Cor

            frm_login v_tela_login = new frm_login();
            v_tela_login.ShowDialog();


            // faz com que sejha exibido quem está logado
            toolStripStatusLabel2.Text = classe_PUBLICA.v_usuario;
            //ERRADO, LUGAR ERRADO
            //if (this.WindowState == FormWindowState.Minimized)
            //{
            //    this.Hide();
            //}


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

            ////this.Visible = false;
            //frm_prof_lanc_presenc teste1 = new frm_prof_lanc_presenc();
            //teste1.MdiParent = this;
            //teste1.Show();
            //teste1.Focus();

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

            //this.Visible = false;
            frm_list_alun_dados teste4 = new frm_list_alun_dados();
            teste4.MdiParent = this;
            teste4.Show();
            teste4.Focus();


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
            ////  this.Visible = false;
            //frm_prof_lanc_presenc teste1 = new frm_prof_lanc_presenc();
            //teste1.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {

        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //frm_curso teste5 = new frm_curso();
            //teste5.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //frm_curso teste2 = new frm_curso();
            //teste2.ShowDialog();
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

            frm_sobre2 teste3 = new frm_sobre2();
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
            ////this.Visible = false;
            //frm_list_alun_dados teste4 = new frm_list_alun_dados();
            //teste4.ShowDialog();
        }

        private void turmasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //this.Visible = false;
            Frm_lista_turmas v_turmas = new Frm_lista_turmas();
            v_turmas.Show();
        }

        private void tsb_princ_btn_calendario_Click(object sender, System.EventArgs e)
        {

        }

        private void cadastroDeFuncionariosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            classe_PUBLICA.v_funcd = "0";
            frm_cadastro_funcionario teste7 = new frm_cadastro_funcionario();
            teste7.MdiParent = this;
            teste7.Show();
            teste7.Focus();



            // teste
            //quanbdo o botão for clicado, fazer a condição
            //string v_testa;
            //v_testa = tela_de_cadastro_login;
            //if (v_testa)



            ////teste
        }

        private void cadastroDeAlunosToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {

            classe_PUBLICA.v_alutcd = "0";
            classe_PUBLICA.v_alunocd = "0";
            classe_PUBLICA.v_responcd = "0";
            frm_cadastro_aluno v_cadastro = new frm_cadastro_aluno();
            v_cadastro.MdiParent = this;
            v_cadastro.Show();
            v_cadastro.Focus();



        }

        private void button1_Click_1(object sender, System.EventArgs e)
        {
            frm_cadastro_funcionario teste7 = new frm_cadastro_funcionario();
            teste7.ShowDialog();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Form v_janela_nota_aluno_indv = new frm_janela_nota_aluno_indv();
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
            Frm_lista_turmas v_turmas = new Frm_lista_turmas();
            v_turmas.Show();
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            //this.Visible = false;
            //frm_prof_lanc_presenc teste1 = new frm_prof_lanc_presenc();
            //teste1.ShowDialog();
        }

        private void tsb_princ_btn_lanc_notas_Click(object sender, System.EventArgs e)
        {

            classe_PUBLICA.v_lnotascd = "0";

            frm_lançamento_notas lac_notas = new frm_lançamento_notas();
            lac_notas.MdiParent = this;
            lac_notas.Show();
            lac_notas.Focus();
        }

        private void button9_Click(object sender, System.EventArgs e)
        {
            //this.Visible = false;
            //frm_curso teste2 = new frm_curso();
            //teste2.ShowDialog();
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

            notifyIcon1.ShowBalloonTip(10000, "Gabaritei - Gestão Escolar", "O programa ainda está em execução, para encerrar, clique com o botão Direito no ícone", ToolTipIcon.Info);

            this.Hide();

            //FAZ COM QUE AO MINIMIZAR A TELA, ELE SEJA LEVADO PARA A BANDEIJA, NAO ATIVAR
            //if (this.WindowState == FormWindowState.Minimized)
            //{
            //    notifyIcon1.ShowBalloonTip(10000, "Gabaritei - Gestão Escolar", "O programa ainda está em execução, para encerrar, clique com o botão Direito no ícone", ToolTipIcon.Info);

            //    this.Hide();
            //}

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

            frm_logout v_logout = new frm_logout();
            v_logout.ShowDialog();
            if (classe_PUBLICA.v_logout == true)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void cadastroDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //classe_PUBLICA.v_acmateriacd = "0";
            //frm_adicao_materias cadastro_turmas = new frm_adicao_materias();
            //cadastro_turmas.MdiParent = this;
            //cadastro_turmas.Show();
            //cadastro_turmas.Focus();
        }

        private void detalhesDoAlunoNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form v_janela_nota_aluno_indv = new frm_janela_nota_aluno_indv();
            v_janela_nota_aluno_indv.MdiParent = this;
            v_janela_nota_aluno_indv.Show();
            v_janela_nota_aluno_indv.Focus();
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
            utilitarios.MdiParent = this;
            utilitarios.Show();
            utilitarios.Focus();

        }

        private void listaDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_lista_funcionarios lista_funcionarios = new frm_lista_funcionarios();
            lista_funcionarios.MdiParent = this;
            lista_funcionarios.Show();
            lista_funcionarios.Focus();
        }

        private void listaDeTurmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_lista_turmas lista_turmas = new Frm_lista_turmas();
            lista_turmas.MdiParent = this;
            lista_turmas.Show();
            lista_turmas.Focus();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            //toolStripStatusLabel2.Text = classe_PUBLICA.v_usuario;
        }

        private void matériasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_lista_materias v_materias = new frm_lista_materias();
            v_materias.Show();
        }

        private void cadastroDeMatériasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            classe_PUBLICA.v_acmateriacd2 = "0";
            classe_PUBLICA.v_cmateriacd = "0";
            frm_cadastro_materias v_materias1 = new frm_cadastro_materias();
            v_materias1.Show();
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            frm_backup v_backup = new frm_backup();
            v_backup.ShowDialog();
        }

        private void aberturaDeTurmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            classe_PUBLICA.v_turmascd = "0";
            frm_cadastro_abertura_turmas v_abertura = new frm_cadastro_abertura_turmas();
            v_abertura.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");

        }

        private void iniciarExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string app = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office 2013\Excel 2013.lnk";
            System.Diagnostics.Process process = System.Diagnostics.Process.Start(app);

        }

        private void iniciarMicrosoftWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");

        }

        private void iniciarMicrosoftPowerPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("powerpnt");

        }

        private void iniciarBlocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");

        }

        private void iniciarFerramentaDeCapturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string app = @"C:\Windows\System32\SnippingTool.exe";
            System.Diagnostics.Process process = System.Diagnostics.Process.Start(app);


        }

        private void abrirNavegadorPadrãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string app = @"C:\Program Files\Internet Explorer\iexplore.exe";
            string param = "http://google.com.br";
            System.Diagnostics.Process process = System.Diagnostics.Process.Start(/*app,*/ param);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            //MessageBox.Show("Você deseja sair do programa?", "Sair do programa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (MessageBox.Show("Você deseja sair do programa?", "Sair do programa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                //Application.Exit();
                this.Close();
            }

            //else
            //{
            //    //this.Close();
            //}

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel5.Text = DateTime.Now.ToLongTimeString();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            frm_relatorios_principal v_relatorio = new frm_relatorios_principal();
            v_relatorio.Show();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            //testeloguin ll = new testeloguin();
            //ll.ShowDialog();
        }

        private void testeloginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Testelogin1 testelogin1 = new Testelogin1();
            testelogin1.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastroDeLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            classe_PUBLICA.v_cafuncd = "0";
            Form v_login = new frm_cadastro_login();
            v_login.ShowDialog();
        }

        private void cadastroDeCargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            classe_PUBLICA.v_cargocd = "0";
            Form v_cargo = new frm_cadastrar_cargo();
            v_cargo.ShowDialog();

        }

        private void iniciarMicrosoftEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void iniciarMicrosoftAccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("msaccess");
        }

        private void cadastroDeMatériasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            classe_PUBLICA.v_acmateriacd2 = "0";
            Form v_materia = new frm_cadastro_adicao_materia();
            v_materia.ShowDialog();
            
        }

        private void cadastroDeCidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            classe_PUBLICA.v_cidadecd = "0";
            Form v_cadastrociade = new frm_cadastro_cidade();
            v_cadastrociade.ShowDialog();
        }

        private void toolStripButton9_Click_1(object sender, EventArgs e)
        {
            Form teste = new testeloguin();
            teste.Show();
        }

        private void cadastroTipoTelefoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            classe_PUBLICA.v_cadtelcd = "0";
            Form v_categoriatel = new frm_cadastro_categoria_telefone();
            v_categoriatel.ShowDialog();
        }

        private void gerarRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form v_relatorioprofessores = new frm_relatorios_professores();
            v_relatorioprofessores.ShowDialog();
        }

        private void cadastroDeTipoDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            classe_PUBLICA.v_tipousercd = "0";
            Form v_cadastrotipouser = new frm_cadastro_tipo_usuario();
            v_cadastrotipouser.ShowDialog();
        }




    }

}



//Por alguma razão, essa chave está ficando vermelho após escrever os códigos para que o sistema minimizasse na barra de tarefas :(
//}
