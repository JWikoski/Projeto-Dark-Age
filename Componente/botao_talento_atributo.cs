using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Dark_Age.Componente
{
	public partial class botao_talento_atributo : UserControl
	{
		public string Nome_talento_atributo { get; set; }
		public int? Valor { get; set; }
		public botao_talento_atributo()
		{
			InitializeComponent();

		}

		public void preencher_info(string nome_talento_atributo, int? valor)
		{
			Nome_talento_atributo = nome_talento_atributo;
			Valor = valor;
			lbl_nome.Text = Nome_talento_atributo + ":";
			lbl_valor.Text = Valor.ToString();
		}

		private void botao_talento_atributo_Load(object sender, EventArgs e)
		{
		}

        private void lbl_valor_Click(object sender, EventArgs e)
        {
			MessageBox.Show("balita");
        }
    }
}
