using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dark_Age.Componente;
using Dark_Age.Enteties;
using Npgsql;

namespace Dark_Age
{
    public partial class Pagina_mestre : Form
    {
        public Pagina_mestre()
        {
            InitializeComponent();
        }

        private void Pagina_mestre_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_anotacoes_Click(object sender, EventArgs e)
        {
            txt_historia.Visible = true;
            txt_outros.Visible = false;
            txt_regras.Visible = false;
            txt_sanidade.Visible = false;
            txt_historia.Focus();

            btn_regras.BackColor = Color.Transparent;
            btn_sanidades.BackColor = Color.Transparent;
            btn_outros.BackColor = Color.Transparent;
            btn_historia.BackColor = Color.FromArgb(50, 50, 67);
        }

        private void btn_regras_Click(object sender, EventArgs e)
        {
            txt_historia.Visible = false;
            txt_outros.Visible = false;
            txt_regras.Visible = true;
            txt_sanidade.Visible = false;
            txt_regras.Focus();

            lbl_titulo.Text = "Regras do Sistema";

            btn_regras.BackColor = Color.FromArgb(50, 50, 67);
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
            btn_sanidades.BackColor = Color.FromArgb(50, 50, 67);
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
            btn_outros.BackColor = Color.FromArgb(50, 50, 67);
            btn_historia.BackColor = Color.Transparent;
        }

        private void btn_historia_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 67);
        }


        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            Lista_itens lista = new Lista_itens();
            lista.ShowDialog();
        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            lbl_npc.Text = "NPC's";
        }

        private void iconButton4_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 255, 255,192);

        private void iconButton3_Click(object sender, EventArgs e)
        {
            lbl_npc.Text = "Jogadores";
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            lbl_npc.Text = "Monstros";
        }

        private void iconButton5_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, Color.Salmon);
        }
    }
    
}