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
    public partial class Ficha : Form
    {
        public static int forca = 0;
        public static int destreza = 0;
        public static int vigor = 0;
        public static int carisma = 0;
        public static int raciocinio = 0;
        public static int magia = 0;
        public static int pontos = 0;
        public static int pontos_hab = 0;
        public static int pontos_totais = 0;
        public static int bd_ataque, bd_esquiva, bd_defesa, bd_contra_atq, bd_arematirar, bd_lancarmagia, bd_labia, bd_intimidacao, bd_esconder, bd_seduzir, bd_enganacao,
            bd_percepcao, bd_academicos, bd_ocultismo, bd_sobrevivencia, bd_investigacao, bd_intuicao, bd_etiqueta;
        public static int bd_sanidade = 3;
        public static string classe_escolhida = "";
        public static int id_classe = 0;
        public static int idpersonagem = 0;
        public static int pontos_max = 10;
        public static int nivel = 1;
        public static Boolean pers_criado = false;
        public static Image imagem_pers;
        public static int tipo_entidade;  //     | 1 - Personagem | 2 - Pet | 3 - NPC | 4- monstro |
        public DataTable tb_nivel;
        public static byte[] imagembyte_personagem;
        public static int id_entidade = 0;
        public string tamanho = "";
        public int total_ponto_talento;

        public Ficha()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(14, 40, 52);
            button1.ForeColor = Color.FromArgb(150, Color.White);
            button2.ForeColor = Color.FromArgb(150, Color.White);
            button3.ForeColor = Color.FromArgb(150, Color.White);
            button4.ForeColor = Color.FromArgb(150, Color.White);
            button5.ForeColor = Color.FromArgb(150, Color.White);
        }

        public void muda_ficha()   //     | 1 - Personagem | 2 - Pet | 3 - NPC | 4- monstro |
        {
            if (tipo_entidade == 2)
            {
                pnl_classes.Visible = false;
                pnl_talentos.Visible = false;
                label1.Text = "Criação de Pet";
                btn_cria_personagem.Text = "Finalizar Criação do Pet";
                pnl_status.Visible = true;
            } else if (tipo_entidade == 3)
            {
                pnl_classes.Visible = false;
                pnl_talentos.Visible = false;
                label1.Text = "Criação de NPC";
                btn_cria_personagem.Text = "Finalizar Criação do NPC";
            } else if (tipo_entidade == 4)
            {
                pnl_classes.Visible = false;
                pnl_talentos.Visible = true;
                label1.Text = "Criação de Monstro";
                btn_cria_personagem.Text = "Finalizar Criação do Monstro";
            } else
            {
                pnl_classes.Visible = true;
                pnl_talentos.Visible = true;
            }
        }

        private void Ficha_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0
            timer1.Interval = 10;  // increase the opacity every 10ms
            timer1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            timer1.Start();
            preencher_Info_tela();
        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                timer1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
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
            if (raciocinio < 5 && pontos > 0)
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
        private void button4_Click(object sender, EventArgs e)
        {
            classe_escolhida = "Alquimista";
            classe.Text = classe_escolhida;
            id_classe = 1;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            classe_escolhida = "Mestre da Forja";
            classe.Text = classe_escolhida;
            id_classe = 2;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            classe_escolhida = "Caçador de Monstros";
            classe.Text = classe_escolhida;
            id_classe = 3;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            classe_escolhida = "Orador";
            classe.Text = classe_escolhida;
            id_classe = 4;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            classe_escolhida = "Templário";
            classe.Text = classe_escolhida;
            id_classe = 5;
        }

        private void tipo_criacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipo_criacao.SelectedIndex == 0)
            {
                tipo_entidade = 1;
            } else if (tipo_criacao.SelectedIndex == 1)
            {
                tipo_entidade = 2;
            } else if (tipo_criacao.SelectedIndex == 2)
            {
                tipo_entidade = 3;
            } else if (tipo_criacao.SelectedIndex == 3)
            {
                tipo_entidade = 4;
            }
            muda_ficha();
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
            string retorno = verificacao_informacao();	
            if (retorno is null)
            {
				cria_ou_update_pers();
				Form1 frm = new Form1();
				frm.Show();
				this.Close();
            } else
            {
                MessageBox.Show(retorno);
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
            if ((pontos_totais - pontos_hab) > 0)
            {
                bd_ataque = (int)ataque.Value;
            }
        }
        private void esquiva_ValueChanged(object sender, EventArgs e)
        {
            if ((pontos_totais - pontos_hab) > 0)
            {
                bd_esquiva = (int)esquiva.Value;
            }
        }
        private void defesa_ValueChanged(object sender, EventArgs e)
        {
            if ((pontos_totais - pontos_hab) > 0)
            {
                bd_defesa = (int)defesa.Value;
            }
        }
        private void contrataque_ValueChanged(object sender, EventArgs e)
        {
            if ((pontos_totais - pontos_hab) > 0)
            {
                bd_contra_atq = (int)contrataque.Value;
            }
        }
        private void arematirar_ValueChanged(object sender, EventArgs e)
        {
            if ((pontos_totais - pontos_hab) > 0)
            {
                bd_arematirar = (int)arematirar.Value;
            }
        }
        private void lancarmagia_ValueChanged(object sender, EventArgs e)
        {
            if ((pontos_totais - pontos_hab) > 0)
            {
                bd_lancarmagia = (int)lancarmagia.Value;
            }
        }

        private void labia_ValueChanged(object sender, EventArgs e)
        {
            if ((pontos_totais - pontos_hab) > 0)
            {
                bd_labia = (int)labia.Value;
            }
        }

        private void intimidacao_ValueChanged(object sender, EventArgs e)
        {
            if ((pontos_totais - pontos_hab) > 0)
            {
                bd_intimidacao = (int)intimidacao.Value;
            }
        }

        private void seduzir_ValueChanged(object sender, EventArgs e)
        {
            if ((pontos_totais - pontos_hab) > 0)
            {
                bd_seduzir = (int)seduzir.Value;
            }
        }

        private void enganacao_ValueChanged(object sender, EventArgs e)
        {
            if ((pontos_totais - pontos_hab) > 0)
            {
                bd_enganacao = (int)enganacao.Value;
            }
        }
        private void esconder_ValueChanged(object sender, EventArgs e)
        {
            if ((pontos_totais - pontos_hab) > 0)
            {
                bd_esconder = (int)esconder.Value;
            }
        }
        private void percepcao_ValueChanged(object sender, EventArgs e)
        {
            if ((pontos_totais - pontos_hab) > 0)
            {
                bd_percepcao = (int)percepcao.Value;
            }
        }
        private void academicos_ValueChanged(object sender, EventArgs e)
        {
            if (((pontos_totais - pontos_hab) - pontos_hab) > 0)
            {
                bd_academicos = (int)academicos.Value;
            }
        }
        private void ocultismo_ValueChanged(object sender, EventArgs e)
        {
            if (((pontos_totais - pontos_hab) - pontos_hab) > 0)
            {
                bd_ocultismo = (int)ocultismo.Value;
            }
        }
        private void sobrevivencia_ValueChanged(object sender, EventArgs e)
        {
            if ((pontos_totais - pontos_hab) > 0)
            {
                bd_sobrevivencia = (int)sobrevivencia.Value;
            }
        }

        private void investigacao_ValueChanged(object sender, EventArgs e)
        {
            if ((pontos_totais - pontos_hab) > 0)
            {
				bd_investigacao = (int)investigacao.Value;
			}
        }

        private void intuicao_ValueChanged(object sender, EventArgs e)
        {
            if ((pontos_totais - pontos_hab) > 0)
            {
                bd_intuicao = (int)intuicao.Value;
            }
        }
        private void etiqueta_ValueChanged(object sender, EventArgs e)
        {
            if ((pontos_totais - pontos_hab) > 0)
            {
                bd_etiqueta = (int)etiqueta.Value;
            }
        }
        private void sanidade_ValueChanged(object sender, EventArgs e)
        {
            if (total_ponto_talento > 0)
            {
				bd_sanidade = (int)sanidade.Value;
			}
        }

        private void nome_personagem_TextChanged(object sender, EventArgs e)
        {
            Campanha.nome_personagem = nome_personagem.Text;
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

                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

                Image imagem_personagem = Image.FromFile(caminhoCompleto);

                pictureBox1.Image = imagem_personagem;
            }


        }
        public void carregar_nivel()
        {
            comboBox1.DataSource = Conexao_BD.select_nivel(0);
            comboBox1.ValueMember = "nivel";
            comboBox1.DisplayMember = "nivel";
            comboBox1.SelectedValue = nivel;
            definir_pontos_nivel();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            definir_pontos_nivel();
            ataque_Click(comboBox1, e);
        }

        public void definir_pontos_nivel()
        {
            nivel = (int)comboBox1.SelectedValue;
            tb_nivel = Conexao_BD.select_nivel(nivel);
            DataRow[] oDataRow = tb_nivel.Select();
            foreach (DataRow row in oDataRow)
            {
                pontos_max = (int)row[1];
                pontos_totais = (int)row[2];
            }
            label_pontos();
        }

        public void label_pontos()
        {
            pontos = pontos_max - forca - destreza - vigor - carisma - raciocinio - magia;
            lbl_pontos.Text = "Pontos: " + pontos;

            pontos_hab = Convert.ToInt32(ataque.Value) + Convert.ToInt32(esquiva.Value) + Convert.ToInt32(defesa.Value) + Convert.ToInt32(contrataque.Value)
                + Convert.ToInt32(arematirar.Value) + Convert.ToInt32(lancarmagia.Value) + Convert.ToInt32(labia.Value) + Convert.ToInt32(intimidacao.Value) + Convert.ToInt32(seduzir.Value)
                + Convert.ToInt32(enganacao.Value) + Convert.ToInt32(esconder.Value) + Convert.ToInt32(percepcao.Value) + Convert.ToInt32(academicos.Value) + Convert.ToInt32(ocultismo.Value)
                + Convert.ToInt32(sobrevivencia.Value) + Convert.ToInt32(investigacao.Value) + Convert.ToInt32(intuicao.Value) + Convert.ToInt32(etiqueta.Value) + Convert.ToInt32(sanidade.Value) - 3;
            total_ponto_talento = pontos_totais - pontos_hab;
			label40.Text = "Pontos de habilidade restantes: " + total_ponto_talento.ToString();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ataque_Click(object sender, EventArgs e)
        {            
            label_pontos();        
        }

        public void preencher_Info_tela()
        {
            if (pers_criado == true)
            {
                label1.Text = "Edição de Ficha";
                btn_cria_personagem.Text = "Finalizar Edição de Personagem";
                info_entidade.preencher_atributos(Campanha.id_personagem, "'N'");
                info_entidade.preencher_talento(Campanha.id_personagem, "'N'");
                info_entidade.preencher_pers(1, 0, Campanha.id_personagem, 0);
                info_entidade.imagem(Campanha.id_personagem);
				imagem_pers = byte_image.byteArrayToImage(imagembyte_personagem);
                pictureBox1.Image = imagem_pers;
            }

            lbl_forca.Text = forca.ToString();
            lbl_destreza.Text = destreza.ToString();
            lbl_vigor.Text = vigor.ToString();
            lbl_carisma.Text = carisma.ToString();
            lbl_raciocinio.Text = raciocinio.ToString();
            lbl_magia.Text = magia.ToString();

            classe.Text = classe_escolhida;
            nome_personagem.Text = Campanha.nome_personagem;
            comboBox1.SelectedValue = nivel;

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
            sanidade.Minimum = 3;

			carregar_nivel();
            muda_ficha();
        }

        public void cria_ou_update_pers()
        {
            int[] atributos = new int[] {forca, destreza, vigor, carisma, raciocinio, magia};
            int[] talentos = new int[] {bd_ataque, bd_esquiva, bd_defesa, bd_contra_atq, bd_arematirar, bd_lancarmagia, bd_labia, bd_intimidacao, bd_seduzir, bd_enganacao, bd_esconder
                        , bd_percepcao, bd_academicos, bd_ocultismo, bd_sobrevivencia, bd_investigacao, bd_intuicao, bd_etiqueta, bd_sanidade};
            imagembyte_personagem = byte_image.imageToByteArray(pictureBox1.Image);
            info_entidade.atualiza_ids(Campanha.id_personagem, Campanha.id_entidade, tipo_entidade, Campanha.nome_personagem, id_classe, nivel, imagembyte_personagem, atributos, talentos, Campanha.id_campanha, Campanha.id_jogador, tamanho, 0, 0);
        }

        public string verificacao_informacao()
        {
            if ((id_classe <= 0))
            {
                return "Selecione uma classe antes de confirmar o personagem!";
            }else if (tipo_entidade == 0)
            {
                return "Selecione qual é o tipo entidade!";
            }else if (Campanha.nome_personagem == "")
            {
                return "Digite o nome do personagem antes de confirmar!";
            }else if (total_ponto_talento < 0)
            {
                return "A quantidade de Pontos de talentos esta negativo, verifique novamente e distribua os pontos corretamente até o máximo de 0 pontos restantes!";
			}
            return null;
        }
    }
}
