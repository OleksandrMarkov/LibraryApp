using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library_System
{
	public partial class LibrarianMenu : Form
	{
		public LibrarianMenu()
		{
			InitializeComponent();
		}
		
		// Перехід до роботи з каталогом
		void BtnBooksClick(object sender, EventArgs e)
		{
			this.Hide();
			Catalog f = new Catalog();
			f.Show();
		}
		
		//Перехід до роботи з боржниками
		void BtnDebtorsClick(object sender, EventArgs e)
		{
			this.Hide();
			Debtors f = new Debtors();
			f.Show();
		}
	}
}
