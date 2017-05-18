namespace gabaritei
{
    partial class frm_principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.tsp_principal = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.cadastroDeFuncionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeAlunosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aberturaDeTurmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeMatériasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeMatériasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroTipoTelefoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.listaDeFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeTurmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matériasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_principal_alunos = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsb_princ_btn_lanc_notas = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.tsb_princ_btn_sobre = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restaurarProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirUtilitáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirNavegadorPadrãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarBlocoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarMicrosoftWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarMicrosoftPowerPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarMicrosoftEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarMicrosoftAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairDoProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cadastroDeTipoDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_principal.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsp_principal
            // 
            this.tsp_principal.BackColor = System.Drawing.SystemColors.Control;
            this.tsp_principal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsp_principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsp_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.btn_principal_alunos,
            this.toolStripDropDownButton2,
            this.toolStripButton7,
            this.toolStripButton3,
            this.toolStripButton5,
            this.tsb_princ_btn_sobre,
            this.toolStripButton6,
            this.toolStripButton4,
            this.toolStripButton8});
            this.tsp_principal.Location = new System.Drawing.Point(0, 0);
            this.tsp_principal.Name = "tsp_principal";
            this.tsp_principal.Size = new System.Drawing.Size(1276, 27);
            this.tsp_principal.TabIndex = 0;
            this.tsp_principal.Text = "toolStrip1";
            this.tsp_principal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeFuncionariosToolStripMenuItem,
            this.cadastroDeAlunosToolStripMenuItem1,
            this.aberturaDeTurmasToolStripMenuItem,
            this.cadastroDeMatériasToolStripMenuItem,
            this.cadastroDeLoginToolStripMenuItem,
            this.cadastroDeCargoToolStripMenuItem,
            this.cadastroDeMatériasToolStripMenuItem1,
            this.cadastroDeCidadeToolStripMenuItem,
            this.cadastroTipoTelefoneToolStripMenuItem,
            this.cadastroDeTipoDeUsuárioToolStripMenuItem});
            this.toolStripButton1.Image = global::gabaritei.Properties.Resources._1431652941_file_add;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(114, 24);
            this.toolStripButton1.Text = "Cadastro";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_2);
            // 
            // cadastroDeFuncionariosToolStripMenuItem
            // 
            this.cadastroDeFuncionariosToolStripMenuItem.Name = "cadastroDeFuncionariosToolStripMenuItem";
            this.cadastroDeFuncionariosToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.cadastroDeFuncionariosToolStripMenuItem.Text = "Cadastro de Funcionarios";
            this.cadastroDeFuncionariosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFuncionariosToolStripMenuItem_Click);
            // 
            // cadastroDeAlunosToolStripMenuItem1
            // 
            this.cadastroDeAlunosToolStripMenuItem1.Name = "cadastroDeAlunosToolStripMenuItem1";
            this.cadastroDeAlunosToolStripMenuItem1.Size = new System.Drawing.Size(316, 22);
            this.cadastroDeAlunosToolStripMenuItem1.Text = "Cadastro de Alunos";
            this.cadastroDeAlunosToolStripMenuItem1.Click += new System.EventHandler(this.cadastroDeAlunosToolStripMenuItem1_Click);
            // 
            // aberturaDeTurmasToolStripMenuItem
            // 
            this.aberturaDeTurmasToolStripMenuItem.Name = "aberturaDeTurmasToolStripMenuItem";
            this.aberturaDeTurmasToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.aberturaDeTurmasToolStripMenuItem.Text = "Abertura de Turmas";
            this.aberturaDeTurmasToolStripMenuItem.Click += new System.EventHandler(this.aberturaDeTurmasToolStripMenuItem_Click);
            // 
            // cadastroDeMatériasToolStripMenuItem
            // 
            this.cadastroDeMatériasToolStripMenuItem.Name = "cadastroDeMatériasToolStripMenuItem";
            this.cadastroDeMatériasToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.cadastroDeMatériasToolStripMenuItem.Text = "Cadastro de Matérias/Turmas";
            this.cadastroDeMatériasToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeMatériasToolStripMenuItem_Click);
            // 
            // cadastroDeLoginToolStripMenuItem
            // 
            this.cadastroDeLoginToolStripMenuItem.Name = "cadastroDeLoginToolStripMenuItem";
            this.cadastroDeLoginToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.cadastroDeLoginToolStripMenuItem.Text = "Cadastro de Login";
            this.cadastroDeLoginToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeLoginToolStripMenuItem_Click);
            // 
            // cadastroDeCargoToolStripMenuItem
            // 
            this.cadastroDeCargoToolStripMenuItem.Name = "cadastroDeCargoToolStripMenuItem";
            this.cadastroDeCargoToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.cadastroDeCargoToolStripMenuItem.Text = "Cadastro de Cargo";
            this.cadastroDeCargoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCargoToolStripMenuItem_Click);
            // 
            // cadastroDeMatériasToolStripMenuItem1
            // 
            this.cadastroDeMatériasToolStripMenuItem1.Name = "cadastroDeMatériasToolStripMenuItem1";
            this.cadastroDeMatériasToolStripMenuItem1.Size = new System.Drawing.Size(316, 22);
            this.cadastroDeMatériasToolStripMenuItem1.Text = "Cadastro de Matérias";
            this.cadastroDeMatériasToolStripMenuItem1.Click += new System.EventHandler(this.cadastroDeMatériasToolStripMenuItem1_Click);
            // 
            // cadastroDeCidadeToolStripMenuItem
            // 
            this.cadastroDeCidadeToolStripMenuItem.Name = "cadastroDeCidadeToolStripMenuItem";
            this.cadastroDeCidadeToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.cadastroDeCidadeToolStripMenuItem.Text = "Cadastro de Cidade";
            this.cadastroDeCidadeToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCidadeToolStripMenuItem_Click);
            // 
            // cadastroTipoTelefoneToolStripMenuItem
            // 
            this.cadastroTipoTelefoneToolStripMenuItem.Name = "cadastroTipoTelefoneToolStripMenuItem";
            this.cadastroTipoTelefoneToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.cadastroTipoTelefoneToolStripMenuItem.Text = "Cadastro tipo Telefone";
            this.cadastroTipoTelefoneToolStripMenuItem.Click += new System.EventHandler(this.cadastroTipoTelefoneToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeFuncionáriosToolStripMenuItem,
            this.listaDeTurmasToolStripMenuItem,
            this.matériasToolStripMenuItem});
            this.toolStripButton2.Image = global::gabaritei.Properties.Resources.listaordenada;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(90, 24);
            this.toolStripButton2.Text = "Listas";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // listaDeFuncionáriosToolStripMenuItem
            // 
            this.listaDeFuncionáriosToolStripMenuItem.Name = "listaDeFuncionáriosToolStripMenuItem";
            this.listaDeFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.listaDeFuncionáriosToolStripMenuItem.Text = "Lista de Funcionários";
            this.listaDeFuncionáriosToolStripMenuItem.Click += new System.EventHandler(this.listaDeFuncionáriosToolStripMenuItem_Click);
            // 
            // listaDeTurmasToolStripMenuItem
            // 
            this.listaDeTurmasToolStripMenuItem.Name = "listaDeTurmasToolStripMenuItem";
            this.listaDeTurmasToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.listaDeTurmasToolStripMenuItem.Text = "Lista de Turmas";
            this.listaDeTurmasToolStripMenuItem.Click += new System.EventHandler(this.listaDeTurmasToolStripMenuItem_Click);
            // 
            // matériasToolStripMenuItem
            // 
            this.matériasToolStripMenuItem.Name = "matériasToolStripMenuItem";
            this.matériasToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.matériasToolStripMenuItem.Text = "Lista de Matérias";
            this.matériasToolStripMenuItem.Click += new System.EventHandler(this.matériasToolStripMenuItem_Click);
            // 
            // btn_principal_alunos
            // 
            this.btn_principal_alunos.Image = ((System.Drawing.Image)(resources.GetObject("btn_principal_alunos.Image")));
            this.btn_principal_alunos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_principal_alunos.Name = "btn_principal_alunos";
            this.btn_principal_alunos.Size = new System.Drawing.Size(87, 24);
            this.btn_principal_alunos.Text = "Alunos";
            this.btn_principal_alunos.Click += new System.EventHandler(this.btn_alunos_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_princ_btn_lanc_notas,
            this.gerarRelatórioToolStripMenuItem});
            this.toolStripDropDownButton2.Image = global::gabaritei.Properties.Resources._1431651451_Teachers_128;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(136, 24);
            this.toolStripDropDownButton2.Text = "Professores";
            this.toolStripDropDownButton2.Click += new System.EventHandler(this.toolStripDropDownButton2_Click);
            // 
            // tsb_princ_btn_lanc_notas
            // 
            this.tsb_princ_btn_lanc_notas.Name = "tsb_princ_btn_lanc_notas";
            this.tsb_princ_btn_lanc_notas.Size = new System.Drawing.Size(255, 22);
            this.tsb_princ_btn_lanc_notas.Text = "Lançamento de Notas";
            this.tsb_princ_btn_lanc_notas.Click += new System.EventHandler(this.tsb_princ_btn_lanc_notas_Click);
            // 
            // gerarRelatórioToolStripMenuItem
            // 
            this.gerarRelatórioToolStripMenuItem.Name = "gerarRelatórioToolStripMenuItem";
            this.gerarRelatórioToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.gerarRelatórioToolStripMenuItem.Text = "Gerar Relatório";
            this.gerarRelatórioToolStripMenuItem.Click += new System.EventHandler(this.gerarRelatórioToolStripMenuItem_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton7.Image = global::gabaritei.Properties.Resources.exit;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(63, 24);
            this.toolStripButton7.Text = "Sair";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.Image = global::gabaritei.Properties.Resources._1431652431_lock;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(104, 24);
            this.toolStripButton3.Text = "Bloquear";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton5.Image = global::gabaritei.Properties.Resources.logout2;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(88, 24);
            this.toolStripButton5.Text = "Logout";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // tsb_princ_btn_sobre
            // 
            this.tsb_princ_btn_sobre.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsb_princ_btn_sobre.Image = global::gabaritei.Properties.Resources.gabarite_vetor_verde_pequeno_06;
            this.tsb_princ_btn_sobre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_princ_btn_sobre.Name = "tsb_princ_btn_sobre";
            this.tsb_princ_btn_sobre.Size = new System.Drawing.Size(78, 24);
            this.tsb_princ_btn_sobre.Text = "Sobre";
            this.tsb_princ_btn_sobre.Click += new System.EventHandler(this.tsb_princ_btn_sobre_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = global::gabaritei.Properties.Resources.plus_utiles;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(113, 24);
            this.toolStripButton6.Text = "Utilitários";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.Image = global::gabaritei.Properties.Resources.database;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(90, 24);
            this.toolStripButton4.Text = "Backup";
            this.toolStripButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click_1);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = global::gabaritei.Properties.Resources.tumblr_inline_nk6fjhVwM91s4vssj;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(115, 24);
            this.toolStripButton8.Text = "Relatórios";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurarProgramaToolStripMenuItem,
            this.abrirUtilitáriosToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairDoProgramaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // restaurarProgramaToolStripMenuItem
            // 
            this.restaurarProgramaToolStripMenuItem.Name = "restaurarProgramaToolStripMenuItem";
            this.restaurarProgramaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.restaurarProgramaToolStripMenuItem.Text = "Restaurar Programa";
            this.restaurarProgramaToolStripMenuItem.Click += new System.EventHandler(this.restaurarProgramaToolStripMenuItem_Click);
            // 
            // abrirUtilitáriosToolStripMenuItem
            // 
            this.abrirUtilitáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirNavegadorPadrãoToolStripMenuItem,
            this.iniciarBlocoDeNotasToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.iniciarMicrosoftWordToolStripMenuItem,
            this.iniciarMicrosoftPowerPointToolStripMenuItem,
            this.iniciarMicrosoftEToolStripMenuItem,
            this.iniciarMicrosoftAccessToolStripMenuItem});
            this.abrirUtilitáriosToolStripMenuItem.Name = "abrirUtilitáriosToolStripMenuItem";
            this.abrirUtilitáriosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.abrirUtilitáriosToolStripMenuItem.Text = "Utilitários";
            // 
            // abrirNavegadorPadrãoToolStripMenuItem
            // 
            this.abrirNavegadorPadrãoToolStripMenuItem.Name = "abrirNavegadorPadrãoToolStripMenuItem";
            this.abrirNavegadorPadrãoToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.abrirNavegadorPadrãoToolStripMenuItem.Text = "Abrir Navegador padrão";
            this.abrirNavegadorPadrãoToolStripMenuItem.Click += new System.EventHandler(this.abrirNavegadorPadrãoToolStripMenuItem_Click);
            // 
            // iniciarBlocoDeNotasToolStripMenuItem
            // 
            this.iniciarBlocoDeNotasToolStripMenuItem.Name = "iniciarBlocoDeNotasToolStripMenuItem";
            this.iniciarBlocoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.iniciarBlocoDeNotasToolStripMenuItem.Text = "Iniciar Bloco de Notas";
            this.iniciarBlocoDeNotasToolStripMenuItem.Click += new System.EventHandler(this.iniciarBlocoDeNotasToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // iniciarMicrosoftWordToolStripMenuItem
            // 
            this.iniciarMicrosoftWordToolStripMenuItem.Name = "iniciarMicrosoftWordToolStripMenuItem";
            this.iniciarMicrosoftWordToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.iniciarMicrosoftWordToolStripMenuItem.Text = "Iniciar Microsoft Word";
            this.iniciarMicrosoftWordToolStripMenuItem.Click += new System.EventHandler(this.iniciarMicrosoftWordToolStripMenuItem_Click);
            // 
            // iniciarMicrosoftPowerPointToolStripMenuItem
            // 
            this.iniciarMicrosoftPowerPointToolStripMenuItem.Name = "iniciarMicrosoftPowerPointToolStripMenuItem";
            this.iniciarMicrosoftPowerPointToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.iniciarMicrosoftPowerPointToolStripMenuItem.Text = "Iniciar Microsoft Power Point";
            this.iniciarMicrosoftPowerPointToolStripMenuItem.Click += new System.EventHandler(this.iniciarMicrosoftPowerPointToolStripMenuItem_Click);
            // 
            // iniciarMicrosoftEToolStripMenuItem
            // 
            this.iniciarMicrosoftEToolStripMenuItem.Name = "iniciarMicrosoftEToolStripMenuItem";
            this.iniciarMicrosoftEToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.iniciarMicrosoftEToolStripMenuItem.Text = "Iniciar Microsoft Excel";
            this.iniciarMicrosoftEToolStripMenuItem.Click += new System.EventHandler(this.iniciarMicrosoftEToolStripMenuItem_Click);
            // 
            // iniciarMicrosoftAccessToolStripMenuItem
            // 
            this.iniciarMicrosoftAccessToolStripMenuItem.Name = "iniciarMicrosoftAccessToolStripMenuItem";
            this.iniciarMicrosoftAccessToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.iniciarMicrosoftAccessToolStripMenuItem.Text = "Iniciar Microsoft Access";
            this.iniciarMicrosoftAccessToolStripMenuItem.Click += new System.EventHandler(this.iniciarMicrosoftAccessToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // sairDoProgramaToolStripMenuItem
            // 
            this.sairDoProgramaToolStripMenuItem.Name = "sairDoProgramaToolStripMenuItem";
            this.sairDoProgramaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.sairDoProgramaToolStripMenuItem.Text = "Sair do Programa";
            this.sairDoProgramaToolStripMenuItem.Click += new System.EventHandler(this.sairDoProgramaToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "O programa ainda está em execução, para encerrar, clique com o botão Direito no í" +
    "cone";
            this.notifyIcon1.BalloonTipTitle = "Gabaritei - Gestão Escolar";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_DoubleClick);
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick_2);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 209);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1276, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(73, 21);
            this.toolStripStatusLabel1.Text = "Usuário:";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(94, 21);
            this.toolStripStatusLabel3.Text = "Bem-vindo,";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(136, 21);
            this.toolStripStatusLabel2.Text = "Nome do usuário";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(15, 21);
            this.toolStripStatusLabel4.Text = "!";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(943, 21);
            this.toolStripStatusLabel5.Spring = true;
            this.toolStripStatusLabel5.Text = "Hora_do_computador";
            this.toolStripStatusLabel5.Click += new System.EventHandler(this.toolStripStatusLabel5_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cadastroDeTipoDeUsuárioToolStripMenuItem
            // 
            this.cadastroDeTipoDeUsuárioToolStripMenuItem.Name = "cadastroDeTipoDeUsuárioToolStripMenuItem";
            this.cadastroDeTipoDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.cadastroDeTipoDeUsuárioToolStripMenuItem.Text = "Cadastro de Tipo de Usuário";
            this.cadastroDeTipoDeUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeTipoDeUsuárioToolStripMenuItem_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::gabaritei.Properties.Resources.gabarite_vetor_fundo2_08;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1276, 235);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tsp_principal);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gabaritei";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.principal_Load);
            this.Resize += new System.EventHandler(this.principal_Resize);
            this.tsp_principal.ResumeLayout(false);
            this.tsp_principal.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsp_principal;
        private System.Windows.Forms.ToolStripButton tsb_princ_btn_sobre;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem tsb_princ_btn_lanc_notas;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFuncionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeAlunosToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirUtilitáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarMicrosoftWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarMicrosoftPowerPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairDoProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarProgramaToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem listaDeFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeTurmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton btn_principal_alunos;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeMatériasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matériasToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripMenuItem aberturaDeTurmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarBlocoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirNavegadorPadrãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeCargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarMicrosoftAccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarMicrosoftEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeMatériasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeCidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroTipoTelefoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeTipoDeUsuárioToolStripMenuItem;

    }
}

