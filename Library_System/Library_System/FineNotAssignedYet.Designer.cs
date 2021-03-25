/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: Ср 21.08.19
 * Время: 17:49
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Library_System
{
	partial class FineNotAssignedYet
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox rtbWarning;
		
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
			this.rtbWarning = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// rtbWarning
			// 
			this.rtbWarning.BackColor = System.Drawing.Color.Red;
			this.rtbWarning.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbWarning.Location = new System.Drawing.Point(0, 0);
			this.rtbWarning.Name = "rtbWarning";
			this.rtbWarning.Size = new System.Drawing.Size(965, 564);
			this.rtbWarning.TabIndex = 0;
			this.rtbWarning.Text = "";
			// 
			// FineNotAssignedYet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(964, 562);
			this.Controls.Add(this.rtbWarning);
			this.Name = "FineNotAssignedYet";
			this.Text = "ПЕНЯ НАБЛИЖАЄТЬСЯ!!!";
			this.Load += new System.EventHandler(this.FineNotAssignedYetLoad);
			this.ResumeLayout(false);

		}
	}
}
