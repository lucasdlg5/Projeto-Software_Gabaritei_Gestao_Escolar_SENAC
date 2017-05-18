namespace gabaritei
{
    partial class frm_lançamento_notas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewlancamentonotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GABARITEIDataSet = new gabaritei.GABARITEIDataSet();
            this.notafaltaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.nota_faltaTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.nota_faltaTableAdapter();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.view_lancamento_notasTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.view_lancamento_notasTableAdapter();
            this.viewtriviewturmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_triview_turmaTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.View_triview_turmaTableAdapter();
            this.viewtriviewanoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_triview_anoTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.View_triview_anoTableAdapter();
            this.rtb_prof_lanc_presenc = new System.Windows.Forms.RichTextBox();
            this.tvw_prof_lanc_presenc = new System.Windows.Forms.TreeView();
            this.btn_prof_lanc_presenc = new System.Windows.Forms.Button();
            this.nfcdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.falta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmatcdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trbislcdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewlancamentonotasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notafaltaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewtriviewturmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewtriviewanoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nfcdDataGridViewTextBoxColumn,
            this.nota,
            this.falta,
            this.tmatcdDataGridViewTextBoxColumn,
            this.trbislcdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.notafaltaBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(220, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 464);
            this.dataGridView1.TabIndex = 11;
            // 
            // viewlancamentonotasBindingSource
            // 
            this.viewlancamentonotasBindingSource.DataMember = "view_lancamento_notas";
            this.viewlancamentonotasBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // GABARITEIDataSet
            // 
            this.GABARITEIDataSet.DataSetName = "GABARITEIDataSet";
            this.GABARITEIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notafaltaBindingSource
            // 
            this.notafaltaBindingSource.DataMember = "nota_falta";
            this.notafaltaBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(338, 19);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(501, 26);
            this.textBox28.TabIndex = 14;
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(199, 19);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(142, 26);
            this.label28.TabIndex = 15;
            this.label28.Text = "Nome do aluno:";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(870, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 16;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(686, 549);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(86, 26);
            this.btn_salvar.TabIndex = 17;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(870, 549);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 26);
            this.button3.TabIndex = 18;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(778, 549);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 26);
            this.button4.TabIndex = 19;
            this.button4.Text = "Alterar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notafaltaBindingSource, "nota", true));
            this.textBox1.Location = new System.Drawing.Point(73, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 26);
            this.textBox1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "Notas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notafaltaBindingSource, "falta", true));
            this.textBox2.Location = new System.Drawing.Point(73, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 26);
            this.textBox2.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "Faltas:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 27;
            this.button2.Text = "Lançar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Período Disciplinar: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notafaltaBindingSource, "tr_bi_sl_cd", true));
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Bimestre_semestre_etc";
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // nota_faltaTableAdapter
            // 
            this.nota_faltaTableAdapter.ClearBeforeFill = true;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notafaltaBindingSource, "nf_cd", true));
            this.textBox3.Location = new System.Drawing.Point(73, 13);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Codigo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notafaltaBindingSource, "tr_bi_sl_cd", true));
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(783, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "Matéria_selecionada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(682, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 23);
            this.label7.TabIndex = 32;
            this.label7.Text = "Matéria: ";
            // 
            // view_lancamento_notasTableAdapter
            // 
            this.view_lancamento_notasTableAdapter.ClearBeforeFill = true;
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
            // viewtriviewanoBindingSource
            // 
            this.viewtriviewanoBindingSource.DataMember = "View_triview_ano";
            this.viewtriviewanoBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // view_triview_anoTableAdapter
            // 
            this.view_triview_anoTableAdapter.ClearBeforeFill = true;
            // 
            // rtb_prof_lanc_presenc
            // 
            this.rtb_prof_lanc_presenc.Location = new System.Drawing.Point(17, 156);
            this.rtb_prof_lanc_presenc.Name = "rtb_prof_lanc_presenc";
            this.rtb_prof_lanc_presenc.Size = new System.Drawing.Size(193, 387);
            this.rtb_prof_lanc_presenc.TabIndex = 20;
            this.rtb_prof_lanc_presenc.Text = "";
            // 
            // tvw_prof_lanc_presenc
            // 
            this.tvw_prof_lanc_presenc.Location = new System.Drawing.Point(25, 194);
            this.tvw_prof_lanc_presenc.Name = "tvw_prof_lanc_presenc";
            this.tvw_prof_lanc_presenc.Size = new System.Drawing.Size(174, 338);
            this.tvw_prof_lanc_presenc.TabIndex = 21;
            // 
            // btn_prof_lanc_presenc
            // 
            this.btn_prof_lanc_presenc.Location = new System.Drawing.Point(26, 165);
            this.btn_prof_lanc_presenc.Name = "btn_prof_lanc_presenc";
            this.btn_prof_lanc_presenc.Size = new System.Drawing.Size(173, 23);
            this.btn_prof_lanc_presenc.TabIndex = 22;
            this.btn_prof_lanc_presenc.Text = "Adicionar Lista";
            this.btn_prof_lanc_presenc.UseVisualStyleBackColor = true;
            this.btn_prof_lanc_presenc.Click += new System.EventHandler(this.btn_prof_lanc_presenc_Click);
            // 
            // nfcdDataGridViewTextBoxColumn
            // 
            this.nfcdDataGridViewTextBoxColumn.DataPropertyName = "nf_cd";
            this.nfcdDataGridViewTextBoxColumn.HeaderText = "nf_cd";
            this.nfcdDataGridViewTextBoxColumn.Name = "nfcdDataGridViewTextBoxColumn";
            this.nfcdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nota
            // 
            this.nota.DataPropertyName = "nota";
            this.nota.HeaderText = "nota";
            this.nota.Name = "nota";
            // 
            // falta
            // 
            this.falta.DataPropertyName = "falta";
            this.falta.HeaderText = "falta";
            this.falta.Name = "falta";
            // 
            // tmatcdDataGridViewTextBoxColumn
            // 
            this.tmatcdDataGridViewTextBoxColumn.DataPropertyName = "tmat_cd";
            this.tmatcdDataGridViewTextBoxColumn.HeaderText = "tmat_cd";
            this.tmatcdDataGridViewTextBoxColumn.Name = "tmatcdDataGridViewTextBoxColumn";
            // 
            // trbislcdDataGridViewTextBoxColumn
            // 
            this.trbislcdDataGridViewTextBoxColumn.DataPropertyName = "tr_bi_sl_cd";
            this.trbislcdDataGridViewTextBoxColumn.HeaderText = "tr_bi_sl_cd";
            this.trbislcdDataGridViewTextBoxColumn.Name = "trbislcdDataGridViewTextBoxColumn";
            // 
            // frm_lançamento_notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 578);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_prof_lanc_presenc);
            this.Controls.Add(this.tvw_prof_lanc_presenc);
            this.Controls.Add(this.rtb_prof_lanc_presenc);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox28);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_lançamento_notas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento de notas";
            this.Load += new System.EventHandler(this.frm_notas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewlancamentonotasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notafaltaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewtriviewturmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewtriviewanoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private GABARITEIDataSet GABARITEIDataSet;
        private System.Windows.Forms.BindingSource notafaltaBindingSource;
        private GABARITEIDataSetTableAdapters.nota_faltaTableAdapter nota_faltaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn alucdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource viewlancamentonotasBindingSource;
        private GABARITEIDataSetTableAdapters.view_lancamento_notasTableAdapter view_lancamento_notasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn faltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource viewtriviewturmaBindingSource;
        private GABARITEIDataSetTableAdapters.View_triview_turmaTableAdapter view_triview_turmaTableAdapter;
        private System.Windows.Forms.BindingSource viewtriviewanoBindingSource;
        private GABARITEIDataSetTableAdapters.View_triview_anoTableAdapter view_triview_anoTableAdapter;
        private System.Windows.Forms.Button btn_prof_lanc_presenc;
        private System.Windows.Forms.TreeView tvw_prof_lanc_presenc;
        private System.Windows.Forms.RichTextBox rtb_prof_lanc_presenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nfcdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn falta;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmatcdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trbislcdDataGridViewTextBoxColumn;
     
    }
}