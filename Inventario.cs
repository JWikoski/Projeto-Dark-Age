using Dark_Age.Enteties;
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
        
        public int qtd = 1;
        public int qtd_remover = 1;
        public Boolean filtros = true;
        public int id_item;
        public int id_item_equipado;
        public Boolean status;
        public int item_especifico = 0;

        public int temp = 0;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public Inventario()
        {
            InitializeComponent();
            Screen screen = Screen.FromPoint(Cursor.Position);
            this.Location = screen.Bounds.Location;

            moedas_ouro.Value = moedas_de_ouro;
            moedas_prata.Value = moedas_de_prata;

            text_descricao.BackColor = Temas.cor_principal;
            combox_profissao.BackColor = Temas.cor_principal_secundaria;
            cbx_materiais.BackColor = Temas.cor_principal_secundaria;
            combox_dificuldade.BackColor = Temas.cor_principal_secundaria;
            combox_tipo.BackColor = Temas.cor_principal_secundaria;
            pnl_filtro.BackColor = Temas.cor_principal_secundaria;
            pnl_remover_item.BackColor = Temas.cor_principal_secundaria;

            this.BackColor = Temas.cor_principal;
            Temas.mudar_cor_data_grid(data_grid_equipados);
            Temas.mudar_cor_data_grid(Grid_lista_inventario);

            iconButton6.IconChar = FontAwesome.Sharp.IconChar.Minimize;
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (minmax == false && e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void Inventario_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0

            this.SetStyle(
           ControlStyles.AllPaintingInWmPaint |
           ControlStyles.UserPaint |
           ControlStyles.DoubleBuffer,
           true);

            timer2.Interval = 10;
            timer2.Tick += new EventHandler(fadeOut);
            timer3.Interval = 10;
            timer3.Tick += new EventHandler(fadeIn2);
            timer1.Interval = 5;  //we'll increase the opacity every 10ms
            timer1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            timer1.Start();

            Grid_lista_inventario.DataSource = Conexao_BD.select_inventário(item_especifico);
            carregar_data_grid();
            data_grid_equipados.DataSource = Conexao_BD.select_itens_equipados();
            carregar_data_grid_equipados();

            //Carrega as profissãoao abrir a tela
            combox_profissao.DataSource = Conexao_BD.select_profissao();
            combox_profissao.ValueMember = "id_profissao";
            combox_profissao.DisplayMember = "nome_profissao";
            //carrega os tipos dos itens
            combox_tipo.DataSource = Conexao_BD.select_tipo_itens();
            combox_tipo.ValueMember = "id_tipo_itens";
            combox_tipo.DisplayMember = "nome_tipo_itens";
            //carrega os enum do dificuldade da base de dados
            combox_dificuldade.DataSource = Conexao_BD.select_enums();
            combox_dificuldade.ValueMember = "nome_enum_difi";
            combox_dificuldade.DisplayMember = "nome_enum_difi";
        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                timer1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.1;
        }

        void fadeIn2(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                timer1.Stop();
                timer3.Stop();
            }
            else
            {
                Opacity += 0.10;
            }

        }
        void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                if (minmax == true)
                {
                    this.WindowState = FormWindowState.Normal;
                    iconButton6.IconChar = FontAwesome.Sharp.IconChar.Square;
                    this.CenterToScreen();
                    minmax = false;
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                    iconButton6.IconChar = FontAwesome.Sharp.IconChar.Minimize;
                    minmax = true;
                }
                timer2.Stop();
                timer3.Start();
            }
            else
            {
                Opacity -= 1;
            }
        }
        private void Grid_lista_itens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                DataGridViewRow row = Grid_lista_inventario.Rows[e.RowIndex];
                text_descricao.Text = row.Cells[5].Value.ToString();
                if (row.Cells[7].Value.ToString() != "")
                {
                    text_descricao.Text += "\n\r \n\rDano: " + row.Cells[7].Value.ToString();
                }
                id_item = (int)row.Cells[0].Value;
                qtd = (int)row.Cells[8].Value;

                label9.Text = ("Você tem " + qtd + " " + row.Cells[1].Value.ToString()+"!");
            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO click na grid ", "Erro:" + a);
            }
        }
        private void BindGrid()
        {
            Grid_lista_inventario.AllowUserToAddRows = false;
            Grid_lista_inventario.Columns.Clear();
            if (cmp_procura.Text == "")
            {
                Grid_lista_inventario.DataSource = Conexao_BD.select_inventário(item_especifico);
                carregar_data_grid();
            }
            else
            {
                string procura_nome = cmp_procura.Text;
                Grid_lista_inventario.DataSource = Conexao_BD.filtro_inventario(procura_nome);
                carregar_data_grid();
            }
        }

        public void carregar_data_grid()
        {
            try
            {
                Grid_lista_inventario.Columns["id_itens"].HeaderText = "ID";
                Grid_lista_inventario.Columns["nome_itens"].HeaderText = "Nome";
                Grid_lista_inventario.Columns["dificuldade"].HeaderText = "Dificuldade";
                Grid_lista_inventario.Columns["nome_tipo_itens"].HeaderText = "Tipo do Item";
                Grid_lista_inventario.Columns["nome_profissao"].HeaderText = "Profissão";
                Grid_lista_inventario.Columns["descricao"].Visible = false;
                Grid_lista_inventario.Columns["material"].HeaderText = "Material";
                Grid_lista_inventario.Columns["quantidade"].HeaderText = "Quantidade";
                Grid_lista_inventario.Columns["dano"].Visible = false;
                Grid_lista_inventario.Columns["equipado"].Visible = false;
                Grid_lista_inventario.Columns["id_itens"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Grid_lista_inventario.Columns["dificuldade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Grid_lista_inventario.Columns["nome_profissao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Grid_lista_inventario.Columns["nome_tipo_itens"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Grid_lista_inventario.Columns["material"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Grid_lista_inventario.Columns["quantidade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Grid_lista_inventario.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                if (Grid_lista_inventario.Rows.Count > 0)
                {
                    Grid_lista_inventario.Rows[0].Selected = true;
                    DataGridViewRow cell1 = Grid_lista_inventario.Rows[0];
                    text_descricao.Text = cell1.Cells[5].Value.ToString();
                    if (cell1.Cells[7].Value.ToString() != "")
                    {
                        text_descricao.Text += "\n\r \n\rDano: " + cell1.Cells[7].Value.ToString();
                    }
                    id_item = (int)cell1.Cells[0].Value;
                    qtd = (int)cell1.Cells[8].Value;

                    label9.Text = ("Você tem "+ qtd + " "+cell1.Cells[1].Value.ToString());
                }
                foreach (DataGridViewRow x in Grid_lista_inventario.Rows)
                {
                    x.MinimumHeight = 40;
                }

            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO no data grid ", "Erro:" + a);
            }

        }
        public void carregar_data_grid_equipados()
        {
            try
            {
                data_grid_equipados.DataSource = Conexao_BD.select_itens_equipados();

                data_grid_equipados.Columns["id_itens"].Visible = false;
                data_grid_equipados.Columns["nome_itens"].HeaderText = "Nome";
                data_grid_equipados.Columns["dano"].HeaderText = "Dano";
                data_grid_equipados.Columns["equipado"].Visible = false;
                data_grid_equipados.Columns["id_itens"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                
                if (data_grid_equipados.Rows.Count > 0)
                {
                    data_grid_equipados.Rows[0].Selected = true;
                    DataGridViewRow row2 = data_grid_equipados.Rows[0];
                    id_item_equipado = (int)row2.Cells[0].Value;
                }
                foreach (DataGridViewRow x in data_grid_equipados.Rows)
                {
                    x.MinimumHeight = 30;
                }

            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO no data grid equipados", "Erro:" + a);
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(pnl_filtro.Visible == false)
            {
                pnl_filtro.Visible = true;
            }
            else
            {
                pnl_filtro.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Grid_lista_inventario.DataSource;
            limpar_filtros1.Visible = true;
            if (filtro_dificuldade.Checked == true && filtro_profissoes.Checked == false && filtro_tipo.Checked == false)
            {

                bs.Filter = "dificuldade LIKE '" + combox_dificuldade.Text + "'";

            }
            else if (filtro_dificuldade.Checked == false && filtro_profissoes.Checked == true && filtro_tipo.Checked == false)
            {

                bs.Filter = "nome_profissao LIKE '" + combox_profissao.Text + "'";

            }
            else if (filtro_dificuldade.Checked == false && filtro_profissoes.Checked == false && filtro_tipo.Checked == true)
            {

                bs.Filter = "nome_tipo_itens LIKE '" + combox_tipo.Text + "'";

            }
            else if (filtro_dificuldade.Checked == true && filtro_profissoes.Checked == true && filtro_tipo.Checked == false)
            {

                bs.Filter = "dificuldade LIKE '" + combox_dificuldade.Text + "' and nome_profissao LIKE '" + combox_profissao.Text + "'";

            }
            else if (filtro_dificuldade.Checked == true && filtro_profissoes.Checked == false && filtro_tipo.Checked == true)
            {

                bs.Filter = "dificuldade LIKE '" + combox_dificuldade.Text + "' and nome_tipo_itens LIKE '" + combox_tipo.Text + "'";

            }
            else if (filtro_dificuldade.Checked == false && filtro_profissoes.Checked == true && filtro_tipo.Checked == true)
            {

                bs.Filter = "nome_profissao LIKE '" + combox_profissao.Text + "' and nome_tipo_itens LIKE '" + combox_tipo.Text + "'";

            }
            else if (filtro_dificuldade.Checked == true && filtro_profissoes.Checked == true && filtro_tipo.Checked == true)
            {

                bs.Filter = "dificuldade LIKE '" + combox_dificuldade.Text + "' and nome_tipo_itens LIKE '" + combox_tipo.Text + "' and nome_profissao LIKE '" + combox_profissao.Text + "'";

            }
            else
            {
                filtros = false;
            }

            if (filtros == false && cbx_materiais.Text == "Mostrar tudo")
            {

                bs.Filter = Grid_lista_inventario.Rows + " like true";

            }

            Grid_lista_inventario.DataSource = bs;
            pnl_filtro.Visible = false;

            if (filtro_dificuldade.Checked == false && filtro_profissoes.Checked == false && filtro_tipo.Checked == false)
            {
                Grid_lista_inventario.DataSource = Conexao_BD.select_inventário(item_especifico);
                carregar_data_grid();
                limpar_filtros1.Visible = false;
            }

            foreach (DataGridViewRow x in Grid_lista_inventario.Rows)
            {
                x.MinimumHeight = 40;
            }
        }
        private void limpar_filtros2_Click(object sender, EventArgs e)
        {
            limpar_filtros();
        }
        private void limpar_filtros()
        {
            filtro_tipo.Checked = false;
            filtro_profissoes.Checked = false;
            filtro_dificuldade.Checked = false;
            limpar_filtros1.Visible = false;
            limpar_filtros2.Visible = false;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
            pictureBox1.Image = global::Dark_Age.Properties.Resources.mochila_aberta;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(224, 224, 224);
            pictureBox1.Image = global::Dark_Age.Properties.Resources.mochila_fechada;
        }

        private void iconButton4_MouseEnter(object sender, EventArgs e)
        {
            iconButton4.ForeColor = Color.White;
            iconButton4.IconColor = Color.White;
        }

        private void iconButton4_MouseLeave(object sender, EventArgs e)
        {
            iconButton4.ForeColor = Color.FromArgb(224, 224, 224);
            iconButton4.IconColor = Color.FromArgb(224, 224, 224);
        }
        private void filtro_dificuldade_CheckedChanged(object sender, EventArgs e)
        {
            if (filtro_dificuldade.Checked == true)
            {
                limpar_filtros2.Visible = true;
            }
        }

        private void filtro_tipo_CheckedChanged(object sender, EventArgs e)
        {
            if (filtro_tipo.Checked == true)
            {
                limpar_filtros2.Visible = true;
            }
        }
        private void filtro_profissoes_CheckedChanged(object sender, EventArgs e)
        {
            if (filtro_profissoes.Checked == true)
            {
                limpar_filtros2.Visible = true;
            }
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            Conexao_BD.mudar_moedas(moedas_de_ouro, moedas_de_prata, Campanha.id_personagem);
            this.Close();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Lista_itens lista = new Lista_itens();
            lista.ShowDialog();
            Grid_lista_inventario.DataSource = Conexao_BD.select_inventário(item_especifico);
            carregar_data_grid();
            carregar_data_grid_equipados();
            limpar_filtros1.Visible = false;
        }

        private void limpar_filtros1_Click(object sender, EventArgs e)
        {
            filtro_tipo.Checked = false;
            filtro_profissoes.Checked = false;
            filtro_dificuldade.Checked = false;
            Grid_lista_inventario.DataSource = Conexao_BD.select_inventário(item_especifico);
            carregar_data_grid();
            limpar_filtros1.Visible = false;
            limpar_filtros2.Visible = false;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            pnl_filtro.Visible = false;
            if (filtro_dificuldade.Checked == false && filtro_profissoes.Checked == false && filtro_tipo.Checked == false)
            {
                Grid_lista_inventario.DataSource = Conexao_BD.select_inventário(item_especifico);
                carregar_data_grid();
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.FromArgb(255, 128, 128);
            pictureBox2.Image = global::Dark_Age.Properties.Resources.lixo_aberto1;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.LightSalmon;
            pictureBox2.Image = global::Dark_Age.Properties.Resources.lixo_fechado1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            status = true;
            Conexao_BD.equipar_item(id_item, status);
            Grid_lista_inventario.DataSource = Conexao_BD.select_inventário(item_especifico);
            carregar_data_grid();
            carregar_data_grid_equipados();
            limpar_filtros();
        }

        private void cmp_procura_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void combox_dificuldade_Click(object sender, EventArgs e)
        {
            filtro_dificuldade.Checked = true;
        }
        private void combox_profissao_Click(object sender, EventArgs e)
        {
            filtro_profissoes.Checked = true;
        }
        private void combox_tipo_Click(object sender, EventArgs e)
        {
            filtro_tipo.Checked = true;
        }

        private void Grid_lista_inventario_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow x in Grid_lista_inventario.Rows)
            {
                x.MinimumHeight = 40;
            }
        }

        private void data_grid_equipados_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow x in data_grid_equipados.Rows)
            {
                x.MinimumHeight = 30;
            }
        }

        private void btn_eliminar_campanha_MouseEnter(object sender, EventArgs e)
        {
            btn_desequipar.ForeColor = Color.Salmon;
            btn_desequipar.IconColor = Color.Salmon;
        }

        private void btn_eliminar_campanha_MouseLeave(object sender, EventArgs e)
        {
            btn_desequipar.ForeColor = Color.LightSalmon;
            btn_desequipar.IconColor = Color.LightSalmon;
        }

        private void btn_desequipar_Click(object sender, EventArgs e)
        {
            status = false;
            Conexao_BD.equipar_item(id_item_equipado, status);
            Grid_lista_inventario.DataSource = Conexao_BD.select_inventário(item_especifico);
            carregar_data_grid();
            limpar_filtros();
            carregar_data_grid_equipados();
        }

        private void iconButton3_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, Color.White);
            button.FlatAppearance.BorderColor = Color.FromArgb(200, Color.White);
        }

        private void limpar_filtros2_Click_1(object sender, EventArgs e)
        {
            filtro_tipo.Checked = false;
            filtro_profissoes.Checked = false;
            filtro_dificuldade.Checked = false;
            limpar_filtros1.Visible = false;
            limpar_filtros2.Visible = false;
        }

        private void data_grid_equipados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                DataGridViewRow row = data_grid_equipados.Rows[e.RowIndex];
                id_item_equipado = (int)row.Cells[0].Value;
            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO click na grid ", "Erro:" + a);
            }
        }

        private void moedas_ouro_ValueChanged(object sender, EventArgs e)
        {
            moedas_de_ouro = (int)moedas_ouro.Value;
            Conexao_BD.mudar_moedas(moedas_de_ouro, moedas_de_prata, Campanha.id_personagem);
        }
        private void moedas_prata_ValueChanged(object sender, EventArgs e)
        {
            moedas_de_prata = (int)moedas_prata.Value;
            Conexao_BD.mudar_moedas(moedas_de_ouro, moedas_de_prata, Campanha.id_personagem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(qtd <= 1)
            {
                Conexao_BD.delete_item_inventario(id_item);
                Grid_lista_inventario.DataSource = Conexao_BD.select_inventário(item_especifico);
                carregar_data_grid();
                carregar_data_grid_equipados();
                limpar_filtros();
            }
            else
            {
                pnl_remover_item.BringToFront();
                pnl_remover_item.Visible = true;
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            pnl_remover_item.SendToBack();
            pnl_remover_item.Visible = false;
        }

        private void Inventario_Click(object sender, EventArgs e)
        {
            qtd_remover = 1;
            lbl_qtd.Text = qtd_remover.ToString();
            pnl_remover_item.SendToBack();
            pnl_remover_item.Visible = false;
            remove_qtd.Visible = false;
        }
        private void adiciona_qtd_Click(object sender, EventArgs e)
        {
            if(qtd_remover < qtd)
            {
                qtd_remover++;
                lbl_qtd.Text = qtd_remover.ToString();
            }
            
            if (qtd_remover > 1)
            {
                remove_qtd.Visible = true;
            }
        }

        private void remove_qtd_Click(object sender, EventArgs e)
        {
            qtd_remover--;
            lbl_qtd.Text = qtd_remover.ToString();

            if (qtd_remover == 1)
            {
                remove_qtd.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            qtd = qtd - qtd_remover;

            if (qtd == 0)
            {
                Conexao_BD.delete_item_inventario(id_item);
                Grid_lista_inventario.DataSource = Conexao_BD.select_inventário(item_especifico);
                carregar_data_grid();
                carregar_data_grid_equipados();
            }
            else
            {
                Conexao_BD.update_qtd_inventario(id_item, qtd);
            Grid_lista_inventario.DataSource = Conexao_BD.select_inventário(item_especifico);
                carregar_data_grid();
                carregar_data_grid_equipados();
            }
            pnl_remover_item.SendToBack();
            pnl_remover_item.Visible = false;
            limpar_filtros();
        }

        private void iconButton5_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Color cor = button.ForeColor;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, cor);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            qtd_remover = qtd;
            lbl_qtd.Text = qtd_remover.ToString();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
    }
}
