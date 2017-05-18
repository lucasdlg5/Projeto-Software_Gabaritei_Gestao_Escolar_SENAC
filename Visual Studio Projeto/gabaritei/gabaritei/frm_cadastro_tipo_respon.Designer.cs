namespace gabaritei
{
    partial class frm_cadastro_tipo_respon
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
            this.tiporesponsavelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gABARITEIDataSet = new gabaritei.GABARITEIDataSet();
            this.label12 = new System.Windows.Forms.Label();
            this.tipo_responsavelTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.tipo_responsavelTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tiporesponsavelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gABARITEIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 58);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 32);
            this.button2.TabIndex = 77;
            this.button2.Text = "Cadastrar Tipo Responsável";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tiporesponsavelBindingSource, "tresp_nm", true));
            this.textBox2.Location = new System.Drawing.Point(63, 13);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 26);
            this.textBox2.TabIndex = 76;
            // 
            // tiporesponsavelBindingSource
            // 
            this.tiporesponsavelBindingSource.DataMember = "tipo_responsavel";
            this.tiporesponsavelBindingSource.DataSource = this.gABARITEIDataSet;
            // 
            // gABARITEIDataSet
            // 
            this.gABARITEIDataSet.DataSetName = "GABARITEIDataSet";
            this.gABARITEIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-118, 7);
            this.label12.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 36);
            this.label12.TabIndex = 74;
            this.label12.Text = "Tipo:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tipo_responsavelTableAdapter
            // 
            this.tipo_responsavelTableAdapter.ClearBeforeFill = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 5;
            this.toolTip1.AutoPopDelay = 50000;
            this.toolTip1.InitialDelay = 1;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 10;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_cadastro_tipo_respon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 100);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label12);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_cadastro_tipo_respon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar tipo Responsável";
            this.Load += new System.EventHandler(this.frm_cadastro_tipo_respon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiporesponsavelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gABARITEIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private GABARITEIDataSet gABARITEIDataSet;
        private System.Windows.Forms.BindingSource tiporesponsavelBindingSource;
        private GABARITEIDataSetTableAdapters.tipo_responsavelTableAdapter tipo_responsavelTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}