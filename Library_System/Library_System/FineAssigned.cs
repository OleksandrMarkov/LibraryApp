using System;
using System.Drawing;
using System.Windows.Forms;
using Library_System_BL;

namespace Library_System
{
	
	public partial class FineAssigned : Form
	{
		// Отримання інформації про читача
		private Reader r;
		public Reader R
		{
			get
			{
				return r;
			}
			set
			{
				r = value;
			}
		}
			
		public FineAssigned()
		{
			InitializeComponent();
		}
		
		// Сплата пені
		void BtnPayFineClick(object sender, EventArgs e)
		{
			R.pay_fine();
			MessageBox.Show("Пеню сплачено!");
		}
		
		// Повідомлення про пеню
		void FineAssignedLoad(object sender, EventArgs e)
		{
			rtbWarning.Multiline = true;
			rtbWarning.Text = "ШАНОВНИЙ " + R.Login +
			"!\n\n За використання книги довше двох тижнів, вам нараховано пеню у розмірі ".ToUpper() +
			R.fine + " грн.!!!".ToUpper() + "\n\nВи не зможете резервувати книги,\n доки пеня не сплачена!!".ToUpper();
		}
	}
}
