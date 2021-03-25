/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: Ср 14.08.19
 * Время: 20:34
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Library_System
{
	partial class Catalog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgvCatalog;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox txtAuthor;
		private System.Windows.Forms.TextBox txtPublishingHouse;
		private System.Windows.Forms.TextBox txtYear;
		private System.Windows.Forms.TextBox txtCopies;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnAddBook;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.TextBox txtPages;
		
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
			this.dgvCatalog = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtAuthor = new System.Windows.Forms.TextBox();
			this.txtPublishingHouse = new System.Windows.Forms.TextBox();
			this.txtYear = new System.Windows.Forms.TextBox();
			this.txtCopies = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnAddBook = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.txtPages = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCatalog
			// 
			this.dgvCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCatalog.Location = new System.Drawing.Point(12, 80);
			this.dgvCatalog.Name = "dgvCatalog";
			this.dgvCatalog.Size = new System.Drawing.Size(487, 364);
			this.dgvCatalog.TabIndex = 0;
			this.dgvCatalog.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgvCatalogMouseClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(505, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 34);
			this.label1.TabIndex = 11;
			this.label1.Text = "Назва:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(505, 139);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 34);
			this.label2.TabIndex = 12;
			this.label2.Text = "Автор:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(505, 199);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(170, 34);
			this.label3.TabIndex = 13;
			this.label3.Text = "Видавництво:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(505, 265);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(157, 34);
			this.label4.TabIndex = 14;
			this.label4.Text = "Рік видання:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(505, 341);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(124, 34);
			this.label5.TabIndex = 15;
			this.label5.Text = "Сторінок:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(505, 409);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(235, 34);
			this.label6.TabIndex = 16;
			this.label6.Text = "К-ть примірників:";
			// 
			// txtTitle
			// 
			this.txtTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTitle.Location = new System.Drawing.Point(718, 80);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(210, 35);
			this.txtTitle.TabIndex = 6;
			this.txtTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTitleKeyPress);
			// 
			// txtAuthor
			// 
			this.txtAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAuthor.Location = new System.Drawing.Point(718, 139);
			this.txtAuthor.Name = "txtAuthor";
			this.txtAuthor.Size = new System.Drawing.Size(210, 35);
			this.txtAuthor.TabIndex = 7;
			this.txtAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAuthorKeyPress);
			// 
			// txtPublishingHouse
			// 
			this.txtPublishingHouse.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPublishingHouse.Location = new System.Drawing.Point(718, 199);
			this.txtPublishingHouse.Name = "txtPublishingHouse";
			this.txtPublishingHouse.Size = new System.Drawing.Size(210, 35);
			this.txtPublishingHouse.TabIndex = 8;
			this.txtPublishingHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPublishingHouseKeyPress);
			// 
			// txtYear
			// 
			this.txtYear.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtYear.Location = new System.Drawing.Point(718, 264);
			this.txtYear.Name = "txtYear";
			this.txtYear.Size = new System.Drawing.Size(210, 35);
			this.txtYear.TabIndex = 9;
			this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtYearKeyPress);
			// 
			// txtCopies
			// 
			this.txtCopies.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCopies.Location = new System.Drawing.Point(718, 409);
			this.txtCopies.Name = "txtCopies";
			this.txtCopies.Size = new System.Drawing.Size(210, 35);
			this.txtCopies.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(273, 27);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(389, 32);
			this.label7.TabIndex = 10;
			this.label7.Text = "Каталог електронної бібліотеки";
			// 
			// btnAddBook
			// 
			this.btnAddBook.BackColor = System.Drawing.Color.Silver;
			this.btnAddBook.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAddBook.Location = new System.Drawing.Point(42, 486);
			this.btnAddBook.Name = "btnAddBook";
			this.btnAddBook.Size = new System.Drawing.Size(140, 60);
			this.btnAddBook.TabIndex = 1;
			this.btnAddBook.Text = "Нова книга";
			this.btnAddBook.UseVisualStyleBackColor = false;
			this.btnAddBook.Click += new System.EventHandler(this.BtnAddBookClick);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.Silver;
			this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnUpdate.Location = new System.Drawing.Point(247, 486);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(188, 60);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "Переглянути все";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.Silver;
			this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnEdit.Location = new System.Drawing.Point(505, 486);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(140, 60);
			this.btnEdit.TabIndex = 3;
			this.btnEdit.Text = "Редагувати";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.BtnEditClick);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Silver;
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDelete.Location = new System.Drawing.Point(736, 486);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(140, 60);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Видалити";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// txtPages
			// 
			this.txtPages.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPages.Location = new System.Drawing.Point(718, 341);
			this.txtPages.Name = "txtPages";
			this.txtPages.Size = new System.Drawing.Size(210, 35);
			this.txtPages.TabIndex = 10;
			this.txtPages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPagesKeyPress);
			// 
			// Catalog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(940, 572);
			this.Controls.Add(this.txtPages);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAddBook);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtCopies);
			this.Controls.Add(this.txtYear);
			this.Controls.Add(this.txtPublishingHouse);
			this.Controls.Add(this.txtAuthor);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvCatalog);
			this.Name = "Catalog";
			this.Text = "Робота з каталогом";
			((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
