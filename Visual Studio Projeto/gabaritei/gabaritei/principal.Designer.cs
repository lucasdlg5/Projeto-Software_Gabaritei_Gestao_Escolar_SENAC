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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restaurarProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirUtilitáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarMicrosoftWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarMicrosoftPowerPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarJogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairDoProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeBalãoNotificaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.cadastroDeFuncionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeAlunosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalhesDoAlunoNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.listaDeFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeTurmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsb_princ_btn_principal_alunos = new System.Windows.Forms.ToolStripDropDownButton();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsb_princ_btn_lanc_presenc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsb_princ_btn_lanc_notas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsb_princ_btn_calendario = new System.Windows.Forms.ToolStripButton();
            this.tsb_princ_btn_sobre = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsp_principal.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsp_principal
            // 
            this.tsp_principal.BackColor = System.Drawing.SystemColors.Control;
            this.tsp_principal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsp_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.tsb_princ_btn_principal_alunos,
            this.toolStripDropDownButton2,
            this.tsb_princ_btn_calendario,
            this.tsb_princ_btn_sobre,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
            this.tsp_principal.Location = new System.Drawing.Point(0, 0);
            this.tsp_principal.Name = "tsp_principal";
            this.tsp_principal.Size = new System.Drawing.Size(1346, 25);
            this.tsp_principal.TabIndex = 0;
            this.tsp_principal.Text = "toolStrip1";
            this.tsp_principal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurarProgramaToolStripMenuItem,
            this.abrirUtilitáriosToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairDoProgramaToolStripMenuItem,
            this.testeBalãoNotificaçãoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 98);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // restaurarProgramaToolStripMenuItem
            // 
            this.restaurarProgramaToolStripMenuItem.Name = "restaurarProgramaToolStripMenuItem";
            this.restaurarProgramaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.restaurarProgramaToolStripMenuItem.Text = "Restaurar Programa";
            this.restaurarProgramaToolStripMenuItem.Click += new System.EventHandler(this.restaurarProgramaToolStripMenuItem_Click);
            // 
            // abrirUtilitáriosToolStripMenuItem
            // 
            this.abrirUtilitáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.iniciarExcelToolStripMenuItem,
            this.iniciarMicrosoftWordToolStripMenuItem,
            this.iniciarMicrosoftPowerPointToolStripMenuItem,
            this.iniciarJogosToolStripMenuItem});
            this.abrirUtilitáriosToolStripMenuItem.Name = "abrirUtilitáriosToolStripMenuItem";
            this.abrirUtilitáriosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.abrirUtilitáriosToolStripMenuItem.Text = "Utilitários";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            // 
            // iniciarExcelToolStripMenuItem
            // 
            this.iniciarExcelToolStripMenuItem.Name = "iniciarExcelToolStripMenuItem";
            this.iniciarExcelToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.iniciarExcelToolStripMenuItem.Text = "Iniciar Excel";
            // 
            // iniciarMicrosoftWordToolStripMenuItem
            // 
            this.iniciarMicrosoftWordToolStripMenuItem.Name = "iniciarMicrosoftWordToolStripMenuItem";
            this.iniciarMicrosoftWordToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.iniciarMicrosoftWordToolStripMenuItem.Text = "Iniciar Microsoft Word";
            // 
            // iniciarMicrosoftPowerPointToolStripMenuItem
            // 
            this.iniciarMicrosoftPowerPointToolStripMenuItem.Name = "iniciarMicrosoftPowerPointToolStripMenuItem";
            this.iniciarMicrosoftPowerPointToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.iniciarMicrosoftPowerPointToolStripMenuItem.Text = "Iniciar Microsoft Power Point";
            // 
            // iniciarJogosToolStripMenuItem
            // 
            this.iniciarJogosToolStripMenuItem.Name = "iniciarJogosToolStripMenuItem";
            this.iniciarJogosToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.iniciarJogosToolStripMenuItem.Text = "Iniciar Jogos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // sairDoProgramaToolStripMenuItem
            // 
            this.sairDoProgramaToolStripMenuItem.Name = "sairDoProgramaToolStripMenuItem";
            this.sairDoProgramaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.sairDoProgramaToolStripMenuItem.Text = "Sair do Programa";
            this.sairDoProgramaToolStripMenuItem.Click += new System.EventHandler(this.sairDoProgramaToolStripMenuItem_Click);
            // 
            // testeBalãoNotificaçãoToolStripMenuItem
            // 
            this.testeBalãoNotificaçãoToolStripMenuItem.Name = "testeBalãoNotificaçãoToolStripMenuItem";
            this.testeBalãoNotificaçãoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.testeBalãoNotificaçãoToolStripMenuItem.Text = "Teste Balão notificação";
            this.testeBalãoNotificaçãoToolStripMenuItem.Click += new System.EventHandler(this.testeBalãoNotificaçãoToolStripMenuItem_Click);
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
            // toolStripButton1
            // 
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeFuncionariosToolStripMenuItem,
            this.cadastroDeAlunosToolStripMenuItem1,
            this.cadastroDeCursosToolStripMenuItem,
            this.detalhesDoAlunoNotasToolStripMenuItem});
            this.toolStripButton1.Image = global::gabaritei.Properties.Resources._1431652941_file_add;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(110, 22);
            this.toolStripButton1.Text = "Cadastro";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_2);
            // 
            // cadastroDeFuncionariosToolStripMenuItem
            // 
            this.cadastroDeFuncionariosToolStripMenuItem.Name = "cadastroDeFuncionariosToolStripMenuItem";
            this.cadastroDeFuncionariosToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.cadastroDeFuncionariosToolStripMenuItem.Text = "Cadastro de Funcionarios";
            this.cadastroDeFuncionariosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFuncionariosToolStripMenuItem_Click);
            // 
            // cadastroDeAlunosToolStripMenuItem1
            // 
            this.cadastroDeAlunosToolStripMenuItem1.Name = "cadastroDeAlunosToolStripMenuItem1";
            this.cadastroDeAlunosToolStripMenuItem1.Size = new System.Drawing.Size(283, 22);
            this.cadastroDeAlunosToolStripMenuItem1.Text = "Cadastro de Alunos";
            this.cadastroDeAlunosToolStripMenuItem1.Click += new System.EventHandler(this.cadastroDeAlunosToolStripMenuItem1_Click);
            // 
            // cadastroDeCursosToolStripMenuItem
            // 
            this.cadastroDeCursosToolStripMenuItem.Name = "cadastroDeCursosToolStripMenuItem";
            this.cadastroDeCursosToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.cadastroDeCursosToolStripMenuItem.Text = "Cadastro de Turmas";
            this.cadastroDeCursosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCursosToolStripMenuItem_Click);
            // 
            // detalhesDoAlunoNotasToolStripMenuItem
            // 
            this.detalhesDoAlunoNotasToolStripMenuItem.Name = "detalhesDoAlunoNotasToolStripMenuItem";
            this.detalhesDoAlunoNotasToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.detalhesDoAlunoNotasToolStripMenuItem.Text = "Detalhes do aluno notas";
            this.detalhesDoAlunoNotasToolStripMenuItem.Click += new System.EventHandler(this.detalhesDoAlunoNotasToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeFuncionáriosToolStripMenuItem,
            this.listaDeTurmasToolStripMenuItem});
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(86, 22);
            this.toolStripButton2.Text = "Listas";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // listaDeFuncionáriosToolStripMenuItem
            // 
            this.listaDeFuncionáriosToolStripMenuItem.Name = "listaDeFuncionáriosToolStripMenuItem";
            this.listaDeFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.listaDeFuncionáriosToolStripMenuItem.Text = "Lista de Funcionários";
            // 
            // listaDeTurmasToolStripMenuItem
            // 
            this.listaDeTurmasToolStripMenuItem.Name = "listaDeTurmasToolStripMenuItem";
            this.listaDeTurmasToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.listaDeTurmasToolStripMenuItem.Text = "Lista de Turmas";
            // 
            // tsb_princ_btn_principal_alunos
            // 
            this.tsb_princ_btn_principal_alunos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.turmasToolStripMenuItem});
            this.tsb_princ_btn_principal_alunos.Image = ((System.Drawing.Image)(resources.GetObject("tsb_princ_btn_principal_alunos.Image")));
            this.tsb_princ_btn_principal_alunos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_princ_btn_principal_alunos.Name = "tsb_princ_btn_principal_alunos";
            this.tsb_princ_btn_principal_alunos.Size = new System.Drawing.Size(92, 22);
            this.tsb_princ_btn_principal_alunos.Text = "Alunos";
            this.tsb_princ_btn_principal_alunos.Click += new System.EventHandler(this.btn_alunos_Click);
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.alunosToolStripMenuItem.Text = "Alunos";
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // turmasToolStripMenuItem
            // 
            this.turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            this.turmasToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.turmasToolStripMenuItem.Text = "Turmas";
            this.turmasToolStripMenuItem.Click += new System.EventHandler(this.turmasToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_princ_btn_lanc_presenc,
            this.tsb_princ_btn_lanc_notas});
            this.toolStripDropDownButton2.Image = global::gabaritei.Properties.Resources._1431651451_Teachers_128;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(132, 22);
            this.toolStripDropDownButton2.Text = "Professores";
            this.toolStripDropDownButton2.Click += new System.EventHandler(this.toolStripDropDownButton2_Click);
            // 
            // tsb_princ_btn_lanc_presenc
            // 
            this.tsb_princ_btn_lanc_presenc.Name = "tsb_princ_btn_lanc_presenc";
            this.tsb_princ_btn_lanc_presenc.Size = new System.Drawing.Size(280, 22);
            this.tsb_princ_btn_lanc_presenc.Text = "Lançamento de Presença";
            this.tsb_princ_btn_lanc_presenc.Click += new System.EventHandler(this.lançamentoDePresençaToolStripMenuItem_Click);
            // 
            // tsb_princ_btn_lanc_notas
            // 
            this.tsb_princ_btn_lanc_notas.Name = "tsb_princ_btn_lanc_notas";
            this.tsb_princ_btn_lanc_notas.Size = new System.Drawing.Size(280, 22);
            this.tsb_princ_btn_lanc_notas.Text = "Lançamento de Notas";
            this.tsb_princ_btn_lanc_notas.Click += new System.EventHandler(this.tsb_princ_btn_lanc_notas_Click);
            // 
            // tsb_princ_btn_calendario
            // 
            this.tsb_princ_btn_calendario.Image = global::gabaritei.Properties.Resources._1431652189_calendar;
            this.tsb_princ_btn_calendario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_princ_btn_calendario.Name = "tsb_princ_btn_calendario";
            this.tsb_princ_btn_calendario.Size = new System.Drawing.Size(159, 22);
            this.tsb_princ_btn_calendario.Text = "Cal. Pedagógico";
            this.tsb_princ_btn_calendario.Click += new System.EventHandler(this.tsb_princ_btn_calendario_Click);
            // 
            // tsb_princ_btn_sobre
            // 
            this.tsb_princ_btn_sobre.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsb_princ_btn_sobre.Image = global::gabaritei.Properties.Resources._1431652295_settings02;
            this.tsb_princ_btn_sobre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_princ_btn_sobre.Name = "tsb_princ_btn_sobre";
            this.tsb_princ_btn_sobre.Size = new System.Drawing.Size(74, 22);
            this.tsb_princ_btn_sobre.Text = "Sobre";
            this.tsb_princ_btn_sobre.Click += new System.EventHandler(this.tsb_princ_btn_sobre_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::gabaritei.Properties.Resources._1431652431_lock;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(100, 22);
            this.toolStripButton3.Text = "Bloquear";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.Image = global::gabaritei.Properties.Resources._1431653037_photos;
            this.toolStripButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(75, 22);
            this.toolStripButton4.Text = "Home";
            this.toolStripButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton4.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(84, 22);
            this.toolStripButton5.Text = "Logout";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(109, 22);
            this.toolStripButton6.Text = "Utilitários";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Location = new System.Drawing.Point(0, 653);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1346, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1346, 678);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tsp_principal);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello Word";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.principal_Load);
            this.Resize += new System.EventHandler(this.principal_Resize);
            this.tsp_principal.ResumeLayout(false);
            this.tsp_principal.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsp_principal;
        private System.Windows.Forms.ToolStripButton tsb_princ_btn_calendario;
        private System.Windows.Forms.ToolStripButton tsb_princ_btn_sobre;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem tsb_princ_btn_lanc_notas;
        private System.Windows.Forms.ToolStripMenuItem tsb_princ_btn_lanc_presenc;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripDropDownButton tsb_princ_btn_principal_alunos;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFuncionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeAlunosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirUtilitáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarMicrosoftWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarMicrosoftPowerPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarJogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairDoProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeBalãoNotificaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarProgramaToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalhesDoAlunoNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem listaDeFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeTurmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStrip toolStrip1;

    }
}

