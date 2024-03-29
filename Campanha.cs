﻿using Dark_Age.Enteties;
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
using System.Drawing.Drawing2D;

namespace Dark_Age
{
    public partial class Campanha : Form
    {
        public static int id_campanha = 0;
        public static int id_personagem = 0;
        public static string nome_campanha;
        public static int classe_personagem;
        public static int nivel_personagem;
        public static int id_jogador = Login.jogador;
        public static int id_mestre_campanha;
        public static string nome_personagem;
        public static int id_entidade = 0;
        public static Boolean ativa = true;
        public static byte[] imagembyte_campanha;
        public static byte[] imagembyte_campanha_nova;
        public Campanha()
        {
            InitializeComponent();

            this.BackColor = Temas.cor_principal;

            txt_nome_campanha.BackColor = Temas.cor_principal_secundaria;
            pnl_nome_campanha.BackColor = Temas.cor_principal_secundaria;

            Temas.mudar_cor_data_grid(data_grid_campanha);
            Temas.mudar_cor_data_grid(data_grid_pers_camp);

        }


        private void Campanha_Load(object sender, EventArgs e)
        {
            lbl_bvd.Text = "Seja Bem-Vindo(a) a tela de campanhas, " + Login.nome_jogador+".";
            carrega_data_grid_campanha();
        }



        public void carrega_data_grid_campanha()
        {
            try
            {
                data_grid_campanha.DataSource = Conexao_BD.select_campanha(ativa);
                data_grid_campanha.Columns["nome_campanha"].HeaderText = "Campanhas";
                data_grid_campanha.Columns["id_campanha"].Visible = false;
                data_grid_campanha.Columns["fk_id_jogador_mestre"].Visible = false;
                data_grid_campanha.Columns["imagem_campanha"].Visible = false;
                if (data_grid_campanha.Rows.Count > 0)
                {
                    data_grid_campanha.Rows[0].Selected = true;
                    DataGridViewRow cell1 = data_grid_campanha.Rows[0];
                    selecao_campanha(cell1);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO no data grid campanha ", "Erro:" + a);
            }
            foreach (DataGridViewRow x in data_grid_campanha.Rows)
            {
                x.MinimumHeight = 40;
            }
        }

        public void carrega_data_grid_pers_camp(int id_jogador, int id_campanha, int id_mestre)
        {
            try
            {
                if (id_mestre != id_jogador)
                {
                    id_mestre_campanha = 0;
                    data_grid_pers_camp.DataSource = Conexao_BD.select_personagem_campanha(id_jogador, id_campanha, 1);                    
                }
                else
                {
                    id_mestre_campanha = id_jogador;
                    data_grid_pers_camp.DataSource = Conexao_BD.select_personagem_campanha(0, id_campanha, 1);
                }
                if (data_grid_pers_camp.DataSource != null)
                {
                    data_grid_pers_camp.Columns["nome_personagem"].HeaderText = "Nome";
                    data_grid_pers_camp.Columns["nome_personagem"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    data_grid_pers_camp.Columns["nome_classe"].HeaderText = "Classe";
                    data_grid_pers_camp.Columns["nivel"].HeaderText = "Nível";
                    data_grid_pers_camp.Columns["nivel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    data_grid_pers_camp.Columns["id_personagem"].Visible = false;
                    data_grid_pers_camp.Columns["fk_id_classe"].Visible = false;
                    data_grid_pers_camp.Columns["id_entidade"].Visible = false;
                    data_grid_pers_camp.Columns["imagem"].Visible = false;
                    data_grid_pers_camp.Columns["nome_jogador"].Visible = false;
                }
                if (data_grid_pers_camp.Rows.Count > 0)
                {
                    if (id_jogador == id_mestre_campanha)
                    {
                        btn_entrar_mestre.Visible = true;
                        btn_entrar.Visible = false;
                        btn_eliminar.Visible = false;
                        btn_criar_novo.Visible = false;
                        btn_eliminar_campanha.Visible = true;
                    } else
                    {
                        btn_entrar_mestre.Visible = false;
                        btn_entrar.Visible = true;
                        btn_eliminar.Visible = true;
                        btn_criar_novo.Visible = true;
                        btn_eliminar_campanha.Visible = false;
                        data_grid_pers_camp.Rows[0].Selected = true;
                        DataGridViewRow cell1 = data_grid_pers_camp.Rows[0];
                        selecao_personagem(cell1);
                    }                   
                } else
                {
                    if (id_jogador == id_mestre_campanha)
                    {
                        btn_entrar_mestre.Visible = true;
                        btn_entrar.Visible = false;
                        btn_eliminar.Visible = false;
                        btn_criar_novo.Visible = false;
                        btn_eliminar_campanha.Visible = true;
                    } else
                    {
                        btn_entrar_mestre.Visible = false;
                        btn_entrar.Visible = false;
                        btn_eliminar.Visible = false;
                        btn_criar_novo.Visible = true;
                        btn_eliminar_campanha.Visible = false;
                    }                                   
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO no data grid campanha ", "Erro:" + a);
            }
            foreach (DataGridViewRow x in data_grid_pers_camp.Rows)
            {
                x.MinimumHeight = 40;
            }
        }

        private void data_grid_campanha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                DataGridViewRow row = data_grid_campanha.Rows[e.RowIndex];
                selecao_campanha(row);
            } catch (Exception a)
            {
                MessageBox.Show("ERRO click na grid de campanha" + a);
            }
        }

        private void data_grid_pers_camp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                DataGridViewRow row = data_grid_pers_camp.Rows[e.RowIndex];
                selecao_personagem(row);
            } catch (Exception a)
            {
                MessageBox.Show("ERRO click na grid de personagem " + a);
            }
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (id_personagem != 0)
            {
                Form1 pagina_inicial = new Form1();
                pagina_inicial.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecione o personagem para abrir a ficha dele, ou crie um novo personagem.");
            }
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (id_personagem != 0)
            {
                if (MessageBox.Show("Tem certeza que deseja deletar a ficha do personagem, não tem volta depois?", "Excluir personagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Conexao_BD.deletar_personagem(id_personagem, id_campanha);
                    carrega_data_grid_pers_camp(id_jogador, id_campanha, 0);
                }
            }
            else
            {
                MessageBox.Show("Selecione o personagem que deseja deletar. Não recomendo deletar;");
            }
        }
        public void selecao_personagem(DataGridViewRow e)
        {
            try
            {
                DataGridViewRow row = e;
                if (row.Index == -1)
                {
                    return;
                }
                id_personagem = (int)row.Cells[0].Value;
                nome_personagem = row.Cells[1].Value.ToString();                
                nivel_personagem = (int)row.Cells[3].Value;
                classe_personagem = (int)row.Cells[4].Value;
                id_entidade = (int)row.Cells[5].Value;
                byte[] imagem_byte = (byte[])row.Cells[6].Value;
            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO click na grid de personagem " + a);
            }
        }

        public void selecao_campanha(DataGridViewRow e)
        {
            try
            {
                DataGridViewRow row = e;
                if (row.Index == -1)
                {
                    return;
                }
                id_campanha = (int)row.Cells[0].Value;
                nome_campanha = row.Cells[1].Value.ToString();
                int id_mestre = (int)row.Cells[2].Value;
                byte[] imagem_byte = (byte[])row.Cells[3].Value;
                pictureBox1.Image = byte_image.byteArrayToImage(imagem_byte);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                esconder_btn(id_mestre);

                carrega_data_grid_pers_camp(id_jogador, id_campanha, id_mestre);
            } catch (Exception a)
            {
                MessageBox.Show("ERRO click na grid da campanha " + a, "Erro:" + a);
            }
        }
        private void data_grid_campanha_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //selecao_personagem(e);
        }
        private void btn_nova_campanha_Click(object sender, EventArgs e)
        {
            pnl_nome_campanha.Visible = true;
        }
        private void btn_eliminar_campanha_Click(object sender, EventArgs e)
        {
            Conexao_BD.deletar_campanha(Campanha.id_campanha, Campanha.id_jogador);
            carrega_data_grid_campanha();
        }
        private void btn_confirmar_camp_Click(object sender, EventArgs e)
        {
            imagembyte_campanha_nova = byte_image.imageToByteArray(pictureBox2.Image);
            Conexao_BD.criar_nova_campanha(txt_nome_campanha.Text, id_jogador, imagembyte_campanha_nova);
            pnl_nome_campanha.Visible = false;
            MessageBox.Show("Campanha criada com sucesso! \n\r Para acessar sua tela de Mestre, clique na campanha e depois no botão 'Tela do Mestre - Entrar'");
            carrega_data_grid_campanha();
            //this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_nome_campanha.Text = "";
            pnl_nome_campanha.Visible = false;
        }

