using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Dark_Age.Componente
{
    class Adicionar_habilidade
    {


        public Label gerarTitulo(int num_hab, string titulo)
        {
            Label titulo_hab = new Label();
            titulo_hab.BackColor = Color.Transparent;
            titulo_hab.ForeColor = Color.FromArgb(207, 167, 110);
            titulo_hab.Dock = DockStyle.None;
            titulo_hab.TextAlign = ContentAlignment.TopLeft;
            titulo_hab.Left = 0;
            titulo_hab.Top = 0;
            titulo_hab.MinimumSize = new Size(555, 40);
            titulo_hab.MaximumSize = new Size(555, 40);
            titulo_hab.Text = titulo;

            return titulo_hab;
        }
        public Label gerarTexto(int num_hab, string texto)
        {
            Label texto_hab = new Label();
            texto_hab.BackColor = Color.Transparent;
            texto_hab.ForeColor = Color.FromArgb(160, 155, 140);
            texto_hab.Font = new Font(texto_hab.Font, FontStyle.Bold);
            texto_hab.Dock = DockStyle.None;
            texto_hab.TextAlign = ContentAlignment.TopLeft;
            texto_hab.Left = 0;
            texto_hab.AutoSize = true;
            texto_hab.MinimumSize = new Size(540, 110);
            texto_hab.MaximumSize = new Size(540, 2000);
            texto_hab.Text = texto;

            return texto_hab;
        }


    }
}
