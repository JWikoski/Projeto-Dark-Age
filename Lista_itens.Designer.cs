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
            this.Grid_lista_itens = new System.Windows.Forms.DataGridView();
            this.text_descricao = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_lista_itens)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid_lista_itens
            // 
            this.Grid_lista_itens.AllowUserToAddRows = false;
            this.Grid_lista_itens.AllowUserToDeleteRows = false;
            this.Grid_lista_itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_lista_itens.Location = new System.Drawing.Point(3, 100);
            this.Grid_lista_itens.Name = "Grid_lista_itens";
            this.Grid_lista_itens.ReadOnly = true;
            this.Grid_lista_itens.RowTemplate.Height = 25;
            this.Grid_lista_itens.Size = new System.Drawing.Size(519, 536);
            this.Grid_lista_itens.TabIndex = 0;
            this.Grid_lista_itens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_lista_itens_CellClick);
            // 
            // text_descricao
            // 
            this.text_descricao.Location = new System.Drawing.Point(550, 280);
            this.text_descricao.Name = "text_descricao";
            this.text_descricao.Size = new System.Drawing.Size(329, 194);
            this.text_descricao.TabIndex = 1;
            this.text_descricao.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Grid_lista_itens);
            this.panel1.Controls.Add(this.text_descricao);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 636);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lista_itens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 660);
            this.Controls.Add(this.panel1);
            this.Name = "Lista_itens";
            this.Text = "Lista_itens";
            this.Load += new System.EventHandler(this.Lista_itens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_lista_itens)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_lista_itens;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn profissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dificuldade;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox text_descricao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}