/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: Ср 14.08.19
 * Время: 23:50
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Library_System
{
	partial class FineAssigned
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox rtbWarning;
		private System.Windows.Forms.Button btnPayFine;
				
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
			this.btnPayFine = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rtbWarning
			// 
			this.rtbWarning.BackColor = System.Drawing.Color.Red;
			this.rtbWarning.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtbWarning.Location = new System.Drawing.Point(0, 0);
			this.rtbWarning.Name = "rtbWarning";
			this.rtbWarning.Size = new System.Drawing.Size(969, 567);
			this.rtbWarning.TabIndex = 0;
			this.rtbWarning.Text = "";
			// 
			// btnPayFine
			// 
			this.btnPayFine.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnPayFine.Location = new System.Drawing.Point(718, 447);
			this.btnPayFine.Name = "btnPayFine";
			this.btnPayFine.Size = new System.Drawing.Size(234, 103);
			this.btnPayFine.TabIndex = 0;
			this.btnPayFine.Text = "СПЛАТИТИ ПЕНЮ";
			this.btnPayFine.UseVisualStyleBackColor = true;
			this.btnPayFine.Click += new System.EventHandler(this.BtnPayFineClick);
			// 
			// FineAssigned
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(964, 562);
			this.Controls.Add(this.btnPayFine);
			this.Controls.Add(this.rtbWarning);
			this.Name = "FineAssigned";
			this.Text = "ПЕНЯ!!!";
			this.Load += new System.EventHandler(this.FineAssignedLoad);
			this.ResumeLayout(false);

		}
	}
}
