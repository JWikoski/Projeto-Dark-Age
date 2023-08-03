using Dark_Age.Enteties;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dark_Age
{
    public partial class Lista_itens : Form
    {
        public static Boolean editar_adicionar;
        public static Boolean material;
        public static Color bordas;
        public static int id_item = 0;
        public static int qtd_item_inventario = 0;
        public static int id_personagem;
        public static Boolean produzir = true;
        public static Boolean itens_produziveis = false;

        public static Boolean procura_item;
        public static string nome_procura_item;


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public int qtd = 1;
        public Boolean filtros = true;
        public Lista_itens()
        {
            InitializeComponent();
            grid_ingredientes.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dataGridView1_DataBindingComplete);

            this.BackColor = Temas.cor_principal;
            panel3.BackColor = Temas.cor_principal;
            panel5.BackColor = Temas.cor_principal_secundaria;
            text_descricao.BackColor = Temas.cor_principal_secundaria;
            combox_profissao.BackColor = Temas.cor_principal_secundaria;
            cbx_materiais.BackColor = Temas.cor_principal_secundaria;
            combox_dificuldade.BackColor = Temas.cor_principal_secundaria;
            combox_tipo.BackColor = Temas.cor_principal_secundaria;
            pnl_filtro.BackColor = Temas.cor_principal_secundaria;
            cmp_procura.BackColor = Temas.cor_principal_secundaria;
            cbx_materiais.SelectedIndex = 0;
            pnl_filtro.Location = new Point(150, 98);

            pnl_producao.Location = new Point(1130, 602);
            pnl_enviar.Location = new Point(1130, 602);

            Temas.mudar_cor_data_grid(Grid_lista_itens);
            Temas.mudar_cor_data_grid(Grid_lista_personagens);

            Grid_lista_personagens.DefaultCellStyle.SelectionBackColor = Color.FromArgb(50, 50, 67);

            grid_ingredientes.BackgroundColor = Temas.cor_principal;
            grid_ingredientes.ColumnHeadersDefaultCellStyle.BackColor = Temas.cor_principal;
            grid_ingredientes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Transparent;
            grid_ingredientes.DefaultCellStyle.BackColor = Temas.cor_principal;
            grid_ingredientes.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            grid_ingredientes.RowHeadersDefaultCellStyle.BackColor = Temas.cor_principal;
            grid_ingredientes.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Transparent;
        }

        private void Lista_itens_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0

            timer1.Interval = 5;  //we'll increase the opacity every 10ms
            timer1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            timer1.Start();

            Grid_lista_itens.DataSource = Conexao_BD.select_data_gridlist();
            carregar_data_grid();
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

            qtd_lbl();
            carregar_personagens();

            if (procura_item == true)
            {
                cmp_procura.Text = nome_procura_item;
                procura_item = false;
                limpar_filtros1.Visible = true;
            }
        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                timer1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.1;
        }
        public void remove_filtros()
        {

            filtro_tipo.Checked = false;
            filtro_profissoes.Checked = false;
            filtro_dificuldade.Checked = false;
            Grid_lista_itens.DataSource = Conexao_BD.select_data_gridlist();
            carregar_data_grid();
            limpar_filtros1.Visible = false;
            limpar_filtros2.Visible = false;
            cmp_procura.Text = "";
        }

        private void carregar_personagens()
        {

            Grid_lista_personagens.DataSource = Conexao_BD.select_personagem_campanha(0, Campanha.id_campanha, 1);

            if (Grid_lista_personagens.Rows.Count > 0)
            {
                Grid_lista_personagens.Rows[0].Selected = true;
                DataGridViewRow row_personagem = Grid_lista_personagens.Rows[0];
                id_personagem = (int)row_personagem.Cells[0].Value;
            }
            try
            {
                Grid_lista_personagens.Columns["id_personagem"].Visible = false;
                Grid_lista_personagens.Columns["nome_classe"].Visible = false;
                Grid_lista_personagens.Columns["nivel"].Visible = false;
                Grid_lista_personagens.Columns["fk_id_classe"].Visible = false;
                Grid_lista_personagens.Columns["id_entidade"].Visible = false;
                Grid_lista_personagens.Columns["imagem"].Visible = false;
                Grid_lista_personagens.Columns["nome_jogador"].Visible = false;
                Grid_lista_personagens.Columns["nome_personagem"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                Grid_lista_personagens.Columns["nome_personagem"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO no carregar as informações", "Erro:" + a);
            }
            foreach (DataGridViewRow x in Grid_lista_personagens.Rows)
            {
                x.MinimumHeight = 60;
            }
        }

        private void carregar_ingredientes()
        {
            label2.Text = "Ingredientes para fabricação deste item";
            label12.Visible = false;
            grid_ingredientes.DataSource = Conexao_BD.select_materiais_criacao(id_item);

            try
            {
                if (grid_ingredientes.Rows.Count > 0)
                {
                    grid_ingredientes.Rows[0].Selected = true;
                }
                grid_ingredientes.Columns["nome_itens"].HeaderText = "Ingrediente";
                grid_ingredientes.Columns["quantidade"].HeaderText = "Possui";
                grid_ingredientes.Columns["qnt_material"].HeaderText = "Requisito";
                grid_ingredientes.Columns["ingrediente"].Visible = false;
                grid_ingredientes.Columns["id_itens"].Visible = false;
                grid_ingredientes.Columns["qnt_criacao"].Visible = false;
                grid_ingredientes.Columns["quantidade"].DefaultCellStyle.NullValue = "0";
                grid_ingredientes.Columns["qnt_material"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                grid_ingredientes.Columns["quantidade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                grid_ingredientes.Columns["qnt_material"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grid_ingredientes.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                grid_ingredientes.Columns["quantidade"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grid_ingredientes.Columns["qnt_material"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            catch (Exception a)
            {
                MessageBox.Show("Erro:" + a, "ERRO no carregar as informações");
            }
            foreach (DataGridViewRow x in grid_ingredientes.Rows)
            {
                x.MinimumHeight = 30;
            }
        }

        private void carregar_itens_de_criacao()
        {
            label2.Text = "Itens produzidos com este ingrediente";
            label12.Visible = true;
            grid_ingredientes.DataSource = Conexao_BD.select_itens_criacao(id_item);

            try
            {

                if (grid_ingredientes.Rows.Count > 0)
                {
                    grid_ingredientes.Rows[0].Selected = true;
                }
                grid_ingredientes.Columns["nome_itens"].HeaderText = "Item";
                grid_ingredientes.Columns["qnt_material"].HeaderText = "Usa";
                grid_ingredientes.Columns["quantidade"].HeaderText = "Possui";
                grid_ingredientes.Columns["quantidade"].DefaultCellStyle.NullValue = "0";
                grid_ingredientes.Columns["quantidade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                grid_ingredientes.Columns["qnt_material"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                grid_ingredientes.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grid_ingredientes.Columns["qnt_material"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                grid_ingredientes.Columns["quantidade"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grid_ingredientes.Columns["qnt_material"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception a)
            {
                MessageBox.Show("Erro:" + a, "ERRO no carregar as informações");
            }
            foreach (DataGridViewRow x in grid_ingredientes.Rows)
            {
                x.MinimumHeight = 30;
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
                DataGridViewRow row = Grid_lista_itens.Rows[e.RowIndex];
                if (row.Cells["quantidade"].Value == null || row.Cells["quantidade"].Value == DBNull.Value)
                {
                    qtd_inventario.Text = "Quantidade no inventário: 0";
                }
                else
                {
                    qtd_item_inventario = (int)row.Cells[8].Value;
                    qtd_inventario.Text = "Quantidade no inventário: " + qtd_item_inventario;
                }
                text_descricao.Text = row.Cells[5].Value.ToString();
                if (row.Cells[7].Value.ToString() != "")
                {
                    text_descricao.Text += "\n\r \n\rDano: " + row.Cells[7].Value.ToString();
                }
                id_item = (int)row.Cells[0].Value;
                material = (bool)row.Cells[6].Value;

                if (material == false)
                {
                    carregar_ingredientes();
                }
                else
                {
                    carregar_itens_de_criacao();
                }

                Grid_lista_itens.CurrentRow.Selected = true;

            } catch (Exception a)
            {
                MessageBox.Show("ERRO click na grid ", "Erro:" + a);
            }
        }

        private void btn_adicionar_Click_1(object sender, EventArgs e)
        {
            editar_adicionar = false;
            bordas = Color.FromArgb(45, 196, 118);
            adicionar_editar_itens adicionar = new adicionar_editar_itens();
            adicionar.ShowDialog();
            cmp_procura.Text = "";
            Grid_lista_itens.DataSource = Conexao_BD.select_data_gridlist();
            carregar_data_grid();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            editar_adicionar = true;
            bordas = Color.FromArgb(112, 38, 192);
            adicionar_editar_itens adicionar = new adicionar_editar_itens();
            adicionar.ShowDialog();
            cmp_procura.Text = "";
            Grid_lista_itens.DataSource = Conexao_BD.select_data_gridlist();
            carregar_data_grid();
        }

        private void BindGrid()
        {
            Grid_lista_itens.AllowUserToAddRows = false;
            Grid_lista_itens.Columns.Clear();
            if (cmp_procura.Text == "")
            {
                Grid_lista_itens.DataSource = Conexao_BD.select_data_gridlist();
                carregar_data_grid();
            }
            else
            {
                string procura_nome = cmp_procura.Text;
                Grid_lista_itens.DataSource = Conexao_BD.filtro_data_gridlist(procura_nome);
                carregar_data_grid();
            }
        }

        public void carregar_data_grid()
        {
            try
            {

                if (Grid_lista_itens.Rows.Count > 0)
                {
                    DataGridViewRow cell1 = Grid_lista_itens.Rows[0];
                    material = (bool)cell1.Cells[6].Value;
                }

                Grid_lista_itens.Columns["id_itens"].Visible = false;
                Grid_lista_itens.Columns["nome_itens"].HeaderText = "Nome";
                Grid_lista_itens.Columns["dificuldade"].HeaderText = "Dificuldade";
                Grid_lista_itens.Columns["nome_tipo_itens"].HeaderText = "Tipo do Item";
                Grid_lista_itens.Columns["nome_profissao"].HeaderText = "Profissão";
                Grid_lista_itens.Columns["quantidade"].HeaderText = "No inventário";
                Grid_lista_itens.Columns["nome_itens"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Grid_lista_itens.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid_lista_itens.Columns["descricao"].Visible = false;
                Grid_lista_itens.Columns["material"].HeaderText = "Material";
                Grid_lista_itens.Columns["dano"].Visible = false;
                Grid_lista_itens.Columns["peso"].HeaderText = "Peso";
                Grid_lista_itens.Columns["peso"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Grid_lista_itens.Columns["peso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid_lista_itens.Columns["carga"].HeaderText = "Carga";
                Grid_lista_itens.Columns["carga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Grid_lista_itens.Columns["carga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                if (Grid_lista_itens.Rows.Count > 0)
                {
                    Grid_lista_itens.Rows[0].Selected = true;
                    DataGridViewRow cell1 = Grid_lista_itens.Rows[0];
                    text_descricao.Text = cell1.Cells[5].Value.ToString();
                    material = (bool)cell1.Cells[6].Value;
                    if (cell1.Cells[7].Value.ToString() != "")
                    {
                        text_descricao.Text += "\n\r \n\rDano: " + cell1.Cells[7].Value.ToString();
                    }
                    id_item = (int)cell1.Cells[0].Value;

                    if (material == false)
                    {
                        carregar_ingredientes();
                    }
                    else
                    {
                        carregar_itens_de_criacao();
                    }
                }
                foreach (DataGridViewRow x in Grid_lista_itens.Rows)
                {
                    x.MinimumHeight = 30;
                }


            }
            catch (Exception a)
            {
                MessageBox.Show("Erro:" + a, "ERRO no carregar as informações");
            }

        }



        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja Excluir o item selecionado?", "Excluir item da tabela", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
                conn.Open();
                NpgsqlCommand como = new NpgsqlCommand();
                como.Connection = conn;
                como.CommandType = CommandType.Text;
                como.CommandText = $@"delete from ""Dark_Age_Connection"".""Itens"" 
                                        where id_itens = @id_itens";
                como.Parameters.AddWithValue("@id_itens", id_item);
                como.ExecuteNonQuery();

                como.Dispose();
                conn.Close();
                Grid_lista_itens.DataSource = Conexao_BD.select_data_gridlist();
                carregar_data_grid();
                cmp_procura.Text = "";
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LblFecharPassivas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.BindGrid();
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (pnl_filtro.Visible == true)
            {
                pnl_filtro.Visible = false;
            }
            else
            {
                pnl_filtro.Visible = true;
                pnl_filtro.Focus();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (cbx_materiais.Text == "Apenas itens produzíveis")
            {
                Grid_lista_itens.DataSource = Conexao_BD.select_itens_produziveis(Campanha.id_personagem);

                carregar_data_grid();
                Grid_lista_itens.Columns["quantidade"].HeaderText = "Pode criar";
                Grid_lista_itens.Columns["material"].Visible = false;
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = Grid_lista_itens.DataSource;
            limpar_filtros1.Visible = true;
            if (filtro_dificuldade.Checked == true && filtro_profissoes.Checked == false && filtro_tipo.Checked == false)
            {

                bs.Filter = "dificuldade LIKE '" + combox_dificuldade.Text + "'";
                Grid_lista_itens.DataSource = bs;
            }
            else if (filtro_dificuldade.Checked == false && filtro_profissoes.Checked == true && filtro_tipo.Checked == false)
            {

                bs.Filter = "nome_profissao LIKE '" + combox_profissao.Text + "'";
                Grid_lista_itens.DataSource = bs;
            }
            else if (filtro_dificuldade.Checked == false && filtro_profissoes.Checked == false && filtro_tipo.Checked == true)
            {

                bs.Filter = "nome_tipo_itens LIKE '" + combox_tipo.Text + "'";
                Grid_lista_itens.DataSource = bs;
            }
            else if (filtro_dificuldade.Checked == true && filtro_profissoes.Checked == true && filtro_tipo.Checked == false)
            {

                bs.Filter = "dificuldade LIKE '" + combox_dificuldade.Text + "' and nome_profissao LIKE '" + combox_profissao.Text + "'";
                Grid_lista_itens.DataSource = bs;
            }
            else if (filtro_dificuldade.Checked == true && filtro_profissoes.Checked == false && filtro_tipo.Checked == true)
            {

                bs.Filter = "dificuldade LIKE '" + combox_dificuldade.Text + "' and nome_tipo_itens LIKE '" + combox_tipo.Text + "'";
                Grid_lista_itens.DataSource = bs;
            }
            else if (filtro_dificuldade.Checked == false && filtro_profissoes.Checked == true && filtro_tipo.Checked == true)
            {

                bs.Filter = "nome_profissao LIKE '" + combox_profissao.Text + "' and nome_tipo_itens LIKE '" + combox_tipo.Text + "'";
                Grid_lista_itens.DataSource = bs;

            }
            else if (filtro_dificuldade.Checked == true && filtro_profissoes.Checked == true && filtro_tipo.Checked == true)
            {

                bs.Filter = "dificuldade LIKE '" + combox_dificuldade.Text + "' and nome_tipo_itens LIKE '" + combox_tipo.Text + "' and nome_profissao LIKE '" + combox_profissao.Text + "'";

                Grid_lista_itens.DataSource = bs;
            }
            else
            {
                filtros = false;
            }

            if (filtros == false && cbx_materiais.Text == "Apenas materiais")
            {
                bs.Filter = "material = true";

                Grid_lista_itens.DataSource = bs;
            }
            else if (filtros == true && cbx_materiais.Text == "Apenas materiais")
            {
                bs.Filter += " and material = true";
                Grid_lista_itens.DataSource = bs;
            }



            if (filtros == false && cbx_materiais.Text == "Todos os itens")
            {
                Grid_lista_itens.DataSource = Conexao_BD.select_data_gridlist();
                limpar_filtros1.Visible = false;
                pnl_filtro.Visible = false;
            }


            pnl_filtro.Visible = false;

            carregar_data_grid();

            foreach (DataGridViewRow x in Grid_lista_itens.Rows)
            {
                x.MinimumHeight = 30;
            }
        }


        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 67);
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
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


        private void limpar_filtros2_Click(object sender, EventArgs e)
        {
            filtro_tipo.Checked = false;
            filtro_profissoes.Checked = false;
            filtro_dificuldade.Checked = false;
            limpar_filtros1.Visible = false;
            limpar_filtros2.Visible = false;
            cmp_procura.Text = "";
            cbx_materiais.SelectedIndex = 0;
        }

        private void limpar_filtros2_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, Color.Salmon);
            button.ForeColor = Color.Salmon;
        }

        private void limpar_filtros2_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            pnl_filtro.Visible = false;
            if (filtro_dificuldade.Checked == false && filtro_profissoes.Checked == false && filtro_tipo.Checked == false && cbx_materiais.Text == "Todos os itens")
            {
               Grid_lista_itens.DataSource = Conexao_BD.select_data_gridlist();
               carregar_data_grid();
            }
        }

        private void remove_filtros1_Click(object sender, EventArgs e)
        {
            filtro_tipo.Checked = false;
            filtro_profissoes.Checked = false;
            filtro_dificuldade.Checked = false;
            Grid_lista_itens.DataSource = Conexao_BD.select_data_gridlist();
            carregar_data_grid();
            limpar_filtros1.Visible = false;
            limpar_filtros2.Visible = false;
            cmp_procura.Text = "";
            cbx_materiais.SelectedIndex = 0;
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

        private void btn_adicionar_inv_Click(object sender, EventArgs e)
        {
            if (Campanha.id_jogador == Campanha.id_mestre_campanha)
            {
                pnl_enviar.Visible = true;
                pnl_enviar.BringToFront();
            }
            else if (material == false)
            {
                pnl_producao.Visible = true;
                pnl_producao.BringToFront();
            }
            else
            {
                if (id_item > 0)
                {
                    Conexao_BD.insert_item_inventario(id_item, qtd, Campanha.id_personagem);
                    lbl_qtd.Text = "1";
                    qtd = 1;
                    remove_qtd.Visible = false;
                }
                else
                {
                    MessageBox.Show("Selecione o item antes de inserir no inventario!");
                }
                pnl_producao.Visible = false;
            }
            remove_filtros();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            qtd++;
            qtd_lbl();
            remove_qtd.Visible = true;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (qtd > 1)
            {
                qtd--;
                qtd_lbl();
            }
            if (qtd == 1)
            {
                remove_qtd.Visible = false;
            }
        }
        public void qtd_lbl()
        {
            lbl_qtd.Text = Convert.ToString(qtd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pagina_mestre mestre = new Pagina_mestre();
            mestre.ShowDialog();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (pnl_enviar.Visible == true)
            {
                pnl_enviar.Visible = false;
            }
            else
            {
                pnl_enviar.Visible = true;
            }
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            pnl_enviar.Visible = false;
        }



        private void Grid_lista_personagens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = Grid_lista_personagens.Rows[e.RowIndex];
            id_personagem = (int)row.Cells[0].Value;
        }

        private void enviar_qtd_Click(object sender, EventArgs e)
        {
            if (id_item > 0)
            {
                Conexao_BD.insert_item_inventario(id_item, qtd, id_personagem);
                lbl_qtd.Text = "1";
                qtd = 1;
                remove_qtd.Visible = false;
                pnl_enviar.Visible = false;
                MessageBox.Show("Item adicionado ao inventário! (ツ)👍");
            }
            else
            {
                MessageBox.Show("Selecione o item antes de inserir no inventario!");
            }
        }

        private void grid_ingredientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (material == true)
            {
                try
                {
                    if (e.RowIndex == -1)
                    {
                        return;
                    }
                    DataGridViewRow row_ingrediente = grid_ingredientes.Rows[e.RowIndex];
                    cmp_procura.Text = row_ingrediente.Cells["nome_itens"].Value.ToString();
                    limpar_filtros1.Visible = true;
                }
                catch (Exception a)
                {

                }
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            if (material == false)
            {
                foreach (DataGridViewRow row in grid_ingredientes.Rows)
                {
                    // Obtém o valor da célula na coluna desejada
                    object valorObj = row.Cells["quantidade"].Value;

                    if (!Convert.IsDBNull(valorObj)) // Verifica se o valor não é DBNull
                    {
                        // Converte o valor para o tipo desejado
                        int valor_inv = Convert.ToInt32(valorObj);
                        int valor_cri = (int)row.Cells["qnt_material"].Value;

                        // Verifica o valor e define a cor de fundo da linha
                        if (valor_inv >= valor_cri)
                        {
                            if (Temas.tema_escuro == true)
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(10, 100, 10);
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(110, 220, 110);
                            }
                        }
                        else
                        {
                            if (Temas.tema_escuro == true)
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(100, 10, 10);
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(220, 110, 110);
                            }

                        }
                    }
                    else
                    {
                        if (Temas.tema_escuro == true)
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(100, 10, 10);
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(220, 110, 110);
                        }
                    }
                    row.DefaultCellStyle.SelectionBackColor = row.DefaultCellStyle.BackColor;
                }
            }
            else
            {
                foreach (DataGridViewRow row in grid_ingredientes.Rows)
                {
                    row.DefaultCellStyle.SelectionBackColor = Temas.cor_principal_secundaria;
                }
            }
        }

        private void grid_ingredientes_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow x in grid_ingredientes.Rows)
            {
                x.MinimumHeight = 30;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in grid_ingredientes.Rows)
            {
                // Obtém o valor da célula na coluna desejada
                object obj_qtdinv = row.Cells["quantidade"].Value;
                object obj_requisito = row.Cells["qnt_material"].Value;


                if (!Convert.IsDBNull(obj_qtdinv)) // Verifica se o valor não é DBNull
                {
                    int qtdinv = (int)obj_qtdinv;
                    int requisito = (int)obj_requisito;
                    if (qtdinv < requisito)
                    {
                        produzir = false;
                        MessageBox.Show("Você não tem os ingredientes suficientes para produzir este item!", "Sem ingredientes");
                        break;
                    }
                }
                else
                {
                    produzir = false;
                    MessageBox.Show("Você não tem os ingredientes suficientes para produzir este item!", "Sem ingredientes");
                    break;
                }
            }
            if (produzir == true)
            {
                foreach (DataGridViewRow row in grid_ingredientes.Rows)
                {
                    int qtdinv = (int)row.Cells["quantidade"].Value;
                    int requisito = (int)row.Cells["qnt_material"].Value;
                    int id_item = (int)row.Cells["id_itens"].Value;

                    requisito = qtd * requisito;

                    if (qtdinv == requisito)
                    {
                        Conexao_BD.delete_item_inventario(id_item, Campanha.id_personagem);
                    }
                    else
                    {
                        Conexao_BD.update_qtd_inventario(id_item, qtdinv - requisito, Campanha.id_personagem);
                    }
                }
                Conexao_BD.insert_item_inventario(id_item, qtd, Campanha.id_personagem);
                lbl_qtd.Text = "1";
                qtd = 1;
                remove_qtd.Visible = false;
                MessageBox.Show("Item produzido com sucesso!");
            }

            produzir = true;
            remove_filtros();
            pnl_producao.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Campanha.id_jogador == Campanha.id_mestre_campanha)
            {
                pnl_enviar.Visible = true;
                pnl_enviar.BringToFront();
            }
            else
            {
                if (id_item > 0)
                {
                    Conexao_BD.insert_item_inventario(id_item, qtd, Campanha.id_personagem);
                    lbl_qtd.Text = "1";
                    qtd = 1;
                    remove_qtd.Visible = false;
                }
                else
                {
                    MessageBox.Show("Selecione o item antes de inserir no inventario!");
                }
                pnl_producao.Visible = false;
            }
            remove_filtros();
        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            pnl_producao.Visible = false;
        }

        private void Grid_lista_itens_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Grid_lista_itens_CellClick(sender, e);
        }
    }
}
