using Dark_Age.Componente;
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
        public string nome_c = "Teste nome João é lixo";
        public string nome_p = "Teste classe João é lixo";
        public string nome_u = "Teste nome user João é lixo";
        public teste()
        {
            InitializeComponent();
        }

        private void teste_Load(object sender, EventArgs e)
        {
           // label_com_image1.receber_valores(nome_c, nome_p, nome_u);
        }
    }
}
