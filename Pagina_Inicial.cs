using Dark_Age.Componente;
using Dark_Age.Controllers;
using Dark_Age.Enteties;
using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

using System.Runtime.InteropServices;

namespace Dark_Age
{
    public partial class Form1 : Form
    {
        public int valorHabilidade;
        public int expand = 1;
        public static string texto_imagem;
        public Boolean minmax = true;
        public static Boolean imagem_tema;
        public static int vida_maxima;
        public static int vida_atual;
        public static int sanidade_max;
        public static int sanidade_atual;
        public static int mana_atual;
        public static int mana_maxima;
        public static int adicional_atual;
        public static int adicional_max;
        public static int escudo;
        public static Image tmp_bkgd;

        public static int cont_morte = 0;
        public static int cont_sucesso = 0;

        public static byte[] imagem_personagem;
        public static Image imagem_person;
        public static Color cor_fundo = Color.FromArgb(10, 16, 20);
        public static int iniciativa_atual;
        public int count_novo, count_antigo, distancia;
        public static int vida_total_old = 0;
        public static int sanidade_mod;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public Form1()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            Opacity = 0;      //first the opacity is 0
            btn_jogadores.BackColor = Color.FromArgb(150, Color.Black);
            btn_iniciativa.BackColor = Color.FromArgb(90, Color.Black);
            lbl_jogar_iniciativa.BackColor = Temas.cor_escura_secundaria;
            btn_chat.BackColor = Color.FromArgb(90, Color.Black);
            personagens.BackColor = Color.FromArgb(150, Color.Black);
            ficha_resumida.BackColor = Color.FromArgb(0, Color.Black);

            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            panel6.BackColor = Color.Transparent;
            this.BackColor = Color.FromArgb(14, 40, 52);
            btn_open.BackColor = Color.FromArgb(14, 40, 52);
            btn_cria_personagem.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.White });
            btn_inventario.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.White });
            botao_itens.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.White });
            btn_pet.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.White });

        }

        public void preencher_info_tela()
        {

            info_entidade.preencher_pers(1, Campanha.id_entidade, 0, 0, Campanha.id_personagem);
            info_entidade.preencher_atributos(Campanha.id_personagem, "'S'");
            info_entidade.preencher_talento(Campanha.id_personagem, "'S'");

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

            }
            else
            {
                panel_mana.Visible = true;
            }

            label24.Text = escudo.ToString();
            if (escudo > 0)
            {
                panel12.Visible = true;
            }

            sanidade_max += sanidade_mod;

            movimento.Text = "Movimento: " + (6 + Ficha.destreza);
            iniciativa_bonus.Text = "Iniciativa: + " + Ficha.destreza;

            numericUpDown1.Maximum = vida_maxima;
            numericUpDown1.Value = vida_atual;

            numericUpDown2.Value = sanidade_atual;
            numericUpDown2.Maximum = sanidade_max + 1;

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
            carregar_danos();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (minmax == false && e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public void corrige_barras()
        {
            if (vida_maxima > 0)
            {
                panel9.Width = 159;
                decimal porcentagem3 = (decimal)vida_atual / (decimal)vida_maxima;
                porcentagem3 = porcentagem3 * 159;
                panel9.Width = Convert.ToInt32(porcentagem3);
            }
            if (sanidade_max > 0)
            {
                decimal porcentagem4 = (decimal)sanidade_atual / (decimal)sanidade_max;
                porcentagem4 = porcentagem4 * 159;
                lbl_barra2.Width = Convert.ToInt32(porcentagem4);
            }
            if (mana_atual > 0)
            {
                decimal porcentagem5 = (decimal)mana_atual / (decimal)mana_maxima;
                porcentagem5 = porcentagem5 * 159;
                lbl_barra_mana3.Width = Convert.ToInt32(porcentagem5);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0

            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Minimize;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            timer1.Interval = 10;  //we'll increase the opacity every 10ms
            timer1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            timer2.Interval = 10;
            timer2.Tick += new EventHandler(fadeOut);
            timer3.Interval = 10;
            timer3.Tick += new EventHandler(fadeIn2);
            timer1.Start();
            bemvindo.Text = "Bem-Vindo(a), " + Campanha.nome_personagem + "!";

            Lista_de_personagens();
            preencher_info_tela();
            checaguem_criacao_msg();


            timer_atualizar_informações.Start();
        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Temas.tema_claro == true)
            {
                radioButton4.Checked = true;
            }
            else
            {
                radioButton3.Checked = true;
            }
            if (Opacity >= 1)
            {
                timer1.Stop();
                timer3.Stop();
            }
            else
            {
                Opacity += 0.05;
            }

        }
        void fadeIn2(object sender, EventArgs e)
        {
            if (imagem_tema == true)
            {
                Form1.ActiveForm.BackgroundImage = tmp_bkgd;
            }
            if (Opacity >= 1)
            {
                timer1.Stop();
                timer3.Stop();
            }
            else
            {
                Opacity += 0.10;
            }

        }
        void fadeOut(object sender, EventArgs e)
        {
            if (Form1.ActiveForm.BackgroundImage != null)
            {
                tmp_bkgd = Form1.ActiveForm.BackgroundImage;
            }
            Form1.ActiveForm.BackgroundImage = null;
            if (Opacity <= 0)
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
                timer2.Stop();
                timer3.Start();
            }
            else
            {
                Opacity -= 1;
            }
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
            if (button.Name == "btn_anotacoes")
            {
                lbl_anotacoes.Visible = true;
            }
        }

        private void btn_change_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.Transparent;
            button.FlatAppearance.BorderColor = Color.FromArgb(150, Color.White);
            if (button.Name == "btn_anotacoes")
            {
                lbl_anotacoes.Visible = false;
            }
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
            Habilidades frm = new Habilidades();
            frm.ShowDialog();
            numericUpDown1.Value = vida_atual;
            numericUpDown2.Value = sanidade_atual;
            numericUpDown3.Value = mana_atual;
            numericUpDown5.Value = adicional_atual;
            corrige_barras();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Anotacoes_regras_gerais frn = new Anotacoes_regras_gerais();
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
            imagem_tema = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackgroundImage = global::Dark_Age.Properties.Resources.castle2;
            imagem_tema = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackgroundImage = global::Dark_Age.Properties.Resources.festival2;
            imagem_tema = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackgroundImage = global::Dark_Age.Properties.Resources.k7wvl1;
            imagem_tema = true;
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(10, 16, 20);
            Form1.ActiveForm.BackgroundImage = null;
            imagem_tema = false;
        }


        private void Locais_Click(object sender, EventArgs e)
        {
            visualizar_imagem vimg = new visualizar_imagem();
            vimg.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Inventario vinv = new Inventario();
            vinv.Show();
            carregar_danos();
            ouro.Text = Inventario.moedas_de_ouro.ToString();
            prata.Text = Inventario.moedas_de_prata.ToString();
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
                porcentagem = ((decimal)porcentagem * 159) / 100;
                panel9.Width -= Convert.ToInt32(porcentagem);
                vida_atual = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value < 6)
                {
                    panel9.BackColor = Color.Salmon;
                }
                else
                {
                    panel9.BackColor = Color.LimeGreen;
                }
            }
        }


        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (sanidade_max > 0)
            {
                if (numericUpDown2.Value == -1)
                {
                    sanidade_mod--;
                    sanidade_max--;
                    numericUpDown2.Maximum = sanidade_max + 1;
                    numericUpDown2.Value = numericUpDown2.Maximum - 1;
                    sanidade_atual = Convert.ToInt32(numericUpDown2.Value);
                    Conexao_BD.update_sanidade_mod(sanidade_mod, Campanha.id_personagem);

                    lbl_barra2.Width = 159;
                    lbl_sanidade.Text = sanidade_atual + "/" + (sanidade_max);

                    if (numericUpDown2.Value < 3)
                    {
                        lbl_barra2.BackColor = Color.DarkSlateGray;
                    }
                    else
                    {
                        lbl_barra2.BackColor = Color.CadetBlue;
                    }

                }
                else if (numericUpDown2.Value == numericUpDown2.Maximum)
                {
                    sanidade_mod++;
                    sanidade_max++;
                    numericUpDown2.Maximum = sanidade_max + 1;
                    numericUpDown2.Value = numericUpDown2.Maximum - 1;
                    sanidade_atual = Convert.ToInt32(numericUpDown2.Value);
                    Conexao_BD.update_sanidade_mod(sanidade_mod, Campanha.id_personagem);

                    lbl_barra2.Width = 159;
                    lbl_sanidade.Text = sanidade_atual + "/" + (sanidade_max);

                    if (numericUpDown2.Value < 3)
                    {
                        lbl_barra2.BackColor = Color.DarkSlateGray;
                    }
                    else
                    {
                        lbl_barra2.BackColor = Color.CadetBlue;
                    }

                }
                else
                {
                    lbl_sanidade.Text = numericUpDown2.Value + "/" + (sanidade_max);
                    decimal porcentagem2 = (((decimal)sanidade_atual - (decimal)Convert.ToInt32(numericUpDown2.Value)) * 100) / ((decimal)sanidade_max);
                    porcentagem2 = ((decimal)porcentagem2 * 159) / 100;
                    lbl_barra2.Width -= Convert.ToInt32(porcentagem2);

                    sanidade_atual = Convert.ToInt32(numericUpDown2.Value);

                    if (numericUpDown2.Value < 3)
                    {
                        lbl_barra2.BackColor = Color.DarkSlateGray;
                    }
                    else
                    {
                        lbl_barra2.BackColor = Color.CadetBlue;
                    }
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
            }
            else
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
                porcentagem5 = ((decimal)porcentagem5 * 159) / 100;
                lbl_barra_mana3.Width -= Convert.ToInt32(porcentagem5);

                mana_atual = Convert.ToInt32(numericUpDown3.Value);
                if (numericUpDown3.Value <= 2)
                {
                    lbl_barra_mana3.BackColor = Color.DeepSkyBlue;

                }
                else
                {
                    lbl_barra_mana3.BackColor = Color.DodgerBlue;
                }
            }
            else
            {
                lbl_mana.Text = "0/0";
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (pn_adicional.Visible == true)
            {
                pn_adicional.Visible = false;
            }
            else
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
            int id_e;
            int vida_max_sel = 0;
            int vida_atual_sel = 0;

            int vida_total = 0;
            Image image_p;
            int distancia = 0;
            try
            {
                DataTable ndv = Conexao_BD.select_personagem_campanha(0, Campanha.id_campanha, 1);


                foreach (DataRow dr in ndv.Rows)
                {
                    id_e = (int)dr["id_entidade"];
                    string[] valor = info_entidade.select_personagem(1, id_e, 0, Campanha.id_campanha, 0);

                    vida_total += Int32.Parse(valor[2]);
                }
                if (vida_total != vida_total_old)
                {
                    personagens.Controls.Clear();
                    foreach (DataRow dr in ndv.Rows)
                    {
                        label_com_image personagens = new label_com_image();
                        id_e = (int)dr["id_entidade"];
                        nome_p = dr["nome_personagem"].ToString();
                        nome_c = ("Classe: " + dr["nome_classe"].ToString());
                        nome_u = ("Jogador: " + dr["nome_jogador"].ToString());
                        byte[] imagem_byte = ((byte[])dr["imagem"]);
                        image_p = byte_image.byteArrayToImage(imagem_byte);

                        string[] valor = info_entidade.select_personagem(1, id_e, 0, Campanha.id_campanha, 0);

                        vida_atual_sel = Int32.Parse(valor[2]);
                        vida_max_sel = Int32.Parse(valor[3]);

                        personagens.receber_valores(nome_p, nome_c, nome_u, image_p, vida_max_sel, vida_atual_sel);
                        personagens.Dock = DockStyle.None;
                        personagens.Left = 20;

                        Panel pnlDefault = new Panel();
                        pnlDefault.BackColor = Color.Transparent;
                        pnlDefault.Dock = DockStyle.None;
                        pnlDefault.Top = (personagens.Size.Height * distancia + 10);
                        pnlDefault.AutoSize = true;
                        // pnlDefault.BorderStyle = BorderStyle.FixedSingle;

                        this.personagens.Controls.Add(pnlDefault);
                        pnlDefault.Controls.Add(personagens);

                        distancia++;
                        vida_total_old = vida_total;
                    }

                }

            }
            catch (Exception a)
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
            timer2.Start();
        }

        private void btn_pet_Click(object sender, EventArgs e)
        {
            NPCs.tipo_entidade = 2;
            NPCs pets = new NPCs();
            pets.Show();
        }

        private void recaregar_Click(object sender, EventArgs e)
        {
            preencher_info_tela();
        }

        public void salvar_info_pers()
        {
            info_entidade.update_status_entidade(vida_atual, sanidade_atual, mana_atual, adicional_atual, adicional_max, escudo, Campanha.id_entidade);
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            salvar_info_pers();
        }

        private void recaregar_MouseEnter(object sender, EventArgs e)
        {
            style.houver_botao(sender);
            label2.Text = "Atualizar";
            label2.Visible = true;
        }

        private void btn_gravar_MouseEnter(object sender, EventArgs e)
        {
            style.houver_botao(sender);
            label2.Text = "Salvar";
            label2.Visible = true;
        }

        private void recaregar_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();


            MyDialog.AnyColor = true;
            MyDialog.SolidColorOnly = false;
            MyDialog.ShowHelp = true;
            MyDialog.FullOpen = true;
            MyDialog.AllowFullOpen = true;
            MyDialog.Color = cor_fundo;


            if (MyDialog.ShowDialog() == DialogResult.OK)
                cor_fundo = MyDialog.Color;
            this.BackColor = MyDialog.Color;
            Form1.ActiveForm.BackgroundImage = null;
            imagem_tema = false;
        }

        private void carregar_danos()
        {
            temp_danos.DataSource = Conexao_BD.select_itens_equipados();
            temp_danos.EndEdit();
            int q = temp_danos.Rows.Count;
            int i = 0;
            lbl_danos.Text = "";

            while (i < q - 1)
            {
                DataGridViewRow row_temp = temp_danos.Rows[i];
                lbl_danos.Text += row_temp.Cells[1].Value.ToString() + ": " + row_temp.Cells[2].Value.ToString() + "\n\r";
                i++;
            }

        }
        private void carregar_iniciativa()
        {
            try
            {
                data_grid_iniciativa.DataSource = Conexao_BD.select_iniciativa(Campanha.id_campanha);
                if (data_grid_iniciativa.Rows.Count > 0)
                {
                    data_grid_iniciativa.Columns["id_personagem"].Visible = false;
                    data_grid_iniciativa.Columns["nome_personagem"].ReadOnly = true;
                    data_grid_iniciativa.Columns["iniciativa"].FillWeight = 40;
                    data_grid_iniciativa.Columns["nome_personagem"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    data_grid_iniciativa.Columns["iniciativa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                foreach (DataGridViewRow x in data_grid_iniciativa.Rows)
                {
                    x.MinimumHeight = 50;
                }

            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO no data grid ", "Erro:" + a);
            }
        }

        private void btn_iniciativa_Click(object sender, EventArgs e)
        {
            btn_jogadores.BackColor = Color.FromArgb(90, Color.Black);
            btn_jogadores.ForeColor = Color.Silver;
            btn_jogadores.IconColor = Color.Silver;
            btn_iniciativa.BackColor = Color.FromArgb(150, Color.Black);
            btn_iniciativa.ForeColor = Color.White;
            btn_iniciativa.IconColor = Color.White;
            btn_chat.BackColor = Color.FromArgb(90, Color.Black);
            btn_chat.ForeColor = Color.Silver;
            btn_chat.IconColor = Color.Silver;

            pnl_chat.Visible = false;
            personagens.Visible = false;
            pnl_iniciativas.Visible = true;
            data_grid_iniciativa.Visible = true;
            carregar_iniciativa();
        }

        private void btn_jogadores_Click(object sender, EventArgs e)
        {
            btn_jogadores.BackColor = Color.FromArgb(150, Color.Black);
            btn_jogadores.ForeColor = Color.White;
            btn_jogadores.IconColor = Color.White;
            btn_iniciativa.BackColor = Color.FromArgb(90, Color.Black);
            btn_iniciativa.ForeColor = Color.Silver;
            btn_iniciativa.IconColor = Color.Silver;
            btn_chat.BackColor = Color.FromArgb(90, Color.Black);
            btn_chat.ForeColor = Color.Silver;
            btn_chat.IconColor = Color.Silver;

            pnl_chat.Visible = false;
            pnl_iniciativas.Visible = false;
            personagens.Visible = true;
            Lista_de_personagens();
        }

        private void btn_chat_Click(object sender, EventArgs e)
        {
            btn_jogadores.BackColor = Color.FromArgb(90, Color.Black);
            btn_jogadores.ForeColor = Color.Silver;
            btn_jogadores.IconColor = Color.Silver;
            btn_iniciativa.BackColor = Color.FromArgb(90, Color.Black);
            btn_iniciativa.ForeColor = Color.Silver;
            btn_iniciativa.IconColor = Color.Silver;
            btn_chat.BackColor = Color.FromArgb(150, Color.Black);
            btn_chat.ForeColor = Color.White;
            btn_jogadores.IconColor = Color.White;

            pnl_iniciativas.Visible = false;
            personagens.Visible = false;
            pnl_chat.Visible = true;

            timer_chat.Start();
            pnl_mensagens.VerticalScroll.Value = pnl_mensagens.VerticalScroll.Maximum;
        }

        private void lbl_bvd_Click(object sender, EventArgs e)
        {
            iniciativa_atual = roll_dados.rolagem_dados(1, 20, Ficha.destreza);
            Conexao_BD.envia_mensagem_chat(DateTime.Now, iniciativa_atual.ToString(), Campanha.id_entidade, "Iniciativa");
            Conexao_BD.update_iniciativa(Campanha.id_personagem, iniciativa_atual);
            carregar_iniciativa();
        }

        private void lbl_jogar_iniciativa_MouseEnter(object sender, EventArgs e)
        {
            lbl_jogar_iniciativa.FlatAppearance.MouseOverBackColor = Temas.cor_escura_secundaria;
            lbl_jogar_iniciativa.ForeColor = Color.White;
            lbl_jogar_iniciativa.IconColor = Color.White;
        }

        private void iconButton4_MouseLeave(object sender, EventArgs e)
        {
            lbl_jogar_iniciativa.ForeColor = Color.FromArgb(200, 200, 200);
            lbl_jogar_iniciativa.IconColor = Color.FromArgb(200, 200, 200);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            d4.BackgroundImage = global::Dark_Age.Properties.Resources.d43;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            d4.BackgroundImage = global::Dark_Age.Properties.Resources.d42;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            d6.BackgroundImage = global::Dark_Age.Properties.Resources.d6_hover;
        }

        private void d6_MouseLeave(object sender, EventArgs e)
        {
            d6.BackgroundImage = global::Dark_Age.Properties.Resources.d63;
        }

        private void d8_MouseEnter(object sender, EventArgs e)
        {
            d8.BackgroundImage = global::Dark_Age.Properties.Resources.d8_hover;
        }

        private void d8_MouseLeave(object sender, EventArgs e)
        {
            d8.BackgroundImage = global::Dark_Age.Properties.Resources.d81;
        }

        private void d10_MouseEnter(object sender, EventArgs e)
        {
            d10.BackgroundImage = global::Dark_Age.Properties.Resources.d10_hover;
        }

        private void d10_MouseLeave(object sender, EventArgs e)
        {
            d10.BackgroundImage = global::Dark_Age.Properties.Resources.d103;
        }

        private void d12_MouseEnter(object sender, EventArgs e)
        {
            d12.BackgroundImage = global::Dark_Age.Properties.Resources.d12_hover1;
        }

        private void d12_MouseLeave(object sender, EventArgs e)
        {
            d12.BackgroundImage = global::Dark_Age.Properties.Resources.d121;
        }

        private void d20_MouseEnter(object sender, EventArgs e)
        {
            d20.BackgroundImage = global::Dark_Age.Properties.Resources.d20_hover;
        }

        private void d20_MouseLeave(object sender, EventArgs e)
        {
            d20.BackgroundImage = global::Dark_Age.Properties.Resources.d201;
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            if (pnl_insanidades_chat.Visible == true)
            {
                pnl_insanidades_chat.Visible = false;
            }
            else
            {
                pnl_insanidades_chat.Visible = true;
            }
        }

        private void btnProfissões_Click(object sender, EventArgs e)
        {
            Profissoes profissoes = new Profissoes();
            profissoes.Show();
        }

        private void timer_atualizar_informações_Tick(object sender, EventArgs e)
        {
            if (pnl_iniciativas.Visible == true)
            {
                salvar_info_pers();
                carregar_iniciativa();
            }
        }
        private void d20_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, 0, "1d20");
        }
        private void d12_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 12, 0, "1d12");
        }

        private void d10_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 10, 0, "1d10");
        }

        private void d8_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 8, 0, "1d8");
        }

        private void d6_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 6, 0, "1d6");
        }

        private void d4_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 4, 0, "1d4");
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Conexao_BD.envia_mensagem_chat(DateTime.Now, txt_mensagem.Text, Campanha.id_entidade, "");
            txt_mensagem.Clear();
        }
        public void jogar_dados(int qtd_dados, int valor_dado, int valor_atribuido, string tipo_dado)
        {
            int roll = roll_dados.rolagem_dados(qtd_dados, valor_dado, valor_atribuido);
            Conexao_BD.envia_mensagem_chat(DateTime.Now, roll.ToString(), Campanha.id_entidade, tipo_dado);
        }
        private void timer_chat_Tick(object sender, EventArgs e)
        {
            if (pnl_chat.Visible == true)
            {
                checaguem_criacao_msg();
            }
            else
            {
                timer_chat.Stop();
            }
        }

        private void res_etiqueta_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.bd_etiqueta, "Etiqueta");
        }

        private void res_intuicao_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.bd_intuicao, "Intuição");
        }

        private void res_investigacao_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.bd_investigacao, "Investigação");
        }

        private void res_sobrevivencia_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.bd_sobrevivencia, "Sobrevivência");
        }

        private void res_ocultismo_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.bd_ocultismo, "Ocultismo");
        }

        private void res_acad_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.bd_academicos, "Acadêmicos/Medicina");
        }

        private void res_percepcao_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.bd_percepcao, "Escutar/Observar");
        }

        private void res_esconder_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.bd_esconder, "Esconder");
        }

        private void res_enganacao_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.bd_enganacao, "Roubo");
        }

        private void res_seducao_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.bd_seduzir, "Sedução/Enganação");
        }

        private void res_intimidacao_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.bd_intimidacao, "Intimidação");
        }

        private void res_labia_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.bd_labia, "Lábia");
        }

        private void res_conjurar_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.bd_lancarmagia, "Conjurar Magia");
        }

        private void res_atirar_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.bd_arematirar, "Atirar");
        }

        private void res_contrataque_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.bd_contra_atq, "Contra Ataque");
        }

        private void res_defesa_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.bd_defesa, "Defesa");
        }

        private void res_esquiva_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.bd_esquiva, "Esquiva");
        }

        private void res_ataque_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.bd_ataque, "Ataque");
        }

        private void res_magia_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.magia, "Magia");
        }

        private void res_raciocinio_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.raciocinio, "Raciocinio");
        }

        private void res_carisma_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.carisma, "Carisma");
        }

        private void res_vigor_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.vigor, "Vigor");
        }

        private void res_destreza_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.destreza, "Destreza");
        }

        private void res_forca_Click(object sender, EventArgs e)
        {
            jogar_dados(1, 20, Ficha.forca, "Força");
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            btn_fechar mapa = new btn_fechar();
            mapa.Show();
        }

        private void res_ataque_MouseEnter(object sender, EventArgs e)
        {
            var label = (Label)sender;

            label.BackColor = Color.FromArgb(20, Color.White);
        }

        private void res_ataque_MouseLeave(object sender, EventArgs e)
        {
            var label = (Label)sender;

            label.BackColor = Color.Transparent;
        }


        private void txt_mensagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Conexao_BD.envia_mensagem_chat(DateTime.Now, txt_mensagem.Text, Campanha.id_entidade, "");
                txt_mensagem.Clear();
            }
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            if (morte1.IconColor == Color.Salmon)
            {
                morte1.IconColor = Color.Silver;
            }
            else
            {
                morte1.IconColor = Color.Salmon;
            }
            morte2.IconColor = Color.Silver;
            morte3.IconColor = Color.Silver;
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            morte1.IconColor = Color.Salmon;
            morte2.IconColor = Color.Salmon;
            morte3.IconColor = Color.Silver;
        }

        private void morte3_Click(object sender, EventArgs e)
        {
            morte1.IconColor = Color.Salmon;
            morte2.IconColor = Color.Salmon;
            morte3.IconColor = Color.Salmon;
        }

        private void sucesso1_Click(object sender, EventArgs e)
        {
            if (sucesso1.IconColor == Color.LimeGreen)
            {
                sucesso1.IconColor = Color.Silver;
            }
            else
            {
                sucesso1.IconColor = Color.LimeGreen;
            }
            sucesso2.IconColor = Color.Silver;
            sucesso3.IconColor = Color.Silver;
        }

        private void sucesso2_Click(object sender, EventArgs e)
        {
            sucesso1.IconColor = Color.LimeGreen;
            sucesso2.IconColor = Color.LimeGreen;
            sucesso3.IconColor = Color.Silver;
        }

        private void sucesso3_Click(object sender, EventArgs e)
        {
            sucesso1.IconColor = Color.LimeGreen;
            sucesso2.IconColor = Color.LimeGreen;
            sucesso3.IconColor = Color.LimeGreen;
        }

        public void checaguem_criacao_msg()
        {
            DataTable ndv = Conexao_BD.select_mensagens_chat(0, Campanha.id_campanha, 0);
            count_novo = ndv.Rows.Count;
            if (count_novo > count_antigo)
            {
                pnl_mensagens.VerticalScroll.Value = pnl_mensagens.VerticalScroll.Maximum;
                for (int i = count_antigo; i < count_novo; i++)
                {
                    DataRow registros = ndv.Rows[i];
                    carregar_msg_pnl(registros);
                }
                if (distancia > pnl_mensagens.Height)
                {
                    distancia = pnl_mensagens.Height;
                }
                pnl_mensagens.VerticalScroll.Value = pnl_mensagens.VerticalScroll.Maximum;
                count_antigo = count_novo;
            }
        }

        public void carregar_msg_pnl(DataRow ndv)
        {
            mensagem_chat m_chat = new mensagem_chat();
            m_chat.Nome_personagem = ndv["nome_pers"].ToString();
            m_chat.Mensagem = ndv["mensagem_c"].ToString();
            m_chat.Hora = Convert.ToDateTime(ndv["data_hora_c"]).ToString("HH:mm:ss");
            m_chat.Tipo_dado = ndv["dado_tipo"].ToString();
            m_chat.preencher_info();            //m_chat.preencher_info(mensagem, data_time.ToString("HH:mm:ss"), nome_p);
            m_chat.Dock = DockStyle.None;
            m_chat.Top = distancia;
            pnl_mensagens.Controls.Add(m_chat);
            distancia += m_chat.Height;
        }

        private void iconButton_Bonus_Click(object sender, EventArgs e)
        {
            Tela_bonus tela_Bonus = new();
            tela_Bonus.Show();
            tela_Bonus.TelaBonusFechada += Tela_bonus_TelaBonusFechada;
        }
        
        private void Tela_bonus_TelaBonusFechada(object sender, EventArgs e)
        {
            preencher_info_tela();
        }
    }
}