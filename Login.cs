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

    public partial class Login : Form
    {
        
        public DataTable nda;
        public static string senha = " ";
        public static int jogador = 0;


        public Login()
        {
            InitializeComponent();

            var pos = this.PointToScreen(LblFecharLogin.Location);
            pos = pictureBox2.PointToClient(pos);
            LblFecharLogin.Parent = pictureBox2;
            LblFecharLogin.Location = pos;
            LblFecharLogin.BackColor = Color.Transparent;
            

        }
     
            
      

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void TbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (e.KeyCode == Keys.Enter)
            {
                senha = TbSenha.Text;


                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=DarkAge_Server;user Id=João;Password=AEsrNA95");
                conn.Open();
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "select senha_jogador, id_jogador, pers_criado from \"Dark_Age_Connection\".\"Jogadores\" where senha_jogador = @senha";
                comm.Parameters.AddWithValue("@senha", senha);
                NpgsqlDataReader nda = comm.ExecuteReader();
                if (nda.Read())
                {
                    jogador = (int)nda.GetValue(1);
                    Ficha.pers_criado = (bool)nda.GetValue(2);
                }
                

              
                if(nda.HasRows)
                {
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.Closed += (s, args) => this.Close();
                    frm.Show();
                    e.Handled = true;
                     e.SuppressKeyPress = true;
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

        private void TbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
