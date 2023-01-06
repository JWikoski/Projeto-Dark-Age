using System;
using Dark_Age.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Dark_Age.Controllers
{
    class Formatacao_texto
    {
        public static void negrito(RichTextBox texto)
        {
            //Deixar Texto em Negrito
            int start_bold = texto.Find("B0ld", RichTextBoxFinds.None);
            List<int> lista_loc = new();

            while (start_bold >= 0)
            {

                if (start_bold >= 0)
                {

                    int len = 0;

                    for (int i = 0; i >= 0; i++)
                    {
                        texto.Select(start_bold, i);
                        if (texto.SelectedText.Contains('§') == true)
                        {
                            break;
                        }
                        len++;
                    }

                    //remover "B0ld" e "§"
                    texto.Text = texto.Text.Remove(start_bold, 4);
                    texto.Text = texto.Text.Remove(start_bold + len - 5, 1);

                    //adicionar a localização e o comprimento da(s) palavra(s) numa lista

                    lista_loc.Add(start_bold);
                    lista_loc.Add(len - 4);

                    //lista_loc = (start_bold, comp, start_bold, comp, start_bold, comp, )
                    //                  0        1        2       3         4        5
                }
                start_bold = texto.Find("B0ld", RichTextBoxFinds.None);
            }

            //passar pela lista e deixar tudo em negrito
            for (int i = 0; i < lista_loc.Count; i += 2)
            {
                start_bold = lista_loc[i];
                int comp = lista_loc[i + 1];

                texto.Select(start_bold, comp);
                texto.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            }
        }

        public static List<int> Valores_Dados(string dado)
        {
            List<int> lista = new() { Convert.ToInt32(dado.Split('d', ' ')[0]) , Convert.ToInt32(dado.Split('d', ' ')[1]) };

            return lista;
        }
    }
}
