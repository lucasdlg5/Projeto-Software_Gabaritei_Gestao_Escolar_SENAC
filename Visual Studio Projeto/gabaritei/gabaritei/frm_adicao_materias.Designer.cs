namespace gabaritei
{
    partial class frm_adicao_materias
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
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.turmateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDaMatériaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioDeInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioDeTerminoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDaTurmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terçaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quartaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quintaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sextaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domingoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewcadastromateriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GABARITEIDataSet = new gabaritei.GABARITEIDataSet();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.turmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.trbislBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.materiaTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.materiaTableAdapter();
            this.turmaTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.turmaTableAdapter();
            this.tr_bi_slTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.tr_bi_slTableAdapter();
            this.turmamateriahorarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turma_materia_horarioTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.turma_materia_horarioTableAdapter();
            this.view_cadastro_materiaTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.view_cadastro_materiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewcadastromateriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbislBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmamateriahorarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(339, 554);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 72;
            this.button1.Text = "Deletar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(215, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 18);
            this.label8.TabIndex = 71;
            this.label8.Text = "Matérias adicionadas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.turmateriaDataGridViewTextBoxColumn,
            this.nomeDaMatériaDataGridViewTextBoxColumn,
            this.professorDataGridViewTextBoxColumn,
            this.horarioDeInicioDataGridViewTextBoxColumn,
            this.horarioDeTerminoDataGridViewTextBoxColumn,
            this.nomeDaTurmaDataGridViewTextBoxColumn,
            this.segundaDataGridViewTextBoxColumn,
            this.terçaDataGridViewTextBoxColumn,
            this.quartaDataGridViewTextBoxColumn,
            this.quintaDataGridViewTextBoxColumn,
            this.sextaDataGridViewTextBoxColumn,
            this.sabadoDataGridViewTextBoxColumn,
            this.domingoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewcadastromateriaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(640, 308);
            this.dataGridView1.TabIndex = 70;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // turmateriaDataGridViewTextBoxColumn
            // 
            this.turmateriaDataGridViewTextBoxColumn.DataPropertyName = "tur_materia";
            this.turmateriaDataGridViewTextBoxColumn.HeaderText = "tur_materia";
            this.turmateriaDataGridViewTextBoxColumn.Name = "turmateriaDataGridViewTextBoxColumn";
            this.turmateriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDaMatériaDataGridViewTextBoxColumn
            // 
            this.nomeDaMatériaDataGridViewTextBoxColumn.DataPropertyName = "Nome da matéria";
            this.nomeDaMatériaDataGridViewTextBoxColumn.HeaderText = "Nome da matéria";
            this.nomeDaMatériaDataGridViewTextBoxColumn.Name = "nomeDaMatériaDataGridViewTextBoxColumn";
            this.nomeDaMatériaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // professorDataGridViewTextBoxColumn
            // 
            this.professorDataGridViewTextBoxColumn.DataPropertyName = "Professor";
            this.professorDataGridViewTextBoxColumn.HeaderText = "Professor";
            this.professorDataGridViewTextBoxColumn.Name = "professorDataGridViewTextBoxColumn";
            this.professorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horarioDeInicioDataGridViewTextBoxColumn
            // 
            this.horarioDeInicioDataGridViewTextBoxColumn.DataPropertyName = "Horario de inicio";
            this.horarioDeInicioDataGridViewTextBoxColumn.HeaderText = "Horario de inicio";
            this.horarioDeInicioDataGridViewTextBoxColumn.Name = "horarioDeInicioDataGridViewTextBoxColumn";
            this.horarioDeInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horarioDeTerminoDataGridViewTextBoxColumn
            // 
            this.horarioDeTerminoDataGridViewTextBoxColumn.DataPropertyName = "Horario de Termino";
            this.horarioDeTerminoDataGridViewTextBoxColumn.HeaderText = "Horario de Termino";
            this.horarioDeTerminoDataGridViewTextBoxColumn.Name = "horarioDeTerminoDataGridViewTextBoxColumn";
            this.horarioDeTerminoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDaTurmaDataGridViewTextBoxColumn
            // 
            this.nomeDaTurmaDataGridViewTextBoxColumn.DataPropertyName = "Nome da turma";
            this.nomeDaTurmaDataGridViewTextBoxColumn.HeaderText = "Nome da turma";
            this.nomeDaTurmaDataGridViewTextBoxColumn.Name = "nomeDaTurmaDataGridViewTextBoxColumn";
            this.nomeDaTurmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // segundaDataGridViewTextBoxColumn
            // 
            this.segundaDataGridViewTextBoxColumn.DataPropertyName = "Segunda";
            this.segundaDataGridViewTextBoxColumn.HeaderText = "Segunda";
            this.segundaDataGridViewTextBoxColumn.Name = "segundaDataGridViewTextBoxColumn";
            this.segundaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // terçaDataGridViewTextBoxColumn
            // 
            this.terçaDataGridViewTextBoxColumn.DataPropertyName = "Terça";
            this.terçaDataGridViewTextBoxColumn.HeaderText = "Terça";
            this.terçaDataGridViewTextBoxColumn.Name = "terçaDataGridViewTextBoxColumn";
            this.terçaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quartaDataGridViewTextBoxColumn
            // 
            this.quartaDataGridViewTextBoxColumn.DataPropertyName = "Quarta";
            this.quartaDataGridViewTextBoxColumn.HeaderText = "Quarta";
            this.quartaDataGridViewTextBoxColumn.Name = "quartaDataGridViewTextBoxColumn";
            this.quartaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quintaDataGridViewTextBoxColumn
            // 
            this.quintaDataGridViewTextBoxColumn.DataPropertyName = "Quinta";
            this.quintaDataGridViewTextBoxColumn.HeaderText = "Quinta";
            this.quintaDataGridViewTextBoxColumn.Name = "quintaDataGridViewTextBoxColumn";
            this.quintaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sextaDataGridViewTextBoxColumn
            // 
            this.sextaDataGridViewTextBoxColumn.DataPropertyName = "Sexta";
            this.sextaDataGridViewTextBoxColumn.HeaderText = "Sexta";
            this.sextaDataGridViewTextBoxColumn.Name = "sextaDataGridViewTextBoxColumn";
            this.sextaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sabadoDataGridViewTextBoxColumn
            // 
            this.sabadoDataGridViewTextBoxColumn.DataPropertyName = "Sabado";
            this.sabadoDataGridViewTextBoxColumn.HeaderText = "Sabado";
            this.sabadoDataGridViewTextBoxColumn.Name = "sabadoDataGridViewTextBoxColumn";
            this.sabadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // domingoDataGridViewTextBoxColumn
            // 
            this.domingoDataGridViewTextBoxColumn.DataPropertyName = "Domingo";
            this.domingoDataGridViewTextBoxColumn.HeaderText = "Domingo";
            this.domingoDataGridViewTextBoxColumn.Name = "domingoDataGridViewTextBoxColumn";
            this.domingoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewcadastromateriaBindingSource
            // 
            this.viewcadastromateriaBindingSource.DataMember = "view_cadastro_materia";
            this.viewcadastromateriaBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // GABARITEIDataSet
            // 
            this.GABARITEIDataSet.DataSetName = "GABARITEIDataSet";
            this.GABARITEIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataMember = "materia";
            this.materiaBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LimeGreen;
            this.label7.Location = new System.Drawing.Point(251, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 18);
            this.label7.TabIndex = 69;
            this.label7.Text = "Adição de Matérias";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(434, 554);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 26);
            this.button3.TabIndex = 68;
            this.button3.Text = "Nova matéria";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(563, 554);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 26);
            this.button2.TabIndex = 67;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.turmaBindingSource, "periodo_M_T_N", true));
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(464, 142);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 66;
            // 
            // turmaBindingSource
            // 
            this.turmaBindingSource.DataMember = "turma";
            this.turmaBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.turmaBindingSource, "tur_vagas", true));
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(464, 104);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(193, 20);
            this.numericUpDown1.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(346, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 36);
            this.label6.TabIndex = 64;
            this.label6.Text = "Periodo:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 36);
            this.label5.TabIndex = 63;
            this.label5.Text = "N° de vagas:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.turmaBindingSource, "datadetermino", true));
            this.maskedTextBox2.Enabled = false;
            this.maskedTextBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(165, 140);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(159, 26);
            this.maskedTextBox2.TabIndex = 62;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.turmaBindingSource, "datadeinicio", true));
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(165, 106);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(159, 26);
            this.maskedTextBox1.TabIndex = 61;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-80, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 36);
            this.label4.TabIndex = 60;
            this.label4.Text = "Data de termino:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-80, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 36);
            this.label3.TabIndex = 59;
            this.label3.Text = "Data de inicio:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.turmaBindingSource, "tur_nome", true));
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(165, 72);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(492, 26);
            this.textBox1.TabIndex = 58;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-140, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 36);
            this.label1.TabIndex = 57;
            this.label1.Text = "Nome da turma:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.turmaBindingSource, "tur_cd", true));
            this.textBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(165, 41);
            this.textBox2.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(95, 26);
            this.textBox2.TabIndex = 55;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 36);
            this.label2.TabIndex = 56;
            this.label2.Text = "Código:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trbislBindingSource, "tr_bi_sl_nm", true));
            this.textBox3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(165, 175);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(159, 26);
            this.textBox3.TabIndex = 74;
            // 
            // trbislBindingSource
            // 
            this.trbislBindingSource.DataMember = "tr_bi_sl";
            this.trbislBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 169);
            this.label9.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 36);
            this.label9.TabIndex = 73;
            this.label9.Text = "Período Disciplinar:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // materiaTableAdapter
            // 
            this.materiaTableAdapter.ClearBeforeFill = true;
            // 
            // turmaTableAdapter
            // 
            this.turmaTableAdapter.ClearBeforeFill = true;
            // 
            // tr_bi_slTableAdapter
            // 
            this.tr_bi_slTableAdapter.ClearBeforeFill = true;
            // 
            // turmamateriahorarioBindingSource
            // 
            this.turmamateriahorarioBindingSource.DataMember = "turma_materia_horario";
            this.turmamateriahorarioBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // turma_materia_horarioTableAdapter
            // 
            this.turma_materia_horarioTableAdapter.ClearBeforeFill = true;
            // 
            // view_cadastro_materiaTableAdapter
            // 
            this.view_cadastro_materiaTableAdapter.ClearBeforeFill = true;
            // 
            // frm_adicao_materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 591);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Name = "frm_adicao_materias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adição de Matérias/Turmas";
            this.Load += new System.EventHandler(this.frm_adicao_materias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewcadastromateriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbislBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmamateriahorarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private GABARITEIDataSet GABARITEIDataSet;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private GABARITEIDataSetTableAdapters.materiaTableAdapter materiaTableAdapter;
        private System.Windows.Forms.BindingSource turmaBindingSource;
        private GABARITEIDataSetTableAdapters.turmaTableAdapter turmaTableAdapter;
        private System.Windows.Forms.BindingSource trbislBindingSource;
        private GABARITEIDataSetTableAdapters.tr_bi_slTableAdapter tr_bi_slTableAdapter;
        private System.Windows.Forms.BindingSource turmamateriahorarioBindingSource;
        private GABARITEIDataSetTableAdapters.turma_materia_horarioTableAdapter turma_materia_horarioTableAdapter;
        private System.Windows.Forms.BindingSource viewcadastromateriaBindingSource;
        private GABARITEIDataSetTableAdapters.view_cadastro_materiaTableAdapter view_cadastro_materiaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn turmateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDaMatériaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioDeInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioDeTerminoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDaTurmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terçaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quartaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quintaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sextaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domingoDataGridViewTextBoxColumn;
    }
}