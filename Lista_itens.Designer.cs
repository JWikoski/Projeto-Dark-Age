﻿namespace Dark_Age
{
    partial class Lista_itens
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.remove_qtd = new FontAwesome.Sharp.IconButton();
            this.adiciona_qtd = new FontAwesome.Sharp.IconButton();
            this.qtd_inventario = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.text_descricao = new System.Windows.Forms.RichTextBox();
            this.lbl_qtd = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pnl_filtro = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_materiais = new System.Windows.Forms.ComboBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.limpar_filtros2 = new FontAwesome.Sharp.IconButton();
            this.filtro_tipo = new System.Windows.Forms.CheckBox();
            this.filtro_dificuldade = new System.Windows.Forms.CheckBox();
            this.filtro_profissoes = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.combox_profissao = new System.Windows.Forms.ComboBox();
            this.combox_tipo = new System.Windows.Forms.ComboBox();
            this.combox_dificuldade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmp_procura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Grid_lista_itens = new System.Windows.Forms.DataGridView();
            this.limpar_filtros1 = new FontAwesome.Sharp.IconButton();
            this.btn_historia = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnl_filtro.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_lista_itens)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1580, 807);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.remove_qtd);
            this.panel3.Controls.Add(this.adiciona_qtd);
            this.panel3.Controls.Add(this.qtd_inventario);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.lbl_qtd);
            this.panel3.Controls.Add(this.iconButton3);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Controls.Add(this.pnl_filtro);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cmp_procura);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.Grid_lista_itens);
            this.panel3.Controls.Add(this.limpar_filtros1);
            this.panel3.Controls.Add(this.btn_historia);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1577, 804);
            this.panel3.TabIndex = 89;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.LightGray;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(155)))), ((int)(((byte)(140)))));
            this.panel10.Location = new System.Drawing.Point(3, 800);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1568, 4);
            this.panel10.TabIndex = 154;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(155)))), ((int)(((byte)(140)))));
            this.panel8.Location = new System.Drawing.Point(1571, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(6, 800);
            this.panel8.TabIndex = 153;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(155)))), ((int)(((byte)(140)))));
            this.panel7.Location = new System.Drawing.Point(0, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(3, 800);
            this.panel7.TabIndex = 152;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(155)))), ((int)(((byte)(140)))));
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1577, 4);
            this.panel6.TabIndex = 151;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LightGray;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(155)))), ((int)(((byte)(140)))));
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(3, 4);
            this.panel9.TabIndex = 153;
            // 
            // remove_qtd
            // 
            this.remove_qtd.FlatAppearance.BorderSize = 0;
            this.remove_qtd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.remove_qtd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.remove_qtd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_qtd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.remove_qtd.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.remove_qtd.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.remove_qtd.IconColor = System.Drawing.Color.Salmon;
            this.remove_qtd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.remove_qtd.IconSize = 30;
            this.remove_qtd.Location = new System.Drawing.Point(1140, 679);
            this.remove_qtd.Name = "remove_qtd";
            this.remove_qtd.Size = new System.Drawing.Size(30, 30);
            this.remove_qtd.TabIndex = 150;
            this.remove_qtd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.remove_qtd.UseVisualStyleBackColor = true;
            this.remove_qtd.Visible = false;
            this.remove_qtd.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // adiciona_qtd
            // 
            this.adiciona_qtd.FlatAppearance.BorderSize = 0;
            this.adiciona_qtd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adiciona_qtd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adiciona_qtd.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.adiciona_qtd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.adiciona_qtd.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.adiciona_qtd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.adiciona_qtd.IconSize = 30;
            this.adiciona_qtd.Location = new System.Drawing.Point(1173, 679);
            this.adiciona_qtd.Name = "adiciona_qtd";
            this.adiciona_qtd.Size = new System.Drawing.Size(30, 30);
            this.adiciona_qtd.TabIndex = 149;
            this.adiciona_qtd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.adiciona_qtd.UseVisualStyleBackColor = true;
            this.adiciona_qtd.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // qtd_inventario
            // 
            this.qtd_inventario.AutoSize = true;
            this.qtd_inventario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qtd_inventario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.qtd_inventario.Location = new System.Drawing.Point(1311, 666);
            this.qtd_inventario.Name = "qtd_inventario";
            this.qtd_inventario.Size = new System.Drawing.Size(181, 19);
            this.qtd_inventario.TabIndex = 148;
            this.qtd_inventario.Text = "Quantidade no inventário: 0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.panel5.Controls.Add(this.text_descricao);
            this.panel5.Location = new System.Drawing.Point(1131, 200);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(381, 466);
            this.panel5.TabIndex = 147;
            // 
            // text_descricao
            // 
            this.text_descricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.text_descricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_descricao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_descricao.ForeColor = System.Drawing.Color.White;
            this.text_descricao.Location = new System.Drawing.Point(10, 7);
            this.text_descricao.Name = "text_descricao";
            this.text_descricao.ReadOnly = true;
            this.text_descricao.Size = new System.Drawing.Size(361, 456);
            this.text_descricao.TabIndex = 1;
            this.text_descricao.Text = "";
            // 
            // lbl_qtd
            // 
            this.lbl_qtd.AutoSize = true;
            this.lbl_qtd.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_qtd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_qtd.Location = new System.Drawing.Point(1210, 676);
            this.lbl_qtd.Name = "lbl_qtd";
            this.lbl_qtd.Size = new System.Drawing.Size(27, 32);
            this.lbl_qtd.TabIndex = 146;
            this.lbl_qtd.Text = "1";
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.Transparent;
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton3.ForeColor = System.Drawing.Color.Salmon;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButton3.IconColor = System.Drawing.Color.Salmon;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.Location = new System.Drawing.Point(1519, 10);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(43, 37);
            this.iconButton3.TabIndex = 102;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.LblFecharPassivas_Click);
            this.iconButton3.MouseEnter += new System.EventHandler(this.limpar_filtros2_MouseEnter);
            this.iconButton3.MouseLeave += new System.EventHandler(this.limpar_filtros2_MouseLeave);
            this.iconButton3.MouseHover += new System.EventHandler(this.limpar_filtros2_MouseEnter);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(155)))), ((int)(((byte)(140)))));
            this.panel4.Location = new System.Drawing.Point(2, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 1);
            this.panel4.TabIndex = 95;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(127)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(60, 98);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(84, 28);
            this.iconButton1.TabIndex = 94;
            this.iconButton1.Text = "Filtros";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            this.iconButton1.MouseEnter += new System.EventHandler(this.iconButton1_MouseEnter);
            this.iconButton1.MouseLeave += new System.EventHandler(this.iconButton1_MouseLeave);
            this.iconButton1.MouseHover += new System.EventHandler(this.iconButton1_MouseEnter);
            // 
            // pnl_filtro
            // 
            this.pnl_filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_filtro.Controls.Add(this.label4);
            this.pnl_filtro.Controls.Add(this.cbx_materiais);
            this.pnl_filtro.Controls.Add(this.iconButton2);
            this.pnl_filtro.Controls.Add(this.limpar_filtros2);
            this.pnl_filtro.Controls.Add(this.filtro_tipo);
            this.pnl_filtro.Controls.Add(this.filtro_dificuldade);
            this.pnl_filtro.Controls.Add(this.filtro_profissoes);
            this.pnl_filtro.Controls.Add(this.button2);
            this.pnl_filtro.Controls.Add(this.combox_profissao);
            this.pnl_filtro.Controls.Add(this.combox_tipo);
            this.pnl_filtro.Controls.Add(this.combox_dificuldade);
            this.pnl_filtro.Location = new System.Drawing.Point(150, 98);
            this.pnl_filtro.Name = "pnl_filtro";
            this.pnl_filtro.Size = new System.Drawing.Size(509, 229);
            this.pnl_filtro.TabIndex = 93;
            this.pnl_filtro.Visible = false;
            this.pnl_filtro.Leave += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(258, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 104;
            this.label4.Text = "Materiais";
            // 
            // cbx_materiais
            // 
            this.cbx_materiais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.cbx_materiais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_materiais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_materiais.Enabled = false;
            this.cbx_materiais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_materiais.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbx_materiais.FormattingEnabled = true;
            this.cbx_materiais.Items.AddRange(new object[] {
            "Mostrar tudo",
            "Mostrar apenas Materiais",
            "Não mostrar"});
            this.cbx_materiais.Location = new System.Drawing.Point(258, 137);
            this.cbx_materiais.Name = "cbx_materiais";
            this.cbx_materiais.Size = new System.Drawing.Size(155, 23);
            this.cbx_materiais.TabIndex = 103;
            this.cbx_materiais.Tag = "0";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton2.ForeColor = System.Drawing.Color.Salmon;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButton2.IconColor = System.Drawing.Color.Salmon;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(465, 9);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(28, 28);
            this.iconButton2.TabIndex = 101;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.label4_Click);
            this.iconButton2.MouseEnter += new System.EventHandler(this.limpar_filtros2_MouseEnter);
            this.iconButton2.MouseLeave += new System.EventHandler(this.limpar_filtros2_MouseLeave);
            this.iconButton2.MouseHover += new System.EventHandler(this.limpar_filtros2_MouseEnter);
            // 
            // limpar_filtros2
            // 
            this.limpar_filtros2.BackColor = System.Drawing.Color.Transparent;
            this.limpar_filtros2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpar_filtros2.FlatAppearance.BorderSize = 0;
            this.limpar_filtros2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.limpar_filtros2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpar_filtros2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.limpar_filtros2.ForeColor = System.Drawing.Color.Salmon;
            this.limpar_filtros2.IconChar = FontAwesome.Sharp.IconChar.FilterCircleXmark;
            this.limpar_filtros2.IconColor = System.Drawing.Color.Salmon;
            this.limpar_filtros2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.limpar_filtros2.IconSize = 20;
            this.limpar_filtros2.Location = new System.Drawing.Point(375, 186);
            this.limpar_filtros2.Name = "limpar_filtros2";
            this.limpar_filtros2.Size = new System.Drawing.Size(28, 28);
            this.limpar_filtros2.TabIndex = 100;
            this.limpar_filtros2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.limpar_filtros2.UseVisualStyleBackColor = false;
            this.limpar_filtros2.Visible = false;
            this.limpar_filtros2.Click += new System.EventHandler(this.limpar_filtros2_Click);
            this.limpar_filtros2.MouseEnter += new System.EventHandler(this.limpar_filtros2_MouseEnter);
            this.limpar_filtros2.MouseLeave += new System.EventHandler(this.limpar_filtros2_MouseLeave);
            this.limpar_filtros2.MouseHover += new System.EventHandler(this.limpar_filtros2_MouseEnter);
            // 
            // filtro_tipo
            // 
            this.filtro_tipo.AutoSize = true;
            this.filtro_tipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.filtro_tipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtro_tipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filtro_tipo.Location = new System.Drawing.Point(258, 26);
            this.filtro_tipo.Name = "filtro_tipo";
            this.filtro_tipo.Size = new System.Drawing.Size(93, 19);
            this.filtro_tipo.TabIndex = 99;
            this.filtro_tipo.Text = "Tipo do Item";
            this.filtro_tipo.UseVisualStyleBackColor = true;
            this.filtro_tipo.CheckedChanged += new System.EventHandler(this.filtro_tipo_CheckedChanged);
            // 
            // filtro_dificuldade
            // 
            this.filtro_dificuldade.AutoSize = true;
            this.filtro_dificuldade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.filtro_dificuldade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtro_dificuldade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filtro_dificuldade.Location = new System.Drawing.Point(23, 24);
            this.filtro_dificuldade.Name = "filtro_dificuldade";
            this.filtro_dificuldade.Size = new System.Drawing.Size(86, 19);
            this.filtro_dificuldade.TabIndex = 98;
            this.filtro_dificuldade.Text = "Dificuldade";
            this.filtro_dificuldade.UseVisualStyleBackColor = true;
            this.filtro_dificuldade.CheckedChanged += new System.EventHandler(this.filtro_dificuldade_CheckedChanged);
            // 
            // filtro_profissoes
            // 
            this.filtro_profissoes.AutoSize = true;
            this.filtro_profissoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.filtro_profissoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtro_profissoes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filtro_profissoes.Location = new System.Drawing.Point(23, 112);
            this.filtro_profissoes.Name = "filtro_profissoes";
            this.filtro_profissoes.Size = new System.Drawing.Size(79, 19);
            this.filtro_profissoes.TabIndex = 97;
            this.filtro_profissoes.Text = "Profissões";
            this.filtro_profissoes.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(420, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 28);
            this.button2.TabIndex = 96;
            this.button2.Text = "Aplicar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.iconButton1_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.iconButton1_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.iconButton1_MouseEnter);
            // 
            // combox_profissao
            // 
            this.combox_profissao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.combox_profissao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combox_profissao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_profissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combox_profissao.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.combox_profissao.FormattingEnabled = true;
            this.combox_profissao.Location = new System.Drawing.Point(23, 137);
            this.combox_profissao.Name = "combox_profissao";
            this.combox_profissao.Size = new System.Drawing.Size(155, 23);
            this.combox_profissao.TabIndex = 95;
            this.combox_profissao.Click += new System.EventHandler(this.combox_profissao_Click);
            // 
            // combox_tipo
            // 
            this.combox_tipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.combox_tipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combox_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combox_tipo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.combox_tipo.FormattingEnabled = true;
            this.combox_tipo.Location = new System.Drawing.Point(258, 49);
            this.combox_tipo.Name = "combox_tipo";
            this.combox_tipo.Size = new System.Drawing.Size(155, 23);
            this.combox_tipo.TabIndex = 94;
            this.combox_tipo.Click += new System.EventHandler(this.combox_tipo_Click);
            // 
            // combox_dificuldade
            // 
            this.combox_dificuldade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.combox_dificuldade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combox_dificuldade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_dificuldade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combox_dificuldade.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.combox_dificuldade.FormattingEnabled = true;
            this.combox_dificuldade.Items.AddRange(new object[] {
            "Todos"});
            this.combox_dificuldade.Location = new System.Drawing.Point(23, 47);
            this.combox_dificuldade.Name = "combox_dificuldade";
            this.combox_dificuldade.Size = new System.Drawing.Size(155, 23);
            this.combox_dificuldade.TabIndex = 93;
            this.combox_dificuldade.Click += new System.EventHandler(this.combox_dificuldade_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 88;
            this.label3.Text = "Procurar";
            // 
            // cmp_procura
            // 
            this.cmp_procura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.cmp_procura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmp_procura.ForeColor = System.Drawing.SystemColors.Menu;
            this.cmp_procura.Location = new System.Drawing.Point(136, 150);
            this.cmp_procura.Name = "cmp_procura";
            this.cmp_procura.Size = new System.Drawing.Size(920, 23);
            this.cmp_procura.TabIndex = 87;
            this.cmp_procura.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1252, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descrição do Item";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_adicionar);
            this.panel2.Controls.Add(this.btn_editar);
            this.panel2.Controls.Add(this.btn_eliminar);
            this.panel2.Location = new System.Drawing.Point(1131, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 54);
            this.panel2.TabIndex = 5;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.Transparent;
            this.btn_adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_adicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.btn_adicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.btn_adicionar.Location = new System.Drawing.Point(9, 10);
            this.btn_adicionar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(94, 38);
            this.btn_adicionar.TabIndex = 2;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click_1);
            this.btn_adicionar.MouseEnter += new System.EventHandler(this.iconButton1_MouseEnter);
            this.btn_adicionar.MouseLeave += new System.EventHandler(this.iconButton1_MouseLeave);
            this.btn_adicionar.MouseHover += new System.EventHandler(this.iconButton1_MouseEnter);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.Transparent;
            this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(38)))), ((int)(((byte)(192)))));
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(38)))), ((int)(((byte)(192)))));
            this.btn_editar.Location = new System.Drawing.Point(140, 10);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(102, 38);
            this.btn_editar.TabIndex = 3;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            this.btn_editar.MouseEnter += new System.EventHandler(this.iconButton1_MouseEnter);
            this.btn_editar.MouseLeave += new System.EventHandler(this.iconButton1_MouseLeave);
            this.btn_editar.MouseHover += new System.EventHandler(this.iconButton1_MouseEnter);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Transparent;
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.ForeColor = System.Drawing.Color.Salmon;
            this.btn_eliminar.Location = new System.Drawing.Point(277, 10);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(94, 38);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            this.btn_eliminar.MouseEnter += new System.EventHandler(this.iconButton1_MouseEnter);
            this.btn_eliminar.MouseLeave += new System.EventHandler(this.iconButton1_MouseLeave);
            this.btn_eliminar.MouseHover += new System.EventHandler(this.iconButton1_MouseEnter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(126)))), ((int)(((byte)(155)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1131, 722);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(384, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Adicionar Item ao Inventario";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_adicionar_inv_Click);
            // 
            // Grid_lista_itens
            // 
            this.Grid_lista_itens.AllowUserToAddRows = false;
            this.Grid_lista_itens.AllowUserToDeleteRows = false;
            this.Grid_lista_itens.AllowUserToOrderColumns = true;
            this.Grid_lista_itens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_lista_itens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Grid_lista_itens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.Grid_lista_itens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_lista_itens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid_lista_itens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_lista_itens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Grid_lista_itens.ColumnHeadersHeight = 30;
            this.Grid_lista_itens.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_lista_itens.DefaultCellStyle = dataGridViewCellStyle5;
            this.Grid_lista_itens.EnableHeadersVisualStyles = false;
            this.Grid_lista_itens.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.Grid_lista_itens.Location = new System.Drawing.Point(60, 182);
            this.Grid_lista_itens.MultiSelect = false;
            this.Grid_lista_itens.Name = "Grid_lista_itens";
            this.Grid_lista_itens.ReadOnly = true;
            this.Grid_lista_itens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_lista_itens.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Grid_lista_itens.RowTemplate.Height = 10;
            this.Grid_lista_itens.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_lista_itens.Size = new System.Drawing.Size(996, 582);
            this.Grid_lista_itens.TabIndex = 0;
            this.Grid_lista_itens.VirtualMode = true;
            this.Grid_lista_itens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_lista_itens_CellClick);
            this.Grid_lista_itens.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_lista_itens_ColumnHeaderMouseClick);
            // 
            // limpar_filtros1
            // 
            this.limpar_filtros1.BackColor = System.Drawing.Color.Transparent;
            this.limpar_filtros1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpar_filtros1.FlatAppearance.BorderSize = 0;
            this.limpar_filtros1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.limpar_filtros1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpar_filtros1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.limpar_filtros1.ForeColor = System.Drawing.Color.Salmon;
            this.limpar_filtros1.IconChar = FontAwesome.Sharp.IconChar.FilterCircleXmark;
            this.limpar_filtros1.IconColor = System.Drawing.Color.Salmon;
            this.limpar_filtros1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.limpar_filtros1.IconSize = 20;
            this.limpar_filtros1.Location = new System.Drawing.Point(150, 98);
            this.limpar_filtros1.Name = "limpar_filtros1";
            this.limpar_filtros1.Size = new System.Drawing.Size(127, 28);
            this.limpar_filtros1.TabIndex = 96;
            this.limpar_filtros1.Text = "Limpar Filtros";
            this.limpar_filtros1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.limpar_filtros1.UseVisualStyleBackColor = false;
            this.limpar_filtros1.Visible = false;
            this.limpar_filtros1.Click += new System.EventHandler(this.remove_filtros1_Click);
            this.limpar_filtros1.MouseEnter += new System.EventHandler(this.limpar_filtros2_MouseEnter);
            this.limpar_filtros1.MouseLeave += new System.EventHandler(this.limpar_filtros2_MouseLeave);
            this.limpar_filtros1.MouseHover += new System.EventHandler(this.limpar_filtros2_MouseEnter);
            // 
            // btn_historia
            // 
            this.btn_historia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_historia.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_historia.FlatAppearance.BorderSize = 0;
            this.btn_historia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_historia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_historia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_historia.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_historia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_historia.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.btn_historia.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btn_historia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_historia.IconSize = 40;
            this.btn_historia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_historia.Location = new System.Drawing.Point(0, 3);
            this.btn_historia.Name = "btn_historia";
            this.btn_historia.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btn_historia.Size = new System.Drawing.Size(225, 48);
            this.btn_historia.TabIndex = 145;
            this.btn_historia.Text = "Loja de Itens";
            this.btn_historia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_historia.UseVisualStyleBackColor = true;
            // 
            // Lista_itens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1574, 803);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lista_itens";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista_itens";
            this.Load += new System.EventHandler(this.Lista_itens_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnl_filtro.ResumeLayout(false);
            this.pnl_filtro.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_lista_itens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn profissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dificuldade;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton remove_qtd;
        private FontAwesome.Sharp.IconButton adiciona_qtd;
        private System.Windows.Forms.Label qtd_inventario;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox text_descricao;
        private System.Windows.Forms.Label lbl_qtd;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel pnl_filtro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_materiais;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton limpar_filtros2;
        private System.Windows.Forms.CheckBox filtro_tipo;
        private System.Windows.Forms.CheckBox filtro_dificuldade;
        private System.Windows.Forms.CheckBox filtro_profissoes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox combox_profissao;
        private System.Windows.Forms.ComboBox combox_tipo;
        private System.Windows.Forms.ComboBox combox_dificuldade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cmp_procura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView Grid_lista_itens;
        private FontAwesome.Sharp.IconButton limpar_filtros1;
        private FontAwesome.Sharp.IconButton btn_historia;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Timer timer1;
    }
}