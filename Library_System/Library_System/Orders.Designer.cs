/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: Пт 23.08.19
 * Время: 19:55
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Library_System
{
	partial class Orders
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtPages;
		private System.Windows.Forms.Button btnOrder;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtYear;
		private System.Windows.Forms.TextBox txtPublishingHouse;
		private System.Windows.Forms.TextBox txtAuthor;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvCatalog;
		
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
			this.txtPages = new System.Windows.Forms.TextBox();
			this.btnOrder = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.txtYear = new System.Windows.Forms.TextBox();
			this.txtPublishingHouse = new System.Windows.Forms.TextBox();
			this.txtAuthor = new System.Windows.Forms.TextBox();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvCatalog = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).BeginInit();
			this.SuspendLayout();
			// 
			// txtPages
			// 
			this.txtPages.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPages.Location = new System.Drawing.Point(718, 374);
			this.txtPages.Name = "txtPages";
			this.txtPages.Size = new System.Drawing.Size(210, 35);
			this.txtPages.TabIndex = 22;
			// 
			// btnOrder
			// 
			this.btnOrder.BackColor = System.Drawing.Color.Silver;
			this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOrder.Location = new System.Drawing.Point(259, 431);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(444, 107);
			this.btnOrder.TabIndex = 1;
			this.btnOrder.Text = "Замовити";
			this.btnOrder.UseVisualStyleBackColor = false;
			this.btnOrder.Click += new System.EventHandler(this.BtnOrderClick);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(273, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(389, 32);
			this.label7.TabIndex = 28;
			this.label7.Text = "Каталог електронної бібліотеки";
			// 
			// txtYear
			// 
			this.txtYear.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtYear.Location = new System.Drawing.Point(718, 292);
			this.txtYear.Name = "txtYear";
			this.txtYear.Size = new System.Drawing.Size(210, 35);
			this.txtYear.TabIndex = 20;
			// 
			// txtPublishingHouse
			// 
			this.txtPublishingHouse.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPublishingHouse.Location = new System.Drawing.Point(718, 202);
			this.txtPublishingHouse.Name = "txtPublishingHouse";
			this.txtPublishingHouse.Size = new System.Drawing.Size(210, 35);
			this.txtPublishingHouse.TabIndex = 18;
			// 
			// txtAuthor
			// 
			this.txtAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAuthor.Location = new System.Drawing.Point(718, 124);
			this.txtAuthor.Name = "txtAuthor";
			this.txtAuthor.Size = new System.Drawing.Size(210, 35);
			this.txtAuthor.TabIndex = 16;
			// 
			// txtTitle
			// 
			this.txtTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTitle.Location = new System.Drawing.Point(718, 44);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(210, 35);
			this.txtTitle.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(505, 374);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(124, 34);
			this.label5.TabIndex = 21;
			this.label5.Text = "Сторінок:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(505, 293);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(157, 34);
			this.label4.TabIndex = 19;
			this.label4.Text = "Рік видання:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(505, 202);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(170, 34);
			this.label3.TabIndex = 17;
			this.label3.Text = "Видавництво:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(505, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 34);
			this.label2.TabIndex = 15;
			this.label2.Text = "Автор:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(505, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 34);
			this.label1.TabIndex = 13;
			this.label1.Text = "Назва:";
			// 
			// dgvCatalog
			// 
			this.dgvCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCatalog.Location = new System.Drawing.Point(12, 44);
			this.dgvCatalog.Name = "dgvCatalog";
			this.dgvCatalog.Size = new System.Drawing.Size(487, 364);
			this.dgvCatalog.TabIndex = 0;
			this.dgvCatalog.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgvCatalogMouseClick);
			// 
			// Orders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(940, 572);
			this.Controls.Add(this.txtPages);
			this.Controls.Add(this.btnOrder);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtYear);
			this.Controls.Add(this.txtPublishingHouse);
			this.Controls.Add(this.txtAuthor);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvCatalog);
			this.Name = "Orders";
			this.Text = "Мої замовлення";
			((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
