﻿namespace Dark_Age.Componente
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
            ((System.ComponentModel.ISupportInitialize)(this.image_pers)).BeginInit();
            this.SuspendLayout();
            // 
            // image_pers
            // 
            this.image_pers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.image_pers.Image = global::Dark_Age.Properties.Resources.download;
            this.image_pers.InitialImage = global::Dark_Age.Properties.Resources.download;
            this.image_pers.Location = new System.Drawing.Point(0, 9);
            this.image_pers.Name = "image_pers";
            this.image_pers.Size = new System.Drawing.Size(132, 108);
            this.image_pers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_pers.TabIndex = 0;
            this.image_pers.TabStop = false;
            // 
            // nome_perso
            // 
            this.nome_perso.AutoSize = true;
            this.nome_perso.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nome_perso.ForeColor = System.Drawing.SystemColors.Control;
            this.nome_perso.Location = new System.Drawing.Point(138, 14);
            this.nome_perso.Name = "nome_perso";
            this.nome_perso.Size = new System.Drawing.Size(79, 31);
            this.nome_perso.TabIndex = 1;
            this.nome_perso.Text = "Nome";
            // 
            // nome_classe
            // 
            this.nome_classe.AutoSize = true;
            this.nome_classe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nome_classe.ForeColor = System.Drawing.SystemColors.Control;
            this.nome_classe.Location = new System.Drawing.Point(138, 59);
            this.nome_classe.Name = "nome_classe";
            this.nome_classe.Size = new System.Drawing.Size(50, 20);
            this.nome_classe.TabIndex = 2;
            this.nome_classe.Text = "Classe";
            // 
            // nome_user
            // 
            this.nome_user.AutoSize = true;
            this.nome_user.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nome_user.ForeColor = System.Drawing.SystemColors.Control;
            this.nome_user.Location = new System.Drawing.Point(138, 88);
            this.nome_user.Name = "nome_user";
            this.nome_user.Size = new System.Drawing.Size(102, 20);
            this.nome_user.TabIndex = 3;
            this.nome_user.Text = "Nome usuario";
            // 
            // label_com_image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.nome_user);
            this.Controls.Add(this.nome_classe);
            this.Controls.Add(this.nome_perso);
            this.Controls.Add(this.image_pers);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "label_com_image";
            this.Size = new System.Drawing.Size(398, 123);
            this.Load += new System.EventHandler(this.label_com_image_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image_pers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image_pers;
        private System.Windows.Forms.Label nome_perso;
        private System.Windows.Forms.Label nome_classe;
        private System.Windows.Forms.Label nome_user;
    }
}
