
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
            this.btn_diminui_mana = new FontAwesome.Sharp.IconButton();
            this.txt_mana = new System.Windows.Forms.TextBox();
            this.btn_aumenta_mana = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.btn_detalhes = new System.Windows.Forms.Button();
            this.iniciativa_npc = new FontAwesome.Sharp.IconButton();
            this.image_pers = new System.Windows.Forms.PictureBox();
            this.lbl_dado_ataque = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.image_pers)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome_perso
            // 
            this.lbl_nome_perso.AutoSize = true;
            this.lbl_nome_perso.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nome_perso.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_nome_perso.Location = new System.Drawing.Point(10, 8);
            this.lbl_nome_perso.MaximumSize = new System.Drawing.Size(190, 0);
            this.lbl_nome_perso.Name = "lbl_nome_perso";
            this.lbl_nome_perso.Size = new System.Drawing.Size(66, 25);
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
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(209, 38);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(68, 27);
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
            this.btn_aumenta_vida.Location = new System.Drawing.Point(367, 37);
            this.btn_aumenta_vida.Name = "btn_aumenta_vida";
            this.btn_aumenta_vida.Size = new System.Drawing.Size(10, 10);
            this.btn_aumenta_vida.TabIndex = 6;
            this.btn_aumenta_vida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_aumenta_vida.UseVisualStyleBackColor = true;
            this.btn_aumenta_vida.Click += new System.EventHandler(this.btn_aumenta_vida_Click);
            this.btn_aumenta_vida.MouseEnter += new System.EventHandler(this.btn_detalhes_MouseEnter);
            this.btn_aumenta_vida.MouseHover += new System.EventHandler(this.btn_detalhes_MouseEnter);
            // 
            // txt_vida
            // 
            this.txt_vida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.txt_vida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_vida.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt_vida.Location = new System.Drawing.Point(289, 38);
            this.txt_vida.Multiline = true;
            this.txt_vida.Name = "txt_vida";
            this.txt_vida.Size = new System.Drawing.Size(72, 27);
            this.txt_vida.TabIndex = 7;
            this.txt_vida.Text = "0/0";
            this.txt_vida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_vida.Click += new System.EventHandler(this.txt_vida_Click);
            this.txt_vida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_vida_KeyDown);
            this.txt_vida.Leave += new System.EventHandler(this.txt_vida_Leave);
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
            this.btn_diminui_vida.Location = new System.Drawing.Point(368, 55);
            this.btn_diminui_vida.Name = "btn_diminui_vida";
            this.btn_diminui_vida.Size = new System.Drawing.Size(10, 10);
            this.btn_diminui_vida.TabIndex = 8;
            this.btn_diminui_vida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_diminui_vida.UseVisualStyleBackColor = true;
            this.btn_diminui_vida.Click += new System.EventHandler(this.btn_diminui_vida_Click);
            this.btn_diminui_vida.MouseEnter += new System.EventHandler(this.btn_detalhes_MouseEnter);
            this.btn_diminui_vida.MouseHover += new System.EventHandler(this.btn_detalhes_MouseEnter);
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
            this.btn_diminui_mana.Location = new System.Drawing.Point(367, 87);
            this.btn_diminui_mana.Name = "btn_diminui_mana";
            this.btn_diminui_mana.Size = new System.Drawing.Size(10, 10);
            this.btn_diminui_mana.TabIndex = 19;
            this.btn_diminui_mana.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_diminui_mana.UseVisualStyleBackColor = true;
            this.btn_diminui_mana.Click += new System.EventHandler(this.btn_diminui_mana_Click);
            this.btn_diminui_mana.MouseEnter += new System.EventHandler(this.btn_detalhes_MouseEnter);
            this.btn_diminui_mana.MouseHover += new System.EventHandler(this.btn_detalhes_MouseEnter);
            // 
            // txt_mana
            // 
            this.txt_mana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.txt_mana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mana.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_mana.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt_mana.Location = new System.Drawing.Point(289, 71);
            this.txt_mana.Multiline = true;
            this.txt_mana.Name = "txt_mana";
            this.txt_mana.Size = new System.Drawing.Size(72, 27);
            this.txt_mana.TabIndex = 18;
            this.txt_mana.Text = "0/0";
            this.txt_mana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_mana.Click += new System.EventHandler(this.txt_mana_Click);
            this.txt_mana.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_mana_KeyDown);
            this.txt_mana.Leave += new System.EventHandler(this.txt_mana_Leave);
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
            this.btn_aumenta_mana.Location = new System.Drawing.Point(367, 71);
            this.btn_aumenta_mana.Name = "btn_aumenta_mana";
            this.btn_aumenta_mana.Size = new System.Drawing.Size(10, 10);
            this.btn_aumenta_mana.TabIndex = 17;
            this.btn_aumenta_mana.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_aumenta_mana.UseVisualStyleBackColor = true;
            this.btn_aumenta_mana.Click += new System.EventHandler(this.btn_aumenta_mana_Click);
            this.btn_aumenta_mana.MouseEnter += new System.EventHandler(this.btn_detalhes_MouseEnter);
            this.btn_aumenta_mana.MouseHover += new System.EventHandler(this.btn_detalhes_MouseEnter);
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
            this.iconButton6.IconSize = 20;
            this.iconButton6.Location = new System.Drawing.Point(202, 71);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(75, 26);
            this.iconButton6.TabIndex = 16;
            this.iconButton6.Text = "Mana:";
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = true;
            // 
            // btn_detalhes
            // 
            this.btn_detalhes.BackColor = System.Drawing.Color.Transparent;
            this.btn_detalhes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_detalhes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.btn_detalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_detalhes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_detalhes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_detalhes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_detalhes.Location = new System.Drawing.Point(289, 112);
            this.btn_detalhes.Name = "btn_detalhes";
            this.btn_detalhes.Size = new System.Drawing.Size(84, 28);
            this.btn_detalhes.TabIndex = 97;
            this.btn_detalhes.Text = "Detalhes";
            this.btn_detalhes.UseVisualStyleBackColor = false;
            this.btn_detalhes.Click += new System.EventHandler(this.button2_Click);
            this.btn_detalhes.MouseEnter += new System.EventHandler(this.btn_detalhes_MouseEnter);
            this.btn_detalhes.MouseHover += new System.EventHandler(this.btn_detalhes_MouseEnter);
            // 
            // iniciativa_npc
            // 
            this.iniciativa_npc.CausesValidation = false;
            this.iniciativa_npc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iniciativa_npc.FlatAppearance.BorderSize = 0;
            this.iniciativa_npc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iniciativa_npc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iniciativa_npc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iniciativa_npc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iniciativa_npc.ForeColor = System.Drawing.Color.Silver;
            this.iniciativa_npc.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.iniciativa_npc.IconColor = System.Drawing.Color.White;
            this.iniciativa_npc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iniciativa_npc.IconSize = 20;
            this.iniciativa_npc.Location = new System.Drawing.Point(145, 115);
            this.iniciativa_npc.Name = "iniciativa_npc";
            this.iniciativa_npc.Size = new System.Drawing.Size(94, 30);
            this.iniciativa_npc.TabIndex = 99;
            this.iniciativa_npc.Text = "Iniciativa";
            this.iniciativa_npc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iniciativa_npc.UseVisualStyleBackColor = true;
            this.iniciativa_npc.Click += new System.EventHandler(this.iconButton2_Click);
            this.iniciativa_npc.MouseEnter += new System.EventHandler(this.iniciativa_npc_MouseHover);
            this.iniciativa_npc.MouseLeave += new System.EventHandler(this.iniciativa_npc_MouseLeave);
            this.iniciativa_npc.MouseHover += new System.EventHandler(this.iniciativa_npc_MouseHover);
            // 
            // image_pers
            // 
            this.image_pers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.image_pers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.image_pers.Image = global::Dark_Age.Properties.Resources.download;
            this.image_pers.InitialImage = global::Dark_Age.Properties.Resources.download;
            this.image_pers.Location = new System.Drawing.Point(10, 49);
            this.image_pers.Name = "image_pers";
            this.image_pers.Size = new System.Drawing.Size(129, 91);
            this.image_pers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_pers.TabIndex = 108;
            this.image_pers.TabStop = false;
            this.image_pers.Click += new System.EventHandler(this.image_pers_Click);
            // 
            // lbl_dado_ataque
            // 
            this.lbl_dado_ataque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lbl_dado_ataque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_dado_ataque.FlatAppearance.BorderSize = 0;
            this.lbl_dado_ataque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.lbl_dado_ataque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.lbl_dado_ataque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_dado_ataque.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dado_ataque.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_dado_ataque.IconChar = FontAwesome.Sharp.IconChar.HandSparkles;
            this.lbl_dado_ataque.IconColor = System.Drawing.Color.OrangeRed;
            this.lbl_dado_ataque.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lbl_dado_ataque.IconSize = 20;
            this.lbl_dado_ataque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_dado_ataque.Location = new System.Drawing.Point(193, 0);
            this.lbl_dado_ataque.Name = "lbl_dado_ataque";
            this.lbl_dado_ataque.Size = new System.Drawing.Size(168, 32);
            this.lbl_dado_ataque.TabIndex = 147;
            this.lbl_dado_ataque.Text = "Ataque:";
            this.lbl_dado_ataque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_dado_ataque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lbl_dado_ataque.UseVisualStyleBackColor = true;
            this.lbl_dado_ataque.Click += new System.EventHandler(this.lbl_dado_ataque_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton2.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButton2.IconColor = System.Drawing.Color.OrangeRed;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton2.Location = new System.Drawing.Point(367, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(30, 27);
            this.iconButton2.TabIndex = 148;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click_1);
            this.iconButton2.MouseEnter += new System.EventHandler(this.btn_detalhes_MouseEnter);
            this.iconButton2.MouseHover += new System.EventHandler(this.btn_detalhes_MouseEnter);
            // 
            // Painel_NPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.lbl_dado_ataque);
            this.Controls.Add(this.image_pers);
            this.Controls.Add(this.iniciativa_npc);
            this.Controls.Add(this.btn_detalhes);
            this.Controls.Add(this.btn_diminui_mana);
            this.Controls.Add(this.txt_mana);
            this.Controls.Add(this.btn_aumenta_mana);
            this.Controls.Add(this.iconButton6);
            this.Controls.Add(this.btn_diminui_vida);
            this.Controls.Add(this.txt_vida);
            this.Controls.Add(this.btn_aumenta_vida);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.lbl_nome_perso);
            this.Name = "Painel_NPC";
            this.Size = new System.Drawing.Size(396, 148);
            this.Load += new System.EventHandler(this.Painel_NPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image_pers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome_perso;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btn_aumenta_vida;
        private System.Windows.Forms.TextBox txt_vida;
        private FontAwesome.Sharp.IconButton btn_diminui_vida;
        private FontAwesome.Sharp.IconButton btn_diminui_mana;
        private System.Windows.Forms.TextBox txt_mana;
        private FontAwesome.Sharp.IconButton btn_aumenta_mana;
        private FontAwesome.Sharp.IconButton iconButton6;
        private System.Windows.Forms.Button btn_detalhes;
        private FontAwesome.Sharp.IconButton iniciativa_npc;
        private System.Windows.Forms.PictureBox image_pers;
        private FontAwesome.Sharp.IconButton lbl_dado_ataque;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}
