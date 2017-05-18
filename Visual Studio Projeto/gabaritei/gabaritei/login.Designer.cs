namespace gabaritei
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.txb_login_usuario = new System.Windows.Forms.TextBox();
            this.txb_login_senha = new System.Windows.Forms.TextBox();
            this.btn_login_cancelar = new System.Windows.Forms.Button();
            this.btn_login_entrar = new System.Windows.Forms.Button();
            this.lbl_login_usuario = new System.Windows.Forms.Label();
            this.lbl_login_senha = new System.Windows.Forms.Label();
            this.pcb_login = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_login)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_login_usuario
            // 
            this.txb_login_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txb_login_usuario.Location = new System.Drawing.Point(218, 64);
            this.txb_login_usuario.Name = "txb_login_usuario";
            this.txb_login_usuario.Size = new System.Drawing.Size(184, 20);
            this.txb_login_usuario.TabIndex = 0;
            this.txb_login_usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txb_login_senha
            // 
            this.txb_login_senha.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txb_login_senha.Location = new System.Drawing.Point(218, 131);
            this.txb_login_senha.Name = "txb_login_senha";
            this.txb_login_senha.PasswordChar = '*';
            this.txb_login_senha.Size = new System.Drawing.Size(184, 20);
            this.txb_login_senha.TabIndex = 1;
            // 
            // btn_login_cancelar
            // 
            this.btn_login_cancelar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_cancelar.Location = new System.Drawing.Point(312, 182);
            this.btn_login_cancelar.Name = "btn_login_cancelar";
            this.btn_login_cancelar.Size = new System.Drawing.Size(93, 26);
            this.btn_login_cancelar.TabIndex = 3;
            this.btn_login_cancelar.Text = "Cancelar";
            this.btn_login_cancelar.UseVisualStyleBackColor = true;
            this.btn_login_cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_login_entrar
            // 
            this.btn_login_entrar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_entrar.Location = new System.Drawing.Point(205, 182);
            this.btn_login_entrar.Name = "btn_login_entrar";
            this.btn_login_entrar.Size = new System.Drawing.Size(93, 26);
            this.btn_login_entrar.TabIndex = 2;
            this.btn_login_entrar.Text = "Entrar";
            this.btn_login_entrar.UseVisualStyleBackColor = true;
            this.btn_login_entrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_login_usuario
            // 
            this.lbl_login_usuario.AutoSize = true;
            this.lbl_login_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(188)))), ((int)(((byte)(49)))));
            this.lbl_login_usuario.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_usuario.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_login_usuario.Location = new System.Drawing.Point(256, 36);
            this.lbl_login_usuario.Name = "lbl_login_usuario";
            this.lbl_login_usuario.Size = new System.Drawing.Size(101, 25);
            this.lbl_login_usuario.TabIndex = 5;
            this.lbl_login_usuario.Text = "Usuário";
            // 
            // lbl_login_senha
            // 
            this.lbl_login_senha.AutoSize = true;
            this.lbl_login_senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(188)))), ((int)(((byte)(49)))));
            this.lbl_login_senha.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_senha.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_login_senha.Location = new System.Drawing.Point(263, 103);
            this.lbl_login_senha.Name = "lbl_login_senha";
            this.lbl_login_senha.Size = new System.Drawing.Size(85, 25);
            this.lbl_login_senha.TabIndex = 4;
            this.lbl_login_senha.Text = "Senha";
            // 
            // pcb_login
            // 
            this.pcb_login.Image = global::gabaritei.Properties.Resources.gabarite_vetor_login_07;
            this.pcb_login.Location = new System.Drawing.Point(0, 0);
            this.pcb_login.Name = "pcb_login";
            this.pcb_login.Size = new System.Drawing.Size(424, 262);
            this.pcb_login.TabIndex = 0;
            this.pcb_login.TabStop = false;
            this.pcb_login.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(428, 269);
            this.Controls.Add(this.lbl_login_senha);
            this.Controls.Add(this.lbl_login_usuario);
            this.Controls.Add(this.btn_login_entrar);
            this.Controls.Add(this.btn_login_cancelar);
            this.Controls.Add(this.txb_login_senha);
            this.Controls.Add(this.txb_login_usuario);
            this.Controls.Add(this.pcb_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_login;
        private System.Windows.Forms.TextBox txb_login_usuario;
        private System.Windows.Forms.TextBox txb_login_senha;
        private System.Windows.Forms.Button btn_login_cancelar;
        private System.Windows.Forms.Button btn_login_entrar;
        private System.Windows.Forms.Label lbl_login_usuario;
        private System.Windows.Forms.Label lbl_login_senha;



    }
}