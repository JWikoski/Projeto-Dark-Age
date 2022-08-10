
namespace Dark_Age
{
    partial class Habilidades_passivas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Habilidades_passivas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_passivas = new System.Windows.Forms.TextBox();
            this.Editar = new System.Windows.Forms.CheckBox();
            this.Editar2 = new System.Windows.Forms.CheckBox();
            this.txt_passivas2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblFecharPassivas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(220, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Habilidades Passivas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(0, 2000);
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(2, 93);
            this.panel1.MaximumSize = new System.Drawing.Size(727, 2400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 986);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_passivas
            // 
            this.txt_passivas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(98)))), ((int)(((byte)(180)))));
            this.txt_passivas.Enabled = false;
            this.txt_passivas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_passivas.Location = new System.Drawing.Point(2, 57);
            this.txt_passivas.Multiline = true;
            this.txt_passivas.Name = "txt_passivas";
            this.txt_passivas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_passivas.Size = new System.Drawing.Size(722, 23);
            this.txt_passivas.TabIndex = 15;
            this.txt_passivas.TextChanged += new System.EventHandler(this.txt_passivas_TextChanged);
            // 
            // Editar
            // 
            this.Editar.AutoSize = true;
            this.Editar.BackColor = System.Drawing.Color.Transparent;
            this.Editar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Editar.Location = new System.Drawing.Point(12, 32);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(56, 19);
            this.Editar.TabIndex = 16;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = false;
            this.Editar.CheckedChanged += new System.EventHandler(this.Editar_CheckedChanged);
            // 
            // Editar2
            // 
            this.Editar2.AutoSize = true;
            this.Editar2.BackColor = System.Drawing.Color.Transparent;
            this.Editar2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Editar2.Location = new System.Drawing.Point(857, 26);
            this.Editar2.Name = "Editar2";
            this.Editar2.Size = new System.Drawing.Size(56, 19);
            this.Editar2.TabIndex = 21;
            this.Editar2.Text = "Editar";
            this.Editar2.UseVisualStyleBackColor = false;
            this.Editar2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_passivas2
            // 
            this.txt_passivas2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(94)))), ((int)(((byte)(178)))));
            this.txt_passivas2.Enabled = false;
            this.txt_passivas2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_passivas2.Location = new System.Drawing.Point(847, 51);
            this.txt_passivas2.Multiline = true;
            this.txt_passivas2.Name = "txt_passivas2";
            this.txt_passivas2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_passivas2.Size = new System.Drawing.Size(722, 23);
            this.txt_passivas2.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoScrollMinSize = new System.Drawing.Size(0, 2000);
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(847, 87);
            this.panel2.MaximumSize = new System.Drawing.Size(727, 2400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 986);
            this.panel2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.MaximumSize = new System.Drawing.Size(700, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1065, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 45);
            this.label5.TabIndex = 17;
            this.label5.Text = "Habilidades Ativas";
            // 
            // LblFecharPassivas
            // 
            this.LblFecharPassivas.BackColor = System.Drawing.Color.Transparent;
            this.LblFecharPassivas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblFecharPassivas.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFecharPassivas.ForeColor = System.Drawing.Color.White;
            this.LblFecharPassivas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblFecharPassivas.Location = new System.Drawing.Point(1551, 5);
            this.LblFecharPassivas.Name = "LblFecharPassivas";
            this.LblFecharPassivas.Size = new System.Drawing.Size(42, 40);
            this.LblFecharPassivas.TabIndex = 12;
            this.LblFecharPassivas.Text = "X";
            this.LblFecharPassivas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblFecharPassivas.Click += new System.EventHandler(this.LblFecharLogin_Click);
            this.LblFecharPassivas.MouseLeave += new System.EventHandler(this.LblFecharPassivas_MouseLeave);
            this.LblFecharPassivas.MouseHover += new System.EventHandler(this.LblFecharPassivas_MouseHover);
            // 
            // Habilidades_passivas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImage = global::Dark_Age.Properties.Resources.thumb_1920_1159325;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1605, 1080);
            this.Controls.Add(this.Editar2);
            this.Controls.Add(this.txt_passivas2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.txt_passivas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblFecharPassivas);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Habilidades_passivas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Habilidades";
            this.Load += new System.EventHandler(this.Habilidades_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_passivas;
        private System.Windows.Forms.CheckBox Editar;
        private System.Windows.Forms.CheckBox Editar2;
        private System.Windows.Forms.TextBox txt_passivas2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblFecharPassivas;
    }
}