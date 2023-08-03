using Dark_Age.Enteties;
using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Dark_Age.Controllers;

namespace Dark_Age
{
    public partial class NPCs : Form
    {
        public static int id_personagem;
        public static int id_entidade;
        public static int id_jogador;
        public static int vida_pet;
        public static int vida_pet_max;
        public static int mana_atual;
        public static int mana_max;
        public static int tipo_entidade;
        public static string tamanho;
        public static int meus_pets = 1;
        public NPCs()
        {
            InitializeComponent();

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
                Opacity += 0.5;
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Pets_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, Form1.WM_NCLBUTTONDOWN, Form1.HT_CAPTION, 0);
            }
        }

        private void Pets_Load(object sender, EventArgs e)
        {
            if (tipo_entidade == 2)
            {
                this.BackgroundImage = global::Dark_Age.Properties.Resources.papers_co_sk61_dark_purple_blur_gradation_36_3840x2400_4k_wallpaper;
            }
            else
            {
                this.BackgroundImage = global::Dark_Age.Properties.Resources.dark_blue_;
            }

            carregar_data_grid();
        }
        public void carregar_data_grid()
        {
            try
            {

                Grid_lista_pets.DataSource = Conexao_BD.select_pet_jogador(Campanha.id_jogador, Campanha.id_campanha, meus_pets, tipo_entidade);
                Grid_lista_pets.Columns["id_personagem"].HeaderText = "ID";
                Grid_lista_pets.Columns["nome_personagem"].HeaderText = "Nome criatura";
                Grid_lista_pets.Columns["vida_max"].HeaderText = "Vida";
                Grid_lista_pets.Columns["mana_atual"].HeaderText = "Mana";
                Grid_lista_pets.Columns["tamanho"].HeaderText = "Tamanho";
                Grid_lista_pets.Columns["fk_id_jogador"].Visible = false;
                Grid_lista_pets.Columns["vida_atual"].Visible = false;
                Grid_lista_pets.Columns["escudo"].Visible = false;
                Grid_lista_pets.Columns["tipo_personagem"].Visible = false;
                Grid_lista_pets.Columns["id_entidade"].Visible = false;
                Grid_lista_pets.Columns["tamanho"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Grid_lista_pets.Columns["vida_max"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Grid_lista_pets.Columns["mana_atual"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Grid_lista_pets.Columns["id_personagem"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                if (Grid_lista_pets.Rows.Count > 0)
                {
                    Grid_lista_pets.Rows[0].Selected = true;
                    Status_pet.Text = "";
                    DataGridViewRow row = Grid_lista_pets.Rows[0];
                    id_jogador = (int)row.Cells[0].Value;
                    id_personagem = (int)row.Cells[1].Value;
                    id_entidade = (int)row.Cells[9].Value;

                    if (id_jogador == Campanha.id_jogador)
                    {
                        Status_pet.Text += "Vida: " + row.Cells[4].Value.ToString() + " / " + row.Cells[3].Value.ToString() + "\n\r";
                        Status_pet.Text += "Mana: " + row.Cells[5].Value.ToString() + "\n\r";
                    }
                    else
                    {
                        Status_pet.Text += "Vida: " + row.Cells[4].Value.ToString() + "\n\r";
                        Status_pet.Text += "Mana: " + row.Cells[5].Value.ToString() + "\n\r";
                    }
                }
                foreach (DataGridViewRow x in Grid_lista_pets.Rows)
                {
                    x.MinimumHeight = 30;
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO no data grid ", "Erro:" + a);
            }

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grid_lista_pets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                Status_pet.Text = "";
                DataGridViewRow row = Grid_lista_pets.Rows[e.RowIndex];
                id_jogador = (int)row.Cells[0].Value;
                id_personagem = (int)row.Cells[1].Value;
                id_entidade = (int)row.Cells[9].Value;

                if (id_jogador == Campanha.id_jogador)
                {
                    Status_pet.Text += "Vida: " + row.Cells[4].Value.ToString()+" / "+ row.Cells[3].Value.ToString() + "\n\r";
                    Status_pet.Text += "Mana: " + row.Cells[5].Value.ToString() + " / " + row.Cells[5].Value.ToString() + "\n\r";
                }
                else
                {
                    Status_pet.Text += "Vida: " + row.Cells[4].Value.ToString() + "\n\r";
                    Status_pet.Text += "Mana: " + row.Cells[5].Value.ToString() + "\n\r";
                }
                
            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO click na grid ", "Erro:" + a);
            }
        }

        private void adiciona_qtd_MouseEnter(object sender, EventArgs e)
        {
            adiciona_qtd.Text = "Registrar novo Pet";
            adiciona_qtd.IconColor = Color.LightGreen;
        }

        private void adiciona_qtd_MouseLeave(object sender, EventArgs e)
        {
            adiciona_qtd.Text = "";
            adiciona_qtd.IconColor = Color.MediumSpringGreen;
        }

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            btn_adotar.ForeColor = Color.FromArgb(255, 238, 255);
            btn_adotar.IconColor = Color.FromArgb(255, 238, 255);
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            btn_adotar.ForeColor = Color.FromArgb(175, 168, 200);
            btn_adotar.IconColor = Color.FromArgb(175, 168, 200);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                meus_pets = 1;
                Grid_lista_pets.DataSource = Conexao_BD.select_pet_jogador(Campanha.id_jogador, Campanha.id_campanha, meus_pets, tipo_entidade);
                carregar_data_grid();
            }
            else
            {
                meus_pets = 0;
                Grid_lista_pets.DataSource = Conexao_BD.select_pet_jogador(Campanha.id_jogador, Campanha.id_campanha, meus_pets, tipo_entidade);
                carregar_data_grid();
            }
        }

        private void adiciona_qtd_Click(object sender, EventArgs e)
        {
            Ficha.tipo_entidade = 3;
            Ficha.pers_criado = false;
            Ficha.forca = 0;
            Ficha.destreza = 0;
            Ficha.vigor = 0;
            Ficha.carisma = 0;
            Ficha.raciocinio = 0;
            Ficha.magia = 0;

            Ficha ficha_pet = new Ficha();
            ficha_pet.ShowDialog();
        }


        private void btn_adotar_Click(object sender, EventArgs e)
        {
            Conexao_BD.duplicar_entidade(id_entidade);
            carregar_data_grid();
        }
    }
}