        public void esconder_btn(int id)
        {
            if (id == id_jogador)
            {
                btn_entrar_mestre.Visible = true;
                btn_entrar.Visible = false;
                btn_eliminar.Visible = false;
                btn_criar_novo.Visible = false;
                btn_eliminar_campanha.Visible = true;
            }
        }

        private void lbl_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_criar_novo_Click(object sender, EventArgs e)
        {
            if (id_campanha != 0)
            {               
                Ficha.tipo_entidade = 1;
                id_personagem = 0;
                nome_personagem = "";
                Ficha.pers_criado = false;
                Ficha ficha = new Ficha();
                ficha.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione a campanha que deseja criar o personagem!");
            }
        }
        private void btn_entrar_mestre_Click(object sender, EventArgs e)
        {
            Campanha.id_entidade = 47; // depois temos que ver pra ele pegar o automatico, fixei por causa da campanha que vamos jogar e nao da tempo de finalizar
            Pagina_mestre mestre = new Pagina_mestre();
            this.Close();
            mestre.ShowDialog();
            
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Campanha_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, Login.WM_NCLBUTTONDOWN, Login.HT_CAPTION, 0);
            }
        }

        private void data_grid_campanha_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow x in data_grid_campanha.Rows)
            {
                x.MinimumHeight = 40;
            }
        }

        private void data_grid_pers_camp_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow x in data_grid_pers_camp.Rows)
            {
                x.MinimumHeight = 40;
            }
        }

     

        private void lbl_fechar_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, Color.Salmon);
            button.ForeColor = Color.Salmon;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                ativa = false;
                carrega_data_grid_campanha();
            }
            else
            {
                ativa = true;
                carrega_data_grid_campanha();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(id_jogador == id_mestre_campanha)
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

                    Image imagem_campanha = Image.FromFile(caminhoCompleto);

                    pictureBox1.Image = imagem_campanha;
                    imagembyte_campanha = byte_image.imageToByteArray(pictureBox1.Image);
                    Conexao_BD.insert_imagem_campanha(id_campanha, imagembyte_campanha);
                }
            }
            else{
                Image mostrar_imagem = pictureBox1.Image;
                visualizar_imagem.imagem_selecionada = mostrar_imagem;
                visualizar_imagem visualizar_Imagem = new visualizar_imagem();
                visualizar_Imagem.Show();
            }
            
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
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

                pictureBox2.Image = imagem_personagem;
            }

        }
    }
}
