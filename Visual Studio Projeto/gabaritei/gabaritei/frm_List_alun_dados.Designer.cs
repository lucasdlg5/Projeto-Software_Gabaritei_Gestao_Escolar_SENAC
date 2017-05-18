namespace gabaritei
{
    partial class frm_list_alun_dados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_list_alun_dados));
            this.GABARITEIDataSet = new gabaritei.GABARITEIDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.viewtriviewturmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_triview_turmaTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.View_triview_turmaTableAdapter();
            this.viewtriviewanoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_triview_anoTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.View_triview_anoTableAdapter();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunoTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.alunoTableAdapter();
            this.dgv_list_alun_dados = new System.Windows.Forms.DataGridView();
            this.viewlistaalunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_lista_alunoTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.view_lista_alunoTableAdapter();
            this.alucdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDeCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respcdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDoResponsávelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respCatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgãoExpedidorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endlogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endcepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endbairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endnumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endcomplementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewtriviewturmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewtriviewanoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_alun_dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewlistaalunoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GABARITEIDataSet
            // 
            this.GABARITEIDataSet.DataSetName = "GABARITEIDataSet";
            this.GABARITEIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(82, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(664, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(754, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 27);
            this.button2.TabIndex = 9;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button2_KeyPress);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(725, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 26);
            this.button3.TabIndex = 10;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(832, 411);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 26);
            this.button4.TabIndex = 11;
            this.button4.Text = "Novo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(936, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(860, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 27);
            this.button5.TabIndex = 13;
            this.button5.Text = "Gerar Relatório";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewtriviewturmaBindingSource, "tur_cd", true));
            this.textBox2.Location = new System.Drawing.Point(-114, -14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 21);
            this.textBox2.TabIndex = 14;
            // 
            // viewtriviewturmaBindingSource
            // 
            this.viewtriviewturmaBindingSource.DataMember = "View_triview_turma";
            this.viewtriviewturmaBindingSource.DataSource = this.GABARITEIDataSet;
            this.viewtriviewturmaBindingSource.CurrentChanged += new System.EventHandler(this.viewtriviewturmaBindingSource_CurrentChanged);
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
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataMember = "aluno";
            this.alunoBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_list_alun_dados
            // 
            this.dgv_list_alun_dados.AllowUserToAddRows = false;
            this.dgv_list_alun_dados.AllowUserToDeleteRows = false;
            this.dgv_list_alun_dados.AutoGenerateColumns = false;
            this.dgv_list_alun_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list_alun_dados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alucdDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.rGDataGridViewTextBoxColumn,
            this.uFDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.dataDeCadastroDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.nascimentoDataGridViewTextBoxColumn,
            this.respcdDataGridViewTextBoxColumn,
            this.nomeDoResponsávelDataGridViewTextBoxColumn,
            this.respCatDataGridViewTextBoxColumn,
            this.orgãoExpedidorDataGridViewTextBoxColumn,
            this.endlogDataGridViewTextBoxColumn,
            this.endcepDataGridViewTextBoxColumn,
            this.endbairroDataGridViewTextBoxColumn,
            this.endnumeroDataGridViewTextBoxColumn,
            this.endcomplementoDataGridViewTextBoxColumn});
            this.dgv_list_alun_dados.DataSource = this.viewlistaalunoBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_list_alun_dados.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_list_alun_dados.Location = new System.Drawing.Point(12, 38);
            this.dgv_list_alun_dados.Name = "dgv_list_alun_dados";
            this.dgv_list_alun_dados.ReadOnly = true;
            this.dgv_list_alun_dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list_alun_dados.Size = new System.Drawing.Size(1024, 367);
            this.dgv_list_alun_dados.TabIndex = 15;
            this.dgv_list_alun_dados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_list_alun_dados_CellContentDoubleClick);
            // 
            // viewlistaalunoBindingSource
            // 
            this.viewlistaalunoBindingSource.DataMember = "view_lista_aluno";
            this.viewlistaalunoBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // view_lista_alunoTableAdapter
            // 
            this.view_lista_alunoTableAdapter.ClearBeforeFill = true;
            // 
            // alucdDataGridViewTextBoxColumn
            // 
            this.alucdDataGridViewTextBoxColumn.DataPropertyName = "alu_cd";
            this.alucdDataGridViewTextBoxColumn.HeaderText = "Código Aluno";
            this.alucdDataGridViewTextBoxColumn.Name = "alucdDataGridViewTextBoxColumn";
            this.alucdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rGDataGridViewTextBoxColumn
            // 
            this.rGDataGridViewTextBoxColumn.DataPropertyName = "RG";
            this.rGDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rGDataGridViewTextBoxColumn.Name = "rGDataGridViewTextBoxColumn";
            this.rGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uFDataGridViewTextBoxColumn
            // 
            this.uFDataGridViewTextBoxColumn.DataPropertyName = "UF";
            this.uFDataGridViewTextBoxColumn.HeaderText = "UF";
            this.uFDataGridViewTextBoxColumn.Name = "uFDataGridViewTextBoxColumn";
            this.uFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDeCadastroDataGridViewTextBoxColumn
            // 
            this.dataDeCadastroDataGridViewTextBoxColumn.DataPropertyName = "Data de cadastro";
            this.dataDeCadastroDataGridViewTextBoxColumn.HeaderText = "Data de cadastro";
            this.dataDeCadastroDataGridViewTextBoxColumn.Name = "dataDeCadastroDataGridViewTextBoxColumn";
            this.dataDeCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nascimentoDataGridViewTextBoxColumn
            // 
            this.nascimentoDataGridViewTextBoxColumn.DataPropertyName = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.HeaderText = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.Name = "nascimentoDataGridViewTextBoxColumn";
            this.nascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // respcdDataGridViewTextBoxColumn
            // 
            this.respcdDataGridViewTextBoxColumn.DataPropertyName = "resp_cd";
            this.respcdDataGridViewTextBoxColumn.HeaderText = "Código Responsável";
            this.respcdDataGridViewTextBoxColumn.Name = "respcdDataGridViewTextBoxColumn";
            this.respcdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDoResponsávelDataGridViewTextBoxColumn
            // 
            this.nomeDoResponsávelDataGridViewTextBoxColumn.DataPropertyName = "Nome do responsável";
            this.nomeDoResponsávelDataGridViewTextBoxColumn.HeaderText = "Nome do responsável";
            this.nomeDoResponsávelDataGridViewTextBoxColumn.Name = "nomeDoResponsávelDataGridViewTextBoxColumn";
            this.nomeDoResponsávelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // respCatDataGridViewTextBoxColumn
            // 
            this.respCatDataGridViewTextBoxColumn.DataPropertyName = "Resp cat/";
            this.respCatDataGridViewTextBoxColumn.HeaderText = "Resp cat/";
            this.respCatDataGridViewTextBoxColumn.Name = "respCatDataGridViewTextBoxColumn";
            this.respCatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orgãoExpedidorDataGridViewTextBoxColumn
            // 
            this.orgãoExpedidorDataGridViewTextBoxColumn.DataPropertyName = "Orgão expedidor";
            this.orgãoExpedidorDataGridViewTextBoxColumn.HeaderText = "Orgão expedidor";
            this.orgãoExpedidorDataGridViewTextBoxColumn.Name = "orgãoExpedidorDataGridViewTextBoxColumn";
            this.orgãoExpedidorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endlogDataGridViewTextBoxColumn
            // 
            this.endlogDataGridViewTextBoxColumn.DataPropertyName = "end_log";
            this.endlogDataGridViewTextBoxColumn.HeaderText = "Logradouro";
            this.endlogDataGridViewTextBoxColumn.Name = "endlogDataGridViewTextBoxColumn";
            this.endlogDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endcepDataGridViewTextBoxColumn
            // 
            this.endcepDataGridViewTextBoxColumn.DataPropertyName = "end_cep";
            this.endcepDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.endcepDataGridViewTextBoxColumn.Name = "endcepDataGridViewTextBoxColumn";
            this.endcepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endbairroDataGridViewTextBoxColumn
            // 
            this.endbairroDataGridViewTextBoxColumn.DataPropertyName = "end_bairro";
            this.endbairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.endbairroDataGridViewTextBoxColumn.Name = "endbairroDataGridViewTextBoxColumn";
            this.endbairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endnumeroDataGridViewTextBoxColumn
            // 
            this.endnumeroDataGridViewTextBoxColumn.DataPropertyName = "end_numero";
            this.endnumeroDataGridViewTextBoxColumn.HeaderText = "Número";
            this.endnumeroDataGridViewTextBoxColumn.Name = "endnumeroDataGridViewTextBoxColumn";
            this.endnumeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endcomplementoDataGridViewTextBoxColumn
            // 
            this.endcomplementoDataGridViewTextBoxColumn.DataPropertyName = "end_complemento";
            this.endcomplementoDataGridViewTextBoxColumn.HeaderText = "Complemento";
            this.endcomplementoDataGridViewTextBoxColumn.Name = "endcomplementoDataGridViewTextBoxColumn";
            this.endcomplementoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_list_alun_dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 443);
            this.Controls.Add(this.dgv_list_alun_dados);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_list_alun_dados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Alunos";
            this.Load += new System.EventHandler(this.Lista_alunos_dados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewtriviewturmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewtriviewanoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_alun_dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewlistaalunoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private GABARITEIDataSet GABARITEIDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn alucadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alunacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alufilcdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alufpcdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource viewtriviewturmaBindingSource;
        private GABARITEIDataSetTableAdapters.View_triview_turmaTableAdapter view_triview_turmaTableAdapter;
        private System.Windows.Forms.BindingSource viewtriviewanoBindingSource;
        private GABARITEIDataSetTableAdapters.View_triview_anoTableAdapter view_triview_anoTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private GABARITEIDataSetTableAdapters.alunoTableAdapter alunoTableAdapter;
        private System.Windows.Forms.DataGridView dgv_list_alun_dados;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidnomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadecdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource viewlistaalunoBindingSource;
        private GABARITEIDataSetTableAdapters.view_lista_alunoTableAdapter view_lista_alunoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn alucdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn respcdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDoResponsávelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn respCatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgãoExpedidorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endlogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endcepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endbairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endnumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endcomplementoDataGridViewTextBoxColumn;
    }
}