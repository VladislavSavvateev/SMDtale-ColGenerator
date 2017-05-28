using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMDtale_ColGenerator {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		Bitmap mBitmap;
		Color? mColor;
		bool mIsPickerMode = false;

		private void btnOpen_Click(object sender, EventArgs e) {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = "Выберите графический файл";
			if (ofd.ShowDialog() != DialogResult.OK) return;
			try {
				mBitmap = new Bitmap(ofd.FileName);
				if (mBitmap.Width % 8 != 0) throw new Exception("Ширина изображения должна быть кратна 8!");
				if (mBitmap.Height % 8 != 0) throw new Exception("Высота изображения должна быть кратна 8!");
				pbImage.Image = mBitmap;
				pbColor.Image = null;
				if (pbImage.Width < 451)
					Size = new Size(552, pbImage.Size.Height + 126);
				else Size = new Size(pbImage.Size.Width + 40, pbImage.Size.Height + 126);
				grpColor.Top = pbImage.Size.Height + 18;
				grpFile.Top = pbImage.Size.Height + 18;
				if (!grpColor.Enabled) {
					grpColor.Enabled = true;
					btnSave.Enabled = true;
				}
			} catch (Exception ex) {
				mBitmap = null;
				mColor = null;
				pbImage.Image = mBitmap;
				pbColor.Image = null;
				pbImage.Size = new Size(512, 256);
				Size = new Size(552, 382);
				grpColor.Enabled = false;
				btnSave.Enabled = false;
				MessageBox.Show(ex.Message, "*_*", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnSave_Click(object sender, EventArgs e) {
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Title = "Куда сохранить файл?";
			sfd.Filter = "Бинарный файл|*.bin|Все файлы|*.*";
			if (sfd.ShowDialog() != DialogResult.OK) return;
			try {
				FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
				byte[] width = BitConverter.GetBytes((ushort)mBitmap.Width / 8);
				byte[] height = BitConverter.GetBytes((ushort)mBitmap.Height / 8);
				if (BitConverter.IsLittleEndian) {
					Array.Reverse(width);
					Array.Reverse(height);
					width = new byte[2] { width[2], width[3] };
					height = new byte[2] { height[2], height[3] };
				}
				fs.Write(width, 0, 2);
				fs.Write(height, 0, 2);
				for (int y = 0; y < mBitmap.Height; y += 8) {
					for (int x = 0; x < mBitmap.Width; x += 8) {
						if (mBitmap.GetPixel(x, y) == mColor) fs.WriteByte(255);
						else fs.WriteByte(0);
					}
				}
				fs.Close();
				MessageBox.Show("Операция успешно завершена!", "*_*", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} catch (Exception ex) { MessageBox.Show(ex.Message, "*_*", MessageBoxButtons.OK, MessageBoxIcon.Error); }
		}

		private void turnGUI(bool isEnabled) {
			grpColor.Enabled = isEnabled;
			grpFile.Enabled = isEnabled;
		}
		private void btnColorPicker_Click(object sender, EventArgs e) {
			mIsPickerMode = true;
			turnGUI(false);
		}
		private void pbImage_MouseMove(object sender, MouseEventArgs e) {
			if (!mIsPickerMode) return;

			mColor = mBitmap.GetPixel(e.X, e.Y);
			pbColor.Image = GenerateColorTile((Color) mColor, 32);
		}
		private Bitmap GenerateColorTile(Color color, int size) {
			Bitmap b = new Bitmap(size, size);
			for (int y = 0; y < size; y++)
				for (int x = 0; x < size; x++)
					b.SetPixel(x, y, color);
			return b;
		}
		private void pbImage_MouseClick(object sender, MouseEventArgs e) {
			if (!mIsPickerMode) return;

			mIsPickerMode = false;
			turnGUI(true);
		}

	}
}
