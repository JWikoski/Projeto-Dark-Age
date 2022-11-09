namespace Dark_Age
{
    partial class Pagina_mestre
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_outros = new FontAwesome.Sharp.IconButton();
            this.btn_sanidades = new FontAwesome.Sharp.IconButton();
            this.btn_historia = new FontAwesome.Sharp.IconButton();
            this.btn_regras = new FontAwesome.Sharp.IconButton();
            this.txt_outros = new System.Windows.Forms.RichTextBox();
            this.txt_regras = new System.Windows.Forms.RichTextBox();
            this.txt_sanidade = new System.Windows.Forms.RichTextBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_historia = new System.Windows.Forms.RichTextBox();
            this.btn_loja = new FontAwesome.Sharp.IconButton();
            this.bemvindo = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txt_outros);
            this.panel1.Controls.Add(this.txt_regras);
            this.panel1.Controls.Add(this.txt_sanidade);
            this.panel1.Controls.Add(this.lbl_titulo);
            this.panel1.Controls.Add(this.txt_historia);
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 821);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btn_outros);
            this.panel2.Controls.Add(this.btn_sanidades);
            this.panel2.Controls.Add(this.btn_historia);
            this.panel2.Controls.Add(this.btn_regras);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 54);
            this.panel2.TabIndex = 148;
            // 
            // btn_outros
            // 
            this.btn_outros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_outros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_outros.FlatAppearance.BorderSize = 0;
            this.btn_outros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btn_outros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_outros.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_outros.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_outros.IconChar = FontAwesome.Sharp.IconChar.BookJournalWhills;
            this.btn_outros.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btn_outros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_outros.IconSize = 30;
            this.btn_outros.Location = new System.Drawing.Point(588, 1);
            this.btn_outros.Name = "btn_outros";
            this.btn_outros.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btn_outros.Size = new System.Drawing.Size(168, 52);
            this.btn_outros.TabIndex = 147;
            this.btn_outros.Text = "Anotações";
            this.btn_outros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_outros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_outros.UseVisualStyleBackColor = true;
            this.btn_outros.Click += new System.EventHandler(this.btn_outros_Click);
            this.btn_outros.MouseEnter += new System.EventHandler(this.btn_historia_MouseEnter);
            this.btn_outros.MouseHover += new System.EventHandler(this.btn_historia_MouseEnter);
            // 
            // btn_sanidades
            // 
            this.btn_sanidades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sanidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sanidades.FlatAppearance.BorderSize = 0;
            this.btn_sanidades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btn_sanidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sanidades.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sanidades.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_sanidades.IconChar = FontAwesome.Sharp.IconChar.BookDead;
            this.btn_sanidades.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btn_sanidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_sanidades.IconSize = 30;
            this.btn_sanidades.Location = new System.Drawing.Point(410, 1);
            this.btn_sanidades.Name = "btn_sanidades";
            this.btn_sanidades.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btn_sanidades.Size = new System.Drawing.Size(172, 52);
            this.btn_sanidades.TabIndex = 146;
            this.btn_sanidades.Text = "Sanidades";
            this.btn_sanidades.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sanidades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sanidades.UseVisualStyleBackColor = true;
            this.btn_sanidades.Click += new System.EventHandler(this.btn_sanidades_Click);
            this.btn_sanidades.MouseEnter += new System.EventHandler(this.btn_historia_MouseEnter);
            this.btn_sanidades.MouseHover += new System.EventHandler(this.btn_historia_MouseEnter);
            // 
            // btn_historia
            // 
            this.btn_historia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_historia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btn_historia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_historia.FlatAppearance.BorderSize = 0;
            this.btn_historia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btn_historia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_historia.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_historia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_historia.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            this.btn_historia.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btn_historia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_historia.IconSize = 30;
            this.btn_historia.Location = new System.Drawing.Point(-7, 1);
            this.btn_historia.Name = "btn_historia";
            this.btn_historia.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btn_historia.Size = new System.Drawing.Size(172, 52);
            this.btn_historia.TabIndex = 144;
            this.btn_historia.Text = "História";
            this.btn_historia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_historia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_historia.UseVisualStyleBackColor = false;
            this.btn_historia.Click += new System.EventHandler(this.btn_anotacoes_Click);
            this.btn_historia.MouseEnter += new System.EventHandler(this.btn_historia_MouseEnter);
            this.btn_historia.MouseHover += new System.EventHandler(this.btn_historia_MouseEnter);
            // 
            // btn_regras
            // 
            this.btn_regras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_regras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regras.FlatAppearance.BorderSize = 0;
            this.btn_regras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btn_regras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regras.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_regras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_regras.IconChar = FontAwesome.Sharp.IconChar.BookAtlas;
            this.btn_regras.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btn_regras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_regras.IconSize = 30;
            this.btn_regras.Location = new System.Drawing.Point(204, 0);
            this.btn_regras.Name = "btn_regras";
            this.btn_regras.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btn_regras.Size = new System.Drawing.Size(172, 52);
            this.btn_regras.TabIndex = 145;
            this.btn_regras.Text = "Regras ";
            this.btn_regras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_regras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_regras.UseVisualStyleBackColor = true;
            this.btn_regras.Click += new System.EventHandler(this.btn_regras_Click);
            this.btn_regras.MouseEnter += new System.EventHandler(this.btn_historia_MouseEnter);
            this.btn_regras.MouseHover += new System.EventHandler(this.btn_historia_MouseEnter);
            // 
            // txt_outros
            // 
            this.txt_outros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_outros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.txt_outros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_outros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_outros.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt_outros.Location = new System.Drawing.Point(16, 108);
            this.txt_outros.Name = "txt_outros";
            this.txt_outros.Size = new System.Drawing.Size(740, 697);
            this.txt_outros.TabIndex = 8;
            this.txt_outros.Text = "";
            this.txt_outros.Visible = false;
            // 
            // txt_regras
            // 
            this.txt_regras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_regras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.txt_regras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_regras.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_regras.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt_regras.Location = new System.Drawing.Point(16, 108);
            this.txt_regras.Name = "txt_regras";
            this.txt_regras.Size = new System.Drawing.Size(740, 697);
            this.txt_regras.TabIndex = 7;
            this.txt_regras.Text = "\n";
            this.txt_regras.Visible = false;
            // 
            // txt_sanidade
            // 
            this.txt_sanidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sanidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.txt_sanidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sanidade.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_sanidade.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt_sanidade.Location = new System.Drawing.Point(16, 108);
            this.txt_sanidade.Name = "txt_sanidade";
            this.txt_sanidade.Size = new System.Drawing.Size(740, 697);
            this.txt_sanidade.TabIndex = 6;
            this.txt_sanidade.Text = "\n";
            this.txt_sanidade.Visible = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_titulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_titulo.Location = new System.Drawing.Point(349, 60);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.lbl_titulo.Size = new System.Drawing.Size(75, 33);
            this.lbl_titulo.TabIndex = 5;
            this.lbl_titulo.Text = "Título";
            this.lbl_titulo.Click += new System.EventHandler(this.lbl_titulo_Click);
            // 
            // txt_historia
            // 
            this.txt_historia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_historia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.txt_historia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_historia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_historia.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt_historia.Location = new System.Drawing.Point(16, 108);
            this.txt_historia.Name = "txt_historia";
            this.txt_historia.Size = new System.Drawing.Size(740, 697);
            this.txt_historia.TabIndex = 1;
            this.txt_historia.Text = "\n";
            // 
            // btn_loja
            // 
            this.btn_loja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_loja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loja.FlatAppearance.BorderSize = 0;
            this.btn_loja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loja.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_loja.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_loja.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.btn_loja.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btn_loja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_loja.IconSize = 30;
            this.btn_loja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_loja.Location = new System.Drawing.Point(744, -1);
            this.btn_loja.Name = "btn_loja";
            this.btn_loja.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btn_loja.Size = new System.Drawing.Size(172, 52);
            this.btn_loja.TabIndex = 148;
            this.btn_loja.Text = "Itens";
            this.btn_loja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_loja.UseVisualStyleBackColor = true;
            this.btn_loja.Click += new System.EventHandler(this.iconButton1_Click_1);
            this.btn_loja.MouseEnter += new System.EventHandler(this.btn_historia_MouseEnter);
            this.btn_loja.MouseHover += new System.EventHandler(this.btn_historia_MouseEnter);
            // 
            // bemvindo
            // 
            this.bemvindo.AutoSize = true;
            this.bemvindo.BackColor = System.Drawing.Color.Transparent;
            this.bemvindo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bemvindo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bemvindo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bemvindo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bemvindo.Location = new System.Drawing.Point(15, 9);
            this.bemvindo.Name = "bemvindo";
            this.bemvindo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.bemvindo.Size = new System.Drawing.Size(168, 42);
            this.bemvindo.TabIndex = 4;
            this.bemvindo.Text = "Bem-Vindo";
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.panel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.panel9.Location = new System.Drawing.Point(797, 71);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1, 790);
            this.panel9.TabIndex = 150;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(255, 18);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.label1.Size = new System.Drawing.Size(70, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "NPCs";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(815, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(770, 817);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.iconButton1);
            this.panel5.Controls.Add(this.iconButton3);
            this.panel5.Controls.Add(this.iconButton4);
            this.panel5.Controls.Add(this.iconButton5);
            this.panel5.Location = new System.Drawing.Point(464, 318);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 219);
            this.panel5.TabIndex = 149;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.panel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.panel7.Location = new System.Drawing.Point(-9, 718);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 350);
            this.panel7.TabIndex = 150;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(3, 729);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.iconButton1.Size = new System.Drawing.Size(172, 52);
            this.iconButton1.TabIndex = 148;
            this.iconButton1.Text = "Itens";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.BookDead;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(3, 157);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.iconButton3.Size = new System.Drawing.Size(172, 52);
            this.iconButton3.TabIndex = 146;
            this.iconButton3.Text = "Jogadores";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            this.iconButton4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(5, 33);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.iconButton4.Size = new System.Drawing.Size(172, 52);
            this.iconButton4.TabIndex = 144;
            this.iconButton4.Text = "NPCs";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton5
            // 
            this.iconButton5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.BookAtlas;
            this.iconButton5.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 30;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(3, 99);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.iconButton5.Size = new System.Drawing.Size(172, 52);
            this.iconButton5.TabIndex = 145;
            this.iconButton5.Text = "Monstros";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // Pagina_mestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.btn_loja);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.bemvindo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "Pagina_mestre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina_mestre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pagina_mestre_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txt_historia;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label bemvindo;
        private System.Windows.Forms.RichTextBox txt_outros;
        private System.Windows.Forms.RichTextBox txt_regras;
        private System.Windows.Forms.RichTextBox txt_sanidade;
        private FontAwesome.Sharp.IconButton btn_historia;
        private FontAwesome.Sharp.IconButton btn_outros;
        private FontAwesome.Sharp.IconButton btn_sanidades;
        private FontAwesome.Sharp.IconButton btn_regras;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_loja;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
    }
}