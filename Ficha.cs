using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

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
        public static int pontos_totais = 10;
        public static int bd_ataque, bd_esquiva, bd_defesa, bd_contra_atq, bd_arematirar, bd_lancarmagia, bd_labia, bd_intimidacao, bd_esconder, bd_seduzir, bd_enganacao,
            bd_percepcao, bd_academicos, bd_ocultismo, bd_sobrevivencia, bd_investigacao, bd_intuicao, bd_etiqueta;
        public static int bd_ataque2, bd_esquiva2, bd_defesa2, bd_contra_atq2, bd_arematirar2, bd_lancarmagia2, bd_labia2, bd_intimidacao2, bd_esconder2, bd_seduzir2, bd_enganacao2,
            bd_percepcao2, bd_academicos2, bd_ocultismo2, bd_sobrevivencia2, bd_investigacao2, bd_intuicao2, bd_etiqueta2;
        public static int bd_sanidade = 3;
        public static int bd_sanidade2;
        public static string classe_escolhida = "";
        public static string nomepersonagem = "";
        public static int idpersonagem = 0;
        public static int pontos_max = 10;
        public static int nivel = 1;
        public static Boolean pers_criado = false;
        public static Image imagem_pers;
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


                NpgsqlConnection conn2 = new NpgsqlConnection("Server=26.45.149.194;Port=5432;Database=DarkAge_Server;user Id=João;Password=ANlsPD80");
                conn2.Open();
                NpgsqlCommand comt = new NpgsqlCommand();
                comt.Connection = conn2;
                comt.CommandType = CommandType.Text;
                comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos2\" where fk_id_talento = 1 and fk_id_personagem = @personagem";
                comt.Parameters.AddWithValue("@personagem", Login.jogador);

                NpgsqlDataReader ndp = comt.ExecuteReader();
                if (ndp.Read())
                {
                    Ficha.bd_ataque2 = (int)ndp.GetValue(0);
                }
                ndp.Close();
                comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos2\" where fk_id_talento = 2 and fk_id_personagem = @personagem";
                ndp = comt.ExecuteReader();
                if (ndp.Read())
                {
                    Ficha.bd_esquiva2 = (int)ndp.GetValue(0);
                }
                ndp.Close();
                comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos2\" where fk_id_talento = 3 and fk_id_personagem = @personagem";
                ndp = comt.ExecuteReader();
                if (ndp.Read())
                {
                    Ficha.bd_defesa2 = (int)ndp.GetValue(0);
                }
                ndp.Close();
                comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos2\" where fk_id_talento = 4 and fk_id_personagem = @personagem";
                ndp = comt.ExecuteReader();
                if (ndp.Read())
                {
                    Ficha.bd_contra_atq2 = (int)ndp.GetValue(0);
                }
                ndp.Close();
                comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos2\" where fk_id_talento = 5 and fk_id_personagem = @personagem";
                ndp = comt.ExecuteReader();
                if (ndp.Read())
                {
                    Ficha.bd_arematirar2 = (int)ndp.GetValue(0);
                }
                ndp.Close();
                comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos2\" where fk_id_talento = 6 and fk_id_personagem = @personagem";
                ndp = comt.ExecuteReader();
                if (ndp.Read())
                {
                    Ficha.bd_lancarmagia2 = (int)ndp.GetValue(0);
                }
                ndp.Close();
                comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos2\" where fk_id_talento = 7 and fk_id_personagem = @personagem";
                ndp = comt.ExecuteReader();
                if (ndp.Read())
                {
                    Ficha.bd_labia2 = (int)ndp.GetValue(0);
                }
                ndp.Close();
                comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos2\" where fk_id_talento = 8 and fk_id_personagem = @personagem";
                ndp = comt.ExecuteReader();
                if (ndp.Read())
                {
                    Ficha.bd_intimidacao2 = (int)ndp.GetValue(0);
                }
                ndp.Close();
                comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos2\" where fk_id_talento = 9 and fk_id_personagem = @personagem";
                ndp = comt.ExecuteReader();
                if (ndp.Read())
                {
                    Ficha.bd_seduzir2 = (int)ndp.GetValue(0);
                }
                ndp.Close();
                comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos2\" where fk_id_talento = 10 and fk_id_personagem = @personagem";
                ndp = comt.ExecuteReader();
                if (ndp.Read())
                {
                    Ficha.bd_enganacao2 = (int)ndp.GetValue(0);
                }
                ndp.Close();
                comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos2\" where fk_id_talento = 11 and fk_id_personagem = @personagem";
                ndp = comt.ExecuteReader();
                if (ndp.Read())
                {
                    Ficha.bd_esconder2 = (int)ndp.GetValue(0);
                }
                ndp.Close();
                comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos2\" where fk_id_talento = 12 and fk_id_personagem = @personagem";
                ndp = comt.ExecuteReader();
                if (ndp.Read())
                {
                    Ficha.bd_percepcao2 = (int)ndp.GetValue(0);
                }
                ndp.Close();
                comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos2\" where fk_id_talento = 13 and fk_id_personagem = @personagem";
                ndp = comt.ExecuteReader();
                if (ndp.Read())
                {
                    Ficha.bd_academicos2 = (int)ndp.GetValue(0);
                }
                ndp.Close();
                comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos2\" where fk_id_talento = 14 and fk_id_personagem = @personagem";
                ndp = comt.ExecuteReader();
                if (ndp.Read())
                {
                    Ficha.bd_ocultismo2 = (int)ndp.GetValue(0);
                }
                ndp.Close();
                comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos2\" where fk_id_talento = 15 and fk_id_personagem = @personagem";
                ndp = comt.ExecuteReader();
                if (ndp.Read())
                {
                    Ficha.bd_sobrevivencia2 = (int)ndp.GetValue(0);
                }
                ndp.Close();
                comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos2\" where fk_id_talento = 16 and fk_id_personagem = @personagem";
                ndp = comt.ExecuteReader();
                if (ndp.Read())
                {
                    Ficha.bd_investigacao2 = (int)ndp.GetValue(0);
                }
                ndp.Close();
                comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos2\" where fk_id_talento = 17 and fk_id_personagem = @personagem";
                ndp = comt.ExecuteReader();
                if (ndp.Read())
                {
                    Ficha.bd_intuicao2 = (int)ndp.GetValue(0);
                }
                ndp.Close();
                comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos2\" where fk_id_talento = 18 and fk_id_personagem = @personagem";
                ndp = comt.ExecuteReader();
                if (ndp.Read())
                {
                    Ficha.bd_etiqueta2 = (int)ndp.GetValue(0);
                }
                ndp.Close();
                comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos2\" where fk_id_talento = 19 and fk_id_personagem = @personagem";
                ndp = comt.ExecuteReader();
                if (ndp.Read())
                {
                    Ficha.bd_sanidade2 = (int)ndp.GetValue(0);
                }
                ndp.Dispose();
                conn2.Close();

            }

            if (pers_criado == true)
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=26.45.149.194;Port=5432;Database=DarkAge_Server;user Id=João;Password=ANlsPD80");
                conn.Open();
                NpgsqlCommand comi = new NpgsqlCommand();
                comi.Connection = conn;
                comi.CommandType = CommandType.Text;
                comi.CommandText = "select forca, destreza, vigor, carisma, raciocinio, magia, nome_personagem, classe_personagem, nivel, imagem from \"Dark_Age_Connection\".\"Personagens\" where fk_id_jogador = @jogador";
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
                    nivel = (int)nda.GetValue(8);
                    byte[] byte_image_personagem = (byte[])nda.GetValue(9); 
                   

                    classe.Text = classe_escolhida;
                    nome_personagem.Text = nomepersonagem;



                    lbl_forca.Text = forca.ToString();
                    lbl_destreza.Text = destreza.ToString();
                    lbl_vigor.Text = vigor.ToString();
                    lbl_carisma.Text = carisma.ToString();
                    lbl_raciocinio.Text = raciocinio.ToString();
                    lbl_magia.Text = magia.ToString();
                    comboBox1.Text = nivel.ToString();

                    pontos = pontos_max - forca - destreza - vigor - carisma - raciocinio - magia;
                    lbl_pontos.Text = "Pontos: " + pontos;

                    ataque.Value = bd_ataque2;
                    esquiva.Value = bd_esquiva2;
                    defesa.Value = bd_defesa2;
                    contrataque.Value = bd_contra_atq2;
                    arematirar.Value = bd_arematirar2;
                    lancarmagia.Value = bd_lancarmagia2;
                    labia.Value = bd_labia2;
                    intimidacao.Value = bd_intimidacao2;
                    seduzir.Value = bd_seduzir2;
                    enganacao.Value = bd_enganacao2;
                    esconder.Value = bd_esconder2;
                    percepcao.Value = bd_percepcao2;
                    academicos.Value = bd_academicos2;
                    ocultismo.Value = bd_ocultismo2;
                    sobrevivencia.Value = bd_sobrevivencia2;
                    investigacao.Value = bd_investigacao2;
                    intuicao.Value = bd_intuicao2;
                    etiqueta.Value = bd_etiqueta2;
                    sanidade.Value = bd_sanidade2;

                    
                    imagem_pers = byte_image.byteArrayToImage(byte_image_personagem);
                    pictureBox1.Image = imagem_pers;


                    comi.Dispose();
                    conn.Close();
                } else
                {
                    MessageBox.Show("Alguma coisa deu errado, não me pergunte oq '-', culpa do surdi!");
                }

            } else
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
            Opacity = 0;      //first the opacity is 0

            timer1.Interval = 10;  // increase the opacity every 10ms
            timer1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            timer1.Start();

        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                timer1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }




        private void label1_Click(object sender, EventArgs e)
        {
            if (pers_criado == true)
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Close();
            } else
            {
                Application.Exit();
            }
        }

        private void btn_forcasum_Click(object sender, EventArgs e)
        {


            if (forca < 5 && pontos > 0)
            {
                pontos--;
                lbl_pontos.Text = "Pontos: " + pontos;
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
                destreza++;
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
        }
        private void btn_cria_personagem_MouseDown(object sender, MouseEventArgs e)
        {
            btn_cria_personagem.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, Color.White);
            btn_cria_personagem.BackColor = Color.Transparent;
        }


        private void btn_cria_personagem_Click(object sender, EventArgs e)
        {

            NpgsqlConnection conn = new("Server=26.45.149.194;Port=5432;Database=DarkAge_Server;user Id=João;Password=ANlsPD80");
            conn.Open();
            NpgsqlCommand come = new NpgsqlCommand();
            come.Connection = conn;
            come.CommandType = CommandType.Text;
            NpgsqlCommand coms = new NpgsqlCommand();
            coms.Connection = conn;
            coms.CommandType = CommandType.Text;
            NpgsqlCommand comt = new NpgsqlCommand();
            comt.Connection = conn;
            comt.CommandType = CommandType.Text;
            NpgsqlCommand comr = new NpgsqlCommand();
            comr.Connection = conn;
            comr.CommandType = CommandType.Text;
            NpgsqlCommand comz = new NpgsqlCommand();
            comz.Connection = conn;
            comz.CommandType = CommandType.Text;

            if (classe_escolhida == "Orador" ^ classe_escolhida == "alquimista")
            {
                Form1.vida_maxima = (8 * nivel) + (2 * vigor);
            } else if (classe_escolhida == "Mestre da Forja" ^ classe_escolhida == "Caçador de Monstros")
            {
                Form1.vida_maxima = (10 * nivel) + (2 * vigor);
            } else if (classe_escolhida == "Templário")
            {
                Form1.vida_maxima = (12 * nivel) + (2 * vigor);
            } else
            {
                Form1.vida_maxima = (12 * nivel) + (2 * vigor);
            }





            if (pers_criado == false)
            {


                bd_sanidade += carisma;

                come.CommandText = "insert into \"Dark_Age_Connection\".\"Personagens\" (nome_personagem, classe_personagem, fk_id_jogador, forca, destreza, vigor, carisma, raciocinio, magia, nivel, passivas, ativas, inventario, silver, gold, vida_atual, vida_max, sanidade_atual, sanidade_max) values(@nome, @classe, @idjogador, @forca, @destreza, @vigor, @carisma, @raciocinio, @magia, @nivel, ' ', ' ', ' ', 0, 0, @vida_atual, @vida_max, @sanidade_atual, @sanidade_max)";
                come.Parameters.AddWithValue("@nome", nomepersonagem);
                come.Parameters.AddWithValue("@classe", classe_escolhida);
                come.Parameters.AddWithValue("@idjogador", Login.jogador);
                come.Parameters.AddWithValue("@forca", forca);
                come.Parameters.AddWithValue("@destreza", destreza);
                come.Parameters.AddWithValue("@vigor", vigor);
                come.Parameters.AddWithValue("@carisma", carisma);
                come.Parameters.AddWithValue("@raciocinio", raciocinio);
                come.Parameters.AddWithValue("@magia", magia);
                come.Parameters.AddWithValue("@nivel", nivel);
                come.Parameters.AddWithValue("@vida_atual", Form1.vida_maxima);
                come.Parameters.AddWithValue("@vida_max", Form1.vida_maxima);
                come.Parameters.AddWithValue("@sanidade_atual", bd_sanidade);
                come.Parameters.AddWithValue("@sanidade_max", bd_sanidade);
                come.ExecuteNonQuery();

                come.CommandText = "update \"Dark_Age_Connection\".\"Jogadores\" set pers_criado = true where id_jogador = @idjogador";
                come.Parameters.AddWithValue("@idjogador", Login.jogador);
                come.ExecuteNonQuery();
                pers_criado = true;


                idpersonagem = Login.jogador;

                comr.CommandText = " insert into  \"Dark_Age_Connection\".\"Inter_talentos2\" (fk_id_personagem, fk_id_talento, valor_talento) values (@personagem, 1, @ataque), (@personagem, 2, @esquiva), (@personagem, 3, @defesa)," +
                    "(@personagem, 4, @contra_atq), (@personagem, 5, @arematirar), (@personagem, 6, @lancarmagia), (@personagem, 7, @labia), (@personagem, 8, @intimidacao), (@personagem, 9, @seduzir), (@personagem, 10, @enganacao)," +
                    "(@personagem, 11, @esconder), (@personagem, 12, @percepcao), (@personagem, 13, @academicos), (@personagem, 14, @ocultismo), (@personagem, 15, @sobrevivencia), (@personagem, 16, @investigacao), (@personagem, 17, @intuicao), " +
                    "(@personagem, 18, @etiqueta), (@personagem, 19, @sanidade)";
                comr.Parameters.AddWithValue("@personagem", idpersonagem);
                comr.Parameters.AddWithValue("@ataque", bd_ataque2);
                comr.Parameters.AddWithValue("@esquiva", bd_esquiva2);
                comr.Parameters.AddWithValue("@defesa", bd_defesa2);
                comr.Parameters.AddWithValue("@contra_atq", bd_contra_atq2);
                comr.Parameters.AddWithValue("@arematirar", bd_arematirar2);
                comr.Parameters.AddWithValue("@lancarmagia", bd_lancarmagia2);
                comr.Parameters.AddWithValue("@labia", bd_labia2);
                comr.Parameters.AddWithValue("@intimidacao", bd_intimidacao2);
                comr.Parameters.AddWithValue("@seduzir", bd_seduzir2);
                comr.Parameters.AddWithValue("@enganacao", bd_enganacao2);
                comr.Parameters.AddWithValue("@esconder", bd_esconder2);
                comr.Parameters.AddWithValue("@percepcao", bd_percepcao2);
                comr.Parameters.AddWithValue("@academicos", bd_academicos2);
                comr.Parameters.AddWithValue("@ocultismo", bd_ocultismo2);
                comr.Parameters.AddWithValue("@sobrevivencia", bd_sobrevivencia2);
                comr.Parameters.AddWithValue("@investigacao", bd_investigacao2);
                comr.Parameters.AddWithValue("@intuicao", bd_intuicao2);
                comr.Parameters.AddWithValue("@etiqueta", bd_etiqueta2);
                comr.Parameters.AddWithValue("@sanidade", bd_sanidade2);
                comr.ExecuteNonQuery();

                bd_ataque += forca;
                bd_esquiva += destreza;
                bd_defesa += carisma;
                bd_contra_atq += forca;
                bd_arematirar += destreza;
                bd_lancarmagia += magia;
                bd_labia += carisma;
                bd_intimidacao += carisma;
                bd_seduzir += carisma;
                bd_enganacao += destreza;
                bd_esconder += destreza;
                bd_percepcao += raciocinio;
                bd_academicos += raciocinio;
                bd_ocultismo += raciocinio;
                bd_sobrevivencia += raciocinio;
                bd_investigacao += raciocinio;
                bd_intuicao += raciocinio;
                bd_etiqueta += carisma;

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
                comt.ExecuteNonQuery();


                
                byte[] imagembyte_personagem = byte_image.imageToByteArray(pictureBox1.Image);
                UpdateImagemBanco(imagembyte_personagem);


            } else
            {
                if (Form1.vida_atual > Form1.vida_maxima)
                {
                    Form1.vida_atual = Form1.vida_maxima;
                    comz.CommandText = "update \"Dark_Age_Connection\".\"Personagens\" set vida_atual = @vida_atual where fk_id_jogador = @jogador";
                    comz.Parameters.AddWithValue("@vida_atual", Form1.vida_atual);
                    comz.Parameters.AddWithValue("@jogador", Login.jogador);
                    comz.ExecuteNonQuery();
                }
                bd_sanidade = bd_sanidade2 + carisma;
                idpersonagem = Login.jogador;
                come.CommandText = "update \"Dark_Age_Connection\".\"Personagens\" set forca = @forca, destreza = @destreza, vigor = @vigor, carisma = @carisma, raciocinio = @raciocinio, magia = @magia, nivel = @nivel, vida_max = @vida_max, sanidade_max = @sanidade_max where fk_id_jogador = @jogador";
                come.Parameters.AddWithValue("@forca", forca);
                come.Parameters.AddWithValue("@destreza", destreza);
                come.Parameters.AddWithValue("@vigor", vigor);
                come.Parameters.AddWithValue("@carisma", carisma);
                come.Parameters.AddWithValue("@raciocinio", raciocinio);
                come.Parameters.AddWithValue("@magia", magia);
                come.Parameters.AddWithValue("@nivel", nivel);
                come.Parameters.AddWithValue("@jogador", Login.jogador);
                come.Parameters.AddWithValue("@vida_max", Form1.vida_maxima);
                come.Parameters.AddWithValue("@sanidade_max", bd_sanidade);
                come.ExecuteNonQuery();

                int[] specs2 = new int[] {bd_ataque2, bd_esquiva2, bd_defesa2, bd_contra_atq2, bd_arematirar2, bd_lancarmagia2, bd_labia2, bd_intimidacao2, bd_seduzir2, bd_enganacao2, bd_esconder2
                        , bd_percepcao2, bd_academicos2, bd_ocultismo2, bd_sobrevivencia2, bd_investigacao2, bd_intuicao2, bd_etiqueta2, bd_sanidade2};

                for (int t = 0; t < specs2.Length; ++t)
                {
                    NpgsqlCommand comh = new NpgsqlCommand();
                    comh.Connection = conn;
                    comh.CommandType = CommandType.Text;
                    comh.CommandText = "update \"Dark_Age_Connection\".\"Inter_talentos2\" set valor_talento = @ataque where fk_id_talento = @cod and fk_id_personagem = @personagem";
                    comh.Parameters.AddWithValue("@ataque", specs2[t]);
                    comh.Parameters.AddWithValue("@cod", t + 1);
                    comh.Parameters.AddWithValue("@personagem", idpersonagem);

                    comh.ExecuteNonQuery();
                }

                bd_ataque = bd_ataque2 + forca;
                bd_esquiva = bd_esquiva2 + destreza;
                bd_defesa = bd_defesa2 + vigor;
                bd_contra_atq = bd_contra_atq2 + forca;
                bd_arematirar = bd_arematirar2 + destreza;
                bd_lancarmagia = bd_lancarmagia2 + magia;
                bd_labia = bd_labia2 + carisma;
                bd_intimidacao = bd_intimidacao2 + carisma;
                bd_seduzir = bd_seduzir2 + carisma;
                bd_enganacao = bd_enganacao2 + destreza;
                bd_esconder = bd_esconder2 + destreza;
                bd_percepcao = bd_percepcao2 + raciocinio;
                bd_academicos = bd_academicos2 + raciocinio;
                bd_ocultismo = bd_ocultismo2 + raciocinio;
                bd_sobrevivencia = bd_sobrevivencia2 + raciocinio;
                bd_investigacao = bd_investigacao2 + raciocinio;
                bd_intuicao = bd_intuicao2 + raciocinio;
                bd_etiqueta = bd_etiqueta2 + carisma;


                int[] specs = new int[] {bd_ataque, bd_esquiva, bd_defesa, bd_contra_atq , bd_arematirar, bd_lancarmagia, bd_labia, bd_intimidacao, bd_seduzir, bd_enganacao, bd_esconder
                        , bd_percepcao, bd_academicos, bd_ocultismo, bd_sobrevivencia, bd_investigacao, bd_intuicao, bd_etiqueta, bd_sanidade};

                for (int i = 0; i < specs.Length; ++i)
                {
                    NpgsqlCommand comu = new NpgsqlCommand();
                    comu.Connection = conn;
                    comu.CommandType = CommandType.Text;
                    comu.CommandText = "update \"Dark_Age_Connection\".\"Inter_talentos\" set valor_talento = @ataque where fk_id_talento = @cod and fk_id_personagem = @personagem";
                    comu.Parameters.AddWithValue("@ataque", specs[i]);
                    comu.Parameters.AddWithValue("@cod", i + 1);
                    comu.Parameters.AddWithValue("@personagem", idpersonagem);

                    comu.ExecuteNonQuery();
                }

                
                byte[] imagembyte_personagem = byte_image.imageToByteArray(pictureBox1.Image);
                UpdateImagemBanco(imagembyte_personagem);


            }

            comt.Dispose();
            come.Dispose();

            conn.Close();


            Form1 frm = new Form1();
            frm.Show();
            this.Close();


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
            bd_ataque2 = (int)ataque.Value;
        }

        private void esquiva_ValueChanged(object sender, EventArgs e)
        {
            bd_esquiva2 = (int)esquiva.Value;
        }

        private void defesa_ValueChanged(object sender, EventArgs e)
        {
            bd_defesa2 = (int)defesa.Value;
        }

        private void contrataque_ValueChanged(object sender, EventArgs e)
        {
            bd_contra_atq2 = (int)contrataque.Value;
        }

        private void arematirar_ValueChanged(object sender, EventArgs e)
        {
            bd_arematirar2 = (int)arematirar.Value;
        }

        private void lancarmagia_ValueChanged(object sender, EventArgs e)
        {
            bd_lancarmagia2 = (int)lancarmagia.Value;
        }

        private void labia_ValueChanged(object sender, EventArgs e)
        {
            bd_labia2 = (int)labia.Value;
        }

        private void intimidacao_ValueChanged(object sender, EventArgs e)
        {
            bd_intimidacao2 = (int)intimidacao.Value;
        }

        private void seduzir_ValueChanged(object sender, EventArgs e)
        {
            bd_seduzir2 = (int)seduzir.Value;
        }

        private void enganacao_ValueChanged(object sender, EventArgs e)
        {
            bd_enganacao2 = (int)enganacao.Value;
        }

        private void esconder_ValueChanged(object sender, EventArgs e)
        {
            bd_esconder2 = (int)esconder.Value;
        }

        private void percepcao_ValueChanged(object sender, EventArgs e)
        {
            bd_percepcao2 = (int)percepcao.Value;
        }

        private void academicos_ValueChanged(object sender, EventArgs e)
        {
            bd_academicos2 = (int)academicos.Value;
        }

        private void ocultismo_ValueChanged(object sender, EventArgs e)
        {
            bd_ocultismo2 = (int)ocultismo.Value;
        }

        private void sobrevivencia_ValueChanged(object sender, EventArgs e)
        {
            bd_sobrevivencia2 = (int)sobrevivencia.Value;
        }

        private void investigacao_ValueChanged(object sender, EventArgs e)
        {
            bd_investigacao2 = (int)investigacao.Value;
        }

        private void intuicao_ValueChanged(object sender, EventArgs e)
        {
            bd_intuicao2 = (int)intuicao.Value;
        }

        private void etiqueta_ValueChanged(object sender, EventArgs e)
        {
            bd_etiqueta2 = (int)etiqueta.Value;
        }

        private void sanidade_ValueChanged(object sender, EventArgs e)
        {
            bd_sanidade2 = (int)sanidade.Value;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();

            dialogo.Title = "Procurar arquivos no computador";

            dialogo.InitialDirectory = @"C:\";

            dialogo.Filter = "Todos os arquivos (*.*)|*.*";


            DialogResult resposta = dialogo.ShowDialog();

            if (resposta == DialogResult.OK)

            {
                string caminhoCompleto = dialogo.FileName;

                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;

                Image imagem_personagem = Image.FromFile(caminhoCompleto);

                pictureBox1.Image = imagem_personagem;
            }


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

        private void lbl_forca_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1")
            {
                pontos_totais = 10;
                pontos_max = 10;
                nivel = 1;
                pontos = pontos_max - forca - destreza - vigor - carisma - raciocinio - magia;
                lbl_pontos.Text = "Pontos: " + pontos;
            } else if (comboBox1.Text == "2")
            {
                pontos_totais = 12;
                pontos_max = 12;
                nivel = 2;
                pontos = pontos_max - forca - destreza - vigor - carisma - raciocinio - magia;
                lbl_pontos.Text = "Pontos: " + pontos;
            } else if (comboBox1.Text == "3")
            {
                pontos_totais = 14;
                pontos_max = 14;
                nivel = 3;
                pontos = pontos_max - forca - destreza - vigor - carisma - raciocinio - magia;
                lbl_pontos.Text = "Pontos: " + pontos;
            } else if (comboBox1.Text == "4")
            {
                pontos_totais = 16;
                pontos_max = 16;
                nivel = 4;
                pontos = pontos_max - forca - destreza - vigor - carisma - raciocinio - magia;
                lbl_pontos.Text = "Pontos: " + pontos;
            } else if (comboBox1.Text == "5")
            {
                pontos_totais = 18;
                pontos_max = 18;
                nivel = 5;
                pontos = pontos_max - forca - destreza - vigor - carisma - raciocinio - magia;
                lbl_pontos.Text = "Pontos: " + pontos;
            }
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ataque_Click(object sender, EventArgs e)
        {
            pontos_hab = Convert.ToInt32(ataque.Value) + Convert.ToInt32(esquiva.Value) + Convert.ToInt32(defesa.Value) + Convert.ToInt32(contrataque.Value)
                + Convert.ToInt32(arematirar.Value) + Convert.ToInt32(lancarmagia.Value) + Convert.ToInt32(labia.Value) + Convert.ToInt32(intimidacao.Value) + Convert.ToInt32(seduzir.Value)
                + Convert.ToInt32(enganacao.Value) + Convert.ToInt32(esconder.Value) + Convert.ToInt32(percepcao.Value) + Convert.ToInt32(academicos.Value) + Convert.ToInt32(ocultismo.Value)
                + Convert.ToInt32(sobrevivencia.Value) + Convert.ToInt32(investigacao.Value) + Convert.ToInt32(intuicao.Value) + Convert.ToInt32(etiqueta.Value) + Convert.ToInt32(sanidade.Value) - 3;

            label40.Text = "Pontos de habilidade restantes: " + (pontos_totais - pontos_hab).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        public void UpdateImagemBanco(byte[] imagembyte_personagem)
        {
            NpgsqlConnection conn = new("Server=26.45.149.194;Port=5432;Database=DarkAge_Server;user Id=João;Password=ANlsPD80");
            conn.Open();
            NpgsqlCommand como = new NpgsqlCommand();
            como.Connection = conn;
            como.CommandType = CommandType.Text;
            como.CommandText = $@"update ""Dark_Age_Connection"".""Personagens"" 
                         set imagem = @imagembyte_personagem
                       where fk_id_jogador = @jogador";
            como.Parameters.AddWithValue("@imagembyte_personagem", imagembyte_personagem);
            como.Parameters.AddWithValue("@jogador", Login.jogador);
            como.ExecuteNonQuery();
        }


    }
}
