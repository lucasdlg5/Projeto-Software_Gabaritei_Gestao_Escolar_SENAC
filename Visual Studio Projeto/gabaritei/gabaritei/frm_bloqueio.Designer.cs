namespace gabaritei
{
    partial class frm_bloqueio
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
            this.btn_bloquear_bloqueio = new System.Windows.Forms.Button();
            this.btn_cancelar_bloqueio = new System.Windows.Forms.Button();
            this.lbl_bloqueio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_bloquear_bloqueio
            // 
            this.btn_bloquear_bloqueio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_bloquear_bloqueio.Location = new System.Drawing.Point(64, 72);
            this.btn_bloquear_bloqueio.Margin = new System.Windows.Forms.Padding(4);
            this.btn_bloquear_bloqueio.Name = "btn_bloquear_bloqueio";
            this.btn_bloquear_bloqueio.Size = new System.Drawing.Size(112, 32);
            this.btn_bloquear_bloqueio.TabIndex = 0;
            this.btn_bloquear_bloqueio.Text = "Bloquear!";
            this.btn_bloquear_bloqueio.UseVisualStyleBackColor = false;
            this.btn_bloquear_bloqueio.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cancelar_bloqueio
            // 
            this.btn_cancelar_bloqueio.Location = new System.Drawing.Point(233, 72);
            this.btn_cancelar_bloqueio.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar_bloqueio.Name = "btn_cancelar_bloqueio";
            this.btn_cancelar_bloqueio.Size = new System.Drawing.Size(112, 32);
            this.btn_cancelar_bloqueio.TabIndex = 1;
            this.btn_cancelar_bloqueio.Text = "Cancelar";
            this.btn_cancelar_bloqueio.UseVisualStyleBackColor = true;
            this.btn_cancelar_bloqueio.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_bloqueio
            // 
            this.lbl_bloqueio.AutoSize = true;
            this.lbl_bloqueio.BackColor = System.Drawing.Color.LawnGreen;
            this.lbl_bloqueio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_bloqueio.Location = new System.Drawing.Point(40, 12);
            this.lbl_bloqueio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bloqueio.Name = "lbl_bloqueio";
            this.lbl_bloqueio.Size = new System.Drawing.Size(335, 18);
            this.lbl_bloqueio.TabIndex = 2;
            this.lbl_bloqueio.Text = "Você deseja bloquear o computador?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LawnGreen;
            this.pictureBox1.Image = global::gabaritei.Properties.Resources.gabarite_vetor_branco_08;
            this.pictureBox1.Location = new System.Drawing.Point(-9, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 136);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LawnGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(7, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 155);
            this.panel1.TabIndex = 6;
            // 
            // frm_bloqueio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(402, 165);
            this.Controls.Add(this.lbl_bloqueio);
            this.Controls.Add(this.btn_cancelar_bloqueio);
            this.Controls.Add(this.btn_bloquear_bloqueio);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_bloqueio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloqueio";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bloquear_bloqueio;
        private System.Windows.Forms.Button btn_cancelar_bloqueio;
        private System.Windows.Forms.Label lbl_bloqueio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}