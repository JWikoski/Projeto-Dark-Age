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
        public static int id_item;
        public Lista_itens()
        {
            InitializeComponent();
        }

        private void Lista_itens_Load(object sender, EventArgs e)
        {
            carregar_data_grid();
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
                this.text_descricao.Text = row.Cells[5].Value.ToString();
                id_item = (int)row.Cells[0].Value;
            } catch (Exception a)
            {
                MessageBox.Show("ERRO click na grid ", "Erro:" + a);
            }            
        }

        private void btn_adicionar_Click_1(object sender, EventArgs e)
        {
            editar_adicionar = false;
            adicionar_editar_itens adicionar = new adicionar_editar_itens();
            adicionar.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            editar_adicionar = true;
            adicionar_editar_itens adicionar = new adicionar_editar_itens();
            adicionar.ShowDialog();
        }

        public static void carregar_data_grid()
        {
            try
            {                
                Grid_lista_itens.DataSource = Conexao_BD.select_data_gridlist();

                Grid_lista_itens.Columns["id_itens"].HeaderText = "ID";
                Grid_lista_itens.Columns["nome_itens"].HeaderText = "Nome";
                Grid_lista_itens.Columns["dificuldade"].HeaderText = "Dificuldade";
                Grid_lista_itens.Columns["nome_tipo_itens"].HeaderText = "Tipo do Item";
                Grid_lista_itens.Columns["nome_profissao"].HeaderText = "Profissão";

                Grid_lista_itens.Columns["descricao"].Visible = false;

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
                conn.Close();
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
    }
}
