using Dark_Age.Enteties;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Dark_Age
{
    public partial class adicionar_editar_itens : Form
    {
        
        public string nome_item;
        public int id_profissao;
        public string dificuldade;
        public string dano;
        public string descricao;
        public Boolean material;
        public int id_tipo_itens;


        public adicionar_editar_itens()
        {
            InitializeComponent();
        }
        
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                Lista_itens.SendMessage(Handle, Lista_itens.WM_NCLBUTTONDOWN, Lista_itens.HT_CAPTION, 0);
            }
        }
        private void adicionar_editar_itens_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Lista_itens.bordas;
            panel2.BackColor = Lista_itens.bordas;
            panel3.BackColor = Lista_itens.bordas;
            panel4.BackColor = Lista_itens.bordas;

            //Carrega as profissãoao abrir a tela
                combox_profissao.DataSource = Conexao_BD.select_profissao();
                combox_profissao.ValueMember = "id_profissao";
                combox_profissao.DisplayMember = "nome_profissao";

            //carrega os tipos dos itens
                combox_tipo.DataSource = Conexao_BD.select_tipo_itens();
                combox_tipo.ValueMember = "id_tipo_itens";
                combox_tipo.DisplayMember = "nome_tipo_itens";

            //carrega os enum do dificuldade da base de dados
                combox_dificuldade.DataSource = Conexao_BD.select_enums();
                combox_dificuldade.ValueMember = "nome_enum_difi";
                combox_dificuldade.DisplayMember = "nome_enum_difi";

            // setar os valores de dos campos com oque esta na base para edição 

            if (Lista_itens.editar_adicionar == true)
            {
                NpgsqlConnection conn = new NpgsqlConnection(Conexao_BD.Caminho_DB());
                conn.Open();
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = $@"select nome_itens 
                                           , dificuldade 
                                           , fk_id_tipo_itens
                                           , fk_id_profissao
                                           , descricao
                                           , material
                                        from ""Dark_Age_Connection"".""Itens""
                                       where id_itens = @id_itens";
                comm.Parameters.AddWithValue("@id_itens", Lista_itens.id_item);
                NpgsqlDataReader nds = comm.ExecuteReader();

                if (nds.Read())
                {
                    text_nome.Text = nds.GetValue(0).ToString();
                    combox_dificuldade.SelectedValue = nds.GetValue(1).ToString();
                    combox_tipo.SelectedValue = nds.GetValue(2).ToString();
                    combox_profissao.SelectedValue = nds.GetValue(3).ToString() ;
                    richTextBox1.Text = nds.GetValue(4).ToString();
                    if((Boolean)nds.GetValue(5) == true)
                    {
                        cbx_material.Checked = true;
                    }
                    
                }
                comm.Dispose();
                nds.Close();
                conn.Close();
            }
        }

       
        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            nome_item = text_nome.Text;
            dificuldade = combox_dificuldade.Text;
            id_profissao = (int)combox_profissao.SelectedValue;
            id_tipo_itens = (int)combox_tipo.SelectedValue;
            descricao = richTextBox1.Text;
            dano = txt_dano.Text;
            if(cbx_material.Checked == true)
            {
                material = true;
            }
            else
            {
                material = false;
            }

            if (Lista_itens.editar_adicionar == false)
            {
                NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
                conn.Open();
                NpgsqlCommand como = new NpgsqlCommand();
                como.Connection = conn;
                como.CommandType = CommandType.Text;
                como.CommandText = $@"insert into ""Dark_Age_Connection"".""Itens"" (nome_itens, dificuldade, fk_id_profissao, descricao, fk_id_tipo_itens, material, dano) 
                                       values (@nome_items, (@dificuldade)::""Dark_Age_Connection"".""enum_dificuldade"", @id_profissao, @descricao, @id_tipo_itens, @material, @dano)";
                como.Parameters.AddWithValue("@nome_items", nome_item);
                como.Parameters.AddWithValue("@dificuldade", dificuldade);
                como.Parameters.AddWithValue("@id_profissao", id_profissao);
                como.Parameters.AddWithValue("@descricao", descricao);
                como.Parameters.AddWithValue("@id_tipo_itens", id_tipo_itens);
                como.Parameters.AddWithValue("@material", material);
                como.Parameters.AddWithValue("@dano", dano);

                como.ExecuteNonQuery();
                como.Dispose();
                conn.Close();
            } else if (Lista_itens.editar_adicionar == true)
            {
                NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
                conn.Open();
                NpgsqlCommand como = new NpgsqlCommand();
                como.Connection = conn;
                como.CommandType = CommandType.Text;
                como.CommandText = $@"update ""Dark_Age_Connection"".""Itens""
                                         set nome_itens = @nome_items
                                           , dificuldade = (@dificuldade)::""Dark_Age_Connection"".""enum_dificuldade""
                                           , fk_id_profissao = @id_profissao
                                           , descricao = @descricao
                                           , fk_id_tipo_itens = @id_tipo_itens
                                           , material = @material
                                           , dano = @dano
                                       where id_itens =  @id_itens";
                como.Parameters.AddWithValue("@nome_items", nome_item);
                como.Parameters.AddWithValue("@dificuldade", dificuldade);
                como.Parameters.AddWithValue("@id_profissao", id_profissao);
                como.Parameters.AddWithValue("@descricao", descricao);
                como.Parameters.AddWithValue("@id_tipo_itens", id_tipo_itens);
                como.Parameters.AddWithValue("@id_itens", Lista_itens.id_item);
                como.Parameters.AddWithValue("@material", material);
                como.Parameters.AddWithValue("@dano", dano);
                como.ExecuteNonQuery();
                como.Dispose();
                conn.Close();
            }
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}