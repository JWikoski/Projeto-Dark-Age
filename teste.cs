using Dark_Age.Componente;
using Dark_Age.Controllers;
using Dark_Age.Enteties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dark_Age
{
	public partial class teste : Form
	{
		public teste()
		{
			InitializeComponent();			
		}

		private void teste_Load(object sender, EventArgs e)
		{
			preencher_informação(1, "'S'");
		}

		public void preencher_informação(int id, string situacao)
		{
			int[] valores = info_entidade.select_talentos(id, situacao);
			if (valores != null)
			{
				btn_ataque.preencher_info("Ataque", valores[0]);
				btn_esquiva.preencher_info("Esquiva", valores[1]);
				btn_defesa.preencher_info("Defesa", valores[2]);
				btn_contra_ataque.preencher_info("Contra Ataque",valores[3]);
				btn_atirar.preencher_info("Atirar",valores[4]);
				btn_conj_magia.preencher_info("Conjurar Magia",valores[5]);
				btn_labia.preencher_info("Lábia", valores[6]);
				btn_intimidacao.preencher_info("Intimidação", valores[7]);
				btn_seducao.preencher_info("Sedução/ Enganação",valores[8]);
				btn_roubo.preencher_info("Roubo", valores[9]);
				btn_esconder.preencher_info("Esconder", valores[10]);
				btn_escutar.preencher_info("Escutar/ Observar", valores[11]);
				btn_academicos.preencher_info("Acadêmicos/ Medicina", valores[12]);
				btn_ocultismo.preencher_info("Ocultismo", valores[13]);
				btn_sobrevivencia.preencher_info("Sobrevivência", valores[14]);
				btn_investigacao.preencher_info("Investigação", valores[15]);
				btn_intuicao.preencher_info("Intuição", valores[16]);
				btn_etiqueta.preencher_info("Etiqueta", valores[17]);
			}

		}

		private void btn_ataque_Click(object sender, EventArgs e)
		{
			botao_talento_atributo btn = (botao_talento_atributo)sender;
			int roll = roll_dados.rolagem_dados(1, 20, btn.Valor);
			Conexao_BD.envia_mensagem_chat(DateTime.Now, roll.ToString(), Campanha.id_entidade, btn.Nome_talento_atributo);
		}

		private void btn_esquiva_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Teste");
		}

		private void btn_ataque_MouseClick(object sender, MouseEventArgs e)
		{
			MessageBox.Show("Teste");
		}

		private void botao_talento_atributo1_Click_M(object sender, EventArgs e)
		{
			botao_talento_atributo btn = (botao_talento_atributo)sender;
			MessageBox.Show("Valor:" + btn.Valor);
		}

		private void botao_talento_atributo2_Click(object sender, EventArgs e)
		{
			botao_talento_atributo btn = (botao_talento_atributo)sender;
			MessageBox.Show("Valor:" + btn.Valor);
		}
	}
}
