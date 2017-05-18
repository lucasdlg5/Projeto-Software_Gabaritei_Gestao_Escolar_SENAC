namespace gabaritei
{
    partial class frm_curso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_curso));
            this.dgv_curso = new System.Windows.Forms.DataGridView();
            this.txb_curso = new System.Windows.Forms.TextBox();
            this.btn_codigo_curso = new System.Windows.Forms.Button();
            this.btn_alterar_curso = new System.Windows.Forms.Button();
            this.lbl_curso = new System.Windows.Forms.Label();
            this.btn_cancelar_curso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_curso)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_curso
            // 
            this.dgv_curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_curso.Location = new System.Drawing.Point(12, 51);
            this.dgv_curso.Name = "dgv_curso";
            this.dgv_curso.Size = new System.Drawing.Size(697, 390);
            this.dgv_curso.TabIndex = 0;
            // 
            // txb_curso
            // 
            this.txb_curso.Location = new System.Drawing.Point(69, 13);
            this.txb_curso.Name = "txb_curso";
            this.txb_curso.Size = new System.Drawing.Size(402, 20);
            this.txb_curso.TabIndex = 2;
            // 
            // btn_codigo_curso
            // 
            this.btn_codigo_curso.Location = new System.Drawing.Point(477, 11);
            this.btn_codigo_curso.Name = "btn_codigo_curso";
            this.btn_codigo_curso.Size = new System.Drawing.Size(75, 23);
            this.btn_codigo_curso.TabIndex = 3;
            this.btn_codigo_curso.Text = "Codigo";
            this.btn_codigo_curso.UseVisualStyleBackColor = true;
            // 
            // btn_alterar_curso
            // 
            this.btn_alterar_curso.Location = new System.Drawing.Point(558, 11);
            this.btn_alterar_curso.Name = "btn_alterar_curso";
            this.btn_alterar_curso.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar_curso.TabIndex = 4;
            this.btn_alterar_curso.Text = "Alterar";
            this.btn_alterar_curso.UseVisualStyleBackColor = true;
            this.btn_alterar_curso.Click += new System.EventHandler(this.btn_alterar_curso_Click);
            // 
            // lbl_curso
            // 
            this.lbl_curso.AutoSize = true;
            this.lbl_curso.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_curso.Location = new System.Drawing.Point(6, 16);
            this.lbl_curso.Name = "lbl_curso";
            this.lbl_curso.Size = new System.Drawing.Size(62, 13);
            this.lbl_curso.TabIndex = 5;
            this.lbl_curso.Text = "Pesquisar";
            // 
            // btn_cancelar_curso
            // 
            this.btn_cancelar_curso.Location = new System.Drawing.Point(639, 11);
            this.btn_cancelar_curso.Name = "btn_cancelar_curso";
            this.btn_cancelar_curso.Size = new System.Drawing.Size(70, 24);
            this.btn_cancelar_curso.TabIndex = 6;
            this.btn_cancelar_curso.Text = "Cancelar";
            this.btn_cancelar_curso.UseVisualStyleBackColor = true;
            this.btn_cancelar_curso.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 444);
            this.Controls.Add(this.btn_cancelar_curso);
            this.Controls.Add(this.lbl_curso);
            this.Controls.Add(this.btn_alterar_curso);
            this.Controls.Add(this.btn_codigo_curso);
            this.Controls.Add(this.txb_curso);
            this.Controls.Add(this.dgv_curso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_curso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curso";
            this.Load += new System.EventHandler(this.frm_curso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_curso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_curso;
        private System.Windows.Forms.TextBox txb_curso;
        private System.Windows.Forms.Button btn_codigo_curso;
        private System.Windows.Forms.Button btn_alterar_curso;
        private System.Windows.Forms.Label lbl_curso;
        private System.Windows.Forms.Button btn_cancelar_curso;
    }
}