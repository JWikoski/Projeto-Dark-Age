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
        public Habilidades_passivas()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=DarkAge_Server;user Id=João;Password=AEsrNA95");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select passivas from \"Dark_Age_Connection\".\"Personagens\" where fk_id_jogador = @jogador";
            comm.Parameters.AddWithValue("@jogador", Login.jogador);
            string nda = (string)comm.ExecuteScalar();

            passivas = nda;
            label2.Text = nda;
            txt_passivas.Text = nda;

            comm.Dispose();
            conn.Close();

        }

        private void Habilidades_Load(object sender, EventArgs e)
        {

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
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=DarkAge_Server;user Id=João;Password=AEsrNA95");
            conn.Open();
            NpgsqlCommand coss = new NpgsqlCommand();
            coss.Connection = conn;
            coss.CommandType = CommandType.Text;
            coss.CommandText = "update \"Dark_Age_Connection\".\"Personagens\" set passivas = @passivas";
            coss.Parameters.AddWithValue("@passivas", passivas);
            NpgsqlDataReader nda = coss.ExecuteReader();
            coss.Dispose();
            conn.Close();
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
                txt_passivas2.Enabled = true;
                txt_passivas2.Height = 1000;
            }
            else
            {
                txt_passivas2.Enabled = false;

                txt_passivas2.Height = 23;
            }
        }
    }
}
