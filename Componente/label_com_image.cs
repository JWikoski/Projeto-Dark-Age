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
    public partial class label_com_image : UserControl
    {
        public label_com_image()
        {
            InitializeComponent();
        }


        public System.Windows.Forms.Control receber_valores( string nome_p, string nome_c, string nome_u, Image image_p)
        {
            nome_perso.Text = nome_p.ToString();
            nome_classe.Text = nome_c.ToString();
            nome_user.Text = nome_u.ToString();
            image_pers.Image = image_p;
            return null;
            //   image_pers.Image = nome_p.Image; PictureBox image_p,
        }

        private void label_com_image_Load(object sender, EventArgs e)
        {
            
        }
    }
}
