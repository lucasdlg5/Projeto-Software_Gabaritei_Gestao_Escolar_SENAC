namespace gabaritei
{
    partial class frm_cadastro_login
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
            this.gb_CadLogin_cad_fun = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.loginnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GABARITEIDataSet = new gabaritei.GABARITEIDataSet();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tipodeuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tipo_de_userTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.tipo_de_userTableAdapter();
            this.loginnTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.loginnTableAdapter();
            this.funcionarioTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.funcionarioTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gb_CadLogin_cad_fun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodeuserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_CadLogin_cad_fun
            // 
            this.gb_CadLogin_cad_fun.Controls.Add(this.comboBox1);
            this.gb_CadLogin_cad_fun.Controls.Add(this.label1);
            this.gb_CadLogin_cad_fun.Controls.Add(this.textBox14);
            this.gb_CadLogin_cad_fun.Controls.Add(this.textBox7);
            this.gb_CadLogin_cad_fun.Controls.Add(this.comboBox4);
            this.gb_CadLogin_cad_fun.Controls.Add(this.comboBox3);
            this.gb_CadLogin_cad_fun.Controls.Add(this.textBox6);
            this.gb_CadLogin_cad_fun.Controls.Add(this.textBox5);
            this.gb_CadLogin_cad_fun.Controls.Add(this.label16);
            this.gb_CadLogin_cad_fun.Controls.Add(this.label15);
            this.gb_CadLogin_cad_fun.Controls.Add(this.label17);
            this.gb_CadLogin_cad_fun.Controls.Add(this.label14);
            this.gb_CadLogin_cad_fun.Controls.Add(this.label26);
            this.gb_CadLogin_cad_fun.Controls.Add(this.label13);
            this.gb_CadLogin_cad_fun.Location = new System.Drawing.Point(6, 3);
            this.gb_CadLogin_cad_fun.Name = "gb_CadLogin_cad_fun";
            this.gb_CadLogin_cad_fun.Size = new System.Drawing.Size(540, 163);
            this.gb_CadLogin_cad_fun.TabIndex = 8;
            this.gb_CadLogin_cad_fun.TabStop = false;
            this.gb_CadLogin_cad_fun.Text = "Cadastro de Login";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.loginnBindingSource, "fun_cd", true));
            this.comboBox1.DataSource = this.funcionarioBindingSource;
            this.comboBox1.DisplayMember = "fun_nm";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(311, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 26);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.ValueMember = "fun_cd";
            // 
            // loginnBindingSource
            // 
            this.loginnBindingSource.DataMember = "loginn";
            this.loginnBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // GABARITEIDataSet
            // 
            this.GABARITEIDataSet.DataSetName = "GABARITEIDataSet";
            this.GABARITEIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "funcionario";
            this.funcionarioBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nome do Funcionário:";
            // 
            // textBox14
            // 
            this.textBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginnBindingSource, "loginn_cd", true));
            this.textBox14.Location = new System.Drawing.Point(70, 33);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(36, 26);
            this.textBox14.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginnBindingSource, "email", true));
            this.textBox7.Location = new System.Drawing.Point(70, 129);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(459, 26);
            this.textBox7.TabIndex = 4;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginnBindingSource, "situaçao", true));
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "",
            "Ativo",
            "Inativo"});
            this.comboBox4.Location = new System.Drawing.Point(405, 97);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(124, 26);
            this.comboBox4.TabIndex = 3;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipodeuserBindingSource, "tipo_nm", true));
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.loginnBindingSource, "tipo_user_cd", true));
            this.comboBox3.DataSource = this.tipodeuserBindingSource;
            this.comboBox3.DisplayMember = "tipo_nm";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(374, 64);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(155, 26);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.ValueMember = "tipo_user_cd";
            // 
            // tipodeuserBindingSource
            // 
            this.tipodeuserBindingSource.DataMember = "tipo_de_user";
            this.tipodeuserBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginnBindingSource, "cadsenha", true));
            this.textBox6.Location = new System.Drawing.Point(70, 96);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(162, 26);
            this.textBox6.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginnBindingSource, "cadloginn", true));
            this.textBox5.Location = new System.Drawing.Point(70, 65);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(162, 26);
            this.textBox5.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(236, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(130, 18);
            this.label16.TabIndex = 4;
            this.label16.Text = "Tipo de Usuário:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(235, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(173, 18);
            this.label15.TabIndex = 3;
            this.label15.Text = "Situação do cadastro:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 18);
            this.label17.TabIndex = 5;
            this.label17.Text = "Email:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 18);
            this.label14.TabIndex = 2;
            this.label14.Text = "Senha:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(5, 37);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(67, 18);
            this.label26.TabIndex = 17;
            this.label26.Text = "Código:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "Usuário:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 25);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tipo_de_userTableAdapter
            // 
            this.tipo_de_userTableAdapter.ClearBeforeFill = true;
            // 
            // loginnTableAdapter
            // 
            this.loginnTableAdapter.ClearBeforeFill = true;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_cadastro_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 196);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gb_CadLogin_cad_fun);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_cadastro_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Novo Login";
            this.Load += new System.EventHandler(this.frm_cadastro_login_Load);
            this.gb_CadLogin_cad_fun.ResumeLayout(false);
            this.gb_CadLogin_cad_fun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodeuserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_CadLogin_cad_fun;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label13;
        private GABARITEIDataSet GABARITEIDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource tipodeuserBindingSource;
        private GABARITEIDataSetTableAdapters.tipo_de_userTableAdapter tipo_de_userTableAdapter;
        private System.Windows.Forms.BindingSource loginnBindingSource;
        private GABARITEIDataSetTableAdapters.loginnTableAdapter loginnTableAdapter;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private GABARITEIDataSetTableAdapters.funcionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}