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
    public partial class Habilidades_ativas : Form
    {
        public string ativas = "";
        public Habilidades_ativas()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.FromArgb(10, Color.Black);

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=DarkAge_Server;user Id=João;Password=AEsrNA95");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select ativas from \"Dark_Age_Connection\".\"Personagens\" where fk_id_jogador = @jogador";
            comm.Parameters.AddWithValue("@jogador", Login.jogador);
            string nda = (string)comm.ExecuteScalar();

            ativas = nda;
            label2.Text = nda;
            txt_ativas.Text = nda;

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

        private void txt_ativas_TextChanged(object sender, EventArgs e)
        {
            ativas = txt_ativas.Text;
            label2.Text = ativas;
            txt_ativas.Text = ativas;
        }

        private void LblFecharLogin_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=DarkAge_Server;user Id=João;Password=AEsrNA95");
            conn.Open();
            NpgsqlCommand coss = new NpgsqlCommand();
            coss.Connection = conn;
            coss.CommandType = CommandType.Text;
            coss.CommandText = "update \"Dark_Age_Connection\".\"Personagens\" set ativas = @ativas";
            coss.Parameters.AddWithValue("@ativas", ativas);
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
                txt_ativas.Visible = true;
                txt_ativas.Enabled = true;
                txt_ativas.Height = 700;
            }
            else
            {
                txt_ativas.Enabled = false;
                txt_ativas.Visible = false;
                txt_ativas.Height = 23;
            }

        }
    }
}
