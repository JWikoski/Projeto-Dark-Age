
namespace Dark_Age
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Lbl_senha = new System.Windows.Forms.Label();
            this.TbSenha = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ShowPass = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LblFecharLogin = new System.Windows.Forms.Label();
            this.LblSenhaInvalida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_senha
            // 
            this.Lbl_senha.AutoSize = true;
            this.Lbl_senha.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_senha.ForeColor = System.Drawing.Color.Silver;
            this.Lbl_senha.Location = new System.Drawing.Point(161, 190);
            this.Lbl_senha.Name = "Lbl_senha";
            this.Lbl_senha.Size = new System.Drawing.Size(106, 45);
            this.Lbl_senha.TabIndex = 2;
            this.Lbl_senha.Text = "Senha";
            // 
            // TbSenha
            // 
            this.TbSenha.AcceptsReturn = true;
            this.TbSenha.BackColor = System.Drawing.Color.Silver;
            this.TbSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbSenha.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.TbSenha.Location = new System.Drawing.Point(167, 255);
            this.TbSenha.Name = "TbSenha";
            this.TbSenha.ShortcutsEnabled = false;
            this.TbSenha.Size = new System.Drawing.Size(271, 29);
            this.TbSenha.TabIndex = 3;
            this.TbSenha.UseSystemPasswordChar = true;
            this.TbSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSenha_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(167, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 3);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Dark_Age.Properties.Resources.esquerda_festival;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel8_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dark_Age.Properties.Resources.direita_festival;
            this.pictureBox2.Location = new System.Drawing.Point(486, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 366);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.WaitOnLoad = true;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel8_MouseDown);
            // 
            // ShowPass
            // 
            this.ShowPass.AutoSize = true;
            this.ShowPass.ForeColor = System.Drawing.Color.Silver;
            this.ShowPass.Location = new System.Drawing.Point(166, 313);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(101, 19);
            this.ShowPass.TabIndex = 7;
            this.ShowPass.Text = "Mostrar senha";
            this.ShowPass.UseVisualStyleBackColor = true;
            this.ShowPass.CheckedChanged += new System.EventHandler(this.ShowPass_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::Dark_Age.Properties.Resources.giphy1;
            this.pictureBox3.Location = new System.Drawing.Point(141, -6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(349, 182);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel8_MouseDown);
            // 
            // LblFecharLogin
            // 
            this.LblFecharLogin.BackColor = System.Drawing.Color.Transparent;
            this.LblFecharLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblFecharLogin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFecharLogin.ForeColor = System.Drawing.Color.White;
            this.LblFecharLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblFecharLogin.Location = new System.Drawing.Point(578, 3);
            this.LblFecharLogin.Name = "LblFecharLogin";
            this.LblFecharLogin.Size = new System.Drawing.Size(42, 40);
            this.LblFecharLogin.TabIndex = 1;
            this.LblFecharLogin.Text = "X";
            this.LblFecharLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblFecharLogin.Click += new System.EventHandler(this.LblFecharLogin_Click);
            this.LblFecharLogin.MouseLeave += new System.EventHandler(this.LblFecharLogin_MouseLeave);
            this.LblFecharLogin.MouseHover += new System.EventHandler(this.LblFecharLogin_MouseHover);
            // 
            // LblSenhaInvalida
            // 
            this.LblSenhaInvalida.AutoSize = true;
            this.LblSenhaInvalida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblSenhaInvalida.Location = new System.Drawing.Point(298, 331);
            this.LblSenhaInvalida.Name = "LblSenhaInvalida";
            this.LblSenhaInvalida.Size = new System.Drawing.Size(182, 15);
            this.LblSenhaInvalida.TabIndex = 9;
            this.LblSenhaInvalida.Text = "Senha Inválida, tente novamente.";
            this.LblSenhaInvalida.Visible = false;
            // 
            // Login
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(623, 357);
            this.Controls.Add(this.LblSenhaInvalida);
            this.Controls.Add(this.LblFecharLogin);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TbSenha);
            this.Controls.Add(this.Lbl_senha);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel8_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_senha;
        private System.Windows.Forms.TextBox TbSenha;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox ShowPass;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label LblFecharLogin;
        private System.Windows.Forms.Label LblSenhaInvalida;
    }
}