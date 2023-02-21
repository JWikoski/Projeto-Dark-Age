namespace Dark_Age.Componente
{
	partial class mensagem_chat
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
			this.pnl_color = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbl_tipo = new System.Windows.Forms.Label();
			this.lbl_mensagem = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbl_hora = new System.Windows.Forms.Label();
			this.lbl_nome_pers = new System.Windows.Forms.Label();
			this.pnl_color.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnl_color
			// 
			this.pnl_color.AutoSize = true;
			this.pnl_color.BackColor = System.Drawing.Color.Black;
			this.pnl_color.Controls.Add(this.panel1);
			this.pnl_color.Controls.Add(this.panel2);
			this.pnl_color.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_color.Location = new System.Drawing.Point(0, 0);
			this.pnl_color.MaximumSize = new System.Drawing.Size(427, 0);
			this.pnl_color.MinimumSize = new System.Drawing.Size(427, 64);
			this.pnl_color.Name = "pnl_color";
			this.pnl_color.Size = new System.Drawing.Size(427, 68);
			this.pnl_color.TabIndex = 0;
			this.pnl_color.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_color_Paint);
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.lbl_tipo);
			this.panel1.Controls.Add(this.lbl_mensagem);
			this.panel1.Location = new System.Drawing.Point(138, 2);
			this.panel1.MaximumSize = new System.Drawing.Size(284, 0);
			this.panel1.MinimumSize = new System.Drawing.Size(284, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(284, 63);
			this.panel1.TabIndex = 2;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// lbl_tipo
			// 
			this.lbl_tipo.ForeColor = System.Drawing.Color.White;
			this.lbl_tipo.Location = new System.Drawing.Point(6, 1);
			this.lbl_tipo.Name = "lbl_tipo";
			this.lbl_tipo.Size = new System.Drawing.Size(274, 19);
			this.lbl_tipo.TabIndex = 6;
			this.lbl_tipo.Text = "Iniciativa";
			this.lbl_tipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_mensagem
			// 
			this.lbl_mensagem.AutoSize = true;
			this.lbl_mensagem.ForeColor = System.Drawing.Color.White;
			this.lbl_mensagem.Location = new System.Drawing.Point(6, 20);
			this.lbl_mensagem.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
			this.lbl_mensagem.MaximumSize = new System.Drawing.Size(274, 0);
			this.lbl_mensagem.MinimumSize = new System.Drawing.Size(274, 0);
			this.lbl_mensagem.Name = "lbl_mensagem";
			this.lbl_mensagem.Size = new System.Drawing.Size(274, 30);
			this.lbl_mensagem.TabIndex = 5;
			this.lbl_mensagem.Text = "A mensagem vai aparecer aqui uma texto \r\nA mensagem vai aparecer aqui uma texto \r" +
	"\n";
			this.lbl_mensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.AutoSize = true;
			this.panel2.Controls.Add(this.lbl_hora);
			this.panel2.Controls.Add(this.lbl_nome_pers);
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.MaximumSize = new System.Drawing.Size(126, 0);
			this.panel2.MinimumSize = new System.Drawing.Size(126, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(126, 58);
			this.panel2.TabIndex = 4;
			// 
			// lbl_hora
			// 
			this.lbl_hora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_hora.ForeColor = System.Drawing.Color.White;
			this.lbl_hora.Location = new System.Drawing.Point(3, 0);
			this.lbl_hora.Name = "lbl_hora";
			this.lbl_hora.Size = new System.Drawing.Size(125, 23);
			this.lbl_hora.TabIndex = 2;
			this.lbl_hora.Text = "12:00";
			this.lbl_hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_nome_pers
			// 
			this.lbl_nome_pers.AutoSize = true;
			this.lbl_nome_pers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_nome_pers.ForeColor = System.Drawing.Color.White;
			this.lbl_nome_pers.Location = new System.Drawing.Point(3, 28);
			this.lbl_nome_pers.MaximumSize = new System.Drawing.Size(123, 0);
			this.lbl_nome_pers.MinimumSize = new System.Drawing.Size(123, 0);
			this.lbl_nome_pers.Name = "lbl_nome_pers";
			this.lbl_nome_pers.Size = new System.Drawing.Size(123, 30);
			this.lbl_nome_pers.TabIndex = 3;
			this.lbl_nome_pers.Text = "Nome Do personagem";
			this.lbl_nome_pers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mensagem_chat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.pnl_color);
			this.Name = "mensagem_chat";
			this.Size = new System.Drawing.Size(427, 68);
			this.pnl_color.ResumeLayout(false);
			this.pnl_color.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnl_color;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbl_hora;
		private System.Windows.Forms.Label lbl_nome_pers;
		private System.Windows.Forms.Label lbl_mensagem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbl_tipo;
	}
}