namespace gabaritei
{
    partial class frm_cadastro_funcionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_DadosPessoais_cad_fun = new System.Windows.Forms.GroupBox();
            this.logradouroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GABARITEIDataSet = new gabaritei.GABARITEIDataSet();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.endresidencialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_cancelar_cad_fun = new System.Windows.Forms.Button();
            this.btn_salvar_cad_fun = new System.Windows.Forms.Button();
            this.btn_limpar_cad_fun = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.loginnTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.loginnTableAdapter();
            this.funcionarioTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.funcionarioTableAdapter();
            this.cargoTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.cargoTableAdapter();
            this.cidadeTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.cidadeTableAdapter();
            this.logradouroTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.logradouroTableAdapter();
            this.end_residencialTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.end_residencialTableAdapter();
            this.fKfuncionariocargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gb_DadosPessoais_cad_fun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logradouroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endresidencialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKfuncionariocargoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE FUNCIONÁRIO";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(43, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "RG:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de Cadastro:";
            // 
            // gb_DadosPessoais_cad_fun
            // 
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.maskedTextBox5);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.textBox13);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.textBox11);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.label24);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.maskedTextBox2);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.maskedTextBox1);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.textBox12);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.textBox10);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.label23);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.textBox9);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.label21);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.textBox8);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.label19);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.comboBox5);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.maskedTextBox6);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.label20);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.label18);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.label12);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.label8);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.comboBox2);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.textBox4);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.label11);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.maskedTextBox4);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.textBox2);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.textBox1);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.label9);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.label7);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.label6);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.label2);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.label3);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.label5);
            this.gb_DadosPessoais_cad_fun.Controls.Add(this.label4);
            this.gb_DadosPessoais_cad_fun.Location = new System.Drawing.Point(12, 30);
            this.gb_DadosPessoais_cad_fun.Name = "gb_DadosPessoais_cad_fun";
            this.gb_DadosPessoais_cad_fun.Size = new System.Drawing.Size(702, 303);
            this.gb_DadosPessoais_cad_fun.TabIndex = 6;
            this.gb_DadosPessoais_cad_fun.TabStop = false;
            this.gb_DadosPessoais_cad_fun.Text = "Dados Pessoais";
            this.gb_DadosPessoais_cad_fun.Enter += new System.EventHandler(this.gb_DadosPessoais_cad_fun_Enter);
            // 
            // logradouroBindingSource
            // 
            this.logradouroBindingSource.DataMember = "logradouro";
            this.logradouroBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // GABARITEIDataSet
            // 
            this.GABARITEIDataSet.DataSetName = "GABARITEIDataSet";
            this.GABARITEIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "fun_telefone", true));
            this.maskedTextBox5.Location = new System.Drawing.Point(88, 161);
            this.maskedTextBox5.Mask = "(00)0000-9999";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(153, 27);
            this.maskedTextBox5.TabIndex = 49;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "funcionario";
            this.funcionarioBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "fun_sexo", true));
            this.textBox13.Location = new System.Drawing.Point(88, 127);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(134, 27);
            this.textBox13.TabIndex = 4;
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "orgaoexpeditor_rg", true));
            this.textBox11.Location = new System.Drawing.Point(613, 94);
            this.textBox11.MaxLength = 3;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(76, 27);
            this.textBox11.TabIndex = 7;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(520, 97);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(97, 18);
            this.label24.TabIndex = 47;
            this.label24.Text = "Org. Exp.: ";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "fun_cpf", true));
            this.maskedTextBox2.Location = new System.Drawing.Point(366, 94);
            this.maskedTextBox2.Mask = "000-000-000-00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(148, 27);
            this.maskedTextBox2.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "fun_rg", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(87, 94);
            this.maskedTextBox1.Mask = "00-000-000-a";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(123, 27);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected_1);
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "data_admissao", true));
            this.textBox12.Location = new System.Drawing.Point(533, 26);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(129, 27);
            this.textBox12.TabIndex = 44;
            this.textBox12.Click += new System.EventHandler(this.textBox12_Click);
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged_1);
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "complemento", true));
            this.textBox10.Location = new System.Drawing.Point(145, 261);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(190, 27);
            this.textBox10.TabIndex = 13;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(10, 261);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(133, 28);
            this.label23.TabIndex = 41;
            this.label23.Text = "Complemento:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "numero", true));
            this.textBox9.Location = new System.Drawing.Point(445, 229);
            this.textBox9.MaxLength = 6;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(51, 27);
            this.textBox9.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(392, 227);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 28);
            this.label21.TabIndex = 37;
            this.label21.Text = "Nº:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "log_nm", true));
            this.textBox8.Location = new System.Drawing.Point(88, 228);
            this.textBox8.MaxLength = 50;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(298, 27);
            this.textBox8.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(12, 225);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 28);
            this.label19.TabIndex = 35;
            this.label19.Text = "Rua:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox5
            // 
            this.comboBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.funcionarioBindingSource, "cidade_cd", true));
            this.comboBox5.DataSource = this.cidadeBindingSource;
            this.comboBox5.DisplayMember = "cid_nome";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(88, 196);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(567, 26);
            this.comboBox5.TabIndex = 8;
            this.comboBox5.ValueMember = "cid_codigo";
            // 
            // cidadeBindingSource
            // 
            this.cidadeBindingSource.DataMember = "cidade";
            this.cidadeBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "cep", true));
            this.maskedTextBox6.Location = new System.Drawing.Point(547, 229);
            this.maskedTextBox6.Mask = "00-000-000";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(108, 27);
            this.maskedTextBox6.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(499, 232);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 18);
            this.label20.TabIndex = 32;
            this.label20.Text = "CEP:";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(12, 194);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 28);
            this.label18.TabIndex = 29;
            this.label18.Text = "Cidade:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 18);
            this.label12.TabIndex = 27;
            this.label12.Text = "Telefone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "CPF: ";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.funcionarioBindingSource, "cargo_cd", true));
            this.comboBox2.DataSource = this.cargoBindingSource;
            this.comboBox2.DisplayMember = "cargo_nm";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(246, 28);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 26);
            this.comboBox2.TabIndex = 24;
            this.comboBox2.ValueMember = "cargo_cd";
            // 
            // cargoBindingSource
            // 
            this.cargoBindingSource.DataMember = "cargo";
            this.cargoBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "fun_ufdoRG", true));
            this.textBox4.Location = new System.Drawing.Point(246, 94);
            this.textBox4.MaxLength = 2;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(56, 27);
            this.textBox4.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(214, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "UF: ";
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "fun_dt_nascimento", true));
            this.maskedTextBox4.Location = new System.Drawing.Point(409, 127);
            this.maskedTextBox4.Mask = "00/00/0000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 27);
            this.maskedTextBox4.TabIndex = 5;
            this.maskedTextBox4.ValidatingType = typeof(System.DateTime);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "fun_nm", true));
            this.textBox2.Location = new System.Drawing.Point(88, 61);
            this.textBox2.MaxLength = 60;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(567, 27);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "fun_cd", true));
            this.textBox1.Location = new System.Drawing.Point(88, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Cargo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Data de Nascimento: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sexo:";
            // 
            // endresidencialBindingSource
            // 
            this.endresidencialBindingSource.DataMember = "end_residencial";
            this.endresidencialBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // btn_cancelar_cad_fun
            // 
            this.btn_cancelar_cad_fun.Location = new System.Drawing.Point(628, 339);
            this.btn_cancelar_cad_fun.Name = "btn_cancelar_cad_fun";
            this.btn_cancelar_cad_fun.Size = new System.Drawing.Size(86, 26);
            this.btn_cancelar_cad_fun.TabIndex = 3;
            this.btn_cancelar_cad_fun.Text = "Cancelar";
            this.btn_cancelar_cad_fun.UseVisualStyleBackColor = true;
            this.btn_cancelar_cad_fun.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_salvar_cad_fun
            // 
            this.btn_salvar_cad_fun.Location = new System.Drawing.Point(444, 339);
            this.btn_salvar_cad_fun.Name = "btn_salvar_cad_fun";
            this.btn_salvar_cad_fun.Size = new System.Drawing.Size(86, 26);
            this.btn_salvar_cad_fun.TabIndex = 0;
            this.btn_salvar_cad_fun.Text = "Salvar";
            this.btn_salvar_cad_fun.UseVisualStyleBackColor = true;
            this.btn_salvar_cad_fun.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_limpar_cad_fun
            // 
            this.btn_limpar_cad_fun.Location = new System.Drawing.Point(536, 339);
            this.btn_limpar_cad_fun.Name = "btn_limpar_cad_fun";
            this.btn_limpar_cad_fun.Size = new System.Drawing.Size(86, 26);
            this.btn_limpar_cad_fun.TabIndex = 2;
            this.btn_limpar_cad_fun.Text = "Limpar";
            this.btn_limpar_cad_fun.UseVisualStyleBackColor = true;
            this.btn_limpar_cad_fun.Click += new System.EventHandler(this.btn_limpar_cad_fun_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 5;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 5;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 1;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "oooolp";
            // 
            // loginnTableAdapter
            // 
            this.loginnTableAdapter.ClearBeforeFill = true;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // cargoTableAdapter
            // 
            this.cargoTableAdapter.ClearBeforeFill = true;
            // 
            // cidadeTableAdapter
            // 
            this.cidadeTableAdapter.ClearBeforeFill = true;
            // 
            // logradouroTableAdapter
            // 
            this.logradouroTableAdapter.ClearBeforeFill = true;
            // 
            // end_residencialTableAdapter
            // 
            this.end_residencialTableAdapter.ClearBeforeFill = true;
            // 
            // fKfuncionariocargoBindingSource
            // 
            this.fKfuncionariocargoBindingSource.DataMember = "FK_funcionario_cargo";
            this.fKfuncionariocargoBindingSource.DataSource = this.cargoBindingSource;
            // 
            // frm_cadastro_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 369);
            this.Controls.Add(this.btn_limpar_cad_fun);
            this.Controls.Add(this.btn_salvar_cad_fun);
            this.Controls.Add(this.btn_cancelar_cad_fun);
            this.Controls.Add(this.gb_DadosPessoais_cad_fun);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "frm_cadastro_funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionario";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.tela_de_cadastro_login_Load);
            this.gb_DadosPessoais_cad_fun.ResumeLayout(false);
            this.gb_DadosPessoais_cad_fun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logradouroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endresidencialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKfuncionariocargoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_DadosPessoais_cad_fun;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_cancelar_cad_fun;
        private System.Windows.Forms.Button btn_salvar_cad_fun;
        private System.Windows.Forms.Button btn_limpar_cad_fun;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.BindingSource loginnBindingSource;
        private GABARITEIDataSetTableAdapters.loginnTableAdapter loginnTableAdapter;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox13;
        private GABARITEIDataSet GABARITEIDataSet;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private GABARITEIDataSetTableAdapters.funcionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.BindingSource cargoBindingSource;
        private GABARITEIDataSetTableAdapters.cargoTableAdapter cargoTableAdapter;
        private System.Windows.Forms.BindingSource cidadeBindingSource;
        private GABARITEIDataSetTableAdapters.cidadeTableAdapter cidadeTableAdapter;
        private System.Windows.Forms.BindingSource logradouroBindingSource;
        private GABARITEIDataSetTableAdapters.logradouroTableAdapter logradouroTableAdapter;
        private System.Windows.Forms.BindingSource endresidencialBindingSource;
        private GABARITEIDataSetTableAdapters.end_residencialTableAdapter end_residencialTableAdapter;
        private System.Windows.Forms.BindingSource fKfuncionariocargoBindingSource;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
    }
}