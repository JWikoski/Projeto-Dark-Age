using Dark_Age.Componente;
using Dark_Age.Controllers;
using Dark_Age.Enteties;
using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Drawing.Drawing2D;
using Npgsql;
using NpgsqlTypes;

namespace Dark_Age
{
    public partial class Mapa_combate : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        public Boolean atualizar = false;
        public Mapa_combate()
        {
            InitializeComponent();

            btnProfissões.BackColor = Color.FromArgb(10, Color.Black);
            pnl_menu.BackColor = Color.FromArgb(10, Color.Black);
            btn_menu.BackColor = Color.FromArgb(10, Color.Black);


        }

        private void Mapa_combate_Load(object sender, EventArgs e)
        {
            DataTable ndv = Conexao_BD.select_tokens(Campanha.id_campanha);
            foreach (DataRow dr in ndv.Rows)
            {
                PictureBox token = new PictureBox();

                token.BackgroundImageLayout = ImageLayout.Zoom;
                token.Cursor  = Cursors.Hand;
                token.BackColor = Color.FromArgb(15, 15, 15);

                byte[] imagem_byte = ((byte[])dr["imagem"]);
                token.BackgroundImage = byte_image.byteArrayToImage(imagem_byte);

                token.Tag = (int)dr["id_entidade"];
               

                token.Size = new Size(50, 50);

                NpgsqlPoint location = (NpgsqlPoint)dr["local_token"];

                Point coordenada = new Point((int)location.X, (int)location.Y);

                token.Left = (int)coordenada.Y;
                token.Top = (int)coordenada.X;

                if((int)dr["id_personagem"] == Campanha.id_personagem)
                {
                    ControlExtension.Draggable(token, true);
                    token.MouseUp += new MouseEventHandler(this.token_MouseUp);
                    token.MouseDown += new MouseEventHandler(this.token_mouseDown);
                }
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(0, 0, token.Width, token.Height);
                    token.Region = new Region(path);
                }
                this.Controls.Add(token);
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            atualizador_tokens.Stop();
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                atualizador_tokens.Start();
            }
        }
        private void btnProfissões_Click(object sender, EventArgs e)
        {
            visualizar_imagem.imagem_selecionada = global::Dark_Age.Properties.Resources.Castlevania;
            visualizar_imagem imagem = new visualizar_imagem();
            imagem.Show();
        }

        private void token_MouseUp(object sender, MouseEventArgs e)
        {
            var token = (PictureBox)sender;
            if (token.Left < 0)
            {
                token.Left = 0;
            }
            if (token.Top < 0)
            {
                token.Top = 0;
            }
            if (token.Left > 1235)
            {
                token.Left = 1210;
            }
            if (token.Top > 665)
            {
                token.Top = 640;
            }
            atualizar_localizacao(token.Top, token.Left);
            atualizador_tokens.Start();
        }
        public void token_mouseDown(object sender, MouseEventArgs e)
        {
            atualizador_tokens.Stop();
        }

        public void atualizar_localizacao(int top_token, int left_token)
        {
            using NpgsqlConnection conn = new NpgsqlConnection(Conexao_BD.Caminho_DB());
            conn.Open();
            using NpgsqlCommand comt = new NpgsqlCommand();
            comt.Connection = conn;
            comt.CommandType = CommandType.Text;
            comt.CommandText = "update \"Dark_Age_Connection\".\"Personagens\" set local_token = point'("+ top_token + ","+ left_token + ")'" +
                " where id_personagem = "+Campanha.id_personagem+"";
            comt.ExecuteScalar();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if(pnl_menu.Visible == true)
            {
                pnl_menu.Visible = false;
            }
            else
            {
                pnl_menu.Visible = true;
            }
        }

        private void atualizador_tokens_Tick(object sender, EventArgs e)
        {
            DataTable ndv = Conexao_BD.select_tokens(Campanha.id_campanha);

            foreach (DataRow dr in ndv.Rows)
            {
                foreach (Control c in this.Controls)
                {
                    if (c is PictureBox && (int)c.Tag == (int)dr["id_entidade"])
                    {
                        NpgsqlPoint location = (NpgsqlPoint)dr["local_token"];

                        Point coordenada = new Point((int)location.X, (int)location.Y);

                        c.Left = (int)coordenada.Y;
                        c.Top = (int)coordenada.X;
                    }
                }

            }

        }
    }
}
