using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.google.zxing;
using ByteMatrix = com.google.zxing.common.ByteMatrix;
using EAN13Writer = com.google.zxing.oned.EAN13Writer;
using EAN8Writer = com.google.zxing.oned.EAN8Writer;
using MultiFormatWriter = com.google.zxing.MultiFormatWriter;
using System.IO;

namespace GoogleQRCode
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			this.skinEngine1.SkinFile = Application.StartupPath + "//skins//SportsGreen.ssk";
			this.p1.Visible = true;
			//this.p2.Visible = false;

			//用于实现PictureBox的鼠标移动过去的提示
			ToolTip toolTip = new ToolTip();
			toolTip.AutoPopDelay = 5000;//一下4个都是属性
			toolTip.InitialDelay = 1000;
			toolTip.ReshowDelay = 500;
			toolTip.ShowAlways = true;
			toolTip.SetToolTip(this.open, "打开");//参数1是button名,参数2是要显示的内容
			toolTip.SetToolTip(this.save, "保存");
			toolTip.SetToolTip(this.print,"打印二维码");
			toolTip.SetToolTip(this.decod,"解码");
			toolTip.SetToolTip(this.exit,"返回生成二维码");
		}


		private void txtContent_TextChanged(object sender, EventArgs e)
		{
			string content = txtContent.Text;
			if (content == "")
			{
				MessageBox.Show("请输入内容", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			ByteMatrix byteMatrix = new MultiFormatWriter().encode(content, BarcodeFormat.QR_CODE, 200, 200);
			Bitmap bitmap = toBitmap(byteMatrix);
			orpic.Image = bitmap;
			
		}

		public static Bitmap toBitmap(ByteMatrix matrix)
		{
			int width = matrix.Width;
			int height = matrix.Height;
			Bitmap bmap = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
			for (int x = 0; x < width; x++)
			{
				for (int y = 0; y < height; y++)
				{
					bmap.SetPixel(x, y, matrix.get_Renamed(x, y) != -1 ? ColorTranslator.FromHtml("0xFF000000") : ColorTranslator.FromHtml("0xFFFFFFFF"));
				}
			}
			return bmap;
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			this.timeshowlable.Text = DateTime.Now.ToString();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void exit_MouseMove(object sender, MouseEventArgs e)
		{
			System.Drawing.Bitmap map = new Bitmap(Application.StartupPath+@"\image\exit-1.png");
			this.exit.Image = map;
		}

		private void exit_MouseLeave(object sender, EventArgs e)
		{
			System.Drawing.Bitmap map = new Bitmap(Application.StartupPath + @"\image\exit.png");
			this.exit.Image = map;
		}

		private void print_MouseMove(object sender, MouseEventArgs e)
		{
			System.Drawing.Bitmap map = new Bitmap(Application.StartupPath + @"\image\print-1.png");
			this.print.Image = map;
		}

		private void print_MouseLeave(object sender, EventArgs e)
		{
			System.Drawing.Bitmap map = new Bitmap(Application.StartupPath + @"\image\print.png");
			this.print.Image = map;
		}

		private void open_MouseLeave(object sender, EventArgs e)
		{
			System.Drawing.Bitmap map = new Bitmap(Application.StartupPath + @"\image\open.png");
			this.open.Image = map;
		}

		private void open_MouseMove(object sender, MouseEventArgs e)
		{
			System.Drawing.Bitmap map = new Bitmap(Application.StartupPath + @"\image\open-1.png");
			this.open.Image = map;
		}

		private void save_MouseLeave(object sender, EventArgs e)
		{
			System.Drawing.Bitmap map = new Bitmap(Application.StartupPath + @"\image\save.png");
			this.save.Image = map;
		}

		private void save_MouseMove(object sender, MouseEventArgs e)
		{
			System.Drawing.Bitmap map = new Bitmap(Application.StartupPath + @"\image\save-1.png");
			this.save.Image = map;
		}

		private void decod_MouseMove(object sender, MouseEventArgs e)
		{
			System.Drawing.Bitmap map = new Bitmap(Application.StartupPath + @"\image\encoding-1.png");
			this.decod.Image = map;
		}

		private void decod_MouseLeave(object sender, EventArgs e)
		{
			System.Drawing.Bitmap map = new Bitmap(Application.StartupPath + @"\image\encoding.png");
			this.decod.Image = map;
		}

		private void open_Click(object sender, EventArgs e)
		{
			if (p1.Visible == true)
			{
				if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
				{
					return;
				}
				string path = this.openFileDialog1.FileName;
				openFileDialog1.DefaultExt = "*.txt";
				openFileDialog1.Filter = "*.txt|";
				if (path.EndsWith(".txt"))
				{
					string content = File.ReadAllText(path, Encoding.Default);
					this.txtContent.Text = content;
				}
				else
				{
					MessageBox.Show("只能读取txt文件","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			else
			{
				if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
				{
					return;
				}
				string path = this.openFileDialog1.FileName;
				if (!path.EndsWith(".png"))
				{
					MessageBox.Show("图像格式不正确，只能读取png文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					Image img = Image.FromFile(path);
					Bitmap bmap;
					try
					{
						bmap = new Bitmap(img);
					}
					catch (System.IO.IOException ioe)
					{
						MessageBox.Show(ioe.ToString());
						return;
					}
					if (bmap == null)
					{
						MessageBox.Show("Could not decode image");
						return;
					}
					else
					{
						this.picOpenQr.Image = bmap;
					}
					LuminanceSource source = new RGBLuminanceSource(bmap, bmap.Width, bmap.Height);
					com.google.zxing.BinaryBitmap bitmap = new com.google.zxing.BinaryBitmap(new com.google.zxing.common.HybridBinarizer(source));
					Result result;
					try
					{
						result = new MultiFormatReader().decode(bitmap);
					}
					catch (ReaderException re)
					{
						MessageBox.Show(re.ToString());
						return;
					}

					this.txtDencoder.Text = (result.Text);
				}
			}
		}

		private void save_Click(object sender, EventArgs e)
		{
			if (p1.Visible == true)
			{
				saveFileDialog1.Filter = "*.png|";
				//saveFileDialog1.DefaultExt = "*.png";
				saveFileDialog1.RestoreDirectory = true;
				if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					string localPath = saveFileDialog1.FileName.ToString();
					Image qrcode = orpic.Image;
					if (qrcode == null)
					{
						MessageBox.Show("无保存项", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						if (localPath.EndsWith(".png"))
						{
							qrcode.Save(localPath);
						}
						else
						{
							qrcode.Save(localPath + ".png");
						}

					}
				}
			}
			else
			{
				saveFileDialog1.Filter = "*.txt|";
				//saveFileDialog1.DefaultExt = "*.txt";
				if(this.saveFileDialog1.ShowDialog()==DialogResult.OK)
				{
					string localPath = saveFileDialog1.FileName.ToString()+".txt";
					if (File.Exists(localPath))
					{
						DialogResult RESULT = MessageBox.Show("是否确认覆盖原有文件?", "信息提示", MessageBoxButtons.YesNo);
						if (RESULT.ToString().Equals("Yes"))
						{
							File.Delete(localPath);
							File.AppendAllText(localPath, this.txtDencoder.Text, Encoding.Default);
						}
						else
						{
							return;
						}
					}
					else
					{
						File.AppendAllText(localPath, this.txtDencoder.Text, Encoding.Default);
					}
				}
			}
		}

		private void exit_Click(object sender, EventArgs e)
		{
			this.p2.Visible = false;
			this.p1.Visible=true;
		}

		private void decod_Click(object sender, EventArgs e)
		{
			this.p2.Visible=true;
			this.p1.Visible = !(p1.Visible);
		}

		private void print_Click(object sender, EventArgs e)
		{
			PrintDialog printDialog = new PrintDialog();
			printDialog.Document = printDocument;
			if (printDialog.ShowDialog() == DialogResult.OK) { try
                {
                    printDocument.Print();
                }
                catch
                {   //停止打印
                    printDocument.PrintController.OnEndPrint(printDocument, new System.Drawing.Printing.PrintEventArgs());
                }
            }
        }

		private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			if (this.p1.Visible == true)
			{
				e.Graphics.DrawImage(this.orpic.Image, 20, 20);
			}
			else
			{
				e.Graphics.DrawImage(this.picOpenQr.Image, 20, 20);
			}
		}
	}
}
