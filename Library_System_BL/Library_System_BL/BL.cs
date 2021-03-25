using System;
using System.Collections.Generic;
using MySql.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace Library_System_BL
{
	public interface IUserVerification
	{
		bool exist_in_db();
		bool input_correct_password();
	}
	
	public interface IRegistration
	{
		void sign_in();
	}
	
	public interface IObject_id
	{
		int get_id();
	}
	
	public interface IIs_object_unique
	{
		bool is_unique();
	}

	public class User
	{
		private string login, password;
		public string Login
		{
			get { return this.login; }
			//set { login = value; }
		}
		public string Password
		{
			get { return this.password; }	
			//set { password = value; }
		}
		public User(string login, string password)
		{
				this.login = login;
				this.password = password;		
		}
	}
	
	public class Librarian:User, IUserVerification
	{
		public Librarian (string login, string password):base(login, password){}
		
		// Перевірки правильності логіна та пароля бібліотекаря
		public bool exist_in_db()
		{
			const string path = "librarian_login.txt";
			string result = File.ReadAllText(path);
			if (result == Login) return true;
			return false;
		}
		public bool input_correct_password()
		{
			const string path = "librarian_password.txt";
			string result = File.ReadAllText(path);
			if (result == Password) return true;
			return false;
		}	
	}
	
	public class Reader: User, IUserVerification, IRegistration, IObject_id, IIs_object_unique
	{
		public double fine;
		public bool is_debtor;
		public Reader(string login, string password):base(login, password){}
		
		/*
		Перевірка логіна нового читача перед реєстрацією:
			1. Отримується число читачів
			2. Створюється масив відповідного розміру для логінів
			3. Логіни витягаються з БД в масив
			4. Виконується порівняння
		*/		
		public bool is_unique()
		{				
			const string sql1 = "SELECT COUNT(*) FROM readers";
			string result = "";
			bool is_unique_login = true;
			MySqlConnection conn = DBUtils.GetDBConnection();
			MySqlCommand cmd;
			
			conn.Open();
			cmd = new MySqlCommand(sql1,conn);
			result = cmd.ExecuteScalar().ToString();

			int number = Int32.Parse(result);
			
			// Якщо в с-мі ще немає читачів, то логін, звісно, унікальний
			if (number > 0)
			{
				const string sql2 = "SELECT login FROM readers";
				
				cmd = new MySqlCommand(sql2, conn);
				MySqlDataReader r = cmd.ExecuteReader();
				string [] logins = new string[number];
				int i = 0;
				
				while (r.Read())
				{
					logins[i] = r[0].ToString();
					++i;
				}
				r.Close();
				
				foreach (string log in logins)
				{
					if (log == Login)
					{
						is_unique_login = false;
						break;
					}
				}
			}			
			conn.Close();
			return is_unique_login;
		}
		
		// Реєстрація читача
		public void sign_in()
		{  
			MySqlConnection conn = DBUtils.GetDBConnection();
			conn.Open();
			const string sql = "INSERT INTO readers(login,password,is_debtor,fine) VALUES (@LOGIN,@PASSWORD,@IS_DEBTOR,@FINE)";
			MySqlCommand cmd = new MySqlCommand(sql,conn);
			cmd.Parameters.AddWithValue("@LOGIN", Login);
			cmd.Parameters.AddWithValue("@PASSWORD", Password);
			// За замовчуванням пеня щойно зареєстрованого читача дорівнює нулю.
			cmd.Parameters.AddWithValue("@IS_DEBTOR", 0);
			cmd.Parameters.AddWithValue("@FINE", 0);
			cmd.ExecuteNonQuery();
        	conn.Close();
		}
		
		/*
		Перевірка: чи зареєстрований читач з таким логіном
			1. Отримується число читачів
			2. Створюється масив відповідного розміру для логінів
			3. Логіни витягаються з БД в масив
			4. Виконується порівняння
		*/			
		public bool exist_in_db()
		{
			const string sql1 = "SELECT COUNT(*) FROM readers";
			string result = "";
			bool is_exist = false;
			
			MySqlConnection conn = DBUtils.GetDBConnection();
			MySqlCommand cmd;
			
			conn.Open();
			cmd = new MySqlCommand(sql1,conn);
			result = cmd.ExecuteScalar().ToString();
			int number = Int32.Parse(result);
			
			if (number>0)
			{
				const string sql2 = "SELECT login FROM readers";
				cmd = new MySqlCommand(sql2, conn);
				MySqlDataReader r = cmd.ExecuteReader();
				
				string [] logins = new string[number];
				int i = 0;
				while (r.Read())
				{
					logins[i] = r[0].ToString();
					++i;
				}
				r.Close();
				
				foreach (string log in logins)
				{
					if (log == Login)
					{
						is_exist = true;
						break;
					}
				}	
			}
			conn.Close();
			return is_exist;
		}		
		
		// Перевірка правильності пароля за логіном	
		public bool input_correct_password()
		{
			string parameter = Login;
			const string get_password = "SELECT password FROM readers WHERE login = @LOGIN";
			
			MySqlConnection conn = DBUtils.GetDBConnection();
			conn.Open();
			MySqlCommand cmd = new MySqlCommand (get_password, conn);
			cmd.Parameters.AddWithValue("@LOGIN", Login);
			string result = cmd.ExecuteScalar().ToString();
			conn.Close();
			
			if (result == Password)
			{
				return true;	
			}
			return false;
		}
		
		// Отримання id-номера читача
		public int get_id()
		{
			const string sql = "SELECT id FROM readers WHERE login = @LOGIN";
			MySqlConnection conn = DBUtils.GetDBConnection();
			conn.Open();
			MySqlCommand cmd = new MySqlCommand(sql,conn);
			cmd.Parameters.AddWithValue("@LOGIN", Login);
			string result = cmd.ExecuteScalar().ToString();
			conn.Close();
			int id = Convert.ToInt32(result);
			return id;
		}
		
		/*
		Перевірка: чи не прострочив читач термін тримання книги
			1. Отримується дата останнього замовлення
			2. Порівнюються поточна дата та критичний термін тримання книги (дата останнього замовлення + 2 тижні)
		*/	
		public bool check_time()
		{
			bool delay = false;
			MySqlConnection conn = DBUtils.GetDBConnection();
			const string sql = "SELECT MAX(date) FROM Orders WHERE reader_id = @ID";
			
			conn.Open();
			MySqlCommand cmd = new MySqlCommand(sql,conn);
			cmd.Parameters.AddWithValue("@ID", get_id());
			string result = cmd.ExecuteScalar().ToString();
			conn.Close();
			// Якщо читач не замовляв книг, перевірка не виконується
			if (result != "")
			{
				const int days = 14; // 2 тижні	
				DateTime term = Convert.ToDateTime(result).AddDays(days);	
				int cmpr = DateTime.Compare(term, DateTime.Now);
				if (cmpr <= 0) delay = true;
			}	
			return delay;
		}

		// Оновлення статусу читача (він стає боржником, якщо прострочив термін)	
		public void update_status()
		{
			if (check_time() == true)
			{
				const string update = "UPDATE readers SET is_debtor = 1 WHERE login = @LOGIN";
				MySqlConnection conn = DBUtils.GetDBConnection();
				MySqlDataAdapter adapter;
				MySqlCommand cmd = new MySqlCommand(update,conn);
				cmd.Parameters.AddWithValue("@LOGIN", Login);
				conn.Open();
				cmd.ExecuteNonQuery();
				adapter = new MySqlDataAdapter(cmd);
				adapter.UpdateCommand = conn.CreateCommand();
				adapter.UpdateCommand.CommandText = update;
				conn.Close();
			}
		}
		
		// Отримання статусу читача (боржник/не боржник)	
		public bool has_expired_time()
		{
			update_status();
			MySqlConnection conn = DBUtils.GetDBConnection();
			MySqlCommand cmd;
			const string sql = "SELECT is_debtor FROM readers WHERE login = @LOGIN";
			conn.Open();
			cmd = new MySqlCommand(sql, conn);
			cmd.Parameters.AddWithValue("@LOGIN", Login);
			string result = cmd.ExecuteScalar().ToString();
			conn.Close();
			bool res = Convert.ToBoolean(result);
			return res;
		}
		
		// Отримання пені читача
		public double get_fine()
		{
			MySqlConnection conn = DBUtils.GetDBConnection();
			const string sql = "SELECT fine FROM readers WHERE login = @LOGIN";
			conn.Open();
			MySqlCommand cmd = new MySqlCommand(sql, conn);
			cmd.Parameters.AddWithValue("@LOGIN", Login);
			string result = cmd.ExecuteScalar().ToString();
			double current_fine = Convert.ToDouble(result);
			return current_fine;
		}
		
		// Встановлення пені для читача
		public void set_fine(double fine)
		{
			this.fine = fine;
			const string sql = "UPDATE readers SET fine = @FINE WHERE login = @LOGIN";
			MySqlConnection conn = DBUtils.GetDBConnection();
			MySqlDataAdapter adapter;
			conn.Open();
			MySqlCommand cmd = new MySqlCommand(sql,conn);
			cmd.Parameters.AddWithValue("@FINE", fine);
			cmd.Parameters.AddWithValue("@LOGIN", Login);
			cmd.ExecuteNonQuery();
			adapter = new MySqlDataAdapter(cmd);
			adapter.UpdateCommand = conn.CreateCommand();
			adapter.UpdateCommand.CommandText = sql;
			conn.Close();
		}
		
		// Оплата пені читачем (+ зміна статусу)		
		public void pay_fine()
		{
			const string sql = "UPDATE readers SET fine = 0, is_debtor = 0 WHERE login = @LOGIN";
			MySqlConnection conn = DBUtils.GetDBConnection();
			MySqlDataAdapter adapter;
			conn.Open();
			MySqlCommand cmd = new MySqlCommand(sql,conn);
			cmd.Parameters.AddWithValue("@LOGIN", Login);
			cmd.ExecuteNonQuery();
			adapter = new MySqlDataAdapter(cmd);
			adapter.UpdateCommand = conn.CreateCommand();
			adapter.UpdateCommand.CommandText = sql;
			conn.Close();
		}

		// Створення запису в БД про замовлення примірника		
		public void order_copy( int id)
		{
			const string sql = "INSERT INTO Orders (book_id, reader_id, date) VALUES (@BOOK_ID, @READER_ID, @DATE)";
			MySqlConnection conn = DBUtils.GetDBConnection();
			conn.Open();
			MySqlCommand cmd = new MySqlCommand(sql,conn);
			cmd.Parameters.AddWithValue("@BOOK_ID", id);
			cmd.Parameters.AddWithValue("@READER_ID", get_id());
			cmd.Parameters.AddWithValue("@DATE", DateTime.Now);
			cmd.ExecuteNonQuery();
			conn.Close();
		}
		
		// Додавання читача в чергу на книгу
		public void add_to_queue(Book book)
		{
			string filename = book.title + ".txt";
			StreamWriter sw  = new StreamWriter(File.Open(filename, FileMode.OpenOrCreate));
			sw.WriteLine(Login);
			sw.Close();
		}
	}
	
	public class Book: IRegistration, IObject_id, IIs_object_unique
	{
		public string title, author, publishing_house;
		public int year, pages, copies;
		
		public Book(string title, string author, string publishing_house, int year, int pages, int copies)
		{
			this.title = title;
			this.author = author;
			this.publishing_house = publishing_house;
			this.year = year;
			this.pages = pages;
			this.copies = copies;	
		}
		
		/*
		Перевірка нової книги перед реєстрацією:
			1. Отримуються дані про книгу з такою ж назвою
			2. Виконується порівняння
			
			Книги з однаковими назвами можуть друкуватись різними видавництвами в різні роки,
			а отже, мати різну к-ть сторінок 
		*/			
		public bool is_unique()
		{
			bool is_unique_book = true;
			
			const string sql = "SELECT * FROM books WHERE title = @TITLE";
			
			const int columns = 7; // к-ть полів, що описують книгу 
			string [] data = new string[columns];
			
			MySqlConnection conn = DBUtils.GetDBConnection();
			conn.Open();
			MySqlCommand cmd = new MySqlCommand(sql,conn);
			cmd.Parameters.AddWithValue("@TITLE", title);
			
			MySqlDataReader r = cmd.ExecuteReader();
			while(r.Read())
			{
				for(int i = 0; i<columns; i++ )
				{
					data[i] = r[i].ToString();
				}
			}
			r.Close();
			conn.Close();
			
			if (data[4] == publishing_house && Convert.ToInt32(data[3]) == year && Convert.ToInt32(data[5]) == pages)
			{
				is_unique_book = false;
			}
			return is_unique_book;
		}
		
		// Реєстрація книги
		public void sign_in()
		{
			MySqlConnection conn = DBUtils.GetDBConnection();
			conn.Open();
			const string sql = "INSERT INTO books(title,author,publishing_house,year,pages,copies) VALUES (@TITLE, @AUTHOR, @PUBLISHING_HOUSE, @YEAR, @PAGES, @COPIES)";
			MySqlCommand cmd = new MySqlCommand(sql,conn);
			cmd.Parameters.AddWithValue("@TITLE", title);
			cmd.Parameters.AddWithValue("@AUTHOR", author );
			cmd.Parameters.AddWithValue("@PUBLISHING_HOUSE", publishing_house);
			cmd.Parameters.AddWithValue("@YEAR", year);
			cmd.Parameters.AddWithValue("@PAGES", pages);
			cmd.Parameters.AddWithValue("@COPIES", copies);
			cmd.ExecuteNonQuery();
			conn.Close();
		}
		
		// Редагування даних книги	
		public void edit()
		{	
			string sql = "UPDATE books SET title='" + title + "',author='" + author + "',publishing_house='" + publishing_house + "',year='" + year + "',pages='" + pages + "',copies='" + copies +"' WHERE title=@TITLE";
			MySqlConnection conn = DBUtils.GetDBConnection();
			MySqlDataAdapter adapter;
			conn.Open();
			MySqlCommand cmd = new MySqlCommand(sql,conn);
			cmd.Parameters.AddWithValue("@TITLE",title);
			cmd.ExecuteNonQuery();
			adapter = new MySqlDataAdapter(cmd);
			adapter.UpdateCommand = conn.CreateCommand();
			adapter.UpdateCommand.CommandText = sql;
			conn.Close();
		}
		
		// Видалення книги з каталогу
		public void delete()
		{			
			const string sql = "DELETE FROM books WHERE title=@TITLE";
			MySqlConnection conn = DBUtils.GetDBConnection();
			MySqlDataAdapter adapter;
			conn.Open();
			MySqlCommand cmd = new MySqlCommand(sql, conn);
			cmd.Parameters.AddWithValue("@TITLE", title);
			cmd.ExecuteNonQuery();
			adapter = new MySqlDataAdapter(cmd);
			adapter.DeleteCommand = conn.CreateCommand();
			adapter.DeleteCommand.CommandText = sql;
			conn.Close();
		}
		
		// Замовлення книги: зменшення к-ті примірників на одиницю
		public void is_ordered()
		{
			const string sql = "UPDATE books SET copies = @COPIES WHERE title = @TITLE";
			MySqlConnection conn = DBUtils.GetDBConnection();
			MySqlDataAdapter adapter;
			conn.Open();
			MySqlCommand cmd = new MySqlCommand(sql, conn);
			cmd.Parameters.AddWithValue("@TITLE", title);
			cmd.Parameters.AddWithValue("@COPIES", copies-1);
			cmd.ExecuteNonQuery();
			adapter = new MySqlDataAdapter(cmd);
			adapter.UpdateCommand = conn.CreateCommand();
			adapter.UpdateCommand.CommandText = sql;
			conn.Close();
		}
		
		// Отримання id-номера книги
		public int get_id()
		{
			const string sql = "SELECT id FROM books WHERE title = @TITLE";
			MySqlConnection conn = DBUtils.GetDBConnection();
			conn.Open();
			MySqlCommand cmd = new MySqlCommand(sql,conn);
			cmd.Parameters.AddWithValue("@TITLE", title);
			string result = cmd.ExecuteScalar().ToString();
			conn.Close();
			int id = Convert.ToInt32(result);
			return id;
		}	
	}
}
