namespace GoogleQRCode
{
	partial class MainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.p1 = new System.Windows.Forms.Panel();
			this.txtContent = new System.Windows.Forms.TextBox();
			this.orpic = new System.Windows.Forms.PictureBox();
			this.p2 = new System.Windows.Forms.Panel();
			this.picOpenQr = new System.Windows.Forms.PictureBox();
			this.txtDencoder = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.exit = new System.Windows.Forms.PictureBox();
			this.print = new System.Windows.Forms.PictureBox();
			this.decod = new System.Windows.Forms.PictureBox();
			this.save = new System.Windows.Forms.PictureBox();
			this.open = new System.Windows.Forms.PictureBox();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.timeshowlable = new System.Windows.Forms.ToolStripStatusLabel();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.printDocument = new System.Drawing.Printing.PrintDocument();
			this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
			this.p1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.orpic)).BeginInit();
			this.p2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picOpenQr)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.print)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.decod)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.save)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.open)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// p1
			// 
			this.p1.Controls.Add(this.txtContent);
			this.p1.Controls.Add(this.orpic);
			this.p1.Location = new System.Drawing.Point(1, 59);
			this.p1.Name = "p1";
			this.p1.Size = new System.Drawing.Size(312, 342);
			this.p1.TabIndex = 1;
			// 
			// txtContent
			// 
			this.txtContent.Location = new System.Drawing.Point(3, 3);
			this.txtContent.Multiline = true;
			this.txtContent.Name = "txtContent";
			this.txtContent.Size = new System.Drawing.Size(306, 124);
			this.txtContent.TabIndex = 1;
			this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
			// 
			// orpic
			// 
			this.orpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.orpic.Location = new System.Drawing.Point(50, 133);
			this.orpic.Name = "orpic";
			this.orpic.Size = new System.Drawing.Size(262, 193);
			this.orpic.TabIndex = 0;
			this.orpic.TabStop = false;
			// 
			// p2
			// 
			this.p2.Controls.Add(this.picOpenQr);
			this.p2.Controls.Add(this.txtDencoder);
			this.p2.Location = new System.Drawing.Point(2, 57);
			this.p2.Name = "p2";
			this.p2.Size = new System.Drawing.Size(312, 342);
			this.p2.TabIndex = 2;
			this.p2.Visible = false;
			// 
			// picOpenQr
			// 
			this.picOpenQr.Location = new System.Drawing.Point(35, 15);
			this.picOpenQr.Name = "picOpenQr";
			this.picOpenQr.Size = new System.Drawing.Size(216, 192);
			this.picOpenQr.TabIndex = 1;
			this.picOpenQr.TabStop = false;
			// 
			// txtDencoder
			// 
			this.txtDencoder.BackColor = System.Drawing.Color.White;
			this.txtDencoder.Location = new System.Drawing.Point(3, 213);
			this.txtDencoder.Multiline = true;
			this.txtDencoder.Name = "txtDencoder";
			this.txtDencoder.Size = new System.Drawing.Size(303, 121);
			this.txtDencoder.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.exit);
			this.groupBox1.Controls.Add(this.print);
			this.groupBox1.Controls.Add(this.decod);
			this.groupBox1.Controls.Add(this.save);
			this.groupBox1.Controls.Add(this.open);
			this.groupBox1.Location = new System.Drawing.Point(1, -1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(312, 54);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// exit
			// 
			this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.exit.Image = global::GoogleQRCode.Properties.Resources.exit;
			this.exit.Location = new System.Drawing.Point(257, 9);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(42, 41);
			this.exit.TabIndex = 4;
			this.exit.TabStop = false;
			this.exit.Click += new System.EventHandler(this.exit_Click);
			this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
			this.exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.exit_MouseMove);
			// 
			// print
			// 
			this.print.Cursor = System.Windows.Forms.Cursors.Hand;
			this.print.Image = ((System.Drawing.Image)(resources.GetObject("print.Image")));
			this.print.Location = new System.Drawing.Point(199, 9);
			this.print.Name = "print";
			this.print.Size = new System.Drawing.Size(42, 41);
			this.print.TabIndex = 3;
			this.print.TabStop = false;
			this.print.Click += new System.EventHandler(this.print_Click);
			this.print.MouseLeave += new System.EventHandler(this.print_MouseLeave);
			this.print.MouseMove += new System.Windows.Forms.MouseEventHandler(this.print_MouseMove);
			// 
			// decod
			// 
			this.decod.Cursor = System.Windows.Forms.Cursors.Hand;
			this.decod.Image = global::GoogleQRCode.Properties.Resources.encoding;
			this.decod.Location = new System.Drawing.Point(136, 9);
			this.decod.Name = "decod";
			this.decod.Size = new System.Drawing.Size(42, 41);
			this.decod.TabIndex = 2;
			this.decod.TabStop = false;
			this.decod.Click += new System.EventHandler(this.decod_Click);
			this.decod.MouseLeave += new System.EventHandler(this.decod_MouseLeave);
			this.decod.MouseMove += new System.Windows.Forms.MouseEventHandler(this.decod_MouseMove);
			// 
			// save
			// 
			this.save.Cursor = System.Windows.Forms.Cursors.Hand;
			this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
			this.save.Location = new System.Drawing.Point(73, 10);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(42, 41);
			this.save.TabIndex = 1;
			this.save.TabStop = false;
			this.save.Click += new System.EventHandler(this.save_Click);
			this.save.MouseLeave += new System.EventHandler(this.save_MouseLeave);
			this.save.MouseMove += new System.Windows.Forms.MouseEventHandler(this.save_MouseMove);
			// 
			// open
			// 
			this.open.AccessibleDescription = "";
			this.open.Cursor = System.Windows.Forms.Cursors.Hand;
			this.open.Image = ((System.Drawing.Image)(resources.GetObject("open.Image")));
			this.open.Location = new System.Drawing.Point(12, 11);
			this.open.Name = "open";
			this.open.Size = new System.Drawing.Size(42, 41);
			this.open.TabIndex = 0;
			this.open.TabStop = false;
			this.open.Tag = "打开";
			this.open.Click += new System.EventHandler(this.open_Click);
			this.open.MouseLeave += new System.EventHandler(this.open_MouseLeave);
			this.open.MouseMove += new System.Windows.Forms.MouseEventHandler(this.open_MouseMove);
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.timeshowlable});
			this.statusStrip1.Location = new System.Drawing.Point(0, 404);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(314, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(299, 17);
			this.toolStripStatusLabel1.Spring = true;
			this.toolStripStatusLabel1.Text = "当前时间：";
			this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// timeshowlable
			// 
			this.timeshowlable.Name = "timeshowlable";
			this.timeshowlable.Size = new System.Drawing.Size(0, 17);
			// 
			// printDocument
			// 
			this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
			// 
			// skinEngine1
			// 
			this.skinEngine1.@__DrawButtonFocusRectangle = true;
			this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
			this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
			this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.skinEngine1.SerialNumber = "";
			this.skinEngine1.SkinFile = null;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 426);
			this.Controls.Add(this.p2);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.p1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QRCode";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.p1.ResumeLayout(false);
			this.p1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.orpic)).EndInit();
			this.p2.ResumeLayout(false);
			this.p2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picOpenQr)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.print)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.decod)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.save)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.open)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Panel p1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtContent;
		private System.Windows.Forms.PictureBox orpic;

		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.PictureBox open;
		private System.Windows.Forms.PictureBox save;
		private System.Windows.Forms.PictureBox exit;
		private System.Windows.Forms.PictureBox print;
		private System.Windows.Forms.PictureBox decod;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel timeshowlable;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Panel p2;
		private System.Windows.Forms.PictureBox picOpenQr;
		private System.Windows.Forms.TextBox txtDencoder;
		private System.Drawing.Printing.PrintDocument printDocument;
		private Sunisoft.IrisSkin.SkinEngine skinEngine1;

	}
}

