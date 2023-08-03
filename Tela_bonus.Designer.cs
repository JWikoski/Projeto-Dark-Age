namespace Dark_Age
{
    partial class Tela_bonus
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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel1 = new System.Windows.Forms.Panel();
            iconButton_Remover_bonus_pers = new FontAwesome.Sharp.IconButton();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            dataGrid_bonus_pers_ativos = new System.Windows.Forms.DataGridView();
            dataGrid_bonus_ativos = new System.Windows.Forms.DataGridView();
            Abrir_bonus = new FontAwesome.Sharp.IconButton();
            panel2 = new System.Windows.Forms.Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_bonus_pers_ativos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_bonus_ativos).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // iconButton1
            // 
            iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButton1.IconColor = System.Drawing.Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 25;
            iconButton1.Location = new System.Drawing.Point(984, 12);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            iconButton1.Size = new System.Drawing.Size(28, 28);
            iconButton1.TabIndex = 0;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            iconButton1.MouseEnter += Abrir_bonus_MouseEnter;
            iconButton1.MouseLeave += Abrir_bonus_MouseLeave;
            // 
            // iconButton2
            // 
            iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            iconButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltUp;
            iconButton2.IconColor = System.Drawing.Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 40;
            iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            iconButton2.Location = new System.Drawing.Point(12, 12);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new System.Drawing.Size(127, 59);
            iconButton2.TabIndex = 1;
            iconButton2.Text = "Bônus";
            iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.Controls.Add(iconButton_Remover_bonus_pers);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGrid_bonus_pers_ativos);
            panel1.Controls.Add(dataGrid_bonus_ativos);
            panel1.Location = new System.Drawing.Point(12, 77);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1000, 597);
            panel1.TabIndex = 2;
            // 
            // iconButton_Remover_bonus_pers
            // 
            iconButton_Remover_bonus_pers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton_Remover_bonus_pers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            iconButton_Remover_bonus_pers.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButton_Remover_bonus_pers.IconColor = System.Drawing.Color.White;
            iconButton_Remover_bonus_pers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_Remover_bonus_pers.Location = new System.Drawing.Point(957, 525);
            iconButton_Remover_bonus_pers.Name = "iconButton_Remover_bonus_pers";
            iconButton_Remover_bonus_pers.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            iconButton_Remover_bonus_pers.Size = new System.Drawing.Size(39, 59);
            iconButton_Remover_bonus_pers.TabIndex = 4;
            iconButton_Remover_bonus_pers.UseVisualStyleBackColor = true;
            iconButton_Remover_bonus_pers.Click += iconButton_Remover_bonus_pers_Click;
            iconButton_Remover_bonus_pers.MouseEnter += Abrir_bonus_MouseEnter;
            iconButton_Remover_bonus_pers.MouseLeave += Abrir_bonus_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            label2.Location = new System.Drawing.Point(48, 317);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(227, 28);
            label2.TabIndex = 3;
            label2.Text = "Bônus do personagem:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            label1.Location = new System.Drawing.Point(48, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(269, 28);
            label1.TabIndex = 2;
            label1.Text = "Bônus dos itens equipados:";
            // 
            // dataGrid_bonus_pers_ativos
            // 
            dataGrid_bonus_pers_ativos.AllowUserToAddRows = false;
            dataGrid_bonus_pers_ativos.AllowUserToDeleteRows = false;
            dataGrid_bonus_pers_ativos.AllowUserToResizeColumns = false;
            dataGrid_bonus_pers_ativos.AllowUserToResizeRows = false;
            dataGrid_bonus_pers_ativos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_bonus_pers_ativos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGrid_bonus_pers_ativos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGrid_bonus_pers_ativos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGrid_bonus_pers_ativos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(28, 28, 37);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(48, 48, 57);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGrid_bonus_pers_ativos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid_bonus_pers_ativos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(18, 18, 27);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(48, 48, 57);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGrid_bonus_pers_ativos.DefaultCellStyle = dataGridViewCellStyle2;
            dataGrid_bonus_pers_ativos.EnableHeadersVisualStyles = false;
            dataGrid_bonus_pers_ativos.Location = new System.Drawing.Point(48, 348);
            dataGrid_bonus_pers_ativos.Name = "dataGrid_bonus_pers_ativos";
            dataGrid_bonus_pers_ativos.ReadOnly = true;
            dataGrid_bonus_pers_ativos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGrid_bonus_pers_ativos.RowTemplate.Height = 25;
            dataGrid_bonus_pers_ativos.Size = new System.Drawing.Size(904, 236);
            dataGrid_bonus_pers_ativos.TabIndex = 1;
            dataGrid_bonus_pers_ativos.CellClick += dataGrid_bonus_pers_ativos_CellClick;
            dataGrid_bonus_pers_ativos.ColumnHeaderMouseClick += dataGrid_bonus_pers_ativos_ColumnHeaderMouseClick;
            // 
            // dataGrid_bonus_ativos
            // 
            dataGrid_bonus_ativos.AllowUserToAddRows = false;
            dataGrid_bonus_ativos.AllowUserToDeleteRows = false;
            dataGrid_bonus_ativos.AllowUserToResizeColumns = false;
            dataGrid_bonus_ativos.AllowUserToResizeRows = false;
            dataGrid_bonus_ativos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_bonus_ativos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGrid_bonus_ativos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGrid_bonus_ativos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGrid_bonus_ativos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(28, 28, 37);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(48, 48, 57);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGrid_bonus_ativos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGrid_bonus_ativos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(18, 18, 27);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(48, 48, 57);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGrid_bonus_ativos.DefaultCellStyle = dataGridViewCellStyle4;
            dataGrid_bonus_ativos.EnableHeadersVisualStyles = false;
            dataGrid_bonus_ativos.Location = new System.Drawing.Point(48, 56);
            dataGrid_bonus_ativos.Name = "dataGrid_bonus_ativos";
            dataGrid_bonus_ativos.ReadOnly = true;
            dataGrid_bonus_ativos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGrid_bonus_ativos.RowTemplate.Height = 25;
            dataGrid_bonus_ativos.Size = new System.Drawing.Size(904, 236);
            dataGrid_bonus_ativos.TabIndex = 0;
            dataGrid_bonus_ativos.CellClick += dataGrid_bonus_ativos_CellClick;
            dataGrid_bonus_ativos.ColumnHeaderMouseClick += dataGrid_bonus_ativos_ColumnHeaderMouseClick;
            // 
            // Abrir_bonus
            // 
            Abrir_bonus.Cursor = System.Windows.Forms.Cursors.Hand;
            Abrir_bonus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Abrir_bonus.IconChar = FontAwesome.Sharp.IconChar.ChevronUp;
            Abrir_bonus.IconColor = System.Drawing.Color.White;
            Abrir_bonus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Abrir_bonus.IconSize = 56;
            Abrir_bonus.Location = new System.Drawing.Point(474, 646);
            Abrir_bonus.Name = "Abrir_bonus";
            Abrir_bonus.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            Abrir_bonus.Size = new System.Drawing.Size(76, 47);
            Abrir_bonus.TabIndex = 1;
            Abrir_bonus.UseVisualStyleBackColor = true;
            Abrir_bonus.Click += Abrir_bonus_Click;
            Abrir_bonus.MouseEnter += Abrir_bonus_MouseEnter;
            Abrir_bonus.MouseLeave += Abrir_bonus_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(130, 146, 182);
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(iconButton3);
            panel2.Location = new System.Drawing.Point(12, 240);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1000, 446);
            panel2.TabIndex = 1;
            panel2.Visible = false;
            // 
            // iconButton3
            // 
            iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            iconButton3.IconColor = System.Drawing.Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 56;
            iconButton3.Location = new System.Drawing.Point(462, 0);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            iconButton3.Size = new System.Drawing.Size(76, 47);
            iconButton3.TabIndex = 2;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            iconButton3.MouseEnter += Abrir_bonus_MouseEnter;
            iconButton3.MouseLeave += Abrir_bonus_MouseLeave;
            // 
            // Tela_bonus
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(130, 146, 182);
            ClientSize = new System.Drawing.Size(1024, 686);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(Abrir_bonus);
            Controls.Add(panel1);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Tela_bonus";
            FormClosed += Tela_bonus_FormClosed;
            Load += Tela_bonus_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_bonus_pers_ativos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_bonus_ativos).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGrid_bonus_ativos;
        private FontAwesome.Sharp.IconButton Abrir_bonus;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.DataGridView dataGrid_bonus_pers_ativos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton_Remover_bonus_pers;
    }
}