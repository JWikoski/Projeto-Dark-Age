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
using static System.Windows.Forms.DataFormats;

namespace Dark_Age.Componente
{
    public partial class Painel_NPC : UserControl
    {
        public int vida_max;
        public int vida_atual;
        public int mana_max;
        public int mana_atual;
        public int id_personagem;

        private void Painel_NPC_Load(object sender, EventArgs e)
        {
            
        }        

        public Painel_NPC()
        {
            InitializeComponent();
        }


        public void preencher_campos(int id_pers)
        {
            id_personagem = id_pers;
            NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            NpgsqlCommand comi = new NpgsqlCommand();
            comi.Connection = conn;
            comi.CommandType = CommandType.Text;
            comi.CommandText = @"select forca
	                                  , destreza
	                                  , vigor
	                                  , carisma
	                                  , raciocinio
	                                  , magia
	                                  , nome_personagem
	                                  , vida_max 
	                                  , vida_atual 
	                                  , mana_atual
                                   from ""Dark_Age_Connection"".""Personagens"" 
                                  where id_personagem = @id_personagem";
            comi.Parameters.AddWithValue("@id_personagem", id_pers);
            NpgsqlDataReader nda = comi.ExecuteReader();

            if (nda.Read())
            {
                lbl_forca.Text = "Força: " + Convert.ToString((int)nda.GetValue(0));
                lbl_dest.Text = "Destreza: " + Convert.ToString((int)nda.GetValue(1));
                lbl_vigor.Text = "Vigor: " + Convert.ToString((int)nda.GetValue(2));
                lbl_caris.Text = "Carisma: " + Convert.ToString((int)nda.GetValue(3));
                lbl_raci.Text = "Raciocinio: " + Convert.ToString((int)nda.GetValue(4));
                lbl_magia.Text = "Magia: " + Convert.ToString((int)nda.GetValue(5));
                lbl_nome_perso.Text = (string)nda.GetValue(6);
                vida_max = (int)nda.GetValue(7);
                vida_atual = (int)nda.GetValue(8);
                mana_atual = (int)nda.GetValue(9); 
                mana_max = (2 * (int)nda.GetValue(5));
                if((int)nda.GetValue(0) > (int)nda.GetValue(1))
                {
                    lbl_dado_ataque.Text = "Ataque: 1d20 + " + Convert.ToString((int)nda.GetValue(0));
                } else
                {
                    lbl_dado_ataque.Text = "Ataque: 1d20 + " + Convert.ToString((int)nda.GetValue(1));
                }                
                comi.Dispose();
                conn.Close();
            }           
            altera_vida();
            altera_mana();
        }


        private void btn_aumenta_vida_Click(object sender, EventArgs e)
        {            
            if (vida_atual < vida_max)
            {
                vida_atual++;
                altera_vida();
                update_vida_mana();
            }        
        }

        private void btn_diminui_vida_Click(object sender, EventArgs e)
        {            
            if (vida_atual > 0)
            {
                vida_atual--;
                altera_vida();
                update_vida_mana();
            }
        }

        private void btn_aumenta_mana_Click(object sender, EventArgs e)
        {
            if (mana_atual < mana_max)
            {
                mana_atual++;
                altera_mana();
                update_vida_mana();
            }            
        }

        private void btn_diminui_mana_Click(object sender, EventArgs e)
        {
            if (mana_atual > 0)
            {
                mana_atual--;
                altera_mana();
                update_vida_mana();
            }            
        }
        public void altera_vida()
        {
            txt_vida.Text = vida_atual + "/" + vida_max;
        }
        public void altera_mana()
        {
            txt_mana.Text = mana_atual + "/" + mana_max;
        }

        public void update_vida_mana()
        {
            NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            NpgsqlCommand comi = new NpgsqlCommand();
            comi.Connection = conn;
            comi.CommandType = CommandType.Text;
            comi.CommandText = @"update ""Dark_Age_Connection"".""Personagens""
                                    set vida_atual = @vida_atual
                                      , mana_atual = @mana_atual
                                  where id_personagem = @id_personagem";
            comi.Parameters.AddWithValue("@vida_atual", vida_atual);
            comi.Parameters.AddWithValue("@mana_atual", mana_atual);
            comi.Parameters.AddWithValue("@id_personagem", id_personagem);
            NpgsqlDataReader nda = comi.ExecuteReader();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adicionar_editar_itens l = new adicionar_editar_itens();
            l.ShowDialog();
        }
    }
}
