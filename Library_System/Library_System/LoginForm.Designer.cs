/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: Пн 29.07.19
 * Время: 21:33
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Library_System
{
	partial class LoginForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtLogin;
		private System.Windows.Forms.Button btnSignIn;
		private System.Windows.Forms.Button btnLogIn;
		private System.Windows.Forms.CheckBox chbIsLibrarian;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chbIsLibrarian = new System.Windows.Forms.CheckBox();
			this.btnSignIn = new System.Windows.Forms.Button();
			this.btnLogIn = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(283, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(228, 230);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.Color.Gray;
			this.groupBox1.Controls.Add(this.chbIsLibrarian);
			this.groupBox1.Controls.Add(this.btnSignIn);
			this.groupBox1.Controls.Add(this.btnLogIn);
			this.groupBox1.Controls.Add(this.txtPassword);
			this.groupBox1.Controls.Add(this.txtLogin);
			this.groupBox1.Controls.Add(this.pictureBox3);
			this.groupBox1.Controls.Add(this.pictureBox2);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(38, 236);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(720, 364);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// chbIsLibrarian
			// 
			this.chbIsLibrarian.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
				| System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chbIsLibrarian.ForeColor = System.Drawing.Color.Lime;
			this.chbIsLibrarian.Location = new System.Drawing.Point(15, 178);
			this.chbIsLibrarian.Name = "chbIsLibrarian";
			this.chbIsLibrarian.Size = new System.Drawing.Size(267, 48);
			this.chbIsLibrarian.TabIndex = 8;
			this.chbIsLibrarian.Text = "Я бібліотекар!";
			this.chbIsLibrarian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chbIsLibrarian.UseVisualStyleBackColor = true;
			this.chbIsLibrarian.CheckedChanged += new System.EventHandler(this.ChbIsLibrarianCheckedChanged);
			// 
			// btnSignIn
			// 
			this.btnSignIn.BackColor = System.Drawing.Color.Silver;
			this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSignIn.Location = new System.Drawing.Point(360, 243);
			this.btnSignIn.Name = "btnSignIn";
			this.btnSignIn.Size = new System.Drawing.Size(360, 120);
			this.btnSignIn.TabIndex = 7;
			this.btnSignIn.Text = "Реєстрація";
			this.btnSignIn.UseVisualStyleBackColor = false;
			this.btnSignIn.Click += new System.EventHandler(this.BtnSignInClick);
			// 
			// btnLogIn
			// 
			this.btnLogIn.BackColor = System.Drawing.Color.Silver;
			this.btnLogIn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnLogIn.Location = new System.Drawing.Point(0, 243);
			this.btnLogIn.Name = "btnLogIn";
			this.btnLogIn.Size = new System.Drawing.Size(360, 120);
			this.btnLogIn.TabIndex = 6;
			this.btnLogIn.Text = "Вхід";
			this.btnLogIn.UseVisualStyleBackColor = false;
			this.btnLogIn.Click += new System.EventHandler(this.BtnLogInClick);
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtPassword.Location = new System.Drawing.Point(294, 98);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(394, 62);
			this.txtPassword.TabIndex = 5;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// txtLogin
			// 
			this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtLogin.Location = new System.Drawing.Point(294, 21);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(394, 62);
			this.txtLogin.TabIndex = 4;
			this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLoginKeyPress);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(6, 110);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(43, 37);
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(6, 27);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(38, 50);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(50, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(219, 66);
			this.label2.TabIndex = 1;
			this.label2.Text = "Пароль:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(50, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(170, 68);
			this.label1.TabIndex = 0;
			this.label1.Text = "Логін:";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(780, 612);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "LoginForm";
			this.Text = "Вхід & Реєстрація";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
