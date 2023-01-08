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
        public int fk_id_maestria;
        public int xp_profissao;
        private int row_selecionada = 0;
        public static int sobrevivencia = Ficha.bd_sobrevivencia;


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
                data_grid_profissoes.Columns["fk_id_profissao"].Visible = false;
                data_grid_profissoes.Columns["xp_profissao"].Visible = false;

                if (data_grid_profissoes.Rows.Count > 0 && row_selecionada > 0)
                {
                    DataGridViewRow row = data_grid_profissoes.Rows[row_selecionada];
                    Carregar_tabs(row);
                }
                else if (data_grid_profissoes.Rows.Count > 0)
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
            Local_de_Pesca.SelectedIndex = 0;
            panel5.Visible = false;
            panel4.Visible = false;

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

            fk_id_profissao = (int)row.Cells[6].Value;
            fk_id_maestria = (int)row.Cells[5].Value;
            xp_profissao = (int)row.Cells[7].Value;

            richTextBox2.Text = row.Cells[2].Value.ToString();

            richTextBox1.Text = row.Cells[4].Value.ToString();

            carregar_xp_maestria();

            if (fk_id_profissao == 14) //pescador
            {
                panel3.Visible = true;
            }
            else
            {
                panel3.Visible = false;
            }

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

                row_selecionada = data_grid_profissoes.Rows[e.RowIndex].Index;

                Carregar_tabs(row);
            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO click na grid ", "Erro:" + a);
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            add_xp(1);
        }

        private void add_xp(int xp)
        {
            for (int i = xp; i > 0; i--)
            {
                if (progressBar1.Value == progressBar1.Maximum - 1)
                {
                    fk_id_maestria++;

                    progressBar1.Value = 0;

                    xp_profissao = 0;

                    label6.Text = Convert.ToString(xp_profissao);

                    Conexao_BD.update_maestria(Campanha.id_personagem, fk_id_profissao, fk_id_maestria);

                    Conexao_BD.update_xp_profissao(0, Campanha.id_personagem, fk_id_profissao);

                    carregar_data_grid_profissoes();
                }
                else
                {
                    xp_profissao++;

                    progressBar1.Value++;

                    label6.Text = Convert.ToString(xp_profissao);

                    Conexao_BD.update_xp_profissao(xp_profissao, Campanha.id_personagem, fk_id_profissao);

                    data_grid_profissoes.Rows[row_selecionada].Cells[7].Value = xp_profissao;
                }
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            if (xp_profissao > 0)
            {
                xp_profissao--;

                progressBar1.Value--;

                label6.Text = Convert.ToString(xp_profissao);

                Conexao_BD.update_xp_profissao(xp_profissao, Campanha.id_personagem, fk_id_profissao);

                data_grid_profissoes.Rows[row_selecionada].Cells[7].Value = xp_profissao;
            }
            else if (fk_id_maestria > 1)
            {
                fk_id_maestria--;

                progressBar1.Value = 0;

                xp_profissao = progressBar1.Maximum - 1;

                label6.Text = Convert.ToString(xp_profissao);

                Conexao_BD.update_maestria(Campanha.id_personagem, fk_id_profissao, fk_id_maestria);

                Conexao_BD.update_xp_profissao(0, Campanha.id_personagem, fk_id_profissao);

                carregar_data_grid_profissoes();
            }
        }



        private void carregar_xp_maestria() 
        { 
            if(fk_id_maestria == 1)
            {
                progressBar1.Maximum = 10;
                label8.Text = "10";

                iconButton4.Visible = true;
                iconButton5.Visible = true;
                progressBar1.Visible = true;
                label8.Visible = true;
                label7.Visible = true;
                label6.Visible = true;
                label1.Visible = true;
            }
            if (fk_id_maestria == 2)
            {
                progressBar1.Maximum = 15;
                label8.Text = "15";

                iconButton4.Visible = true;
                iconButton5.Visible = true;
                progressBar1.Visible = true;
                label8.Visible = true;
                label7.Visible = true;
                label6.Visible = true;
                label1.Visible = true;
            }
            if (fk_id_maestria == 3)
            {
                progressBar1.Maximum = 25;
                label8.Text = "25";

                iconButton4.Visible = true;
                iconButton5.Visible = true;
                progressBar1.Visible = true;
                label8.Visible = true;
                label7.Visible = true;
                label6.Visible = true;
                label1.Visible = true;
            }
            if (fk_id_maestria == 4)
            {
                progressBar1.Maximum = 40;
                label8.Text = "40";

                iconButton4.Visible = true;
                iconButton5.Visible = true;
                progressBar1.Visible = true;
                label8.Visible = true;
                label7.Visible = true;
                label6.Visible = true;
                label1.Visible = true;
            }
            if (fk_id_maestria == 5)
            {
                iconButton4.Visible = false;
                iconButton5.Visible = false;
                progressBar1.Visible = false;
                label8.Visible = false;
                label7.Visible = false;
                label6.Visible = false;
                label1.Visible = false;
            }

            progressBar1.Value = xp_profissao;
            label6.Text = Convert.ToString(xp_profissao);
        }

        private void pescaria()
        {
            List<int> rio = new() { 145,        146,    147,     148,              149,          150 };
            //                      Perca-Sol   Caboz   Salmão   Truta Arco-Íris   Truta Tigre   Bagre

            List<int> lago = new() { 151,    152,     153,     154,         155,    156 };
            //                       Carpa   Robalo   Achigã   Peixe-Gato   Lúcio   Esturjão

            List<int> mar = new() { 157,       158,      159,      160,       161,     162 };
            //                      Sardinha   Anchova   Tilápia   Linguado   Baiacu   Atum



            List<double> t = new() { 0.25, 0.4, 0.6, 1.0 };

            int maestria = fk_id_maestria;
            double t_min = 0;


            int qnt1 = 0;
            int qnt2 = 0;
            int qnt3 = 0;
            int qnt4 = 0;
            int qnt5 = 0;
            int qnt6 = 0;

            double hr = (double)Tempo_de_Pesca.Value;

            if (maestria == 1)
            {
                t_min = t[0];
            }
            else if (maestria == 2)
            {
                t_min = t[0] * 0.9;
            }
            else if (maestria == 3)
            {
                t_min = t[0] * 0.8;
            }
            else if (maestria == 4)
            {
                t_min = t[0] * 0.65;
            }
            else if (maestria == 5)
            {
                t_min = t[0] * 0.5;
            }


            while (hr >= t_min)
            {
                Random random = new();
                int num = random.Next(1, 100);

                Random random2 = new();
                int d20 = random2.Next(1, 20);

                if (d20 == 20)
                {
                    panel4.Visible = true;
                }

                if (maestria == 1)
                {
                    if (num <= 40 && hr >= t[0])
                    {
                        hr -= t[0];
                        if (d20 + sobrevivencia >= 10)
                        {
                            qnt1++;
                            add_xp(1);
                        }
                    }
                    else if (num >= 41 && num <= 80 && hr >= t[0])
                    {
                        hr -= t[0];
                        if (d20 + sobrevivencia >= 10)
                        {
                            qnt2++;
                            add_xp(1);
                        }
                    }
                    else if (num >= 81 && num <= 90 && hr >= t[1])
                    {
                        hr -= t[1];
                        if (d20 + sobrevivencia >= 15)
                        {
                            qnt3++;
                            add_xp(2);
                        }
                    }
                    else if (num >= 91 && num <= 96 && hr >= t[1])
                    {
                        hr -= t[1];
                        if (d20 + sobrevivencia >= 15)
                        {
                            qnt4++;
                            add_xp(2);
                        }
                    }
                    else if (num >= 97 && num <= 100 && hr >= t[2])
                    {
                        hr -= t[2];
                        if (d20 + sobrevivencia >= 20)
                        {
                            qnt5++;
                            add_xp(3);
                        }
                    }
                }
                else if (maestria == 2)
                {
                    if (num <= 30 && hr >= t[0] * 0.9)
                    {
                        hr -= t[0] * 0.9;
                        if (d20 + sobrevivencia >= 8)
                        {
                            qnt1++;
                            add_xp(1);
                        }
                    }
                    else if (num >= 31 && num <= 60 && hr >= t[0] * 0.9)
                    {
                        hr -= t[0] * 0.9;
                        if (d20 + sobrevivencia >= 8)
                        {
                            qnt2++;
                            add_xp(1);
                        }
                    }
                    else if (num >= 61 && num <= 80 && hr >= t[1] * 0.9)
                    {
                        hr -= t[1] * 0.9;
                        if (d20 + sobrevivencia >= 13)
                        {
                            qnt3++;
                            add_xp(2);
                        }
                    }
                    else if (num >= 81 && num <= 95 && hr >= t[1] * 0.9)
                    {
                        hr -= t[1] * 0.9;
                        if (d20 + sobrevivencia >= 13)
                        {
                            qnt4++;
                            add_xp(2);
                        }
                    }
                    else if (num >= 95 && num <= 100 && hr >= t[2] * 0.9)
                    {
                        hr -= t[2] * 0.9;
                        if (d20 + sobrevivencia >= 17)
                        {
                            qnt5++;
                            add_xp(3);
                        }
                    }
                }
                else if (maestria == 3)
                {
                    if (num <= 25 && hr >= t[0] * 0.8)
                    {
                        hr -= t[0] * 0.8;
                        if (d20 + sobrevivencia >= 5)
                        {
                            qnt1++;
                            add_xp(1);
                        }
                    }
                    else if (num >= 26 && num <= 50 && hr >= t[0] * 0.8)
                    {
                        hr -= t[0] * 0.8;
                        if (d20 + sobrevivencia >= 5)
                        {
                            qnt2++;
                            add_xp(1);
                        }
                    }
                    else if (num >= 51 && num <= 70 && hr >= t[1] * 0.8)
                    {
                        hr -= t[1] * 0.8;
                        if (d20 + sobrevivencia >= 9)
                        {
                            qnt3++;
                            add_xp(2);
                        }
                    }
                    else if (num >= 71 && num <= 85 && hr >= t[1] * 0.8)
                    {
                        hr -= t[1] * 0.8;
                        if (d20 + sobrevivencia >= 9)
                        {
                            qnt4++;
                            add_xp(2);
                        }
                    }
                    else if (num >= 86 && num <= 95 && hr >= t[2] * 0.8)
                    {
                        hr -= t[2] * 0.8;
                        if (d20 + sobrevivencia >= 14)
                        {
                            qnt5++;
                            add_xp(3);
                        }
                    }
                    else if (num >= 96 && num <= 100 && hr >= t[3] * 0.8)
                    {
                        hr -= t[3] * 0.8;
                        if (d20 + sobrevivencia >= 19)
                        {
                            qnt6++;
                            add_xp(4);
                        }
                    }
                }
                else if (maestria == 4)
                {
                    if (num <= 20 && hr >= t[0] * 0.65)
                    {
                        hr -= t[0] * 0.65;
                        if (d20 + sobrevivencia >= 0)
                        {
                            qnt1++;
                            add_xp(1);
                        }
                    }
                    else if (num >= 21 && num <= 40 && hr >= t[0] * 0.65)
                    {
                        hr -= t[0] * 0.65;
                        if (d20 + sobrevivencia >= 0)
                        {
                            qnt2++;
                            add_xp(1);
                        }
                    }
                    else if (num >= 41 && num <= 60 && hr >= t[1] * 0.65)
                    {
                        hr -= t[1] * 0.65;
                        if (d20 + sobrevivencia >= 5)
                        {
                            qnt3++;
                            add_xp(2);
                        }
                    }
                    else if (num >= 61 && num <= 80 && hr >= t[1] * 0.65)
                    {
                        hr -= t[1] * 0.65;
                        if (d20 + sobrevivencia >= 5)
                        {
                            qnt4++;
                            add_xp(2);
                        }
                    }
                    else if (num >= 81 && num <= 90 && hr >= t[2] * 0.65)
                    {
                        hr -= t[2] * 0.65;
                        if (d20 + sobrevivencia >= 10)
                        {
                            qnt5++;
                            add_xp(3);
                        }
                    }
                    else if (num >= 91 && num <= 100 && hr >= t[3] * 0.65)
                    {
                        hr -= t[3] * 0.65;
                        if (d20 + sobrevivencia >= 15)
                        {
                            qnt6++;
                            add_xp(4);
                        }
                    }
                }
                else
                {
                    if (num <= 15 && hr >= t[0] * 0.5)
                    {
                        hr -= t[0] * 0.5;
                        if (d20 + sobrevivencia >= 0)
                        {
                            qnt1++;
                            add_xp(1);
                        }
                    }
                    else if (num >= 16 && num <= 30 && hr >= t[0] * 0.5)
                    {
                        hr -= t[0] * 0.5;
                        if (d20 + sobrevivencia >= 0)
                        {
                            qnt2++;
                            add_xp(1);
                        }
                    }
                    else if (num >= 31 && num <= 50 && hr >= t[1] * 0.5)
                    {
                        hr -= t[1] * 0.5;
                        if (d20 + sobrevivencia >= 0)
                        {
                            qnt3++;
                            add_xp(2);
                        }
                    }
                    else if (num >= 51 && num <= 70 && hr >= t[1] * 0.5)
                    {
                        hr -= t[1] * 0.5;
                        if (d20 + sobrevivencia >= 0)
                        {
                            qnt4++;
                            add_xp(2);
                        }
                    }
                    else if (num >= 71 && num <= 85 && hr >= t[2] * 0.5)
                    {
                        hr -= t[2] * 0.5;
                        if (d20 + sobrevivencia >= 5)
                        {
                            qnt5++;
                            add_xp(3);
                        }
                    }
                    else if (num >= 86 && num <= 100 && hr >= t[3] * 0.5)
                    {
                        hr -= t[3] * 0.5;
                        if (d20 + sobrevivencia >= 10)
                        {
                            qnt6++;
                            add_xp(4);
                        }
                    }
                }
            }

            int[] qnt = { qnt1, qnt2, qnt3, qnt4, qnt5, qnt6 };

            if (Local_de_Pesca.SelectedIndex == 0)
            {
                for (int j = 0; j < rio.Count; j++)
                {
                    if (qnt[j] > 0)
                    {
                        Conexao_BD.insert_item_inventario(rio[j], qnt[j]);
                    }
                    
                }
            }
            else if (Local_de_Pesca.SelectedIndex == 1)
            {
                for (int j = 0; j < lago.Count; j++)
                {
                    if (qnt[j] > 0)
                    {
                        Conexao_BD.insert_item_inventario(lago[j], qnt[j]);
                    }
                        
                }
            }
            else if (Local_de_Pesca.SelectedIndex == 2)
            {
                for (int j = 0; j < mar.Count; j++)
                    if (qnt[j] > 0)
                    {
                        Conexao_BD.insert_item_inventario(mar[j], qnt[j]);
                    }
            }
        }

        private void Pescar_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void panel4_VisibleChanged(object sender, EventArgs e)
        {
            if (panel4.Visible == true)
            {
                timer_tesouro.Enabled = true;
            }
        }

        private void timer_tesouro_Tick(object sender, EventArgs e)
        {
            panel4.Visible = false;
            timer_tesouro.Enabled = false;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (Tempo_de_Pesca.Value > 0)
            {
                pescaria();
                panel5.Visible = false;
            }
            else
            {
                MessageBox.Show("Selecione o tempo de pesca!");
                panel5.Visible = false;
            }

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }
    }
}