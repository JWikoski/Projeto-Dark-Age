using System;
using System.Collections.Generic;
using System.ComponentModel;
using Dark_Age.Componente;
using Dark_Age.Controllers;
using Dark_Age.Enteties;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Dark_Age
{
    public partial class Anotacoes_regras_gerais : Form
    {
        public string anotacoes = "";
        public int navegacao = 1;
        public static string regras;
        public static string sanidades;
        public static int page = 1;
        public Anotacoes_regras_gerais()
        {
            InitializeComponent(); 
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.FromArgb(10, Color.Black);

            NpgsqlConnection conn = new NpgsqlConnection(Conexao_BD.Caminho_DB());
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select anotacoes from \"Dark_Age_Connection\".\"Personagens\" where id_personagem = @id_personagem";
            comm.Parameters.AddWithValue("@id_personagem", Campanha.id_personagem);
            string nda = (string)comm.ExecuteScalar();

            Conexao_BD.Select_Regras(ref regras, ref sanidades);
                lbl_regras.Text = regras;

            anotacoes = nda;
            lbl_anotacoes.Text = nda;
            txt_ativas.Text = nda;
            lbl_descansos.Text = "Descanso curto: \n\r " +
                "Você descansa por 1 hora" +
                "Descanso Logno: \n\r Você descansa uma noite ";

            lbl_anotacoes.Visible = true;
            comm.Dispose();
            conn.Close();
        }

        private void Habilidades_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0

            timer1.Interval = 5;  //we'll increase the opacity every 10ms
            timer1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            timer1.Start();

            panel1.Controls.Add(lbl_descansos);
            panel1.Controls.Add(lbl_anotacoes);
            panel1.Controls.Add(lbl_regras);
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

        private void txt_ativas_TextChanged(object sender, EventArgs e)
        {
            anotacoes = txt_ativas.Text;
            lbl_anotacoes.Text = anotacoes;
            txt_ativas.Text = anotacoes;
        }

        private void LblFecharLogin_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection(Conexao_BD.Caminho_DB());
            conn.Open();
            NpgsqlCommand coss = new NpgsqlCommand();
            coss.Connection = conn;
            coss.CommandType = CommandType.Text;
            coss.CommandText = "update \"Dark_Age_Connection\".\"Personagens\" set anotacoes = @anotacoes where id_personagem = @id_personagem";
            coss.Parameters.AddWithValue("@id_personagem", Campanha.id_personagem);
            coss.Parameters.AddWithValue("@anotacoes", anotacoes);
            coss.ExecuteReader();

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
                txt_ativas.Height = 556;
            }
            else
            {
                txt_ativas.Enabled = false;
                txt_ativas.Visible = false;
                txt_ativas.Height = 23;
            }

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            if(page < 3)
            {
                page += 1;
            }
            seta_esquerda.Visible = true;
            Editar.Visible = false;
            if (page == 3)
            {
                seta_direita.Visible = false;
                pagina.Text = "Descansos";
                lbl_regras.Visible = false;
                lbl_descansos.Visible = true;
            }else if (page == 2)
            {
                pagina.Text = "Regras";
                lbl_anotacoes.Visible = false;
                lbl_regras.Visible = true;
            }
        }

        private void seta_esquerda_Click(object sender, EventArgs e)
        {
            page -= 1;
            if (page == 1)
            {
                seta_esquerda.Visible = false;
                pagina.Text = "Anotações";
                Editar.Visible = true;
                lbl_regras.Visible = false;
                lbl_descansos.Visible = false;
                lbl_anotacoes.Visible = true;
            }
            seta_direita.Visible = true;
            if(page == 2)
            {
                pagina.Text = "Regras";
                lbl_descansos.Visible = false;
                lbl_regras.Visible = true;
            }
        }
    }
}
