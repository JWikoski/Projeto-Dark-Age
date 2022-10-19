namespace Dark_Age
{
    partial class teste
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
            this.label_com_image1 = new Dark_Age.Componente.label_com_image();
            this.SuspendLayout();
            // 
            // label_com_image1
            // 
            this.label_com_image1.Location = new System.Drawing.Point(12, 12);
            this.label_com_image1.Name = "label_com_image1";
            this.label_com_image1.Size = new System.Drawing.Size(424, 114);
            this.label_com_image1.TabIndex = 0;
            // 
            // teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_com_image1);
            this.Name = "teste";
            this.Text = "teste";
            this.Load += new System.EventHandler(this.teste_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Componente.label_com_image label_com_image1;
    }
}