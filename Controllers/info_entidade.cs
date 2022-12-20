using Dark_Age.Enteties;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Dark_Age.Controllers
{
    internal class info_entidade
    {
        public static void  select_atributos(int id, string situacao)
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
                Ficha.forca = (int)nds.GetValue(0);
                Ficha.destreza = (int)nds.GetValue(1);
                Ficha.vigor = (int)nds.GetValue(2);
                Ficha.carisma = (int)nds.GetValue(3);
                Ficha.raciocinio = (int)nds.GetValue(4);
                Ficha.magia = (int)nds.GetValue(5);
            }
        }

        public static void select_talentos(int id, string situacao)
        {
            using NpgsqlConnection conn = new NpgsqlConnection(Conexao_BD.Caminho_DB());
            conn.Open();
            using NpgsqlCommand comm = new NpgsqlCommand();
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
                                    from ""Dark_Age_Connection"".traz_atributos(" + id+ ", " + situacao + ")";
            using NpgsqlDataReader ndp = comm.ExecuteReader();
            while (ndp.Read())
            {
                Ficha.bd_ataque = (int)ndp.GetValue(0);
                Ficha.bd_esquiva = (int)ndp.GetValue(1);
                Ficha.bd_defesa = (int)ndp.GetValue(2);
                Ficha.bd_contra_atq = (int)ndp.GetValue(3);
                Ficha.bd_arematirar = (int)ndp.GetValue(4);
                Ficha.bd_lancarmagia = (int)ndp.GetValue(5);
                Ficha.bd_labia = (int)ndp.GetValue(6);
                Ficha.bd_intimidacao = (int)ndp.GetValue(7);
                Ficha.bd_seduzir = (int)ndp.GetValue(8);
                Ficha.bd_enganacao = (int)ndp.GetValue(9);
                Ficha.bd_esconder = (int)ndp.GetValue(10);
                Ficha.bd_percepcao = (int)ndp.GetValue(11);
                Ficha.bd_academicos = (int)ndp.GetValue(12);
                Ficha.bd_ocultismo = (int)ndp.GetValue(13);
                Ficha.bd_sobrevivencia = (int)ndp.GetValue(14);
                Ficha.bd_investigacao = (int)ndp.GetValue(15);
                Ficha.bd_intuicao = (int)ndp.GetValue(16);
                Ficha.bd_etiqueta = (int)ndp.GetValue(17);
                Ficha.bd_sanidade = (int)ndp.GetValue(18);
            }
        }

        public static void select_personagem(int id)
        {
            using NpgsqlConnection conn3 = new(Conexao_BD.Caminho_DB());
            conn3.Open();
            using NpgsqlCommand comi = new NpgsqlCommand();
            comi.Connection = conn3;
            comi.CommandType = CommandType.Text;
            comi.CommandText = $@"select silver
                                       , gold
                                       , vida_atual
                                       , vida_max
                                       , sanidade_atual
                                       , sanidade_max
                                       , mana_atual
                                       , adicional_atual
                                       , adicional_max 
                                       , escudo
                                       , nivel
                                       , imagem
                                       , c.nome_classe 
                                       , nome_personagem 
                                    from ""Dark_Age_Connection"".""Personagens"" p
                                    join ""Dark_Age_Connection"".""Classes"" c on c.id_classe = p.fk_id_classe 
                                   where id_personagem = @id_personagem";
            comi.Parameters.AddWithValue("@id_personagem", id);
            using NpgsqlDataReader ndp = comi.ExecuteReader();

            while (ndp.Read())
            {
                Inventario.moedas_de_prata = (int)ndp.GetValue(0);
                Inventario.moedas_de_ouro = (int)ndp.GetValue(1);
                Form1.vida_atual = (int)ndp.GetValue(2);
                Form1.vida_maxima = (int)ndp.GetValue(3);
                Form1.sanidade_atual = (int)ndp.GetValue(4);
                Form1.sanidade_max = (int)ndp.GetValue(5);
                Form1.mana_atual = (int)ndp.GetValue(6);
                Form1.adicional_atual = (int)ndp.GetValue(7);
                Form1.adicional_max = (int)ndp.GetValue(8);
                Form1.escudo = (int)ndp.GetValue(9);
                Ficha.nivel = (int)ndp.GetValue(10);
                Ficha.imagembyte_personagem = (byte[])ndp.GetValue(11);
                Ficha.classe_escolhida = ndp.GetValue(12).ToString();
                Ficha.nomepersonagem = ndp.GetValue(13).ToString();
            }
        }

        public static void insert_update_perso(int id_pers, int id_enti, int tipo_enti, string nome, int classe, int nivel, byte[] imagem, int[] variavel_atributo, int[] variavel_talento, int id_campanha, int id_jogador)
        {
            using NpgsqlConnection conn3 = new(Conexao_BD.Caminho_DB());
            conn3.Open();
            using NpgsqlCommand comi = new NpgsqlCommand();
            comi.Connection = conn3;
            comi.CommandType = CommandType.Text;
            comi.CommandText = $@"select id_perso
	                                   , id_enti	
                                    from ""Dark_Age_Connection"".cria_pers(@id_personagem, @identidade, @tipo_entidade, @nome, @classe, @nivel, @imagem, @variavel_atributo, @variavel_talento, @id_campanha, @id_jogador)";
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
            using NpgsqlDataReader ndp = comi.ExecuteReader();

            while (ndp.Read())
            {
                Campanha.id_personagem = (int)ndp.GetValue(0);
                Campanha.id_entidade = (int)ndp.GetValue(1);
            }
        }

    }
}
