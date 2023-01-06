using System;
using System.Text.RegularExpressions;
using Npgsql;
using Dark_Age.Enteties;
using Dark_Age.Controllers;
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
    public partial class Profissoes : Form
    {
        public int fk_id_profissao;
        public static int fk_id_maestria;

        public Profissoes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selecionar_profissao.Visible = true;
        }

        public void carregar_data_grid_profissoes()
        {
            try
            {
                data_grid_profissoes.DataSource = Conexao_BD.select_profissoes_escolhidas();

                data_grid_profissoes.Columns["id_inter_profissao"].Visible = false;
                data_grid_profissoes.Columns["nome_profissao"].HeaderText = "Profissão";
                data_grid_profissoes.Columns["descricao_profissao"].Visible = false;
                data_grid_profissoes.Columns["nome"].Visible = false;
                data_grid_profissoes.Columns["descricao"].Visible = false;
                data_grid_profissoes.Columns["fk_id_maestria"].Visible = false;


                if (data_grid_profissoes.Rows.Count > 0)
                {
                    data_grid_profissoes.Rows[0].Selected = true;
                    DataGridViewRow row = data_grid_profissoes.Rows[0];
                    Carregar_tabs(row);
                }
                foreach (DataGridViewRow x in data_grid_profissoes.Rows)
                {
                    x.MinimumHeight = 30;
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO no data grid profissoes", "Erro:" + a);
            }

        }

        private void Profissoes_Load(object sender, EventArgs e)
        {
            carregar_data_grid_profissoes();

            selecionar_profissao.Visible = false;

            //Combobox para seleção de profissão
            comboBox1.DataSource = Conexao_BD.select_profissao();
            comboBox1.ValueMember = "id_profissao";
            comboBox1.DisplayMember = "nome_profissao";

            //Combobox para seleção de mestria
            comboBox2.DataSource = Conexao_BD.select_maestria();
            comboBox2.ValueMember = "id_maestria";
            comboBox2.DisplayMember = "nome";


        }

        private void Carregar_tabs(DataGridViewRow e)
        {
            DataGridViewRow row = e;

            fk_id_profissao = (int)row.Cells[0].Value;
            fk_id_maestria = (int)row.Cells[5].Value;

            richTextBox2.Text = row.Cells[2].Value.ToString();

            richTextBox1.Text = row.Cells[4].Value.ToString();


            Formatacao_texto.negrito(richTextBox2);
            Formatacao_texto.negrito(richTextBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selecionar_profissao.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Conexao_BD.checar_profissao(Campanha.id_personagem, (int)comboBox1.SelectedIndex + 1) == true)
            {
                Conexao_BD.remover_profissao(Campanha.id_personagem, (int)comboBox1.SelectedIndex + 1);

                carregar_data_grid_profissoes();
            }
            else
            {
                MessageBox.Show("Selecione uma profissão válida!");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (Conexao_BD.checar_profissao(Campanha.id_personagem, (int)comboBox1.SelectedIndex + 1) == false)
            {
                Conexao_BD.adicionar_profissao(Campanha.id_personagem, (int)comboBox1.SelectedIndex + 1, (int)comboBox2.SelectedIndex + 1);

                carregar_data_grid_profissoes();
            }
            else
            {
                MessageBox.Show("Profissão Repetida!");
            }
        }

        private void data_grid_profissoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                DataGridViewRow row = data_grid_profissoes.Rows[e.RowIndex];
                Carregar_tabs(row);

                
            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO click na grid ", "Erro:" + a);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if(fk_id_maestria == 1)
            {

            }
            if (fk_id_maestria == 2)
            {

            }
            if (fk_id_maestria == 3)
            {

            }
            if (fk_id_maestria == 4)
            {

            }
            if (fk_id_maestria == 5)
            {

            }



        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private static void carregar_xp_maestria() 
        { 
            if(fk_id_maestria == 1)
            {

            }
            if (fk_id_maestria == 2)
            {

            }
            if (fk_id_maestria == 3)
            {

            }
            if (fk_id_maestria == 4)
            {

            }
            if (fk_id_maestria == 5)
            {

            }
        }

        private DataTable pescaria()
        {

            List<string> rio = new() { "Perca-Sol", "Caboz", "Salmão", "Truta Arco-Íris", "Truta Tigre", "Bagre" };
            List<string> lago = new() { "Carpa", "Robalo", "Achigã", "Peixe-Gato", "Lúcio", "Esturjão" };
            List<string> mar = new() { "Sardinha", "Anchova", "Tilápia", "Linguado", "Baiacu", "Atum" };

            List<double> t = new() { 0.25, 0.4, 0.6, 1.0 }; //tempo necessário para pescar

            int maestria = fk_id_maestria;

            int qnt1 = 0;
            int qnt2 = 0;
            int qnt3 = 0;
            int qnt4 = 0;
            int qnt5 = 0;
            int qnt6 = 0;

            float hr = (float)Tempo_de_Pesca.Value;

            while (hr >= 0.25)
            {
                if (Local_de_Pesca.SelectedIndex == 0)
                {

                }
                if (maestria == 1)
                {

                }
                else if (maestria == 2)
                {

                }
                else if (maestria == 3)
                {

                }
                else if (maestria == 4)
                {

                }
                else
                {

                }
            }


        }

        private void Pescar_Click(object sender, EventArgs e)
        {

        }
    }
}