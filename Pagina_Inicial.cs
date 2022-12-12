using Dark_Age.Componente;
using Dark_Age.Controllers;
using Dark_Age.Enteties;
using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Net;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Ink;

namespace Dark_Age
{
    public partial class Form1 : Form
    {
        public int valorHabilidade;
        public int expand = 1;
        public static string texto_imagem;
        public Boolean minmax = true;
        public static int vida_maxima;
        public static int vida_atual;
        public static int sanidade_max;
        public static int sanidade_atual;
        public static int mana_atual;
        public static int mana_maxima;
        public static int adicional_atual;
        public static int adicional_max;
        public static int escudo;
        public static byte[] imagem_personagem;
        public static Image imagem_person;


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        public Form1()
        {
            InitializeComponent();
            Opacity = 0;      //first the opacity is 0
            label1.BackColor = Color.FromArgb(150, Color.Black);
            painel_jogadores.BackColor = Color.FromArgb(150, Color.Black);
            ficha_resumida.BackColor = Color.FromArgb(0, Color.Black);
            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            panel6.BackColor = Color.Transparent;
            this.BackColor = Color.FromArgb(14, 40, 52);
            btn_open.BackColor = Color.FromArgb(14, 40, 52);



            btn_cria_personagem.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.White });
            btn_anotacoes.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.White });
            btn_inventario.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.White });
            botao_itens.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.White });
            btn_pet.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.White });

           /* NpgsqlConnection conn3 = new NpgsqlConnection(Conexao_BD.Caminho_DB());
            conn3.Open();
            NpgsqlCommand comi = new NpgsqlCommand();
            comi.Connection = conn3;
            comi.CommandType = CommandType.Text;
            comi.CommandText = $@"select forca, destreza
	                                   , vigor
	                                   , carisma
	                                   , raciocinio
	                                   , magia
	                                   , silver
	                                   , gold
	                                   , vida_atual
	                                   , vida_max
	                                   , sanidade_atual
	                                   , sanidade_max
	                                   , mana_atual
	                                   , adicional_atual
	                                   , adicional_max 
                                       , escudo
                                    from ""Dark_Age_Connection"".""Personagens"" 
                                   where id_personagem = @id_personagem";
            comi.Parameters.AddWithValue("@id_personagem", Campanha.id_personagem);
            NpgsqlDataReader nds = comi.ExecuteReader();


            if (nds.Read())
            {
                res_forca.Text = nds.GetValue(0).ToString();
                res_destreza.Text = nds.GetValue(1).ToString();
                res_vigor.Text = nds.GetValue(2).ToString();
                res_carisma.Text = nds.GetValue(3).ToString();
                res_raciocinio.Text = nds.GetValue(4).ToString();
                res_magia.Text = nds.GetValue(5).ToString();
                prata.Text = nds.GetValue(6).ToString();
                ouro.Text = nds.GetValue(7).ToString();
                vida_atual = (int)nds.GetValue(8);
                vida_maxima = (int)nds.GetValue(9);
                sanidade_atual = (int)nds.GetValue(10);
                sanidade_max = (int)nds.GetValue(11);
                mana_atual = (int)nds.GetValue(12);

                if ((int)nds.GetValue(5) <= 0)
                {
                    label30.Visible = false;
                    lbl_mana.Visible = false;
                    lbl_barra_mana3.Visible = false;
                    numericUpDown3.Visible = false;
                    panel14.Visible = false;
                }
                else
                {
                        label30.Visible = true;
                        lbl_mana.Visible = true;
                        lbl_barra_mana3.Visible = true;
                        numericUpDown3.Visible = true;
                        panel14.Visible = true;
                }

                mana_maxima = ((int)nds.GetValue(5) * 2);
                adicional_atual = (int)nds.GetValue(13);
                adicional_max = (int)nds.GetValue(14);
                if (adicional_atual > 0)
                {
                    pn_adicional.Visible = true;
                }
                escudo = (int)nds.GetValue(15);
                label24.Text = nds.GetValue(15).ToString(); 
                if(escudo > 0)
                {
                    panel12.Visible = true;
                }
                movimento.Text = "Movimento: " + (6 + (int)nds.GetValue(1)).ToString();
                iniciativa.Text = "Iniciativa: + " + ((int)nds.GetValue(1)).ToString();

                numericUpDown1.Maximum = vida_maxima;
                numericUpDown1.Value = vida_atual;
                numericUpDown2.Value = sanidade_atual;
                numericUpDown3.Value = mana_atual;

                numericUpDown2.Maximum = sanidade_max;
                numericUpDown3.Maximum = mana_maxima;

                numericUpDown5.Value = adicional_atual;
                numericUpDown6.Value = adicional_max;



                lbl_vida.Text = vida_atual + "/" + vida_maxima;
                lbl_sanidade.Text = sanidade_atual + "/" + sanidade_max;
                lbl_mana.Text = mana_atual + "/" + mana_maxima;
                lbl_adicional.Text = adicional_atual + "/" + adicional_max;

                corrige_barras();

                nds.Close();
                conn3.Close();
                comi.Dispose();
            }/*


            /*
            NpgsqlConnection conn2 = new NpgsqlConnection(Conexao_BD.Caminho_DB());
            conn2.Open();
            NpgsqlCommand comt = new NpgsqlCommand();
            comt.Connection = conn2;
            comt.CommandType = CommandType.Text;
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 1 and fk_id_personagem = @id_personagem";
            comt.Parameters.AddWithValue("@id_personagem", Campanha.id_personagem);

            NpgsqlDataReader ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_ataque = (int)ndp.GetValue(0);
                res_ataque.Text = Ficha.bd_ataque.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 2 and fk_id_personagem = @id_personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_esquiva = (int)ndp.GetValue(0);
                res_esquiva.Text = Ficha.bd_esquiva.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 3 and fk_id_personagem = @id_personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_defesa = (int)ndp.GetValue(0);
                res_defesa.Text = Ficha.bd_defesa.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 4 and fk_id_personagem = @id_personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_contra_atq = (int)ndp.GetValue(0);
                res_contrataque.Text = Ficha.bd_contra_atq.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 5 and fk_id_personagem = @id_personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_arematirar = (int)ndp.GetValue(0);
                res_atirar.Text = Ficha.bd_arematirar.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 6 and fk_id_personagem = @id_personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_lancarmagia = (int)ndp.GetValue(0);
                res_conjurar.Text = Ficha.bd_lancarmagia.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 7 and fk_id_personagem = @id_personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_labia = (int)ndp.GetValue(0);
                res_labia.Text = Ficha.bd_labia.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 8 and fk_id_personagem = @id_personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_intimidacao = (int)ndp.GetValue(0);
                res_intimidacao.Text = Ficha.bd_intimidacao.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 9 and fk_id_personagem = @id_personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_seduzir = (int)ndp.GetValue(0);
                res_seducao.Text = Ficha.bd_seduzir.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 10 and fk_id_personagem = @id_personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_enganacao = (int)ndp.GetValue(0);
                res_enganacao.Text = Ficha.bd_enganacao.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 11 and fk_id_personagem = @id_personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_esconder = (int)ndp.GetValue(0);
                res_esconder.Text = Ficha.bd_esconder.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 12 and fk_id_personagem = @id_personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_percepcao = (int)ndp.GetValue(0);
                res_percepcao.Text = Ficha.bd_percepcao.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 13 and fk_id_personagem = @id_personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_academicos = (int)ndp.GetValue(0);
                res_acad.Text = Ficha.bd_academicos.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 14 and fk_id_personagem = @id_personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_ocultismo = (int)ndp.GetValue(0);
                res_ocultismo.Text = Ficha.bd_ocultismo.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 15 and fk_id_personagem = @id_personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_sobrevivencia = (int)ndp.GetValue(0);
                res_sobrevivencia.Text = Ficha.bd_sobrevivencia.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 16 and fk_id_personagem = @id_personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_investigacao = (int)ndp.GetValue(0);
                res_investigacao.Text = Ficha.bd_investigacao.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 17 and fk_id_personagem = @id_personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_intuicao = (int)ndp.GetValue(0);
                res_intuicao.Text = Ficha.bd_intuicao.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 18 and fk_id_personagem = @id_personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_etiqueta = (int)ndp.GetValue(0);
                res_etiqueta.Text = Ficha.bd_etiqueta.ToString();
            }
            ndp.Close();
            comt.CommandText = "select valor_talento from \"Dark_Age_Connection\".\"Inter_talentos\" where fk_id_talento = 19 and fk_id_personagem = @id_personagem";
            ndp = comt.ExecuteReader();
            if (ndp.Read())
            {
                Ficha.bd_sanidade = (int)ndp.GetValue(0);
            }
            ndp.Dispose();
            ndp.Close();
            comt.Dispose();
            conn2.Close();*/
        }
        public void select_atributos()
        {
            using NpgsqlDataReader nds = Conexao_BD.select_atributos(Campanha.id_personagem, "S");

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

        public void select_talentos()
        {                     
            using NpgsqlDataReader ndp = Conexao_BD.select_talentos(Campanha.id_personagem, "S");

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

        public void select_personagem()
        {
            using NpgsqlDataReader ndp = Conexao_BD.select_info_personagem(Campanha.id_personagem);

            while (ndp.Read())
            {
                Inventario.moedas_de_prata = (int)ndp.GetValue(0);
                Inventario.moedas_de_ouro = (int)ndp.GetValue(1);
                vida_atual = (int)ndp.GetValue(2);
                vida_maxima = (int)ndp.GetValue(3);
                sanidade_atual = (int)ndp.GetValue(4);
                sanidade_max = (int)ndp.GetValue(5);
                mana_atual = (int)ndp.GetValue(6);
                adicional_atual = (int)ndp.GetValue(7);
                adicional_max = (int)ndp.GetValue(8);
                escudo = (int)ndp.GetValue(9);
            }
        }

        public void preencher_info_tela()
        {
            select_personagem();
            select_atributos();
            select_talentos();
            res_ataque.Text = Ficha.bd_ataque.ToString();
            res_esquiva.Text = Ficha.bd_esquiva.ToString();
            res_defesa.Text = Ficha.bd_defesa.ToString();
            res_contrataque.Text = Ficha.bd_contra_atq.ToString();
            res_atirar.Text = Ficha.bd_arematirar.ToString();
            res_conjurar.Text = Ficha.bd_lancarmagia.ToString();
            res_labia.Text = Ficha.bd_labia.ToString();
            res_intimidacao.Text = Ficha.bd_intimidacao.ToString();
            res_seducao.Text = Ficha.bd_seduzir.ToString();
            res_enganacao.Text = Ficha.bd_enganacao.ToString();
            res_esconder.Text = Ficha.bd_esconder.ToString();
            res_percepcao.Text = Ficha.bd_percepcao.ToString();
            res_acad.Text = Ficha.bd_academicos.ToString();
            res_ocultismo.Text = Ficha.bd_ocultismo.ToString();
            res_sobrevivencia.Text = Ficha.bd_sobrevivencia.ToString();
            res_investigacao.Text = Ficha.bd_investigacao.ToString();
            res_intuicao.Text = Ficha.bd_intuicao.ToString();
            res_etiqueta.Text = Ficha.bd_etiqueta.ToString();

            res_forca.Text = Ficha.forca.ToString();
            res_destreza.Text = Ficha.destreza.ToString();
            res_vigor.Text = Ficha.vigor.ToString();
            res_carisma.Text = Ficha.carisma.ToString();
            res_raciocinio.Text = Ficha.raciocinio.ToString();
            res_magia.Text = Ficha.magia.ToString();

            prata.Text = Inventario.moedas_de_prata.ToString();
            ouro.Text = Inventario.moedas_de_ouro.ToString();

            if (Ficha.magia <= 0)
            {
                panel_mana.Visible = false;

            } else
            {
                panel_mana.Visible = true;
            }
            mana_maxima = (Ficha.magia * 2);

            label24.Text = escudo.ToString();
            if (escudo > 0)
            {
                panel12.Visible = true;
            }

            movimento.Text = "Movimento: " + (6 + Ficha.destreza);
            iniciativa.Text = "Iniciativa: + " + Ficha.destreza;

            numericUpDown1.Maximum = vida_maxima;
            numericUpDown1.Value = vida_atual;

            numericUpDown2.Value = sanidade_atual;
            numericUpDown2.Maximum = sanidade_max;

            numericUpDown3.Value = mana_atual;
            numericUpDown3.Maximum = mana_maxima;

            numericUpDown5.Value = adicional_atual;
            numericUpDown6.Value = adicional_max;

            lbl_vida.Text = vida_atual + "/" + vida_maxima;
            lbl_sanidade.Text = sanidade_atual + "/" + sanidade_max;
            lbl_mana.Text = mana_atual + "/" + mana_maxima;
            lbl_adicional.Text = adicional_atual + "/" + adicional_max;

            corrige_barras();

            if (adicional_atual > 0)
            {
                pn_adicional.Visible = true;
            }

            Lista_de_personagens();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Square;
            minmax = false;
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public void corrige_barras()
        {
            if (vida_maxima > 0)
            {
                panel9.Width = 220;
                decimal porcentagem3 = (decimal)vida_atual / (decimal)vida_maxima;
                porcentagem3 = porcentagem3 * 220;
                panel9.Width = Convert.ToInt32(porcentagem3);
            }
            if (sanidade_max > 0)
            {
                decimal porcentagem4 = (decimal)sanidade_atual / (decimal)sanidade_max;
                porcentagem4 = porcentagem4 * 220;
                lbl_barra2.Width = Convert.ToInt32(porcentagem4);
            }
            if (mana_atual > 0)
            {
                decimal porcentagem5 = (decimal)mana_atual / (decimal)mana_maxima;
                porcentagem5 = porcentagem5 * 220;
                lbl_barra_mana3.Width = Convert.ToInt32(porcentagem5);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0

            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Minimize;
            radioButton5.Checked = true;
            timer1.Interval = 10;  //we'll increase the opacity every 10ms
            timer1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            timer1.Start();
            bemvindo.Text = "Bem-Vindo(a), "+Campanha.nome_personagem+"!";

            Lista_de_personagens();
            preencher_info_tela();
        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                timer1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            salvar_info_pers();
            this.Hide();
            Ficha.tipo_entidade = 1;
            Ficha.pers_criado = true;
            Ficha frm = new Ficha();            
            frm.Show();
        }


        private void btn_open_MouseHover(object sender, EventArgs e)
        {
            Task.Delay(150).Wait();
            btn_open.ForeColor = Color.White;
            btn_open.ImageAlign = ContentAlignment.MiddleCenter;

        }

        private void btn_open_MouseLeave(object sender, EventArgs e)
        {
            Task.Delay(175).Wait();
            btn_open.ForeColor = Color.Silver;
            btn_open.ImageAlign = ContentAlignment.MiddleRight;
        }

        private void btn_open_MouseEnter(object sender, EventArgs e)
        {
            Task.Delay(150).Wait();
            btn_open.ForeColor = Color.White;
            btn_open.ImageAlign = ContentAlignment.MiddleCenter;
        }
        private void btn_change_MouseHover(object sender, EventArgs e)
        {
            var button = (Button)sender;

            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, Color.White);
            button.FlatAppearance.BorderColor = Color.FromArgb(200, Color.White);

        }

        private void btn_change_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, Color.White);
            button.FlatAppearance.BorderColor = Color.FromArgb(200, Color.White);
        }

        private void btn_change_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.Transparent;
            button.FlatAppearance.BorderColor = Color.FromArgb(150, Color.White);

            button.Controls.Remove(new Label());
        }

        private void btn_change_MouseDown(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, Color.White);
            button.FlatAppearance.BorderColor = Color.FromArgb(200, Color.White);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Teste de Força - " + "!(1d20+" + res_forca.Text + "+" + modificador.Text + ")");
        }

        private void btn_cria_personagem_Click(object sender, EventArgs e)
        {
            Habilidades_passivas frm = new Habilidades_passivas();
            frm.ShowDialog();
            numericUpDown1.Value = vida_atual;
            numericUpDown2.Value = sanidade_atual;
            numericUpDown3.Value = mana_atual;
            numericUpDown5.Value = adicional_atual;
            corrige_barras();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Habilidades_ativas frn = new Habilidades_ativas();
            frn.Show();
        }



        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                texto_imagem = mudaimagem.Text;
                if (mudaimagem.Text == "dracula")
                {
                    Locais.BackgroundImage = global::Dark_Age.Properties.Resources.castlvania;
                }
                if (mudaimagem.Text == "lenore")
                {
                    Locais.BackgroundImage = global::Dark_Age.Properties.Resources.lenore;
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackgroundImage = global::Dark_Age.Properties.Resources.image;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackgroundImage = global::Dark_Age.Properties.Resources.castle2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackgroundImage = global::Dark_Age.Properties.Resources.festival2;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackgroundImage = global::Dark_Age.Properties.Resources.k7wvl1;
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(10, 16, 20);
            Form1.ActiveForm.BackgroundImage = null;
        }


        private void Locais_Click(object sender, EventArgs e)
        {
            visualizar_imagem vimg = new visualizar_imagem();
            vimg.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Inventario vinv = new Inventario();
            vinv.ShowDialog();
            ouro.Text = Inventario.moedas_de_ouro.ToString();
            prata.Text = Inventario.moedas_de_prata.ToString();
        }


        private void label29_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LblFecharPassivas_Click(object sender, EventArgs e)
        {
            salvar_info_pers();
            Application.Exit();
        }
        private void LblFecharPassivas_MouseHover(object sender, EventArgs e)
        {

            var label = (Label)sender;
            label.BackColor = Color.FromArgb(25, Color.LightGray);

        }
        private void LblFecharPassivas_MouseEnter(object sender, EventArgs e)
        {
            var label = (Label)sender;
            label.BackColor = Color.FromArgb(20, Color.White);
        }

        private void LblFecharPassivas_MouseLeave(object sender, EventArgs e)
        {
            var label = (Label)sender;
            label.BackColor = Color.Transparent;

        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            if (vida_maxima > 0)
            {
                lbl_vida.Text = numericUpDown1.Value + "/" + vida_maxima;
                decimal porcentagem = (((decimal)vida_atual - (decimal)Convert.ToInt32(numericUpDown1.Value)) * 100) / (decimal)vida_maxima;
                porcentagem = ((decimal)porcentagem * 220) / 100;
                panel9.Width -= Convert.ToInt32(porcentagem);
                vida_atual = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value < 6)
                {
                    panel9.BackColor = Color.Salmon;
                } else
                {
                    panel9.BackColor = Color.LimeGreen;
                }
            }           
        }


        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (sanidade_max > 0)
            {
                lbl_sanidade.Text = numericUpDown2.Value + "/" + sanidade_max;
                decimal porcentagem2 = (((decimal)sanidade_atual - (decimal)Convert.ToInt32(numericUpDown2.Value)) * 100) / (decimal)sanidade_max;
                porcentagem2 = ((decimal)porcentagem2 * 220) / 100;
                lbl_barra2.Width -= Convert.ToInt32(porcentagem2);

                sanidade_atual = Convert.ToInt32(numericUpDown2.Value);
                if (numericUpDown2.Value < 3)
                {
                    lbl_barra2.BackColor = Color.DarkSlateGray;
                } else
                {
                    lbl_barra2.BackColor = Color.CadetBlue;
                }
            }
        }

        private void mana_MouseHover(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, Color.White);
        }

        private void btn_forcasum_Click(object sender, EventArgs e)
        {
            escudo = Convert.ToInt32(label24.Text);
            escudo = escudo + 1;
            label24.Text = escudo.ToString();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (panel12.Visible == true)
            {
                panel12.Visible = false;
            } else
            {
                panel12.Visible = true;
            }

        }

        private void btn_forcasub_Click(object sender, EventArgs e)
        {
            escudo = Convert.ToInt32(label24.Text);
            escudo = escudo - 1;
            label24.Text = escudo.ToString();
            if (escudo == 0)
            {
                panel12.Visible = false;
                escudo = escudo + 1;
                label24.Text = escudo.ToString();
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (mana_maxima > 0)
            {

                lbl_mana.Text = numericUpDown3.Value + "/" + mana_maxima;
                decimal porcentagem5 = (((decimal)mana_atual - (decimal)Convert.ToInt32(numericUpDown3.Value)) * 100) / (decimal)mana_maxima;
                porcentagem5 = ((decimal)porcentagem5 * 220) / 100;
                lbl_barra_mana3.Width -= Convert.ToInt32(porcentagem5);

                mana_atual = Convert.ToInt32(numericUpDown3.Value);
                if (numericUpDown3.Value <= 2)
                {
                    lbl_barra_mana3.BackColor = Color.DeepSkyBlue;

                } else
                {
                    lbl_barra_mana3.BackColor = Color.DodgerBlue;
                }
            } else
            {
                lbl_mana.Text = "0/0";
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (pn_adicional.Visible == true)
            {
                pn_adicional.Visible = false;
            } else
            {
                pn_adicional.Visible = true;
            }
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown6.Minimum = numericUpDown5.Value;
            adicional_max = Convert.ToInt32(numericUpDown6.Value);
            lbl_adicional.Text = numericUpDown5.Value + "/" + numericUpDown6.Value;

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown5.Maximum = numericUpDown6.Value;
            adicional_atual = Convert.ToInt32(numericUpDown5.Value);
            lbl_adicional.Text = numericUpDown5.Value + "/" + numericUpDown6.Value;
        }

        private void botao_itens_Click(object sender, EventArgs e)
        {
            Lista_itens lista = new Lista_itens();
            lista.Show();
        }


        public void Lista_de_personagens()
        {
            string nome_c;
            string nome_p;
            string nome_u;
            Image image_p;
            int distancia = 0;
            try
            {

                NpgsqlConnection conn = new NpgsqlConnection(Conexao_BD.Caminho_DB());
                conn.Open();
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = @$"select nome_personagem 
                                           , classe_personagem
                                           , nome_jogador
                                           , imagem 
                                        from ""Dark_Age_Connection"".""Inter_camp_pers"" 
                                        join ""Dark_Age_Connection"".""Jogadores"" on id_jogador = fk_id_jogador 
                                        join ""Dark_Age_Connection"".""Personagens"" on id_personagem = fk_id_personagem 
                                       where fk_id_campanha =" + Campanha.id_campanha;
                NpgsqlDataReader ndv = comm.ExecuteReader();

                while (ndv.Read())
                {
                    label_com_image personagens = new label_com_image();
                    nome_p = ndv.GetValue(0).ToString();
                    nome_c = ("Classe: " + ndv.GetValue(1).ToString());
                    nome_u = ("Usuario: " + ndv.GetValue(2).ToString());
                    byte[] imagem_byte = (byte[])ndv.GetValue(3);
                    image_p = byte_image.byteArrayToImage(imagem_byte);                    

                    personagens.receber_valores(nome_p, nome_c, nome_u, image_p);
                    personagens.Dock = DockStyle.None;                                      
                    personagens.Left = 20;

                    Panel pnlDefault = new Panel();
                    pnlDefault.BackColor = Color.Transparent;
                    pnlDefault.Dock = DockStyle.None;
                    pnlDefault.Top = (personagens.Size.Height * distancia + 10);
                    pnlDefault.AutoSize = true;
                   // pnlDefault.BorderStyle = BorderStyle.FixedSingle;

                    painel_jogadores.Controls.Add(pnlDefault);
                    pnlDefault.Controls.Add(personagens);

                    distancia++;
                }
                comm.Dispose();
                ndv.Close();
                conn.Close();

            } catch (Exception a)
            {
                MessageBox.Show("ERRO no carregar as informações", "Erro:" + a);
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Campanha campanha = new Campanha();
            campanha.ShowDialog();
        }

        private void btn_descanso_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_MouseEnter(object sender, EventArgs e)
        {
            style.houver_botao(sender);
        }



        private void iconButton3_Click(object sender, EventArgs e)
        {
             if (minmax == true)
            {
                this.WindowState = FormWindowState.Normal;
                iconButton3.IconChar = FontAwesome.Sharp.IconChar.Square;
                this.CenterToScreen();
                minmax = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                iconButton3.IconChar = FontAwesome.Sharp.IconChar.Minimize;
                minmax = true;
            }
        }

        private void btn_pet_Click(object sender, EventArgs e)
        {
            Pets pets = new Pets();
            pets.Show();

        }

        private void recaregar_Click(object sender, EventArgs e)
        {
            preencher_info_tela();
        }

        public void salvar_info_pers()
        {
            using NpgsqlConnection conn = new(Conexao_BD.Caminho_DB());
            conn.Open();
            using NpgsqlCommand como = new NpgsqlCommand();
            como.Connection = conn;
            como.CommandType = CommandType.Text;
            como.CommandText = $@"update ""Dark_Age_Connection"".""Personagens"" 
                                     set vida_atual = @vida_atual
                                       , vida_max = @vida_max
                                       , sanidade_atual = @sanidade_atual
                                       , sanidade_max = @sanidade_max
                                       , mana_atual = @mana_atual 
                                       , adicional_atual = @adicional_atual
                                       , adicional_max = @adicional_max 
                                   where id_personagem = @id_personagem";
            como.Parameters.AddWithValue("@vida_atual", vida_atual);
            como.Parameters.AddWithValue("@vida_max", vida_maxima);
            como.Parameters.AddWithValue("@sanidade_atual", sanidade_atual);
            como.Parameters.AddWithValue("@sanidade_max", sanidade_max);
            como.Parameters.AddWithValue("@mana_atual", mana_atual);
            como.Parameters.AddWithValue("@adicional_atual", adicional_atual);
            como.Parameters.AddWithValue("@adicional_max", adicional_max);
            como.Parameters.AddWithValue("@id_personagem", Campanha.id_personagem);
            como.ExecuteNonQuery();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            salvar_info_pers();
        }

        private void recaregar_MouseEnter(object sender, EventArgs e)
        {
            style.houver_botao(sender);
        }

        private void btn_gravar_MouseEnter(object sender, EventArgs e)
        {
            style.houver_botao(sender);
        }
    }
}
