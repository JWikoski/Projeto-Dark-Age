namespace Dark_Age
{
    partial class Lista_itens
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
            Grid_lista_itens = new System.Windows.Forms.DataGridView();
            this.text_descricao = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblFecharPassivas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(Grid_lista_itens)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid_lista_itens
            // 
            Grid_lista_itens.AllowUserToAddRows = false;
            Grid_lista_itens.AllowUserToDeleteRows = false;
            Grid_lista_itens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            Grid_lista_itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_lista_itens.Location = new System.Drawing.Point(12, 46);
            Grid_lista_itens.MultiSelect = false;
            Grid_lista_itens.Name = "Grid_lista_itens";
            Grid_lista_itens.ReadOnly = true;
            Grid_lista_itens.RowTemplate.Height = 25;
            Grid_lista_itens.Size = new System.Drawing.Size(519, 481);
            Grid_lista_itens.TabIndex = 0;
            Grid_lista_itens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_lista_itens_CellClick);
            // 
            // text_descricao
            // 
            this.text_descricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.text_descricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_descricao.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_descricao.ForeColor = System.Drawing.Color.White;
            this.text_descricao.Location = new System.Drawing.Point(560, 178);
            this.text_descricao.Name = "text_descricao";
            this.text_descricao.Size = new System.Drawing.Size(329, 349);
            this.text_descricao.TabIndex = 1;
            this.text_descricao.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.LblFecharPassivas);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(Grid_lista_itens);
            this.panel1.Controls.Add(this.text_descricao);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 557);
            this.panel1.TabIndex = 2;
            // 
            // LblFecharPassivas
            // 
            this.LblFecharPassivas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFecharPassivas.BackColor = System.Drawing.Color.Transparent;
            this.LblFecharPassivas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblFecharPassivas.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFecharPassivas.ForeColor = System.Drawing.Color.White;
            this.LblFecharPassivas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblFecharPassivas.Location = new System.Drawing.Point(852, 0);
            this.LblFecharPassivas.Name = "LblFecharPassivas";
            this.LblFecharPassivas.Size = new System.Drawing.Size(42, 40);
            this.LblFecharPassivas.TabIndex = 86;
            this.LblFecharPassivas.Text = "X";
            this.LblFecharPassivas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblFecharPassivas.Click += new System.EventHandler(this.LblFecharPassivas_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(126)))), ((int)(((byte)(155)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(560, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Adicionar Item ao Inventario";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(207, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tabela de Itens";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(651, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descrição do Item";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_adicionar);
            this.panel2.Controls.Add(this.btn_editar);
            this.panel2.Controls.Add(this.btn_eliminar);
            this.panel2.Location = new System.Drawing.Point(560, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 54);
            this.panel2.TabIndex = 5;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(58)))));
            this.btn_adicionar.FlatAppearance.BorderSize = 0;
            this.btn_adicionar.ForeColor = System.Drawing.Color.White;
            this.btn_adicionar.Location = new System.Drawing.Point(0, 10);
            this.btn_adicionar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(94, 38);
            this.btn_adicionar.TabIndex = 2;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click_1);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(38)))), ((int)(((byte)(102)))));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Location = new System.Drawing.Point(111, 10);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(102, 38);
            this.btn_editar.TabIndex = 3;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(58)))));
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(58)))));
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(58)))));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Location = new System.Drawing.Point(232, 10);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(94, 38);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // Lista_itens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(906, 547);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lista_itens";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Lista_itens";
            this.Load += new System.EventHandler(this.Lista_itens_Load);
            ((System.ComponentModel.ISupportInitialize)(Grid_lista_itens)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn profissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dificuldade;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox text_descricao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblFecharPassivas;
        public static System.Windows.Forms.DataGridView Grid_lista_itens;
    }
}