
namespace Dark_Age.Componente
{
    partial class painel_habilidade
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.titulo_hab = new System.Windows.Forms.Label();
            this.custo_tipo = new FontAwesome.Sharp.IconButton();
            this.custo_extra = new System.Windows.Forms.Label();
            this.btn_usar = new System.Windows.Forms.Button();
            this.pnl_hab = new System.Windows.Forms.Panel();
            this.armazena_tipo = new System.Windows.Forms.Label();
            this.armazena_custo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titulo_hab
            // 
            this.titulo_hab.AutoSize = true;
            this.titulo_hab.BackColor = System.Drawing.Color.Transparent;
            this.titulo_hab.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titulo_hab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(167)))), ((int)(((byte)(110)))));
            this.titulo_hab.Location = new System.Drawing.Point(12, 2);
            this.titulo_hab.Name = "titulo_hab";
            this.titulo_hab.Size = new System.Drawing.Size(0, 31);
            this.titulo_hab.TabIndex = 0;
            // 
            // custo_tipo
            // 
            this.custo_tipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.custo_tipo.BackColor = System.Drawing.Color.Transparent;
            this.custo_tipo.FlatAppearance.BorderSize = 0;
            this.custo_tipo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.custo_tipo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.custo_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custo_tipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.custo_tipo.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.custo_tipo.IconChar = FontAwesome.Sharp.IconChar.Droplet;
            this.custo_tipo.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.custo_tipo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.custo_tipo.IconSize = 20;
            this.custo_tipo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.custo_tipo.Location = new System.Drawing.Point(321, 0);
            this.custo_tipo.Name = "custo_tipo";
            this.custo_tipo.Size = new System.Drawing.Size(163, 28);
            this.custo_tipo.TabIndex = 6;
            this.custo_tipo.Text = "2 Pontos Fracos";
            this.custo_tipo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.custo_tipo.UseVisualStyleBackColor = false;
            // 
            // custo_extra
            // 
            this.custo_extra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.custo_extra.BackColor = System.Drawing.Color.Transparent;
            this.custo_extra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.custo_extra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(167)))), ((int)(((byte)(110)))));
            this.custo_extra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.custo_extra.Location = new System.Drawing.Point(321, 26);
            this.custo_extra.Name = "custo_extra";
            this.custo_extra.Size = new System.Drawing.Size(163, 14);
            this.custo_extra.TabIndex = 8;
            this.custo_extra.Text = "+ Exaustão";
            this.custo_extra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_usar
            // 
            this.btn_usar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_usar.FlatAppearance.BorderSize = 0;
            this.btn_usar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_usar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_usar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_usar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(155)))), ((int)(((byte)(140)))));
            this.btn_usar.Location = new System.Drawing.Point(508, -3);
            this.btn_usar.Name = "btn_usar";
            this.btn_usar.Size = new System.Drawing.Size(62, 34);
            this.btn_usar.TabIndex = 9;
            this.btn_usar.Text = "Usar";
            this.btn_usar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_usar.UseVisualStyleBackColor = true;
            this.btn_usar.Visible = false;
            this.btn_usar.Click += new System.EventHandler(this.btn_usar_Click);
            this.btn_usar.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.btn_usar.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.btn_usar.MouseHover += new System.EventHandler(this.button1_MouseEnter);
            // 
            // pnl_hab
            // 
            this.pnl_hab.AutoScroll = true;
            this.pnl_hab.AutoSize = true;
            this.pnl_hab.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnl_hab.Location = new System.Drawing.Point(2, 43);
            this.pnl_hab.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.pnl_hab.MaximumSize = new System.Drawing.Size(570, 200);
            this.pnl_hab.Name = "pnl_hab";
            this.pnl_hab.Size = new System.Drawing.Size(570, 96);
            this.pnl_hab.TabIndex = 10;
            // 
            // armazena_tipo
            // 
            this.armazena_tipo.AutoSize = true;
            this.armazena_tipo.Location = new System.Drawing.Point(150, -2);
            this.armazena_tipo.Name = "armazena_tipo";
            this.armazena_tipo.Size = new System.Drawing.Size(0, 15);
            this.armazena_tipo.TabIndex = 11;
            this.armazena_tipo.Visible = false;
            // 
            // armazena_custo
            // 
            this.armazena_custo.AutoSize = true;
            this.armazena_custo.Location = new System.Drawing.Point(170, 23);
            this.armazena_custo.Name = "armazena_custo";
            this.armazena_custo.Size = new System.Drawing.Size(0, 15);
            this.armazena_custo.TabIndex = 12;
            this.armazena_custo.Visible = false;
            // 
            // painel_habilidade
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.armazena_custo);
            this.Controls.Add(this.armazena_tipo);
            this.Controls.Add(this.pnl_hab);
            this.Controls.Add(this.btn_usar);
            this.Controls.Add(this.custo_extra);
            this.Controls.Add(this.custo_tipo);
            this.Controls.Add(this.titulo_hab);
            this.MaximumSize = new System.Drawing.Size(570, 1600);
            this.Name = "painel_habilidade";
            this.Size = new System.Drawing.Size(570, 164);
            this.Load += new System.EventHandler(this.painel_habilidade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo_hab;
        private FontAwesome.Sharp.IconButton custo_tipo;
        private System.Windows.Forms.Label custo_extra;
        private System.Windows.Forms.Button btn_usar;
        private System.Windows.Forms.Panel pnl_hab;
        private System.Windows.Forms.Label armazena_tipo;
        private System.Windows.Forms.Label armazena_custo;
    }
}
