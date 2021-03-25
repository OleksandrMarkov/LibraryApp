using System;
using System.Drawing;
using System.Windows.Forms;
using Library_System_BL;

namespace Library_System
{
	public partial class LoginForm : Form
	{
			
		public LoginForm()
		{
			InitializeComponent();
			chbIsLibrarian.Checked = false;
			btnLogIn.Enabled = true;
			btnSignIn.Enabled = true;
		}
		
		// Очищення текстових полів
		void cleartxts()
		{
			txtLogin.Text = txtPassword.Text = "";
		}
		
		// Перевірка довжин логіна та пароля (5-15 символів)
		bool CheckUserData(string login, string password)
		{
			bool login_length = false;
			bool password_length = false;
			if (login.Length > 4 && login.Length < 16) login_length = true;
			if (password.Length > 4 && password.Length < 16) password_length = true;
			
			if (login_length && password_length)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
		// Кнопка "Реєстрація"
		void BtnSignInClick(object sender, EventArgs e)
		{  
			try
			{
				// Якщо довжини логіна та пароля некоректні, повідомляємо про це
				if (CheckUserData(txtLogin.Text,txtPassword.Text) == false) throw new Exception();
				else
				{
					//Якщо реєструється читач
					if (chbIsLibrarian.Checked == false)
					{	
						Reader reader = new Reader(txtLogin.Text,txtPassword.Text);
				
						// Якщо читач придумав унікальний логін, відбувається реєстрація
						if (reader.is_unique())
						{
				 			reader.sign_in();
				 			MessageBox.Show("Вас зареєстровано в с-мі електронного замовлення книг бібліотеки!", "Вітаємо!", MessageBoxButtons.OK, MessageBoxIcon.Information);
							cleartxts();					
						}
					
						// Реєстрація не відбувається, оскільки читача з таким логіном вже зареєстровано
				 		else
						{
				 			MessageBox.Show("Читача з таким логіном вже зареєстровано!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}		
					}
					/*if (chbIsLibrarian.Checked == true)
					{
						MessageBox.Show("Реєстрація бібліотекарів не передбачена...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}*/
				}	
			}
			catch(Exception ex)
			{
				MessageBox.Show("Довжини логіна та пароля - від 5 до 15 символів!", "Помилка реєстрації!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				cleartxts();
			}	
		}
		
		// Кнопка "Вхід"
		void BtnLogInClick(object sender, EventArgs e)
		{
			try
			{
				if (CheckUserData(txtLogin.Text, txtPassword.Text) == false) throw new Exception();
				else
				{
					// Якщо входить читач
					if (chbIsLibrarian.Checked == false)
					{
						Reader reader = new Reader(txtLogin.Text,txtPassword.Text);
						
						// Перевіряються логін та пароль (дані читачів містяться в БД)
						if (reader.exist_in_db() && reader.input_correct_password())
						{	
							// Перевіряється, чи не прострочено термін тримання книги читачем  
							if (reader.has_expired_time())
							{
								reader.fine = reader.get_fine();
								
								// Якщо читачеві вже призначено пеню, він дізнається її розмір та зможе анулювати її 
								if (reader.fine > 0)
								{
									this.Hide();							
									FineAssigned f  = new FineAssigned();
									f.R = reader;
									f.Show();
								}
								
								// Читачеві повідомляється, що йому скоро буде призначено пеню 
								else
								{
									this.Hide();
									FineNotAssignedYet f = new FineNotAssignedYet();
									f.R = reader;
									f.Show();
								}
							}
							
							// Якщо читач не заборгував книг, він переходить до нових замовлень 
							else
							{
								Orders f = new Orders();
								f.R = reader;
								f.Show();
							}
						}	
						// Помилка авторизації
						else
						{
							MessageBox.Show("Невірний логін або пароль!", "Помилка авторизації!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					
					// Якщо входить бібліотекар
					if (chbIsLibrarian.Checked == true)
					{
						Librarian librarian = new Librarian(txtLogin.Text,txtPassword.Text);
								
						/* Перевіряються логін та пароль (дані бібліотекаря містяться в текстових файлах
						librarian_login.txt та librarian_password.txt)*/
						if (librarian.exist_in_db() && librarian.input_correct_password())
						{
							this.Hide();
							LibrarianMenu f = new LibrarianMenu();
							f.Show();
						}
						// Помилка авторизації
						else
						{
							MessageBox.Show("Невірний логін або пароль!", "Помилка авторизації!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}	
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Нагадуємо, що довжини логіна та пароля - від 5 до 15 символів!", "Помилка авторизації!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				cleartxts();
			}
		}
			
		// Перемикання прапорця "Я бібліотекар!"
		void ChbIsLibrarianCheckedChanged(object sender, EventArgs e)
		{
			if (chbIsLibrarian.Checked == true)
			{
				btnSignIn.Enabled = false;
			}
			else
			{
				btnSignIn.Enabled = true;
			}
		}
		
		// Перехід між текстовими полями
		void TxtLoginKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				txtPassword.Focus();
			}
		}
		
	}
}
