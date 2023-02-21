using Dark_Age.Componente;
using Dark_Age.Controllers;
using Dark_Age.Enteties;
using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Dark_Age
{
	public partial class Chat : Form
	{
		public int Id_entidade { get; set; }
		public int Id_entidade_privada { get; set; }

		public int count_novo, count_antigo, distancia;
		public Chat()
		{
			InitializeComponent();
		}
		public void teste_scroll()
		{

		}
		public Chat(int id_entidade = 0, int id_entidade_privada = 0)
		{
			Id_entidade = id_entidade;
			Id_entidade_privada = id_entidade_privada;
		}

		private void iconButton1_Click(object sender, EventArgs e)
		{
			if (pnl_insanidade.Visible == false)
			{
				pnl_insanidade.Visible = true;
			}else
			{
				pnl_insanidade.Visible = false;
			}			
		}

		private void btn_dadod20_Click(object sender, EventArgs e)
		{

		}

		private void Chat_Load(object sender, EventArgs e)
		{
			checaguem_criacao_msg();
		}

		public void checaguem_criacao_msg()
		{
			DataTable ndv = Conexao_BD.select_mensagens_chat(Id_entidade, Campanha.id_campanha, Id_entidade_privada);
			count_novo = ndv.Rows.Count;
			if (count_novo > count_antigo)
			{
				pnl_mensagens.VerticalScroll.Value = pnl_mensagens.VerticalScroll.Maximum;
				for (int i = count_antigo; i < count_novo; i++)
				{
					DataRow registros = ndv.Rows[i];
					carregar_msg_pnl(registros);
				}
				if (distancia > pnl_mensagens.Height)
				{
					distancia = pnl_mensagens.Height;
				}
				pnl_mensagens.VerticalScroll.Value = pnl_mensagens.VerticalScroll.Maximum;
				count_antigo = count_novo;
			}
		}

		public void carregar_msg_pnl(DataRow ndv)
		{
			mensagem_chat m_chat = new mensagem_chat();
			m_chat.Nome_personagem = ndv["nome_pers"].ToString();
			m_chat.Mensagem = ndv["mensagem_c"].ToString();
			m_chat.Hora = Convert.ToDateTime(ndv["data_hora_c"]).ToString("HH:mm:ss");
			m_chat.Tipo_dado = ndv["dado_tipo"].ToString();
			m_chat.preencher_info();
			m_chat.Dock = DockStyle.None;
			m_chat.Top = distancia;
			pnl_mensagens.Controls.Add(m_chat);
			distancia += m_chat.Height;
		}

	}
}
