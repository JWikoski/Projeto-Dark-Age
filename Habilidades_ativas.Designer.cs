
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Habilidades_ativas));
            this.label1 = new System.Windows.Forms.Label();
            this.LblFecharPassivas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_ativas = new System.Windows.Forms.TextBox();
            this.Editar = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(276, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Anotações";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblFecharPassivas
            // 
            this.LblFecharPassivas.BackColor = System.Drawing.Color.Transparent;
            this.LblFecharPassivas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblFecharPassivas.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFecharPassivas.ForeColor = System.Drawing.Color.White;
            this.LblFecharPassivas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblFecharPassivas.Location = new System.Drawing.Point(673, 9);
            this.LblFecharPassivas.Name = "LblFecharPassivas";
            this.LblFecharPassivas.Size = new System.Drawing.Size(42, 40);
            this.LblFecharPassivas.TabIndex = 12;
            this.LblFecharPassivas.Text = "X";
            this.LblFecharPassivas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblFecharPassivas.Click += new System.EventHandler(this.LblFecharLogin_Click);
            this.LblFecharPassivas.MouseLeave += new System.EventHandler(this.LblFecharPassivas_MouseLeave);
            this.LblFecharPassivas.MouseHover += new System.EventHandler(this.LblFecharPassivas_MouseHover);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.MaximumSize = new System.Drawing.Size(700, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 11;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(0, 2000);
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 93);
            this.panel1.MaximumSize = new System.Drawing.Size(727, 2000);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 983);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_ativas
            // 
            this.txt_ativas.Enabled = false;
            this.txt_ativas.Location = new System.Drawing.Point(5, 64);
            this.txt_ativas.Multiline = true;
            this.txt_ativas.Name = "txt_ativas";
            this.txt_ativas.Size = new System.Drawing.Size(716, 23);
            this.txt_ativas.TabIndex = 14;
            this.txt_ativas.TextChanged += new System.EventHandler(this.txt_ativas_TextChanged);
            // 
            // Editar
            // 
            this.Editar.AutoSize = true;
            this.Editar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Editar.Location = new System.Drawing.Point(12, 39);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(56, 19);
            this.Editar.TabIndex = 12;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.CheckedChanged += new System.EventHandler(this.Editar_CheckedChanged);
            // 
            // Habilidades_ativas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 1080);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.txt_ativas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblFecharPassivas);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblFecharPassivas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_ativas;
        private System.Windows.Forms.CheckBox Editar;
    }
}