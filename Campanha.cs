using Dark_Age.Enteties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dark_Age
{
    public partial class Campanha : Form
    {
        public static int id_campanha;
        public static int id_personagem;
        public static int id_jogador = Login.jogador;
        public Campanha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Campanha_Load(object sender, EventArgs e)
        {
            carrega_data_grid_campanha();
        }



        public void carrega_data_grid_campanha()
        {
            try
            {
                data_grid_campanha.DataSource = Conexao_BD.select_campanha();


                data_grid_campanha.Columns["nome_campanha"].HeaderText = "Nome";
                data_grid_campanha.Columns["id_campanha"].Visible = false;


            } catch (Exception a)
            {
                MessageBox.Show("ERRO no data grid campanha ", "Erro:" + a);
            }
        }

        public void carrega_data_grid_pers_camp(int id_jogador, int id_campanha)
        {
            try
            {
                data_grid_pers_camp.DataSource = Conexao_BD.select_personagem_campanha(id_jogador, id_campanha);

                if (data_grid_pers_camp.DataSource != null)
                {

                    data_grid_pers_camp.Columns["nome_personagem"].HeaderText = "Nomes Personagens";
                    data_grid_pers_camp.Columns["mestre"].Visible = false;
                    data_grid_pers_camp.Columns["id_personagem"].Visible = false;
                }

            } catch (Exception a)
            {
                MessageBox.Show("ERRO no data grid campanha ", "Erro:" + a);
            }
        }

        private void data_grid_campanha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                DataGridViewRow row = data_grid_campanha.Rows[e.RowIndex];               
                id_campanha = (int)row.Cells[0].Value;
                carrega_data_grid_pers_camp(id_jogador, id_campanha);
            } catch (Exception a)
            {
                MessageBox.Show("ERRO click na grid ", "Erro:" + a);
            }
        }

        private void data_grid_pers_camp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                DataGridViewRow row = data_grid_pers_camp.Rows[e.RowIndex];
                id_personagem = (int)row.Cells[0].Value;                
            } catch (Exception a)
            {
                MessageBox.Show("ERRO click na grid ", "Erro:" + a);
            }
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (id_personagem != null)
            {
                Form1 pagina_inicial = new Form1();
                pagina_inicial.ShowDialog();
            } else
            {
                MessageBox.Show("Por favor, selecione o personagem para abrir a ficha dele, ou crie um novo personagem.");
            }
        }
    }
}
