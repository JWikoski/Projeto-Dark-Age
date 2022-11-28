
namespace Dark_Age.Componente
{
    partial class Painel_NPC
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
            this.lbl_nome_perso = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btn_aumenta_vida = new FontAwesome.Sharp.IconButton();
            this.txt_vida = new System.Windows.Forms.TextBox();
            this.btn_diminui_vida = new FontAwesome.Sharp.IconButton();
            this.lbl_dado_ataque = new System.Windows.Forms.Label();
            this.lbl_forca = new System.Windows.Forms.Label();
            this.lbl_dest = new System.Windows.Forms.Label();
            this.lbl_raci = new System.Windows.Forms.Label();
            this.lbl_caris = new System.Windows.Forms.Label();
            this.lbl_magia = new System.Windows.Forms.Label();
            this.btn_diminui_mana = new FontAwesome.Sharp.IconButton();
            this.txt_mana = new System.Windows.Forms.TextBox();
            this.btn_aumenta_mana = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_vigor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nome_perso
            // 
            this.lbl_nome_perso.AutoSize = true;
            this.lbl_nome_perso.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nome_perso.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_nome_perso.Location = new System.Drawing.Point(10, 8);
            this.lbl_nome_perso.Name = "lbl_nome_perso";
            this.lbl_nome_perso.Size = new System.Drawing.Size(79, 31);
            this.lbl_nome_perso.TabIndex = 4;
            this.lbl_nome_perso.Text = "Nome";
            // 
            // iconButton1
            // 
            this.iconButton1.CausesValidation = false;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(5, 56);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(84, 30);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Vida:";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // btn_aumenta_vida
            // 
            this.btn_aumenta_vida.FlatAppearance.BorderSize = 0;
            this.btn_aumenta_vida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aumenta_vida.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_aumenta_vida.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_aumenta_vida.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_aumenta_vida.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_aumenta_vida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_aumenta_vida.IconSize = 15;
            this.btn_aumenta_vida.Location = new System.Drawing.Point(176, 57);
            this.btn_aumenta_vida.Name = "btn_aumenta_vida";
            this.btn_aumenta_vida.Size = new System.Drawing.Size(18, 15);
            this.btn_aumenta_vida.TabIndex = 6;
            this.btn_aumenta_vida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_aumenta_vida.UseVisualStyleBackColor = true;
            this.btn_aumenta_vida.Click += new System.EventHandler(this.btn_aumenta_vida_Click);
            // 
            // txt_vida
            // 
            this.txt_vida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.txt_vida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vida.Enabled = false;
            this.txt_vida.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_vida.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt_vida.Location = new System.Drawing.Point(100, 59);
            this.txt_vida.Multiline = true;
            this.txt_vida.Name = "txt_vida";
            this.txt_vida.Size = new System.Drawing.Size(72, 30);
            this.txt_vida.TabIndex = 7;
            this.txt_vida.Text = "0/0";
            this.txt_vida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_diminui_vida
            // 
            this.btn_diminui_vida.FlatAppearance.BorderSize = 0;
            this.btn_diminui_vida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_diminui_vida.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_diminui_vida.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_diminui_vida.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_diminui_vida.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_diminui_vida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_diminui_vida.IconSize = 15;
            this.btn_diminui_vida.Location = new System.Drawing.Point(177, 76);
            this.btn_diminui_vida.Name = "btn_diminui_vida";
            this.btn_diminui_vida.Size = new System.Drawing.Size(18, 15);
            this.btn_diminui_vida.TabIndex = 8;
            this.btn_diminui_vida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_diminui_vida.UseVisualStyleBackColor = true;
            this.btn_diminui_vida.Click += new System.EventHandler(this.btn_diminui_vida_Click);
            // 
            // lbl_dado_ataque
            // 
            this.lbl_dado_ataque.AutoSize = true;
            this.lbl_dado_ataque.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dado_ataque.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_dado_ataque.Location = new System.Drawing.Point(234, 20);
            this.lbl_dado_ataque.Name = "lbl_dado_ataque";
            this.lbl_dado_ataque.Size = new System.Drawing.Size(118, 19);
            this.lbl_dado_ataque.TabIndex = 9;
            this.lbl_dado_ataque.Text = "Ataque: 1d20 + 5";
            // 
            // lbl_forca
            // 
            this.lbl_forca.AutoSize = true;
            this.lbl_forca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_forca.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_forca.Location = new System.Drawing.Point(201, 56);
            this.lbl_forca.Name = "lbl_forca";
            this.lbl_forca.Size = new System.Drawing.Size(48, 15);
            this.lbl_forca.TabIndex = 11;
            this.lbl_forca.Text = "Força: 5";
            // 
            // lbl_dest
            // 
            this.lbl_dest.AutoSize = true;
            this.lbl_dest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dest.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_dest.Location = new System.Drawing.Point(268, 56);
            this.lbl_dest.Name = "lbl_dest";
            this.lbl_dest.Size = new System.Drawing.Size(63, 15);
            this.lbl_dest.TabIndex = 12;
            this.lbl_dest.Text = "Destreza: 2";
            // 
            // lbl_raci
            // 
            this.lbl_raci.AutoSize = true;
            this.lbl_raci.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_raci.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_raci.Location = new System.Drawing.Point(266, 89);
            this.lbl_raci.Name = "lbl_raci";
            this.lbl_raci.Size = new System.Drawing.Size(74, 15);
            this.lbl_raci.TabIndex = 14;
            this.lbl_raci.Text = "Raciocinio: 0";
            // 
            // lbl_caris
            // 
            this.lbl_caris.AutoSize = true;
            this.lbl_caris.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_caris.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_caris.Location = new System.Drawing.Point(201, 89);
            this.lbl_caris.Name = "lbl_caris";
            this.lbl_caris.Size = new System.Drawing.Size(62, 15);
            this.lbl_caris.TabIndex = 13;
            this.lbl_caris.Text = "Carisma: 1";
            // 
            // lbl_magia
            // 
            this.lbl_magia.AutoSize = true;
            this.lbl_magia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_magia.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_magia.Location = new System.Drawing.Point(341, 56);
            this.lbl_magia.Name = "lbl_magia";
            this.lbl_magia.Size = new System.Drawing.Size(52, 15);
            this.lbl_magia.TabIndex = 15;
            this.lbl_magia.Text = "magia: 2";
            // 
            // btn_diminui_mana
            // 
            this.btn_diminui_mana.FlatAppearance.BorderSize = 0;
            this.btn_diminui_mana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_diminui_mana.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_diminui_mana.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_diminui_mana.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_diminui_mana.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_diminui_mana.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_diminui_mana.IconSize = 15;
            this.btn_diminui_mana.Location = new System.Drawing.Point(177, 119);
            this.btn_diminui_mana.Name = "btn_diminui_mana";
            this.btn_diminui_mana.Size = new System.Drawing.Size(18, 15);
            this.btn_diminui_mana.TabIndex = 19;
            this.btn_diminui_mana.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_diminui_mana.UseVisualStyleBackColor = true;
            this.btn_diminui_mana.Click += new System.EventHandler(this.btn_diminui_mana_Click);
            // 
            // txt_mana
            // 
            this.txt_mana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.txt_mana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mana.Enabled = false;
            this.txt_mana.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_mana.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt_mana.Location = new System.Drawing.Point(100, 102);
            this.txt_mana.Multiline = true;
            this.txt_mana.Name = "txt_mana";
            this.txt_mana.Size = new System.Drawing.Size(72, 30);
            this.txt_mana.TabIndex = 18;
            this.txt_mana.Text = "0/0";
            this.txt_mana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_aumenta_mana
            // 
            this.btn_aumenta_mana.FlatAppearance.BorderSize = 0;
            this.btn_aumenta_mana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aumenta_mana.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_aumenta_mana.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_aumenta_mana.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_aumenta_mana.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_aumenta_mana.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_aumenta_mana.IconSize = 15;
            this.btn_aumenta_mana.Location = new System.Drawing.Point(176, 99);
            this.btn_aumenta_mana.Name = "btn_aumenta_mana";
            this.btn_aumenta_mana.Size = new System.Drawing.Size(18, 15);
            this.btn_aumenta_mana.TabIndex = 17;
            this.btn_aumenta_mana.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_aumenta_mana.UseVisualStyleBackColor = true;
            this.btn_aumenta_mana.Click += new System.EventHandler(this.btn_aumenta_mana_Click);
            // 
            // iconButton6
            // 
            this.iconButton6.CausesValidation = false;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconButton6.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 30;
            this.iconButton6.Location = new System.Drawing.Point(6, 99);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(88, 30);
            this.iconButton6.TabIndex = 16;
            this.iconButton6.Text = "Mana:";
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(268, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 28);
            this.button2.TabIndex = 97;
            this.button2.Text = "Detalhes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_vigor
            // 
            this.lbl_vigor.AutoSize = true;
            this.lbl_vigor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_vigor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_vigor.Location = new System.Drawing.Point(346, 89);
            this.lbl_vigor.Name = "lbl_vigor";
            this.lbl_vigor.Size = new System.Drawing.Size(47, 15);
            this.lbl_vigor.TabIndex = 98;
            this.lbl_vigor.Text = "Vigor: 1";
            // 
            // Painel_NPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_vigor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_diminui_mana);
            this.Controls.Add(this.txt_mana);
            this.Controls.Add(this.btn_aumenta_mana);
            this.Controls.Add(this.iconButton6);
            this.Controls.Add(this.lbl_magia);
            this.Controls.Add(this.lbl_raci);
            this.Controls.Add(this.lbl_caris);
            this.Controls.Add(this.lbl_dest);
            this.Controls.Add(this.lbl_forca);
            this.Controls.Add(this.lbl_dado_ataque);
            this.Controls.Add(this.btn_diminui_vida);
            this.Controls.Add(this.txt_vida);
            this.Controls.Add(this.btn_aumenta_vida);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.lbl_nome_perso);
            this.Name = "Painel_NPC";
            this.Size = new System.Drawing.Size(396, 148);
            this.Load += new System.EventHandler(this.Painel_NPC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome_perso;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btn_aumenta_vida;
        private System.Windows.Forms.TextBox txt_vida;
        private FontAwesome.Sharp.IconButton btn_diminui_vida;
        private System.Windows.Forms.Label lbl_dado_ataque;
        private System.Windows.Forms.Label lbl_forca;
        private System.Windows.Forms.Label lbl_dest;
        private System.Windows.Forms.Label lbl_raci;
        private System.Windows.Forms.Label lbl_caris;
        private System.Windows.Forms.Label lbl_magia;
        private FontAwesome.Sharp.IconButton btn_diminui_mana;
        private System.Windows.Forms.TextBox txt_mana;
        private FontAwesome.Sharp.IconButton btn_aumenta_mana;
        private FontAwesome.Sharp.IconButton iconButton6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_vigor;
    }
}
