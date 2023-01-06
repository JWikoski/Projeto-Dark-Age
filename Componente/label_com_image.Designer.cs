namespace Dark_Age.Componente
{
    partial class label_com_image
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.image_pers = new System.Windows.Forms.PictureBox();
            this.nome_perso = new System.Windows.Forms.Label();
            this.nome_classe = new System.Windows.Forms.Label();
            this.nome_user = new System.Windows.Forms.Label();
            this.Vida_jogador_s = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image_pers)).BeginInit();
            this.SuspendLayout();
            // 
            // image_pers
            // 
            this.image_pers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.image_pers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.image_pers.Image = global::Dark_Age.Properties.Resources.download;
            this.image_pers.InitialImage = global::Dark_Age.Properties.Resources.download;
            this.image_pers.Location = new System.Drawing.Point(0, 9);
            this.image_pers.Name = "image_pers";
            this.image_pers.Size = new System.Drawing.Size(132, 108);
            this.image_pers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_pers.TabIndex = 0;
            this.image_pers.TabStop = false;
            this.image_pers.Click += new System.EventHandler(this.image_pers_Click);
            // 
            // nome_perso
            // 
            this.nome_perso.AutoSize = true;
            this.nome_perso.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nome_perso.ForeColor = System.Drawing.SystemColors.Control;
            this.nome_perso.Location = new System.Drawing.Point(138, 12);
            this.nome_perso.Name = "nome_perso";
            this.nome_perso.Size = new System.Drawing.Size(79, 31);
            this.nome_perso.TabIndex = 1;
            this.nome_perso.Text = "Nome";
            // 
            // nome_classe
            // 
            this.nome_classe.AutoSize = true;
            this.nome_classe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nome_classe.ForeColor = System.Drawing.SystemColors.Control;
            this.nome_classe.Location = new System.Drawing.Point(138, 53);
            this.nome_classe.Name = "nome_classe";
            this.nome_classe.Size = new System.Drawing.Size(47, 19);
            this.nome_classe.TabIndex = 2;
            this.nome_classe.Text = "Classe";
            // 
            // nome_user
            // 
            this.nome_user.AutoSize = true;
            this.nome_user.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nome_user.ForeColor = System.Drawing.SystemColors.Control;
            this.nome_user.Location = new System.Drawing.Point(138, 82);
            this.nome_user.Name = "nome_user";
            this.nome_user.Size = new System.Drawing.Size(95, 19);
            this.nome_user.TabIndex = 3;
            this.nome_user.Text = "Nome usuario";
            // 
            // Vida_jogador_s
            // 
            this.Vida_jogador_s.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Vida_jogador_s.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.Vida_jogador_s.Location = new System.Drawing.Point(0, 104);
            this.Vida_jogador_s.Name = "Vida_jogador_s";
            this.Vida_jogador_s.Size = new System.Drawing.Size(132, 19);
            this.Vida_jogador_s.TabIndex = 18;
            this.Vida_jogador_s.Text = "Classe";
            this.Vida_jogador_s.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label_com_image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Vida_jogador_s);
            this.Controls.Add(this.image_pers);
            this.Controls.Add(this.nome_user);
            this.Controls.Add(this.nome_classe);
            this.Controls.Add(this.nome_perso);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "label_com_image";
            this.Size = new System.Drawing.Size(398, 123);
            ((System.ComponentModel.ISupportInitialize)(this.image_pers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image_pers;
        private System.Windows.Forms.Label nome_perso;
        private System.Windows.Forms.Label nome_classe;
        private System.Windows.Forms.Label nome_user;
        private FontAwesome.Sharp.IconButton Mana_jogador_s;
        private System.Windows.Forms.Label Vida_jogador_s;
    }
}
