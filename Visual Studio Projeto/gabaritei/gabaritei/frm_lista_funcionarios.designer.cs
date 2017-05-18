namespace gabaritei
{
    partial class frm_lista_funcionarios
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewlistafuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GABARITEIDataSet = new gabaritei.GABARITEIDataSet();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.funcionarioTableAdapter();
            this.view_lista_funcionarioTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.view_lista_funcionarioTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.funcdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargocdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDoCargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funnmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funrgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funsexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funtelefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fundtnascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadecdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewlistafuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(515, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.Location = new System.Drawing.Point(-12, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(64, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(446, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.funcdDataGridViewTextBoxColumn,
            this.cargocdDataGridViewTextBoxColumn,
            this.nomeDoCargoDataGridViewTextBoxColumn,
            this.funnmDataGridViewTextBoxColumn,
            this.funrgDataGridViewTextBoxColumn,
            this.funcpfDataGridViewTextBoxColumn,
            this.funsexoDataGridViewTextBoxColumn,
            this.funtelefoneDataGridViewTextBoxColumn,
            this.fundtnascimentoDataGridViewTextBoxColumn,
            this.cidadecdDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.cepDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewlistafuncionarioBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(956, 411);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // viewlistafuncionarioBindingSource
            // 
            this.viewlistafuncionarioBindingSource.DataMember = "view_lista_funcionario";
            this.viewlistafuncionarioBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // GABARITEIDataSet
            // 
            this.GABARITEIDataSet.DataSetName = "GABARITEIDataSet";
            this.GABARITEIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(583, 6);
            this.textBox2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(98, 26);
            this.textBox2.TabIndex = 34;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(689, 5);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 26);
            this.button4.TabIndex = 35;
            this.button4.Text = "Pesquisar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(765, 460);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 27);
            this.button5.TabIndex = 39;
            this.button5.Text = "Novo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(845, 460);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 27);
            this.button2.TabIndex = 40;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "funcionario";
            this.funcionarioBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // view_lista_funcionarioTableAdapter
            // 
            this.view_lista_funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(782, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 27);
            this.button1.TabIndex = 42;
            this.button1.Text = "Gerar Relatório";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // funcdDataGridViewTextBoxColumn
            // 
            this.funcdDataGridViewTextBoxColumn.DataPropertyName = "fun_cd";
            this.funcdDataGridViewTextBoxColumn.HeaderText = "Código Funcionário";
            this.funcdDataGridViewTextBoxColumn.Name = "funcdDataGridViewTextBoxColumn";
            this.funcdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargocdDataGridViewTextBoxColumn
            // 
            this.cargocdDataGridViewTextBoxColumn.DataPropertyName = "cargo_cd";
            this.cargocdDataGridViewTextBoxColumn.HeaderText = "Código Cargo";
            this.cargocdDataGridViewTextBoxColumn.Name = "cargocdDataGridViewTextBoxColumn";
            this.cargocdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDoCargoDataGridViewTextBoxColumn
            // 
            this.nomeDoCargoDataGridViewTextBoxColumn.DataPropertyName = "Nome do cargo";
            this.nomeDoCargoDataGridViewTextBoxColumn.HeaderText = "Nome do cargo";
            this.nomeDoCargoDataGridViewTextBoxColumn.Name = "nomeDoCargoDataGridViewTextBoxColumn";
            this.nomeDoCargoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funnmDataGridViewTextBoxColumn
            // 
            this.funnmDataGridViewTextBoxColumn.DataPropertyName = "fun_nm";
            this.funnmDataGridViewTextBoxColumn.HeaderText = "Nome Funcionário";
            this.funnmDataGridViewTextBoxColumn.Name = "funnmDataGridViewTextBoxColumn";
            this.funnmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funrgDataGridViewTextBoxColumn
            // 
            this.funrgDataGridViewTextBoxColumn.DataPropertyName = "fun_rg";
            this.funrgDataGridViewTextBoxColumn.HeaderText = "RG Funcionário";
            this.funrgDataGridViewTextBoxColumn.Name = "funrgDataGridViewTextBoxColumn";
            this.funrgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcpfDataGridViewTextBoxColumn
            // 
            this.funcpfDataGridViewTextBoxColumn.DataPropertyName = "fun_cpf";
            this.funcpfDataGridViewTextBoxColumn.HeaderText = "CPF Funcionário";
            this.funcpfDataGridViewTextBoxColumn.Name = "funcpfDataGridViewTextBoxColumn";
            this.funcpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funsexoDataGridViewTextBoxColumn
            // 
            this.funsexoDataGridViewTextBoxColumn.DataPropertyName = "fun_sexo";
            this.funsexoDataGridViewTextBoxColumn.HeaderText = "Sexo Funcionário";
            this.funsexoDataGridViewTextBoxColumn.Name = "funsexoDataGridViewTextBoxColumn";
            this.funsexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funtelefoneDataGridViewTextBoxColumn
            // 
            this.funtelefoneDataGridViewTextBoxColumn.DataPropertyName = "fun_telefone";
            this.funtelefoneDataGridViewTextBoxColumn.HeaderText = "Telefone Funcionário";
            this.funtelefoneDataGridViewTextBoxColumn.Name = "funtelefoneDataGridViewTextBoxColumn";
            this.funtelefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fundtnascimentoDataGridViewTextBoxColumn
            // 
            this.fundtnascimentoDataGridViewTextBoxColumn.DataPropertyName = "fun_dt_nascimento";
            this.fundtnascimentoDataGridViewTextBoxColumn.HeaderText = "Data de Nascimento Funcionário";
            this.fundtnascimentoDataGridViewTextBoxColumn.Name = "fundtnascimentoDataGridViewTextBoxColumn";
            this.fundtnascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadecdDataGridViewTextBoxColumn
            // 
            this.cidadecdDataGridViewTextBoxColumn.DataPropertyName = "cidade_cd";
            this.cidadecdDataGridViewTextBoxColumn.HeaderText = "Código Cidade";
            this.cidadecdDataGridViewTextBoxColumn.Name = "cidadecdDataGridViewTextBoxColumn";
            this.cidadecdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "complemento";
            this.dataGridViewTextBoxColumn1.HeaderText = "complemento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "cep";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            this.cepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_lista_funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Verdana", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_lista_funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista funcionarios";
            this.Load += new System.EventHandler(this.frm_pesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewlistafuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private GABARITEIDataSet GABARITEIDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeAdmissãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDaCasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDaCidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private GABARITEIDataSetTableAdapters.funcionarioTableAdapter funcionarioTableAdapter;
        private GABARITEIDataSetTableAdapters.view_lista_funcionarioTableAdapter view_lista_funcionarioTableAdapter;
        private System.Windows.Forms.BindingSource viewlistafuncionarioBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargocdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDoCargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funnmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funrgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funsexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funtelefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fundtnascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadecdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
    }
}