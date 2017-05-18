namespace gabaritei
{
    partial class frm_cadastro_materias
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
            this.turmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GABARITEIDataSet = new gabaritei.GABARITEIDataSet();
            this.turmamateriahorarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cmbprofessorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turmamateriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.cmbturmaaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.trbislBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmb_professorTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.cmb_professorTableAdapter();
            this.cargoTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.cargoTableAdapter();
            this.turmaTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.turmaTableAdapter();
            this.tr_bi_slTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.tr_bi_slTableAdapter();
            this.turma_materia_horarioTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.turma_materia_horarioTableAdapter();
            this.materiaTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.materiaTableAdapter();
            this.turma_materiaTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.turma_materiaTableAdapter();
            this.cmb_turmaaTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.cmb_turmaaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.turmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmamateriahorarioBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbprofessorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmamateriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbturmaaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbislBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // turmaBindingSource
            // 
            this.turmaBindingSource.DataMember = "turma";
            this.turmaBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // GABARITEIDataSet
            // 
            this.GABARITEIDataSet.DataSetName = "GABARITEIDataSet";
            this.GABARITEIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // turmamateriahorarioBindingSource
            // 
            this.turmamateriahorarioBindingSource.DataMember = "turma_materia_horario";
            this.turmamateriahorarioBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 160);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matéria";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.cmbprofessorBindingSource, "Nome do professor", true));
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.turmamateriaBindingSource, "mat_cd", true));
            this.comboBox2.DataSource = this.materiaBindingSource;
            this.comboBox2.DisplayMember = "mat_nm";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(102, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(189, 26);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.ValueMember = "mat_cd";
            // 
            // cmbprofessorBindingSource
            // 
            this.cmbprofessorBindingSource.DataMember = "cmb_professor";
            this.cmbprofessorBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // turmamateriaBindingSource
            // 
            this.turmamateriaBindingSource.DataMember = "turma_materia";
            this.turmamateriaBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataMember = "materia";
            this.materiaBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.turmaBindingSource, "periodo_M_T_N", true));
            this.textBox4.Location = new System.Drawing.Point(371, 89);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(119, 26);
            this.textBox4.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.turmamateriaBindingSource, "tur_materia", true));
            this.textBox1.Location = new System.Drawing.Point(102, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(88, 26);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.turmamateriaBindingSource, "tur_cd", true));
            this.comboBox3.DataSource = this.cmbturmaaBindingSource;
            this.comboBox3.DisplayMember = "Nome da turma";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(102, 121);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(388, 26);
            this.comboBox3.TabIndex = 12;
            this.comboBox3.ValueMember = "Codigo";
            // 
            // cmbturmaaBindingSource
            // 
            this.cmbturmaaBindingSource.DataMember = "cmb_turmaa";
            this.cmbturmaaBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Turma: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Professor:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.cmbprofessorBindingSource, "Nome do professor", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.turmamateriaBindingSource, "fun_cd", true));
            this.comboBox1.DataSource = this.cmbprofessorBindingSource;
            this.comboBox1.DisplayMember = "Nome do professor";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(388, 26);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "fun_cd";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Matéria:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(297, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 26);
            this.label9.TabIndex = 14;
            this.label9.Text = "Período:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trbislBindingSource
            // 
            this.trbislBindingSource.DataMember = "tr_bi_sl";
            this.trbislBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // cargoBindingSource
            // 
            this.cargoBindingSource.DataMember = "cargo";
            this.cargoBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(335, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 26);
            this.button3.TabIndex = 24;
            this.button3.Text = "Salvar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 22;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cadastro de Matérias";
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
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "uol";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // cmb_professorTableAdapter
            // 
            this.cmb_professorTableAdapter.ClearBeforeFill = true;
            // 
            // cargoTableAdapter
            // 
            this.cargoTableAdapter.ClearBeforeFill = true;
            // 
            // turmaTableAdapter
            // 
            this.turmaTableAdapter.ClearBeforeFill = true;
            // 
            // tr_bi_slTableAdapter
            // 
            this.tr_bi_slTableAdapter.ClearBeforeFill = true;
            // 
            // turma_materia_horarioTableAdapter
            // 
            this.turma_materia_horarioTableAdapter.ClearBeforeFill = true;
            // 
            // materiaTableAdapter
            // 
            this.materiaTableAdapter.ClearBeforeFill = true;
            // 
            // turma_materiaTableAdapter
            // 
            this.turma_materiaTableAdapter.ClearBeforeFill = true;
            // 
            // cmb_turmaaTableAdapter
            // 
            this.cmb_turmaaTableAdapter.ClearBeforeFill = true;
            // 
            // frm_cadastro_materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 234);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_cadastro_materias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Matérias";
            this.Load += new System.EventHandler(this.frm_cadastro_materias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmamateriahorarioBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbprofessorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmamateriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbturmaaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbislBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private GABARITEIDataSet GABARITEIDataSet;
        private System.Windows.Forms.BindingSource cmbprofessorBindingSource;
        private GABARITEIDataSetTableAdapters.cmb_professorTableAdapter cmb_professorTableAdapter;
        private System.Windows.Forms.BindingSource cargoBindingSource;
        private GABARITEIDataSetTableAdapters.cargoTableAdapter cargoTableAdapter;
        private System.Windows.Forms.BindingSource turmaBindingSource;
        private GABARITEIDataSetTableAdapters.turmaTableAdapter turmaTableAdapter;
        private System.Windows.Forms.BindingSource trbislBindingSource;
        private GABARITEIDataSetTableAdapters.tr_bi_slTableAdapter tr_bi_slTableAdapter;
        private System.Windows.Forms.BindingSource turmamateriahorarioBindingSource;
        private GABARITEIDataSetTableAdapters.turma_materia_horarioTableAdapter turma_materia_horarioTableAdapter;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private GABARITEIDataSetTableAdapters.materiaTableAdapter materiaTableAdapter;
        private System.Windows.Forms.BindingSource turmamateriaBindingSource;
        private GABARITEIDataSetTableAdapters.turma_materiaTableAdapter turma_materiaTableAdapter;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.BindingSource cmbturmaaBindingSource;
        private GABARITEIDataSetTableAdapters.cmb_turmaaTableAdapter cmb_turmaaTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;

    }
}