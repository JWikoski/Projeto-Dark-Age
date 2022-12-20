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
using Npgsql;

namespace Dark_Age
{
    public partial class Pagina_mestre : Form
    {
        public static string historia;
        public static string anotacoes;
        public static string regras;
        Boolean minmax = false;
        public static string sanidades;

        public Pagina_mestre()
        {
            InitializeComponent();
        }

        private void Pagina_mestre_Load(object sender, EventArgs e)
        {
            bemvindo.Text = "Bem-Vindo(a) a sua tela de mestre, "+Login.nome_jogador;
            lbl_titulo.Text = Campanha.nome_campanha;
            Conexao_BD.Select_historia_e_anotacoes(ref historia, ref anotacoes);
            txt_historia.Text = historia;
            txt_outros.Text = anotacoes;

            timer1.Interval = 10;  //we'll increase the opacity every 10ms
            timer1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            timer1.Start();

            Conexao_BD.Select_Regras(ref regras, ref sanidades);
            txt_regras.Text = regras;
            txt_sanidade.Text = sanidades;
        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                timer1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        private void btn_anotacoes_Click(object sender, EventArgs e)
        {
            txt_historia.Visible = true;
            txt_outros.Visible = false;
            txt_regras.Visible = false;
            txt_sanidade.Visible = false;
            txt_historia.Focus();

            lbl_titulo.Text = Campanha.nome_campanha;

            btn_regras.BackColor = Color.Transparent;
            btn_sanidades.BackColor = Color.Transparent;
            btn_outros.BackColor = Color.Transparent;
            btn_historia.BackColor = Color.FromArgb(50, 50, 67);
        }


        private void btn_regras_Click(object sender, EventArgs e)
        {
            txt_historia.Visible = false;
            txt_outros.Visible = false;
            txt_regras.Visible = true;
            txt_sanidade.Visible = false;
            txt_regras.Focus();

            lbl_titulo.Text = "Regras do Sistema";

            btn_regras.BackColor = Color.FromArgb(50, 50, 67);
            btn_sanidades.BackColor = Color.Transparent;
            btn_outros.BackColor = Color.Transparent;
            btn_historia.BackColor = Color.Transparent;
        }

        private void btn_sanidades_Click(object sender, EventArgs e)
        {
            txt_historia.Visible = false;
            txt_outros.Visible = false;
            txt_regras.Visible = false;
            txt_sanidade.Visible = true;
            txt_sanidade.Focus();

            lbl_titulo.Text = "Lista de Insanidades e Manias/Fobias";

            btn_regras.BackColor = Color.Transparent;
            btn_sanidades.BackColor = Color.FromArgb(50, 50, 67);
            btn_outros.BackColor = Color.Transparent;
            btn_historia.BackColor = Color.Transparent;
        }

        private void btn_outros_Click(object sender, EventArgs e)
        {
            txt_historia.Visible = false;
            txt_outros.Visible = true;
            txt_regras.Visible = false;
            txt_sanidade.Visible = false;
            txt_outros.Focus();

            lbl_titulo.Text = "Anotações";

            btn_regras.BackColor = Color.Transparent;
            btn_sanidades.BackColor = Color.Transparent;
            btn_outros.BackColor = Color.FromArgb(50, 50, 67);
            btn_historia.BackColor = Color.Transparent;
        }

        private void btn_historia_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 67);
        }


        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            Campanha.classe_personagem = 1;
            Ficha.nivel = 5;
            Habilidades_passivas lista = new Habilidades_passivas();
            lista.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            lbl_npc.Text = "NPC's";
        }

        private void HoverEnter_MouseEnter(object sender, EventArgs e)
        {

            style.houver_botao(sender);
        }

        private void iconButton5_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, Color.Salmon);
        }

        private void btn_monstros_Click(object sender, EventArgs e)
        {
            lbl_npc.Text = "Monstros";
        }

        private void btn_jogadores_Click(object sender, EventArgs e)
        {
            lbl_npc.Text = "Jogadores";
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {            
            salvar_alteracoes();
            this.Close();
        }
       public void salvar_alteracoes()
        {
            NpgsqlConnection conn = new NpgsqlConnection(Conexao_BD.Caminho_DB());
            conn.Open();
            NpgsqlCommand comt = new NpgsqlCommand();
            comt.Connection = conn;
            comt.CommandType = CommandType.Text;
            comt.CommandText = "update \"Dark_Age_Connection\".\"Campanha\" set historia_campanha = @historia, anotacoes_campanha = @anotacoes where id_campanha = @id_campanha";
            comt.Parameters.AddWithValue("@historia", historia);
            comt.Parameters.AddWithValue("@anotacoes", anotacoes);
            comt.Parameters.AddWithValue("@id_campanha", Campanha.id_campanha);
            comt.ExecuteNonQuery();

            comt.CommandText = "update \"Dark_Age_Connection\".\"Regras\" set regras_gerais = @regras, sanidades = @sanidades";
            comt.Parameters.AddWithValue("@regras", regras);
            comt.Parameters.AddWithValue("@sanidades", sanidades);
            comt.ExecuteNonQuery();

            comt.Dispose();
            conn.Close();
        }

        private void txt_historia_TextChanged(object sender, EventArgs e)
        {
            historia = txt_historia.Text;
        }

        private void txt_sanidade_TextChanged(object sender, EventArgs e)
        {
            sanidades = txt_sanidade.Text;
        }

        private void txt_outros_TextChanged(object sender, EventArgs e)
        {
            anotacoes = txt_outros.Text;
        }

        private void txt_regras_TextChanged(object sender, EventArgs e)
        {
            regras = txt_regras.Text;
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Pagina_mestre_MouseDown(object sender, MouseEventArgs e)
        {
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Square;
            minmax = false;
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, Login.WM_NCLBUTTONDOWN, Login.HT_CAPTION, 0);
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
           
            if (minmax == true)
            {
                this.WindowState = FormWindowState.Normal;
                iconButton3.IconChar = FontAwesome.Sharp.IconChar.Square;
                this.CenterToScreen();
                minmax = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                iconButton3.IconChar = FontAwesome.Sharp.IconChar.Minimize;
                minmax = true;
            }
        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            Lista_itens lista = new Lista_itens();
            lista.Show();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            salvar_alteracoes();
            MessageBox.Show("Alterações salvas!");
        }

        
    }

}