using Dark_Age.Componente;
using Dark_Age.Controllers;
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
        public int id_entidade;

        private void Painel_NPC_Load(object sender, EventArgs e)
        {
            Painel_entidade.preenche_atributos(id_personagem);
            lbl_dado_ataque.Text = "Ataque: 1d20 + " + Painel_entidade.forca;
        }        

        public Painel_NPC(int entidade)
        {
            InitializeComponent();
            id_entidade = entidade;
        }


        public void preencher_campos(Image image)
        {
            NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            NpgsqlCommand comi = new NpgsqlCommand();
            comi.Connection = conn;
            comi.CommandType = CommandType.Text;
            comi.CommandText = @"select pers.nome_personagem
	                                  , ent.vida_max 
	                                  , ent.vida_atual
	                                  , ent.mana_atual
	                                  , ent.mana_max
                                      , pers.id_personagem
                                   from ""Dark_Age_Connection"".""Inter_status_pers"" ent
                                   join ""Dark_Age_Connection"".""Personagens"" pers on pers.id_personagem = ent.fk_id_personagem
                                  where ent.id_entidade = @id_entidade";
            comi.Parameters.AddWithValue("@id_entidade", id_entidade);
            NpgsqlDataReader nda = comi.ExecuteReader();

            

            if (nda.Read())
            {
                lbl_nome_perso.Text = (string)nda.GetValue(0);
                vida_max = (int)nda.GetValue(1);
                vida_atual = (int)nda.GetValue(2);
                mana_atual = (int)nda.GetValue(3); 
                mana_max = (int)nda.GetValue(4);
                id_personagem = (int)nda.GetValue(5);
                image_pers.Image = image;

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

            if (vida_atual > vida_max)
            {
                vida_atual = vida_max;
            }
            txt_vida.Text = vida_atual + "/" + vida_max;
        }
        public void altera_mana()
        {
            if(mana_atual > mana_max)
            {
                mana_atual = mana_max;
            }
            txt_mana.Text = mana_atual + "/" + mana_max;
        }

        public void update_vida_mana()
        {
            NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            NpgsqlCommand comi = new NpgsqlCommand();
            comi.Connection = conn;
            comi.CommandType = CommandType.Text;
            comi.CommandText = @"update ""Dark_Age_Connection"".""Inter_status_pers""
                                    set vida_atual = @vida_atual
                                      , mana_atual = @mana_atual
                                  where id_entidade = @id_entidade";
            comi.Parameters.AddWithValue("@vida_atual", vida_atual);
            comi.Parameters.AddWithValue("@mana_atual", mana_atual);
            comi.Parameters.AddWithValue("@id_entidade", id_entidade);
            NpgsqlDataReader nda = comi.ExecuteReader();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Painel_entidade l = new Painel_entidade(id_personagem);
            l.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int roll = random.Next(1, 21);
            int iniciativa_d20 = roll + Ficha.destreza;
            Conexao_BD.update_iniciativa(id_personagem, iniciativa_d20);
        }

        private void lbl_dado_ataque_Click(object sender, EventArgs e)
        {
           
        }

        private void iniciativa_npc_MouseHover(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.ForeColor = Color.White;
        }

        private void iniciativa_npc_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.ForeColor = Color.Silver;
        }
        private void btn_detalhes_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, Color.White);
        }

        private void txt_vida_Click(object sender, EventArgs e)
        {
            txt_vida.Text = vida_atual.ToString();
        }

        private void txt_vida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_vida.Text.All(char.IsDigit))
                {
                    vida_atual = Convert.ToInt32(txt_vida.Text);
                    altera_vida();
                    update_vida_mana();
                }
                else
                {

                }
            }
        }

        private void txt_vida_Leave(object sender, EventArgs e)
        {
            if (txt_vida.Text.All(char.IsDigit))
            {
                vida_atual = Convert.ToInt32(txt_vida.Text);
                altera_vida();
                update_vida_mana();
            }
            else
            {
            }
        }

        private void txt_mana_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_mana.Text.All(char.IsDigit))
                {
                    mana_atual = Convert.ToInt32(txt_mana.Text);
                    altera_mana();
                    update_vida_mana();
                }
                else
                {
                }
            }
        }

        private void txt_mana_Click(object sender, EventArgs e)
        {
            txt_mana.Text = mana_atual.ToString();
        }

        private void txt_mana_Leave(object sender, EventArgs e)
        {
           
            if (txt_mana.Text.All(char.IsDigit))
            {
                mana_atual = Convert.ToInt32(txt_mana.Text);
                altera_mana();
                update_vida_mana();
            }
            else
            {

            }
        }

        private void image_pers_Click(object sender, EventArgs e)
        {
            visualizar_imagem.imagem_selecionada = image_pers.Image;
            visualizar_imagem foto_personagem = new visualizar_imagem();
            foto_personagem.Show();
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja Exluir esse Monstro?", "Excluir monstro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Conexao_BD.excluir_entidade(id_entidade);
            }
        }
    }
}
