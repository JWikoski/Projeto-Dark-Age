
namespace Dark_Age
{
    partial class Anotacoes_regras_gerais
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anotacoes_regras_gerais));
            pagina = new System.Windows.Forms.Label();
            LblFecharPassivas = new System.Windows.Forms.Label();
            lbl_anotacoes = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            lbl_regras = new System.Windows.Forms.Label();
            lbl_descansos = new System.Windows.Forms.Label();
            txt_ativas = new System.Windows.Forms.TextBox();
            Editar = new System.Windows.Forms.CheckBox();
            timer1 = new System.Windows.Forms.Timer(components);
            seta_direita = new FontAwesome.Sharp.IconButton();
            seta_esquerda = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pagina
            // 
            pagina.AutoSize = true;
            pagina.BackColor = System.Drawing.Color.Transparent;
            pagina.Font = new System.Drawing.Font("Segoe Script", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            pagina.ForeColor = System.Drawing.Color.FromArgb(1, 1, 1);
            pagina.Location = new System.Drawing.Point(289, 31);
            pagina.Name = "pagina";
            pagina.Size = new System.Drawing.Size(178, 50);
            pagina.TabIndex = 9;
            pagina.Text = "Anotações";
            pagina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            pagina.Click += label1_Click;
            // 
            // LblFecharPassivas
            // 
            LblFecharPassivas.BackColor = System.Drawing.Color.Transparent;
            LblFecharPassivas.Cursor = System.Windows.Forms.Cursors.Hand;
            LblFecharPassivas.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LblFecharPassivas.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0, 40);
            LblFecharPassivas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            LblFecharPassivas.Location = new System.Drawing.Point(639, 22);
            LblFecharPassivas.Name = "LblFecharPassivas";
            LblFecharPassivas.Size = new System.Drawing.Size(42, 40);
            LblFecharPassivas.TabIndex = 12;
            LblFecharPassivas.Text = "X";
            LblFecharPassivas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            LblFecharPassivas.Click += LblFecharLogin_Click;
            LblFecharPassivas.MouseLeave += LblFecharPassivas_MouseLeave;
            LblFecharPassivas.MouseHover += LblFecharPassivas_MouseHover;
            // 
            // lbl_anotacoes
            // 
            lbl_anotacoes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbl_anotacoes.AutoSize = true;
            lbl_anotacoes.BackColor = System.Drawing.Color.Transparent;
            lbl_anotacoes.Font = new System.Drawing.Font("Segoe Script", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_anotacoes.ForeColor = System.Drawing.Color.FromArgb(1, 1, 1);
            lbl_anotacoes.Location = new System.Drawing.Point(10, 10);
            lbl_anotacoes.MaximumSize = new System.Drawing.Size(450, 0);
            lbl_anotacoes.Name = "lbl_anotacoes";
            lbl_anotacoes.Size = new System.Drawing.Size(0, 30);
            lbl_anotacoes.TabIndex = 11;
            lbl_anotacoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lbl_anotacoes.Visible = false;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.Controls.Add(lbl_regras);
            panel1.Controls.Add(lbl_anotacoes);
            panel1.Controls.Add(lbl_descansos);
            panel1.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            panel1.ForeColor = System.Drawing.Color.FromArgb(1, 1, 1);
            panel1.Location = new System.Drawing.Point(99, 126);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(582, 556);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // lbl_regras
            // 
            lbl_regras.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbl_regras.AutoSize = true;
            lbl_regras.BackColor = System.Drawing.Color.Transparent;
            lbl_regras.Font = new System.Drawing.Font("Segoe Script", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_regras.ForeColor = System.Drawing.Color.FromArgb(1, 1, 1);
            lbl_regras.Location = new System.Drawing.Point(10, 10);
            lbl_regras.MaximumSize = new System.Drawing.Size(450, 0);
            lbl_regras.Name = "lbl_regras";
            lbl_regras.Size = new System.Drawing.Size(0, 25);
            lbl_regras.TabIndex = 12;
            lbl_regras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lbl_regras.Visible = false;
            // 
            // lbl_descansos
            // 
            lbl_descansos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbl_descansos.AutoSize = true;
            lbl_descansos.BackColor = System.Drawing.Color.Transparent;
            lbl_descansos.Font = new System.Drawing.Font("Segoe Script", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_descansos.ForeColor = System.Drawing.Color.FromArgb(1, 1, 1);
            lbl_descansos.Location = new System.Drawing.Point(10, 10);
            lbl_descansos.MaximumSize = new System.Drawing.Size(450, 0);
            lbl_descansos.Name = "lbl_descansos";
            lbl_descansos.Size = new System.Drawing.Size(0, 30);
            lbl_descansos.TabIndex = 13;
            lbl_descansos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lbl_descansos.Visible = false;
            // 
            // txt_ativas
            // 
            txt_ativas.BackColor = System.Drawing.Color.FromArgb(243, 229, 171);
            txt_ativas.Enabled = false;
            txt_ativas.Font = new System.Drawing.Font("Segoe Script", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txt_ativas.ForeColor = System.Drawing.Color.FromArgb(1, 1, 1);
            txt_ativas.Location = new System.Drawing.Point(99, 126);
            txt_ativas.Multiline = true;
            txt_ativas.Name = "txt_ativas";
            txt_ativas.Size = new System.Drawing.Size(582, 23);
            txt_ativas.TabIndex = 14;
            txt_ativas.Visible = false;
            txt_ativas.TextChanged += txt_ativas_TextChanged;
            // 
            // Editar
            // 
            Editar.AutoSize = true;
            Editar.BackColor = System.Drawing.Color.Transparent;
            Editar.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Editar.ForeColor = System.Drawing.Color.FromArgb(1, 1, 1);
            Editar.Location = new System.Drawing.Point(102, 83);
            Editar.Name = "Editar";
            Editar.Size = new System.Drawing.Size(115, 37);
            Editar.TabIndex = 12;
            Editar.Text = "Escrever";
            Editar.UseVisualStyleBackColor = false;
            Editar.CheckedChanged += Editar_CheckedChanged;
            // 
            // seta_direita
            // 
            seta_direita.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            seta_direita.BackColor = System.Drawing.Color.Transparent;
            seta_direita.Cursor = System.Windows.Forms.Cursors.Hand;
            seta_direita.FlatAppearance.BorderSize = 0;
            seta_direita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            seta_direita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            seta_direita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            seta_direita.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            seta_direita.ForeColor = System.Drawing.Color.FromArgb(1, 1, 1);
            seta_direita.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            seta_direita.IconColor = System.Drawing.Color.FromArgb(1, 1, 1);
            seta_direita.IconFont = FontAwesome.Sharp.IconFont.Auto;
            seta_direita.IconSize = 30;
            seta_direita.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            seta_direita.Location = new System.Drawing.Point(473, 31);
            seta_direita.Name = "seta_direita";
            seta_direita.Size = new System.Drawing.Size(45, 45);
            seta_direita.TabIndex = 158;
            seta_direita.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            seta_direita.UseVisualStyleBackColor = false;
            seta_direita.Click += iconButton5_Click;
            // 
            // seta_esquerda
            // 
            seta_esquerda.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            seta_esquerda.BackColor = System.Drawing.Color.Transparent;
            seta_esquerda.Cursor = System.Windows.Forms.Cursors.Hand;
            seta_esquerda.FlatAppearance.BorderSize = 0;
            seta_esquerda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            seta_esquerda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            seta_esquerda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            seta_esquerda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            seta_esquerda.ForeColor = System.Drawing.Color.FromArgb(1, 1, 1);
            seta_esquerda.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            seta_esquerda.IconColor = System.Drawing.Color.FromArgb(1, 1, 1);
            seta_esquerda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            seta_esquerda.IconSize = 30;
            seta_esquerda.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            seta_esquerda.Location = new System.Drawing.Point(238, 31);
            seta_esquerda.Name = "seta_esquerda";
            seta_esquerda.Size = new System.Drawing.Size(45, 45);
            seta_esquerda.TabIndex = 159;
            seta_esquerda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            seta_esquerda.UseVisualStyleBackColor = false;
            seta_esquerda.Visible = false;
            seta_esquerda.Click += seta_esquerda_Click;
            // 
            // Anotacoes_regras_gerais
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(14, 40, 52);
            BackgroundImage = Properties.Resources.Tz04p___Imgur;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 800);
            Controls.Add(seta_esquerda);
            Controls.Add(seta_direita);
            Controls.Add(Editar);
            Controls.Add(txt_ativas);
            Controls.Add(panel1);
            Controls.Add(LblFecharPassivas);
            Controls.Add(pagina);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Anotacoes_regras_gerais";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Habilidades";
            Load += Habilidades_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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