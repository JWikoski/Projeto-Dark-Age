using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Dark_Age.Enteties
{
    public static class Conexao_BD
    {
        public static string Caminho_DB()
        {
            return "Server=db.lrtxyttihecehnpzgeus.supabase.co;Port=5432;Database=postgres;user Id=postgres;Password=ProjetoDark@ge123";
            //return "Server=26.45.149.194;Port=5432;Database=DarkAge_Server;user Id=João;Password=ANlsPD80";
        }

        public static void Select_historia_e_anotacoes(ref string historia, ref string anotacoes)
        {

            using NpgsqlConnection conn = new NpgsqlConnection(Caminho_DB());
            conn.Open();
            using NpgsqlCommand comt = new NpgsqlCommand();
            comt.Connection = conn;
            comt.CommandType = CommandType.Text;
            comt.CommandText = "select historia_campanha, anotacoes_campanha from \"Dark_Age_Connection\".\"Campanha\" where id_campanha = @id_campanha";
            comt.Parameters.AddWithValue("@id_campanha", Campanha.id_campanha);

            using NpgsqlDataReader ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                historia = ndp.GetValue(0).ToString();
                anotacoes = ndp.GetValue(1).ToString();
            }
        }

        public static void Select_Regras(ref string regras, ref string sanidades)
        {

            using NpgsqlConnection conn = new NpgsqlConnection(Caminho_DB());
            conn.Open();
            using NpgsqlCommand comt = new NpgsqlCommand();
            comt.Connection = conn;
            comt.CommandType = CommandType.Text;
            comt.CommandText = "select regras_gerais, sanidades from \"Dark_Age_Connection\".\"Regras\"";

            using NpgsqlDataReader ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                regras = ndp.GetValue(0).ToString();
                sanidades = ndp.GetValue(1).ToString();
            }
        }

        public static DataTable select_enums()
        {
            try
            {
                using NpgsqlDataAdapter dt_adapter_difi = new NpgsqlDataAdapter($@"SELECT enumlabel AS nome_enum_difi
                                                                                  , enumsortorder   AS ordem
                                                                               from pg_type t 
                                                                               JOIN pg_enum e ON t.oid = e.enumtypid 
                                                                              WHERE typname = 'enum_dificuldade'
                                                                              order by ordem;", Conexao_BD.Caminho_DB());

                DataTable dt_table_retorno_difi = new DataTable();

                dt_adapter_difi.Fill(dt_table_retorno_difi);

                return dt_table_retorno_difi;
            } catch (NpgsqlException a)
            {
                MessageBox.Show("ERRO nos enums dificuldade" + a);
                return null;
            }           
        } 

        public static DataTable select_tipo_itens()
        {
            try
            {
                using NpgsqlDataAdapter dt_adapter_tipo = new NpgsqlDataAdapter($@"select id_tipo_itens 
                                                                                   , nome_tipo_itens 
                                                                                from ""Dark_Age_Connection"".""Tipo_itens""
                                                                               order by id_tipo_itens ;", Conexao_BD.Caminho_DB());

                DataTable dt_table_retorno_tipo = new DataTable();

                dt_adapter_tipo.Fill(dt_table_retorno_tipo);

                return dt_table_retorno_tipo;

            } catch (NpgsqlException a)
            {
                MessageBox.Show("ERRO no tipo de itens: " + a);
                return null;
            }
        }

        public static DataTable select_profissao()
        {
            try
            {
                using NpgsqlDataAdapter dt_adapter_profissao = new NpgsqlDataAdapter($@"select id_profissao
                                                                                       , nome_profissao
                                                                                    from ""Dark_Age_Connection"".""Profissao""
                                                                                   order by id_profissao ;", Conexao_BD.Caminho_DB());

                DataTable dt_table_retorno_profissao = new DataTable();

                dt_adapter_profissao.Fill(dt_table_retorno_profissao);

                return dt_table_retorno_profissao;

            } catch (NpgsqlException a)
            {
                MessageBox.Show("ERRO nas profissoes: " + a);
                return null;
            }
        }
        public static DataTable select_data_gridlist()
        {
            try
            {
                using NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter($@"select id_itens 
                                                                             , nome_itens 
                                                                             , dificuldade 
                                                                             , nome_tipo_itens
                                                                             , nome_profissao
                                                                             , descricao
                                                                             , material
                                                                             , dano
                                                                          from ""Dark_Age_Connection"".""Itens""
                                                                          join ""Dark_Age_Connection"".""Profissao"" on id_profissao = fk_id_profissao 
                                                                          join ""Dark_Age_Connection"".""Tipo_itens"" on id_tipo_itens = fk_id_tipo_itens ;", Conexao_BD.Caminho_DB());
                using NpgsqlCommandBuilder cBuilder = new NpgsqlCommandBuilder(dt_adapter);
                DataTable dt_table = new DataTable();

                dt_adapter.Fill(dt_table);
                return dt_table;
            } catch (Exception e)
            {
                MessageBox.Show("ERRO nas select personagem: " + e);
                return null;
            }
        }

        public static DataTable filtro_data_gridlist(string nome)
        {

            using NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter($@"select id_itens 
                                                             , nome_itens 
                                                             , dificuldade 
                                                             , nome_tipo_itens
                                                             , nome_profissao
                                                             , descricao
                                                             , material
                                                             , dano
                                                          from ""Dark_Age_Connection"".""Itens""
                                                          join ""Dark_Age_Connection"".""Profissao"" on id_profissao = fk_id_profissao 
                                                          join ""Dark_Age_Connection"".""Tipo_itens"" on id_tipo_itens = fk_id_tipo_itens 
                                                          where nome_itens ILIKE '%" + nome + "%' or " +
                                                      "nome_tipo_itens ILIKE '%" + nome + "%' " +
                                                      "or nome_profissao ILIKE '%" + nome + "%';", Conexao_BD.Caminho_DB());
            using NpgsqlCommandBuilder cBuilder = new NpgsqlCommandBuilder(dt_adapter);
            DataTable dt_table = new DataTable();

            dt_adapter.Fill(dt_table);
            return dt_table;
        }

        public static DataTable select_campanha()
        {
            try
            {
                using NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter($@"select id_campanha 
	                                                                         , nome_campanha
                                                                             , fk_id_jogador_mestre       
                                                                          from ""Dark_Age_Connection"".""Campanha"";", Conexao_BD.Caminho_DB());
                using NpgsqlCommandBuilder cBuilder = new NpgsqlCommandBuilder(dt_adapter);
                DataTable dt_table = new DataTable();

                dt_adapter.Fill(dt_table);
                return dt_table;
            } catch (Exception e)
            {
                MessageBox.Show("ERRO nas select personagem: " + e);
                return null;
            }
        }
        public static DataTable select_personagem_campanha(int id_jogador, int id_campanha)
        {
            try
            {                
                using NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter($@"select id_personagem 
	                                                                             , nome_personagem	
   	                                                                             , nome_classe 
   	                                                                             , nivel
	                                                                             , fk_id_classe
                                                                                 , id_entidade
                                                                                 , imagem
                                                                                 , nome_jogador           
                                                                              from ""Dark_Age_Connection"".""Inter_status_pers"" isp 
                                                                              join ""Dark_Age_Connection"".""Jogadores"" j on id_jogador = fk_id_jogador
                                                                              join ""Dark_Age_Connection"".""Personagens"" p on id_personagem = fk_id_personagem
                                                                              join ""Dark_Age_Connection"".""Classes"" c on c.id_classe = p.fk_id_classe
                                                                             where tipo_personagem = 1
                                                                               and((isp.fk_id_jogador = " + id_jogador + ") or(" + id_jogador +" = 0))" + 
                                                                              "and isp.fk_id_campanha = " + id_campanha + ";", Conexao_BD.Caminho_DB());
                
                using NpgsqlCommandBuilder cBuilder = new NpgsqlCommandBuilder(dt_adapter);
                DataTable dt_table = new DataTable();

                dt_adapter.Fill(dt_table);
                return dt_table;
            } catch(Exception e)
            {
                MessageBox.Show("ERRO nas select personagem: " + e);
                return null;
            }
        }
        

        public static void deletar_personagem(int id_personagem, int id_campanha)
        {
            using NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            using NpgsqlCommand como = new NpgsqlCommand();
            como.Connection = conn;
            como.CommandType = CommandType.Text;
            como.CommandText = $@"call ""Dark_Age_Connection"".sp_deletar_personagem(@id_personagem, @id_campanha);";
            como.Parameters.AddWithValue("@id_personagem", id_personagem);
            como.Parameters.AddWithValue("@id_campanha", id_campanha);
            como.ExecuteNonQuery();
        }

        public static void criar_nova_campanha(string nome_campanha, int id_jogador)
        {
            using NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            using NpgsqlCommand como = new NpgsqlCommand();
            como.Connection = conn;
            como.CommandType = CommandType.Text;
            como.CommandText = $@"INSERT INTO ""Dark_Age_Connection"".""Campanha"" (nome_campanha, fk_id_jogador_mestre )
                                       VALUES (@nome_campanha, @fk_id_jogador_mestre )
                                       returning id_campanha;";
            como.Parameters.AddWithValue("@nome_campanha", nome_campanha);
            como.Parameters.AddWithValue("@fk_id_jogador_mestre", id_jogador);
            object id_camp =  como.ExecuteScalar();

            Campanha.id_campanha = Convert.ToInt32(id_camp);
        }

        public static void deletar_campanha(int id_campanha, int id_jogador)
        {
            using NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            using NpgsqlCommand como = new NpgsqlCommand();
            como.Connection = conn;
            como.CommandType = CommandType.Text;
            como.CommandText = $@"DELETE FROM ""Dark_Age_Connection"".""Campanha""
                                        WHERE id_campanha = @id_campanha;
                                          and fk_id_jogador_mestre = @id_jogador";
            como.Parameters.AddWithValue("@id_campanha", id_campanha);
            como.Parameters.AddWithValue("@id_jogador", id_jogador);
            como.ExecuteNonQuery();
        }

        public static void insert_inter_camp_pers(int id_pers, int id_camp, int id_jog)
        {            
            using NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            using NpgsqlCommand cone = new NpgsqlCommand();
            cone.Connection = conn;

            cone.CommandText = $@"INSERT INTO ""Dark_Age_Connection"".""Inter_camp_pers""
                                                (fk_id_campanha, fk_id_jogador, fk_id_personagem)
                                                VALUES(@id_campanha, @id_jogador, @id_personagem);";
            cone.Parameters.AddWithValue("@id_campanha", id_camp);
            cone.Parameters.AddWithValue("@id_jogador", id_jog);
            cone.Parameters.AddWithValue("@id_personagem", id_pers);            
            cone.ExecuteNonQuery();
        }

        public static void insert_item_inventario(int id_item ,int qtd)
        {
            using NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            using NpgsqlCommand cone = new NpgsqlCommand();
            cone.Connection = conn;
            cone.CommandText = $@"INSERT INTO ""Dark_Age_Connection"".""Inventario""
                                    (fk_id_item, fk_id_personagem, quantidade)
                                    VALUES(@id_item, @id_personagem, @qtd);";
            cone.Parameters.AddWithValue("@id_item", id_item);
            cone.Parameters.AddWithValue("@id_personagem", Campanha.id_personagem);
            cone.Parameters.AddWithValue("@qtd", qtd);
            cone.ExecuteNonQuery();
        }
        public static DataTable select_pet_jogador(int id_jogador, int id_campanha, int pessoal)
        {
            try
            {
                using NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter($@"select fk_id_jogador
                                                                                 , id_personagem
	                                                                             , nome_personagem
                                                                                 , vida_max1
                                                                                 , vida_atual1
                                                                                 , mana_atual1
                                                                                 , escudo1
                                                                                 , tipo_personagem
                                                                                 , tamanho
                                                                             from ""Dark_Age_Connection"".""Inter_status_pers"" 
                                                                             join ""Dark_Age_Connection"".""Personagens"" on id_personagem = fk_id_personagem
                                                                            where tipo_personagem = 'Pet' 
                                                                            and fk_id_jogador = " +id_jogador+" or "+ pessoal+ " = 0" +
                                                                            "and fk_id_campanha = " +id_campanha +" or "+ pessoal+ " = 0 " +
                                                                            " group by 1,2,3,4,5,6,7,8,9 " +
                                                                            " order by 2; ", Conexao_BD.Caminho_DB());

                using NpgsqlCommandBuilder cBuilder = new NpgsqlCommandBuilder(dt_adapter);
                DataTable dt_table = new DataTable();

                dt_adapter.Fill(dt_table);
                return dt_table;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERRO nas select personagem: " + e);
                return null;
            }
        }
        public static void adotar_novo_pet(int id_campanha, int id_jogador, int id_personagem, int vida, int vida_max, int mana_atual, string tamanho)
        {
            using NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            using NpgsqlCommand como = new NpgsqlCommand();
            como.Connection = conn;
            como.CommandType = CommandType.Text;
            como.CommandText = $@"INSERT INTO ""Dark_Age_Connection"".""Inter_status_pers"" (fk_id_personagem, fk_id_jogador, fk_id_campanha, vida_atual1, vida_max1, mana_atual1, tamanho)
                                       VALUES (@fk_id_personagem, @fk_id_jogador, @fk_id_campanha, @vida_atual1, @vida_max1, @mana_atual1, @tamanho)
                                       returning id_campanha;";
            como.Parameters.AddWithValue("@fk_id_personagem", id_personagem);
            como.Parameters.AddWithValue("@fk_id_jogador", id_jogador);
            como.Parameters.AddWithValue("@fk_id_campanha", id_campanha);
            como.Parameters.AddWithValue("@vida_atual1", vida);
            como.Parameters.AddWithValue("@vida_max1", vida_max);
            como.Parameters.AddWithValue("@mana_atual1", mana_atual);
            como.Parameters.AddWithValue("@tamanho", tamanho);
            como.ExecuteScalar();
        }

        public static DataTable select_nivel(int nivel)
        {
            try
            {
                using NpgsqlDataAdapter dt_adapter_nivel = new NpgsqlDataAdapter($@"select nivel 
                                                                                   , pontos_atributos 
                                                                                   , pontos_talentos 
                                                                                from ""Dark_Age_Connection"".nivel
                                                                               where ((nivel = "+ nivel +") or ("+ nivel +" = 0));", Conexao_BD.Caminho_DB());

                DataTable dt_table_retorno_nivel = new DataTable();

                dt_adapter_nivel.Fill(dt_table_retorno_nivel);

                return dt_table_retorno_nivel;

            } catch (NpgsqlException a)
            {
                MessageBox.Show("ERRO na seleção do nivel: " + a);
                return null;
            }

        }
    }
}
