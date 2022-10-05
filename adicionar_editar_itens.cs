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
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Dark_Age
{
    public partial class adicionar_editar_itens : Form
    {
        public adicionar_editar_itens()
        {
            InitializeComponent();
        }

        private void adicionar_editar_itens_Load(object sender, EventArgs e)
        {

            //Carrega as profissãoao abrir a tela
            try
            {
                NpgsqlDataAdapter dt_adapter_profissao = new NpgsqlDataAdapter($@"select id_profissao
                                                                                       , nome_profissao
                                                                                    from ""Dark_Age_Connection"".""Profissao""
                                                                                   order by id_profissao ;", Conexao_BD.Caminho_DB());

                DataTable dt_table_retorno_profissao = new DataTable();

                dt_adapter_profissao.Fill(dt_table_retorno_profissao);

                this.combox_profissao.DataSource = dt_table_retorno_profissao;

                this.combox_profissao.ValueMember = "id_profissao";
                this.combox_profissao.DisplayMember = "nome_profissao";

            } catch (NpgsqlException a)
            {
                MessageBox.Show("ERRO", "Erro:" + a);
            }

            //carrega os enum do tipo da base de dados
            try
            {
                NpgsqlDataAdapter dt_adapter_tipo = new NpgsqlDataAdapter($@"SELECT enumlabel AS nome_enum_tipo
                                                                                  , enumsortorder   AS ordem  
                                                                               from pg_type t 
                                                                               JOIN pg_enum e ON t.oid = e.enumtypid 
                                                                              WHERE typname = 'enum_tipo_itens' 
                                                                              order by ordem  ;", Conexao_BD.Caminho_DB());

                DataTable dt_table_retorno_tipo = new DataTable();

                dt_adapter_tipo.Fill(dt_table_retorno_tipo);

                this.combox_tipo.DataSource = dt_table_retorno_tipo;

                this.combox_tipo.ValueMember = "nome_enum_tipo";
                this.combox_tipo.DisplayMember = "nome_enum_tipo";

            } catch (NpgsqlException a)
            {
                MessageBox.Show("ERRO", "Erro:" + a);
            }

            //carrega os enum do dificuldade da base de dados
            try
            {
                NpgsqlDataAdapter dt_adapter_difi = new NpgsqlDataAdapter($@"SELECT enumlabel AS nome_enum_difi
                                                                                  , enumsortorder   AS ordem
                                                                               from pg_type t 
                                                                               JOIN pg_enum e ON t.oid = e.enumtypid 
                                                                              WHERE typname = 'enum_dificuldade' 
                                                                              order by ordem;", Conexao_BD.Caminho_DB());

                DataTable dt_table_retorno_difi = new DataTable();

                dt_adapter_difi.Fill(dt_table_retorno_difi);

                this.combox_dificuldade.DataSource = dt_table_retorno_difi;

                this.combox_dificuldade.ValueMember = "nome_enum_difi";
                this.combox_dificuldade.DisplayMember = "nome_enum_difi";

            } catch (NpgsqlException a)
            {
                MessageBox.Show("ERRO", "Erro:" + a);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void combox_profissao_Click(object sender, EventArgs e)
        {

        }

        private void combox_dificuldade_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void combox_profissao_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void combox_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

