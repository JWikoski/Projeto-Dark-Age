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
            this.btn_entrar = new System.Windows.Forms.Button();
            this.btn_criar_novo = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.data_grid_pers_camp = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.data_grid_campanha = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 426);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_entrar);
            this.panel4.Controls.Add(this.btn_criar_novo);
            this.panel4.Controls.Add(this.btn_eliminar);
            this.panel4.Location = new System.Drawing.Point(556, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(176, 423);
            this.panel4.TabIndex = 2;
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(20, 349);
            this.btn_entrar.Margin = new System.Windows.Forms.Padding(3, 10, 3, 25);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(138, 49);
            this.btn_entrar.TabIndex = 4;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // btn_criar_novo
            // 
            this.btn_criar_novo.Location = new System.Drawing.Point(20, 20);
            this.btn_criar_novo.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.btn_criar_novo.Name = "btn_criar_novo";
            this.btn_criar_novo.Size = new System.Drawing.Size(138, 49);
            this.btn_criar_novo.TabIndex = 2;
            this.btn_criar_novo.Text = "Novo personagem";
            this.btn_criar_novo.UseVisualStyleBackColor = true;
            this.btn_criar_novo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(20, 177);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(138, 49);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Text = "Eliminar personagem";
            this.btn_eliminar.UseVisualStyleBackColor = true;
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
            this.data_grid_pers_camp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_pers_camp.Location = new System.Drawing.Point(0, 0);
            this.data_grid_pers_camp.Name = "data_grid_pers_camp";
            this.data_grid_pers_camp.RowTemplate.Height = 25;
            this.data_grid_pers_camp.Size = new System.Drawing.Size(268, 423);
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
            this.data_grid_campanha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_campanha.Location = new System.Drawing.Point(0, 0);
            this.data_grid_campanha.Name = "data_grid_campanha";
            this.data_grid_campanha.RowTemplate.Height = 25;
            this.data_grid_campanha.Size = new System.Drawing.Size(267, 423);
            this.data_grid_campanha.TabIndex = 0;
            this.data_grid_campanha.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_campanha_CellClick);
            // 
            // Campanha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Campanha";
            this.Text = "Campanha";
            this.Load += new System.EventHandler(this.Campanha_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_pers_camp)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_campanha)).EndInit();
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
    }
}