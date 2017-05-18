namespace gabaritei
{
    partial class frm_lista_materias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewcadastromateriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GABARITEIDataSet = new gabaritei.GABARITEIDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.view_cadastro_materiaTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.view_cadastro_materiaTableAdapter();
            this.viewtriviewanoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_triview_anoTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.View_triview_anoTableAdapter();
            this.viewtriviewturmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_triview_turmaTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.View_triview_turmaTableAdapter();
            this.nomeDaTurmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDaMatériaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioDeInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioDeTerminoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terçaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quartaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quintaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sextaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domingoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewcadastromateriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewtriviewanoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewtriviewturmaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(865, 632);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 26);
            this.button2.TabIndex = 49;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(770, 632);
            this.button5.Margin = new System.Windows.Forms.Padding(6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 26);
            this.button5.TabIndex = 48;
            this.button5.Text = "Novo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(865, 15);
            this.button4.Margin = new System.Windows.Forms.Padding(6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 26);
            this.button4.TabIndex = 46;
            this.button4.Text = "Pesquisar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(711, 16);
            this.textBox2.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 26);
            this.textBox2.TabIndex = 45;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDaTurmaDataGridViewTextBoxColumn,
            this.nomeDaMatériaDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.professorDataGridViewTextBoxColumn,
            this.horarioDeInicioDataGridViewTextBoxColumn,
            this.horarioDeTerminoDataGridViewTextBoxColumn,
            this.segundaDataGridViewTextBoxColumn,
            this.terçaDataGridViewTextBoxColumn,
            this.quartaDataGridViewTextBoxColumn,
            this.sabadoDataGridViewTextBoxColumn,
            this.quintaDataGridViewTextBoxColumn,
            this.sextaDataGridViewTextBoxColumn,
            this.domingoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewcadastromateriaBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(11, 57);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(940, 569);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(77, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(556, 26);
            this.textBox1.TabIndex = 43;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 36);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(639, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 36);
            this.label2.TabIndex = 41;
            this.label2.Text = "Código:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // view_cadastro_materiaTableAdapter
            // 
            this.view_cadastro_materiaTableAdapter.ClearBeforeFill = true;
            // 
            // viewtriviewanoBindingSource
            // 
            this.viewtriviewanoBindingSource.DataMember = "View_triview_ano";
            this.viewtriviewanoBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // view_triview_anoTableAdapter
            // 
            this.view_triview_anoTableAdapter.ClearBeforeFill = true;
            // 
            // viewtriviewturmaBindingSource
            // 
            this.viewtriviewturmaBindingSource.DataMember = "View_triview_turma";
            this.viewtriviewturmaBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // view_triview_turmaTableAdapter
            // 
            this.view_triview_turmaTableAdapter.ClearBeforeFill = true;
            // 
            // nomeDaTurmaDataGridViewTextBoxColumn
            // 
            this.nomeDaTurmaDataGridViewTextBoxColumn.DataPropertyName = "Nome da turma";
            this.nomeDaTurmaDataGridViewTextBoxColumn.HeaderText = "Nome da turma";
            this.nomeDaTurmaDataGridViewTextBoxColumn.Name = "nomeDaTurmaDataGridViewTextBoxColumn";
            // 
            // nomeDaMatériaDataGridViewTextBoxColumn
            // 
            this.nomeDaMatériaDataGridViewTextBoxColumn.DataPropertyName = "Nome da matéria";
            this.nomeDaMatériaDataGridViewTextBoxColumn.HeaderText = "Nome da matéria";
            this.nomeDaMatériaDataGridViewTextBoxColumn.Name = "nomeDaMatériaDataGridViewTextBoxColumn";
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            // 
            // professorDataGridViewTextBoxColumn
            // 
            this.professorDataGridViewTextBoxColumn.DataPropertyName = "Professor";
            this.professorDataGridViewTextBoxColumn.HeaderText = "Professor";
            this.professorDataGridViewTextBoxColumn.Name = "professorDataGridViewTextBoxColumn";
            // 
            // horarioDeInicioDataGridViewTextBoxColumn
            // 
            this.horarioDeInicioDataGridViewTextBoxColumn.DataPropertyName = "Horario de inicio";
            this.horarioDeInicioDataGridViewTextBoxColumn.HeaderText = "Horario de inicio";
            this.horarioDeInicioDataGridViewTextBoxColumn.Name = "horarioDeInicioDataGridViewTextBoxColumn";
            // 
            // horarioDeTerminoDataGridViewTextBoxColumn
            // 
            this.horarioDeTerminoDataGridViewTextBoxColumn.DataPropertyName = "Horario de Termino";
            this.horarioDeTerminoDataGridViewTextBoxColumn.HeaderText = "Horario de Termino";
            this.horarioDeTerminoDataGridViewTextBoxColumn.Name = "horarioDeTerminoDataGridViewTextBoxColumn";
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
            // sabadoDataGridViewTextBoxColumn
            // 
            this.sabadoDataGridViewTextBoxColumn.DataPropertyName = "Sabado";
            this.sabadoDataGridViewTextBoxColumn.HeaderText = "Sabado";
            this.sabadoDataGridViewTextBoxColumn.Name = "sabadoDataGridViewTextBoxColumn";
            this.sabadoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // domingoDataGridViewTextBoxColumn
            // 
            this.domingoDataGridViewTextBoxColumn.DataPropertyName = "Domingo";
            this.domingoDataGridViewTextBoxColumn.HeaderText = "Domingo";
            this.domingoDataGridViewTextBoxColumn.Name = "domingoDataGridViewTextBoxColumn";
            this.domingoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_lista_materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 666);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_lista_materias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Matérias";
            this.Load += new System.EventHandler(this.frm_lista_materias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewcadastromateriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewtriviewanoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewtriviewturmaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private GABARITEIDataSet GABARITEIDataSet;
        private System.Windows.Forms.BindingSource viewcadastromateriaBindingSource;
        private GABARITEIDataSetTableAdapters.view_cadastro_materiaTableAdapter view_cadastro_materiaTableAdapter;
        private System.Windows.Forms.BindingSource viewtriviewanoBindingSource;
        private GABARITEIDataSetTableAdapters.View_triview_anoTableAdapter view_triview_anoTableAdapter;
        private System.Windows.Forms.BindingSource viewtriviewturmaBindingSource;
        private GABARITEIDataSetTableAdapters.View_triview_turmaTableAdapter view_triview_turmaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDaTurmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDaMatériaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioDeInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioDeTerminoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terçaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quartaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quintaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sextaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domingoDataGridViewTextBoxColumn;
    }
}