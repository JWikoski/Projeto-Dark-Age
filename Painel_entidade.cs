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
using System.Windows.Controls;
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
        public static byte[] img_NPC;
        public static string caracteristicas;
        public static int id_pers;


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public Painel_entidade(int id_personagem, string nome_perso)
        {
            InitializeComponent();
            this.TransparencyKey = Color.Black;
            preenche_atributos(id_personagem);

            id_pers = id_personagem;

            lbl_nome_perso.Text = nome_perso;

            info_entidade.imagem_NPC(id_personagem);
            image_pers.Image = byte_image.byteArrayToImage(img_NPC);

            lbl_forca.Text = "Força: " + forca;
            lbl_dest.Text = "Destreza: " + destreza;
            lbl_magia.Text = "Magia: " + magia;
            lbl_caris.Text = "Carisma: " + carisma;
            lbl_raci.Text = "Raciocínio: " + raciocinio;
            lbl_vigor.Text = "Vigor: " + vigor;

            if (Pagina_mestre.tipo == 3)
            {
                pnl_talento.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = true;
                textBox2.Text = caracteristicas;
            }
            else
            {
                preencher_talento(id_personagem, "'S'");
                res_ataque.Text = "Ataque: " + Ficha.bd_ataque;
                res_esquiva.Text = "Esquiva: " + Ficha.bd_esquiva;
                res_defesa.Text = "Defesa: " + Ficha.bd_defesa;
                res_contrataque.Text = "Contra Atq: " + Ficha.bd_contra_atq;
                res_atirar.Text = "Atirar: " + Ficha.bd_arematirar;
                res_conjurar.Text = "Conjurar: " + Ficha.bd_lancarmagia;
                res_labia.Text = "Lábia: " + Ficha.bd_labia;
                res_intimidacao.Text = "Intimidação: " + Ficha.bd_intimidacao;
                res_enganacao.Text = "Enganação: " + Ficha.bd_seduzir;
                res_roubo.Text = "Roubo: " + Ficha.bd_enganacao;
                res_esconder.Text = "Esconder: " + Ficha.bd_esconder;
                res_percepcao.Text = "Escu/Obs: " + Ficha.bd_percepcao;
                res_acad.Text = "Acad/Med: " + Ficha.bd_academicos;
                res_ocultismo.Text = "Ocultismo: " + Ficha.bd_ocultismo;
                res_sobrevivencia.Text = "Sobrevivência: " + Ficha.bd_sobrevivencia;
                res_investigacao.Text = "Investigação: " + Ficha.bd_investigacao;
                res_intuicao.Text = "Intuição: " + Ficha.bd_intuicao;
                res_etiqueta.Text = "Etiqueta: " + Ficha.bd_etiqueta;

                textBox1.Text = caracteristicas;
            }
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

        private void Editar_Click(object sender, EventArgs e)
        {
            if (Pagina_mestre.tipo == 3)
            {
                caracteristicas = textBox2.Text;
            }
            else
            {
                caracteristicas = textBox1.Text;
            }

            NpgsqlConnection conn = new NpgsqlConnection(Conexao_BD.Caminho_DB());
            conn.Open();
            NpgsqlCommand coss = new NpgsqlCommand();
            coss.Connection = conn;
            coss.CommandType = CommandType.Text;
            coss.CommandText = "update \"Dark_Age_Connection\".\"Personagens\" set anotacoes = @anotacoes where id_personagem = @id_personagem";
            coss.Parameters.AddWithValue("@id_personagem", id_pers);
            coss.Parameters.AddWithValue("@anotacoes", caracteristicas);
            coss.ExecuteReader();

            coss.Dispose();
            conn.Close();
        }
    }
}
