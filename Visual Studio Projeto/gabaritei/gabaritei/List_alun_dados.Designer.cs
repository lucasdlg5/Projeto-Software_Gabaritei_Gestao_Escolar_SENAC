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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_list_alun_dados));
            this.rtxb_list_alun_dados = new System.Windows.Forms.RichTextBox();
            this.cmb_list_alun_dados_turmas = new System.Windows.Forms.ComboBox();
            this.lbl_list_alun_dados_selecao = new System.Windows.Forms.Label();
            this.tvw_list_alun_dados = new System.Windows.Forms.TreeView();
            this.btn_list_alun_dados = new System.Windows.Forms.Button();
            this.dgv_list_alun_dados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_alun_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxb_list_alun_dados
            // 
            this.rtxb_list_alun_dados.Location = new System.Drawing.Point(5, 35);
            this.rtxb_list_alun_dados.Name = "rtxb_list_alun_dados";
            this.rtxb_list_alun_dados.Size = new System.Drawing.Size(155, 457);
            this.rtxb_list_alun_dados.TabIndex = 0;
            this.rtxb_list_alun_dados.Text = "";
            // 
            // cmb_list_alun_dados_turmas
            // 
            this.cmb_list_alun_dados_turmas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_list_alun_dados_turmas.FormattingEnabled = true;
            this.cmb_list_alun_dados_turmas.Items.AddRange(new object[] {
            "Turma 2013",
            "Turma 2014",
            "Turma 2015"});
            this.cmb_list_alun_dados_turmas.Location = new System.Drawing.Point(82, 10);
            this.cmb_list_alun_dados_turmas.Name = "cmb_list_alun_dados_turmas";
            this.cmb_list_alun_dados_turmas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_list_alun_dados_turmas.Size = new System.Drawing.Size(80, 21);
            this.cmb_list_alun_dados_turmas.TabIndex = 1;
            this.cmb_list_alun_dados_turmas.Visible = false;
            this.cmb_list_alun_dados_turmas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_list_alun_dados_selecao
            // 
            this.lbl_list_alun_dados_selecao.AutoSize = true;
            this.lbl_list_alun_dados_selecao.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_list_alun_dados_selecao.Location = new System.Drawing.Point(10, 10);
            this.lbl_list_alun_dados_selecao.Name = "lbl_list_alun_dados_selecao";
            this.lbl_list_alun_dados_selecao.Size = new System.Drawing.Size(66, 18);
            this.lbl_list_alun_dados_selecao.TabIndex = 2;
            this.lbl_list_alun_dados_selecao.Text = "Seleção";
            this.lbl_list_alun_dados_selecao.Click += new System.EventHandler(this.label1_Click);
            // 
            // tvw_list_alun_dados
            // 
            this.tvw_list_alun_dados.Location = new System.Drawing.Point(5, 70);
            this.tvw_list_alun_dados.Name = "tvw_list_alun_dados";
            this.tvw_list_alun_dados.Size = new System.Drawing.Size(150, 413);
            this.tvw_list_alun_dados.TabIndex = 3;
            // 
            // btn_list_alun_dados
            // 
            this.btn_list_alun_dados.Location = new System.Drawing.Point(10, 40);
            this.btn_list_alun_dados.Name = "btn_list_alun_dados";
            this.btn_list_alun_dados.Size = new System.Drawing.Size(140, 23);
            this.btn_list_alun_dados.TabIndex = 4;
            this.btn_list_alun_dados.Text = "Adicionar Lista";
            this.btn_list_alun_dados.UseVisualStyleBackColor = true;
            // 
            // dgv_list_alun_dados
            // 
            this.dgv_list_alun_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list_alun_dados.Location = new System.Drawing.Point(170, 35);
            this.dgv_list_alun_dados.Name = "dgv_list_alun_dados";
            this.dgv_list_alun_dados.Size = new System.Drawing.Size(830, 457);
            this.dgv_list_alun_dados.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pesquisar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(496, 20);
            this.textBox1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(763, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(844, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(925, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Novo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frm_list_alun_dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 500);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_list_alun_dados);
            this.Controls.Add(this.btn_list_alun_dados);
            this.Controls.Add(this.tvw_list_alun_dados);
            this.Controls.Add(this.lbl_list_alun_dados_selecao);
            this.Controls.Add(this.cmb_list_alun_dados_turmas);
            this.Controls.Add(this.rtxb_list_alun_dados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_list_alun_dados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Alunos";
            this.Load += new System.EventHandler(this.Lista_alunos_dados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_alun_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxb_list_alun_dados;
        private System.Windows.Forms.ComboBox cmb_list_alun_dados_turmas;
        private System.Windows.Forms.Label lbl_list_alun_dados_selecao;
        private System.Windows.Forms.TreeView tvw_list_alun_dados;
        private System.Windows.Forms.Button btn_list_alun_dados;
        private System.Windows.Forms.DataGridView dgv_list_alun_dados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}