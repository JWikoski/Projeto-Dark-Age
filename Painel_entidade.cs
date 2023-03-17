using Dark_Age.Componente;
using Dark_Age.Controllers;
using Dark_Age.Enteties;
using Npgsql;
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
    public partial class Painel_entidade : Form
    {

        public static int forca;
        public static int destreza;
        public static int vigor;
        public static int carisma;
        public static int raciocinio;
        public static int magia;


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public Painel_entidade(int id_personagem)
        {
            InitializeComponent();
            this.TransparencyKey = Color.Black;
            preenche_atributos(id_personagem);
        }

        public static void preenche_atributos(int id_pers)
        {
            int[] valores = info_entidade.Select_atributos(id_pers, "'S'");
            if (valores != null)
            {
                forca = valores[0];
                destreza = valores[1];
                vigor = valores[2];
                carisma = valores[3];
                raciocinio = valores[4];
                magia = valores[5];
            }
        }
        public static void preencher_talento(int id, string situacao)
        {
            int[] valores = info_entidade.select_talentos(id, situacao);
            if (valores != null)
            {
                Ficha.bd_ataque = valores[0];
                Ficha.bd_esquiva = valores[1];
                Ficha.bd_defesa = valores[2];
                Ficha.bd_contra_atq = valores[3];
                Ficha.bd_arematirar = valores[4];
                Ficha.bd_lancarmagia = valores[5];
                Ficha.bd_labia = valores[6];
                Ficha.bd_intimidacao = valores[7];
                Ficha.bd_seduzir = valores[8];
                Ficha.bd_enganacao = valores[9];
                Ficha.bd_esconder = valores[10];
                Ficha.bd_percepcao = valores[11];
                Ficha.bd_academicos = valores[12];
                Ficha.bd_ocultismo = valores[13];
                Ficha.bd_sobrevivencia = valores[14];
                Ficha.bd_investigacao = valores[15];
                Ficha.bd_intuicao = valores[16];
                Ficha.bd_etiqueta = valores[17];
                Ficha.bd_sanidade = valores[18];
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Painel_entidade_MouseDown(object sender, MouseEventArgs e)
        {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void LblFecharPassivas_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
