namespace Dark_Age
{
    partial class Campanha
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_eliminar_campanha = new FontAwesome.Sharp.IconButton();
            this.btn_eliminar = new FontAwesome.Sharp.IconButton();
            this.btn_entrar_mestre = new System.Windows.Forms.Button();
            this.btn_nova_campanha = new System.Windows.Forms.Button();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.btn_criar_novo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_nome_campanha = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_confirmar_camp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome_campanha = new System.Windows.Forms.TextBox();
            this.data_grid_pers_camp = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.data_grid_campanha = new System.Windows.Forms.DataGridView();
            this.lbl_fechar = new System.Windows.Forms.Label();
            this.lbl_bvd = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_nome_campanha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_pers_camp)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_campanha)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 617);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_eliminar_campanha);
            this.panel4.Controls.Add(this.btn_eliminar);
            this.panel4.Controls.Add(this.btn_entrar_mestre);
            this.panel4.Controls.Add(this.btn_nova_campanha);
            this.panel4.Controls.Add(this.btn_entrar);
            this.panel4.Controls.Add(this.btn_criar_novo);
            this.panel4.Location = new System.Drawing.Point(913, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(335, 608);
            this.panel4.TabIndex = 2;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Campanha_MouseDown);
            // 
            // btn_eliminar_campanha
            // 
            this.btn_eliminar_campanha.BackColor = System.Drawing.Color.Transparent;
            this.btn_eliminar_campanha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_campanha.ForeColor = System.Drawing.Color.Salmon;
            this.btn_eliminar_campanha.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btn_eliminar_campanha.IconColor = System.Drawing.Color.Salmon;
            this.btn_eliminar_campanha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_eliminar_campanha.IconSize = 20;
            this.btn_eliminar_campanha.Location = new System.Drawing.Point(183, 72);
            this.btn_eliminar_campanha.Name = "btn_eliminar_campanha";
            this.btn_eliminar_campanha.Size = new System.Drawing.Size(141, 34);
            this.btn_eliminar_campanha.TabIndex = 9;
            this.btn_eliminar_campanha.Text = "Excluir Campanha";
            this.btn_eliminar_campanha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_eliminar_campanha.UseVisualStyleBackColor = false;
            this.btn_eliminar_campanha.Click += new System.EventHandler(this.btn_eliminar_campanha_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Transparent;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.ForeColor = System.Drawing.Color.Salmon;
            this.btn_eliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btn_eliminar.IconColor = System.Drawing.Color.Salmon;
            this.btn_eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_eliminar.IconSize = 20;
            this.btn_eliminar.Location = new System.Drawing.Point(183, 561);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(141, 34);
            this.btn_eliminar.TabIndex = 8;
            this.btn_eliminar.Text = "Excluir Personagem";
            this.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_entrar_mestre
            // 
            this.btn_entrar_mestre.BackColor = System.Drawing.Color.Transparent;
            this.btn_entrar_mestre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.btn_entrar_mestre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.btn_entrar_mestre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar_mestre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_entrar_mestre.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_entrar_mestre.Location = new System.Drawing.Point(12, 430);
            this.btn_entrar_mestre.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btn_entrar_mestre.Name = "btn_entrar_mestre";
            this.btn_entrar_mestre.Size = new System.Drawing.Size(312, 49);
            this.btn_entrar_mestre.TabIndex = 7;
            this.btn_entrar_mestre.Text = "Tela do Mestre - Entrar";
            this.btn_entrar_mestre.UseVisualStyleBackColor = false;
            this.btn_entrar_mestre.Visible = false;
            this.btn_entrar_mestre.Click += new System.EventHandler(this.btn_entrar_mestre_Click);
            // 
            // btn_nova_campanha
            // 
            this.btn_nova_campanha.BackColor = System.Drawing.Color.Transparent;
            this.btn_nova_campanha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.btn_nova_campanha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.btn_nova_campanha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nova_campanha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_nova_campanha.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_nova_campanha.Location = new System.Drawing.Point(12, 10);
            this.btn_nova_campanha.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btn_nova_campanha.Name = "btn_nova_campanha";
            this.btn_nova_campanha.Size = new System.Drawing.Size(312, 49);
            this.btn_nova_campanha.TabIndex = 5;
            this.btn_nova_campanha.Text = "Nova Campanha";
            this.btn_nova_campanha.UseVisualStyleBackColor = false;
            this.btn_nova_campanha.Click += new System.EventHandler(this.btn_nova_campanha_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.btn_entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_entrar.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_entrar.Location = new System.Drawing.Point(12, 499);
            this.btn_entrar.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(312, 49);
            this.btn_entrar.TabIndex = 4;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // btn_criar_novo
            // 
            this.btn_criar_novo.BackColor = System.Drawing.Color.Transparent;
            this.btn_criar_novo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.btn_criar_novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.btn_criar_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_criar_novo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_criar_novo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_criar_novo.Location = new System.Drawing.Point(12, 119);
            this.btn_criar_novo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btn_criar_novo.Name = "btn_criar_novo";
            this.btn_criar_novo.Size = new System.Drawing.Size(312, 49);
            this.btn_criar_novo.TabIndex = 2;
            this.btn_criar_novo.Text = "Novo personagem";
            this.btn_criar_novo.UseVisualStyleBackColor = false;
            this.btn_criar_novo.Click += new System.EventHandler(this.btn_criar_novo_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnl_nome_campanha);
            this.panel3.Controls.Add(this.data_grid_pers_camp);
            this.panel3.Location = new System.Drawing.Point(459, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(448, 611);
            this.panel3.TabIndex = 1;
            // 
            // pnl_nome_campanha
            // 
            this.pnl_nome_campanha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.pnl_nome_campanha.Controls.Add(this.btn_cancelar);
            this.pnl_nome_campanha.Controls.Add(this.btn_confirmar_camp);
            this.pnl_nome_campanha.Controls.Add(this.label1);
            this.pnl_nome_campanha.Controls.Add(this.txt_nome_campanha);
            this.pnl_nome_campanha.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_nome_campanha.Location = new System.Drawing.Point(35, 184);
            this.pnl_nome_campanha.Name = "pnl_nome_campanha";
            this.pnl_nome_campanha.Size = new System.Drawing.Size(329, 117);
            this.pnl_nome_campanha.TabIndex = 7;
            this.pnl_nome_campanha.Visible = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.ForeColor = System.Drawing.Color.Salmon;
            this.btn_cancelar.Location = new System.Drawing.Point(19, 82);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_confirmar_camp
            // 
            this.btn_confirmar_camp.BackColor = System.Drawing.Color.Transparent;
            this.btn_confirmar_camp.FlatAppearance.BorderSize = 0;
            this.btn_confirmar_camp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.btn_confirmar_camp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.btn_confirmar_camp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar_camp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_confirmar_camp.Location = new System.Drawing.Point(233, 82);
            this.btn_confirmar_camp.Name = "btn_confirmar_camp";
            this.btn_confirmar_camp.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmar_camp.TabIndex = 2;
            this.btn_confirmar_camp.Text = "Confirmar";
            this.btn_confirmar_camp.UseVisualStyleBackColor = false;
            this.btn_confirmar_camp.Click += new System.EventHandler(this.btn_confirmar_camp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da campanha:";
            // 
            // txt_nome_campanha
            // 
            this.txt_nome_campanha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.txt_nome_campanha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nome_campanha.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt_nome_campanha.Location = new System.Drawing.Point(19, 31);
            this.txt_nome_campanha.Name = "txt_nome_campanha";
            this.txt_nome_campanha.Size = new System.Drawing.Size(289, 23);
            this.txt_nome_campanha.TabIndex = 0;
            // 
            // data_grid_pers_camp
            // 
            this.data_grid_pers_camp.AllowUserToAddRows = false;
            this.data_grid_pers_camp.AllowUserToDeleteRows = false;
            this.data_grid_pers_camp.AllowUserToOrderColumns = true;
            this.data_grid_pers_camp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_grid_pers_camp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.data_grid_pers_camp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.data_grid_pers_camp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_grid_pers_camp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_grid_pers_camp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid_pers_camp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_grid_pers_camp.ColumnHeadersHeight = 30;
            this.data_grid_pers_camp.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_grid_pers_camp.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_grid_pers_camp.EnableHeadersVisualStyles = false;
            this.data_grid_pers_camp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.data_grid_pers_camp.Location = new System.Drawing.Point(3, 0);
            this.data_grid_pers_camp.MultiSelect = false;
            this.data_grid_pers_camp.Name = "data_grid_pers_camp";
            this.data_grid_pers_camp.ReadOnly = true;
            this.data_grid_pers_camp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid_pers_camp.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data_grid_pers_camp.RowTemplate.Height = 10;
            this.data_grid_pers_camp.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid_pers_camp.Size = new System.Drawing.Size(445, 614);
            this.data_grid_pers_camp.TabIndex = 4;
            this.data_grid_pers_camp.VirtualMode = true;
            this.data_grid_pers_camp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_pers_camp_CellClick);
            this.data_grid_pers_camp.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_grid_pers_camp_ColumnHeaderMouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.data_grid_campanha);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 611);
            this.panel2.TabIndex = 0;
            // 
            // data_grid_campanha
            // 
            this.data_grid_campanha.AllowUserToAddRows = false;
            this.data_grid_campanha.AllowUserToDeleteRows = false;
            this.data_grid_campanha.AllowUserToOrderColumns = true;
            this.data_grid_campanha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_grid_campanha.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.data_grid_campanha.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.data_grid_campanha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_grid_campanha.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_grid_campanha.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid_campanha.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.data_grid_campanha.ColumnHeadersHeight = 30;
            this.data_grid_campanha.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_grid_campanha.DefaultCellStyle = dataGridViewCellStyle5;
            this.data_grid_campanha.EnableHeadersVisualStyles = false;
            this.data_grid_campanha.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.data_grid_campanha.Location = new System.Drawing.Point(0, 0);
            this.data_grid_campanha.MultiSelect = false;
            this.data_grid_campanha.Name = "data_grid_campanha";
            this.data_grid_campanha.ReadOnly = true;
            this.data_grid_campanha.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid_campanha.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.data_grid_campanha.RowTemplate.Height = 10;
            this.data_grid_campanha.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid_campanha.Size = new System.Drawing.Size(450, 611);
            this.data_grid_campanha.TabIndex = 3;
            this.data_grid_campanha.VirtualMode = true;
            this.data_grid_campanha.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_campanha_CellClick);
            this.data_grid_campanha.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_campanha_CellEnter);
            this.data_grid_campanha.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_grid_campanha_ColumnHeaderMouseClick);
            // 
            // lbl_fechar
            // 
            this.lbl_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fechar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_fechar.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_fechar.ForeColor = System.Drawing.Color.White;
            this.lbl_fechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_fechar.Location = new System.Drawing.Point(1220, 8);
            this.lbl_fechar.Name = "lbl_fechar";
            this.lbl_fechar.Size = new System.Drawing.Size(42, 40);
            this.lbl_fechar.TabIndex = 86;
            this.lbl_fechar.Text = "X";
            this.lbl_fechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_fechar.Click += new System.EventHandler(this.lbl_fechar_Click);
            // 
            // lbl_bvd
            // 
            this.lbl_bvd.AutoSize = true;
            this.lbl_bvd.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_bvd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_bvd.Location = new System.Drawing.Point(15, 14);
            this.lbl_bvd.Name = "lbl_bvd";
            this.lbl_bvd.Size = new System.Drawing.Size(443, 32);
            this.lbl_bvd.TabIndex = 4;
            this.lbl_bvd.Text = "Seja Bem-Vindo(a) a tela de campanhas,";
            // 
            // Campanha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1275, 686);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_bvd);
            this.Controls.Add(this.lbl_fechar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Campanha";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Campanha";
            this.Load += new System.EventHandler(this.Campanha_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Campanha_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnl_nome_campanha.ResumeLayout(false);
            this.pnl_nome_campanha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_pers_camp)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_campanha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_criar_novo;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_nova_campanha;
        private System.Windows.Forms.Panel pnl_nome_campanha;
        private System.Windows.Forms.TextBox txt_nome_campanha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_confirmar_camp;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_fechar;
        private System.Windows.Forms.Button btn_entrar_mestre;
        public System.Windows.Forms.DataGridView data_grid_campanha;
        public System.Windows.Forms.DataGridView data_grid_pers_camp;
        private FontAwesome.Sharp.IconButton btn_eliminar;
        private FontAwesome.Sharp.IconButton btn_eliminar_campanha;
        private System.Windows.Forms.Label lbl_bvd;
    }
}