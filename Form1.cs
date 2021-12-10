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

        public Form1()
        {
            InitializeComponent();
            label1.BackColor = Color.FromArgb(15, 39, 45);
            pn_personagens.BackColor = Color.FromArgb(150, Color.Black);
            ficha_resumida.BackColor = Color.FromArgb(50, Color.Black);
            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
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
            comi.CommandText = "select forca, destreza, vigor, carisma, raciocinio, magia, nome_personagem, classe_personagem from \"Dark_Age_Connection\".\"Personagens\" where fk_id_jogador = @jogador";
            comi.Parameters.AddWithValue("@jogador", Login.jogador);
            NpgsqlDataReader nds = comi.ExecuteReader();


            if (nds.Read())
            {
                res_forca.Text = nds.GetValue(0).ToString();
                res_destreza.Text = nds.GetValue(1).ToString();
                res_vigor.Text = nds.GetValue(2).ToString();
                res_vigor.Text = nds.GetValue(3).ToString();
                res_raciocinio.Text = nds.GetValue(4).ToString();
                res_magia.Text = nds.GetValue(5).ToString();
            }


                NpgsqlConnection conn2 = new NpgsqlConnection("Server=localhost;Port=5432;Database=DarkAge_Server;user Id=João;Password=AEsrNA95");
            conn2.Open();
            NpgsqlCommand comt = new NpgsqlCommand();
            comt.Connection = conn2;
            comt.CommandType = CommandType.Text; 
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = @ataque and fk_id_personagem = @personagem";
            
            
            comt.Parameters.AddWithValue("@ataque", 1);
            comt.Parameters.AddWithValue("@personagem",Ficha.idpersonagem);
            NpgsqlDataReader ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_ataque = (int)ndp.GetValue(0);
                res_ataque.Text = Ficha.bd_ataque.ToString();
            }
            ndp.Close();
            comt.Parameters.AddWithValue("@ataque", 2);
            comt.Parameters.AddWithValue("@personagem", Ficha.idpersonagem);
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_esquiva = (int)ndp.GetValue(0);
                res_esquiva.Text = Ficha.bd_esquiva.ToString();
            }
            ndp.Close();
            comt.Parameters.AddWithValue("@ataque", 3);
            comt.Parameters.AddWithValue("@personagem", Ficha.idpersonagem);
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_defesa = (int)ndp.GetValue(0);
                res_defesa.Text = Ficha.bd_defesa.ToString();
            }
            ndp.Close();
            comt.Parameters.AddWithValue("@ataque", 4);
            comt.Parameters.AddWithValue("@personagem", Ficha.idpersonagem);
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_contra_atq = (int)ndp.GetValue(0);
                res_contrataque.Text = Ficha.bd_contra_atq.ToString();
            }
            ndp.Close();
            comt.Parameters.AddWithValue("@ataque", 5);
            comt.Parameters.AddWithValue("@personagem", Ficha.idpersonagem);
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_arematirar = (int)ndp.GetValue(0);
                res_atirar.Text = Ficha.bd_arematirar.ToString();
            }
            ndp.Close();
            comt.Parameters.AddWithValue("@ataque", 6);
            comt.Parameters.AddWithValue("@personagem", Ficha.idpersonagem);
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_lancarmagia = (int)ndp.GetValue(0);
                res_conjurar.Text = Ficha.bd_lancarmagia.ToString();
            }
            ndp.Close();
            comt.Parameters.AddWithValue("@ataque", 7);
            comt.Parameters.AddWithValue("@personagem", Ficha.idpersonagem);
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_labia = (int)ndp.GetValue(0);
                res_labia.Text = Ficha.bd_labia.ToString();
            }
            ndp.Close();
            comt.Parameters.AddWithValue("@ataque", 8);
            comt.Parameters.AddWithValue("@personagem", Ficha.idpersonagem);
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_intimidacao = (int)ndp.GetValue(0);
                res_intimidacao.Text = Ficha.bd_intimidacao.ToString();
            }
            ndp.Close();
            comt.Parameters.AddWithValue("@ataque", 9);
            comt.Parameters.AddWithValue("@personagem", Ficha.idpersonagem);
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_seduzir = (int)ndp.GetValue(0);
                res_seducao.Text = Ficha.bd_seduzir.ToString();
            }
            ndp.Close();
            comt.Parameters.AddWithValue("@ataque", 10);
            comt.Parameters.AddWithValue("@personagem", Ficha.idpersonagem);
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_enganacao = (int)ndp.GetValue(0);
                res_enganacao.Text = Ficha.bd_enganacao.ToString();
            }
            ndp.Close();
            comt.Parameters.AddWithValue("@ataque", 11);
            comt.Parameters.AddWithValue("@personagem", Ficha.idpersonagem);
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_esconder = (int)ndp.GetValue(0);
                res_esconder.Text = Ficha.bd_esconder.ToString();
            }
            ndp.Close();
            comt.Parameters.AddWithValue("@ataque", 12);
            comt.Parameters.AddWithValue("@personagem", Ficha.idpersonagem);
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_percepcao = (int)ndp.GetValue(0);
                res_percepcao.Text = Ficha.bd_percepcao.ToString();
            }
            ndp.Close();
            comt.Parameters.AddWithValue("@ataque", 13);
            comt.Parameters.AddWithValue("@personagem", Ficha.idpersonagem);
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_academicos = (int)ndp.GetValue(0);
                res_academicos.Text = Ficha.bd_academicos.ToString();
            }
            ndp.Close();
            comt.Parameters.AddWithValue("@ataque", 14);
            comt.Parameters.AddWithValue("@personagem", Ficha.idpersonagem);
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_ocultismo = (int)ndp.GetValue(0);
                res_ocultismo.Text = Ficha.bd_ocultismo.ToString();
            }
            ndp.Close();
            comt.Parameters.AddWithValue("@ataque", 15);
            comt.Parameters.AddWithValue("@personagem", Ficha.idpersonagem);
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_sobrevivencia = (int)ndp.GetValue(0);
                res_sobrevivencia.Text = Ficha.bd_sobrevivencia.ToString();
            }
            ndp.Close();
            comt.Parameters.AddWithValue("@ataque", 16);
            comt.Parameters.AddWithValue("@personagem", Ficha.idpersonagem);
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_investigacao = (int)ndp.GetValue(0);
                res_investigacao.Text = Ficha.bd_investigacao.ToString();
            }
            ndp.Close();
            comt.Parameters.AddWithValue("@ataque", 17);
            comt.Parameters.AddWithValue("@personagem", Ficha.idpersonagem);
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_intuicao = (int)ndp.GetValue(0);
                res_intuicao.Text = Ficha.bd_intuicao.ToString();
            }
            ndp.Close();
            comt.Parameters.AddWithValue("@ataque", 18);
            comt.Parameters.AddWithValue("@personagem", Ficha.idpersonagem);
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_etiqueta = (int)ndp.GetValue(0);
                res_etiqueta.Text = Ficha.bd_etiqueta.ToString();
            }
            ndp.Close();
            comt.Parameters.AddWithValue("@ataque", 19);
            comt.Parameters.AddWithValue("@personagem", Ficha.idpersonagem);
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_sanidade = (int)ndp.GetValue(0);
                res_sanidade.Maximum = Ficha.bd_sanidade;
            }
            ndp.Close();
            conn2.Close();
            


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
            this.Refresh();
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
            if (e.KeyCode == Keys.F10)
            {
                if (mudaimagem.Text == "solana")
                {
                    Form1.ActiveForm.BackgroundImage = global::Dark_Age.Properties.Resources.alchemist;
                }
            }
        }
    }
}
