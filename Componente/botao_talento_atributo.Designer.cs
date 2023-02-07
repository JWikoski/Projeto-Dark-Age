namespace Dark_Age.Componente
{
	partial class botao_talento_atributo
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
			this.lbl_nome = new System.Windows.Forms.Label();
			this.lbl_valor = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_nome
			// 
			this.lbl_nome.BackColor = System.Drawing.Color.Transparent;
			this.lbl_nome.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_nome.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lbl_nome.Location = new System.Drawing.Point(0, 0);
			this.lbl_nome.Name = "lbl_nome";
			this.lbl_nome.Size = new System.Drawing.Size(92, 46);
			this.lbl_nome.TabIndex = 0;
			this.lbl_nome.Text = "Acadêmicos/ Medicina:";
			this.lbl_nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_valor
			// 
			this.lbl_valor.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_valor.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lbl_valor.Location = new System.Drawing.Point(95, 0);
			this.lbl_valor.Margin = new System.Windows.Forms.Padding(0);
			this.lbl_valor.Name = "lbl_valor";
			this.lbl_valor.Size = new System.Drawing.Size(33, 46);
			this.lbl_valor.TabIndex = 1;
			this.lbl_valor.Text = "10";
			this.lbl_valor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// botao_talento_atributo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.lbl_valor);
			this.Controls.Add(this.lbl_nome);
			this.Name = "botao_talento_atributo";
			this.Size = new System.Drawing.Size(128, 46);
			this.Load += new System.EventHandler(this.botao_talento_atributo_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lbl_nome;
		private System.Windows.Forms.Label lbl_valor;
	}
}
