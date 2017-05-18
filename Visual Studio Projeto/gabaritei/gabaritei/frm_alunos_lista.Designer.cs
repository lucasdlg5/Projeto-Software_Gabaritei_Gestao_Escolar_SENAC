namespace gabaritei
{
    partial class frm_funcionarios_lista
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
            this.dgv_alunos = new System.Windows.Forms.DataGridView();
            this.lbl_pesquisa_alunos = new System.Windows.Forms.Label();
            this.txb_pesquisa_alunos = new System.Windows.Forms.TextBox();
            this.cancelar_alunos = new System.Windows.Forms.Button();
            this.alterar_alunos = new System.Windows.Forms.Button();
            this.pesquisar_alunos = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GABARITEIDataSet = new gabaritei.GABARITEIDataSet();
            this.viewalunoturmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_aluno_turmaTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.view_aluno_turmaTableAdapter();
            this.nomeDoAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDaTurmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioDeEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioDeSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewalunoturmaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_alunos
            // 
            this.dgv_alunos.AutoGenerateColumns = false;
            this.dgv_alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDoAlunoDataGridViewTextBoxColumn,
            this.nomeDaTurmaDataGridViewTextBoxColumn,
            this.horarioDeEntradaDataGridViewTextBoxColumn,
            this.horarioDeSaidaDataGridViewTextBoxColumn});
            this.dgv_alunos.DataSource = this.viewalunoturmaBindingSource;
            this.dgv_alunos.Location = new System.Drawing.Point(12, 52);
            this.dgv_alunos.Name = "dgv_alunos";
            this.dgv_alunos.Size = new System.Drawing.Size(1107, 505);
            this.dgv_alunos.TabIndex = 1;
            // 
            // lbl_pesquisa_alunos
            // 
            this.lbl_pesquisa_alunos.AutoSize = true;
            this.lbl_pesquisa_alunos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesquisa_alunos.Location = new System.Drawing.Point(165, 17);
            this.lbl_pesquisa_alunos.Name = "lbl_pesquisa_alunos";
            this.lbl_pesquisa_alunos.Size = new System.Drawing.Size(94, 18);
            this.lbl_pesquisa_alunos.TabIndex = 5;
            this.lbl_pesquisa_alunos.Text = "Pesquisar:";
            // 
            // txb_pesquisa_alunos
            // 
            this.txb_pesquisa_alunos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_pesquisa_alunos.Location = new System.Drawing.Point(265, 14);
            this.txb_pesquisa_alunos.Name = "txb_pesquisa_alunos";
            this.txb_pesquisa_alunos.Size = new System.Drawing.Size(547, 27);
            this.txb_pesquisa_alunos.TabIndex = 6;
            // 
            // cancelar_alunos
            // 
            this.cancelar_alunos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar_alunos.Location = new System.Drawing.Point(1035, 12);
            this.cancelar_alunos.Name = "cancelar_alunos";
            this.cancelar_alunos.Size = new System.Drawing.Size(88, 31);
            this.cancelar_alunos.TabIndex = 7;
            this.cancelar_alunos.Text = "Cancelar";
            this.cancelar_alunos.UseVisualStyleBackColor = true;
            this.cancelar_alunos.Click += new System.EventHandler(this.button1_Click);
            // 
            // alterar_alunos
            // 
            this.alterar_alunos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterar_alunos.Location = new System.Drawing.Point(954, 12);
            this.alterar_alunos.Name = "alterar_alunos";
            this.alterar_alunos.Size = new System.Drawing.Size(75, 31);
            this.alterar_alunos.TabIndex = 8;
            this.alterar_alunos.Text = "Alterar";
            this.alterar_alunos.UseVisualStyleBackColor = true;
            this.alterar_alunos.Click += new System.EventHandler(this.alterar_alunos_Click);
            // 
            // pesquisar_alunos
            // 
            this.pesquisar_alunos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisar_alunos.Location = new System.Drawing.Point(851, 12);
            this.pesquisar_alunos.Name = "pesquisar_alunos";
            this.pesquisar_alunos.Size = new System.Drawing.Size(97, 31);
            this.pesquisar_alunos.TabIndex = 9;
            this.pesquisar_alunos.Text = "Pesquisar";
            this.pesquisar_alunos.UseVisualStyleBackColor = true;
            this.pesquisar_alunos.Click += new System.EventHandler(this.button3_Click);
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
            // 
            // GABARITEIDataSet
            // 
            this.GABARITEIDataSet.DataSetName = "GABARITEIDataSet";
            this.GABARITEIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewalunoturmaBindingSource
            // 
            this.viewalunoturmaBindingSource.DataMember = "view_aluno_turma";
            this.viewalunoturmaBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // view_aluno_turmaTableAdapter
            // 
            this.view_aluno_turmaTableAdapter.ClearBeforeFill = true;
            // 
            // nomeDoAlunoDataGridViewTextBoxColumn
            // 
            this.nomeDoAlunoDataGridViewTextBoxColumn.DataPropertyName = "Nome do aluno";
            this.nomeDoAlunoDataGridViewTextBoxColumn.HeaderText = "Nome do aluno";
            this.nomeDoAlunoDataGridViewTextBoxColumn.Name = "nomeDoAlunoDataGridViewTextBoxColumn";
            // 
            // nomeDaTurmaDataGridViewTextBoxColumn
            // 
            this.nomeDaTurmaDataGridViewTextBoxColumn.DataPropertyName = "Nome da turma";
            this.nomeDaTurmaDataGridViewTextBoxColumn.HeaderText = "Nome da turma";
            this.nomeDaTurmaDataGridViewTextBoxColumn.Name = "nomeDaTurmaDataGridViewTextBoxColumn";
            // 
            // horarioDeEntradaDataGridViewTextBoxColumn
            // 
            this.horarioDeEntradaDataGridViewTextBoxColumn.DataPropertyName = "Horario de entrada";
            this.horarioDeEntradaDataGridViewTextBoxColumn.HeaderText = "Horario de entrada";
            this.horarioDeEntradaDataGridViewTextBoxColumn.Name = "horarioDeEntradaDataGridViewTextBoxColumn";
            // 
            // horarioDeSaidaDataGridViewTextBoxColumn
            // 
            this.horarioDeSaidaDataGridViewTextBoxColumn.DataPropertyName = "Horario de saida";
            this.horarioDeSaidaDataGridViewTextBoxColumn.HeaderText = "Horario de saida";
            this.horarioDeSaidaDataGridViewTextBoxColumn.Name = "horarioDeSaidaDataGridViewTextBoxColumn";
            // 
            // frm_funcionarios_lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 569);
            this.Controls.Add(this.pesquisar_alunos);
            this.Controls.Add(this.alterar_alunos);
            this.Controls.Add(this.cancelar_alunos);
            this.Controls.Add(this.txb_pesquisa_alunos);
            this.Controls.Add(this.lbl_pesquisa_alunos);
            this.Controls.Add(this.dgv_alunos);
            this.MaximizeBox = false;
            this.Name = "frm_funcionarios_lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista alunos e suas respectivas turmas";
            this.Load += new System.EventHandler(this.Alunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewalunoturmaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_alunos;
        private System.Windows.Forms.Label lbl_pesquisa_alunos;
        private System.Windows.Forms.TextBox txb_pesquisa_alunos;
        private System.Windows.Forms.Button cancelar_alunos;
        private System.Windows.Forms.Button alterar_alunos;
        private System.Windows.Forms.Button pesquisar_alunos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private GABARITEIDataSet GABARITEIDataSet;
        private System.Windows.Forms.BindingSource viewalunoturmaBindingSource;
        private GABARITEIDataSetTableAdapters.view_aluno_turmaTableAdapter view_aluno_turmaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDoAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDaTurmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioDeEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioDeSaidaDataGridViewTextBoxColumn;

    }
}