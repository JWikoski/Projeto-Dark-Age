namespace Dark_Age
{
    partial class adicionar_editar_itens
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
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.combox_tipo = new System.Windows.Forms.ComboBox();
            this.combox_profissao = new System.Windows.Forms.ComboBox();
            this.combox_dificuldade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Location = new System.Drawing.Point(244, 485);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(112, 29);
            this.btn_finalizar.TabIndex = 0;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(30, 88);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(344, 23);
            this.text_nome.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 274);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(344, 158);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // combox_tipo
            // 
            this.combox_tipo.FormattingEnabled = true;
            this.combox_tipo.Location = new System.Drawing.Point(52, 144);
            this.combox_tipo.Name = "combox_tipo";
            this.combox_tipo.Size = new System.Drawing.Size(121, 23);
            this.combox_tipo.TabIndex = 3;
            this.combox_tipo.SelectedIndexChanged += new System.EventHandler(this.combox_tipo_SelectedIndexChanged);
            // 
            // combox_profissao
            // 
            this.combox_profissao.FormattingEnabled = true;
            this.combox_profissao.Location = new System.Drawing.Point(235, 144);
            this.combox_profissao.Name = "combox_profissao";
            this.combox_profissao.Size = new System.Drawing.Size(121, 23);
            this.combox_profissao.TabIndex = 4;
            this.combox_profissao.SelectedIndexChanged += new System.EventHandler(this.combox_profissao_SelectedIndexChanged);
            this.combox_profissao.Click += new System.EventHandler(this.combox_profissao_Click);
            // 
            // combox_dificuldade
            // 
            this.combox_dificuldade.FormattingEnabled = true;
            this.combox_dificuldade.Location = new System.Drawing.Point(52, 212);
            this.combox_dificuldade.Name = "combox_dificuldade";
            this.combox_dificuldade.Size = new System.Drawing.Size(121, 23);
            this.combox_dificuldade.TabIndex = 5;
            this.combox_dificuldade.SelectedIndexChanged += new System.EventHandler(this.combox_dificuldade_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dificuldade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Profissão:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descrição:";
            // 
            // adicionar_editar_itens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 535);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combox_dificuldade);
            this.Controls.Add(this.combox_profissao);
            this.Controls.Add(this.combox_tipo);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.btn_finalizar);
            this.Name = "adicionar_editar_itens";
            this.Text = "adicionar_editar_itens";
            this.Load += new System.EventHandler(this.adicionar_editar_itens_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox combox_tipo;
        private System.Windows.Forms.ComboBox combox_profissao;
        private System.Windows.Forms.ComboBox combox_dificuldade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}