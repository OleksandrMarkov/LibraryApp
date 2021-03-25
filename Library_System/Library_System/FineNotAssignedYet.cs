using System;
using System.Drawing;
using System.Windows.Forms;
using Library_System_BL;

namespace Library_System
{

	public partial class FineNotAssignedYet : Form
	{
		// Інформація про читача
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
		
		public FineNotAssignedYet()
		{
			InitializeComponent();
		}
		
		// Повідомлення про пеню
		void FineNotAssignedYetLoad(object sender, EventArgs e)
		{
			rtbWarning.Multiline = true;
			rtbWarning.Text = "ШАНОВНИЙ " + R.Login +
			"!\n\n За використання книги довше двох тижнів, найближчим часом вам буде нараховано пеню у розмірі, визначеному бібліотекарем.\n\nВи не зможете резервувати книги,\n доки пеня не сплачена!!".ToUpper();
		}
	}
}
