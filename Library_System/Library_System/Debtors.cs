using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_System_BL;
using MySql.Data.MySqlClient;

namespace Library_System
{
	public partial class Debtors : Form
	{
		static string connstr = "server=localhost;database=library_db;user=root;password=zntu";
		MySqlConnection conn = new MySqlConnection(connstr);
		MySqlCommand cmd;
		MySqlDataAdapter adapter;	
		DataTable dt = new DataTable();
		
		public Debtors()
		{
			InitializeComponent();
			
			// Опис таблиці боржників
			dgvDebtors.ColumnCount = 3;
			dgvDebtors.Columns[0].Name = "Логін";
			dgvDebtors.Columns[1].Name = "Пароль";
			dgvDebtors.Columns[2].Name = "Пеня";
			
			dgvDebtors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvDebtors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDebtors.MultiSelect = false;

			btnShowList.Focus();
			retrieve();
		}	

		// Ф-ція заповнення таблиці
		public void populate(string login, string password, string fine)
		{
			dgvDebtors.Rows.Add(login, password, fine);
		}
		
		// Ф-ція завантаження даних з БД
		public void retrieve()
		{
			dgvDebtors.Rows.Clear();
			const string select_all = "SELECT login, password, fine FROM readers WHERE is_debtor=1";
			try
			{
				cmd = new MySqlCommand(select_all, conn);
				conn.Open();
				adapter = new MySqlDataAdapter(cmd);
				adapter.Fill(dt);
				foreach (DataRow row in dt.Rows)
				{
					populate(row[0].ToString(), row[1].ToString(), row[2].ToString());
				}
				dt.Rows.Clear();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Не вдалось оновити каталог!", "Виникла помилка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				conn.Close();
			}
		}
		
		// Очищення текстового поля
		public void cleartxts()
		{
			txtFine.Text = "";
		}
		
		// Відображення переліку боржників
		void BtnShowListClick(object sender, EventArgs e)
		{
			retrieve();
		}
		
		// Встановлення пені 
		void BtnSetFineClick(object sender, EventArgs e)
		{
			string login = dgvDebtors.SelectedRows[0].Cells[0].Value.ToString();
			string password = dgvDebtors.SelectedRows[0].Cells[1].Value.ToString();
			Reader reader =  new Reader(login, password);
			int number = dgvDebtors.CurrentCell.RowIndex;
			
			// Перевірка введеного значення
			try
			{
				double res;			
				if (Double.TryParse(txtFine.Text, out res))
				{
					double fine = Convert.ToDouble(txtFine.Text);
					if (fine>0)
					{
						reader.set_fine(fine);
						MessageBox.Show("Пеню встановлено", "Робота з боржниками!", MessageBoxButtons.OK, MessageBoxIcon.Information);
						retrieve();				
					}
					else
					{
						MessageBox.Show("Значення пені > 0 !!!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else throw new Exception();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Введено нечислове значення пені!!!", "Груба помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				cleartxts();	
			}
		}
		
		// Перехід між текстовим полем та кнопкою
		void TxtFineKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				btnSetFine.Focus();
			}
		}
		
		// Зв'язок між текстовим полем і таблицею
		void DgvDebtorsMouseClick(object sender, MouseEventArgs e)
		{
			txtFine.Text = dgvDebtors.SelectedRows[0].Cells[2].Value.ToString();
		}	
	}
}
