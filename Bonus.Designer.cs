namespace Dark_Age
{
    partial class Bonus
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            iconButton_Combinar = new FontAwesome.Sharp.IconButton();
            panel1 = new System.Windows.Forms.Panel();
            iconButton_Add_bonus = new FontAwesome.Sharp.IconButton();
            checkBox_Tipo = new System.Windows.Forms.CheckBox();
            comboBox_Tipo_bonus = new System.Windows.Forms.ComboBox();
            numericUpDown_Valor_bonus = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            checkBox_Itens = new System.Windows.Forms.CheckBox();
            dataGrid_Itens = new System.Windows.Forms.DataGridView();
            dataGrid_Bonus = new System.Windows.Forms.DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            iconButton_Add_bonus_pers = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Valor_bonus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Itens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Bonus).BeginInit();
            SuspendLayout();
            // 
            // iconButton_Combinar
            // 
            iconButton_Combinar.BackColor = System.Drawing.Color.FromArgb(18, 18, 27);
            iconButton_Combinar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton_Combinar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            iconButton_Combinar.ForeColor = System.Drawing.SystemColors.ControlDark;
            iconButton_Combinar.IconChar = FontAwesome.Sharp.IconChar.ArrowsToCircle;
            iconButton_Combinar.IconColor = System.Drawing.Color.White;
            iconButton_Combinar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_Combinar.Location = new System.Drawing.Point(452, 112);
            iconButton_Combinar.Name = "iconButton_Combinar";
            iconButton_Combinar.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            iconButton_Combinar.Size = new System.Drawing.Size(96, 72);
            iconButton_Combinar.TabIndex = 2;
            iconButton_Combinar.Text = "Combinar";
            iconButton_Combinar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            iconButton_Combinar.UseVisualStyleBackColor = false;
            iconButton_Combinar.Click += iconButton_Combinar_Click;
            iconButton_Combinar.MouseEnter += iconButton_Combinar_MouseEnter;
            iconButton_Combinar.MouseLeave += iconButton_Combinar_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(18, 18, 27);
            panel1.Controls.Add(iconButton_Add_bonus);
            panel1.Controls.Add(checkBox_Tipo);
            panel1.Controls.Add(comboBox_Tipo_bonus);
            panel1.Controls.Add(numericUpDown_Valor_bonus);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(588, 290);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(280, 144);
            panel1.TabIndex = 3;
            // 
            // iconButton_Add_bonus
            // 
            iconButton_Add_bonus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton_Add_bonus.ForeColor = System.Drawing.SystemColors.ControlDark;
            iconButton_Add_bonus.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            iconButton_Add_bonus.IconColor = System.Drawing.Color.White;
            iconButton_Add_bonus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_Add_bonus.IconSize = 35;
            iconButton_Add_bonus.Location = new System.Drawing.Point(238, 108);
            iconButton_Add_bonus.Name = "iconButton_Add_bonus";
            iconButton_Add_bonus.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            iconButton_Add_bonus.Size = new System.Drawing.Size(39, 33);
            iconButton_Add_bonus.TabIndex = 4;
            iconButton_Add_bonus.UseVisualStyleBackColor = true;
            iconButton_Add_bonus.Click += iconButton_Add_bonus_Click;
            iconButton_Add_bonus.MouseEnter += iconButton_Add_bonus_MouseEnter;
            iconButton_Add_bonus.MouseLeave += iconButton_Add_bonus_MouseLeave;
            // 
            // checkBox_Tipo
            // 
            checkBox_Tipo.AutoSize = true;
            checkBox_Tipo.Checked = true;
            checkBox_Tipo.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox_Tipo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            checkBox_Tipo.Location = new System.Drawing.Point(194, 62);
            checkBox_Tipo.Name = "checkBox_Tipo";
            checkBox_Tipo.Size = new System.Drawing.Size(70, 19);
            checkBox_Tipo.TabIndex = 3;
            checkBox_Tipo.Text = "Atributo";
            checkBox_Tipo.UseVisualStyleBackColor = true;
            checkBox_Tipo.CheckedChanged += checkBox_Tipo_CheckedChanged;
            // 
            // comboBox_Tipo_bonus
            // 
            comboBox_Tipo_bonus.FormattingEnabled = true;
            comboBox_Tipo_bonus.Location = new System.Drawing.Point(67, 58);
            comboBox_Tipo_bonus.Name = "comboBox_Tipo_bonus";
            comboBox_Tipo_bonus.Size = new System.Drawing.Size(121, 23);
            comboBox_Tipo_bonus.TabIndex = 2;
            // 
            // numericUpDown_Valor_bonus
            // 
            numericUpDown_Valor_bonus.Location = new System.Drawing.Point(28, 58);
            numericUpDown_Valor_bonus.Name = "numericUpDown_Valor_bonus";
            numericUpDown_Valor_bonus.Size = new System.Drawing.Size(33, 23);
            numericUpDown_Valor_bonus.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(135, 21);
            label1.TabIndex = 0;
            label1.Text = "Adicionar Bônus";
            // 
            // checkBox_Itens
            // 
            checkBox_Itens.AutoSize = true;
            checkBox_Itens.Checked = true;
            checkBox_Itens.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox_Itens.ForeColor = System.Drawing.SystemColors.ControlLight;
            checkBox_Itens.Location = new System.Drawing.Point(12, 290);
            checkBox_Itens.Name = "checkBox_Itens";
            checkBox_Itens.Size = new System.Drawing.Size(81, 19);
            checkBox_Itens.TabIndex = 5;
            checkBox_Itens.Text = "Equipados";
            checkBox_Itens.UseVisualStyleBackColor = true;
            checkBox_Itens.CheckedChanged += checkBox_Itens_CheckedChanged;
            // 
            // dataGrid_Itens
            // 
            dataGrid_Itens.AllowUserToAddRows = false;
            dataGrid_Itens.AllowUserToDeleteRows = false;
            dataGrid_Itens.AllowUserToOrderColumns = true;
            dataGrid_Itens.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGrid_Itens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Itens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGrid_Itens.BackgroundColor = System.Drawing.Color.FromArgb(10, 16, 20);
            dataGrid_Itens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGrid_Itens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGrid_Itens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(130, 146, 182);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(110, 126, 162);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGrid_Itens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid_Itens.ColumnHeadersHeight = 30;
            dataGrid_Itens.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(130, 146, 182);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(110, 126, 162);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGrid_Itens.DefaultCellStyle = dataGridViewCellStyle2;
            dataGrid_Itens.EnableHeadersVisualStyles = false;
            dataGrid_Itens.GridColor = System.Drawing.Color.FromArgb(18, 18, 27);
            dataGrid_Itens.Location = new System.Drawing.Point(12, 12);
            dataGrid_Itens.MultiSelect = false;
            dataGrid_Itens.Name = "dataGrid_Itens";
            dataGrid_Itens.ReadOnly = true;
            dataGrid_Itens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(130, 146, 182);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(110, 126, 162);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGrid_Itens.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGrid_Itens.RowTemplate.Height = 10;
            dataGrid_Itens.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dataGrid_Itens.ScrollBars = System.Windows.Forms.ScrollBars.None;
            dataGrid_Itens.Size = new System.Drawing.Size(400, 272);
            dataGrid_Itens.TabIndex = 98;
            dataGrid_Itens.VirtualMode = true;
            dataGrid_Itens.CellClick += dataGrid_Itens_CellClick;
            dataGrid_Itens.ColumnHeaderMouseClick += dataGrid_Itens_ColumnHeaderMouseClick;
            // 
            // dataGrid_Bonus
            // 
            dataGrid_Bonus.AllowUserToAddRows = false;
            dataGrid_Bonus.AllowUserToDeleteRows = false;
            dataGrid_Bonus.AllowUserToOrderColumns = true;
            dataGrid_Bonus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGrid_Bonus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Bonus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGrid_Bonus.BackgroundColor = System.Drawing.Color.FromArgb(10, 16, 20);
            dataGrid_Bonus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGrid_Bonus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGrid_Bonus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(130, 146, 182);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(110, 126, 162);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGrid_Bonus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGrid_Bonus.ColumnHeadersHeight = 30;
            dataGrid_Bonus.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(130, 146, 182);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(110, 126, 162);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGrid_Bonus.DefaultCellStyle = dataGridViewCellStyle5;
            dataGrid_Bonus.EnableHeadersVisualStyles = false;
            dataGrid_Bonus.GridColor = System.Drawing.Color.FromArgb(18, 18, 27);
            dataGrid_Bonus.Location = new System.Drawing.Point(588, 12);
            dataGrid_Bonus.MultiSelect = false;
            dataGrid_Bonus.Name = "dataGrid_Bonus";
            dataGrid_Bonus.ReadOnly = true;
            dataGrid_Bonus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(130, 146, 182);
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(110, 126, 162);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGrid_Bonus.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGrid_Bonus.RowTemplate.Height = 10;
            dataGrid_Bonus.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dataGrid_Bonus.Size = new System.Drawing.Size(400, 272);
            dataGrid_Bonus.TabIndex = 99;
            dataGrid_Bonus.VirtualMode = true;
            dataGrid_Bonus.CellClick += dataGrid_Bonus_CellClick;
            dataGrid_Bonus.ColumnHeaderMouseClick += dataGrid_Bonus_ColumnHeaderMouseClick;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // iconButton_Add_bonus_pers
            // 
            iconButton_Add_bonus_pers.BackColor = System.Drawing.Color.FromArgb(18, 18, 27);
            iconButton_Add_bonus_pers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton_Add_bonus_pers.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            iconButton_Add_bonus_pers.ForeColor = System.Drawing.SystemColors.ControlDark;
            iconButton_Add_bonus_pers.IconChar = FontAwesome.Sharp.IconChar.LongArrowDown;
            iconButton_Add_bonus_pers.IconColor = System.Drawing.Color.White;
            iconButton_Add_bonus_pers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_Add_bonus_pers.IconSize = 60;
            iconButton_Add_bonus_pers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            iconButton_Add_bonus_pers.Location = new System.Drawing.Point(874, 290);
            iconButton_Add_bonus_pers.Name = "iconButton_Add_bonus_pers";
            iconButton_Add_bonus_pers.Size = new System.Drawing.Size(114, 141);
            iconButton_Add_bonus_pers.TabIndex = 100;
            iconButton_Add_bonus_pers.Text = "Adicionar Bônus ao Personagem";
            iconButton_Add_bonus_pers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            iconButton_Add_bonus_pers.UseVisualStyleBackColor = false;
            iconButton_Add_bonus_pers.Click += iconButton_Add_bonus_pers_Click;
            iconButton_Add_bonus_pers.MouseEnter += iconButton_Add_bonus_MouseEnter;
            iconButton_Add_bonus_pers.MouseLeave += iconButton_Add_bonus_MouseLeave;
            // 
            // Bonus
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(10, 16, 20);
            ClientSize = new System.Drawing.Size(1000, 446);
            Controls.Add(iconButton_Add_bonus_pers);
            Controls.Add(checkBox_Itens);
            Controls.Add(panel1);
            Controls.Add(iconButton_Combinar);
            Controls.Add(dataGrid_Itens);
            Controls.Add(dataGrid_Bonus);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Bonus";
            Text = "Bonus";
            Load += Bonus_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Valor_bonus).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Itens).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Bonus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton_Combinar;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton_Add_bonus;
        private System.Windows.Forms.CheckBox checkBox_Tipo;
        private System.Windows.Forms.ComboBox comboBox_Tipo_bonus;
        private System.Windows.Forms.NumericUpDown numericUpDown_Valor_bonus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_Itens;
        public System.Windows.Forms.DataGridView dataGrid_Itens;
        public System.Windows.Forms.DataGridView dataGrid_Bonus;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton iconButton_Add_bonus_pers;
    }
}