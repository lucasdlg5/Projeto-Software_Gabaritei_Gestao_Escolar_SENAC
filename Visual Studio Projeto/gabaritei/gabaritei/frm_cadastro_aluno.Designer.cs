namespace gabaritei
{
    partial class frm_cadastro_aluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastro_aluno));
            this.tbp_responsaveis_cad_aluno = new System.Windows.Forms.TabControl();
            this.tbp_aluno_cad_aluno = new System.Windows.Forms.TabPage();
            this.cmb_aluno_cad_aluno = new System.Windows.Forms.TextBox();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GABARITEIDataSet = new gabaritei.GABARITEIDataSet();
            this.cmb_UF_cad_aluno = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_nome_aluno_cad_aluno = new System.Windows.Forms.TextBox();
            this.txb_codigo_aluno_cad_aluno = new System.Windows.Forms.TextBox();
            this.gb_aluno_cad_aluno = new System.Windows.Forms.GroupBox();
            this.txb_email_contato_cad_aluno = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txb_bairro_end_cad_aluno = new System.Windows.Forms.TextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txb_complemento_end_cad_aluno = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_cid_end_cad_aluno = new System.Windows.Forms.ComboBox();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txb_no_end_cad_aluno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_rua_end_cad_aluno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mtb_cpf_aluno_cad_aluno = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtb_rg_aluno_cad_aluno = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_cancelar_cad_aluno = new System.Windows.Forms.Button();
            this.btn_salvar_cad_aluno = new System.Windows.Forms.Button();
            this.alunoTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.alunoTableAdapter();
            this.cidadeTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.cidadeTableAdapter();
            this.tbp_responsaveis_cad_aluno.SuspendLayout();
            this.tbp_aluno_cad_aluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).BeginInit();
            this.gb_aluno_cad_aluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbp_responsaveis_cad_aluno
            // 
            this.tbp_responsaveis_cad_aluno.Controls.Add(this.tbp_aluno_cad_aluno);
            this.tbp_responsaveis_cad_aluno.Location = new System.Drawing.Point(0, -1);
            this.tbp_responsaveis_cad_aluno.Name = "tbp_responsaveis_cad_aluno";
            this.tbp_responsaveis_cad_aluno.SelectedIndex = 0;
            this.tbp_responsaveis_cad_aluno.Size = new System.Drawing.Size(744, 377);
            this.tbp_responsaveis_cad_aluno.TabIndex = 9;
            this.tbp_responsaveis_cad_aluno.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbp_responsaveis_cad_aluno_Selected);
            this.tbp_responsaveis_cad_aluno.Click += new System.EventHandler(this.tbp_responsaveis_cad_aluno_Click);
            // 
            // tbp_aluno_cad_aluno
            // 
            this.tbp_aluno_cad_aluno.Controls.Add(this.cmb_aluno_cad_aluno);
            this.tbp_aluno_cad_aluno.Controls.Add(this.cmb_UF_cad_aluno);
            this.tbp_aluno_cad_aluno.Controls.Add(this.textBox11);
            this.tbp_aluno_cad_aluno.Controls.Add(this.label24);
            this.tbp_aluno_cad_aluno.Controls.Add(this.textBox3);
            this.tbp_aluno_cad_aluno.Controls.Add(this.label13);
            this.tbp_aluno_cad_aluno.Controls.Add(this.label3);
            this.tbp_aluno_cad_aluno.Controls.Add(this.txb_nome_aluno_cad_aluno);
            this.tbp_aluno_cad_aluno.Controls.Add(this.txb_codigo_aluno_cad_aluno);
            this.tbp_aluno_cad_aluno.Controls.Add(this.gb_aluno_cad_aluno);
            this.tbp_aluno_cad_aluno.Controls.Add(this.mtb_cpf_aluno_cad_aluno);
            this.tbp_aluno_cad_aluno.Controls.Add(this.label7);
            this.tbp_aluno_cad_aluno.Controls.Add(this.label6);
            this.tbp_aluno_cad_aluno.Controls.Add(this.mtb_rg_aluno_cad_aluno);
            this.tbp_aluno_cad_aluno.Controls.Add(this.maskedTextBox2);
            this.tbp_aluno_cad_aluno.Controls.Add(this.label5);
            this.tbp_aluno_cad_aluno.Controls.Add(this.label4);
            this.tbp_aluno_cad_aluno.Controls.Add(this.label2);
            this.tbp_aluno_cad_aluno.Controls.Add(this.label1);
            this.tbp_aluno_cad_aluno.Location = new System.Drawing.Point(4, 27);
            this.tbp_aluno_cad_aluno.Name = "tbp_aluno_cad_aluno";
            this.tbp_aluno_cad_aluno.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_aluno_cad_aluno.Size = new System.Drawing.Size(736, 346);
            this.tbp_aluno_cad_aluno.TabIndex = 0;
            this.tbp_aluno_cad_aluno.Text = "Aluno";
            this.tbp_aluno_cad_aluno.UseVisualStyleBackColor = true;
            this.tbp_aluno_cad_aluno.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cmb_aluno_cad_aluno
            // 
            this.cmb_aluno_cad_aluno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "alu_sx", true));
            this.cmb_aluno_cad_aluno.Location = new System.Drawing.Point(113, 115);
            this.cmb_aluno_cad_aluno.Name = "cmb_aluno_cad_aluno";
            this.cmb_aluno_cad_aluno.Size = new System.Drawing.Size(142, 26);
            this.cmb_aluno_cad_aluno.TabIndex = 53;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataMember = "aluno";
            this.alunoBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // GABARITEIDataSet
            // 
            this.GABARITEIDataSet.DataSetName = "GABARITEIDataSet";
            this.GABARITEIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb_UF_cad_aluno
            // 
            this.cmb_UF_cad_aluno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "uf_rg", true));
            this.cmb_UF_cad_aluno.Location = new System.Drawing.Point(306, 85);
            this.cmb_UF_cad_aluno.Name = "cmb_UF_cad_aluno";
            this.cmb_UF_cad_aluno.Size = new System.Drawing.Size(100, 26);
            this.cmb_UF_cad_aluno.TabIndex = 2;
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "orgao_exp", true));
            this.textBox11.Location = new System.Drawing.Point(505, 83);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(76, 26);
            this.textBox11.TabIndex = 3;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(412, 86);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 18);
            this.label24.TabIndex = 49;
            this.label24.Text = "Org. Exp.: ";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "alu_dt_cadastro", true));
            this.textBox3.Location = new System.Drawing.Point(603, 15);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(116, 26);
            this.textBox3.TabIndex = 34;
            this.textBox3.Click += new System.EventHandler(this.textBox3_Click);
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(247, 84);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 26);
            this.label13.TabIndex = 33;
            this.label13.Text = "UF :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data inscrição aluno:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txb_nome_aluno_cad_aluno
            // 
            this.txb_nome_aluno_cad_aluno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "alu_nm", true));
            this.txb_nome_aluno_cad_aluno.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_nome_aluno_cad_aluno.Location = new System.Drawing.Point(113, 51);
            this.txb_nome_aluno_cad_aluno.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txb_nome_aluno_cad_aluno.MaxLength = 50;
            this.txb_nome_aluno_cad_aluno.Name = "txb_nome_aluno_cad_aluno";
            this.txb_nome_aluno_cad_aluno.Size = new System.Drawing.Size(612, 26);
            this.txb_nome_aluno_cad_aluno.TabIndex = 0;
            this.txb_nome_aluno_cad_aluno.TextChanged += new System.EventHandler(this.txb_nome_aluno_cad_aluno_TextChanged);
            this.txb_nome_aluno_cad_aluno.Validating += new System.ComponentModel.CancelEventHandler(this.txb_nome_aluno_cad_aluno_Validating);
            // 
            // txb_codigo_aluno_cad_aluno
            // 
            this.txb_codigo_aluno_cad_aluno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "alu_cd", true));
            this.txb_codigo_aluno_cad_aluno.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_codigo_aluno_cad_aluno.Location = new System.Drawing.Point(113, 15);
            this.txb_codigo_aluno_cad_aluno.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txb_codigo_aluno_cad_aluno.Name = "txb_codigo_aluno_cad_aluno";
            this.txb_codigo_aluno_cad_aluno.ReadOnly = true;
            this.txb_codigo_aluno_cad_aluno.Size = new System.Drawing.Size(124, 26);
            this.txb_codigo_aluno_cad_aluno.TabIndex = 2;
            this.txb_codigo_aluno_cad_aluno.TextChanged += new System.EventHandler(this.txb_codigo_aluno_cad_aluno_TextChanged);
            // 
            // gb_aluno_cad_aluno
            // 
            this.gb_aluno_cad_aluno.Controls.Add(this.txb_email_contato_cad_aluno);
            this.gb_aluno_cad_aluno.Controls.Add(this.label15);
            this.gb_aluno_cad_aluno.Controls.Add(this.txb_bairro_end_cad_aluno);
            this.gb_aluno_cad_aluno.Controls.Add(this.maskedTextBox4);
            this.gb_aluno_cad_aluno.Controls.Add(this.label20);
            this.gb_aluno_cad_aluno.Controls.Add(this.txb_complemento_end_cad_aluno);
            this.gb_aluno_cad_aluno.Controls.Add(this.label18);
            this.gb_aluno_cad_aluno.Controls.Add(this.label14);
            this.gb_aluno_cad_aluno.Controls.Add(this.cmb_cid_end_cad_aluno);
            this.gb_aluno_cad_aluno.Controls.Add(this.txb_no_end_cad_aluno);
            this.gb_aluno_cad_aluno.Controls.Add(this.label11);
            this.gb_aluno_cad_aluno.Controls.Add(this.label10);
            this.gb_aluno_cad_aluno.Controls.Add(this.txb_rua_end_cad_aluno);
            this.gb_aluno_cad_aluno.Controls.Add(this.label9);
            this.gb_aluno_cad_aluno.Location = new System.Drawing.Point(8, 143);
            this.gb_aluno_cad_aluno.Name = "gb_aluno_cad_aluno";
            this.gb_aluno_cad_aluno.Size = new System.Drawing.Size(717, 176);
            this.gb_aluno_cad_aluno.TabIndex = 15;
            this.gb_aluno_cad_aluno.TabStop = false;
            this.gb_aluno_cad_aluno.Text = "Endereço";
            // 
            // txb_email_contato_cad_aluno
            // 
            this.txb_email_contato_cad_aluno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "alu_email", true));
            this.txb_email_contato_cad_aluno.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_email_contato_cad_aluno.Location = new System.Drawing.Point(107, 127);
            this.txb_email_contato_cad_aluno.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txb_email_contato_cad_aluno.Name = "txb_email_contato_cad_aluno";
            this.txb_email_contato_cad_aluno.Size = new System.Drawing.Size(602, 26);
            this.txb_email_contato_cad_aluno.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(-11, 127);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 26);
            this.label15.TabIndex = 32;
            this.label15.Text = "E-mail:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txb_bairro_end_cad_aluno
            // 
            this.txb_bairro_end_cad_aluno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "end_bairro", true));
            this.txb_bairro_end_cad_aluno.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_bairro_end_cad_aluno.Location = new System.Drawing.Point(107, 93);
            this.txb_bairro_end_cad_aluno.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txb_bairro_end_cad_aluno.Name = "txb_bairro_end_cad_aluno";
            this.txb_bairro_end_cad_aluno.Size = new System.Drawing.Size(287, 26);
            this.txb_bairro_end_cad_aluno.TabIndex = 4;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "end_cep", true));
            this.maskedTextBox4.Location = new System.Drawing.Point(567, 62);
            this.maskedTextBox4.Mask = "00-000-000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(108, 26);
            this.maskedTextBox4.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(513, 64);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 18);
            this.label20.TabIndex = 30;
            this.label20.Text = "CEP:";
            // 
            // txb_complemento_end_cad_aluno
            // 
            this.txb_complemento_end_cad_aluno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "end_complemento", true));
            this.txb_complemento_end_cad_aluno.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_complemento_end_cad_aluno.Location = new System.Drawing.Point(567, 93);
            this.txb_complemento_end_cad_aluno.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txb_complemento_end_cad_aluno.Name = "txb_complemento_end_cad_aluno";
            this.txb_complemento_end_cad_aluno.Size = new System.Drawing.Size(144, 26);
            this.txb_complemento_end_cad_aluno.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(407, 94);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(150, 26);
            this.label18.TabIndex = 28;
            this.label18.Text = "Complemento:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(-6, 93);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 26);
            this.label14.TabIndex = 27;
            this.label14.Text = "Bairro :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_cid_end_cad_aluno
            // 
            this.cmb_cid_end_cad_aluno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_cid_end_cad_aluno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_cid_end_cad_aluno.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.alunoBindingSource, "cidade_cd", true));
            this.cmb_cid_end_cad_aluno.DataSource = this.cidadeBindingSource;
            this.cmb_cid_end_cad_aluno.DisplayMember = "cid_nome";
            this.cmb_cid_end_cad_aluno.FormattingEnabled = true;
            this.cmb_cid_end_cad_aluno.Location = new System.Drawing.Point(107, 26);
            this.cmb_cid_end_cad_aluno.Name = "cmb_cid_end_cad_aluno";
            this.cmb_cid_end_cad_aluno.Size = new System.Drawing.Size(604, 26);
            this.cmb_cid_end_cad_aluno.TabIndex = 0;
            this.cmb_cid_end_cad_aluno.ValueMember = "cid_codigo";
            // 
            // cidadeBindingSource
            // 
            this.cidadeBindingSource.DataMember = "cidade";
            this.cidadeBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // txb_no_end_cad_aluno
            // 
            this.txb_no_end_cad_aluno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "end_numero", true));
            this.txb_no_end_cad_aluno.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_no_end_cad_aluno.Location = new System.Drawing.Point(436, 61);
            this.txb_no_end_cad_aluno.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txb_no_end_cad_aluno.Name = "txb_no_end_cad_aluno";
            this.txb_no_end_cad_aluno.Size = new System.Drawing.Size(35, 26);
            this.txb_no_end_cad_aluno.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(404, 61);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 26);
            this.label11.TabIndex = 22;
            this.label11.Text = "N°:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-5, 61);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 26);
            this.label10.TabIndex = 21;
            this.label10.Text = "Rua:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txb_rua_end_cad_aluno
            // 
            this.txb_rua_end_cad_aluno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "end_log", true));
            this.txb_rua_end_cad_aluno.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_rua_end_cad_aluno.Location = new System.Drawing.Point(107, 61);
            this.txb_rua_end_cad_aluno.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txb_rua_end_cad_aluno.Name = "txb_rua_end_cad_aluno";
            this.txb_rua_end_cad_aluno.Size = new System.Drawing.Size(287, 26);
            this.txb_rua_end_cad_aluno.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-6, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 26);
            this.label9.TabIndex = 19;
            this.label9.Text = "Cidade:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtb_cpf_aluno_cad_aluno
            // 
            this.mtb_cpf_aluno_cad_aluno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "alu_cpf", true));
            this.mtb_cpf_aluno_cad_aluno.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_cpf_aluno_cad_aluno.Location = new System.Drawing.Point(614, 117);
            this.mtb_cpf_aluno_cad_aluno.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mtb_cpf_aluno_cad_aluno.Mask = "000000000/00";
            this.mtb_cpf_aluno_cad_aluno.Name = "mtb_cpf_aluno_cad_aluno";
            this.mtb_cpf_aluno_cad_aluno.Size = new System.Drawing.Size(115, 26);
            this.mtb_cpf_aluno_cad_aluno.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(561, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "CPF:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "RG:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtb_rg_aluno_cad_aluno
            // 
            this.mtb_rg_aluno_cad_aluno.Culture = new System.Globalization.CultureInfo("");
            this.mtb_rg_aluno_cad_aluno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "alu_rg", true));
            this.mtb_rg_aluno_cad_aluno.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_rg_aluno_cad_aluno.Location = new System.Drawing.Point(114, 84);
            this.mtb_rg_aluno_cad_aluno.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mtb_rg_aluno_cad_aluno.Mask = "00.000.000-00";
            this.mtb_rg_aluno_cad_aluno.Name = "mtb_rg_aluno_cad_aluno";
            this.mtb_rg_aluno_cad_aluno.Size = new System.Drawing.Size(123, 26);
            this.mtb_rg_aluno_cad_aluno.TabIndex = 1;
            this.mtb_rg_aluno_cad_aluno.Validating += new System.ComponentModel.CancelEventHandler(this.mtb_rg_aluno_cad_aluno_Validating);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "alu_nascimento", true));
            this.maskedTextBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(444, 117);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(115, 26);
            this.maskedTextBox2.TabIndex = 5;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data de nascimento:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sexo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 5;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 1;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 10;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // btn_cancelar_cad_aluno
            // 
            this.btn_cancelar_cad_aluno.Location = new System.Drawing.Point(654, 382);
            this.btn_cancelar_cad_aluno.Name = "btn_cancelar_cad_aluno";
            this.btn_cancelar_cad_aluno.Size = new System.Drawing.Size(86, 27);
            this.btn_cancelar_cad_aluno.TabIndex = 3;
            this.btn_cancelar_cad_aluno.Text = "Cancelar";
            this.btn_cancelar_cad_aluno.UseVisualStyleBackColor = true;
            this.btn_cancelar_cad_aluno.Click += new System.EventHandler(this.btn_cancelar_cad_aluno_Click);
            // 
            // btn_salvar_cad_aluno
            // 
            this.btn_salvar_cad_aluno.Location = new System.Drawing.Point(574, 382);
            this.btn_salvar_cad_aluno.Name = "btn_salvar_cad_aluno";
            this.btn_salvar_cad_aluno.Size = new System.Drawing.Size(75, 27);
            this.btn_salvar_cad_aluno.TabIndex = 0;
            this.btn_salvar_cad_aluno.Text = "Salvar";
            this.btn_salvar_cad_aluno.UseVisualStyleBackColor = true;
            this.btn_salvar_cad_aluno.Click += new System.EventHandler(this.btn_salvar_cad_aluno_Click_1);
            this.btn_salvar_cad_aluno.Validating += new System.ComponentModel.CancelEventHandler(this.btn_salvar_cad_aluno_Validating);
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // cidadeTableAdapter
            // 
            this.cidadeTableAdapter.ClearBeforeFill = true;
            // 
            // frm_cadastro_aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 412);
            this.Controls.Add(this.btn_cancelar_cad_aluno);
            this.Controls.Add(this.btn_salvar_cad_aluno);
            this.Controls.Add(this.tbp_responsaveis_cad_aluno);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_cadastro_aluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de aluno";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.cadastro_alu_certo_Load);
            this.tbp_responsaveis_cad_aluno.ResumeLayout(false);
            this.tbp_aluno_cad_aluno.ResumeLayout(false);
            this.tbp_aluno_cad_aluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).EndInit();
            this.gb_aluno_cad_aluno.ResumeLayout(false);
            this.gb_aluno_cad_aluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbp_responsaveis_cad_aluno;
        private System.Windows.Forms.TabPage tbp_aluno_cad_aluno;
        private System.Windows.Forms.TextBox txb_nome_aluno_cad_aluno;
        private System.Windows.Forms.TextBox txb_codigo_aluno_cad_aluno;
        private System.Windows.Forms.GroupBox gb_aluno_cad_aluno;
        private System.Windows.Forms.TextBox txb_complemento_end_cad_aluno;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_cid_end_cad_aluno;
        private System.Windows.Forms.TextBox txb_no_end_cad_aluno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_rua_end_cad_aluno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtb_cpf_aluno_cad_aluno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtb_rg_aluno_cad_aluno;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_cancelar_cad_aluno;
        private System.Windows.Forms.Button btn_salvar_cad_aluno;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label24;
        private GABARITEIDataSet GABARITEIDataSet;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private GABARITEIDataSetTableAdapters.alunoTableAdapter alunoTableAdapter;
        private System.Windows.Forms.BindingSource cidadeBindingSource;
        private GABARITEIDataSetTableAdapters.cidadeTableAdapter cidadeTableAdapter;
        private System.Windows.Forms.TextBox txb_bairro_end_cad_aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDoResponsávelDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox cmb_UF_cad_aluno;
        private System.Windows.Forms.TextBox txb_email_contato_cad_aluno;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox cmb_aluno_cad_aluno;
    }
}