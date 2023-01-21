using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark_Age.Controllers
{
	internal class roll_dados
	{
		public static int rolagem_dados(int qtd_dados, int lados, int valor_atribuido)
		{
			int valor_dados = 0;
			for (int i = 0; i < qtd_dados; i++)
			{
				Random random = new Random();
				int roll = random.Next(1, lados + 1);
				valor_dados += roll + valor_atribuido;
			}
			return valor_dados;
		}
	}
}
