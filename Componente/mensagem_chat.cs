using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dark_Age.Componente
{
	public partial class mensagem_chat : UserControl
	{
		public string Mensagem { get; set; }
		public string Hora { get; set; }
		public string Nome_personagem { get; set; }
		public string? Tipo_dado { get; set; }

		public mensagem_chat(string mensagem, string hora, string nome_personagem, string tipo_dado)
		{
			Mensagem = mensagem;
			Hora = hora;
			Nome_personagem = nome_personagem;
			Tipo_dado = tipo_dado;
		}


		public mensagem_chat()
		{
			InitializeComponent();
			pnl_color.BackColor = Temas.cor_principal_secundaria;
			pnl_color.ForeColor = System.Drawing.Color.White;
			pnl_color.BorderStyle = BorderStyle.FixedSingle;
			//lbl_hora.ForeColor = Color.Bott;
			//lbl_nome_pers.ForeColor = cor_escrita;
			//lbl_mensagem.ForeColor = cor_fundo;
		}

		public void preencher_info()
		{
			lbl_mensagem.Text = Mensagem;
			lbl_hora.Text = Hora;
			lbl_nome_pers.Text = Nome_personagem;
			lbl_tipo.Text = Tipo_dado ?? "";
			if(Tipo_dado != "")
            {
				lbl_mensagem.Font = new Font("Segoe UI", 15);
            }
            else
            {
				lbl_mensagem.Font = new Font("Segoe UI", 11);
			}
		}

		public void alterar_cor(Color cor_fundo, Color cor_escrita)
		{
			pnl_color.BackColor = cor_fundo;
			lbl_hora.ForeColor = cor_escrita;
			lbl_nome_pers.ForeColor = cor_escrita;
			lbl_mensagem.ForeColor = cor_fundo;
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			panel1.BorderStyle = BorderStyle.None;
			Pen pen = new Pen(Color.White, 1);
			e.Graphics.DrawLine(pen, new Point(0, 0), new Point(0, panel1.Height));

		}

		private void pnl_color_Paint(object sender, PaintEventArgs e)
		{
			/*
			int borderThickness = 2; // espessura da borda em pixels
			Pen borderPen = new Pen(Color.White, borderThickness); // cria uma caneta para desenhar a borda

			// desenha a borda no topo do Panel
			int x1 = 0, y1 = 0, x2 = pnl_color.Width, y2 = borderThickness / 2;
			e.Graphics.DrawLine(borderPen, x1, y1, x2, y2);

			// desenha a borda no fundo do Panel
			x1 = 0; y1 = pnl_color.Height - borderThickness / 2; x2 = pnl_color.Width; y2 = pnl_color.Height;
			e.Graphics.DrawLine(borderPen, x1, y1, x2, y2);*/
		}
	}
}
