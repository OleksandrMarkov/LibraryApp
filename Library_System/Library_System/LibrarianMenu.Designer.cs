/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: Ср 14.08.19
 * Время: 20:12
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Library_System
{
	partial class LibrarianMenu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnBooks;
		private System.Windows.Forms.Button btnDebtors;
		
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
			this.btnBooks = new System.Windows.Forms.Button();
			this.btnDebtors = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnBooks
			// 
			this.btnBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnBooks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnBooks.BackColor = System.Drawing.Color.Silver;
			this.btnBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnBooks.Location = new System.Drawing.Point(67, 200);
			this.btnBooks.Name = "btnBooks";
			this.btnBooks.Size = new System.Drawing.Size(360, 120);
			this.btnBooks.TabIndex = 0;
			this.btnBooks.Text = "Каталог";
			this.btnBooks.UseVisualStyleBackColor = false;
			this.btnBooks.Click += new System.EventHandler(this.BtnBooksClick);
			// 
			// btnDebtors
			// 
			this.btnDebtors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnDebtors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnDebtors.BackColor = System.Drawing.Color.Silver;
			this.btnDebtors.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDebtors.Location = new System.Drawing.Point(499, 200);
			this.btnDebtors.Name = "btnDebtors";
			this.btnDebtors.Size = new System.Drawing.Size(360, 120);
			this.btnDebtors.TabIndex = 1;
			this.btnDebtors.Text = "Боржники";
			this.btnDebtors.UseVisualStyleBackColor = false;
			this.btnDebtors.Click += new System.EventHandler(this.BtnDebtorsClick);
			// 
			// LibrarianMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(914, 552);
			this.Controls.Add(this.btnDebtors);
			this.Controls.Add(this.btnBooks);
			this.Name = "LibrarianMenu";
			this.Text = "Меню бібліотекаря";
			this.ResumeLayout(false);

		}
	}
}
