using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Dark_Age
{
    public partial class Habilidades_passivas : Form
    {
        public string passivas = "";
        public string ativas = "";
        
        public Habilidades_passivas()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=26.45.149.194;Port=5432;Database=DarkAge_Server;user Id=João;Password=ANlsPD80");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select passivas, ativas from \"Dark_Age_Connection\".\"Personagens\" where fk_id_jogador = @jogador";
            comm.Parameters.AddWithValue("@jogador", Login.jogador);
            NpgsqlDataReader nda = comm.ExecuteReader();


            if (nda.Read())
            {
                passivas = nda.GetValue(0).ToString();
                label2.Text = nda.GetValue(0).ToString();
                txt_passivas.Text = nda.GetValue(0).ToString();

                ativas = nda.GetValue(1).ToString();
                label3.Text = nda.GetValue(1).ToString();
                txt_ativas.Text = nda.GetValue(1).ToString();
            }

            comm.Dispose();
            conn.Close();

        }

        private void Habilidades_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0

            timer1.Interval = 5;  //we'll increase the opacity every 10ms
            timer1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            timer1.Start();
        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                timer1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.1;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LblFecharPassivas_MouseHover(object sender, EventArgs e)
        {

            LblFecharPassivas.BackColor = Color.FromArgb(25, Color.LightGray);

        }

        private void LblFecharPassivas_MouseLeave(object sender, EventArgs e)
        {

            LblFecharPassivas.BackColor = Color.Transparent;

        }
        private void txt_passivas_TextChanged(object sender, EventArgs e)
        {
            passivas = txt_passivas.Text;
            label2.Text = passivas;
            txt_passivas.Text = passivas;

        }

        private void LblFecharLogin_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=26.45.149.194;Port=5432;Database=DarkAge_Server;user Id=João;Password=ANlsPD80");
            conn.Open();
            NpgsqlCommand coss = new NpgsqlCommand();
            coss.Connection = conn;
            coss.CommandType = CommandType.Text;
            coss.CommandText = "update \"Dark_Age_Connection\".\"Personagens\" set passivas = @passivas where fk_id_jogador = @jogador";
            coss.Parameters.AddWithValue("@jogador", Login.jogador);
            coss.Parameters.AddWithValue("@passivas", passivas);
            NpgsqlDataReader nda = coss.ExecuteReader();
            coss.Dispose();

            conn.Close();

            NpgsqlConnection cont = new NpgsqlConnection("Server=26.45.149.194;Port=5432;Database=DarkAge_Server;user Id=João;Password=ANlsPD80");
            cont.Open();
            NpgsqlCommand cosa = new NpgsqlCommand();
            cosa.Connection = cont;
            cosa.CommandType = CommandType.Text;
            cosa.CommandText = "update \"Dark_Age_Connection\".\"Personagens\" set ativas = @ativas where fk_id_jogador = @jogador";
            cosa.Parameters.AddWithValue("@jogador", Login.jogador);
            cosa.Parameters.AddWithValue("@ativas", ativas);
            NpgsqlDataReader ndf = cosa.ExecuteReader();
            cosa.Dispose();




            cont.Close();
            this.Close();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Editar_CheckedChanged(object sender, EventArgs e)
        {
            if (Editar.Checked)
            {
                txt_passivas.Enabled = true;
                txt_passivas.Height = 1000;
             }
            else
            {
                txt_passivas.Enabled = false;

                txt_passivas.Height = 23;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Editar2.Checked)
            {
                txt_ativas.Enabled = true;
                txt_ativas.Height = 1000;
            }
            else
            {
                txt_ativas.Enabled = false;

                txt_ativas.Height = 23;
            }
        }

        private void txt_passivas2_TextChanged(object sender, EventArgs e)
        {
            ativas = txt_ativas.Text;
            label3.Text = ativas;
            txt_ativas.Text = ativas;
        }
    }
}
