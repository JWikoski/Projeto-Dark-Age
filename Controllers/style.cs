using Dark_Age.Componente;
using Dark_Age.Enteties;
using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Net;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Ink;

namespace Dark_Age.Controllers
{
    internal class style
    {
        public static void houver_botao(object sender)
        {
            var button = (Button)sender;
            Color cor = button.ForeColor;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, cor);
        }

    }
}
