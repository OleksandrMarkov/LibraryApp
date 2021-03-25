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

	public partial class Orders : Form
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
		
		static string connstr = "server=localhost;database=library_db;user=root;password=zntu";
		MySqlConnection conn = new MySqlConnection(connstr);
		MySqlCommand cmd;
		MySqlDataAdapter adapter;	
		DataTable dt = new DataTable();
		
		
		public Orders()
		{
			InitializeComponent();
			// Опис таблиці каталогу
			dgvCatalog.ColumnCount = 5;
			dgvCatalog.Columns[0].Name = "Назва";
			dgvCatalog.Columns[1].Name = "Автор";
			dgvCatalog.Columns[2].Name = "Видавництво";
			dgvCatalog.Columns[3].Name = "Рік видання";
			dgvCatalog.Columns[4].Name = "Сторінок";
			dgvCatalog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvCatalog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvCatalog.MultiSelect = false;
			// Завантаження
			retrieve();
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
		public void populate(string title, string author, string publishing_house, string year, string pages)
		{
			dgvCatalog.Rows.Add(title, author, publishing_house, year, pages);
		}
		
		// Ф-ція завантаження даних із БД 
		public void retrieve()
		{
			dgvCatalog.Rows.Clear();
			const string sql = "SELECT title, author, publishing_house, year, pages FROM books";
			try
			{
				cmd = new MySqlCommand(sql, conn);
				conn.Open();
				adapter = new MySqlDataAdapter(cmd);
				adapter.Fill(dt);
			
				foreach (DataRow row in dt.Rows)
				{
					populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
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
			txtTitle.Text = txtAuthor.Text = txtPublishingHouse.Text = txtYear.Text = txtYear.Text = txtPages.Text = "";
		}
		
		// Замовлення книги
		void BtnOrderClick(object sender, EventArgs e)
		{
			const string sql = "SELECT copies FROM books WHERE title = @TITLE";
			string result = "";
			int copies = 0;
			
			try
			{
				conn.Open();
				cmd = new MySqlCommand(sql,conn);
				cmd.Parameters.AddWithValue("@TITLE", txtTitle.Text);
				result = cmd.ExecuteScalar().ToString();	
			}
			catch(Exception ex)
			{
				MessageBox.Show("Помилка при роботі з БД!", "Виникла помилка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				conn.Close();	
			}
			
			try
			{
				if (is_wrong(txtTitle.Text, txtAuthor.Text, txtPublishingHouse.Text, txtYear.Text, txtPages.Text, result) == true)
				{
					throw new Exception();
				}
				
				Book book = new Book(txtTitle.Text,txtAuthor.Text,txtPublishingHouse.Text, Convert.ToInt32(txtYear.Text), Convert.ToInt32(txtPages.Text), copies);
				if (MessageBox.Show("Ви впевнені?!", "Замовлення книги", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					// Якщо є вільні екземпляри книги		 
					if (copies>0)
					{
						// Книга замовляється
						book.is_ordered();
						int id = book.get_id();
						R.order_copy(id);
						MessageBox.Show("Книга замовлена!", "Замовлення книги", MessageBoxButtons.OK, MessageBoxIcon.Information);					
					}
					
					// Інакше читач стає в чергу
					else
					{
						R.add_to_queue(book);
						MessageBox.Show("На жаль, вільних примірників зараз немає. Вас додано в чергу на книгу!", "Замовлення книги", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
		
		// Зв'язок між текстовими полями і таблицею
		void DgvCatalogMouseClick(object sender, MouseEventArgs e)
		{
			txtTitle.Text = dgvCatalog.SelectedRows[0].Cells[0].Value.ToString();
			txtAuthor.Text = dgvCatalog.SelectedRows[0].Cells[1].Value.ToString();
			txtPublishingHouse.Text = dgvCatalog.SelectedRows[0].Cells[2].Value.ToString();
			txtYear.Text = dgvCatalog.SelectedRows[0].Cells[3].Value.ToString();
			txtPages.Text = dgvCatalog.SelectedRows[0].Cells[4].Value.ToString();
		}
		
		// Переходи між текстовими полями 
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
	}
}
