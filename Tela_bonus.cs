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
    public partial class Tela_bonus : Form
    {
        private static int id_bonus = 0;
        public event EventHandler TelaBonusFechada;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public Tela_bonus()
        {
            InitializeComponent();

            this.BackColor = Temas.cor_principal;
            iconButton1.BackColor = Temas.cor_principal_secundaria;
            iconButton2.BackColor = Temas.cor_principal;
            iconButton3.BackColor = Temas.cor_principal_secundaria;
            Abrir_bonus.BackColor = Temas.cor_principal_secundaria;

            Temas.mudar_cor_data_grid(dataGrid_bonus_ativos);
            Temas.mudar_cor_data_grid(dataGrid_bonus_pers_ativos);

            dataGrid_bonus_ativos.ColumnHeadersDefaultCellStyle.BackColor = Temas.cor_principal_secundaria;
            dataGrid_bonus_pers_ativos.ColumnHeadersDefaultCellStyle.BackColor = Temas.cor_principal_secundaria;
        }

        private void Tela_bonus_Load(object sender, EventArgs e)
        {
            Carregar_dataGrid_bonus_ativos();
            Carregar_dataGrid_bonus_pers_ativos();
        }

        private void Carregar_dataGrid_bonus_ativos()
        {
            dataGrid_bonus_ativos.DataSource = Conexao_BD.select_bonus_ativos(Campanha.id_personagem);


            dataGrid_bonus_ativos.Columns["id_itens"].Visible = false;
            dataGrid_bonus_ativos.Columns["nome_itens"].HeaderText = "Item";
            dataGrid_bonus_ativos.Columns["nome_itens"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_bonus_ativos.Columns["equipado"].Visible = false;
            dataGrid_bonus_ativos.Columns["valor_bonus"].HeaderText = "Valor";
            dataGrid_bonus_ativos.Columns["valor_bonus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_bonus_ativos.Columns["id_tipo"].Visible = false;
            dataGrid_bonus_ativos.Columns["tipo"].Visible = false;
            dataGrid_bonus_ativos.Columns["nome_tipo"].HeaderText = "Tipo";
            dataGrid_bonus_ativos.Columns["nome_tipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewRow x in dataGrid_bonus_ativos.Rows)
            {
                x.MinimumHeight = 60;
            }

            if (dataGrid_bonus_ativos.Rows.Count > 0)
            {
                dataGrid_bonus_ativos.Rows[0].Selected = true;
            }
        }

        private void Carregar_dataGrid_bonus_pers_ativos()
        {
            dataGrid_bonus_pers_ativos.DataSource = Conexao_BD.select_bonus_pers_ativos(Campanha.id_personagem);


            dataGrid_bonus_pers_ativos.Columns["id_bonus"].Visible = false;
            dataGrid_bonus_pers_ativos.Columns["valor_bonus"].HeaderText = "Valor";
            dataGrid_bonus_pers_ativos.Columns["valor_bonus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_bonus_pers_ativos.Columns["nome_tipo"].HeaderText = "Tipo";
            dataGrid_bonus_pers_ativos.Columns["nome_tipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_bonus_pers_ativos.Columns["descricao"].HeaderText = "Descrição";
            dataGrid_bonus_pers_ativos.Columns["descricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewRow x in dataGrid_bonus_pers_ativos.Rows)
            {
                x.MinimumHeight = 60;
            }

            if (dataGrid_bonus_pers_ativos.Rows.Count > 0)
            {
                dataGrid_bonus_pers_ativos.Rows[0].Selected = true;
            }
        }

        private void Abrir_bonus_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 67);
        }

        private void Abrir_bonus_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void Abrir_bonus_Click(object sender, EventArgs e)
        {
            Bonus bonus = new();
            bonus.TopLevel = false;
            panel2.Controls.Add(bonus);
            bonus.Dock = DockStyle.Fill;
            bonus.Show();
            panel2.Visible = true;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Carregar_dataGrid_bonus_ativos();
            Carregar_dataGrid_bonus_pers_ativos();
            panel2.Visible = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGrid_bonus_ativos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid_bonus_ativos.Rows.Count == 0)
            {
                return;
            }
            dataGrid_bonus_ativos.CurrentRow.Selected = true;
        }

        private void dataGrid_bonus_ativos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow x in dataGrid_bonus_ativos.Rows)
            {
                x.MinimumHeight = 60;
            }
        }

        private void dataGrid_bonus_pers_ativos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid_bonus_pers_ativos.Rows.Count == 0)
            {
                return;
            }
            try
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                DataGridViewRow row = dataGrid_bonus_pers_ativos.Rows[e.RowIndex];

                id_bonus = (int)row.Cells[0].Value;

                dataGrid_bonus_pers_ativos.CurrentRow.Selected = true;
            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO click na grid ", "Erro:" + a);
            }


        }

        private void dataGrid_bonus_pers_ativos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow x in dataGrid_bonus_pers_ativos.Rows)
            {
                x.MinimumHeight = 60;
            }
        }

        private void iconButton_Remover_bonus_pers_Click(object sender, EventArgs e)
        {
            if (id_bonus == 0)
            {
                MessageBox.Show("Selecione um Bônus para remover do seu personagem!");
            }
            else
            {
                Conexao_BD.remover_bonus_personagem(id_bonus, Campanha.id_personagem);
                Carregar_dataGrid_bonus_pers_ativos();
            }
        }

        private void Tela_bonus_FormClosed(object sender, FormClosedEventArgs e)
        {
            TelaBonusFechada?.Invoke(this, EventArgs.Empty);
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
    }
}