using Dark_Age.Componente;
using Dark_Age.Controllers;
using Dark_Age.Enteties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Dark_Age
{
	public partial class teste : Form
	{
		public teste()
		{
			InitializeComponent();			
		}

		private void teste_Load(object sender, EventArgs e)
		{
			Chat chat = new Chat();
			chat.TopLevel = false;
			panel1.Controls.Add(chat);
			chat.Show();
		}
	}
}
