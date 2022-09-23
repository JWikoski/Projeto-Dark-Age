using Dark_Age.Enteties;
using Npgsql;
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
    public partial class Lista_itens : Form
    {
        public Lista_itens()
        {
            InitializeComponent();
        }

        private void Lista_itens_Load(object sender, EventArgs e)
        {
            try
            {
                NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter($@"select id_itens 
	                                                                         , nome_itens 
	                                                                         , dificuldade 
	                                                                         , tipo_itens
	                                                                         , nome_profissao
                                                                             , descricao   
                                                                          from ""Dark_Age_Connection"".""Itens""
                                                                          join ""Dark_Age_Connection"".""Profissao"" on id_profissao = fk_id_profissao  ;",Conexao_BD.Caminho_DB());
                NpgsqlCommandBuilder cBuilder = new NpgsqlCommandBuilder(dt_adapter);
                DataTable dt_table = new DataTable();

                dt_adapter.Fill(dt_table);
                Grid_lista_itens.DataSource = dt_table;

                Grid_lista_itens.Columns["id_itens"].HeaderText = "ID";
                Grid_lista_itens.Columns["nome_itens"].HeaderText = "Nome";
                Grid_lista_itens.Columns["dificuldade"].HeaderText = "Dificuldade";
                Grid_lista_itens.Columns["tipo_itens"].HeaderText = "Tipo do Item";
                Grid_lista_itens.Columns["nome_profissao"].HeaderText = "Profissão";

                Grid_lista_itens.Columns["descricao"].Visible = false;

            } catch (NpgsqlException a)
            {
                MessageBox.Show("ERRO", "Erro:" + a);
            }
        }

        private void Grid_lista_itens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.Grid_lista_itens.Rows[e.RowIndex];
            this.text_descricao.Text = row.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adicionar_editar_itens adicionar = new adicionar_editar_itens();
            adicionar.ShowDialog();
        }
    }
}
