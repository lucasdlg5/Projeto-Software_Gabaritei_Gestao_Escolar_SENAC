namespace gabaritei
{
    partial class frm_cadastro_responsavel
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
            this.label27 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.reponsavelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gABARITEIDataSet = new gabaritei.GABARITEIDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.reponsavelTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.reponsavelTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reponsavelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gABARITEIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(4, 11);
            this.label27.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(114, 26);
            this.label27.TabIndex = 72;
            this.label27.Text = "Código Resp.:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reponsavelBindingSource, "resp_cd", true));
            this.textBox5.Location = new System.Drawing.Point(121, 12);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(56, 26);
            this.textBox5.TabIndex = 71;
            // 
            // reponsavelBindingSource
            // 
            this.reponsavelBindingSource.DataMember = "reponsavel";
            this.reponsavelBindingSource.DataSource = this.gABARITEIDataSet;
            // 
            // gABARITEIDataSet
            // 
            this.gABARITEIDataSet.DataSetName = "GABARITEIDataSet";
            this.gABARITEIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 28);
            this.button2.TabIndex = 70;
            this.button2.Text = "Cadastrar Responsável";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reponsavelBindingSource, "resp_nm", true));
            this.textBox2.Location = new System.Drawing.Point(121, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(411, 26);
            this.textBox2.TabIndex = 68;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reponsavelBindingSource, "resp_cpf", true));
            this.maskedTextBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(235, 11);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.maskedTextBox1.Mask = "000000000/00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(130, 26);
            this.maskedTextBox1.TabIndex = 66;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(183, 11);
            this.label25.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(47, 26);
            this.label25.TabIndex = 64;
            this.label25.Text = "CPF:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-4, 43);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 26);
            this.label12.TabIndex = 65;
            this.label12.Text = "Responsável:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // reponsavelTableAdapter
            // 
            this.reponsavelTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 5;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 1;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 10;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frm_cadastro_responsavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 108);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label12);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_cadastro_responsavel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar responsável";
            this.Load += new System.EventHandler(this.frm_cadastro_responsavel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reponsavelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gABARITEIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label12;
        private GABARITEIDataSet gABARITEIDataSet;
        private System.Windows.Forms.BindingSource reponsavelBindingSource;
        private GABARITEIDataSetTableAdapters.reponsavelTableAdapter reponsavelTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}