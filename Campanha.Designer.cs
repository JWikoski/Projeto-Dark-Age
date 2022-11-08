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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_entrar_mestre = new System.Windows.Forms.Button();
            this.btn_eliminar_campanha = new System.Windows.Forms.Button();
            this.btn_nova_campanha = new System.Windows.Forms.Button();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.btn_criar_novo = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.data_grid_pers_camp = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.data_grid_campanha = new System.Windows.Forms.DataGridView();
            this.pnl_nome_campanha = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_confirmar_camp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome_campanha = new System.Windows.Forms.TextBox();
            this.lbl_fechar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_pers_camp)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_campanha)).BeginInit();
            this.pnl_nome_campanha.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 426);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_entrar_mestre);
            this.panel4.Controls.Add(this.btn_eliminar_campanha);
            this.panel4.Controls.Add(this.btn_nova_campanha);
            this.panel4.Controls.Add(this.btn_entrar);
            this.panel4.Controls.Add(this.btn_criar_novo);
            this.panel4.Controls.Add(this.btn_eliminar);
            this.panel4.Location = new System.Drawing.Point(556, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(176, 423);
            this.panel4.TabIndex = 2;
            // 
            // btn_entrar_mestre
            // 
            this.btn_entrar_mestre.Location = new System.Drawing.Point(20, 148);
            this.btn_entrar_mestre.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btn_entrar_mestre.Name = "btn_entrar_mestre";
            this.btn_entrar_mestre.Size = new System.Drawing.Size(138, 49);
            this.btn_entrar_mestre.TabIndex = 7;
            this.btn_entrar_mestre.Text = "Tela do Mestre - Entrar";
            this.btn_entrar_mestre.UseVisualStyleBackColor = true;
            this.btn_entrar_mestre.Visible = false;
            this.btn_entrar_mestre.Click += new System.EventHandler(this.btn_entrar_mestre_Click);
            // 
            // btn_eliminar_campanha
            // 
            this.btn_eliminar_campanha.Location = new System.Drawing.Point(20, 79);
            this.btn_eliminar_campanha.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btn_eliminar_campanha.Name = "btn_eliminar_campanha";
            this.btn_eliminar_campanha.Size = new System.Drawing.Size(138, 49);
            this.btn_eliminar_campanha.TabIndex = 6;
            this.btn_eliminar_campanha.Text = "Eliminar Campanha";
            this.btn_eliminar_campanha.UseVisualStyleBackColor = true;
            this.btn_eliminar_campanha.Click += new System.EventHandler(this.btn_eliminar_campanha_Click);
            // 
            // btn_nova_campanha
            // 
            this.btn_nova_campanha.Location = new System.Drawing.Point(20, 10);
            this.btn_nova_campanha.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btn_nova_campanha.Name = "btn_nova_campanha";
            this.btn_nova_campanha.Size = new System.Drawing.Size(138, 49);
            this.btn_nova_campanha.TabIndex = 5;
            this.btn_nova_campanha.Text = "Nova Campanha";
            this.btn_nova_campanha.UseVisualStyleBackColor = true;
            this.btn_nova_campanha.Click += new System.EventHandler(this.btn_nova_campanha_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(20, 364);
            this.btn_entrar.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(138, 49);
            this.btn_entrar.TabIndex = 4;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // btn_criar_novo
            // 
            this.btn_criar_novo.Location = new System.Drawing.Point(20, 226);
            this.btn_criar_novo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btn_criar_novo.Name = "btn_criar_novo";
            this.btn_criar_novo.Size = new System.Drawing.Size(138, 49);
            this.btn_criar_novo.TabIndex = 2;
            this.btn_criar_novo.Text = "Novo personagem";
            this.btn_criar_novo.UseVisualStyleBackColor = true;
            this.btn_criar_novo.Click += new System.EventHandler(this.btn_criar_novo_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(20, 295);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(138, 49);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Text = "Eliminar personagem";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.data_grid_pers_camp);
            this.panel3.Location = new System.Drawing.Point(274, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 423);
            this.panel3.TabIndex = 1;
            // 
            // data_grid_pers_camp
            // 
            this.data_grid_pers_camp.AllowUserToAddRows = false;
            this.data_grid_pers_camp.AllowUserToDeleteRows = false;
            this.data_grid_pers_camp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_grid_pers_camp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_pers_camp.Location = new System.Drawing.Point(0, 0);
            this.data_grid_pers_camp.Name = "data_grid_pers_camp";
            this.data_grid_pers_camp.ReadOnly = true;
            this.data_grid_pers_camp.RowTemplate.Height = 25;
            this.data_grid_pers_camp.Size = new System.Drawing.Size(276, 423);
            this.data_grid_pers_camp.TabIndex = 0;
            this.data_grid_pers_camp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_pers_camp_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.data_grid_campanha);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 423);
            this.panel2.TabIndex = 0;
            // 
            // data_grid_campanha
            // 
            this.data_grid_campanha.AllowUserToAddRows = false;
            this.data_grid_campanha.AllowUserToDeleteRows = false;
            this.data_grid_campanha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_grid_campanha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_campanha.Location = new System.Drawing.Point(0, 0);
            this.data_grid_campanha.Name = "data_grid_campanha";
            this.data_grid_campanha.ReadOnly = true;
            this.data_grid_campanha.RowTemplate.Height = 25;
            this.data_grid_campanha.Size = new System.Drawing.Size(267, 423);
            this.data_grid_campanha.TabIndex = 0;
            this.data_grid_campanha.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_campanha_CellClick);
            this.data_grid_campanha.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_campanha_CellContentClick);
            this.data_grid_campanha.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_campanha_CellEnter);
            this.data_grid_campanha.SelectionChanged += new System.EventHandler(this.data_grid_campanha_SelectionChanged);
            // 
            // pnl_nome_campanha
            // 
            this.pnl_nome_campanha.Controls.Add(this.btn_cancelar);
            this.pnl_nome_campanha.Controls.Add(this.btn_confirmar_camp);
            this.pnl_nome_campanha.Controls.Add(this.label1);
            this.pnl_nome_campanha.Controls.Add(this.txt_nome_campanha);
            this.pnl_nome_campanha.Location = new System.Drawing.Point(125, 160);
            this.pnl_nome_campanha.Name = "pnl_nome_campanha";
            this.pnl_nome_campanha.Size = new System.Drawing.Size(329, 117);
            this.pnl_nome_campanha.TabIndex = 7;
            this.pnl_nome_campanha.Visible = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(115, 82);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_confirmar_camp
            // 
            this.btn_confirmar_camp.Location = new System.Drawing.Point(233, 82);
            this.btn_confirmar_camp.Name = "btn_confirmar_camp";
            this.btn_confirmar_camp.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmar_camp.TabIndex = 2;
            this.btn_confirmar_camp.Text = "Confirmar";
            this.btn_confirmar_camp.UseVisualStyleBackColor = true;
            this.btn_confirmar_camp.Click += new System.EventHandler(this.btn_confirmar_camp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da campanha:";
            // 
            // txt_nome_campanha
            // 
            this.txt_nome_campanha.Location = new System.Drawing.Point(19, 31);
            this.txt_nome_campanha.Name = "txt_nome_campanha";
            this.txt_nome_campanha.Size = new System.Drawing.Size(289, 23);
            this.txt_nome_campanha.TabIndex = 0;
            // 
            // lbl_fechar
            // 
            this.lbl_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fechar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_fechar.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_fechar.ForeColor = System.Drawing.Color.White;
            this.lbl_fechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_fechar.Location = new System.Drawing.Point(702, 9);
            this.lbl_fechar.Name = "lbl_fechar";
            this.lbl_fechar.Size = new System.Drawing.Size(42, 40);
            this.lbl_fechar.TabIndex = 86;
            this.lbl_fechar.Text = "X";
            this.lbl_fechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_fechar.Click += new System.EventHandler(this.lbl_fechar_Click);
            // 
            // Campanha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 495);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_fechar);
            this.Controls.Add(this.pnl_nome_campanha);
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
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_pers_camp)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_campanha)).EndInit();
            this.pnl_nome_campanha.ResumeLayout(false);
            this.pnl_nome_campanha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_criar_novo;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView data_grid_campanha;
        private System.Windows.Forms.DataGridView data_grid_pers_camp;
        private System.Windows.Forms.Button btn_eliminar_campanha;
        private System.Windows.Forms.Button btn_nova_campanha;
        private System.Windows.Forms.Panel pnl_nome_campanha;
        private System.Windows.Forms.TextBox txt_nome_campanha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_confirmar_camp;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_fechar;
        private System.Windows.Forms.Button btn_entrar_mestre;
    }
}