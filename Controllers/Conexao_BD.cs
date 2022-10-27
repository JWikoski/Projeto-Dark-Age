﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dark_Age.Enteties
{
    public static class Conexao_BD
    {
        public static string Caminho_DB()
        {
            return "Server=db.lrtxyttihecehnpzgeus.supabase.co;Port=5432;Database=postgres;user Id=postgres;Password=ProjetoDark@ge123";
            //return "Server=26.45.149.194;Port=5432;Database=DarkAge_Server;user Id=João;Password=ANlsPD80";
        }

        public static DataTable select_enums()
        {
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
                NpgsqlDataAdapter dt_adapter_tipo = new NpgsqlDataAdapter($@"select id_tipo_itens 
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
                NpgsqlDataAdapter dt_adapter_profissao = new NpgsqlDataAdapter($@"select id_profissao
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
                NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter($@"select id_itens 
                                                                             , nome_itens 
                                                                             , dificuldade 
                                                                             , nome_tipo_itens
                                                                             , nome_profissao
                                                                             , descricao
                                                                          from ""Dark_Age_Connection"".""Itens""
                                                                          join ""Dark_Age_Connection"".""Profissao"" on id_profissao = fk_id_profissao 
                                                                          join ""Dark_Age_Connection"".""Tipo_itens"" on id_tipo_itens = fk_id_tipo_itens ;", Conexao_BD.Caminho_DB());
                NpgsqlCommandBuilder cBuilder = new NpgsqlCommandBuilder(dt_adapter);
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

            NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter($@"select id_itens 
                                                             , nome_itens 
                                                             , dificuldade 
                                                             , nome_tipo_itens
                                                             , nome_profissao
                                                             , descricao
                                                          from ""Dark_Age_Connection"".""Itens""
                                                          join ""Dark_Age_Connection"".""Profissao"" on id_profissao = fk_id_profissao 
                                                          join ""Dark_Age_Connection"".""Tipo_itens"" on id_tipo_itens = fk_id_tipo_itens 
                                                          where nome_itens ILIKE '%" + nome + "%' or " +
                                                      "nome_tipo_itens ILIKE '%" + nome + "%' " +
                                                      "or nome_profissao ILIKE '%" + nome + "%';", Conexao_BD.Caminho_DB());
            NpgsqlCommandBuilder cBuilder = new NpgsqlCommandBuilder(dt_adapter);
            DataTable dt_table = new DataTable();

            dt_adapter.Fill(dt_table);
            return dt_table;
        }

        public static DataTable select_campanha()
        {
            try
            {
                NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter($@"select id_campanha 
	                                                                         , nome_campanha 
                                                                          from ""Dark_Age_Connection"".""Campanha"";", Conexao_BD.Caminho_DB());
                NpgsqlCommandBuilder cBuilder = new NpgsqlCommandBuilder(dt_adapter);
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
                NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter($@"select id_personagem
	                                                                         , nome_personagem
	                                                                         , mestre 
                                                                         from ""Dark_Age_Connection"".""Inter_camp_pers"" 
                                                                         join ""Dark_Age_Connection"".""Jogadores"" on id_jogador = fk_id_jogador 
                                                                         join ""Dark_Age_Connection"".""Personagens"" on id_personagem = fk_id_personagem
                                                                        where id_jogador ="+ id_jogador+  
                                                                          "and fk_id_campanha = "+ id_campanha+";", Conexao_BD.Caminho_DB());
                
                NpgsqlCommandBuilder cBuilder = new NpgsqlCommandBuilder(dt_adapter);
                DataTable dt_table = new DataTable();

                dt_adapter.Fill(dt_table);
                return dt_table;
            } catch(Exception e)
            {
                MessageBox.Show("ERRO nas select personagem: " + e);
                return null;
            }
        }
    }
}
