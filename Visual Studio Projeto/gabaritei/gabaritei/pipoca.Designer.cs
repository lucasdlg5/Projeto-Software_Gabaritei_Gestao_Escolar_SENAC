namespace gabaritei
{
    partial class pipoca
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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gABARITEIDataSet = new gabaritei.GABARITEIDataSet();
            this.alunotelefoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aluno_telefoneTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.aluno_telefoneTableAdapter();
            this.alutcdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alucdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telnumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttelcdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunoTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.alunoTableAdapter();
            this.tipotelefoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_telefoneTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.tipo_telefoneTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gABARITEIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunotelefoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipotelefoneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(483, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 27);
            this.button2.TabIndex = 67;
            this.button2.Text = "Atualizar Categoria";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "alu_cd", true));
            this.textBox2.Location = new System.Drawing.Point(631, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(50, 26);
            this.textBox2.TabIndex = 66;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunotelefoneBindingSource, "alut_cd", true));
            this.textBox6.Location = new System.Drawing.Point(565, 12);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(57, 26);
            this.textBox6.TabIndex = 65;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(496, 12);
            this.label28.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(67, 26);
            this.label28.TabIndex = 64;
            this.label28.Text = "Código:";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(573, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 26);
            this.button3.TabIndex = 63;
            this.button3.Text = "Nova Categoria";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(483, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 26);
            this.button4.TabIndex = 62;
            this.button4.Text = "Adicionar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.alunotelefoneBindingSource, "ttel_cd", true));
            this.comboBox2.DataSource = this.tipotelefoneBindingSource;
            this.comboBox2.DisplayMember = "ttel_nm";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(565, 71);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 26);
            this.comboBox2.TabIndex = 57;
            this.comboBox2.ValueMember = "ttel_cd";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(478, 71);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 26);
            this.label17.TabIndex = 61;
            this.label17.Tag = "Tipo Telefone";
            this.label17.Text = "Categoria:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunotelefoneBindingSource, "tel_numero", true));
            this.textBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(565, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 26);
            this.textBox1.TabIndex = 59;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(475, 41);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 26);
            this.label16.TabIndex = 60;
            this.label16.Text = "Numero:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alutcdDataGridViewTextBoxColumn,
            this.alucdDataGridViewTextBoxColumn,
            this.telnumeroDataGridViewTextBoxColumn,
            this.ttelcdDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.alunotelefoneBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(461, 157);
            this.dataGridView2.TabIndex = 58;
            // 
            // gABARITEIDataSet
            // 
            this.gABARITEIDataSet.DataSetName = "GABARITEIDataSet";
            this.gABARITEIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunotelefoneBindingSource
            // 
            this.alunotelefoneBindingSource.DataMember = "aluno_telefone";
            this.alunotelefoneBindingSource.DataSource = this.gABARITEIDataSet;
            // 
            // aluno_telefoneTableAdapter
            // 
            this.aluno_telefoneTableAdapter.ClearBeforeFill = true;
            // 
            // alutcdDataGridViewTextBoxColumn
            // 
            this.alutcdDataGridViewTextBoxColumn.DataPropertyName = "alut_cd";
            this.alutcdDataGridViewTextBoxColumn.HeaderText = "alut_cd";
            this.alutcdDataGridViewTextBoxColumn.Name = "alutcdDataGridViewTextBoxColumn";
            this.alutcdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alucdDataGridViewTextBoxColumn
            // 
            this.alucdDataGridViewTextBoxColumn.DataPropertyName = "alu_cd";
            this.alucdDataGridViewTextBoxColumn.HeaderText = "alu_cd";
            this.alucdDataGridViewTextBoxColumn.Name = "alucdDataGridViewTextBoxColumn";
            this.alucdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telnumeroDataGridViewTextBoxColumn
            // 
            this.telnumeroDataGridViewTextBoxColumn.DataPropertyName = "tel_numero";
            this.telnumeroDataGridViewTextBoxColumn.HeaderText = "tel_numero";
            this.telnumeroDataGridViewTextBoxColumn.Name = "telnumeroDataGridViewTextBoxColumn";
            this.telnumeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ttelcdDataGridViewTextBoxColumn
            // 
            this.ttelcdDataGridViewTextBoxColumn.DataPropertyName = "ttel_cd";
            this.ttelcdDataGridViewTextBoxColumn.HeaderText = "ttel_cd";
            this.ttelcdDataGridViewTextBoxColumn.Name = "ttelcdDataGridViewTextBoxColumn";
            this.ttelcdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataMember = "aluno";
            this.alunoBindingSource.DataSource = this.gABARITEIDataSet;
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // tipotelefoneBindingSource
            // 
            this.tipotelefoneBindingSource.DataMember = "tipo_telefone";
            this.tipotelefoneBindingSource.DataSource = this.gABARITEIDataSet;
            // 
            // tipo_telefoneTableAdapter
            // 
            this.tipo_telefoneTableAdapter.ClearBeforeFill = true;
            // 
            // pipoca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 179);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dataGridView2);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "pipoca";
            this.Text = "pipoca";
            this.Load += new System.EventHandler(this.pipoca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gABARITEIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunotelefoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipotelefoneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridView2;
        private GABARITEIDataSet gABARITEIDataSet;
        private System.Windows.Forms.BindingSource alunotelefoneBindingSource;
        private GABARITEIDataSetTableAdapters.aluno_telefoneTableAdapter aluno_telefoneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn alutcdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alucdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telnumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttelcdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private GABARITEIDataSetTableAdapters.alunoTableAdapter alunoTableAdapter;
        private System.Windows.Forms.BindingSource tipotelefoneBindingSource;
        private GABARITEIDataSetTableAdapters.tipo_telefoneTableAdapter tipo_telefoneTableAdapter;
    }
}