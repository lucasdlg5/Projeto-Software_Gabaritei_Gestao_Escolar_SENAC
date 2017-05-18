namespace gabaritei
{
    partial class testeloguin
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GABARITEIDataSet = new gabaritei.GABARITEIDataSet();
            this.loginnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginnTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.loginnTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.alunoTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.alunoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginnBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataMember = "aluno";
            this.alunoBindingSource.DataSource = this.GABARITEIDataSet;
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.alunoBindingSource;
            reportDataSource2.Name = "aluno";
            reportDataSource2.Value = this.alunoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "gabaritei.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(521, 590);
            this.reportViewer1.TabIndex = 1;
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // testeloguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 590);
            this.Controls.Add(this.reportViewer1);
            this.Name = "testeloguin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.testeloguin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GABARITEIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginnBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GABARITEIDataSet GABARITEIDataSet;
        private System.Windows.Forms.BindingSource loginnBindingSource;
        private GABARITEIDataSetTableAdapters.loginnTableAdapter loginnTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private GABARITEIDataSetTableAdapters.alunoTableAdapter alunoTableAdapter;
    }
}