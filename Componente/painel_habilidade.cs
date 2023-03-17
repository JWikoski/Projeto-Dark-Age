using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dark_Age.Componente
{
    public partial class painel_habilidade : UserControl
    {
        public painel_habilidade(string text, string titulo, int valor_hab, string tipo_habilidade, string extra)
        {
            InitializeComponent();

            Label desc_habilidade = new Label();
            desc_habilidade.BackColor = Color.Transparent;
            desc_habilidade.ForeColor = Color.FromArgb(160, 155, 140);
            desc_habilidade.Font = new Font("Segoe UI", 11);
            desc_habilidade.Dock = DockStyle.None;
            desc_habilidade.TextAlign = ContentAlignment.TopLeft;
            desc_habilidade.Top = 0;
            desc_habilidade.Left = 10;
            desc_habilidade.AutoSize = true;
            desc_habilidade.MinimumSize = new Size(0, 20);
            desc_habilidade.MaximumSize = new Size(540, 0);
            desc_habilidade.Text = "";

            pnl_hab.Controls.Add(desc_habilidade);

            titulo_hab.Text = titulo;
            desc_habilidade.Text = text;

            if (tipo_habilidade != "Sem Custo" || Habilidades.tipo_hab == true)
            {
                armazena_custo.Text = valor_hab.ToString();
                armazena_tipo.Text = tipo_habilidade;
                custo_tipo.Text = valor_hab + " " + tipo_habilidade;
                custo_extra.Text = extra;
                custo_tipo.Visible = true;
                custo_extra.Visible = true;
            }
            else
            {
                custo_tipo.Visible = false;
                custo_extra.Visible = false;
                btn_usar.Visible = false;
            }

            if (tipo_habilidade == "PM")
            {
                custo_tipo.IconChar = FontAwesome.Sharp.IconChar.Tint;
                custo_tipo.ForeColor = Color.DeepSkyBlue;
                custo_tipo.IconColor = Color.DeepSkyBlue;
                btn_usar.Visible = true;
            }
            else if(tipo_habilidade == "PV" || tipo_habilidade == "PV mínimo")
            {
                custo_tipo.IconChar = FontAwesome.Sharp.IconChar.HeartBroken;
                custo_tipo.ForeColor = Color.Salmon;
                custo_tipo.IconColor = Color.Salmon;
                btn_usar.Visible = true;
            }
            else if (tipo_habilidade == "Pontos Fracos" || tipo_habilidade == "Ponto Fraco")
            {
                custo_tipo.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
                custo_tipo.ForeColor = Color.White;
                custo_tipo.IconColor = Color.White;
            }else if (tipo_habilidade == "Sanidade")
            {
                custo_tipo.IconChar = FontAwesome.Sharp.IconChar.StarOfDavid;
                custo_tipo.ForeColor = Color.CadetBlue;
                custo_tipo.IconColor = Color.CadetBlue;
                btn_usar.Visible = true;
            }
            else if (tipo_habilidade == "PL")
            {
                custo_tipo.IconChar = FontAwesome.Sharp.IconChar.Superpowers;
                custo_tipo.ForeColor = Color.Khaki;
                custo_tipo.IconColor = Color.Khaki;
                btn_usar.Visible = true;
            }
            else
            {
                custo_tipo.IconChar = FontAwesome.Sharp.IconChar.None;
                custo_tipo.ForeColor = Color.FromArgb(160, 155, 140);
                custo_tipo.IconColor = Color.FromArgb(160, 155, 140);
                custo_tipo.Text = "Sem Custo";
            }


          
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Color cor = button.ForeColor;
            button.ForeColor = Color.FromArgb(207, 167, 110);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.ForeColor = Color.FromArgb(160, 155, 140);
        }

        private void btn_usar_Click(object sender, EventArgs e)
        {

            if (armazena_tipo.Text == "PM")
            {
                
                if (Form1.mana_atual > Convert.ToInt32(armazena_custo.Text))
                {
                    Form1.mana_atual = Form1.mana_atual - Convert.ToInt32(armazena_custo.Text);
                }
                else if((Form1.mana_atual - Convert.ToInt32(armazena_custo.Text)) <= 0)
                {
                    if(Form1.mana_atual == 0)
                    {
                        MessageBox.Show("Você está sem mana T-T");
                    }
                    else if (MessageBox.Show("Usar esta habilidade vai zerar seus pontos de mana, tem certeza que deseja usá-la?", "Sua mana está quase esgotada!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Form1.mana_atual = 0;
                    }
                }
            }
            if (armazena_tipo.Text == "PL")
            {

                if (Form1.adicional_atual > Convert.ToInt32(armazena_custo.Text))
                {
                    Form1.adicional_atual = Form1.adicional_atual - Convert.ToInt32(armazena_custo.Text);
                }
                else if ((Form1.adicional_atual - Convert.ToInt32(armazena_custo.Text)) <= 0)
                {
                    if (Form1.adicional_atual == 0)
                    {
                        MessageBox.Show("Sem pontos de luz restantes, mas não desista, a escuridão não vai reinar enquanto você estiver de pé!!");
                    }
                    else if(MessageBox.Show("Seus pontos de luz estão quase no fim, tem certeza que deseja usar esta habilidade?", "Sua luz nunca será em vão!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Form1.adicional_atual = 0;
                    }
                }
            }
            else if (armazena_tipo.Text == "PV" || armazena_tipo.Text == "PV mínimo")
            {
                
                if (Form1.vida_atual > Convert.ToInt32(armazena_custo.Text))
                {
                    Form1.vida_atual = Form1.vida_atual - Convert.ToInt32(armazena_custo.Text);
                }
                else if ((Form1.vida_atual - Convert.ToInt32(armazena_custo.Text)) <= 0)
                {
                    if (Form1.vida_atual == 0)
                    {
                        MessageBox.Show("Você tá desmaiado, nem pode usar essa habilidade. '-'");
                    }
                    else
                      if (MessageBox.Show("Você vai desmaiar ao usar essa habilidade, tem certeza que deseja usá-la?", "Seus companheiros precisam de você vivo!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Form1.vida_atual = 0;
                    }
                }
            }
            else if (armazena_tipo.Text == "Sanidade")
            {
                if(Form1.sanidade_atual > Convert.ToInt32(armazena_custo.Text))
                {
                    Form1.sanidade_atual = Form1.sanidade_atual - Convert.ToInt32(armazena_custo.Text);
                }
                else if ((Form1.sanidade_atual - Convert.ToInt32(armazena_custo.Text)) <= 0)
                {
                    if (Form1.sanidade_atual == 0)
                    {
                        MessageBox.Show("Sua sanidade está zerada, procure um terapeuta antes de usar essa habilidade novamente (ou durma).");
                    }
                    else
                      if (MessageBox.Show("Você vai receber uma insanidade caso use essa habilidade, tem certeza que deseja usá-la?", "Sua sanidade também é importante!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Form1.sanidade_atual = 0;
                    }
                }
            }
        }

        private void painel_habilidade_Load(object sender, EventArgs e)
        {

        }
    }
}
