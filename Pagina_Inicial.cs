using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Dark_Age
{
    public partial class Form1 : Form
    {

        public int valorHabilidade;
        public int expand = 1;
        public static string texto_imagem;
        public Boolean minmax = true;
        public int talento;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = Color.FromArgb(15, 39, 45);
            pn_personagens.BackColor = Color.FromArgb(150, Color.Black);
            ficha_resumida.BackColor = Color.FromArgb(0, Color.Black);
            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            panel6.BackColor = Color.Transparent;
            this.BackColor = Color.FromArgb(14, 40, 52);
            btn_open.BackColor = Color.FromArgb(14, 40, 52);


            if (Ficha.pers_criado == false)
            {
                Ficha frm = new Ficha();
                frm.ShowDialog();

            }
            else
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=DarkAge_Server;user Id=João;Password=AEsrNA95");
                conn.Open();
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "select nome_personagem, classe_personagem, id_personagem from \"Dark_Age_Connection\".\"Personagens\" where fk_id_jogador = @jogador";
                comm.Parameters.AddWithValue("@jogador", Login.jogador);
                btn_open.Text = "Editar ficha do personagem";

                NpgsqlDataReader nda = comm.ExecuteReader();

                if (nda.Read())
                {
                    personagem1.Text = (string)nda.GetValue(0);
                    bemvindo.Text = "Bem Vindo, " + nda.GetValue(0) + "!";
                    classe_jogador1.Text = nda.GetValue(1).ToString();
                    Ficha.idpersonagem = (int)nda.GetValue(2);
                }

                conn.Close();


                conn.Open();
                NpgsqlCommand comj = new NpgsqlCommand();
                comj.Connection = conn;
                comj.CommandType = CommandType.Text;
                comj.CommandText = "select nome_jogador from \"Dark_Age_Connection\".\"Jogadores\" where id_jogador = @jogador";
                comj.Parameters.AddWithValue("@jogador", Login.jogador);


                string ndj = (string)comj.ExecuteScalar();

                jogador1.Text = ndj;
                conn.Close();

            }
            NpgsqlConnection conn3 = new NpgsqlConnection("Server=localhost;Port=5432;Database=DarkAge_Server;user Id=João;Password=AEsrNA95");
            conn3.Open();
            NpgsqlCommand comi = new NpgsqlCommand();
            comi.Connection = conn3;
            comi.CommandType = CommandType.Text;
            comi.CommandText = "select forca, destreza, vigor, carisma, raciocinio, magia from \"Dark_Age_Connection\".\"Personagens\" where fk_id_jogador = @jogador";
            comi.Parameters.AddWithValue("@jogador", Login.jogador);
            NpgsqlDataReader nds = comi.ExecuteReader();


            if (nds.Read())
            {
                res_forca.Text = nds.GetValue(0).ToString();
                res_destreza.Text = nds.GetValue(1).ToString();
                res_vigor.Text = nds.GetValue(2).ToString();
                res_carisma.Text = nds.GetValue(3).ToString();
                res_raciocinio.Text = nds.GetValue(4).ToString();
                res_magia.Text = nds.GetValue(5).ToString();
            }


                NpgsqlConnection conn2 = new NpgsqlConnection("Server=localhost;Port=5432;Database=DarkAge_Server;user Id=João;Password=AEsrNA95");
            conn2.Open();
            NpgsqlCommand comt = new NpgsqlCommand();
            comt.Connection = conn2;
            comt.CommandType = CommandType.Text; 
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 1 and fk_id_personagem = @personagem";
            comt.Parameters.AddWithValue("@talento", talento);
            comt.Parameters.AddWithValue("@personagem",Ficha.idpersonagem);
            
            NpgsqlDataReader ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_ataque = (int)ndp.GetValue(0);
                res_ataque.Text = Ficha.bd_ataque.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 2 and fk_id_personagem = @personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_esquiva = (int)ndp.GetValue(0);
                res_esquiva.Text = Ficha.bd_esquiva.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 3 and fk_id_personagem = @personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_defesa = (int)ndp.GetValue(0);
                res_defesa.Text = Ficha.bd_defesa.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 4 and fk_id_personagem = @personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_contra_atq = (int)ndp.GetValue(0);
                res_contrataque.Text = Ficha.bd_contra_atq.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 5 and fk_id_personagem = @personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_arematirar = (int)ndp.GetValue(0);
                res_atirar.Text = Ficha.bd_arematirar.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 6 and fk_id_personagem = @personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_lancarmagia = (int)ndp.GetValue(0);
                res_conjurar.Text = Ficha.bd_lancarmagia.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 7 and fk_id_personagem = @personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_labia = (int)ndp.GetValue(0);
                res_labia.Text = Ficha.bd_labia.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 8 and fk_id_personagem = @personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_intimidacao = (int)ndp.GetValue(0);
                res_intimidacao.Text = Ficha.bd_intimidacao.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 9 and fk_id_personagem = @personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_seduzir = (int)ndp.GetValue(0);
                res_seducao.Text = Ficha.bd_seduzir.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 10 and fk_id_personagem = @personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_enganacao = (int)ndp.GetValue(0);
                res_enganacao.Text = Ficha.bd_enganacao.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 11 and fk_id_personagem = @personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_esconder = (int)ndp.GetValue(0);
                res_esconder.Text = Ficha.bd_esconder.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 12 and fk_id_personagem = @personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_percepcao = (int)ndp.GetValue(0);
                res_percepcao.Text = Ficha.bd_percepcao.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 13 and fk_id_personagem = @personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_academicos = (int)ndp.GetValue(0);
                res_acad.Text = Ficha.bd_academicos.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 14 and fk_id_personagem = @personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_ocultismo = (int)ndp.GetValue(0);
                res_ocultismo.Text = Ficha.bd_ocultismo.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 15 and fk_id_personagem = @personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_sobrevivencia = (int)ndp.GetValue(0);
                res_sobrevivencia.Text = Ficha.bd_sobrevivencia.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 16 and fk_id_personagem = @personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_investigacao = (int)ndp.GetValue(0);
                res_investigacao.Text = Ficha.bd_investigacao.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 17 and fk_id_personagem = @personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_intuicao = (int)ndp.GetValue(0);
                res_intuicao.Text = Ficha.bd_intuicao.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 18 and fk_id_personagem = @personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_etiqueta = (int)ndp.GetValue(0);
                res_etiqueta.Text = Ficha.bd_etiqueta.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 19 and fk_id_personagem = @personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_sanidade = (int)ndp.GetValue(0);
                res_sanidade.Maximum = Ficha.bd_sanidade;
                res_sanidade.Value = Ficha.bd_sanidade;
            }
            ndp.Dispose();
            conn2.Close();
            


        }
        

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            
            Ficha frm = new Ficha();
            frm.ShowDialog();
            this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_open_MouseHover(object sender, EventArgs e)
        {
            Task.Delay(150).Wait();
            btn_open.ForeColor = Color.White;
            btn_open.ImageAlign = ContentAlignment.MiddleCenter;
        }

        private void btn_open_MouseLeave(object sender, EventArgs e)
        {
            Task.Delay(175).Wait();
            btn_open.ForeColor = Color.Silver;
            btn_open.ImageAlign = ContentAlignment.MiddleRight;
        }

        private void btn_open_MouseEnter(object sender, EventArgs e)
        {
            Task.Delay(150).Wait();
            btn_open.ForeColor = Color.White;
            btn_open.ImageAlign = ContentAlignment.MiddleCenter;
        }
        private void btn_change_MouseHover(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, Color.White);
        }

        private void btn_change_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, Color.White);
        }

        private void btn_change_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.Transparent;
        }

        private void btn_change_MouseDown(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, Color.White);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("!(1d20+"+res_forca.Text+"+"+modificador.Text+")");
        }

        private void btn_cria_personagem_Click(object sender, EventArgs e)
        {
            Habilidades_passivas frm = new Habilidades_passivas();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Habilidades_ativas frn = new Habilidades_ativas();
            frn.ShowDialog();
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                texto_imagem = mudaimagem.Text;
                if (mudaimagem.Text == "dracula")
                {
                    Locais.BackgroundImage = global::Dark_Age.Properties.Resources.castlvania;
                }
                if (mudaimagem.Text == "lenore")
                {
                    Locais.BackgroundImage = global::Dark_Age.Properties.Resources.lenore;
                    
                }
                if (mudaimagem.Text == "por do sol")
                {
                    Form1.ActiveForm.BackgroundImage = global::Dark_Age.Properties.Resources.pordosol;
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackgroundImage = global::Dark_Age.Properties.Resources.image;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackgroundImage = global::Dark_Age.Properties.Resources.castle2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackgroundImage = global::Dark_Age.Properties.Resources.pordosol;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackgroundImage = global::Dark_Age.Properties.Resources.k7wvl1;
        }

        private void Locais_Click(object sender, EventArgs e)
        {
            visualizar_imagem vimg = new visualizar_imagem();
           vimg.ShowDialog();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Inventario vinv = new Inventario();
            vinv.ShowDialog();
        }


        private void Label28_Click(object sender, EventArgs e)
        {
            if (minmax == true)
            {
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();
                label28.Image = global::Dark_Age.Properties.Resources.maxscreen2;
                minmax = false;
                panel8.Enabled = true;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                label28.Image = global::Dark_Age.Properties.Resources.minimizar;
                minmax = true;
                panel8.Enabled = false;
            }
        }
        private void label29_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LblFecharPassivas_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LblFecharPassivas_MouseHover(object sender, EventArgs e)
        {

            var label = (Label)sender;
            label.BackColor = Color.FromArgb(25, Color.LightGray);

        }
        private void LblFecharPassivas_MouseEnter(object sender, EventArgs e)
        {
            var label = (Label)sender;
            label.BackColor = Color.FromArgb(20, Color.White);
        }

        private void LblFecharPassivas_MouseLeave(object sender, EventArgs e)
        {
            var label = (Label)sender;
            label.BackColor = Color.Transparent;

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
