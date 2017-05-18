namespace gabaritei
{
    partial class frm_cadastro_aluno_materia
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.viewalunonotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gABARITEIDataSet = new gabaritei.GABARITEIDataSet();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.turmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.alunoTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.alunoTableAdapter();
            this.notafaltaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nota_faltaTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.nota_faltaTableAdapter();
            this.turmaTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.turmaTableAdapter();
            this.turmamateriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turma_materiaTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.turma_materiaTableAdapter();
            this.materiaTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.materiaTableAdapter();
            this.view_aluno_notaTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.view_aluno_notaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewalunonotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gABARITEIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notafaltaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmamateriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.viewalunonotaBindingSource, "mat_nm", true));
            this.comboBox1.DataSource = this.materiaBindingSource;
            this.comboBox1.DisplayMember = "mat_nm";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "mat_cd";
            // 
            // viewalunonotaBindingSource
            // 
            this.viewalunonotaBindingSource.DataMember = "view_aluno_nota";
            this.viewalunonotaBindingSource.DataSource = this.gABARITEIDataSet;
            // 
            // gABARITEIDataSet
            // 
            this.gABARITEIDataSet.DataSetName = "GABARITEIDataSet";
            this.gABARITEIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataMember = "materia";
            this.materiaBindingSource.DataSource = this.gABARITEIDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.viewalunonotaBindingSource, "Nome da turma", true));
            this.comboBox2.DataSource = this.turmaBindingSource;
            this.comboBox2.DisplayMember = "tur_nome";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(80, 36);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(244, 24);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "tur_cd";
            // 
            // turmaBindingSource
            // 
            this.turmaBindingSource.DataMember = "turma";
            this.turmaBindingSource.DataSource = this.gABARITEIDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.viewalunonotaBindingSource, "alu_cd", true));
            this.comboBox3.DataSource = this.alunoBindingSource;
            this.comboBox3.DisplayMember = "alu_nm";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(80, 6);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(244, 24);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.ValueMember = "alu_cd";
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataMember = "aluno";
            this.alunoBindingSource.DataSource = this.gABARITEIDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matéeria";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Turma";
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // notafaltaBindingSource
            // 
            this.notafaltaBindingSource.DataMember = "nota_falta";
            this.notafaltaBindingSource.DataSource = this.gABARITEIDataSet;
            // 
            // nota_faltaTableAdapter
            // 
            this.nota_faltaTableAdapter.ClearBeforeFill = true;
            // 
            // turmaTableAdapter
            // 
            this.turmaTableAdapter.ClearBeforeFill = true;
            // 
            // turmamateriaBindingSource
            // 
            this.turmamateriaBindingSource.DataMember = "turma_materia";
            this.turmamateriaBindingSource.DataSource = this.gABARITEIDataSet;
            // 
            // turma_materiaTableAdapter
            // 
            this.turma_materiaTableAdapter.ClearBeforeFill = true;
            // 
            // materiaTableAdapter
            // 
            this.materiaTableAdapter.ClearBeforeFill = true;
            // 
            // view_aluno_notaTableAdapter
            // 
            this.view_aluno_notaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_cadastro_aluno_materia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 167);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_cadastro_aluno_materia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_cadastro_alunadastrar matéria ao Alunoo_materia";
            this.Load += new System.EventHandler(this.frm_cadastro_aluno_materia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewalunonotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gABARITEIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notafaltaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmamateriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private GABARITEIDataSet gABARITEIDataSet;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private GABARITEIDataSetTableAdapters.alunoTableAdapter alunoTableAdapter;
        private System.Windows.Forms.BindingSource notafaltaBindingSource;
        private GABARITEIDataSetTableAdapters.nota_faltaTableAdapter nota_faltaTableAdapter;
        private System.Windows.Forms.BindingSource turmaBindingSource;
        private GABARITEIDataSetTableAdapters.turmaTableAdapter turmaTableAdapter;
        private System.Windows.Forms.BindingSource turmamateriaBindingSource;
        private GABARITEIDataSetTableAdapters.turma_materiaTableAdapter turma_materiaTableAdapter;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private GABARITEIDataSetTableAdapters.materiaTableAdapter materiaTableAdapter;
        private System.Windows.Forms.BindingSource viewalunonotaBindingSource;
        private GABARITEIDataSetTableAdapters.view_aluno_notaTableAdapter view_aluno_notaTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}