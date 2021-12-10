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
    public partial class visualizar_imagem : Form
    {
        public visualizar_imagem()
        {
            InitializeComponent();
        }

        private void visualizar_imagem_Load(object sender, EventArgs e)
        {
            
                if (Form1.texto_imagem == "dracula")
                {
                    this.BackgroundImage = global::Dark_Age.Properties.Resources.castlvania;
                }
                if (Form1.texto_imagem == "lenore")
                {
                    this.BackgroundImage = global::Dark_Age.Properties.Resources.lenore;
                }
                if (Form1.texto_imagem == "por do sol")
                {
                    this.BackgroundImage = global::Dark_Age.Properties.Resources.pordosol;
                }
                if (Form1.texto_imagem == "")
                {
                    this.BackgroundImage = global::Dark_Age.Properties.Resources.castle2;
                }

            
        }

        private void visualizar_imagem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
