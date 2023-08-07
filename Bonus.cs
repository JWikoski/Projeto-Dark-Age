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
    public partial class Bonus : Form
    {
        private static int id_item = 0;
        private static int id_bonus = 0;
        private static Boolean tipo;
        private static int id_tipo;

        public List<String> lista_atributo = new()
        {
            "Força", "Destreza", "Vigor", "Carisma", "Raciocínio", "Magia"
        };

        public List<String> lista_talento = new()
        {
            "Briga", "Esquiva", "Defesa", "Contra Ataque", "Atirar", "Conjurar Magia", "Lábia", "Intimidação", "Seduzição/Enganação"
            , "Roubo", "Esconder", "Percepção", "Academicos/Medicina", "Ocultismo", "Sobrevivência", "Investigação", "Intuição", "Etiqueta", "Sanidade"
        };


        public Bonus()
        {
            InitializeComponent();

            this.BackColor = Temas.cor_principal;
            iconButton_Combinar.BackColor = Temas.cor_principal_secundaria;
            panel1.BackColor = Temas.cor_principal_secundaria;
            iconButton_Add_bonus.BackColor = Temas.cor_principal_secundaria;
            panel_desc.Visible = false;
            panel_desc.BackColor = Temas.cor_principal;
            button_desc.BackColor = Temas.cor_principal_secundaria;
            iconButton1.BackColor = Temas.cor_principal_secundaria;


            Temas.mudar_cor_data_grid(dataGrid_Itens);
            Temas.mudar_cor_data_grid(dataGrid_Bonus);

            dataGrid_Itens.ColumnHeadersDefaultCellStyle.BackColor = Temas.cor_principal_secundaria;
            dataGrid_Bonus.ColumnHeadersDefaultCellStyle.BackColor = Temas.cor_principal_secundaria;
        }

        private void Bonus_Load(object sender, EventArgs e)
        {
            timer1.Start();

            if (checkBox_Tipo.Checked == true)
            {
                comboBox_Tipo_bonus.DataSource = lista_atributo;
            }
            else
            {
                comboBox_Tipo_bonus.DataSource = lista_talento;
            }
        }

        private void Carregar_dataGrid_Itens_equipados()
        {
            dataGrid_Itens.DataSource = Conexao_BD.select_itens_equipados();

            dataGrid_Itens.Columns["id_itens"].Visible = false;
            dataGrid_Itens.Columns["nome_itens"].HeaderText = "Itens";
            dataGrid_Itens.Columns["dano"].Visible = false;
            dataGrid_Itens.Columns["equipado"].Visible = false;
            dataGrid_Itens.Columns["descricao"].Visible = false;



            foreach (DataGridViewRow x in dataGrid_Itens.Rows)
            {
                x.MinimumHeight = 60;
            }

            if (dataGrid_Itens.Rows.Count > 0)
            {
                dataGrid_Itens.Rows[0].Selected = true;
            }
        }

        private void Carregar_dataGrid_Itens()
        {
            dataGrid_Itens.DataSource = Conexao_BD.select_data_gridlist();

            dataGrid_Itens.Columns["id_itens"].Visible = false;
            dataGrid_Itens.Columns["nome_itens"].HeaderText = "Itens";
            dataGrid_Itens.Columns["dificuldade"].Visible = false;
            dataGrid_Itens.Columns["nome_tipo_itens"].Visible = false;
            dataGrid_Itens.Columns["nome_profissao"].Visible = false;
            dataGrid_Itens.Columns["descricao"].Visible = false;
            dataGrid_Itens.Columns["material"].Visible = false;
            dataGrid_Itens.Columns["dano"].Visible = false;
            dataGrid_Itens.Columns["quantidade"].Visible = false;

            foreach (DataGridViewRow x in dataGrid_Itens.Rows)
            {
                x.MinimumHeight = 60;
            }

            if (dataGrid_Itens.Rows.Count > 0)
            {
                dataGrid_Itens.Rows[0].Selected = true;
            }
        }

        private void Carregar_dataGrid_Bonus()
        {
            dataGrid_Bonus.DataSource = Conexao_BD.select_bonus();

            dataGrid_Bonus.Columns["id_bonus"].Visible = false;
            dataGrid_Bonus.Columns["valor_bonus"].HeaderText = "Valor";
            dataGrid_Bonus.Columns["id_tipo"].Visible = false;
            dataGrid_Bonus.Columns["tipo"].Visible = false;
            dataGrid_Bonus.Columns["nome_tipo"].HeaderText = "tipo";

            foreach (DataGridViewRow x in dataGrid_Bonus.Rows)
            {
                x.MinimumHeight = 60;
            }

            if (dataGrid_Bonus.Rows.Count > 0)
            {
                dataGrid_Bonus.Rows[0].Selected = true;
            }
        }

        private void dataGrid_Itens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                DataGridViewRow row = dataGrid_Itens.Rows[e.RowIndex];

                id_item = (int)row.Cells[0].Value;

                dataGrid_Itens.CurrentRow.Selected = true;
            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO click na grid ", "Erro:" + a);
            }
        }

        private void dataGrid_Bonus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                DataGridViewRow row = dataGrid_Bonus.Rows[e.RowIndex];

                id_bonus = (int)row.Cells[0].Value;
                tipo = (Boolean)row.Cells[3].Value;

                dataGrid_Bonus.CurrentRow.Selected = true;
            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO click na grid ", "Erro:" + a);
            }
        }

        private void iconButton_Combinar_Click(object sender, EventArgs e)
        {
            if (id_item == 0 || id_bonus == 0)
            {
                MessageBox.Show("Selecione Item e Bônus para combinar!");
            }
            else
            {
                Conexao_BD.combinar_bonus_item(id_item, id_bonus);
            }
        }

        private void iconButton_Add_bonus_Click(object sender, EventArgs e)
        {
            if (numericUpDown_Valor_bonus.Value == 0)
            {
                MessageBox.Show("Selecione um valor para o bônus!");
            }
            else
            {
                Conexao_BD.adicionar_bonus((int)numericUpDown_Valor_bonus.Value, comboBox_Tipo_bonus.SelectedIndex + 1, checkBox_Tipo.Checked);
                Carregar_dataGrid_Bonus();
            }
        }

        private void checkBox_Tipo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Tipo.Checked == true)
            {
                checkBox_Tipo.Text = "Atributo";
            }
            else
            {
                checkBox_Tipo.Text = "Talento";
            }
        }

        private void iconButton_Combinar_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 67);
        }

        private void iconButton_Combinar_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void iconButton_Add_bonus_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 67);
        }

        private void iconButton_Add_bonus_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void checkBox_Itens_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Itens.Checked == true)
            {
                Carregar_dataGrid_Itens_equipados();
            }
            else
            {
                Carregar_dataGrid_Itens();
            }
        }

        private void dataGrid_Itens_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow x in dataGrid_Bonus.Rows)
            {
                x.MinimumHeight = 60;
            }
        }

        private void dataGrid_Bonus_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow x in dataGrid_Bonus.Rows)
            {
                x.MinimumHeight = 60;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Carregar_dataGrid_Bonus();
            if (checkBox_Itens.Checked == true)
            {
                Carregar_dataGrid_Itens_equipados();
            }
            else
            {
                Carregar_dataGrid_Itens();
            }

            timer1.Stop();
        }

        private void iconButton_Add_bonus_pers_Click(object sender, EventArgs e)
        {
            if (id_bonus == 0)
            {
                MessageBox.Show("Selecione um Bônus da tabela para adicionar!");
            }
            else
            {
                panel_desc.Visible = true;
            }
        }

        private void button_desc_Click(object sender, EventArgs e)
        {
            Conexao_BD.adicionar_bonus_personagem(id_bonus, Campanha.id_personagem, textBox1.Text);

            panel_desc.Visible = false;
            textBox1.Text = string.Empty;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            panel_desc.Visible = false;
            textBox1.Text = string.Empty;
        }
    }
}
