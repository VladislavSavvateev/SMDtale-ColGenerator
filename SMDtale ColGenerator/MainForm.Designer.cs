namespace SMDtale_ColGenerator {
	partial class MainForm {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.pbImage = new System.Windows.Forms.PictureBox();
			this.grpColor = new System.Windows.Forms.GroupBox();
			this.btnColorPicker = new System.Windows.Forms.Button();
			this.pbColor = new System.Windows.Forms.PictureBox();
			this.grpFile = new System.Windows.Forms.GroupBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
			this.grpColor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
			this.grpFile.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbImage
			// 
			this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbImage.Location = new System.Drawing.Point(12, 12);
			this.pbImage.Name = "pbImage";
			this.pbImage.Size = new System.Drawing.Size(512, 256);
			this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbImage.TabIndex = 0;
			this.pbImage.TabStop = false;
			this.pbImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseClick);
			this.pbImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseMove);
			// 
			// grpColor
			// 
			this.grpColor.Controls.Add(this.btnColorPicker);
			this.grpColor.Controls.Add(this.pbColor);
			this.grpColor.Enabled = false;
			this.grpColor.Location = new System.Drawing.Point(12, 274);
			this.grpColor.Name = "grpColor";
			this.grpColor.Size = new System.Drawing.Size(128, 58);
			this.grpColor.TabIndex = 1;
			this.grpColor.TabStop = false;
			this.grpColor.Text = "Выбор цвета";
			// 
			// btnColorPicker
			// 
			this.btnColorPicker.Location = new System.Drawing.Point(44, 24);
			this.btnColorPicker.Name = "btnColorPicker";
			this.btnColorPicker.Size = new System.Drawing.Size(75, 23);
			this.btnColorPicker.TabIndex = 1;
			this.btnColorPicker.Text = "Пипетка";
			this.btnColorPicker.UseVisualStyleBackColor = true;
			this.btnColorPicker.Click += new System.EventHandler(this.btnColorPicker_Click);
			// 
			// pbColor
			// 
			this.pbColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbColor.Location = new System.Drawing.Point(6, 19);
			this.pbColor.Name = "pbColor";
			this.pbColor.Size = new System.Drawing.Size(32, 32);
			this.pbColor.TabIndex = 0;
			this.pbColor.TabStop = false;
			// 
			// grpFile
			// 
			this.grpFile.Controls.Add(this.btnSave);
			this.grpFile.Controls.Add(this.btnOpen);
			this.grpFile.Location = new System.Drawing.Point(146, 274);
			this.grpFile.Name = "grpFile";
			this.grpFile.Size = new System.Drawing.Size(317, 47);
			this.grpFile.TabIndex = 2;
			this.grpFile.TabStop = false;
			this.grpFile.Text = "Открытие/сохранение";
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(152, 19);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(159, 23);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Сохранить файл коллизий...";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(6, 19);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(140, 23);
			this.btnOpen.TabIndex = 0;
			this.btnOpen.Text = "Открыть изображение...";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(536, 344);
			this.Controls.Add(this.grpFile);
			this.Controls.Add(this.grpColor);
			this.Controls.Add(this.pbImage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "SMDtale ColGenerator";
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
			this.grpColor.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
			this.grpFile.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbImage;
		private System.Windows.Forms.GroupBox grpColor;
		private System.Windows.Forms.Button btnColorPicker;
		private System.Windows.Forms.PictureBox pbColor;
		private System.Windows.Forms.GroupBox grpFile;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnOpen;
	}
}

