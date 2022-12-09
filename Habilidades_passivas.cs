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
        public static Boolean tipo_hab;
        public static int custo_hab;
        public static string tipo_custo = "";
        public static string custo_extra;


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

            if(Campanha.id_mestre_campanha == Campanha.id_jogador)
            {
                pnl_hab_classes.Visible = true;
            }

            timer1.Interval = 5;  //we'll increase the opacity every 10ms
            timer1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            timer1.Start();
            Carregar_habilidades();
            Atualizar_legendas();
        }

        public void Atualizar_legendas()
        {
            tipo_mana.Text = Form1.mana_atual + " de Mana restante";
            tipo_luz.Text = Form1.adicional_atual + " de Luz restante";
            tipo_sanidade.Text = Form1.sanidade_atual + " de Sanidade restante";
            tipo_vida.Text = Form1.vida_atual + " de Vida restante";
        }

        public void Carregar_habilidades()
        {
            NpgsqlConnection conn = new NpgsqlConnection(Conexao_BD.Caminho_DB());
            conn.Open();
            NpgsqlCommand comj = new NpgsqlCommand();
            comj.Connection = conn;
            comj.CommandType = CommandType.Text;
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;

            comj.CommandText = "SELECT COUNT(*) from \"Dark_Age_Connection\".\"Habilidades\" where id_classe = @classe and nivel_hab <= @nivel";
            comj.Parameters.AddWithValue("@classe", Campanha.classe_personagem);
            comj.Parameters.AddWithValue("@nivel", Campanha.nivel_personagem);
            int ndj = Convert.ToInt32(comj.ExecuteScalar());


            comm.CommandText = "select id_classe, nivel_hab, titulo_hab, desc_hab, tipo_hab, custo_hab, tipo_custo, custo_adicional, id_habilidade from \"Dark_Age_Connection\".\"Habilidades\" where id_classe = @classe and nivel_hab <= @nivel order by nivel_hab, id_habilidade";
            comm.Parameters.AddWithValue("@classe", Campanha.classe_personagem);
            comm.Parameters.AddWithValue("@nivel", Campanha.nivel_personagem);
            NpgsqlDataReader ndv = comm.ExecuteReader();

            for (int i = 0; i < ndj; ++i)
            {

                if (ndv.Read())
                {
                    if (Campanha.classe_personagem == 2)
                    {
                        lbl_passivas.Text = "Passivas e Invocações";
                        lbl_passivas.IconChar = FontAwesome.Sharp.IconChar.StarOfDavid;
                    }
                    else
                    {
                        lbl_passivas.Text = "Habilidades Passivas";
                        lbl_passivas.IconChar = FontAwesome.Sharp.IconChar.Leaf;
                    }
                    titulo_hab = (string)ndv.GetValue(2);
                    desc_hab = (string)ndv.GetValue(3);
                    tipo_hab = (Boolean)ndv.GetValue(4);
                    if(ndv.GetValue(5).ToString() != "")
                    {
                        tipo_custo = "Sem Custo";
                        custo_hab = (int)ndv.GetValue(5);
                        tipo_custo = ndv.GetValue(6).ToString();
                    }
                    else
                    {
                        tipo_custo = "Sem Custo";
                        custo_hab = 0;
                    }
                    if(ndv.GetValue(5).ToString() != "")
                    {
                        custo_extra = ndv.GetValue(7).ToString();
                    }
                    else
                    {
                        custo_extra = " ";
                    }
                    

                    if (tipo_hab == true)
                    {
                        Panel pnlDefault = new Panel();
                        pnlDefault.BackColor = Color.Transparent;
                        pnlDefault.Dock = DockStyle.None;
                        pnlDefault.Top = (110 * num_hab2) + (40 * num_hab2) + (50 * num_hab2);
                        pnlDefault.Left = 20;
                        pnlDefault.Size = new Size(570, 160);
                        pnlDefault.MaximumSize = new Size(575, 160);

                        painel_habilidade hab = new painel_habilidade(desc_hab, titulo_hab, custo_hab, tipo_custo, custo_extra);

                        panel2.Controls.Add(pnlDefault);
                        pnlDefault.Controls.Add(hab);
                        num_hab2++;
                    }
                    else
                    {
                        Panel pnlDefault = new Panel();
                        pnlDefault.BackColor = Color.Transparent;
                        pnlDefault.Dock = DockStyle.None;
                        pnlDefault.Top = (110 * num_hab) + (40 * num_hab) + (50 * num_hab);
                        pnlDefault.Left = 20;
                        pnlDefault.Size = new Size(570, 160);
                        pnlDefault.MaximumSize = new Size(575, 160);

                        painel_habilidade hab = new painel_habilidade(desc_hab, titulo_hab, custo_hab, tipo_custo, custo_extra);

                        panel1.Controls.Add(pnlDefault);
                        pnlDefault.Controls.Add(hab);
                        num_hab++;
                    }
                    if (tipo_custo == "PM")
                    {
                        tipo_mana.Visible = true;
                    }else if (tipo_custo == "Sanidade")
                    {
                        tipo_sanidade.Visible = true;
                    }
                    else if (tipo_custo == "PV" || tipo_custo == "PV mínimo")
                    {
                        tipo_vida.Visible = true;
                    }else if(tipo_custo == "PL")
                    {
                        tipo_luz.Visible = true;
                    }
                }
              
            }
            num_hab = 0;
            num_hab2 = 0;
            conn.Close();
            comm.Dispose();
            comj.Dispose();
            ndv.Close();
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

        private void cng_alquimista_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            num_hab = 0;
            num_hab2 = 0;
            Campanha.classe_personagem = 1;
            Campanha.nivel_personagem = 5;
            Carregar_habilidades();
        }

        private void cng_mestreforja_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            num_hab = 0;
            num_hab2 = 0;
            Campanha.classe_personagem = 2;
            Campanha.nivel_personagem = 5;
            Carregar_habilidades();
        }

        private void cng_caçador_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            num_hab = 0;
            num_hab2 = 0;
            Campanha.classe_personagem = 3;
            Campanha.nivel_personagem = 5;
            Carregar_habilidades();
        }

        private void cng_orador_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            num_hab = 0;
            num_hab2 = 0;
            Campanha.classe_personagem = 4;
            Campanha.nivel_personagem = 5;
            Carregar_habilidades();
        }

        private void cng_templario_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            num_hab = 0;
            num_hab2 = 0;
            Campanha.classe_personagem = 5;
            Campanha.nivel_personagem = 5;

            Carregar_habilidades();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Atualizar_legendas();
        }
    }
}
