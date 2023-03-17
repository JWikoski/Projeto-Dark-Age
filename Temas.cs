using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dark_Age.Componente;
using Dark_Age.Controllers;
using Dark_Age.Enteties;

namespace Dark_Age
{
    public partial class Temas : Form
    {
        public static Color cor_principal = Color.FromArgb(130, 146, 182);
        public static Color cor_escura = Color.FromArgb(10, 16, 20);
        public static Color cor_clara = Color.FromArgb(130, 146, 182);
        public static Color cor_principal_secundaria = Color.FromArgb(110, 126, 162);
        public static Color cor_escura_secundaria = Color.FromArgb(18, 18, 27);
        public static Color cor_clara_secundaria = Color.FromArgb(110, 126, 162);
        public static Boolean tema_claro, tema_escuro;

        public Temas()
        {
            InitializeComponent();
        }
        
        private void Temas_Load(object sender, EventArgs e)
        {

        }
        public static void mudar_cor_fundo(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = cor_principal_secundaria;
            button.FlatAppearance.BorderColor = cor_principal_secundaria;
        }
        public static void mudar_cor_data_grid(DataGridView e)
        {
            e.BackgroundColor = Temas.cor_principal;
            e.ColumnHeadersDefaultCellStyle.BackColor = Temas.cor_principal;
            e.ColumnHeadersDefaultCellStyle.SelectionBackColor = Temas.cor_principal_secundaria;
            e.DefaultCellStyle.BackColor = Temas.cor_principal;
            e.DefaultCellStyle.SelectionBackColor = Temas.cor_principal_secundaria;
            e.RowHeadersDefaultCellStyle.BackColor = Temas.cor_principal;
            e.RowHeadersDefaultCellStyle.SelectionBackColor = Temas.cor_principal_secundaria;
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.BackColor = cor_clara;
            escuro.BackColor = Color.Transparent;
            tema_claro_escolhido();
        }

        public static void tema_escuro_escolhido()
        {
            cor_principal = cor_escura;
            cor_principal_secundaria = cor_escura_secundaria;
            tema_claro = false;
            tema_escuro = true;
        }

        public static void tema_claro_escolhido()
        {
           
            cor_principal = cor_clara;
            cor_principal_secundaria = cor_clara_secundaria;
            tema_claro = true;
            tema_escuro = false;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.BackColor = cor_escura;
            claro.BackColor = Color.Transparent;
            tema_escuro_escolhido();
        }

        private void escuro_MouseLeave(object sender, EventArgs e)
        {
            if(tema_escuro == true)
            {
                escuro.BackColor = cor_principal_secundaria;
                escuro.IconColor = Color.SteelBlue;
            }
            else
            {
                escuro.ForeColor = Color.White;
                escuro.IconColor = Color.White;
            }
            if (tema_claro == true)
            {
                claro.BackColor = cor_principal_secundaria;
                claro.IconColor = Color.Khaki;
            }
            else
            {
                claro.ForeColor = Color.White;
                claro.IconColor = Color.White;
            }

        }

        private void btn_continuar_MouseEnter(object sender, EventArgs e)
        {
            btn_continuar.ForeColor = Color.White;
        }

        private void btn_continuar_MouseLeave(object sender, EventArgs e)
        {
            btn_continuar.ForeColor = Color.Silver;
        }

        private void claro_MouseEnter(object sender, EventArgs e)
        {
            if (tema_claro == true)
            {
                claro.FlatAppearance.MouseOverBackColor = cor_principal_secundaria;
            }
            else
            {
                claro.FlatAppearance.MouseOverBackColor = Color.Transparent;
            }
           
            claro.ForeColor = Color.Khaki;
            claro.IconColor = Color.Khaki;
        }

        private void escuro_MouseEnter(object sender, EventArgs e)
        {
            if (tema_escuro == true)
            {
                escuro.FlatAppearance.MouseOverBackColor = cor_principal_secundaria;
            }
            else
            {
                escuro.FlatAppearance.MouseOverBackColor = Color.Transparent;
            }
            escuro.ForeColor = Color.SteelBlue;
            escuro.IconColor = Color.SteelBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tema_claro == false && tema_escuro == false)
            {
                MessageBox.Show("Escolha um tema antes de prosseguir!");
            }
            else { 
            //{
            //    if(tema_claro == true)
            //    {
            //        if (MessageBox.Show("Gostaria de deixar o Tema Escuro como padrão?", "Tema Escuro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //        {
            //            Conexao_BD.update_tema(true);
            //        }
            //        else
            //        {
            //            this.Close();
            //        }
            //    }
            //    else
            //    {
            //        if (MessageBox.Show("Gostaria de deixar o Tema Claro como padrão?", "Tema Claro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //        {
            //            Conexao_BD.update_tema(false);
            //        }
            //        else
            //        {
            //            this.Close();
            //        }
            //    }
                this.Close();
            }
            
        }
    }
}
