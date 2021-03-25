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
	public partial class Catalog : Form
	{
		static string connstr = "server=localhost;database=library_db;user=root;password=zntu";
		MySqlConnection conn = new MySqlConnection(connstr);
		MySqlCommand cmd;
		MySqlDataAdapter adapter;	
		DataTable dt = new DataTable();
		
		public Catalog()
		{
			InitializeComponent();
			
			// Опис таблиці каталогу
			dgvCatalog.ColumnCount = 6;
			dgvCatalog.Columns[0].Name = "Назва";
			dgvCatalog.Columns[1].Name = "Автор";
			dgvCatalog.Columns[2].Name = "Видавництво";
			dgvCatalog.Columns[3].Name = "Рік видання";
			dgvCatalog.Columns[4].Name = "Сторінок";
			dgvCatalog.Columns[5].Name = "К-ть примірників";
			
			dgvCatalog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvCatalog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvCatalog.MultiSelect = false;
		}
		
		// Перевірка даних книги
		public bool is_wrong(string title, string author, string publishing_house, string year, string pages, string copies)
		{	
			bool wrong_book = true;
			bool title_length = false;
			bool author_length = false;
			bool publishing_house_length = false;
			bool year_number = false;
			bool pages_number = false;
			bool copies_number = false;
			
			if(title.Length > 0 && title.Length < 51) title_length = true;
			if (author.Length > 1 && author.Length < 51) author_length = true;
			if (publishing_house.Length > 2 && publishing_house.Length < 51) publishing_house_length = true;
			
			int res;
			
			if (Int32.TryParse(year, out res))
			{
				int y = Int32.Parse(year);
				if (y >= 1800 && y <= Int32.Parse(DateTime.Now.Year.ToString()))
				{
					year_number = true;
				}
			}
			
			if (Int32.TryParse(pages, out res))
			{
				int p = Int32.Parse(pages);
				if (p > 0 && p < 3605)
				{
					pages_number = true;
				}
			}
			
			if (Int32.TryParse(copies, out res))
			{
				int c = Int32.Parse(copies);
				if (c >= 0 && c <= 1E3)
				{
					copies_number = true;
				}
			}
			
			if (title_length && author_length && publishing_house_length && year_number && pages_number && copies_number)
			{
				wrong_book = false;
			}
			return wrong_book;
		}
		
		// Ф-ція заповнення таблиці
		public void populate(string title, string author, string publishing_house, string year, string pages, string copies)
		{
			dgvCatalog.Rows.Add(title, author, publishing_house, year, pages, copies);
		}
		
		// Ф-ція завантаження даних з БД
		public void retrieve()
		{
			dgvCatalog.Rows.Clear();
			const string select_all = "SELECT title, author, publishing_house, year, pages, copies FROM books";
			try
			{
				conn.Open();
				cmd = new MySqlCommand(select_all, conn);
				adapter = new MySqlDataAdapter(cmd);
				adapter.Fill(dt);
			
				foreach (DataRow row in dt.Rows)
				{
					populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
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
		
		// Очищення текстових полів
		public void cleartxts()
		{
			txtTitle.Text = txtAuthor.Text = txtPublishingHouse.Text = txtYear.Text = txtYear.Text = txtPages.Text = txtCopies.Text = "";
		}
		
		// Реєстрація нової книги
		void BtnAddBookClick(object sender, EventArgs e)
		{
			try
			{
				if (is_wrong(txtTitle.Text, txtAuthor.Text, txtPublishingHouse.Text, txtYear.Text, txtPages.Text, txtCopies.Text) == true)
				{
					throw new Exception();
				}
				else
				{
					Book book = new Book (txtTitle.Text, txtAuthor.Text, txtPublishingHouse.Text, Int32.Parse(txtYear.Text), Int32.Parse(txtPages.Text), Int32.Parse(txtCopies.Text));
					
					// Якщо така книга ще не зареєстрована в каталозі, відбувається реєстрація
					if (book.is_unique() == true)
					{
						book.sign_in();
						retrieve();
						MessageBox.Show("Нову книгу додано!", "Робота з каталогом", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Така книга вже зареєстрована!", "Робота з каталогом", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Груба помилка в даних книги!", "Робота з каталогом", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				cleartxts();
			}
		}
		
		// Оновлення таблиці
		void BtnUpdateClick(object sender, EventArgs e)
		{
			retrieve();
		}
		
		// Зміна відомостей про книгу
		void BtnEditClick(object sender, EventArgs e)
		{
			try
			{
				if (is_wrong(txtTitle.Text, txtAuthor.Text, txtPublishingHouse.Text, txtYear.Text, txtPages.Text, txtCopies.Text) == true)
				{
					throw new Exception();
				}
				
				Book book = new Book (txtTitle.Text, txtAuthor.Text, txtPublishingHouse.Text, Int32.Parse(txtYear.Text), Int32.Parse(txtPages.Text), Int32.Parse(txtCopies.Text));
				book.edit();
				retrieve();
				MessageBox.Show("Відомості про книгу змінено!", "Робота з каталогом", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
			}
			catch(Exception ex)
			{
				MessageBox.Show("Груба помилка в даних книги!", "Робота з каталогом", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				cleartxts();
			}	
		}
		
		// Видалення книги з каталогу
		void BtnDeleteClick(object sender, EventArgs e)
		{
			try
			{
				if (is_wrong(txtTitle.Text, txtAuthor.Text, txtPublishingHouse.Text, txtYear.Text, txtPages.Text, txtCopies.Text) == true)
				{
					throw new Exception();
				}
				
				Book book = new Book (txtTitle.Text, txtAuthor.Text, txtPublishingHouse.Text, Int32.Parse(txtYear.Text), Int32.Parse(txtPages.Text), Int32.Parse(txtCopies.Text));
				
				if (MessageBox.Show("Ви впевнені?!","Видалення книги з каталогу", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
				{
					book.delete();
					retrieve();
				}	
			}
			catch(Exception ex)
			{
				MessageBox.Show("Помилка при видаленні книги!", "Робота з каталогом", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				cleartxts();
			}
		}
		
		// Зв'язок між таблицею та текстовими полями
		void DgvCatalogMouseClick(object sender, MouseEventArgs e)
		{
			txtTitle.Text = dgvCatalog.SelectedRows[0].Cells[0].Value.ToString();
			txtAuthor.Text = dgvCatalog.SelectedRows[0].Cells[1].Value.ToString();
			txtPublishingHouse.Text = dgvCatalog.SelectedRows[0].Cells[2].Value.ToString();
			txtYear.Text = dgvCatalog.SelectedRows[0].Cells[3].Value.ToString();
			txtPages.Text = dgvCatalog.SelectedRows[0].Cells[4].Value.ToString();
			txtCopies.Text = dgvCatalog.SelectedRows[0].Cells[5].Value.ToString();
		}
		
		// Перехід між текстовими полями
		void TxtTitleKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				txtAuthor.Focus();
			}
		}
		void TxtAuthorKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				txtPublishingHouse.Focus();
			}
		}
		void TxtPublishingHouseKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				txtYear.Focus();
			}
		}
		void TxtYearKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				txtPages.Focus();
			}
		}
		void TxtPagesKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				txtCopies.Focus();
			}
		}		
	}
}
