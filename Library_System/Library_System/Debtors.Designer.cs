/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: Ср 14.08.19
 * Время: 22:58
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Library_System
{
	partial class Debtors
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgvDebtors;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFine;
		private System.Windows.Forms.Button btnSetFine;
		private System.Windows.Forms.Button btnShowList;
		
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
			this.dgvDebtors = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFine = new System.Windows.Forms.TextBox();
			this.btnSetFine = new System.Windows.Forms.Button();
			this.btnShowList = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvDebtors)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDebtors
			// 
			this.dgvDebtors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDebtors.Location = new System.Drawing.Point(12, 26);
			this.dgvDebtors.Name = "dgvDebtors";
			this.dgvDebtors.Size = new System.Drawing.Size(533, 386);
			this.dgvDebtors.TabIndex = 0;
			this.dgvDebtors.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgvDebtorsMouseClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(566, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 76);
			this.label1.TabIndex = 4;
			this.label1.Text = "Розмір пені:";
			// 
			// txtFine
			// 
			this.txtFine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txtFine.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtFine.Location = new System.Drawing.Point(694, 91);
			this.txtFine.Name = "txtFine";
			this.txtFine.Size = new System.Drawing.Size(154, 35);
			this.txtFine.TabIndex = 1;
			this.txtFine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFineKeyPress);
			// 
			// btnSetFine
			// 
			this.btnSetFine.BackColor = System.Drawing.Color.Silver;
			this.btnSetFine.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSetFine.Location = new System.Drawing.Point(566, 150);
			this.btnSetFine.Name = "btnSetFine";
			this.btnSetFine.Size = new System.Drawing.Size(269, 66);
			this.btnSetFine.TabIndex = 2;
			this.btnSetFine.Text = "Встановити";
			this.btnSetFine.UseVisualStyleBackColor = false;
			this.btnSetFine.Click += new System.EventHandler(this.BtnSetFineClick);
			// 
			// btnShowList
			// 
			this.btnShowList.BackColor = System.Drawing.Color.Silver;
			this.btnShowList.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnShowList.Location = new System.Drawing.Point(566, 274);
			this.btnShowList.Name = "btnShowList";
			this.btnShowList.Size = new System.Drawing.Size(269, 84);
			this.btnShowList.TabIndex = 3;
			this.btnShowList.Text = "Переглянути боржників";
			this.btnShowList.UseVisualStyleBackColor = false;
			this.btnShowList.Click += new System.EventHandler(this.BtnShowListClick);
			// 
			// Debtors
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(914, 430);
			this.Controls.Add(this.btnShowList);
			this.Controls.Add(this.btnSetFine);
			this.Controls.Add(this.txtFine);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvDebtors);
			this.Name = "Debtors";
			this.Text = "Робота з боржниками";
			((System.ComponentModel.ISupportInitialize)(this.dgvDebtors)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
