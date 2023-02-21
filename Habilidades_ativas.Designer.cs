
namespace Dark_Age
{
    partial class Habilidades_ativas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Habilidades_ativas));
			this.pagina = new System.Windows.Forms.Label();
			this.LblFecharPassivas = new System.Windows.Forms.Label();
			this.lbl_anotacoes = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbl_descansos = new System.Windows.Forms.Label();
			this.lbl_regras = new System.Windows.Forms.Label();
			this.txt_ativas = new System.Windows.Forms.TextBox();
			this.Editar = new System.Windows.Forms.CheckBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.seta_direita = new FontAwesome.Sharp.IconButton();
			this.seta_esquerda = new FontAwesome.Sharp.IconButton();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pagina
			// 
			this.pagina.AutoSize = true;
			this.pagina.BackColor = System.Drawing.Color.Transparent;
			this.pagina.Font = new System.Drawing.Font("Segoe Script", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.pagina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
			this.pagina.Location = new System.Drawing.Point(289, 31);
			this.pagina.Name = "pagina";
			this.pagina.Size = new System.Drawing.Size(178, 50);
			this.pagina.TabIndex = 9;
			this.pagina.Text = "Anotações";
			this.pagina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.pagina.Click += new System.EventHandler(this.label1_Click);
			// 
			// LblFecharPassivas
			// 
			this.LblFecharPassivas.BackColor = System.Drawing.Color.Transparent;
			this.LblFecharPassivas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.LblFecharPassivas.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LblFecharPassivas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
			this.LblFecharPassivas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.LblFecharPassivas.Location = new System.Drawing.Point(639, 22);
			this.LblFecharPassivas.Name = "LblFecharPassivas";
			this.LblFecharPassivas.Size = new System.Drawing.Size(42, 40);
			this.LblFecharPassivas.TabIndex = 12;
			this.LblFecharPassivas.Text = "X";
			this.LblFecharPassivas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LblFecharPassivas.Click += new System.EventHandler(this.LblFecharLogin_Click);
			this.LblFecharPassivas.MouseLeave += new System.EventHandler(this.LblFecharPassivas_MouseLeave);
			this.LblFecharPassivas.MouseHover += new System.EventHandler(this.LblFecharPassivas_MouseHover);
			// 
			// lbl_anotacoes
			// 
			this.lbl_anotacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_anotacoes.AutoSize = true;
			this.lbl_anotacoes.BackColor = System.Drawing.Color.Transparent;
			this.lbl_anotacoes.Font = new System.Drawing.Font("Segoe Script", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_anotacoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
			this.lbl_anotacoes.Location = new System.Drawing.Point(3, 4);
			this.lbl_anotacoes.MaximumSize = new System.Drawing.Size(450, 0);
			this.lbl_anotacoes.Name = "lbl_anotacoes";
			this.lbl_anotacoes.Size = new System.Drawing.Size(0, 30);
			this.lbl_anotacoes.TabIndex = 11;
			this.lbl_anotacoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.lbl_descansos);
			this.panel1.Controls.Add(this.lbl_regras);
			this.panel1.Controls.Add(this.lbl_anotacoes);
			this.panel1.Controls.Add(this.txt_ativas);
			this.panel1.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
			this.panel1.Location = new System.Drawing.Point(99, 126);
			this.panel1.MaximumSize = new System.Drawing.Size(582, 556);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(582, 556);
			this.panel1.TabIndex = 13;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// lbl_descansos
			// 
			this.lbl_descansos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_descansos.BackColor = System.Drawing.Color.Transparent;
			this.lbl_descansos.Font = new System.Drawing.Font("Segoe Script", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_descansos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
			this.lbl_descansos.Location = new System.Drawing.Point(3, 0);
			this.lbl_descansos.MaximumSize = new System.Drawing.Size(450, 0);
			this.lbl_descansos.Name = "lbl_descansos";
			this.lbl_descansos.Size = new System.Drawing.Size(0, 0);
			this.lbl_descansos.TabIndex = 13;
			this.lbl_descansos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_regras
			// 
			this.lbl_regras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_regras.AutoSize = true;
			this.lbl_regras.BackColor = System.Drawing.Color.Transparent;
			this.lbl_regras.Font = new System.Drawing.Font("Segoe Script", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_regras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
			this.lbl_regras.Location = new System.Drawing.Point(3, 4);
			this.lbl_regras.MaximumSize = new System.Drawing.Size(450, 0);
			this.lbl_regras.Name = "lbl_regras";
			this.lbl_regras.Size = new System.Drawing.Size(0, 25);
			this.lbl_regras.TabIndex = 12;
			this.lbl_regras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_ativas
			// 
			this.txt_ativas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(229)))), ((int)(((byte)(171)))));
			this.txt_ativas.Enabled = false;
			this.txt_ativas.Font = new System.Drawing.Font("Segoe Script", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.txt_ativas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
			this.txt_ativas.Location = new System.Drawing.Point(0, -1);
			this.txt_ativas.Multiline = true;
			this.txt_ativas.Name = "txt_ativas";
			this.txt_ativas.Size = new System.Drawing.Size(582, 23);
			this.txt_ativas.TabIndex = 14;
			this.txt_ativas.Visible = false;
			this.txt_ativas.TextChanged += new System.EventHandler(this.txt_ativas_TextChanged);
			// 
			// Editar
			// 
			this.Editar.AutoSize = true;
			this.Editar.BackColor = System.Drawing.Color.Transparent;
			this.Editar.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Editar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
			this.Editar.Location = new System.Drawing.Point(102, 83);
			this.Editar.Name = "Editar";
			this.Editar.Size = new System.Drawing.Size(115, 37);
			this.Editar.TabIndex = 12;
			this.Editar.Text = "Escrever";
			this.Editar.UseVisualStyleBackColor = false;
			this.Editar.CheckedChanged += new System.EventHandler(this.Editar_CheckedChanged);
			// 
			// seta_direita
			// 
			this.seta_direita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.seta_direita.BackColor = System.Drawing.Color.Transparent;
			this.seta_direita.Cursor = System.Windows.Forms.Cursors.Hand;
			this.seta_direita.FlatAppearance.BorderSize = 0;
			this.seta_direita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.seta_direita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.seta_direita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.seta_direita.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.seta_direita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
			this.seta_direita.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
			this.seta_direita.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
			this.seta_direita.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.seta_direita.IconSize = 30;
			this.seta_direita.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.seta_direita.Location = new System.Drawing.Point(473, 31);
			this.seta_direita.Name = "seta_direita";
			this.seta_direita.Size = new System.Drawing.Size(45, 45);
			this.seta_direita.TabIndex = 158;
			this.seta_direita.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.seta_direita.UseVisualStyleBackColor = false;
			this.seta_direita.Click += new System.EventHandler(this.iconButton5_Click);
			// 
			// seta_esquerda
			// 
			this.seta_esquerda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.seta_esquerda.BackColor = System.Drawing.Color.Transparent;
			this.seta_esquerda.Cursor = System.Windows.Forms.Cursors.Hand;
			this.seta_esquerda.FlatAppearance.BorderSize = 0;
			this.seta_esquerda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.seta_esquerda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.seta_esquerda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.seta_esquerda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.seta_esquerda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
			this.seta_esquerda.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
			this.seta_esquerda.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
			this.seta_esquerda.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.seta_esquerda.IconSize = 30;
			this.seta_esquerda.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.seta_esquerda.Location = new System.Drawing.Point(238, 31);
			this.seta_esquerda.Name = "seta_esquerda";
			this.seta_esquerda.Size = new System.Drawing.Size(45, 45);
			this.seta_esquerda.TabIndex = 159;
			this.seta_esquerda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.seta_esquerda.UseVisualStyleBackColor = false;
			this.seta_esquerda.Visible = false;
			this.seta_esquerda.Click += new System.EventHandler(this.seta_esquerda_Click);
			// 
			// Habilidades_ativas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
			this.BackgroundImage = global::Dark_Age.Properties.Resources.Tz04p___Imgur;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 800);
			this.Controls.Add(this.seta_esquerda);
			this.Controls.Add(this.seta_direita);
			this.Controls.Add(this.Editar);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.LblFecharPassivas);
			this.Controls.Add(this.pagina);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Habilidades_ativas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Habilidades";
			this.Load += new System.EventHandler(this.Habilidades_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pagina;
        private System.Windows.Forms.Label LblFecharPassivas;
        private System.Windows.Forms.Label lbl_anotacoes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_ativas;
        private System.Windows.Forms.CheckBox Editar;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton seta_direita;
        private FontAwesome.Sharp.IconButton seta_esquerda;
        private System.Windows.Forms.Label lbl_regras;
        private System.Windows.Forms.Label lbl_descansos;
    }
}