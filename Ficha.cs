using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Dark_Age
{
    public partial class Ficha : Form
    {
        public int forca = 0;
        public int destreza = 0;
        public int vigor = 0;
        public int carisma = 0;
        public int raciocinio = 0;
        public int magia = 0;
        public static int pontos = 10;
        public static int pontos_hab = 0;
            public static int bd_ataque;
            public static int bd_esquiva;
            public static int bd_defesa;
            public static int bd_contra_atq;
            public static int bd_arematirar;
            public static int bd_lancarmagia;
            public static int bd_labia;
            public static int bd_intimidacao;
            public static int bd_seduzir;
            public static int bd_enganacao;
            public static int bd_esconder;
            public static int bd_percepcao; 
            public static int bd_academicos;
            public static int bd_ocultismo;
            public static int bd_sobrevivencia;
            public static int bd_investigacao;
            public static int bd_intuicao;
            public static int bd_etiqueta;
            public static int bd_sanidade = 3;
        public static string classe_escolhida = "";
        public static string nomepersonagem = "";
        public static int idpersonagem = 0;
        public static Boolean pers_criado = false;
        public Ficha()
        {
            InitializeComponent();
            
            this.BackColor = Color.FromArgb(14, 40, 52);
            button1.ForeColor = Color.FromArgb(150, Color.White);
            button2.ForeColor = Color.FromArgb(150, Color.White);
            button3.ForeColor = Color.FromArgb(150, Color.White);
            button4.ForeColor = Color.FromArgb(150, Color.White);
            button5.ForeColor = Color.FromArgb(150, Color.White);

            if (pers_criado == true)
            {
                label1.Text = "Edição de Ficha";
                btn_cria_personagem.Text = "Finalizar Edição de Personagem";
            }

            if (pers_criado == true)
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=DarkAge_Server;user Id=João;Password=AEsrNA95");
                conn.Open();
                NpgsqlCommand comi = new NpgsqlCommand();
                comi.Connection = conn;
                comi.CommandType = CommandType.Text;
                comi.CommandText = "select forca, destreza, vigor, carisma, raciocinio, magia, nome_personagem, classe_personagem from \"Dark_Age_Connection\".\"Personagens\" where fk_id_jogador = @jogador";
                comi.Parameters.AddWithValue("@jogador", Login.jogador);
                NpgsqlDataReader nda = comi.ExecuteReader();
                

                if (nda.Read())
                {
                    forca = (int)nda.GetValue(0);
                    destreza = (int)nda.GetValue(1);
                    vigor = (int)nda.GetValue(2);
                    carisma = (int)nda.GetValue(3);
                    raciocinio = (int)nda.GetValue(4);
                    magia = (int)nda.GetValue(5);
                    classe_escolhida = (string)nda.GetValue(7);
                    nomepersonagem = (string)nda.GetValue(6);

                    classe.Text = classe_escolhida;
                    nome_personagem.Text = nomepersonagem;


                    lbl_forca.Text = forca.ToString();
                    lbl_destreza.Text = destreza.ToString();
                    lbl_vigor.Text = vigor.ToString();
                    lbl_carisma.Text = carisma.ToString();
                    lbl_raciocinio.Text = raciocinio.ToString();
                    lbl_magia.Text = magia.ToString();
                    pontos = 10 - forca - destreza - vigor - carisma - raciocinio - magia;
                    lbl_pontos.Text = "Pontos: " + pontos;

                    ataque.Value = bd_ataque;
                    esquiva.Value = bd_esquiva;
                    defesa.Value = bd_defesa;
                    contrataque.Value = bd_contra_atq;
                    arematirar.Value = bd_arematirar;
                    lancarmagia.Value = bd_lancarmagia;
                    labia.Value = bd_labia;
                    intimidacao.Value = bd_intimidacao;
                    seduzir.Value = bd_seduzir;
                    enganacao.Value = bd_enganacao;
                    esconder.Value = bd_esconder;
                    percepcao.Value = bd_percepcao;
                    academicos.Value = bd_academicos;
                    ocultismo.Value = bd_ocultismo;
                    sobrevivencia.Value = bd_sobrevivencia;
                    investigacao.Value = bd_investigacao;
                    intuicao.Value = bd_intuicao;
                    etiqueta.Value = bd_etiqueta;
                    sanidade.Value = bd_sanidade;

                    comi.Dispose();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Alguma coisa deu errado, não me pergunte oq '-'");
                }

            }
            else
            {

                lbl_pontos.Text = "Pontos: " + pontos;
                lbl_forca.Text = forca.ToString();
                lbl_destreza.Text = destreza.ToString();
                lbl_vigor.Text = vigor.ToString();
                lbl_carisma.Text = carisma.ToString();
                lbl_raciocinio.Text = raciocinio.ToString();
                lbl_magia.Text = magia.ToString();

               
            }
        }

        private void Ficha_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        

        private void label1_Click(object sender, EventArgs e)
        {
            if (pers_criado == true)
            {
                Form1 frp = new Form1();
                frp.Show();
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btn_forcasum_Click(object sender, EventArgs e)
        {
            

            if (forca < 5 && pontos >0)
            {
                pontos--;
                lbl_pontos.Text = "Pontos: "+pontos;
                forca++;
                lbl_forca.Text = Convert.ToString(forca);
            }
        }


        private void btn_destrezasum_Click(object sender, EventArgs e)
        {

            if (destreza < 5 && pontos > 0)
            {
                pontos--;
                lbl_pontos.Text = "Pontos: " + pontos;
                destreza ++;
                lbl_destreza.Text = Convert.ToString(destreza);
            }
        }


        private void btn_vigorsum_Click(object sender, EventArgs e)
        {

            if (vigor < 5 && pontos > 0)
            {
                
                pontos--;
                lbl_pontos.Text = "Pontos: " + pontos;
                vigor++;
                lbl_vigor.Text = Convert.ToString(vigor);
            }
        }


        private void btn_carismasum_Click(object sender, EventArgs e)
        {

            if (carisma < 5 && pontos > 0)
            {
                pontos--;
                lbl_pontos.Text = "Pontos: " + pontos;
                carisma++;
                lbl_carisma.Text = Convert.ToString(carisma);
            }
        }


        private void btn_raciosum_Click(object sender, EventArgs e)
        {

            if (raciocinio < 5 & pontos > 0)
            {
                pontos--;
                lbl_pontos.Text = "Pontos: " + pontos;
                raciocinio++;
                lbl_raciocinio.Text = Convert.ToString(raciocinio);
            }
        }

        private void btn_magiasum_Click(object sender, EventArgs e)
        {

            if (magia < 5 && pontos > 0)
            {
                pontos--;
                lbl_pontos.Text = "Pontos: " + pontos;
                magia++;
                lbl_magia.Text = Convert.ToString(magia);
            }
        }
        private void btn_forcasub_Click(object sender, EventArgs e)
        {

            if (forca > 0)
            {
                pontos++;
                lbl_pontos.Text = "Pontos: " + pontos;
                forca--;
                lbl_forca.Text = Convert.ToString(forca);
            }
        }
        private void btn_destrezasub_Click(object sender, EventArgs e)
        {

            if (destreza > 0)
            {
                pontos++;
                lbl_pontos.Text = "Pontos: " + pontos;
                destreza--;
                lbl_destreza.Text = Convert.ToString(destreza);
            }
        }
        private void btn_vigorsub_Click(object sender, EventArgs e)
        {

            if (vigor > 0)
            {
                pontos++;
                lbl_pontos.Text = "Pontos: " + pontos;
                vigor--;
                lbl_vigor.Text = Convert.ToString(vigor);
            }
        }
        private void btn_carismasub_Click(object sender, EventArgs e)
        {
            if (carisma > 0)
            {
                pontos++;
                lbl_pontos.Text = "Pontos: " + pontos;
                carisma--;
                lbl_carisma.Text = Convert.ToString(carisma);
            }
        }
        private void btn_raciosub_Click(object sender, EventArgs e)
        {

            if (raciocinio > 0)
            {
                pontos++;
                lbl_pontos.Text = "Pontos: " + pontos;
                raciocinio--;
                lbl_raciocinio.Text = Convert.ToString(raciocinio);
            }
        }
        private void btn_magiasub_Click(object sender, EventArgs e)
        {

            if (magia > 0)
            {
                pontos++;
                lbl_pontos.Text = "Pontos: " + pontos;
                magia--;
                lbl_magia.Text = Convert.ToString(magia);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            classe_escolhida = "Orador";
            classe.Text = classe_escolhida;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            classe_escolhida = "Caçador de Monstros";
            classe.Text = classe_escolhida;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            classe_escolhida = "Alquimista";
            classe.Text = classe_escolhida;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            classe_escolhida = "Mestre da Forja";
            classe.Text = classe_escolhida; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            classe_escolhida = "Templário";
            classe.Text = classe_escolhida;
        }

        private void btn_cria_personagem_MouseHover(object sender, EventArgs e)
        {
            btn_cria_personagem.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, Color.White);
        }

        private void btn_cria_personagem_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, Color.White);
        }

        private void btn_cria_personagem_MouseLeave(object sender, EventArgs e)
        {
            btn_cria_personagem.BackColor = Color.Transparent;
        }         private void btn_cria_personagem_MouseDown(object sender, MouseEventArgs e)
        {
            btn_cria_personagem.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, Color.White);
            btn_cria_personagem.BackColor = Color.Transparent;
        }


        private void btn_cria_personagem_Click(object sender, EventArgs e)
        {
            pontos_hab = Convert.ToInt32(ataque.Value) + Convert.ToInt32(esquiva.Value) + Convert.ToInt32(defesa.Value) + Convert.ToInt32(contrataque.Value)
                + Convert.ToInt32(arematirar.Value) + Convert.ToInt32(lancarmagia.Value) + Convert.ToInt32(labia.Value) + Convert.ToInt32(intimidacao.Value) + Convert.ToInt32(seduzir.Value)
                + Convert.ToInt32(enganacao.Value) + Convert.ToInt32(esconder.Value) + Convert.ToInt32(percepcao.Value) + Convert.ToInt32(academicos.Value) + Convert.ToInt32(ocultismo.Value)
                + Convert.ToInt32(sobrevivencia.Value) + Convert.ToInt32(investigacao.Value) + Convert.ToInt32(intuicao.Value) + Convert.ToInt32(etiqueta.Value) + Convert.ToInt32(sanidade.Value) - 3;
            if (pontos_hab > 15) { 
                MessageBox.Show("Você tentou adicionar " + pontos_hab + " pontos de habilidade, sendo que existem 15 pontos para serem adicionados");
                                 }
            else {

                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=DarkAge_Server;user Id=João;Password=AEsrNA95");
                conn.Open();
                NpgsqlCommand come = new NpgsqlCommand();
                come.Connection = conn;
                come.CommandType = CommandType.Text;
                NpgsqlCommand comt = new NpgsqlCommand();
                comt.Connection = conn;
                comt.CommandType = CommandType.Text;
                if (pers_criado == false)
                {
                    come.CommandText = "insert into \"Dark_Age_Connection\".\"Personagens\" (nome_personagem, classe_personagem, fk_id_jogador, forca, destreza, vigor, carisma, raciocinio, magia) values(@nome, @classe, @idjogador, @forca, @destreza, @vigor, @carisma, @raciocinio, @magia)";
                    come.Parameters.AddWithValue("@nome", nomepersonagem);
                    come.Parameters.AddWithValue("@classe", classe_escolhida);
                    come.Parameters.AddWithValue("@idjogador", Login.jogador);
                    come.Parameters.AddWithValue("@forca", forca);
                    come.Parameters.AddWithValue("@destreza", destreza);
                    come.Parameters.AddWithValue("@vigor", vigor);
                    come.Parameters.AddWithValue("@carisma", carisma);
                    come.Parameters.AddWithValue("@raciocinio", raciocinio);
                    come.Parameters.AddWithValue("@magia", magia);
                    come.ExecuteNonQuery();

                    come.CommandText = "update \"Dark_Age_Connection\".\"Jogadores\" set pers_criado = true";
                    come.ExecuteNonQuery();
                    pers_criado = true;

                    come.CommandText = "select id_personagem from \"Dark_Age_Connection\".\"Personagens\" where fk_id_jogador = @jogador";
                    come.Parameters.AddWithValue("@jogador", Login.jogador);
                    NpgsqlDataReader nda = come.ExecuteReader();

                    if (nda.Read())
                    {
                        idpersonagem = (int)nda.GetValue(0);
                    } 
                        comt.CommandText = " insert into  \"Dark_Age_Connection\".\"Inter_talentos\" (fk_id_personagem, fk_id_talento, valor_talento) values (@personagem, 1, @ataque), (@personagem, 2, @esquiva), (@personagem, 3, @defesa)," +
                        "(@personagem, 4, @contra_atq), (@personagem, 5, @arematirar), (@personagem, 6, @lancarmagia), (@personagem, 7, @labia), (@personagem, 8, @intimidacao), (@personagem, 9, @seduzir), (@personagem, 10, @enganacao)," +
                        "(@personagem, 11, @esconder), (@personagem, 12, @percepcao), (@personagem, 13, @academicos), (@personagem, 14, @ocultismo), (@personagem, 15, @sobrevivencia), (@personagem, 16, @investigacao), (@personagem, 17, @intuicao), " +
                        "(@personagem, 18, @etiqueta), (@personagem, 19, @sanidade)";
                    comt.Parameters.AddWithValue("@personagem", idpersonagem);
                    comt.Parameters.AddWithValue("@ataque", bd_ataque);
                    comt.Parameters.AddWithValue("@esquiva", bd_esquiva);
                    comt.Parameters.AddWithValue("@defesa", bd_defesa);
                    comt.Parameters.AddWithValue("@contra_atq", bd_contra_atq);
                    comt.Parameters.AddWithValue("@arematirar", bd_arematirar);
                    comt.Parameters.AddWithValue("@lancarmagia", bd_lancarmagia);
                    comt.Parameters.AddWithValue("@labia", bd_labia);
                    comt.Parameters.AddWithValue("@intimidacao", bd_intimidacao);
                    comt.Parameters.AddWithValue("@seduzir", bd_seduzir);
                    comt.Parameters.AddWithValue("@enganacao", bd_enganacao);
                    comt.Parameters.AddWithValue("@esconder", bd_esconder);
                    comt.Parameters.AddWithValue("@percepcao", bd_percepcao);
                    comt.Parameters.AddWithValue("@academicos", bd_academicos);
                    comt.Parameters.AddWithValue("@ocultismo", bd_ocultismo);
                    comt.Parameters.AddWithValue("@sobrevivencia", bd_sobrevivencia);
                    comt.Parameters.AddWithValue("@investigacao", bd_investigacao);
                    comt.Parameters.AddWithValue("@intuicao", bd_intuicao);
                    comt.Parameters.AddWithValue("@etiqueta", bd_etiqueta);
                    comt.Parameters.AddWithValue("@sanidade", bd_sanidade);
                }
                else
                {
                    come.CommandText = "update \"Dark_Age_Connection\".\"Personagens\" set forca = @forca, destreza = @destreza, vigor = @vigor, carisma = @carisma, raciocinio = @carisma, magia = @magia where fk_id_jogador = @jogador";
                    come.Parameters.AddWithValue("@forca", forca);
                    come.Parameters.AddWithValue("@destreza", destreza);
                    come.Parameters.AddWithValue("@vigor", vigor);
                    come.Parameters.AddWithValue("@carisma", carisma);
                    come.Parameters.AddWithValue("@raciocinio", raciocinio);
                    come.Parameters.AddWithValue("@magia", magia);
                    come.Parameters.AddWithValue("@jogador", Login.jogador);
                    come.ExecuteNonQuery();

                    
                    comt.CommandText = "update \"Dark_Age_Connection\".\"Inter_talentos\" set valor_talento = @ataque where fk_id_talento = 1";
                    comt.Parameters.AddWithValue("@ataque", bd_ataque);
                    comt.ExecuteNonQuery();
                    comt.CommandText = "update \"Dark_Age_Connection\".\"Inter_talentos\" set valor_talento = @esquiva where fk_id_talento = 2";
                    comt.Parameters.AddWithValue("@esquiva", bd_esquiva);
                    comt.ExecuteNonQuery();
                    comt.CommandText = "update \"Dark_Age_Connection\".\"Inter_talentos\" set valor_talento = @defesa where fk_id_talento = 3";
                    comt.Parameters.AddWithValue("@defesa", bd_defesa);
                    comt.ExecuteNonQuery();
                    comt.CommandText = "update \"Dark_Age_Connection\".\"Inter_talentos\" set valor_talento = @contra_atq where fk_id_talento = 4";
                    comt.Parameters.AddWithValue("@contra_atq", bd_contra_atq);
                    comt.ExecuteNonQuery();
                    comt.CommandText = "update \"Dark_Age_Connection\".\"Inter_talentos\" set valor_talento = @arematirar where fk_id_talento = 5";
                    comt.Parameters.AddWithValue("@arematirar", bd_arematirar);
                    comt.ExecuteNonQuery();
                    comt.CommandText = "update \"Dark_Age_Connection\".\"Inter_talentos\" set valor_talento = @lancarmagia where fk_id_talento = 6";
                    comt.Parameters.AddWithValue("@lancarmagia", bd_lancarmagia);
                    comt.ExecuteNonQuery();
                    comt.CommandText = "update \"Dark_Age_Connection\".\"Inter_talentos\" set valor_talento = @labia where fk_id_talento = 7";
                    comt.Parameters.AddWithValue("@labia", bd_labia);
                    comt.ExecuteNonQuery();
                    comt.CommandText = "update \"Dark_Age_Connection\".\"Inter_talentos\" set valor_talento = @intimidacao where fk_id_talento = 8";
                    comt.Parameters.AddWithValue("@intimidacao", bd_intimidacao);
                    comt.ExecuteNonQuery();
                    comt.CommandText = "update \"Dark_Age_Connection\".\"Inter_talentos\" set valor_talento = @seduzir where fk_id_talento = 9";
                    comt.Parameters.AddWithValue("@seduzir", bd_seduzir);
                    comt.ExecuteNonQuery();
                    comt.CommandText = "update \"Dark_Age_Connection\".\"Inter_talentos\" set valor_talento = @enganacao where fk_id_talento = 10";
                    comt.Parameters.AddWithValue("@enganacao", bd_enganacao);
                    comt.ExecuteNonQuery();
                    comt.CommandText = "update \"Dark_Age_Connection\".\"Inter_talentos\" set valor_talento = @esconder where fk_id_talento = 11";
                    comt.Parameters.AddWithValue("@esconder", bd_esconder);
                    comt.ExecuteNonQuery();
                    comt.CommandText = "update \"Dark_Age_Connection\".\"Inter_talentos\" set valor_talento = @percepcao where fk_id_talento = 12";
                    comt.Parameters.AddWithValue("@percepcao", bd_percepcao);
                    comt.ExecuteNonQuery();
                    comt.CommandText = "update \"Dark_Age_Connection\".\"Inter_talentos\" set valor_talento = @academicos where fk_id_talento = 13";
                    comt.Parameters.AddWithValue("@academicos", bd_academicos);
                    comt.ExecuteNonQuery();
                    comt.CommandText = "update \"Dark_Age_Connection\".\"Inter_talentos\" set valor_talento = @ocultismo where fk_id_talento = 14";
                    comt.Parameters.AddWithValue("@ocultismo", bd_ocultismo);
                    comt.ExecuteNonQuery();
                    comt.CommandText = "update \"Dark_Age_Connection\".\"Inter_talentos\" set valor_talento = @sobrevivencia where fk_id_talento = 15";
                    comt.Parameters.AddWithValue("@sobrevivencia", bd_sobrevivencia);
                    comt.ExecuteNonQuery();
                    comt.CommandText = "update \"Dark_Age_Connection\".\"Inter_talentos\" set valor_talento = @investigacao where fk_id_talento = 16";
                    comt.Parameters.AddWithValue("@investigacao", bd_investigacao);
                    comt.ExecuteNonQuery();
                    comt.CommandText = "update \"Dark_Age_Connection\".\"Inter_talentos\" set valor_talento = @intuicao where fk_id_talento = 17";
                    comt.Parameters.AddWithValue("@intuicao", bd_intuicao);
                    comt.ExecuteNonQuery();
                    comt.CommandText = "update \"Dark_Age_Connection\".\"Inter_talentos\" set valor_talento = @etiqueta where fk_id_talento = 18";
                    comt.Parameters.AddWithValue("@etiqueta", bd_etiqueta);
                    comt.ExecuteNonQuery();
                    comt.CommandText = "update \"Dark_Age_Connection\".\"Inter_talentos\" set valor_talento = @sanidade where fk_id_talento = 19";
                    comt.Parameters.AddWithValue("@sanidade", bd_sanidade);
                    comt.ExecuteNonQuery();
                }

                    comt.Dispose();        
                come.Dispose();
                conn.Close();


                
                this.Close();
            }
                  
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.BorderSize = 1;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.BorderSize = 0;
        }

        private void ataque_ValueChanged(object sender, EventArgs e)
        {
            bd_ataque = (int)ataque.Value;
        }

        private void esquiva_ValueChanged(object sender, EventArgs e)
        {
            bd_esquiva = (int)esquiva.Value;
        }

        private void defesa_ValueChanged(object sender, EventArgs e)
        {
            bd_defesa = (int)defesa.Value;
        }

        private void contrataque_ValueChanged(object sender, EventArgs e)
        {
            bd_contra_atq = (int)contrataque.Value;
        }

        private void arematirar_ValueChanged(object sender, EventArgs e)
        {
            bd_arematirar = (int)arematirar.Value;
        }

        private void lancarmagia_ValueChanged(object sender, EventArgs e)
        {
            bd_lancarmagia = (int)lancarmagia.Value;
        }

        private void labia_ValueChanged(object sender, EventArgs e)
        {
            bd_labia = (int)labia.Value;
        }

        private void intimidacao_ValueChanged(object sender, EventArgs e)
        {
            bd_intimidacao = (int)intimidacao.Value;
        }

        private void seduzir_ValueChanged(object sender, EventArgs e)
        {
            bd_seduzir  = (int)seduzir.Value;
        }

        private void enganacao_ValueChanged(object sender, EventArgs e)
        {
            bd_enganacao = (int)enganacao.Value;
        }

        private void esconder_ValueChanged(object sender, EventArgs e)
        {
            bd_esconder = (int)esconder.Value;
        }

        private void percepcao_ValueChanged(object sender, EventArgs e)
        {
            bd_percepcao = (int)percepcao.Value;
        }

        private void academicos_ValueChanged(object sender, EventArgs e)
        {
            bd_academicos = (int)academicos.Value;
        }

        private void ocultismo_ValueChanged(object sender, EventArgs e)
        {
            bd_ocultismo = (int)ocultismo.Value;
        }

        private void sobrevivencia_ValueChanged(object sender, EventArgs e)
        {
            bd_sobrevivencia = (int)sobrevivencia.Value;
        }

        private void investigacao_ValueChanged(object sender, EventArgs e)
        {
            bd_investigacao = (int)investigacao.Value;
        }

        private void intuicao_ValueChanged(object sender, EventArgs e)
        {
            bd_intuicao = (int)intuicao.Value;
        }

        private void etiqueta_ValueChanged(object sender, EventArgs e)
        {
            bd_etiqueta = (int)etiqueta.Value;
        }

        private void sanidade_ValueChanged(object sender, EventArgs e)
        {
            bd_sanidade = (int)sanidade.Value;
        }

        private void nome_personagem_TextChanged(object sender, EventArgs e)
        {
            nomepersonagem = nome_personagem.Text;
        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void lbl_pontos_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label_esquiva_Click(object sender, EventArgs e)
        {

        }

        private void lbl_briga_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbl_forca_Click(object sender, EventArgs e)
        {

        }

        private void lbl_magia_Click(object sender, EventArgs e)
        {

        }

        private void lbl_raciocinio_Click(object sender, EventArgs e)
        {

        }

        private void lbl_carisma_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_vigor_Click(object sender, EventArgs e)
        {

        }

        private void lbl_destreza_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
