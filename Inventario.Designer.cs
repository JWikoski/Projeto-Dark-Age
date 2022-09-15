
namespace Dark_Age
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.txt_inventario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.itens_inventario = new System.Windows.Forms.Label();
            this.ouro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.moedas_ouro = new System.Windows.Forms.NumericUpDown();
            this.moedas_prata = new System.Windows.Forms.NumericUpDown();
            this.Editar = new System.Windows.Forms.CheckBox();
            this.LblFecharPassivas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.moedas_ouro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moedas_prata)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_inventario
            // 
            this.txt_inventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_inventario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_inventario.Enabled = false;
            this.txt_inventario.Location = new System.Drawing.Point(102, 3);
            this.txt_inventario.Multiline = true;
            this.txt_inventario.Name = "txt_inventario";
            this.txt_inventario.Size = new System.Drawing.Size(512, 31);
            this.txt_inventario.TabIndex = 0;
            this.txt_inventario.Text = "Consumiveis:\r\n\r\n\r\nArmas/Armaduras:\r\n\r\n\r\nItens de quest:\r\n\r\n\r\nFerramentas e compon" +
    "entes de profissão: \r\n";
            this.txt_inventario.TextChanged += new System.EventHandler(this.txt_inventario_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(25, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 50);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(46, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "Inventário";
            // 
            // itens_inventario
            // 
            this.itens_inventario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itens_inventario.AutoSize = true;
            this.itens_inventario.BackColor = System.Drawing.Color.Transparent;
            this.itens_inventario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itens_inventario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.itens_inventario.Location = new System.Drawing.Point(371, 126);
            this.itens_inventario.MaximumSize = new System.Drawing.Size(600, 0);
            this.itens_inventario.Name = "itens_inventario";
            this.itens_inventario.Size = new System.Drawing.Size(0, 21);
            this.itens_inventario.TabIndex = 12;
            // 
            // ouro
            // 
            this.ouro.AutoSize = true;
            this.ouro.BackColor = System.Drawing.Color.Transparent;
            this.ouro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ouro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ouro.Location = new System.Drawing.Point(53, 140);
            this.ouro.Name = "ouro";
            this.ouro.Size = new System.Drawing.Size(129, 21);
            this.ouro.TabIndex = 13;
            this.ouro.Text = "Moedas de Ouro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(53, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Moedas de Prata:";
            // 
            // moedas_ouro
            // 
            this.moedas_ouro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.moedas_ouro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moedas_ouro.ForeColor = System.Drawing.Color.Black;
            this.moedas_ouro.Location = new System.Drawing.Point(200, 143);
            this.moedas_ouro.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.moedas_ouro.Name = "moedas_ouro";
            this.moedas_ouro.Size = new System.Drawing.Size(72, 23);
            this.moedas_ouro.TabIndex = 80;
            this.moedas_ouro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // moedas_prata
            // 
            this.moedas_prata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.moedas_prata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moedas_prata.ForeColor = System.Drawing.Color.Black;
            this.moedas_prata.Location = new System.Drawing.Point(200, 188);
            this.moedas_prata.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.moedas_prata.Name = "moedas_prata";
            this.moedas_prata.Size = new System.Drawing.Size(72, 23);
            this.moedas_prata.TabIndex = 81;
            this.moedas_prata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Editar
            // 
            this.Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Editar.AutoSize = true;
            this.Editar.BackColor = System.Drawing.Color.Transparent;
            this.Editar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Editar.Location = new System.Drawing.Point(15, 9);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(56, 19);
            this.Editar.TabIndex = 82;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = false;
            this.Editar.CheckedChanged += new System.EventHandler(this.Editar_CheckedChanged);
            // 
            // LblFecharPassivas
            // 
            this.LblFecharPassivas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFecharPassivas.BackColor = System.Drawing.Color.Transparent;
            this.LblFecharPassivas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblFecharPassivas.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFecharPassivas.ForeColor = System.Drawing.Color.White;
            this.LblFecharPassivas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblFecharPassivas.Location = new System.Drawing.Point(629, 3);
            this.LblFecharPassivas.Name = "LblFecharPassivas";
            this.LblFecharPassivas.Size = new System.Drawing.Size(42, 40);
            this.LblFecharPassivas.TabIndex = 83;
            this.LblFecharPassivas.Text = "X";
            this.LblFecharPassivas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblFecharPassivas.Click += new System.EventHandler(this.LblFecharPassivas_Click);
            this.LblFecharPassivas.MouseEnter += new System.EventHandler(this.LblFecharPassivas_MouseEnter);
            this.LblFecharPassivas.MouseLeave += new System.EventHandler(this.LblFecharPassivas_MouseLeave);
            this.LblFecharPassivas.MouseHover += new System.EventHandler(this.LblFecharPassivas_MouseHover);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = global::Dark_Age.Properties.Resources.minimizar1;
            this.label3.Location = new System.Drawing.Point(629, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 42);
            this.label3.TabIndex = 84;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseEnter += new System.EventHandler(this.LblFecharPassivas_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.LblFecharPassivas_MouseLeave);
            this.label3.MouseHover += new System.EventHandler(this.LblFecharPassivas_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.ouro);
            this.panel2.Controls.Add(this.moedas_prata);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.moedas_ouro);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 776);
            this.panel2.TabIndex = 85;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_inventario);
            this.panel3.Controls.Add(this.LblFecharPassivas);
            this.panel3.Controls.Add(this.Editar);
            this.panel3.Location = new System.Drawing.Point(984, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(678, 797);
            this.panel3.TabIndex = 86;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Enabled = false;
            this.panel8.Location = new System.Drawing.Point(2, -1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1660, 62);
            this.panel8.TabIndex = 89;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            this.panel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Dark_Age.Properties.Resources.castle2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1661, 800);
            this.Controls.Add(this.itens_inventario);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventario";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moedas_ouro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moedas_prata)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_inventario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label itens_inventario;
        private System.Windows.Forms.Label ouro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown moedas_ouro;
        private System.Windows.Forms.NumericUpDown moedas_prata;
        private System.Windows.Forms.CheckBox Editar;
        private System.Windows.Forms.Label LblFecharPassivas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Timer timer1;
    }
}