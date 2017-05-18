namespace gabaritei
{
    partial class frm_splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_splash));
            this.pgb_splash = new System.Windows.Forms.ProgressBar();
            this.lbl_splash_mensagem = new System.Windows.Forms.Label();
            this.tmr_splash_tempo = new System.Windows.Forms.Timer(this.components);
            this.btn_splash_fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pgb_splash
            // 
            this.pgb_splash.Location = new System.Drawing.Point(33, 449);
            this.pgb_splash.Name = "pgb_splash";
            this.pgb_splash.Size = new System.Drawing.Size(467, 18);
            this.pgb_splash.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pgb_splash.TabIndex = 0;
            // 
            // lbl_splash_mensagem
            // 
            this.lbl_splash_mensagem.AutoSize = true;
            this.lbl_splash_mensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(140)))), ((int)(((byte)(40)))));
            this.lbl_splash_mensagem.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lbl_splash_mensagem.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_splash_mensagem.Location = new System.Drawing.Point(237, 470);
            this.lbl_splash_mensagem.Name = "lbl_splash_mensagem";
            this.lbl_splash_mensagem.Size = new System.Drawing.Size(247, 25);
            this.lbl_splash_mensagem.TabIndex = 1;
            this.lbl_splash_mensagem.Text = "Carregando Tabelas...";
            this.lbl_splash_mensagem.Click += new System.EventHandler(this.lbl_carregamento_Click);
            // 
            // tmr_splash_tempo
            // 
            this.tmr_splash_tempo.Enabled = true;
            this.tmr_splash_tempo.Interval = 5000;
            this.tmr_splash_tempo.Tick += new System.EventHandler(this.tmr_tempo_Tick);
            // 
            // btn_splash_fechar
            // 
            this.btn_splash_fechar.Location = new System.Drawing.Point(485, 16);
            this.btn_splash_fechar.Name = "btn_splash_fechar";
            this.btn_splash_fechar.Size = new System.Drawing.Size(28, 23);
            this.btn_splash_fechar.TabIndex = 2;
            this.btn_splash_fechar.Text = "X";
            this.btn_splash_fechar.UseVisualStyleBackColor = true;
            this.btn_splash_fechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::gabaritei.Properties.Resources.gabarite_vetor_05_saida_05;
            this.ClientSize = new System.Drawing.Size(529, 508);
            this.ControlBox = false;
            this.Controls.Add(this.btn_splash_fechar);
            this.Controls.Add(this.lbl_splash_mensagem);
            this.Controls.Add(this.pgb_splash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_splash";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.Splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgb_splash;
        private System.Windows.Forms.Label lbl_splash_mensagem;
        private System.Windows.Forms.Timer tmr_splash_tempo;
        private System.Windows.Forms.Button btn_splash_fechar;

    }
}