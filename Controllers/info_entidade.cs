using Dark_Age.Enteties;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.Arm;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Dark_Age.Controllers
{
    internal class info_entidade
    {		
		
		public static int[] Select_atributos(int id, string situacao)
        {
            using NpgsqlConnection conn = new NpgsqlConnection(Conexao_BD.Caminho_DB());
            conn.Open();
            using NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = @$"select o_atributo_forca 
                                       , o_atributo_destreza 
 	                                   , o_atributo_vigor
	                                   , o_atributo_carisma 
	                                   , o_atributo_raciocinio 
	                                   , o_atributo_magia  
                                    from ""Dark_Age_Connection"".traz_atributos(" + id + ", " + situacao + ")";
            using NpgsqlDataReader nds = comm.ExecuteReader();

            while (nds.Read())
            {
                return new int[] { (int)nds.GetValue(0), (int)nds.GetValue(1), (int)nds.GetValue(2), (int)nds.GetValue(3), (int)nds.GetValue(4), (int)nds.GetValue(5) };
            }
            return null;
        }
        public static void preencher_atributos(int id, string situacao)
        {
            int[] valores = Select_atributos(id, situacao);
            if (valores != null){
				Ficha.forca = valores[0];
				Ficha.destreza = valores[1];
				Ficha.vigor = valores[2];
				Ficha.carisma = valores[3];
				Ficha.raciocinio = valores[4];
				Ficha.magia = valores[5];
			}			
		}

        public static int[] select_talentos(int id, string situacao)
        {
			NpgsqlConnection conn = new NpgsqlConnection(Conexao_BD.Caminho_DB());
			conn.Open();
			NpgsqlCommand comm = new NpgsqlCommand();
			comm.Connection = conn;
			comm.CommandType = CommandType.Text;
			comm.CommandText = @$"select o_talento_briga 
	                                   , o_talento_esquiva 
	                                   , o_talento_defesa 
	                                   , o_talento_contra_atq 
	                                   , o_talento_arematirar 
	                                   , o_talento_lancamagia 
	                                   , o_talento_labia 
	                                   , o_talento_intimidacao 
	                                   , o_talento_seduzir 
	                                   , o_talento_enganacao 
	                                   , o_talento_esconder 
	                                   , o_talento_percepcao 
	                                   , o_talento_academicos 
	                                   , o_talento_ocultismo 
	                                   , o_talento_sobrevivencia 
	                                   , o_talento_invesigacao 
	                                   , o_talento_intuicao 
	                                   , o_talento_etiqueta 
	                                   , o_talento_sanidade 
                                    from ""Dark_Age_Connection"".traz_atributos(" + id + ", " + situacao + ")";
			NpgsqlDataReader ndp = comm.ExecuteReader();
            while (ndp.Read())
            {
                return new int[] {(int)ndp.GetValue(0), (int)ndp.GetValue(1), (int)ndp.GetValue(2) , (int)ndp.GetValue(3), (int)ndp.GetValue(4), (int)ndp.GetValue(5), (int)ndp.GetValue(6), (int)ndp.GetValue(7), (int)ndp.GetValue(8), (int)ndp.GetValue(9), (int)ndp.GetValue(10), (int)ndp.GetValue(11), (int)ndp.GetValue(12), (int)ndp.GetValue(13), (int)ndp.GetValue(14), (int)ndp.GetValue(15), (int)ndp.GetValue(16), (int)ndp.GetValue(17), (int)ndp.GetValue(18)};
            }
            return null;
		}


        public static void preencher_talento(int id, string situacao)
        {
            int [] valores = select_talentos(id, situacao);
            if (valores != null)
            {
                Ficha.bd_ataque = valores[0];
                Ficha.bd_esquiva = valores[1];
				Ficha.bd_defesa = valores[2];
				Ficha.bd_contra_atq = valores[3];
				Ficha.bd_arematirar = valores[4];
				Ficha.bd_lancarmagia = valores[5];
				Ficha.bd_labia = valores[6];
				Ficha.bd_intimidacao = valores[7];
				Ficha.bd_seduzir = valores[8];
				Ficha.bd_enganacao = valores[9];
				Ficha.bd_esconder = valores[10];
				Ficha.bd_percepcao = valores[11];
				Ficha.bd_academicos = valores[12];
				Ficha.bd_ocultismo = valores[14];
				Ficha.bd_sobrevivencia = valores[14];
				Ficha.bd_investigacao = valores[15];
				Ficha.bd_intuicao = valores[16];
				Ficha.bd_etiqueta = valores[17];
				Ficha.bd_sanidade = valores[18];
			}
        }

        public static string[] select_personagem(int tipo, int id_entidade, int id_jogador, int id_campanha)
        {
            using NpgsqlConnection conn3 = new(Conexao_BD.Caminho_DB());
            conn3.Open();
            using NpgsqlCommand comi = new NpgsqlCommand();
            comi.Connection = conn3;
            comi.CommandType = CommandType.Text;
            comi.CommandText = $@"select p.silver
                                       , p.gold
                                       , isp.vida_atual
                                       , isp.vida_max
                                       , isp.sanidade_atual
                                       , isp.sanidade_max
                                       , isp.mana_atual
                                       , isp.adicional_atual
                                       , isp.adicional_max 
                                       , isp.escudo
                                       , p.nivel
                                       , p.imagem
                                       , c.nome_classe 
                                       , p.nome_personagem
                                       , p.fk_id_classe
                                       , isp.escudo
                                       , p.id_personagem 
                                       , isp.fk_id_jogador
                                       , isp.tipo_personagem 
                                       , isp.tamanho 
                                     from ""Dark_Age_Connection"".""Inter_status_pers"" isp 
                                     join ""Dark_Age_Connection"".""Personagens"" p on p.id_personagem = fk_id_personagem
                                    left join ""Dark_Age_Connection"".""Classes"" c on c.id_classe = p.fk_id_classe
                                    where tipo_personagem = @tipo
                                      and ((id_entidade = @id_entidade) or (@id_entidade = 0))
                                      and ((fk_id_jogador = @id_jogador) or (@id_jogador = 0))
                                      and ((fk_id_campanha =  @id_campanha) or (@id_campanha = 0))
                                    group by 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20
                                    order by 2;";
            comi.Parameters.AddWithValue("@tipo", tipo);
			comi.Parameters.AddWithValue("@id_entidade", id_entidade);
			comi.Parameters.AddWithValue("@id_jogador", id_jogador);
			comi.Parameters.AddWithValue("@id_campanha", id_campanha);
			using NpgsqlDataReader ndp = comi.ExecuteReader();

            while (ndp.Read())
            {
                return new string[] { ndp.GetValue(0).ToString(), ndp.GetValue(1).ToString(), ndp.GetValue(2).ToString(), ndp.GetValue(3).ToString(), ndp.GetValue(4).ToString(), ndp.GetValue(5).ToString(), ndp.GetValue(6).ToString(), ndp.GetValue(7).ToString(), ndp.GetValue(8).ToString(), ndp.GetValue(9).ToString(), ndp.GetValue(10).ToString(), ndp.GetValue(11).ToString(), ndp.GetValue(12).ToString(), ndp.GetValue(13).ToString(), ndp.GetValue(14).ToString(), ndp.GetValue(15).ToString(), ndp.GetValue(16).ToString(), ndp.GetValue(17).ToString(), ndp.GetValue(18).ToString(), ndp.GetValue(19).ToString() }; 
            }
            return null;
        }
        public static void preencher_pers(int tipo, int id_entidade, int id_jogador, int id_campanha)
        {
            string[] valor = select_personagem(tipo, id_entidade, id_jogador, id_campanha);
            if (valor != null)
            {
				Inventario.moedas_de_prata = Int32.Parse(valor[0]);
				Inventario.moedas_de_ouro = Int32.Parse(valor[1]);
				Form1.vida_atual = Int32.Parse(valor[2]);
				Form1.vida_maxima = Int32.Parse(valor[3]);
				Form1.sanidade_atual = Int32.Parse(valor[4]);
				Form1.sanidade_max = Int32.Parse(valor[5]);
				Form1.mana_atual = Int32.Parse(valor[6]);
				Form1.adicional_atual = Int32.Parse(valor[7]);
				Form1.adicional_max = Int32.Parse(valor[8]);
				Form1.escudo = Int32.Parse(valor[9]);
                Ficha.nivel = Int32.Parse(valor[10]);
				Ficha.imagembyte_personagem = Encoding.ASCII.GetBytes(valor[11]);
				Ficha.classe_escolhida = valor[12];
				Campanha.nome_personagem = valor[13];
				Ficha.id_classe = Int32.Parse(valor[14]);
                Form1.escudo = Int32.Parse(valor[15]);
			}
		}


        public static int[] insert_update_perso(int id_pers, int id_enti, int tipo_enti, string nome, int classe, int nivel, byte[] imagem, int[] variavel_atributo, int[] variavel_talento, int id_campanha, int id_jogador, string tamanho, int mana_pers, int vida_pers)
        {
            using NpgsqlConnection conn3 = new(Conexao_BD.Caminho_DB());
            conn3.Open();
            using NpgsqlCommand comi = new NpgsqlCommand();
            comi.Connection = conn3;
            comi.CommandType = CommandType.Text;
            comi.CommandText = $@"select id_perso
	                                   , id_enti	
                                    from ""Dark_Age_Connection"".cria_pers(@id_personagem, @identidade, @tipo_entidade, @nome, @classe, @nivel, @imagem, @variavel_atributo, @variavel_talento, @id_campanha, @id_jogador, @tamanho)";
            comi.Parameters.AddWithValue("@id_personagem", id_pers);
            comi.Parameters.AddWithValue("@identidade", id_enti);
            comi.Parameters.AddWithValue("@tipo_entidade", tipo_enti);
            comi.Parameters.AddWithValue("@nome", nome);
            comi.Parameters.AddWithValue("@classe", classe);
            comi.Parameters.AddWithValue("@nivel", nivel);
            comi.Parameters.AddWithValue("@imagem", imagem);
            comi.Parameters.AddWithValue("@variavel_atributo", variavel_atributo);
            comi.Parameters.AddWithValue("@variavel_talento", variavel_talento);
            comi.Parameters.AddWithValue("@id_campanha", id_campanha);
            comi.Parameters.AddWithValue("@id_jogador", id_jogador);
            comi.Parameters.AddWithValue("@tamanho", tamanho);
            using NpgsqlDataReader ndp = comi.ExecuteReader();

            while (ndp.Read())
            {
                return new int[]{ (int)ndp.GetValue(0), (int)ndp.GetValue(1) };
            }
            return null;
        }

        public static void atualiza_ids(int id_pers, int id_enti, int tipo_enti, string nome, int classe, int nivel, byte[] imagem, int[] variavel_atributo, int[] variavel_talento, int id_campanha, int id_jogador, string tamanho, int mana_pers, int vida_pers)
        {
            int[] valor = insert_update_perso(id_pers, id_enti, tipo_enti, nome, classe, nivel, imagem, variavel_atributo, variavel_talento, id_campanha, id_jogador, tamanho, mana_pers, vida_pers);
			Campanha.id_personagem = valor[0];
			Campanha.id_entidade = valor[1];
		}

        public static void update_status_entidade(int vida_atual, int sanidade_atual, int mana_atual, int adicional_atual, int adicional_max, int escudo, int entidade)
        {
			using NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
			conn.Open();
			using NpgsqlCommand como = new NpgsqlCommand();
			como.Connection = conn;
			como.CommandType = CommandType.Text;
			como.CommandText = $@"update ""Dark_Age_Connection"".""Inter_status_pers""
                                     set vida_atual = @vida_atual
                                       , sanidade_atual = @sanidade_atual
                                       , mana_atual = @mana_atual 
                                       , adicional_atual = @adicional_atual
                                       , adicional_max = @adicional_max
                                       , escudo = @escudo
                                   where id_entidade = @id_entidade";
			como.Parameters.AddWithValue("@vida_atual", vida_atual);
			como.Parameters.AddWithValue("@sanidade_atual", sanidade_atual);
			como.Parameters.AddWithValue("@mana_atual", mana_atual);
			como.Parameters.AddWithValue("@adicional_atual", adicional_atual);
			como.Parameters.AddWithValue("@adicional_max", adicional_max);
			como.Parameters.AddWithValue("@escudo", escudo);
			como.Parameters.AddWithValue("@id_entidade", entidade);
			como.ExecuteNonQuery();
		}

    }
}
