using Dark_Age.Componente;
using Dark_Age.Controllers;
using Dark_Age.Enteties;
using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Dark_Age
{
    public partial class Pagina_mestre : Form
    {
        public static string historia;
        public static string anotacoes;
        public static string regras;
        Boolean minmax = false;
        public static string sanidades;
        public static int id_entidade;
        public static int id_personagem;
        public static int tipo;
		public int count_novo, count_antigo, distancia;

		public Pagina_mestre()
        {
            InitializeComponent();


            Grid_lista_iniciativas.DataSource = Conexao_BD.select_iniciativa(Campanha.id_campanha);
            this.BackColor = Temas.cor_principal;
            txt_regras.BackColor = Temas.cor_principal;
            txt_sanidade.BackColor = Temas.cor_principal;
            txt_historia.BackColor = Temas.cor_principal;
            btn_iniciativa.BackColor = Temas.cor_principal_secundaria;
            txt_outros.BackColor = Temas.cor_principal;
            pnl_entidades.BackColor = Temas.cor_principal;
            btn_outros.BackColor = Temas.cor_principal;
            btn_regras.BackColor = Temas.cor_principal;
            btn_sanidades.BackColor = Temas.cor_principal;
            Temas.mudar_cor_data_grid(Grid_lista_iniciativas);
            style.muda_cor_fundo_botao(btn_monstros);
        }

        public void carregar_data_grid()
        {
            try
            {

                Grid_lista_iniciativas.DataSource = Conexao_BD.select_iniciativa(Campanha.id_campanha);
                if (Grid_lista_iniciativas.Rows.Count > 0)
                {
                    Grid_lista_iniciativas.Columns["id_personagem"].Visible = false;
                    Grid_lista_iniciativas.Columns["nome_personagem"].ReadOnly = true;
                    Grid_lista_iniciativas.Columns["iniciativa"].FillWeight = 40;
                    Grid_lista_iniciativas.Columns["iniciativa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                foreach (DataGridViewRow x in Grid_lista_iniciativas.Rows)
                {
                    x.MinimumHeight = 40;
                }

            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO no data grid ", "Erro:" + a);
            }

        }

        public void Lista_de_personagens()
        {
            string nome_c;
            string nome_p;
            string nome_u;
            int id_e;
            int vida_max_sel = 0;
            int vida_atual_sel = 0;
            Image image_p;
            int distancia = 0;
            try
            {
                DataTable ndv = Conexao_BD.select_personagem_campanha(0, Campanha.id_campanha, 1);

                pnl_entidades.Controls.Clear();

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

                    pnl_entidades.Controls.Add(pnlDefault);
                    pnlDefault.Controls.Add(personagens);

                    distancia++;
                }

            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO no carregar as informações", "Erro:" + a);
            }
        }

        private void Pagina_mestre_Load(object sender, EventArgs e)
        {
            bemvindo.Text = "Bem-Vindo(a) a sua tela de mestre, " + Login.nome_jogador;
            lbl_titulo.Text = Campanha.nome_campanha;
            Conexao_BD.Select_historia_e_anotacoes(ref historia, ref anotacoes);
            txt_historia.Text = historia;
            txt_outros.Text = anotacoes;

            timer1.Interval = 10;  //we'll increase the opacity every 10ms
            timer1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            timer1.Start();

            carregar_monstros();
            carregar_data_grid();
            Conexao_BD.Select_Regras(ref regras, ref sanidades);
            txt_regras.Text = regras;
            txt_sanidade.Text = sanidades;
            checaguem_criacao_msg();
        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                timer1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        private void btn_anotacoes_Click(object sender, EventArgs e)
        {
            txt_historia.Visible = true;
            txt_outros.Visible = false;
            txt_regras.Visible = false;
            txt_sanidade.Visible = false;
            txt_historia.Focus();

            lbl_titulo.Text = Campanha.nome_campanha;

            btn_regras.BackColor = Color.Transparent;
            btn_sanidades.BackColor = Color.Transparent;
            btn_outros.BackColor = Color.Transparent;
            btn_historia.BackColor = Color.FromArgb(40, 40, 57);
        }


        private void btn_regras_Click(object sender, EventArgs e)
        {
            txt_historia.Visible = false;
            txt_outros.Visible = false;
            txt_regras.Visible = true;
            txt_sanidade.Visible = false;
            txt_regras.Focus();

            lbl_titulo.Text = "Regras do Sistema";

            btn_regras.BackColor = Color.FromArgb(40, 40, 57);
            btn_sanidades.BackColor = Color.Transparent;
            btn_outros.BackColor = Color.Transparent;
            btn_historia.BackColor = Color.Transparent;
        }

        private void btn_sanidades_Click(object sender, EventArgs e)
        {
            txt_historia.Visible = false;
            txt_outros.Visible = false;
            txt_regras.Visible = false;
            txt_sanidade.Visible = true;
            txt_sanidade.Focus();

            lbl_titulo.Text = "Lista de Insanidades e Manias/Fobias";

            btn_regras.BackColor = Color.Transparent;
            btn_sanidades.BackColor = Color.FromArgb(40, 40, 57);
            btn_outros.BackColor = Color.Transparent;
            btn_historia.BackColor = Color.Transparent;
        }

        private void btn_outros_Click(object sender, EventArgs e)
        {
            txt_historia.Visible = false;
            txt_outros.Visible = true;
            txt_regras.Visible = false;
            txt_sanidade.Visible = false;
            txt_outros.Focus();

            lbl_titulo.Text = "Anotações";

            btn_regras.BackColor = Color.Transparent;
            btn_sanidades.BackColor = Color.Transparent;
            btn_outros.BackColor = Color.FromArgb(40, 40, 57);
            btn_historia.BackColor = Color.Transparent;
        }

        private void btn_historia_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 67);
        }


        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            Campanha.classe_personagem = 1;
            Ficha.nivel = 5;
            Habilidades_passivas lista = new Habilidades_passivas();
            lista.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ///pnl_entidades.Controls.Clear();
            style.muda_cor_fundo_botao(btn_npcs);
            btn_jogadores.BackColor = Color.Transparent;
            btn_monstros.BackColor = Color.Transparent;

            btn_npcs.Focus();
            tipo = 2;
            carregar_entidade_NPC(tipo);
        }

        private void HoverEnter_MouseEnter(object sender, EventArgs e)
        {
            style.houver_botao(sender);
        }

        private void iconButton5_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, Color.Salmon);
        }

        private void btn_monstros_Click(object sender, EventArgs e)
        {
            carregar_monstros();
        }
        
        private void carregar_monstros()
        {
            pnl_entidades.Controls.Clear();

            ///pnl_entidades.Controls.Clear();
            style.muda_cor_fundo_botao(btn_monstros);
            btn_jogadores.BackColor = Color.Transparent;
            btn_npcs.BackColor = Color.Transparent;

            btn_monstros.Focus();
            tipo = 3;
            carregar_entidade_NPC(tipo);
        }

        private void btn_jogadores_Click(object sender, EventArgs e)
        {
            ///pnl_entidades.Controls.Clear();
            style.muda_cor_fundo_botao(btn_jogadores);
            btn_monstros.BackColor = Color.Transparent;
            style.muda_cor_fundo_botao(btn_jogadores);
            btn_npcs.BackColor = Color.Transparent;

            btn_jogadores.Focus();
            Lista_de_personagens();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            salvar_alteracoes();
            Application.Exit();
        }
        public void salvar_alteracoes()
        {
            NpgsqlConnection conn = new NpgsqlConnection(Conexao_BD.Caminho_DB());
            conn.Open();
            NpgsqlCommand comt = new NpgsqlCommand();
            comt.Connection = conn;
            comt.CommandType = CommandType.Text;
            comt.CommandText = "update \"Dark_Age_Connection\".\"Campanha\" set historia_campanha = @historia, anotacoes_campanha = @anotacoes where id_campanha = @id_campanha";
            comt.Parameters.AddWithValue("@historia", historia);
            comt.Parameters.AddWithValue("@anotacoes", anotacoes);
            comt.Parameters.AddWithValue("@id_campanha", Campanha.id_campanha);
            comt.ExecuteNonQuery();

            comt.CommandText = "update \"Dark_Age_Connection\".\"Regras\" set regras_gerais = @regras, sanidades = @sanidades";
            comt.Parameters.AddWithValue("@regras", regras);
            comt.Parameters.AddWithValue("@sanidades", sanidades);
            comt.ExecuteNonQuery();

            comt.Dispose();
            conn.Close();
        }

        private void txt_historia_TextChanged(object sender, EventArgs e)
        {
            historia = txt_historia.Text;
        }

        private void txt_sanidade_TextChanged(object sender, EventArgs e)
        {
            sanidades = txt_sanidade.Text;
        }

        private void txt_outros_TextChanged(object sender, EventArgs e)
        {
            anotacoes = txt_outros.Text;
        }

        private void txt_regras_TextChanged(object sender, EventArgs e)
        {
            regras = txt_regras.Text;
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Pagina_mestre_MouseDown(object sender, MouseEventArgs e)
        {
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Square;
            minmax = false;
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, Login.WM_NCLBUTTONDOWN, Login.HT_CAPTION, 0);
            }
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

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            Lista_itens lista = new Lista_itens();
            lista.Show();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            salvar_alteracoes();
            MessageBox.Show("Alterações salvas!");
        }

        private void Grid_lista_iniciativas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                DataGridViewRow row = Grid_lista_iniciativas.Rows[e.RowIndex];
                id_entidade = (int)row.Cells[0].Value;
            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO click na grid ", "Erro:" + a);
            }
        }

        private void Grid_lista_iniciativas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = Grid_lista_iniciativas.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if ((int)cell.Value == 0)
            {
                cell.Value = 0;
            }
            Conexao_BD.update_iniciativa(id_entidade, (int)cell.Value);
            carregar_data_grid();
        }

        private void btn_desequipar_Click(object sender, EventArgs e)
        {
            Conexao_BD.update_iniciativa(id_entidade, -20);
            carregar_data_grid();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            btn_iniciativa.BackColor = Color.FromArgb(40, 40, 57);
            btn_chat.BackColor = Color.Transparent;
            btn_chat.ForeColor = Color.Silver;
            btn_iniciativa.ForeColor = Color.White;
            panel13.Visible = true;
            pnl_chat.Visible = false;
            btn_iniciativa.Focus();
        }

        private void btn_chat_Click(object sender, EventArgs e)
        {
            btn_chat.BackColor = Color.FromArgb(40, 40, 57);
            btn_iniciativa.BackColor = Color.Transparent;
            btn_chat.ForeColor = Color.White;
            btn_iniciativa.ForeColor = Color.Silver;
            pnl_chat.Visible = true;
            panel13.Visible = false;
            btn_chat.Focus();
            timer_chat.Start();
			pnl_mensagens.VerticalScroll.Value = pnl_mensagens.VerticalScroll.Maximum;
		}

        private void button2_Click(object sender, EventArgs e)
        {

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

        public void carregar_entidade_NPC(int tipo)
        {
            int id_entidade;
            string nome_entidade;
            int distancia = 0;
            Image image_p;
            try
            {
                DataTable nde = Conexao_BD.select_personagem_campanha(0, Campanha.id_campanha, tipo);


                foreach (DataRow de in nde.Rows)
                {
                    id_entidade = (int)de["id_entidade"];
                    id_personagem = (int)de["id_personagem"];
                    nome_entidade = de["nome_personagem"].ToString();
                    byte[] imagem_byte = ((byte[])de["imagem"]);
                    image_p = byte_image.byteArrayToImage(imagem_byte);

                    string[] valor = info_entidade.select_personagem(tipo, id_entidade, 0, Campanha.id_campanha, 0);


                    Painel_NPC entidades = new Painel_NPC(id_entidade);
                    entidades.preencher_campos(image_p);
                    entidades.Dock = DockStyle.None;
                    entidades.Left = 10;

                    Panel pnl_entidade = new Panel();
                    pnl_entidade.BackColor = Color.Transparent;
                    pnl_entidade.Dock = DockStyle.None;
                    pnl_entidade.Top = (distancia + 10);
                    pnl_entidade.AutoSize = true;
                    // pnlDefault.BorderStyle = BorderStyle.FixedSingle;
                    pnl_entidade.Controls.Add(entidades);
                    pnl_entidades.Controls.Add(pnl_entidade);

                    distancia += 148;
                }

            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO no carregar as informações"+a, "Erro:" + a);
            }
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

            NPCs.tipo_entidade = 3;
            NPCs pets = new NPCs();
            pets.ShowDialog();
            carregar_monstros();
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
		public void jogar_dados(int qtd_dados, int valor_dado, int valor_atribuido, string tipo_dado)
		{
			int roll = roll_dados.rolagem_dados(qtd_dados, valor_dado, valor_atribuido);
			Conexao_BD.envia_mensagem_chat(DateTime.Now, roll.ToString(), Campanha.id_entidade, tipo_dado);
		}

		private void timer_chat_Tick(object sender, EventArgs e)
        {
            checaguem_criacao_msg();
        }

        private void btn_enviar_mensagem_Click(object sender, EventArgs e)
        {
			Conexao_BD.envia_mensagem_chat(DateTime.Now, txt_mensagem.Text, Campanha.id_entidade, "");
			txt_mensagem.Clear();
		}

        private void iconButton10_Click(object sender, EventArgs e)
        {
            btn_fechar mapa = new btn_fechar();
            mapa.Show();
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
	}
}