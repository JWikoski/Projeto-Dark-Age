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

        public static void mudar_moedas(int ouro, int prata, int id_personagem)
        {

            using NpgsqlConnection conn = new NpgsqlConnection(Caminho_DB());
            conn.Open();
            using NpgsqlCommand comt = new NpgsqlCommand();
            comt.Connection = conn;
            comt.CommandType = CommandType.Text;
            comt.CommandText = "update \"Dark_Age_Connection\".\"Personagens\" set gold = "+ouro+ ", silver = " + prata+
                " where id_personagem = "+id_personagem+" ";

            comt.ExecuteNonQuery();
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
                                                                               order by nome_tipo_itens ;", Conexao_BD.Caminho_DB());

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
                                                                                       , descricao_profissao
                                                                                    from ""Dark_Age_Connection"".""Profissao""
                                                                                   order by nome_profissao ;", Conexao_BD.Caminho_DB());

                DataTable dt_table_retorno_profissao = new DataTable();

                dt_adapter_profissao.Fill(dt_table_retorno_profissao);

                return dt_table_retorno_profissao;

            } catch (NpgsqlException a)
            {
                MessageBox.Show("ERRO nas profissoes: " + a);
                return null;
            }
        }
        public static DataTable select_maestria()
        {
            try
            {
                using NpgsqlDataAdapter dt_adapter_maestria = new NpgsqlDataAdapter($@"select id_maestria
                                                                                       , nome
                                                                                       , descricao
                                                                                       , bp
                                                                                    from ""Dark_Age_Connection"".""maestria""
                                                                                   order by nome ;", Conexao_BD.Caminho_DB());

                DataTable dt_table_retorno_maestria = new DataTable();

                dt_adapter_maestria.Fill(dt_table_retorno_maestria);

                return dt_table_retorno_maestria;

            }
            catch (NpgsqlException a)
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
                                                                             , quantidade
                                                                          from ""Dark_Age_Connection"".""Itens""
                                                                          join ""Dark_Age_Connection"".""Profissao"" on id_profissao = fk_id_profissao 
                                                                          join ""Dark_Age_Connection"".""Tipo_itens"" on id_tipo_itens = fk_id_tipo_itens 
                                                                          left join ""Dark_Age_Connection"".""Inventario"" on fk_id_itens = id_itens
                                                                          and fk_id_personagem = "+Campanha.id_personagem+"" +
                                                                          " order by nome_itens;", Conexao_BD.Caminho_DB());
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
        public static DataTable select_inventário(int item, int id_personagem)
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
                                                                             , quantidade
                                                                             , equipado
                                                                          from ""Dark_Age_Connection"".""Itens""
                                                                          join ""Dark_Age_Connection"".""Profissao"" on id_profissao = fk_id_profissao 
                                                                          join ""Dark_Age_Connection"".""Inventario"" on fk_id_itens = id_itens 
                                                                          join ""Dark_Age_Connection"".""Tipo_itens"" on id_tipo_itens = fk_id_tipo_itens
                                                                          where fk_id_personagem = " + id_personagem + " " +
                                                                          "and equipado = 'false' " +
                                                                          "and ((id_itens = "+item+ ") or (" + item +" = 0)) " +
                                                                          " order by nome_itens;", Conexao_BD.Caminho_DB());
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
        public static DataTable select_itens_equipados()
        {
            try
            {
                using NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter($@"select id_itens 
                                                                             , nome_itens
                                                                             , dano
                                                                             , equipado
                                                                          from ""Dark_Age_Connection"".""Itens""
                                                                          join ""Dark_Age_Connection"".""Inventario"" on fk_id_itens = id_itens 
                                                                          where fk_id_personagem = " + Campanha.id_personagem+
                                                                          "and equipado = true ;", Conexao_BD.Caminho_DB());
                using NpgsqlCommandBuilder cBuilder = new NpgsqlCommandBuilder(dt_adapter);
                DataTable dt_table = new DataTable();

                dt_adapter.Fill(dt_table);
                return dt_table;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERRO ao equipar item: " + e);
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
                                                             , quantidade
                                                          from ""Dark_Age_Connection"".""Itens""
                                                          join ""Dark_Age_Connection"".""Profissao"" on id_profissao = fk_id_profissao 
                                                          join ""Dark_Age_Connection"".""Tipo_itens"" on id_tipo_itens = fk_id_tipo_itens 
                                                          left join ""Dark_Age_Connection"".""Inventario"" on fk_id_itens = id_itens
                                                                          and fk_id_personagem = " + Campanha.id_personagem + 
                                                          " where nome_itens ILIKE '%" + nome + "%' or " +
                                                      "nome_tipo_itens ILIKE '%" + nome + "%' " +
                                                      "or nome_profissao ILIKE '%" + nome + "%'" +
                                                      " order by nome_itens;", Conexao_BD.Caminho_DB());
            using NpgsqlCommandBuilder cBuilder = new NpgsqlCommandBuilder(dt_adapter);
            DataTable dt_table = new DataTable();

            dt_adapter.Fill(dt_table);
            return dt_table;
        }
        
        public static DataTable select_materiais_criacao(int id_item)
        {

            using NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter($@"select id_itens
                                                             , ingrediente 
                                                             , nome_itens 
                                                             , quantidade
                                                             , qnt_material 
                                                             , qnt_criacao
                                                          from ""Dark_Age_Connection"".""criacao"" cri
                                                           join ""Dark_Age_Connection"".""Itens"" on id_itens = ingrediente 
                                                           left join ""Dark_Age_Connection"".""Inventario"" inv on inv.fk_id_itens = ingrediente 
	                                                      and inv.fk_id_personagem = "+Campanha.id_personagem +
                                                          " where cri.fk_id_itens = " + id_item +"" +
                                                          " order by nome_itens;", Conexao_BD.Caminho_DB());

            using NpgsqlCommandBuilder cBuilder = new NpgsqlCommandBuilder(dt_adapter);
            DataTable dt_table = new DataTable();

            dt_adapter.Fill(dt_table);
            return dt_table;
        }
        
        public static DataTable select_itens_criacao(int id_item)
        {
            using NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter($@"select nome_itens 
                                                             , quantidade
                                                             , qnt_material 
                                                          from ""Dark_Age_Connection"".""criacao"" cri
                                                           join ""Dark_Age_Connection"".""Itens"" on id_itens = cri.fk_id_itens 
                                                           left join ""Dark_Age_Connection"".""Inventario"" inv on inv.fk_id_itens = cri.ingrediente 
	                                                      and inv.fk_id_personagem = " +Campanha.id_personagem +
                                                          " where cri.ingrediente = " + id_item +";", Conexao_BD.Caminho_DB());

            using NpgsqlCommandBuilder cBuilder = new NpgsqlCommandBuilder(dt_adapter);
            DataTable dt_table = new DataTable();

            dt_adapter.Fill(dt_table);
            return dt_table;
        }
        
        public static DataTable select_itens_produziveis(int id_personagem)
        {
            using NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter($@"SELECT i.id_itens, i.nome_itens, i.dificuldade , t.nome_tipo_itens
	                                                                                 , p.nome_profissao , i.descricao, i.material, i.dano
	                                                                                 , COALESCE(MIN(inv.quantidade/c.qnt_material), 0) AS quantidade

                                                                        FROM ""Dark_Age_Connection"".""Itens"" i
                                                                        JOIN ""Dark_Age_Connection"".""criacao"" c ON c.fk_id_itens = i.id_itens
                                                                        JOIN(
                                                                            SELECT fk_id_itens, quantidade
                                                                            FROM ""Dark_Age_Connection"".""Inventario""
                                                                            WHERE fk_id_personagem = " + Campanha.id_personagem+
                                                                            " GROUP BY fk_id_itens, quantidade" +
                                                                     " ) inv ON c.Ingrediente = inv.fk_id_itens AND c.qnt_material <= inv.quantidade " +
                                                                       " join \"Dark_Age_Connection\".\"Profissao\" p on p.id_profissao = I.fk_id_profissao "+
                                                                        " join \"Dark_Age_Connection\".\"Tipo_itens\" t on t.id_tipo_itens = I.fk_id_tipo_itens "+
                                                                        " GROUP BY i.id_itens, i.nome_itens, i.dificuldade, t.nome_tipo_itens "+
                                                                            " , p.nome_profissao, i.descricao, i.material, i.dano" +
                                                                         " HAVING COUNT(*) = (" +
                                                                           " SELECT COUNT(*)" +
                                                                           " FROM \"Dark_Age_Connection\".\"criacao\" " +
                                                                            " WHERE fk_id_itens = i.id_itens);", Conexao_BD.Caminho_DB());


            using NpgsqlCommandBuilder cBuilder = new NpgsqlCommandBuilder(dt_adapter);
            DataTable dt_table = new DataTable();

            dt_adapter.Fill(dt_table);
            return dt_table;
        }

        public static DataTable filtro_inventario(string nome)
        {

            using NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter($@"select id_itens 
                                                                             , nome_itens 
                                                                             , dificuldade 
                                                                             , nome_tipo_itens
                                                                             , nome_profissao
                                                                             , descricao
                                                                             , material
                                                                             , dano
                                                                             , quantidade
                                                                             , equipado
                                                                          from ""Dark_Age_Connection"".""Itens""
                                                                          join ""Dark_Age_Connection"".""Profissao"" on id_profissao = fk_id_profissao 
                                                                           join ""Dark_Age_Connection"".""Inventario"" on fk_id_itens = id_itens  
                                                                            join ""Dark_Age_Connection"".""Tipo_itens"" on id_tipo_itens = fk_id_tipo_itens 
                                                                            where fk_id_personagem = " + Campanha.id_personagem + 
                                                                            "and ((nome_itens ILIKE '%" + nome + "%') or (" +
                                                                            "nome_tipo_itens ILIKE '%" + nome + "%') " +
                                                                            "or (nome_profissao ILIKE '%" + nome + "%'));", Conexao_BD.Caminho_DB());
            using NpgsqlCommandBuilder cBuilder = new NpgsqlCommandBuilder(dt_adapter);
            DataTable dt_table = new DataTable();

            dt_adapter.Fill(dt_table);
            return dt_table;
        }

        public static DataTable select_campanha(Boolean ativa)
        {
            try
            {
                using NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter($@"select id_campanha 
	                                                                         , nome_campanha
                                                                             , fk_id_jogador_mestre    
                                                                             , imagem_campanha
                                                                          from ""Dark_Age_Connection"".""Campanha""
                                                                          where (ativa = True and "+ativa+" = true)" +
                                                                          "or ("+ativa+" = false) ;", Conexao_BD.Caminho_DB());
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
        public static DataTable select_personagem_campanha(int id_jogador, int id_campanha, int tipo)
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
                                                                             where tipo_personagem = "+tipo+
                                                                               " and((isp.fk_id_jogador = " + id_jogador + ") or(" + id_jogador +" = 0))" + 
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
        public static DataTable select_tokens(int id_campanha)
        {
            try
            {                
                using NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter($@"select imagem
                                                                                 , isp.fk_id_campanha   
                                                                                 , iniciativa
                                                                                 , id_personagem
                                                                                 , isp.local_token
                                                                                 , isp.tamanho_token
                                                                                 , isp.id_entidade
                                                                              from ""Dark_Age_Connection"".""Inter_status_pers"" isp 
                                                                              join ""Dark_Age_Connection"".""Personagens"" p on id_personagem = fk_id_personagem
                                                                             where isp.fk_id_campanha = " + id_campanha + "" +
                                                                             " and iniciativa > 0" +
                                                                             " and id_personagem > 0" +
                                                                             " order by id_personagem;", Conexao_BD.Caminho_DB());
                
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
        public static DataTable atualizar_localizacao_tokens(int id_campanha)
        {
            try
            {
                using NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter($@"select isp.local_token
                                                                                 , isp.id_entidade
                                                                                 , isp.tamanho_token
                                                                              from ""Dark_Age_Connection"".""Inter_status_pers"" isp 
                                                                              join ""Dark_Age_Connection"".""Personagens"" p on id_personagem = fk_id_personagem
                                                                             where isp.fk_id_campanha = " + id_campanha + "" +
                                                                             " and iniciativa > 0" +
                                                                             " and id_personagem > 0;", Conexao_BD.Caminho_DB());

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

        public static void criar_nova_campanha(string nome_campanha, int id_jogador, byte[] imagem)
        {
            using NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            using NpgsqlCommand como = new NpgsqlCommand();
            como.Connection = conn;
            como.CommandType = CommandType.Text;
            como.CommandText = $@"INSERT INTO ""Dark_Age_Connection"".""Campanha"" (nome_campanha, fk_id_jogador_mestre, ativa, imagem_campanha)
                                       VALUES (@nome_campanha, @fk_id_jogador_mestre, true, @imagem)
                                       returning id_campanha;";
            como.Parameters.AddWithValue("@nome_campanha", nome_campanha);
            como.Parameters.AddWithValue("@fk_id_jogador_mestre", id_jogador);
            como.Parameters.AddWithValue("@imagem", imagem);
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
            como.CommandText = $@"update ""Dark_Age_Connection"".""Campanha""
                                        set ativa = false
                                        WHERE id_campanha = @id_campanha
                                          and fk_id_jogador_mestre = @id_jogador;";
            como.Parameters.AddWithValue("@id_campanha", id_campanha);
            como.Parameters.AddWithValue("@id_jogador", id_jogador);
            como.ExecuteNonQuery();
        } 
        public static void update_tamanho_token(int id_campanha, int id_entidade, int tamanho)
        {
            using NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            using NpgsqlCommand como = new NpgsqlCommand();
            como.Connection = conn;
            como.CommandType = CommandType.Text;
            como.CommandText = $@"update ""Dark_Age_Connection"".""Inter_status_pers""
                                        set tamanho_token = @tamanho
                                        WHERE fk_id_campanha = @id_campanha
                                          and (id_entidade = @id_entidade
                                          or @id_entidade = 0);";
            como.Parameters.AddWithValue("@tamanho", tamanho);
            como.Parameters.AddWithValue("@id_campanha", id_campanha);
            como.Parameters.AddWithValue("@id_entidade", id_entidade);
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
        public static void insert_imagem_campanha(int id_campanha, byte[] imagem)
        {            
            using NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            using NpgsqlCommand cone = new NpgsqlCommand();
            cone.Connection = conn;

            cone.CommandText = $@"update ""Dark_Age_Connection"".""Campanha""
                                               set imagem_campanha = @imagem
                                                where id_campanha = @id_camp;";
            cone.Parameters.AddWithValue("@id_camp", id_campanha);      
            cone.Parameters.AddWithValue("@imagem", imagem);      
            cone.ExecuteNonQuery();
        }

        public static void insert_item_inventario(int id_item ,int qtd, int id_personagem)
        {
            using NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            using NpgsqlCommand cone = new NpgsqlCommand();
            cone.Connection = conn;
            cone.CommandText = $@"call ""Dark_Age_Connection"".sp_insere_item(@id_personagem, @id_item, @qtd); ";
            cone.Parameters.AddWithValue("@id_item", id_item);
            cone.Parameters.AddWithValue("@id_personagem", id_personagem);
            cone.Parameters.AddWithValue("@qtd", qtd);
            cone.ExecuteNonQuery();
        }
        public static void delete_item_inventario(int id_item, int id_personagem)
        {
            using NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            using NpgsqlCommand cone = new NpgsqlCommand();
            cone.Connection = conn;
            cone.CommandText = $@"delete from ""Dark_Age_Connection"".""Inventario""
                                    where fk_id_itens = @id_item
                                    and fk_id_personagem = @id_personagem;";
            cone.Parameters.AddWithValue("@id_item", id_item);
            cone.Parameters.AddWithValue("@id_personagem", id_personagem);
            cone.ExecuteNonQuery();
        }

        public static void update_qtd_inventario(int id_item, int qtd, int id_personagem)
        {
            using NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            using NpgsqlCommand cone = new NpgsqlCommand();
            cone.Connection = conn;
            cone.CommandText = $@"update ""Dark_Age_Connection"".""Inventario""
                                    set quantidade = @qtd
                                    where fk_id_itens = @id_item
                                    and fk_id_personagem = @id_personagem;";
            cone.Parameters.AddWithValue("@id_item", id_item);
            cone.Parameters.AddWithValue("@qtd", qtd);
            cone.Parameters.AddWithValue("@id_personagem", id_personagem);
            cone.ExecuteNonQuery();
        }
        public static void equipar_item(int id_item, Boolean status)
        {
            using NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            using NpgsqlCommand cone = new NpgsqlCommand();
            cone.Connection = conn;
            cone.CommandText = $@"update ""Dark_Age_Connection"".""Inventario""
                                    set equipado = @status "+
                                    "where fk_id_itens = @id_item" +
                                    " and fk_id_personagem = @id_personagem ;";
            cone.Parameters.AddWithValue("@id_item", id_item);
            cone.Parameters.AddWithValue("@status", status);
            cone.Parameters.AddWithValue("@id_personagem", Campanha.id_personagem);
            cone.ExecuteNonQuery();
        }

        public static DataTable select_pet_jogador(int id_jogador, int id_campanha, int pessoal, int tipo)
        {
            try
            {
                using NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter($@"select fk_id_jogador
                                                                                 , id_personagem
	                                                                             , nome_personagem
                                                                                 , i.vida_max
                                                                                 , i.vida_atual
                                                                                 , i.mana_atual
                                                                                 , i.escudo
                                                                                 , tipo_personagem
                                                                                 , tamanho
                                                                                 , i.id_entidade
                                                                             from ""Dark_Age_Connection"".""Inter_status_pers"" i
                                                                             join ""Dark_Age_Connection"".""Personagens"" on id_personagem = fk_id_personagem
                                                                            where tipo_personagem = "+tipo+
                                                                            " and ((fk_id_campanha = " +id_campanha +") or ("+ pessoal+ " = 0)) " +
                                                                            " group by 1,2,3,4,5,6,7,8,9, 10" +
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

        public static void adicionar_profissao(int id_personagem, int id_profissao, int id_maestria)
        {
            using NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            using NpgsqlCommand comm = new NpgsqlCommand();

            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = $@"INSERT INTO ""Dark_Age_Connection"".""inter_profissao_pers"" (fk_id_personagem, fk_id_profissao, fk_id_maestria, xp_profissao) 
                                       VALUES (@id_personagem, @id_profissao, @id_maestria, 0)";
            comm.Parameters.AddWithValue("@id_personagem", id_personagem);
            comm.Parameters.AddWithValue("@id_profissao", id_profissao);
            comm.Parameters.AddWithValue("@id_maestria", id_maestria);
            comm.ExecuteNonQuery();
        }

        public static void remover_profissao(int id_personagem, int id_profissao)
        {
            using NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            using NpgsqlCommand comm = new NpgsqlCommand();

            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = $@"DELETE FROM ""Dark_Age_Connection"".""inter_profissao_pers"" 
                                         WHERE fk_id_personagem = @id_personagem
                                         AND fk_id_profissao = @id_profissao";
            comm.Parameters.AddWithValue("@id_personagem", id_personagem);
            comm.Parameters.AddWithValue("@id_profissao", id_profissao);
            comm.ExecuteNonQuery();
        }

        public static void update_maestria(int id_personagem, int id_profissao, int id_maestria)
        {
            using NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            using NpgsqlCommand comm = new NpgsqlCommand();

            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = $@"UPDATE ""Dark_Age_Connection"".""inter_profissao_pers""
                                  SET fk_id_maestria = @id_maestria
                                  WHERE fk_id_profissao = @id_profissao
                                  AND fk_id_personagem = @id_personagem";
            comm.Parameters.AddWithValue("@id_personagem", id_personagem);
            comm.Parameters.AddWithValue("@id_profissao", id_profissao);
            comm.Parameters.AddWithValue("@id_maestria", id_maestria);
            comm.ExecuteNonQuery();
        }

        public static Boolean checar_profissao(int id_personagem, int id_profissao)
        {
            using NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            using NpgsqlCommand comm = new NpgsqlCommand();

            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = $@"SELECT * FROM ""Dark_Age_Connection"".""inter_profissao_pers"" 
                                  WHERE fk_id_personagem = @id_personagem 
                                  AND fk_id_profissao = @id_profissao";
            comm.Parameters.AddWithValue("@id_personagem", id_personagem);
            comm.Parameters.AddWithValue("@id_profissao", id_profissao);

            using NpgsqlDataReader chk = comm.ExecuteReader();
            if (chk.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable select_profissoes_escolhidas()
        {
            try
            {
                using NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter($@"select ipp.id_pp as id_inter_profissao
                                                                                 , p.nome_profissao
                                                                                 , p.descricao_profissao 
                                                                                 , m.nome 
                                                                                 , m.descricao 
                                                                                 , ipp.fk_id_maestria
                                                                                 , ipp.fk_id_profissao
                                                                                 , ipp.xp_profissao
                                                                              from ""Dark_Age_Connection"".inter_profissao_pers ipp 
                                                                              join ""Dark_Age_Connection"".""Profissao"" p on p.id_profissao = ipp.fk_id_profissao
                                                                              join ""Dark_Age_Connection"".maestria m on m.id_maestria = ipp.fk_id_maestria
                                                                              where ipp.fk_id_personagem = " + Campanha.id_personagem + " ORDER BY ipp.id_pp", Conexao_BD.Caminho_DB());
                using NpgsqlCommandBuilder cBuilder = new NpgsqlCommandBuilder(dt_adapter);
                DataTable dt_table = new DataTable();

                dt_adapter.Fill(dt_table);
                return dt_table;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERRO ao nas profissões escolhidas: " + e);
                return null;
            }
        }
        
        public static DataTable select_iniciativa(int id_campanha)
        {
            try
            {
                using NpgsqlDataAdapter dt_adapter_iniciativas = new NpgsqlDataAdapter($@"select id_personagem
                                                                                   , nome_personagem
                                                                                   , iniciativa 
                                                                                from ""Dark_Age_Connection"".""Personagens""
                                                                                join ""Dark_Age_Connection"".""Inter_status_pers"" on fk_id_personagem = id_personagem
                                                                                and fk_id_campanha = " + id_campanha + ""+
                                                                                "WHERE fk_id_campanha = " + id_campanha + "" +
                                                                                " and iniciativa > -5" +
                                                                                " order by iniciativa desc;", Conexao_BD.Caminho_DB());

                DataTable dt_retorno_iniciativas = new DataTable();

                dt_adapter_iniciativas.Fill(dt_retorno_iniciativas);

                return dt_retorno_iniciativas;

            } catch (NpgsqlException a)
            {
                MessageBox.Show("ERRO na seleção do nivel: " + a);
                return null;
            }

        }public static void update_iniciativa(int id_personagem, int iniciativa)
        {
                using NpgsqlConnection conn = new NpgsqlConnection(Caminho_DB());
                conn.Open();
                using NpgsqlCommand comn = new NpgsqlCommand();
                comn.Connection = conn;
                comn.CommandType = CommandType.Text;
                comn.CommandText = "update \"Dark_Age_Connection\".\"Personagens\" set iniciativa = " + iniciativa + "" +
                                                                                "WHERE id_personagem = " + id_personagem + "";

                comn.ExecuteNonQuery();
        }

        public static void update_xp_profissao(int xp_profissao, int id_personagem, int id_profissao)
        {
            using NpgsqlConnection conn = new NpgsqlConnection(Caminho_DB());
            conn.Open();
            using NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = $@"UPDATE ""Dark_Age_Connection"".""inter_profissao_pers""
                                  SET xp_profissao = @xp_profissao
                                  WHERE fk_id_profissao = @id_profissao
                                  AND fk_id_personagem = @id_personagem";
            comm.Parameters.AddWithValue("@id_personagem", id_personagem);
            comm.Parameters.AddWithValue("@id_profissao", id_profissao);
            comm.Parameters.AddWithValue("@xp_profissao", xp_profissao);
            comm.ExecuteNonQuery();
        }
        public static void excluir_entidade(int id_entidade)
        {
            using NpgsqlConnection conn = new NpgsqlConnection(Caminho_DB());
            conn.Open();
            using NpgsqlCommand comt = new NpgsqlCommand();
            comt.Connection = conn;
            comt.CommandType = CommandType.Text;
            comt.CommandText = $@"delete from ""Dark_Age_Connection"".""Inter_status_pers"" " +
                " where id_entidade = " + id_entidade + " ";

            comt.ExecuteNonQuery();
        }
        public static void duplicar_entidade(int id_entidade)
        {
            using NpgsqlConnection conn = new NpgsqlConnection(Caminho_DB());
            conn.Open();
            using NpgsqlCommand comt = new NpgsqlCommand();
            comt.Connection = conn;
            comt.CommandType = CommandType.Text;
            comt.CommandText = $@"call ""Dark_Age_Connection"".""duplicar_entidade"" (" + id_entidade + ") ";

            comt.ExecuteNonQuery();
        }
		public static DataTable select_mensagens_chat(int id_entidade, int id_campanha, int id_entidade_privada)
		{
			try
			{
				using NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter($@"select * from ""Dark_Age_Connection"".sp_mensagem_chat(" + id_entidade + "," + id_campanha + "," + id_entidade_privada + ")", Conexao_BD.Caminho_DB());

				DataTable dt_table = new DataTable();

				dt_adapter.Fill(dt_table);

				return dt_table;

			} catch (NpgsqlException a)
			{
				MessageBox.Show("Erro ao carregar as informações do Chat: " + a);
				return null;
			}
		}

		public static void envia_mensagem_chat(DateTime data_atual, string mensagem, int id_entidade_envio, string? tipo_dado)
		{
			using NpgsqlConnection conn = new NpgsqlConnection(Caminho_DB());
			conn.Open();
			using NpgsqlCommand comn = new NpgsqlCommand();
			comn.Connection = conn;
			comn.CommandType = CommandType.Text;
			comn.CommandText = $@" INSERT INTO ""Dark_Age_Connection"".chat
                                    (data_hora, mensagem, fk_id_entidade, tipo_dado)
                                    VALUES(current_timestamp - INTERVAL '3 hours', @mensagem, @id_entidade, @tipo_dado);";
			comn.Parameters.AddWithValue("@data_atual", data_atual);
			comn.Parameters.AddWithValue("@mensagem", mensagem);
			comn.Parameters.AddWithValue("@id_entidade", id_entidade_envio);
			comn.Parameters.AddWithValue("@tipo_dado", tipo_dado);
			comn.ExecuteNonQuery();
		}
        public static void update_tema(Boolean tema)
        {
            using NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            using NpgsqlCommand como = new NpgsqlCommand();
            como.Connection = conn;
            como.CommandType = CommandType.Text;
            como.CommandText = $@"update ""Dark_Age_Connection"".""Jogadores""
                                        set tema_atual = @tema
                                        WHERE id_jogador = @id_jogador;";
            como.Parameters.AddWithValue("@tema", tema);
            como.Parameters.AddWithValue("@id_jogador", Login.jogador);
            como.ExecuteNonQuery();
        }

        public static void update_sanidade_mod(int sanidade_mod, int id_personagem)
        {
            using NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            using NpgsqlCommand comm = new NpgsqlCommand();

            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = $@"UPDATE ""Dark_Age_Connection"".""Inter_status_personagem""
                                  SET sanidade_mod = @sanidade_mod
                                  WHERE fk_id_personagem = @id_personagem";
            comm.Parameters.AddWithValue("@id_personagem", id_personagem);
            comm.Parameters.AddWithValue("@sanidade_mod", sanidade_mod);
            comm.ExecuteNonQuery();
        }
    }
}
