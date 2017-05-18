namespace gabaritei
{
    partial class frm_prof_lanc_presenc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_prof_lanc_presenc));
            this.cmb_prof_lanc_presenc = new System.Windows.Forms.ComboBox();
            this.rtb_prof_lanc_presenc = new System.Windows.Forms.RichTextBox();
            this.lbl__prof_lanc_presenc = new System.Windows.Forms.Label();
            this.tvw_prof_lanc_presenc = new System.Windows.Forms.TreeView();
            this.btn_prof_lanc_presenc = new System.Windows.Forms.Button();
            this.dgv_prof_lanc_presenc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gABARITEIDataSet = new gabaritei.GABARITEIDataSet();
            this.viewtriviewturmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_triview_turmaTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.View_triview_turmaTableAdapter();
            this.viewtriviewanoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_triview_anoTableAdapter = new gabaritei.GABARITEIDataSetTableAdapters.View_triview_anoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prof_lanc_presenc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gABARITEIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewtriviewturmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewtriviewanoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_prof_lanc_presenc
            // 
            this.cmb_prof_lanc_presenc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_prof_lanc_presenc.FormattingEnabled = true;
            this.cmb_prof_lanc_presenc.Items.AddRange(new object[] {
            "Turma 2013",
            "Turma 2014",
            "Turma 2015"});
            this.cmb_prof_lanc_presenc.Location = new System.Drawing.Point(76, 21);
            this.cmb_prof_lanc_presenc.Name = "cmb_prof_lanc_presenc";
            this.cmb_prof_lanc_presenc.Size = new System.Drawing.Size(121, 21);
            this.cmb_prof_lanc_presenc.TabIndex = 0;
            // 
            // rtb_prof_lanc_presenc
            // 
            this.rtb_prof_lanc_presenc.Location = new System.Drawing.Point(4, 62);
            this.rtb_prof_lanc_presenc.Name = "rtb_prof_lanc_presenc";
            this.rtb_prof_lanc_presenc.Size = new System.Drawing.Size(193, 438);
            this.rtb_prof_lanc_presenc.TabIndex = 2;
            this.rtb_prof_lanc_presenc.Text = "";
            // 
            // lbl__prof_lanc_presenc
            // 
            this.lbl__prof_lanc_presenc.AutoSize = true;
            this.lbl__prof_lanc_presenc.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__prof_lanc_presenc.Location = new System.Drawing.Point(4, 21);
            this.lbl__prof_lanc_presenc.Name = "lbl__prof_lanc_presenc";
            this.lbl__prof_lanc_presenc.Size = new System.Drawing.Size(78, 18);
            this.lbl__prof_lanc_presenc.TabIndex = 3;
            this.lbl__prof_lanc_presenc.Text = "Seleção: ";
            // 
            // tvw_prof_lanc_presenc
            // 
            this.tvw_prof_lanc_presenc.Location = new System.Drawing.Point(12, 101);
            this.tvw_prof_lanc_presenc.Name = "tvw_prof_lanc_presenc";
            this.tvw_prof_lanc_presenc.Size = new System.Drawing.Size(174, 387);
            this.tvw_prof_lanc_presenc.TabIndex = 4;
            this.tvw_prof_lanc_presenc.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
            // 
            // btn_prof_lanc_presenc
            // 
            this.btn_prof_lanc_presenc.Location = new System.Drawing.Point(13, 72);
            this.btn_prof_lanc_presenc.Name = "btn_prof_lanc_presenc";
            this.btn_prof_lanc_presenc.Size = new System.Drawing.Size(173, 23);
            this.btn_prof_lanc_presenc.TabIndex = 5;
            this.btn_prof_lanc_presenc.Text = "Adicionar Lista";
            this.btn_prof_lanc_presenc.UseVisualStyleBackColor = true;
            this.btn_prof_lanc_presenc.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_prof_lanc_presenc
            // 
            this.dgv_prof_lanc_presenc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_prof_lanc_presenc.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_prof_lanc_presenc.Location = new System.Drawing.Point(203, 62);
            this.dgv_prof_lanc_presenc.Name = "dgv_prof_lanc_presenc";
            this.dgv_prof_lanc_presenc.Size = new System.Drawing.Size(823, 438);
            this.dgv_prof_lanc_presenc.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pesquisar:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(297, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(421, 27);
            this.textBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(948, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(744, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 26);
            this.button2.TabIndex = 11;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(856, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 26);
            this.button3.TabIndex = 12;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gABARITEIDataSet
            // 
            this.gABARITEIDataSet.DataSetName = "GABARITEIDataSet";
            this.gABARITEIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewtriviewturmaBindingSource
            // 
            this.viewtriviewturmaBindingSource.DataMember = "View_triview_turma";
            this.viewtriviewturmaBindingSource.DataSource = this.gABARITEIDataSet;
            // 
            // view_triview_turmaTableAdapter
            // 
            this.view_triview_turmaTableAdapter.ClearBeforeFill = true;
            // 
            // viewtriviewanoBindingSource
            // 
            this.viewtriviewanoBindingSource.DataMember = "View_triview_ano";
            this.viewtriviewanoBindingSource.DataSource = this.gABARITEIDataSet;
            // 
            // view_triview_anoTableAdapter
            // 
            this.view_triview_anoTableAdapter.ClearBeforeFill = true;
            // 
            // frm_prof_lanc_presenc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 504);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_prof_lanc_presenc);
            this.Controls.Add(this.btn_prof_lanc_presenc);
            this.Controls.Add(this.tvw_prof_lanc_presenc);
            this.Controls.Add(this.cmb_prof_lanc_presenc);
            this.Controls.Add(this.lbl__prof_lanc_presenc);
            this.Controls.Add(this.rtb_prof_lanc_presenc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_prof_lanc_presenc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento de Presença";
            this.Load += new System.EventHandler(this.professores_lancamento_de_presenca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prof_lanc_presenc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gABARITEIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewtriviewturmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewtriviewanoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_prof_lanc_presenc;
        private System.Windows.Forms.RichTextBox rtb_prof_lanc_presenc;
        private System.Windows.Forms.Label lbl__prof_lanc_presenc;
        private System.Windows.Forms.TreeView tvw_prof_lanc_presenc;
        private System.Windows.Forms.Button btn_prof_lanc_presenc;
        private System.Windows.Forms.DataGridView dgv_prof_lanc_presenc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private GABARITEIDataSet gABARITEIDataSet;
        private System.Windows.Forms.BindingSource viewtriviewturmaBindingSource;
        private GABARITEIDataSetTableAdapters.View_triview_turmaTableAdapter view_triview_turmaTableAdapter;
        private System.Windows.Forms.BindingSource viewtriviewanoBindingSource;
        private GABARITEIDataSetTableAdapters.View_triview_anoTableAdapter view_triview_anoTableAdapter;







    }
}