
namespace Dark_Age
{
    partial class Pets
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_pet = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Grid_lista_pets = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.Status_pet = new System.Windows.Forms.Label();
            this.btn_adotar = new FontAwesome.Sharp.IconButton();
            this.adiciona_qtd = new FontAwesome.Sharp.IconButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_lista_pets)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pet
            // 
            this.btn_pet.BackColor = System.Drawing.Color.Transparent;
            this.btn_pet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_pet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pet.FlatAppearance.BorderSize = 0;
            this.btn_pet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_pet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_pet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pet.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_pet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(214)))), ((int)(((byte)(246)))));
            this.btn_pet.IconChar = FontAwesome.Sharp.IconChar.Paw;
            this.btn_pet.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(214)))), ((int)(((byte)(246)))));
            this.btn_pet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_pet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pet.Location = new System.Drawing.Point(12, 12);
            this.btn_pet.Name = "btn_pet";
            this.btn_pet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_pet.Size = new System.Drawing.Size(396, 50);
            this.btn_pet.TabIndex = 148;
            this.btn_pet.Text = "Pet\'s e Invocações";
            this.btn_pet.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(214)))), ((int)(((byte)(246)))));
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(155)))), ((int)(((byte)(140)))));
            this.panel4.Location = new System.Drawing.Point(5, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1380, 1);
            this.panel4.TabIndex = 149;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(214)))), ((int)(((byte)(246)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(155)))), ((int)(((byte)(140)))));
            this.panel1.Location = new System.Drawing.Point(932, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 600);
            this.panel1.TabIndex = 150;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // Grid_lista_pets
            // 
            this.Grid_lista_pets.AllowUserToAddRows = false;
            this.Grid_lista_pets.AllowUserToDeleteRows = false;
            this.Grid_lista_pets.AllowUserToOrderColumns = true;
            this.Grid_lista_pets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_lista_pets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Grid_lista_pets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(174)))), ((int)(((byte)(206)))));
            this.Grid_lista_pets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_lista_pets.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid_lista_pets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(174)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(10)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(184)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(10)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_lista_pets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_lista_pets.ColumnHeadersHeight = 30;
            this.Grid_lista_pets.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(174)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(10)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(184)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(10)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_lista_pets.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid_lista_pets.EnableHeadersVisualStyles = false;
            this.Grid_lista_pets.GridColor = System.Drawing.Color.Black;
            this.Grid_lista_pets.Location = new System.Drawing.Point(27, 168);
            this.Grid_lista_pets.MultiSelect = false;
            this.Grid_lista_pets.Name = "Grid_lista_pets";
            this.Grid_lista_pets.ReadOnly = true;
            this.Grid_lista_pets.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(174)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(10)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(184)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(10)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_lista_pets.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid_lista_pets.RowTemplate.Height = 30;
            this.Grid_lista_pets.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_lista_pets.Size = new System.Drawing.Size(876, 509);
            this.Grid_lista_pets.TabIndex = 152;
            this.Grid_lista_pets.VirtualMode = true;
            this.Grid_lista_pets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_lista_pets_CellClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(214)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(964, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 40);
            this.label1.TabIndex = 154;
            this.label1.Text = "Status Pet/Invocação";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(214)))), ((int)(((byte)(246)))));
            this.label2.Location = new System.Drawing.Point(27, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(876, 40);
            this.label2.TabIndex = 156;
            this.label2.Text = "Stauts Pet/Invocação";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButton4
            // 
            this.iconButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton4.BackColor = System.Drawing.Color.Transparent;
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButton4.IconColor = System.Drawing.Color.Salmon;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton4.Location = new System.Drawing.Point(1303, 12);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(45, 45);
            this.iconButton4.TabIndex = 158;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // Status_pet
            // 
            this.Status_pet.BackColor = System.Drawing.Color.Transparent;
            this.Status_pet.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Status_pet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(214)))), ((int)(((byte)(246)))));
            this.Status_pet.Location = new System.Drawing.Point(979, 168);
            this.Status_pet.Name = "Status_pet";
            this.Status_pet.Size = new System.Drawing.Size(357, 436);
            this.Status_pet.TabIndex = 159;
            // 
            // btn_adotar
            // 
            this.btn_adotar.BackColor = System.Drawing.Color.Transparent;
            this.btn_adotar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_adotar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_adotar.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.btn_adotar.FlatAppearance.BorderSize = 0;
            this.btn_adotar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_adotar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_adotar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adotar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_adotar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(168)))), ((int)(((byte)(200)))));
            this.btn_adotar.IconChar = FontAwesome.Sharp.IconChar.Cat;
            this.btn_adotar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(168)))), ((int)(((byte)(200)))));
            this.btn_adotar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_adotar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_adotar.Location = new System.Drawing.Point(979, 621);
            this.btn_adotar.Name = "btn_adotar";
            this.btn_adotar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_adotar.Size = new System.Drawing.Size(357, 50);
            this.btn_adotar.TabIndex = 160;
            this.btn_adotar.Text = "Adotar/Invocar";
            this.btn_adotar.UseVisualStyleBackColor = false;
            this.btn_adotar.Click += new System.EventHandler(this.iconButton1_Click);
            this.btn_adotar.MouseEnter += new System.EventHandler(this.iconButton1_MouseEnter);
            this.btn_adotar.MouseLeave += new System.EventHandler(this.iconButton1_MouseLeave);
            this.btn_adotar.MouseHover += new System.EventHandler(this.iconButton1_MouseEnter);
            // 
            // adiciona_qtd
            // 
            this.adiciona_qtd.AutoSize = true;
            this.adiciona_qtd.BackColor = System.Drawing.Color.Transparent;
            this.adiciona_qtd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adiciona_qtd.FlatAppearance.BorderSize = 0;
            this.adiciona_qtd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.adiciona_qtd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.adiciona_qtd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adiciona_qtd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adiciona_qtd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(214)))), ((int)(((byte)(246)))));
            this.adiciona_qtd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.adiciona_qtd.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.adiciona_qtd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.adiciona_qtd.IconSize = 30;
            this.adiciona_qtd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adiciona_qtd.Location = new System.Drawing.Point(27, 112);
            this.adiciona_qtd.Name = "adiciona_qtd";
            this.adiciona_qtd.Size = new System.Drawing.Size(130, 36);
            this.adiciona_qtd.TabIndex = 161;
            this.adiciona_qtd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adiciona_qtd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.adiciona_qtd.UseVisualStyleBackColor = false;
            this.adiciona_qtd.Click += new System.EventHandler(this.adiciona_qtd_Click);
            this.adiciona_qtd.MouseEnter += new System.EventHandler(this.adiciona_qtd_MouseEnter);
            this.adiciona_qtd.MouseLeave += new System.EventHandler(this.adiciona_qtd_MouseLeave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(214)))), ((int)(((byte)(246)))));
            this.checkBox1.Location = new System.Drawing.Point(713, 125);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(190, 23);
            this.checkBox1.TabIndex = 162;
            this.checkBox1.Text = "Mostrar apenas meus Pets";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Pets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(10)))), ((int)(((byte)(34)))));
            this.BackgroundImage = global::Dark_Age.Properties.Resources.dark_blue_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 700);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.adiciona_qtd);
            this.Controls.Add(this.btn_adotar);
            this.Controls.Add(this.Status_pet);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grid_lista_pets);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_pet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pets";
            this.Load += new System.EventHandler(this.Pets_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pets_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_lista_pets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_pet;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.DataGridView Grid_lista_pets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Label Status_pet;
        private FontAwesome.Sharp.IconButton btn_adotar;
        private FontAwesome.Sharp.IconButton adiciona_qtd;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}