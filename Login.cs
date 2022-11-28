using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dark_Age.Enteties;
using Npgsql;

namespace Dark_Age
{


    public partial class Login : Form
    {
        
        public DataTable nda;
        public static string senha = " ";
        public static int jogador = 0;
        public static string nome_jogador;
        Timer timer1 = new Timer();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public Login()
        {
            InitializeComponent();

            var pos = this.PointToScreen(LblFecharLogin.Location);
            pos = pictureBox2.PointToClient(pos);
            LblFecharLogin.Parent = pictureBox2;
            LblFecharLogin.Location = pos;
            LblFecharLogin.BackColor = Color.Transparent;
            

        }
        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked == true)
            
                TbSenha.UseSystemPasswordChar = false;
            
            else
            
                TbSenha.UseSystemPasswordChar = true;
            
        }

        private void LblFecharLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void LblFecharLogin_MouseHover(object sender, EventArgs e)
        {
       

            LblFecharLogin.BackColor = Color.FromArgb(25, Color.LightGray);
         
        }

        private void LblFecharLogin_MouseLeave(object sender, EventArgs e)
        {
           
            LblFecharLogin.BackColor = Color.Transparent;
       
        }
        

        void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                timer1.Stop();    //if it is, we stop the timer
                Close();   //and we try to close the form
            }
            else
                Opacity -= 0.05;
        }

        private void TbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (e.KeyCode == Keys.Enter)
            {
                senha = TbSenha.Text;


                NpgsqlConnection conn = new NpgsqlConnection(Conexao_BD.Caminho_DB());
                conn.Open();
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "select senha_jogador, id_jogador, nome_jogador from \"Dark_Age_Connection\".\"Jogadores\" where senha_jogador = @senha";
                comm.Parameters.AddWithValue("@senha", senha);
                NpgsqlDataReader nda = comm.ExecuteReader();
                if (nda.Read())
                {
                    jogador = (int)nda.GetValue(1);
                    nome_jogador = nda.GetValue(2).ToString();
                }



                if (nda.HasRows)
                {
                    /*
                    if (Ficha.pers_criado == false)
                    {
                        this.Hide();
                        Ficha frm = new Ficha();
                        frm.ShowDialog();
                       
                    }
                    else
                    {
                        this.Hide();
                        Form1 frm = new Form1();
                        frm.Closed += (s, args) => this.Close();
                        frm.Show();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                    }*/
                 this.Hide();
                 Campanha frm = new Campanha();
                 frm.Show();

                }
                else
                {
                    LblSenhaInvalida.Visible = true;
                    TbSenha.Text = "";
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    comm.Dispose();
                    conn.Close();
                }
               
        }


        }

        private void Login_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0

            timer1.Interval = 10;  //we'll increase the opacity every 10ms
            timer1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            timer1.Start();
        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                timer1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel8_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

      

    }
}
