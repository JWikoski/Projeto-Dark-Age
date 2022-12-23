
namespace Dark_Age
{
    partial class Temas
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
            this.claro = new FontAwesome.Sharp.IconButton();
            this.escuro = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // claro
            // 
            this.claro.BackColor = System.Drawing.Color.Transparent;
            this.claro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.claro.FlatAppearance.BorderSize = 0;
            this.claro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.claro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.claro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.claro.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.claro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.claro.IconChar = FontAwesome.Sharp.IconChar.Sun;
            this.claro.IconColor = System.Drawing.Color.Gainsboro;
            this.claro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.claro.Location = new System.Drawing.Point(13, 62);
            this.claro.Name = "claro";
            this.claro.Size = new System.Drawing.Size(231, 115);
            this.claro.TabIndex = 0;
            this.claro.Text = "Tema Claro";
            this.claro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.claro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.claro.UseVisualStyleBackColor = false;
            this.claro.Click += new System.EventHandler(this.iconButton1_Click);
            this.claro.MouseEnter += new System.EventHandler(this.claro_MouseEnter);
            this.claro.MouseLeave += new System.EventHandler(this.escuro_MouseLeave);
            // 
            // escuro
            // 
            this.escuro.BackColor = System.Drawing.Color.Transparent;
            this.escuro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.escuro.FlatAppearance.BorderSize = 0;
            this.escuro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.escuro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.escuro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.escuro.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.escuro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.escuro.IconChar = FontAwesome.Sharp.IconChar.Moon;
            this.escuro.IconColor = System.Drawing.Color.Gainsboro;
            this.escuro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.escuro.Location = new System.Drawing.Point(252, 62);
            this.escuro.Name = "escuro";
            this.escuro.Size = new System.Drawing.Size(231, 115);
            this.escuro.TabIndex = 1;
            this.escuro.Text = "Tema Escuro";
            this.escuro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.escuro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.escuro.UseVisualStyleBackColor = false;
            this.escuro.Click += new System.EventHandler(this.iconButton2_Click);
            this.escuro.MouseEnter += new System.EventHandler(this.escuro_MouseEnter);
            this.escuro.MouseLeave += new System.EventHandler(this.escuro_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escolha um tema:";
            // 
            // btn_continuar
            // 
            this.btn_continuar.BackColor = System.Drawing.Color.Transparent;
            this.btn_continuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_continuar.FlatAppearance.BorderSize = 0;
            this.btn_continuar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_continuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_continuar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_continuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continuar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_continuar.ForeColor = System.Drawing.Color.Silver;
            this.btn_continuar.Location = new System.Drawing.Point(360, 200);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(109, 39);
            this.btn_continuar.TabIndex = 3;
            this.btn_continuar.Text = "Continuar";
            this.btn_continuar.UseVisualStyleBackColor = false;
            this.btn_continuar.Click += new System.EventHandler(this.button1_Click);
            this.btn_continuar.MouseEnter += new System.EventHandler(this.btn_continuar_MouseEnter);
            this.btn_continuar.MouseLeave += new System.EventHandler(this.btn_continuar_MouseLeave);
            this.btn_continuar.MouseHover += new System.EventHandler(this.btn_continuar_MouseEnter);
            // 
            // Temas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(494, 251);
            this.Controls.Add(this.btn_continuar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.escuro);
            this.Controls.Add(this.claro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Temas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temas";
            this.Load += new System.EventHandler(this.Temas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton claro;
        private FontAwesome.Sharp.IconButton escuro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_continuar;
    }
}