using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Dark_Age
{
    public partial class Inventario : Form
    {
        public string inventario_texto;
        public Boolean minmax = true;

        public static int moedas_de_ouro;
        public static int moedas_de_prata;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public Inventario()
        {
            InitializeComponent();
            Screen screen = Screen.FromPoint(Cursor.Position);
            this.Location = screen.Bounds.Location;
            this.BackColor = Color.FromArgb(14, 40, 52);
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=DarkAge_Server;user Id=João;Password=AEsrNA95");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select inventario, gold, silver from \"Dark_Age_Connection\".\"Personagens\" where fk_id_jogador = @jogador";
            comm.Parameters.AddWithValue("@jogador", Login.jogador);

            NpgsqlDataReader nda = comm.ExecuteReader();

            if (nda.Read())
            {
                inventario_texto = (string)nda.GetValue(0);
                itens_inventario.Text = (string)nda.GetValue(0);
                txt_inventario.Text = (string)nda.GetValue(0);
                moedas_ouro.Value = (int)nda.GetValue(1);
                moedas_prata.Value = (int)nda.GetValue(2);
            }
            comm.Dispose();
            conn.Close();

        }

        private void Editar_CheckedChanged(object sender, EventArgs e)
        {
            if (Editar.Checked)
            {
                txt_inventario.Enabled = true;
                txt_inventario.Height = 790;
            }
            else
            {
                txt_inventario.Enabled = false;

                txt_inventario.Height = 31;
            }
        }

        private void txt_inventario_TextChanged(object sender, EventArgs e)
        {
            inventario_texto = txt_inventario.Text;
            itens_inventario.Text = inventario_texto;
            txt_inventario.Text = inventario_texto;
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


        private void LblFecharPassivas_Click(object sender, EventArgs e)
        {
            this.Close();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=DarkAge_Server;user Id=João;Password=AEsrNA95");
            conn.Open();
            NpgsqlCommand coss = new NpgsqlCommand();
            coss.Connection = conn;
            coss.CommandType = CommandType.Text;
            coss.CommandText = "update \"Dark_Age_Connection\".\"Personagens\" set inventario = @inventario, gold = @ouro, silver = @prata";
            coss.Parameters.AddWithValue("@inventario", inventario_texto);
            coss.Parameters.AddWithValue("@ouro", moedas_ouro.Value);
            coss.Parameters.AddWithValue("@prata", moedas_prata.Value);
            NpgsqlDataReader nda = coss.ExecuteReader();
            coss.Dispose();
            conn.Close();
            moedas_de_ouro = Convert.ToInt32(moedas_ouro.Value);
            moedas_de_prata = Convert.ToInt32(moedas_prata.Value);


            this.Close();
        }


        private void label3_Click(object sender, EventArgs e)
        {
            if (minmax == true)
            {
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();
                label3.Image = global::Dark_Age.Properties.Resources.maxscreen2;
                minmax = false;

                panel8.Enabled = true;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                label3.Image = global::Dark_Age.Properties.Resources.minimizar;
                minmax = true;

                panel8.Enabled = false;
            }
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

        private void Inventario_Load(object sender, EventArgs e)
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
