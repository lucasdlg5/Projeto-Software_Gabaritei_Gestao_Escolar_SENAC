namespace gabaritei
{
    partial class Testelogin1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GABARITEIDataSet = new gabaritei.GABARITEIDataSet();
            this.loginnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginnTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.loginnTableAdapter();
            this.loginnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadloginnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadsenhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situaçaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipousuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginnBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginnDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cadloginnDataGridViewTextBoxColumn,
            this.cadsenhaDataGridViewTextBoxColumn,
            this.situaçaoDataGridViewTextBoxColumn,
            this.tipousuarioDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loginnBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // GABARITEIDataSet
            // 
            this.GABARITEIDataSet.DataSetName = "GABARITEIDataSet";
            this.GABARITEIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginnBindingSource
            // 
            this.loginnBindingSource.DataMember = "loginn";
            this.loginnBindingSource.DataSource = this.GABARITEIDataSet;
            // 
            // loginnTableAdapter
            // 
            this.loginnTableAdapter.ClearBeforeFill = true;
            // 
            // loginnDataGridViewTextBoxColumn
            // 
            this.loginnDataGridViewTextBoxColumn.DataPropertyName = "loginn";
            this.loginnDataGridViewTextBoxColumn.HeaderText = "loginn";
            this.loginnDataGridViewTextBoxColumn.Name = "loginnDataGridViewTextBoxColumn";
            this.loginnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // cadloginnDataGridViewTextBoxColumn
            // 
            this.cadloginnDataGridViewTextBoxColumn.DataPropertyName = "cadloginn";
            this.cadloginnDataGridViewTextBoxColumn.HeaderText = "cadloginn";
            this.cadloginnDataGridViewTextBoxColumn.Name = "cadloginnDataGridViewTextBoxColumn";
            // 
            // cadsenhaDataGridViewTextBoxColumn
            // 
            this.cadsenhaDataGridViewTextBoxColumn.DataPropertyName = "cadsenha";
            this.cadsenhaDataGridViewTextBoxColumn.HeaderText = "cadsenha";
            this.cadsenhaDataGridViewTextBoxColumn.Name = "cadsenhaDataGridViewTextBoxColumn";
            // 
            // situaçaoDataGridViewTextBoxColumn
            // 
            this.situaçaoDataGridViewTextBoxColumn.DataPropertyName = "situaçao";
            this.situaçaoDataGridViewTextBoxColumn.HeaderText = "situaçao";
            this.situaçaoDataGridViewTextBoxColumn.Name = "situaçaoDataGridViewTextBoxColumn";
            // 
            // tipousuarioDataGridViewTextBoxColumn
            // 
            this.tipousuarioDataGridViewTextBoxColumn.DataPropertyName = "tipo_usuario";
            this.tipousuarioDataGridViewTextBoxColumn.HeaderText = "tipo_usuario";
            this.tipousuarioDataGridViewTextBoxColumn.Name = "tipousuarioDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // Testelogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 330);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Testelogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testelogin";
            this.Load += new System.EventHandler(this.Testelogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginnBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GABARITEIDataSet GABARITEIDataSet;
        private System.Windows.Forms.BindingSource loginnBindingSource;
        private GABARITEIDataSetTableAdapters.loginnTableAdapter loginnTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadloginnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadsenhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situaçaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipousuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}