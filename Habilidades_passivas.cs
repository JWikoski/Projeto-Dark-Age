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
using Dark_Age.Enteties;
using Npgsql;

namespace Dark_Age
{
    public partial class Habilidades_passivas : Form
    {
        public string passivas = "";
        public string ativas = "";
        public static int num_hab = 0;
        public static int num_hab2 = 0;
        public static string titulo_hab;
        public static string desc_hab;


        Adicionar_habilidade pnl = new Adicionar_habilidade();
        Adicionar_habilidade text = new Adicionar_habilidade();


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public Habilidades_passivas()
        {
            InitializeComponent();

        }

        private void Habilidades_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0


            timer1.Interval = 5;  //we'll increase the opacity every 10ms
            timer1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            timer1.Start();

            NpgsqlConnection conn = new NpgsqlConnection(Conexao_BD.Caminho_DB());
            conn.Open();
            NpgsqlCommand comj = new NpgsqlCommand();
            comj.Connection = conn;
            comj.CommandType = CommandType.Text;
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;


            comj.CommandText = "SELECT COUNT(*) from \"Dark_Age_Connection\".\"Habilidades\" where id_classe = @classe and nivel_hab = @nivel";
            comj.Parameters.AddWithValue("@classe", 1);
            comj.Parameters.AddWithValue("@nivel", 1);
            int ndj = Convert.ToInt32(comj.ExecuteScalar());


            comm.CommandText = "select id_classe, nivel_hab, titulo_hab, desc_hab, tipo_hab from \"Dark_Age_Connection\".\"Habilidades\" where id_classe = @classe and nivel_hab <= @nivel";
            comm.Parameters.AddWithValue("@classe", 1);
            comm.Parameters.AddWithValue("@nivel", 1);
            NpgsqlDataReader ndv = comm.ExecuteReader();

            for (int i = 0; i < ndj; ++i)
            {

                if (ndv.Read())
            {
               
                    titulo_hab = (string)ndv.GetValue(2);
                    desc_hab = (string)ndv.GetValue(3);

                    if ((Boolean)ndv.GetValue(4) == true)
                    {
                        Panel pnlDefault = new Panel();
                        pnlDefault.BackColor = Color.Transparent;
                        pnlDefault.Dock = DockStyle.None;
                        pnlDefault.Top = (110 * num_hab2) + (30 * num_hab2) + (30 * num_hab2);
                        pnlDefault.Left = 20;
                        pnlDefault.Size = new Size(558, 150);
                        pnlDefault.MaximumSize = new Size(558, 150);

                        Panel pnlDefault2 = new Panel();
                        pnlDefault2.BackColor = Color.Transparent;
                        pnlDefault2.Dock = DockStyle.None;
                        pnlDefault2.AutoScroll = true;
                        pnlDefault2.Top = 40;
                        pnlDefault2.Left = 0;
                        pnlDefault2.Size = new Size(558, 110);
                        pnlDefault2.MaximumSize = new Size(558, 110);

                        panel2.Controls.Add(pnlDefault);
                        pnlDefault.Controls.Add(pnlDefault2);

                        pnlDefault.Controls.Add(text.gerarTitulo(num_hab2, titulo_hab));
                        pnlDefault2.Controls.Add(text.gerarTexto(num_hab2, desc_hab));
                        num_hab2++;
                    }
                    else
                    {
                        Panel pnlDefault = new Panel();
                        pnlDefault.BackColor = Color.Transparent;
                        pnlDefault.Dock = DockStyle.None;
                        pnlDefault.Top = (110 * num_hab) + (30 * num_hab) + (30 * num_hab);
                        pnlDefault.Left = 20;
                        pnlDefault.Size = new Size(558, 150);
                        pnlDefault.MaximumSize = new Size(558, 150);

                        Panel pnlDefault2 = new Panel();
                        pnlDefault2.BackColor = Color.Transparent;
                        pnlDefault2.Dock = DockStyle.None;
                        pnlDefault2.AutoScroll = true;
                        pnlDefault2.Top = 40;
                        pnlDefault2.Left = 0;
                        pnlDefault2.Size = new Size(558, 110);
                        pnlDefault2.MaximumSize = new Size(558, 110);

                        panel1.Controls.Add(pnlDefault);
                        pnlDefault.Controls.Add(pnlDefault2);

                        pnlDefault.Controls.Add(text.gerarTitulo(num_hab, titulo_hab));
                        pnlDefault2.Controls.Add(text.gerarTexto(num_hab, desc_hab));
                        num_hab++;
                    }

                }
            }
            num_hab = 0;
            num_hab2 = 0;


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
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, Color.LightGray);
            button.FlatAppearance.BorderColor = Color.FromArgb(25, Color.DarkGoldenrod);
            button.FlatAppearance.BorderSize = 1;
            
        }

        private void LblFecharPassivas_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.FlatAppearance.BorderSize = 0;
        }
       

        private void LblFecharLogin_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

    
    }
}
