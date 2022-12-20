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
        public static Color bordas; 
        public static int id_item = 0;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public int qtd = 1;
        public Boolean filtros = true;
        public Lista_itens()
        {
            InitializeComponent();
        }

        private void Lista_itens_Load(object sender, EventArgs e)
        {          
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
                text_descricao.Text = row.Cells[5].Value.ToString();
                id_item = (int)row.Cells[0].Value;
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

            Grid_lista_itens.DataSource = Conexao_BD.select_data_gridlist();
            carregar_data_grid();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            editar_adicionar = true;
            bordas = Color.FromArgb(112, 38, 192);
            adicionar_editar_itens adicionar = new adicionar_editar_itens();
            adicionar.ShowDialog();

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
                Grid_lista_itens.Columns["id_itens"].HeaderText = "ID";
                Grid_lista_itens.Columns["nome_itens"].HeaderText = "Nome";
                Grid_lista_itens.Columns["dificuldade"].HeaderText = "Dificuldade";
                Grid_lista_itens.Columns["nome_tipo_itens"].HeaderText = "Tipo do Item";
                Grid_lista_itens.Columns["nome_profissao"].HeaderText = "Profissão";
                Grid_lista_itens.Columns["descricao"].Visible = false;
                Grid_lista_itens.Columns["material"].HeaderText = "Material";
                Grid_lista_itens.Columns["dano"].Visible = false;
                if (Grid_lista_itens.Rows.Count > 0)
                {
                    Grid_lista_itens.Rows[0].Selected = true;
                    DataGridViewRow cell1 = Grid_lista_itens.Rows[0];
                    text_descricao.Text = cell1.Cells[5].Value.ToString();
                    text_descricao.Text += "\n\r \n\rDano: "+cell1.Cells[7].Value.ToString();
                    id_item = (int)cell1.Cells[0].Value;
                }
                foreach (DataGridViewRow x in Grid_lista_itens.Rows)
                {
                    x.MinimumHeight = 30;
                }

            } catch (Exception a)
            {
                MessageBox.Show("ERRO no data grid ", "Erro:" + a);
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
            BindingSource bs = new BindingSource();
            bs.DataSource = Grid_lista_itens.DataSource;
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

            if(filtros == false && cbx_materiais.Text == "Mostrar tudo")
            {

                bs.Filter = Grid_lista_itens.Rows+" like true";

            }

            Grid_lista_itens.DataSource = bs;
            pnl_filtro.Visible = false;

            if (filtro_dificuldade.Checked == false && filtro_profissoes.Checked == false && filtro_tipo.Checked == false)
            {
                    Grid_lista_itens.DataSource = Conexao_BD.select_data_gridlist();
                    carregar_data_grid();
                    limpar_filtros1.Visible = false;
            }

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
            if (filtro_dificuldade.Checked == false && filtro_profissoes.Checked == false && filtro_tipo.Checked == false)
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
        }

        private void filtro_dificuldade_CheckedChanged(object sender, EventArgs e)
        {
            if(filtro_dificuldade.Checked == true)
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


        private void Grid_lista_itens_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow x in Grid_lista_itens.Rows)
            {
                x.MinimumHeight = 30;
            }
        }
        private void btn_adicionar_inv_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O inventário automático ainda está em desenvolvimento :( Por favor, adicione o item manualmente pela tela principal > Inventário");
            //if (id_item > 0)
            //{
            //    Conexao_BD.insert_item_inventario(id_item, qtd);
            //} else
            //{
            //    MessageBox.Show("Selecione o item antes de inserir no inventario!");
            //}
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
            if(qtd == 1)
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

    }
}
