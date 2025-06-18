using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.Win32.SafeHandles;

namespace HID_PnP_Demo
{
	// Token: 0x02000003 RID: 3
	public class Form1 : Form
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002067 File Offset: 0x00000267
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002088 File Offset: 0x00000288
		private void InitializeComponent()
		{
			this.components = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			this.PushbuttonState_lbl = new System.Windows.Forms.Label();
			this.ToggleLEDs_btn = new System.Windows.Forms.Button();
			this.ANxVoltage_lbl = new System.Windows.Forms.Label();
			this.StatusBox_lbl = new System.Windows.Forms.Label();
			this.StatusBox_txtbx = new System.Windows.Forms.TextBox();
			this.progressBar1 = new ProgressBar();
			this.ReadWriteThread = new BackgroundWorker();
			this.FormUpdateTimer = new System.Windows.Forms.Timer(this.components);
			this.ANxVoltageToolTip = new ToolTip(this.components);
			this.ToggleLEDToolTip = new ToolTip(this.components);
			this.PushbuttonStateTooltip = new ToolTip(this.components);
			this.toolTip1 = new ToolTip(this.components);
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel3 = new Panel();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.button12 = new System.Windows.Forms.Button();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.button11 = new System.Windows.Forms.Button();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.panel2 = new Panel();
			this.radioButton1 = new RadioButton();
			this.label10 = new System.Windows.Forms.Label();
			this.radioButton2 = new RadioButton();
			this.panel1 = new Panel();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.dataGridView1 = new DataGridView();
			this.c1 = new DataGridViewTextBoxColumn();
			this.c2 = new DataGridViewTextBoxColumn();
			this.c3 = new DataGridViewTextBoxColumn();
			this.c4 = new DataGridViewTextBoxColumn();
			this.c5 = new DataGridViewTextBoxColumn();
			this.c6 = new DataGridViewTextBoxColumn();
			this.t_kart = new DataGridViewTextBoxColumn();
			this.onay = new DataGridViewButtonColumn();
			this.label13 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.button10 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.contextMenuStrip3 = new ContextMenuStrip(this.components);
			this.toolStripMenuItem1 = new ToolStripMenuItem();
			this.toolStripMenuItem2 = new ToolStripMenuItem();
			this.toolStrip1 = new ToolStrip();
			this.statusStrip1 = new StatusStrip();
			this.toolStripProgressBar1 = new ToolStripProgressBar();
			this.toolStripStatusLabel1 = new ToolStripStatusLabel();
			this.openFileDialog2 = new OpenFileDialog();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.dataGridView1).BeginInit();
			this.contextMenuStrip3.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.PushbuttonState_lbl.AutoSize = true;
			this.PushbuttonState_lbl.Enabled = false;
			this.PushbuttonState_lbl.Location = new System.Drawing.Point(141, 376);
			this.PushbuttonState_lbl.Name = "PushbuttonState_lbl";
			this.PushbuttonState_lbl.Size = new Size(141, 13);
			this.PushbuttonState_lbl.TabIndex = 25;
			this.PushbuttonState_lbl.Text = "Pushbutton State: Unknown";
			this.PushbuttonState_lbl.Click += this.PushbuttonState_lbl_Click;
			this.ToggleLEDs_btn.Enabled = false;
			this.ToggleLEDs_btn.Location = new System.Drawing.Point(23, 376);
			this.ToggleLEDs_btn.Name = "ToggleLEDs_btn";
			this.ToggleLEDs_btn.Size = new Size(96, 23);
			this.ToggleLEDs_btn.TabIndex = 24;
			this.ToggleLEDs_btn.Text = "ToggleLED(s)";
			this.ToggleLEDs_btn.UseVisualStyleBackColor = true;
			this.ToggleLEDs_btn.Click += this.ToggleLEDs_btn_Click;
			this.ANxVoltage_lbl.AutoSize = true;
			this.ANxVoltage_lbl.Enabled = false;
			this.ANxVoltage_lbl.Location = new System.Drawing.Point(151, 401);
			this.ANxVoltage_lbl.Name = "ANxVoltage_lbl";
			this.ANxVoltage_lbl.Size = new Size(93, 13);
			this.ANxVoltage_lbl.TabIndex = 23;
			this.ANxVoltage_lbl.Text = "ANx/POT Voltage";
			this.ANxVoltage_lbl.Click += this.ANxVoltage_lbl_Click;
			this.StatusBox_lbl.AutoSize = true;
			this.StatusBox_lbl.Location = new System.Drawing.Point(310, 376);
			this.StatusBox_lbl.Name = "StatusBox_lbl";
			this.StatusBox_lbl.Size = new Size(37, 13);
			this.StatusBox_lbl.TabIndex = 22;
			this.StatusBox_lbl.Text = "Status";
			this.StatusBox_lbl.Click += this.StatusBox_lbl_Click;
			this.StatusBox_txtbx.BackColor = SystemColors.Window;
			this.StatusBox_txtbx.Location = new System.Drawing.Point(23, 339);
			this.StatusBox_txtbx.Name = "StatusBox_txtbx";
			this.StatusBox_txtbx.ReadOnly = true;
			this.StatusBox_txtbx.Size = new Size(298, 20);
			this.StatusBox_txtbx.TabIndex = 21;
			this.progressBar1.BackColor = Color.White;
			this.progressBar1.ForeColor = Color.Red;
			this.progressBar1.Location = new System.Drawing.Point(23, 417);
			this.progressBar1.Maximum = 1024;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new Size(298, 23);
			this.progressBar1.Step = 1;
			this.progressBar1.Style = ProgressBarStyle.Continuous;
			this.progressBar1.TabIndex = 20;
			this.ReadWriteThread.WorkerReportsProgress = true;
			this.ReadWriteThread.DoWork += this.ReadWriteThread_DoWork;
			this.FormUpdateTimer.Enabled = true;
			this.FormUpdateTimer.Interval = 6;
			this.FormUpdateTimer.Tick += this.FormUpdateTimer_Tick;
			this.ANxVoltageToolTip.AutomaticDelay = 20;
			this.ANxVoltageToolTip.AutoPopDelay = 20000;
			this.ANxVoltageToolTip.InitialDelay = 15;
			this.ANxVoltageToolTip.ReshowDelay = 15;
			this.ToggleLEDToolTip.AutomaticDelay = 2000;
			this.ToggleLEDToolTip.AutoPopDelay = 20000;
			this.ToggleLEDToolTip.InitialDelay = 15;
			this.ToggleLEDToolTip.ReshowDelay = 15;
			this.PushbuttonStateTooltip.AutomaticDelay = 20;
			this.PushbuttonStateTooltip.AutoPopDelay = 20000;
			this.PushbuttonStateTooltip.InitialDelay = 15;
			this.PushbuttonStateTooltip.ReshowDelay = 15;
			this.toolTip1.AutomaticDelay = 2000;
			this.toolTip1.AutoPopDelay = 20000;
			this.toolTip1.InitialDelay = 15;
			this.toolTip1.ReshowDelay = 15;
			this.textBox1.Location = new System.Drawing.Point(72, 446);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new Size(203, 20);
			this.textBox1.TabIndex = 26;
			this.panel3.BackColor = Color.Brown;
			this.panel3.Controls.Add(this.textBox8);
			this.panel3.Controls.Add(this.button12);
			this.panel3.Controls.Add(this.textBox7);
			this.panel3.Controls.Add(this.label14);
			this.panel3.Controls.Add(this.button11);
			this.panel3.Controls.Add(this.textBox6);
			this.panel3.Controls.Add(this.label12);
			this.panel3.Controls.Add(this.button9);
			this.panel3.Controls.Add(this.button8);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.panel2);
			this.panel3.Controls.Add(this.panel1);
			this.panel3.Controls.Add(this.button1);
			this.panel3.Controls.Add(this.textBox3);
			this.panel3.Controls.Add(this.textBox2);
			this.panel3.Controls.Add(this.button3);
			this.panel3.Controls.Add(this.button2);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.dataGridView1);
			this.panel3.Controls.Add(this.label13);
			this.panel3.Controls.Add(this.button5);
			this.panel3.Controls.Add(this.button4);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.textBox1);
			this.panel3.Controls.Add(this.button10);
			this.panel3.Location = new System.Drawing.Point(-1, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size(872, 596);
			this.panel3.TabIndex = 53;
			this.textBox8.BackColor = SystemColors.ScrollBar;
			this.textBox8.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.textBox8.Location = new System.Drawing.Point(72, 13);
			this.textBox8.MaxLength = 6;
			this.textBox8.Name = "textBox8";
			this.textBox8.PasswordChar = '*';
			this.textBox8.Size = new Size(81, 21);
			this.textBox8.TabIndex = 113;
			this.textBox8.TextAlign = HorizontalAlignment.Center;
			this.textBox8.DoubleClick += this.textBox8_DoubleClick;
			this.textBox8.KeyUp += this.textBox8_KeyUp;
			this.button12.BackColor = Color.DarkSalmon;
			this.button12.Enabled = false;
			this.button12.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.button12.ForeColor = Color.DarkBlue;
			this.button12.Location = new System.Drawing.Point(159, 80);
			this.button12.Name = "button12";
			this.button12.Size = new Size(36, 21);
			this.button12.TabIndex = 141;
			this.button12.Text = "K";
			this.button12.UseVisualStyleBackColor = false;
			this.button12.Visible = false;
			this.button12.Click += this.button12_Click;
			this.textBox7.BackColor = SystemColors.ScrollBar;
			this.textBox7.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.textBox7.Location = new System.Drawing.Point(113, 80);
			this.textBox7.MaxLength = 3;
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new Size(40, 21);
			this.textBox7.TabIndex = 140;
			this.textBox7.TextAlign = HorizontalAlignment.Center;
			this.textBox7.TextChanged += this.textBox7_TextChanged;
			this.label14.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label14.Location = new System.Drawing.Point(16, 76);
			this.label14.Name = "label14";
			this.label14.Size = new Size(103, 30);
			this.label14.TabIndex = 139;
			this.label14.Text = "RÖLE SÜRESİ:";
			this.label14.TextAlign = ContentAlignment.MiddleCenter;
			this.button11.BackColor = Color.DarkSalmon;
			this.button11.Enabled = false;
			this.button11.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.button11.ForeColor = Color.DarkBlue;
			this.button11.Location = new System.Drawing.Point(159, 46);
			this.button11.Name = "button11";
			this.button11.Size = new Size(36, 21);
			this.button11.TabIndex = 138;
			this.button11.Text = "K";
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Visible = false;
			this.button11.Click += this.button11_Click;
			this.textBox6.BackColor = SystemColors.ScrollBar;
			this.textBox6.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.textBox6.Location = new System.Drawing.Point(113, 46);
			this.textBox6.MaxLength = 3;
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new Size(40, 21);
			this.textBox6.TabIndex = 136;
			this.textBox6.TextAlign = HorizontalAlignment.Center;
			this.textBox6.TextChanged += this.textBox6_TextChanged;
			this.label12.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label12.Location = new System.Drawing.Point(9, 34);
			this.label12.Name = "label12";
			this.label12.Size = new Size(111, 47);
			this.label12.TabIndex = 137;
			this.label12.Text = "Aynı Etiket Okuma Aralığı";
			this.label12.TextAlign = ContentAlignment.MiddleCenter;
			this.button9.BackColor = Color.FromArgb(192, 0, 0);
			this.button9.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
			this.button9.ForeColor = Color.Black;
			this.button9.Location = new System.Drawing.Point(734, 549);
			this.button9.Name = "button9";
			this.button9.Size = new Size(107, 38);
			this.button9.TabIndex = 135;
			this.button9.Text = "OKUYUCUYU SIFIRLA";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += this.button9_Click;
			this.button8.BackColor = Color.PaleGreen;
			this.button8.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.button8.ForeColor = Color.DarkBlue;
			this.button8.Location = new System.Drawing.Point(544, 549);
			this.button8.Name = "button8";
			this.button8.Size = new Size(142, 28);
			this.button8.TabIndex = 134;
			this.button8.Text = "TANIMSIZ KARTLAR";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += this.button8_Click;
			this.label11.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label11.Location = new System.Drawing.Point(651, 118);
			this.label11.Name = "label11";
			this.label11.Size = new Size(119, 22);
			this.label11.TabIndex = 132;
			this.label11.Text = "Tanımsız Kartno";
			this.label11.TextAlign = ContentAlignment.MiddleCenter;
			this.panel2.Controls.Add(this.radioButton1);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.radioButton2);
			this.panel2.Location = new System.Drawing.Point(617, 54);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(181, 39);
			this.panel2.TabIndex = 131;
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(102, 3);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new Size(59, 17);
			this.radioButton1.TabIndex = 129;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "EXCEL";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.label10.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label10.Location = new System.Drawing.Point(3, 10);
			this.label10.Name = "label10";
			this.label10.Size = new Size(99, 23);
			this.label10.TabIndex = 128;
			this.label10.Text = "DOSYA TÜRÜ :";
			this.label10.TextAlign = ContentAlignment.MiddleCenter;
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(102, 21);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new Size(46, 17);
			this.radioButton2.TabIndex = 130;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "TXT";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.panel1.BackColor = Color.Khaki;
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.textBox5);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.textBox4);
			this.panel1.Location = new System.Drawing.Point(209, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(203, 109);
			this.panel1.TabIndex = 127;
			this.panel1.Visible = false;
			this.button7.BackColor = Color.Gold;
			this.button7.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
			this.button7.ForeColor = Color.Black;
			this.button7.Location = new System.Drawing.Point(4, 62);
			this.button7.Name = "button7";
			this.button7.Size = new Size(84, 28);
			this.button7.TabIndex = 122;
			this.button7.Text = "VAZGEÇ";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += this.button7_Click;
			this.button6.BackColor = Color.Maroon;
			this.button6.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
			this.button6.ForeColor = Color.AliceBlue;
			this.button6.Location = new System.Drawing.Point(107, 62);
			this.button6.Name = "button6";
			this.button6.Size = new Size(84, 28);
			this.button6.TabIndex = 121;
			this.button6.Text = "KAYDET";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += this.button6_Click;
			this.label2.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label2.Location = new System.Drawing.Point(113, 0);
			this.label2.Name = "label2";
			this.label2.Size = new Size(72, 22);
			this.label2.TabIndex = 120;
			this.label2.Text = "Yeni Şifre";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			this.textBox5.BackColor = SystemColors.ScrollBar;
			this.textBox5.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.textBox5.Location = new System.Drawing.Point(107, 25);
			this.textBox5.MaxLength = 6;
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new Size(84, 21);
			this.textBox5.TabIndex = 119;
			this.textBox5.TextAlign = HorizontalAlignment.Center;
			this.label1.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label1.Location = new System.Drawing.Point(17, 2);
			this.label1.Name = "label1";
			this.label1.Size = new Size(72, 22);
			this.label1.TabIndex = 118;
			this.label1.Text = "Yeni Şifre";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			this.textBox4.BackColor = SystemColors.ScrollBar;
			this.textBox4.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.textBox4.Location = new System.Drawing.Point(10, 26);
			this.textBox4.MaxLength = 6;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new Size(84, 21);
			this.textBox4.TabIndex = 114;
			this.textBox4.TextAlign = HorizontalAlignment.Center;
			this.button1.BackColor = Color.DarkSalmon;
			this.button1.Enabled = false;
			this.button1.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.button1.ForeColor = Color.DarkBlue;
			this.button1.Location = new System.Drawing.Point(159, 12);
			this.button1.Name = "button1";
			this.button1.Size = new Size(36, 21);
			this.button1.TabIndex = 111;
			this.button1.Text = "Ş";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Visible = false;
			this.button1.Click += this.button1_Click;
			this.textBox3.BackColor = SystemColors.ScrollBar;
			this.textBox3.Enabled = false;
			this.textBox3.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.textBox3.Location = new System.Drawing.Point(222, 12);
			this.textBox3.MaxLength = 6;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new Size(82, 21);
			this.textBox3.TabIndex = 126;
			this.textBox3.TextAlign = HorizontalAlignment.Center;
			this.textBox3.Visible = false;
			this.textBox2.BackColor = SystemColors.ScrollBar;
			this.textBox2.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.textBox2.Location = new System.Drawing.Point(392, 547);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new Size(75, 21);
			this.textBox2.TabIndex = 125;
			this.textBox2.TextAlign = HorizontalAlignment.Center;
			this.button3.BackColor = Color.Yellow;
			this.button3.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
			this.button3.ForeColor = Color.DarkBlue;
			this.button3.Location = new System.Drawing.Point(32, 547);
			this.button3.Name = "button3";
			this.button3.Size = new Size(114, 43);
			this.button3.TabIndex = 124;
			this.button3.Text = "OKUYUCUDAN OKU";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += this.button3_Click;
			this.button2.BackColor = Color.Yellow;
			this.button2.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
			this.button2.ForeColor = Color.DarkBlue;
			this.button2.Location = new System.Drawing.Point(176, 547);
			this.button2.Name = "button2";
			this.button2.Size = new Size(107, 43);
			this.button2.TabIndex = 123;
			this.button2.Text = "OKUYUCUYA YÜKLE";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += this.button2_Click;
			this.label6.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label6.Location = new System.Drawing.Point(568, 118);
			this.label6.Name = "label6";
			this.label6.Size = new Size(54, 22);
			this.label6.TabIndex = 122;
			this.label6.Text = "Alan5";
			this.label6.TextAlign = ContentAlignment.MiddleCenter;
			this.label5.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label5.Location = new System.Drawing.Point(477, 118);
			this.label5.Name = "label5";
			this.label5.Size = new Size(54, 22);
			this.label5.TabIndex = 121;
			this.label5.Text = "Alan4";
			this.label5.TextAlign = ContentAlignment.MiddleCenter;
			this.label4.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label4.Location = new System.Drawing.Point(369, 118);
			this.label4.Name = "label4";
			this.label4.Size = new Size(54, 22);
			this.label4.TabIndex = 120;
			this.label4.Text = "Alan3";
			this.label4.TextAlign = ContentAlignment.MiddleCenter;
			this.label3.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label3.Location = new System.Drawing.Point(270, 118);
			this.label3.Name = "label3";
			this.label3.Size = new Size(54, 22);
			this.label3.TabIndex = 119;
			this.label3.Text = "Alan2";
			this.label3.TextAlign = ContentAlignment.MiddleCenter;
			this.label7.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label7.Location = new System.Drawing.Point(166, 118);
			this.label7.Name = "label7";
			this.label7.Size = new Size(54, 22);
			this.label7.TabIndex = 118;
			this.label7.Text = "Alan1";
			this.label7.TextAlign = ContentAlignment.MiddleCenter;
			this.label9.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label9.Location = new System.Drawing.Point(55, 118);
			this.label9.Name = "label9";
			this.label9.Size = new Size(54, 22);
			this.label9.TabIndex = 117;
			this.label9.Text = "Kartno";
			this.label9.TextAlign = ContentAlignment.MiddleCenter;
			this.dataGridView1.BackgroundColor = Color.BurlyWood;
			this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.ColumnHeadersVisible = false;
			this.dataGridView1.Columns.AddRange(new DataGridViewColumn[]
			{
				this.c1,
				this.c2,
				this.c3,
				this.c4,
				this.c5,
				this.c6,
				this.t_kart,
				this.onay
			});
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = SystemColors.Window;
			dataGridViewCellStyle.Font = new System.Drawing.Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = Color.DarkRed;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView1.Location = new System.Drawing.Point(28, 139);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new Size(813, 402);
			this.dataGridView1.TabIndex = 116;
			this.dataGridView1.MouseDown += this.dataGridView1_MouseDown_1;
			this.dataGridView1.CellEndEdit += this.dataGridView1_CellEndEdit_1;
			this.dataGridView1.CellClick += this.dataGridView1_CellClick;
			this.dataGridView1.KeyUp += this.dataGridView1_KeyUp;
			this.c1.FillWeight = 120f;
			this.c1.HeaderText = "kart";
			this.c1.MaxInputLength = 8;
			this.c1.MinimumWidth = 8;
			this.c1.Name = "c1";
			this.c1.Width = 120;
			this.c2.HeaderText = "alan1";
			this.c2.MaxInputLength = 30;
			this.c2.Name = "c2";
			this.c3.HeaderText = "alan2";
			this.c3.MaxInputLength = 30;
			this.c3.Name = "c3";
			this.c3.Resizable = DataGridViewTriState.True;
			this.c3.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.c4.HeaderText = "alan3";
			this.c4.MaxInputLength = 30;
			this.c4.Name = "c4";
			this.c4.Resizable = DataGridViewTriState.True;
			this.c4.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.c5.HeaderText = "alan4";
			this.c5.MaxInputLength = 30;
			this.c5.Name = "c5";
			this.c5.Resizable = DataGridViewTriState.True;
			this.c5.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.c6.HeaderText = "alan5";
			this.c6.MaxInputLength = 30;
			this.c6.Name = "c6";
			this.c6.Resizable = DataGridViewTriState.True;
			this.c6.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.t_kart.FillWeight = 120f;
			this.t_kart.HeaderText = "t_kart";
			this.t_kart.MaxInputLength = 8;
			this.t_kart.MinimumWidth = 8;
			this.t_kart.Name = "t_kart";
			this.t_kart.Width = 120;
			this.onay.FillWeight = 60f;
			this.onay.HeaderText = "";
			this.onay.Name = "onay";
			this.onay.Text = "";
			this.onay.UseColumnTextForButtonValue = true;
			this.onay.Width = 60;
			this.label13.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
			this.label13.Location = new System.Drawing.Point(276, 90);
			this.label13.Name = "label13";
			this.label13.Size = new Size(100, 22);
			this.label13.TabIndex = 115;
			this.label13.Text = "LİSTE";
			this.label13.TextAlign = ContentAlignment.MiddleCenter;
			this.button5.BackColor = Color.OrangeRed;
			this.button5.Enabled = false;
			this.button5.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.button5.ForeColor = Color.DarkBlue;
			this.button5.Location = new System.Drawing.Point(790, 446);
			this.button5.Name = "button5";
			this.button5.Size = new Size(82, 41);
			this.button5.TabIndex = 114;
			this.button5.Text = "MASTER SIFIRLA";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Visible = false;
			this.button5.Click += this.button5_Click_1;
			this.button4.BackColor = Color.Red;
			this.button4.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
			this.button4.ForeColor = Color.DarkBlue;
			this.button4.Location = new System.Drawing.Point(618, 12);
			this.button4.Name = "button4";
			this.button4.Size = new Size(103, 43);
			this.button4.TabIndex = 112;
			this.button4.Text = "DOSYA AÇ";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += this.button4_Click;
			this.label8.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label8.Location = new System.Drawing.Point(17, 11);
			this.label8.Name = "label8";
			this.label8.Size = new Size(64, 23);
			this.label8.TabIndex = 52;
			this.label8.Text = "ŞİFRE :";
			this.label8.TextAlign = ContentAlignment.MiddleCenter;
			this.button10.BackColor = Color.Red;
			this.button10.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
			this.button10.ForeColor = Color.DarkBlue;
			this.button10.Location = new System.Drawing.Point(745, 12);
			this.button10.Name = "button10";
			this.button10.Size = new Size(103, 43);
			this.button10.TabIndex = 110;
			this.button10.Text = "DOSYAYA KAYDET";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += this.button10_Click_1;
			this.timer1.Enabled = true;
			this.timer1.Tick += this.timer1_Tick;
			this.timer2.Interval = 50;
			this.timer2.Tick += this.timer2_Tick;
			this.timer3.Tick += this.timer3_Tick;
			this.contextMenuStrip3.BackColor = Color.Silver;
			this.contextMenuStrip3.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem1,
				this.toolStripMenuItem2
			});
			this.contextMenuStrip3.Name = "contextMenuStrip1";
			this.contextMenuStrip3.Size = new Size(144, 48);
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new Size(143, 22);
			this.toolStripMenuItem1.Text = "Seçili satırı sil";
			this.toolStripMenuItem1.Click += this.toolStripMenuItem1_Click;
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new Size(143, 22);
			this.toolStripMenuItem2.Text = "Sırala";
			this.toolStripMenuItem2.Click += this.toolStripMenuItem2_Click;
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new Size(871, 25);
			this.toolStrip1.TabIndex = 56;
			this.toolStrip1.Text = "toolStrip1";
			this.statusStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripProgressBar1,
				this.toolStripStatusLabel1
			});
			this.statusStrip1.Location = new System.Drawing.Point(0, 597);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new Size(871, 22);
			this.statusStrip1.TabIndex = 57;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripProgressBar1.Maximum = 1500;
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new Size(50, 16);
			this.toolStripStatusLabel1.BackColor = SystemColors.Control;
			this.toolStripStatusLabel1.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
			this.toolStripStatusLabel1.ForeColor = Color.Red;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new Size(804, 17);
			this.toolStripStatusLabel1.Spring = true;
			this.openFileDialog2.FileName = "openFileDialog2";
			this.openFileDialog2.FileOk += this.openFileDialog2_FileOk;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(871, 619);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.PushbuttonState_lbl);
			base.Controls.Add(this.ToggleLEDs_btn);
			base.Controls.Add(this.ANxVoltage_lbl);
			base.Controls.Add(this.StatusBox_lbl);
			base.Controls.Add(this.StatusBox_txtbx);
			base.Controls.Add(this.progressBar1);
			base.Controls.Add(this.toolStrip1);
			base.Name = "Form1";
			this.Text = "OGS-USB-STANDALONE  SQL 16.1";
			base.Load += this.Form1_Load;
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((ISupportInitialize)this.dataGridView1).EndInit();
			this.contextMenuStrip3.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000004 RID: 4
		[DllImport("setupapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		internal static extern IntPtr SetupDiGetClassDevs(ref Guid ClassGuid, IntPtr Enumerator, IntPtr hwndParent, uint Flags);

		// Token: 0x06000005 RID: 5
		[DllImport("setupapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		internal static extern bool SetupDiEnumDeviceInterfaces(IntPtr DeviceInfoSet, IntPtr DeviceInfoData, ref Guid InterfaceClassGuid, uint MemberIndex, ref Form1.SP_DEVICE_INTERFACE_DATA DeviceInterfaceData);

		// Token: 0x06000006 RID: 6
		[DllImport("setupapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		internal static extern bool SetupDiDestroyDeviceInfoList(IntPtr DeviceInfoSet);

		// Token: 0x06000007 RID: 7
		[DllImport("setupapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		internal static extern bool SetupDiEnumDeviceInfo(IntPtr DeviceInfoSet, uint MemberIndex, ref Form1.SP_DEVINFO_DATA DeviceInterfaceData);

		// Token: 0x06000008 RID: 8
		[DllImport("setupapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		internal static extern bool SetupDiGetDeviceRegistryProperty(IntPtr DeviceInfoSet, ref Form1.SP_DEVINFO_DATA DeviceInfoData, uint Property, ref uint PropertyRegDataType, IntPtr PropertyBuffer, uint PropertyBufferSize, ref uint RequiredSize);

		// Token: 0x06000009 RID: 9
		[DllImport("setupapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		internal static extern bool SetupDiGetDeviceInterfaceDetail(IntPtr DeviceInfoSet, ref Form1.SP_DEVICE_INTERFACE_DATA DeviceInterfaceData, IntPtr DeviceInterfaceDetailData, uint DeviceInterfaceDetailDataSize, ref uint RequiredSize, IntPtr DeviceInfoData);

		// Token: 0x0600000A RID: 10
		[DllImport("setupapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		internal static extern bool SetupDiGetDeviceInterfaceDetail(IntPtr DeviceInfoSet, ref Form1.SP_DEVICE_INTERFACE_DATA DeviceInterfaceData, IntPtr DeviceInterfaceDetailData, uint DeviceInterfaceDetailDataSize, IntPtr RequiredSize, IntPtr DeviceInfoData);

		// Token: 0x0600000B RID: 11
		[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		internal static extern IntPtr RegisterDeviceNotification(IntPtr hRecipient, IntPtr NotificationFilter, uint Flags);

		// Token: 0x0600000C RID: 12
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		private static extern SafeFileHandle CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

		// Token: 0x0600000D RID: 13
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		private static extern bool WriteFile(SafeFileHandle hFile, byte[] lpBuffer, uint nNumberOfBytesToWrite, ref uint lpNumberOfBytesWritten, IntPtr lpOverlapped);

		// Token: 0x0600000E RID: 14
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		private static extern bool ReadFile(SafeFileHandle hFile, IntPtr lpBuffer, uint nNumberOfBytesToRead, ref uint lpNumberOfBytesRead, IntPtr lpOverlapped);

		// Token: 0x0600000F RID: 15 RVA: 0x00004B8C File Offset: 0x00002D8C
		public Form1()
		{
			this.InitializeComponent();
			this.ANxVoltageToolTip.SetToolTip(this.ANxVoltage_lbl, "If using a board/PIM without a potentiometer, apply an adjustable voltage to the I/O pin.");
			this.ANxVoltageToolTip.SetToolTip(this.progressBar1, "If using a board/PIM without a potentiometer, apply an adjustable voltage to the I/O pin.");
			this.ToggleLEDToolTip.SetToolTip(this.ToggleLEDs_btn, "Sends a packet of data to the USB device.");
			this.PushbuttonStateTooltip.SetToolTip(this.PushbuttonState_lbl, "Try pressing pushbuttons on the USB demo board/PIM.");
			Form1.DEV_BROADCAST_DEVICEINTERFACE dev_BROADCAST_DEVICEINTERFACE = default(Form1.DEV_BROADCAST_DEVICEINTERFACE);
			dev_BROADCAST_DEVICEINTERFACE.dbcc_devicetype = 5U;
			checked
			{
				dev_BROADCAST_DEVICEINTERFACE.dbcc_size = (uint)Marshal.SizeOf(dev_BROADCAST_DEVICEINTERFACE);
				dev_BROADCAST_DEVICEINTERFACE.dbcc_reserved = 0U;
				dev_BROADCAST_DEVICEINTERFACE.dbcc_classguid = this.InterfaceClassGuid;
				IntPtr intPtr = IntPtr.Zero;
				intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(dev_BROADCAST_DEVICEINTERFACE));
				Marshal.StructureToPtr(dev_BROADCAST_DEVICEINTERFACE, intPtr, false);
				Form1.RegisterDeviceNotification(base.Handle, intPtr, 0U);
				if (this.CheckIfPresentAndGetUSBDevicePath())
				{
					this.WriteHandleToUSBDevice = Form1.CreateFile(this.DevicePath, 1073741824U, 3U, IntPtr.Zero, 3U, 0U, IntPtr.Zero);
					uint num = (uint)Marshal.GetLastWin32Error();
					this.ReadHandleToUSBDevice = Form1.CreateFile(this.DevicePath, 2147483648U, 3U, IntPtr.Zero, 3U, 0U, IntPtr.Zero);
					uint num2 = (uint)Marshal.GetLastWin32Error();
					if (num == 0U && num2 == 0U)
					{
						this.AttachedState = true;
						this.AttachedButBroken = false;
						this.StatusBox_txtbx.Text = "Device Found, AttachedState = TRUE";
					}
					else
					{
						this.AttachedState = false;
						this.AttachedButBroken = true;
						if (num == 0U)
						{
							this.WriteHandleToUSBDevice.Close();
						}
						if (num2 == 0U)
						{
							this.ReadHandleToUSBDevice.Close();
						}
					}
				}
				else
				{
					this.AttachedState = false;
					this.AttachedButBroken = false;
				}
				if (this.AttachedState)
				{
					this.StatusBox_txtbx.Text = "Device Found, AttachedState = TRUE";
				}
				else
				{
					this.StatusBox_txtbx.Text = "Device not found, verify connect/correct firmware";
				}
				this.ReadWriteThread.RunWorkerAsync();
				try
				{
					this.ReadWriteThread.RunWorkerAsync();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00004E34 File Offset: 0x00003034
		private bool CheckIfPresentAndGetUSBDevicePath()
		{
			checked
			{
				bool result;
				try
				{
					IntPtr intPtr = IntPtr.Zero;
					Form1.SP_DEVICE_INTERFACE_DATA sp_DEVICE_INTERFACE_DATA = default(Form1.SP_DEVICE_INTERFACE_DATA);
					Form1.SP_DEVICE_INTERFACE_DETAIL_DATA sp_DEVICE_INTERFACE_DETAIL_DATA = default(Form1.SP_DEVICE_INTERFACE_DETAIL_DATA);
					Form1.SP_DEVINFO_DATA sp_DEVINFO_DATA = default(Form1.SP_DEVINFO_DATA);
					uint num = 0U;
					uint num2 = 0U;
					uint num3 = 0U;
					uint num4 = 0U;
					uint num5 = 0U;
					IntPtr intPtr2 = IntPtr.Zero;
					uint num6 = 0U;
					string text = "Vid_04d8&Pid_003f";
					intPtr = Form1.SetupDiGetClassDevs(ref this.InterfaceClassGuid, IntPtr.Zero, IntPtr.Zero, 18U);
					if (intPtr != IntPtr.Zero)
					{
						uint num7;
						for (;;)
						{
							sp_DEVICE_INTERFACE_DATA.cbSize = (uint)Marshal.SizeOf(sp_DEVICE_INTERFACE_DATA);
							if (!Form1.SetupDiEnumDeviceInterfaces(intPtr, IntPtr.Zero, ref this.InterfaceClassGuid, num, ref sp_DEVICE_INTERFACE_DATA))
							{
								goto IL_B3;
							}
							num7 = (uint)Marshal.GetLastWin32Error();
							if (num7 == 259U)
							{
								break;
							}
							sp_DEVINFO_DATA.cbSize = (uint)Marshal.SizeOf(sp_DEVINFO_DATA);
							Form1.SetupDiEnumDeviceInfo(intPtr, num, ref sp_DEVINFO_DATA);
							Form1.SetupDiGetDeviceRegistryProperty(intPtr, ref sp_DEVINFO_DATA, 1U, ref num2, IntPtr.Zero, 0U, ref num3);
							intPtr2 = Marshal.AllocHGlobal((int)num3);
							Form1.SetupDiGetDeviceRegistryProperty(intPtr, ref sp_DEVINFO_DATA, 1U, ref num2, intPtr2, num3, ref num4);
							string text2 = Marshal.PtrToStringUni(intPtr2);
							Marshal.FreeHGlobal(intPtr2);
							text2 = text2.ToLowerInvariant();
							text = text.ToLowerInvariant();
							bool flag = text2.Contains(text);
							if (flag)
							{
								goto Block_4;
							}
							num += 1U;
							num6 += 1U;
							if (num6 == 10000000U)
							{
								goto Block_6;
							}
						}
						Form1.SetupDiDestroyDeviceInfoList(intPtr);
						return false;
						IL_B3:
						num7 = (uint)Marshal.GetLastWin32Error();
						Form1.SetupDiDestroyDeviceInfoList(intPtr);
						return false;
						Block_4:
						sp_DEVICE_INTERFACE_DETAIL_DATA.cbSize = (uint)Marshal.SizeOf(sp_DEVICE_INTERFACE_DETAIL_DATA);
						Form1.SetupDiGetDeviceInterfaceDetail(intPtr, ref sp_DEVICE_INTERFACE_DATA, IntPtr.Zero, 0U, ref num5, IntPtr.Zero);
						IntPtr intPtr3 = IntPtr.Zero;
						intPtr3 = Marshal.AllocHGlobal((int)num5);
						sp_DEVICE_INTERFACE_DETAIL_DATA.cbSize = 6U;
						Marshal.StructureToPtr(sp_DEVICE_INTERFACE_DETAIL_DATA, intPtr3, false);
						if (Form1.SetupDiGetDeviceInterfaceDetail(intPtr, ref sp_DEVICE_INTERFACE_DATA, intPtr3, num5, IntPtr.Zero, IntPtr.Zero))
						{
							IntPtr ptr = new IntPtr((long)(unchecked((ulong)(checked((uint)intPtr3.ToInt32() + 4U)))));
							this.DevicePath = Marshal.PtrToStringUni(ptr);
							Form1.SetupDiDestroyDeviceInfoList(intPtr);
							Marshal.FreeHGlobal(intPtr3);
							return true;
						}
						uint num8 = (uint)Marshal.GetLastWin32Error();
						Form1.SetupDiDestroyDeviceInfoList(intPtr);
						Marshal.FreeHGlobal(intPtr3);
						return false;
						Block_6:
						result = false;
					}
					else
					{
						result = false;
					}
				}
				catch
				{
					result = false;
				}
				return result;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00005088 File Offset: 0x00003288
		protected override void WndProc(ref Message m)
		{
			if ((long)m.Msg == 537L && ((long)((int)m.WParam) == 32768L || (long)((int)m.WParam) == 32771L || (long)((int)m.WParam) == 32772L || (long)((int)m.WParam) == 24L))
			{
				checked
				{
					if (this.CheckIfPresentAndGetUSBDevicePath())
					{
						if (!this.AttachedState || this.AttachedButBroken)
						{
							this.WriteHandleToUSBDevice = Form1.CreateFile(this.DevicePath, 1073741824U, 3U, IntPtr.Zero, 3U, 0U, IntPtr.Zero);
							uint num = (uint)Marshal.GetLastWin32Error();
							this.ReadHandleToUSBDevice = Form1.CreateFile(this.DevicePath, 2147483648U, 3U, IntPtr.Zero, 3U, 0U, IntPtr.Zero);
							uint num2 = (uint)Marshal.GetLastWin32Error();
							if (num == 0U && num2 == 0U)
							{
								this.AttachedState = true;
								this.AttachedButBroken = false;
								this.StatusBox_txtbx.Text = "Device Found, AttachedState = TRUE";
							}
							else
							{
								this.AttachedState = false;
								this.AttachedButBroken = true;
								if (num == 0U)
								{
									this.WriteHandleToUSBDevice.Close();
								}
								if (num2 == 0U)
								{
									this.ReadHandleToUSBDevice.Close();
								}
							}
						}
					}
					else
					{
						if (this.AttachedState)
						{
							this.AttachedState = false;
							this.WriteHandleToUSBDevice.Close();
							this.ReadHandleToUSBDevice.Close();
						}
						this.AttachedState = false;
						this.AttachedButBroken = false;
					}
				}
			}
			base.WndProc(ref m);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000051F5 File Offset: 0x000033F5
		private void ToggleLEDs_btn_Click(object sender, EventArgs e)
		{
			this.ToggleLEDsPending = true;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00005200 File Offset: 0x00003400
		private void ReadWriteThread_DoWork(object sender, DoWorkEventArgs e)
		{
			byte[] array = new byte[65];
			byte[] array2 = new byte[65];
			uint num = 0U;
			uint num2 = 0U;
			checked
			{
				try
				{
					for (;;)
					{
						IL_14:
						if (this.AttachedState)
						{
							if (this.epr1)
							{
								array[0] = 0;
								array[1] = 51;
								array[2] = this.komut;
								array[3] = this.eepromu;
								array[4] = this.eepromh;
								array[5] = this.eeproml;
								for (uint num3 = 6U; num3 < 65U; num3 += 1U)
								{
									array[(int)(unchecked((UIntPtr)num3))] = byte.MaxValue;
								}
								if (Form1.WriteFile(this.WriteHandleToUSBDevice, array, 65U, ref num, IntPtr.Zero))
								{
									for (uint num4 = 0U; num4 < 65U; num4 += 1U)
									{
										array2[(int)(unchecked((UIntPtr)num4))] = byte.MaxValue;
									}
									if (this.ReadFileManagedBuffer(this.ReadHandleToUSBDevice, array2, 65U, ref num2, IntPtr.Zero) && array2[1] == 51)
									{
										this.sifreu = array2[2];
										this.sifreh = array2[3];
										this.sifrel = array2[4];
										this.role = array2[5];
										this.k_ara = array2[6];
										this.epr1 = false;
									}
								}
							}
							if (this.z_epr)
							{
								array[0] = 0;
								array[1] = 50;
								array[2] = this.adrh;
								array[3] = this.adrl;
								array[4] = this.karth2;
								array[5] = this.kartl2;
								array[6] = this.karth;
								array[7] = this.kartl;
								for (uint num5 = 8U; num5 < 65U; num5 += 1U)
								{
									array[(int)(unchecked((UIntPtr)num5))] = byte.MaxValue;
								}
								if (Form1.WriteFile(this.WriteHandleToUSBDevice, array, 65U, ref num, IntPtr.Zero))
								{
									array2[0] = 0;
									if (this.ReadFileManagedBuffer(this.ReadHandleToUSBDevice, array2, 65U, ref num2, IntPtr.Zero) && array2[1] == 50)
									{
										this.z_epr = false;
									}
								}
							}
							if (this.zr_epr)
							{
								array[0] = 0;
								array[1] = 49;
								array[2] = this.adrh;
								array[3] = this.adrl;
								for (uint num6 = 4U; num6 < 65U; num6 += 1U)
								{
									array[(int)(unchecked((UIntPtr)num6))] = byte.MaxValue;
								}
								for (uint num7 = 0U; num7 < 65U; num7 += 1U)
								{
									array2[(int)(unchecked((UIntPtr)num7))] = byte.MaxValue;
								}
								if (Form1.WriteFile(this.WriteHandleToUSBDevice, array, 65U, ref num, IntPtr.Zero) && this.ReadFileManagedBuffer(this.ReadHandleToUSBDevice, array2, 65U, ref num2, IntPtr.Zero) && array2[1] == 49)
								{
									this.karth2 = array2[2];
									this.kartl2 = array2[3];
									this.karth = array2[4];
									this.kartl = array2[5];
									this.zr_epr = false;
								}
							}
							if (this.ztr_epr)
							{
								array[0] = 0;
								array[1] = 52;
								array[2] = this.adrl;
								for (uint num8 = 3U; num8 < 65U; num8 += 1U)
								{
									array[(int)(unchecked((UIntPtr)num8))] = byte.MaxValue;
								}
								for (uint num9 = 0U; num9 < 65U; num9 += 1U)
								{
									array2[(int)(unchecked((UIntPtr)num9))] = byte.MaxValue;
								}
								if (Form1.WriteFile(this.WriteHandleToUSBDevice, array, 65U, ref num, IntPtr.Zero) && this.ReadFileManagedBuffer(this.ReadHandleToUSBDevice, array2, 65U, ref num2, IntPtr.Zero) && array2[1] == 52)
								{
									this.karth2 = array2[2];
									this.kartl2 = array2[3];
									this.karth = array2[4];
									this.kartl = array2[5];
									this.ztr_epr = false;
								}
							}
						}
						else
						{
							Thread.Sleep(5);
						}
					}
				}
				catch
				{
					Thread.Sleep(5);
					goto IL_14;
				}
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00005550 File Offset: 0x00003750
		private void FormUpdateTimer_Tick(object sender, EventArgs e)
		{
			if (this.AttachedState)
			{
				this.StatusBox_txtbx.Text = "Device Found: AttachedState = TRUE";
				this.PushbuttonState_lbl.Enabled = true;
				this.ANxVoltage_lbl.Enabled = true;
				this.ToggleLEDs_btn.Enabled = true;
			}
			if (!this.AttachedState || this.AttachedButBroken)
			{
				this.StatusBox_txtbx.Text = "Device Not Detected: Verify Connection/Correct Firmware";
				this.PushbuttonState_lbl.Enabled = false;
				this.ANxVoltage_lbl.Enabled = false;
				this.ToggleLEDs_btn.Enabled = false;
				this.PushbuttonState_lbl.Text = "Pushbutton State: Unknown";
				this.ADCValue = 0U;
				this.progressBar1.Value = 0;
			}
			if (this.AttachedState)
			{
				if (!this.PushbuttonPressed)
				{
					this.PushbuttonState_lbl.Text = "Pushbutton State: Not Pressed";
				}
				else
				{
					this.PushbuttonState_lbl.Text = "Pushbutton State: Pressed";
				}
				this.progressBar1.Value = checked((int)this.ADCValue) / 20;
				this.textBox1.Text = string.Concat(new string[]
				{
					this.gun.ToString("00"),
					".",
					this.ay.ToString("00"),
					".",
					this.yil.ToString("00"),
					"  ",
					this.saat.ToString("00"),
					":",
					this.dakika.ToString("00"),
					":",
					this.saniye.ToString("00")
				});
				if (this.gun.ToString("00") == "01" && this.ay.ToString("00") == "01" && this.yil.ToString("00") == "01")
				{
					return;
				}
				if (this.gun.ToString("00") != "00")
				{
					Convert.ToDateTime(this.textBox1.Text, this.enGB);
					if (this.xk == 0)
					{
						this.z_ilk = true;
						this.xk = 1;
						this.xk2 = 1;
					}
					if (this.xk2 == 1)
					{
						this.timer2.Enabled = true;
						this.xk2 = 2;
						this.ilk = 1;
					}
					if (this.xk3 == 0)
					{
						this.timer3.Enabled = true;
						this.xk3 = 1;
					}
				}
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000057E4 File Offset: 0x000039E4
		public bool ReadFileManagedBuffer(SafeFileHandle hFile, byte[] INBuffer, uint nNumberOfBytesToRead, ref uint lpNumberOfBytesRead, IntPtr lpOverlapped)
		{
			IntPtr intPtr = IntPtr.Zero;
			checked
			{
				bool result;
				try
				{
					intPtr = Marshal.AllocHGlobal((int)nNumberOfBytesToRead);
					if (Form1.ReadFile(hFile, intPtr, nNumberOfBytesToRead, ref lpNumberOfBytesRead, lpOverlapped))
					{
						Marshal.Copy(intPtr, INBuffer, 0, (int)lpNumberOfBytesRead);
						Marshal.FreeHGlobal(intPtr);
						result = true;
					}
					else
					{
						Marshal.FreeHGlobal(intPtr);
						result = false;
					}
				}
				catch
				{
					if (intPtr != IntPtr.Zero)
					{
						Marshal.FreeHGlobal(intPtr);
					}
					result = false;
				}
				return result;
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00005858 File Offset: 0x00003A58
		private void timer2_Tick(object sender, EventArgs e)
		{
			this.timer2.Enabled = false;
			System.Windows.Forms.Application.DoEvents();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000586C File Offset: 0x00003A6C
		private void button10_Click(object sender, EventArgs e)
		{
			this.z_epr = false;
			int num = 0;
			byte b = 0;
			this.t1hata = 0;
			this.toolStripProgressBar1.Value = 0;
			checked
			{
				if (this.button10.Enabled)
				{
					this.dataGridView1.Sort(this.c1, ListSortDirection.Ascending);
					int i = 0;
					while (i < this.dataGridView1.RowCount)
					{
						Thread.Sleep(20);
						if (this.dataGridView1[0, i].Value == null && this.dataGridView1.RowCount == 1)
						{
							this.z_saat = 0;
							this.z_dakika = 0;
							this.z_sure = 0;
							this.z_gunler = 0;
							goto IL_287;
						}
						if (this.dataGridView1[0, i].Value == null && this.dataGridView1.RowCount - i < 2)
						{
							break;
						}
						if (this.dataGridView1[0, i].Value != null)
						{
							string text = this.dataGridView1[0, i].Value.ToString();
							this.z_saat = Convert.ToByte(text.Substring(0, 2));
							this.z_dakika = Convert.ToByte(text.Substring(3, 2));
							if (this.dataGridView1[1, i].Value == null)
							{
								this.z_sure = 0;
							}
							else
							{
								this.z_sure = Convert.ToByte(this.dataGridView1[1, i].Value.ToString());
							}
							if (this.dataGridView1[2, i].Value != null && this.dataGridView1[2, i].Value != "" && this.dataGridView1[2, i].Value.ToString() == "Dakika")
							{
								num += 128;
							}
							if (Convert.ToBoolean(this.dataGridView1[3, i].Value))
							{
								num += 64;
							}
							if (Convert.ToBoolean(this.dataGridView1[4, i].Value))
							{
								num += 32;
							}
							if (Convert.ToBoolean(this.dataGridView1[5, i].Value))
							{
								num += 16;
							}
							if (Convert.ToBoolean(this.dataGridView1[6, i].Value))
							{
								num += 8;
							}
							if (Convert.ToBoolean(this.dataGridView1[7, i].Value))
							{
								num += 4;
							}
							if (Convert.ToBoolean(this.dataGridView1[8, i].Value))
							{
								num += 2;
							}
							if (Convert.ToBoolean(this.dataGridView1[9, i].Value))
							{
								num++;
							}
							this.z_gunler = Convert.ToByte(num);
							num = 0;
							goto IL_287;
						}
						IL_3A3:
						i++;
						continue;
						IL_287:
						this.adr = b;
						this.z_epr = true;
						ulong num2 = unchecked((ulong)-294967296);
						while (this.z_epr && num2 > 0UL)
						{
							num2 -= 1UL;
						}
						if (this.dataGridView1[2, i].Value != null && this.dataGridView1[2, i].Value != "" && this.v1 < 15 && this.dataGridView1[2, i].Value.ToString() == "Dakika")
						{
							MessageBox.Show("CİHAZIN VERSİYONU DAKİKAYI DESTEKLEMİYOR......");
							this.dataGridView1[2, i].Value = "Saniye";
							this.z_gunler = Convert.ToByte((int)(this.z_gunler - 128));
							num = 0;
							this.z_epr = true;
							num2 = unchecked((ulong)-294967296);
							while (this.z_epr && num2 > 0UL)
							{
								num2 -= 1UL;
							}
						}
						b += 1;
						this.toolStripProgressBar1.Value++;
						this.toolStripProgressBar1.Value++;
						goto IL_3A3;
					}
					this.dataGridView1.Sort(this.c1, ListSortDirection.Ascending);
					this.toolStripStatusLabel1.Text = "ZİL SAATLERİ KAYDEDİLDİ ...";
				}
				this.toolStripProgressBar1.Value = 0;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00005C5F File Offset: 0x00003E5F
		private void button5_Click(object sender, EventArgs e)
		{
			this.ToggleLEDsPending = true;
			this.sayac = -10;
			this.toolStripStatusLabel1.Text = " SAAT TARİH DEĞİŞTİRİLDİ ...";
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00005C80 File Offset: 0x00003E80
		private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridView1.CurrentCell.Value == null)
			{
				return;
			}
			if (this.dataGridView1.CurrentCell.ColumnIndex == 0)
			{
				try
				{
					string text = this.dataGridView1.CurrentCell.Value.ToString();
					char c = Convert.ToChar(text.Substring(0, 1));
					if (char.IsNumber(c))
					{
						c = Convert.ToChar(text.Substring(1, 1));
						if (char.IsNumber(c))
						{
							int num = (int)Convert.ToInt16(text.Substring(0, 2));
							if (num <= 23)
							{
								string a = text.Substring(2, 1);
								if (!(a != ":"))
								{
									c = Convert.ToChar(text.Substring(3, 1));
									if (char.IsNumber(c))
									{
										c = Convert.ToChar(text.Substring(4, 1));
										if (char.IsNumber(c))
										{
											num = (int)Convert.ToInt16(text.Substring(3, 2));
											if (num <= 59)
											{
												this.toolStripStatusLabel1.Text = "GİRİŞLERİ TAMAMLADIKTAN SONRA KAYDEDİNİZ ...";
												return;
											}
										}
									}
								}
							}
						}
					}
				}
				catch
				{
					this.toolStripStatusLabel1.Text = "GİRİŞ SAAT:DAKİKA FORMATINDA OLMALI (12:24) gibi ...";
					this.dataGridView1.CurrentCell.Value = null;
				}
				this.toolStripStatusLabel1.Text = "GİRİŞ SAAT:DAKİKA FORMATINDA OLMALI (12:24) gibi ...";
				this.dataGridView1.CurrentCell.Value = null;
				this.dataGridView1.ClearSelection();
				this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Selected = true;
				this.dataGridView1.CurrentCell = this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex];
				this.dataGridView1.Select();
				this.dataGridView1.Focus();
				return;
			}
			checked
			{
				if (this.dataGridView1.CurrentCell.ColumnIndex == 1)
				{
					string text2 = this.dataGridView1.CurrentCell.Value.ToString();
					for (int i = 0; i < text2.Length; i++)
					{
						char c2 = Convert.ToChar(text2.Substring(i, 1));
						if (!char.IsNumber(c2))
						{
							IL_253:
							this.toolStripStatusLabel1.Text = "SÜRE 256 DAN KÜÇÜK BİR SAYI OLMALI...";
							this.dataGridView1.CurrentCell.Value = null;
							return;
						}
					}
					int num2 = (int)Convert.ToInt16(text2);
					if (this.v1 < 15 && num2 > 20)
					{
						this.toolStripStatusLabel1.Text = "SÜRE 20 DEN KÜÇÜK BİR SAYI OLMALI...";
						this.dataGridView1.CurrentCell.Value = null;
						return;
					}
					if (num2 > 255)
					{
						goto IL_253;
					}
				}
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00005F14 File Offset: 0x00004114
		private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
		{
			checked
			{
				if (e.Button == MouseButtons.Right)
				{
					this.contextMenuStrip3.Visible = true;
					this.contextMenuStrip3.Top = Form.ActiveForm.Top + e.Y + 300;
					this.contextMenuStrip3.Left = Form.ActiveForm.Left + e.X + 10;
				}
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00005F7C File Offset: 0x0000417C
		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			int index = this.dataGridView1.CurrentRow.Index;
			this.dataGridView1.Rows.RemoveAt(index);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00005FAB File Offset: 0x000041AB
		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			this.dataGridView1.Sort(this.c1, ListSortDirection.Ascending);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00005FBF File Offset: 0x000041BF
		private void PushbuttonState_lbl_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00005FC1 File Offset: 0x000041C1
		private void ANxVoltage_lbl_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00005FC3 File Offset: 0x000041C3
		private void StatusBox_lbl_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00005FC8 File Offset: 0x000041C8
		private void Form1_Load(object sender, EventArgs e)
		{
			this.button1.Enabled = false;
			this.button2.Enabled = false;
			this.button3.Enabled = false;
			this.button4.Enabled = false;
			this.button5.Enabled = false;
			this.button8.Enabled = false;
			this.button9.Enabled = false;
			this.button10.Enabled = false;
			this.button11.Enabled = false;
			this.button12.Enabled = false;
			this.label11.Visible = false;
			this.toolStripStatusLabel1.Text = "ŞİFRE GİRİNİZ...";
			this.textBox8.Select();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00006074 File Offset: 0x00004274
		private void dataGridView1_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridView1.CurrentCell.Value == null)
			{
				return;
			}
			if (this.dataGridView1.CurrentCell.ColumnIndex == 0)
			{
				if (Convert.ToInt32(this.dataGridView1.CurrentCell.Value) <= 16777215)
				{
					this.toolStripStatusLabel1.Text = "GİRİŞLERİ TAMAMLADIKTAN SONRA KAYDEDİNİZ ...";
					return;
				}
				MessageBox.Show("KART NUMARASI 16777215 den BÜYÜK OLAMAZ...");
				this.dataGridView1.CurrentCell.Value = null;
				this.dataGridView1.CurrentCell = this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex];
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00006118 File Offset: 0x00004318
		private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return && this.dataGridView1.CurrentCell.ColumnIndex == 0)
			{
				if (Convert.ToInt32(this.dataGridView1.CurrentCell.Value) <= 65534)
				{
					this.toolStripStatusLabel1.Text = "GİRİŞLERİ TAMAMLADIKTAN SONRA KAYDEDİNİZ ...";
					return;
				}
				MessageBox.Show("KART NUMARASI 65534 den BÜYÜK OLAMAZ...");
				this.dataGridView1.CurrentCell.Value = null;
				this.dataGridView1.CurrentCell = this.dataGridView1[0, checked(this.dataGridView1.CurrentCell.RowIndex - 1)];
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000061B8 File Offset: 0x000043B8
		private void button2_Click(object sender, EventArgs e)
		{
			this.z_epr = false;
			this.t1hata = 0;
			short num = 0;
			short num2 = 0;
			this.toolStripProgressBar1.Value = 0;
			checked
			{
				if (this.button2.Enabled)
				{
					short num3;
					if (this.dataGridView1.RowCount > 1500)
					{
						num3 = 1500;
					}
					else
					{
						num3 = Convert.ToInt16(this.dataGridView1.RowCount);
					}
					this.toolStripProgressBar1.Maximum = (int)num3;
					for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
					{
						if (this.dataGridView1[0, i].Value == null || this.dataGridView1[0, i].Value.ToString() == "")
						{
							this.dataGridView1.Rows.RemoveAt(i);
						}
					}
					this.toolStripStatusLabel1.Text = "LÜTFEN BEKLEYİNİZ ......";
					for (int j = 0; j < 1500; j++)
					{
						int value = 0;
						this.yedek[j] = unchecked((ulong)Convert.ToUInt16(value));
					}
					for (short num4 = 0; num4 < 1500; num4 += 1)
					{
						Thread.Sleep(20);
						this.adrh = Convert.ToByte((int)(num4 / 256));
						this.adrl = Convert.ToByte((int)(num4 % 256));
						this.zr_epr = true;
						uint num5 = 600000000U;
						while (this.zr_epr && num5 > 0U)
						{
							num5 -= 1U;
						}
						num = num4;
						if (this.kartl2 != 0 || this.karth != 0 || this.kartl != 0)
						{
							if (this.kartl2 == 255 && this.karth == 255 && this.kartl == 255)
							{
								break;
							}
							ulong num6 = Convert.ToUInt64((int)this.kartl2 * 65536 + ((int)this.karth * 256 + (int)this.kartl));
							this.yedek[(int)num2] = num6;
							num2 += 1;
						}
					}
					if (this.dataGridView1.RowCount > 1500)
					{
						num3 = 1500;
					}
					else
					{
						num3 = Convert.ToInt16(this.dataGridView1.RowCount);
					}
					for (int i = 0; i < (int)num3; i++)
					{
						Thread.Sleep(20);
						if (this.toolStripProgressBar1.Value > 1500)
						{
							this.toolStripProgressBar1.Value = 0;
						}
						this.toolStripProgressBar1.Value++;
						System.Windows.Forms.Application.DoEvents();
						if (this.dataGridView1[0, i].Value == null && this.dataGridView1.RowCount - i < 2)
						{
							break;
						}
						if (this.dataGridView1[0, i].Value != null)
						{
							ulong num7 = Convert.ToUInt64(this.dataGridView1[0, i].Value);
							short num8 = num;
							for (int k = 0; k < (int)(num + 1); k++)
							{
								if (num7 == this.yedek[k])
								{
									goto IL_40D;
								}
							}
							this.adrh = Convert.ToByte((int)(num8 / 256));
							this.adrl = Convert.ToByte((int)(num8 % 256));
							this.karth2 = 0;
							this.kartl2 = Convert.ToByte(num7 / 65536UL);
							this.karth = Convert.ToByte((num7 - Convert.ToUInt64((int)this.kartl2 * 65536)) / 256UL);
							this.kartl = Convert.ToByte((num7 - Convert.ToUInt64((int)this.kartl2 * 65536)) % 256UL);
							this.z_epr = true;
							ulong num9 = unchecked((ulong)-294967296);
							while (this.z_epr && num9 > 0UL)
							{
								num9 -= 1UL;
							}
							num += 1;
							if (this.dataGridView1[0, i].Value != null && this.dataGridView1[0, i].Value != "")
							{
								num9 = unchecked((ulong)-294967296);
								while (this.z_epr && num9 > 0UL)
								{
									num9 -= 1UL;
								}
							}
							num8 += 1;
							if (num > 1499)
							{
								MessageBox.Show("KART SAYISI 1500 den FAZLA.. 1500 TANE YAZILDI...");
								break;
							}
							this.yedek[(int)num2] = num7;
							num2 += 1;
						}
						IL_40D:;
					}
					this.toolStripStatusLabel1.Text = "KARTLAR KAYDEDİLDİ ...TOPLAM " + num2 + " KART";
				}
				this.toolStripProgressBar1.Value = 0;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000660C File Offset: 0x0000480C
		private void button3_Click(object sender, EventArgs e)
		{
			this.dataGridView1.Rows.Clear();
			this.toolStripProgressBar1.Maximum = 100;
			this.toolStripProgressBar1.Value = 0;
			this.toolStripStatusLabel1.Text = "LÜTFEN BEKLEYİNİZ ......";
			int num = 0;
			checked
			{
				for (int i = 0; i < 1500; i++)
				{
					Thread.Sleep(20);
					this.adrh = Convert.ToByte(i / 256);
					this.adrl = Convert.ToByte(i % 256);
					this.zr_epr = true;
					uint num2 = 600000000U;
					while (this.zr_epr && num2 > 0U)
					{
						num2 -= 1U;
					}
					if (this.kartl2 != 0 || this.karth != 0 || this.kartl != 0)
					{
						if (this.kartl2 == 255 && this.karth == 255 && this.kartl == 255)
						{
							break;
						}
						this.dataGridView1.Rows.Add();
						ulong num3 = Convert.ToUInt64((int)this.kartl2 * 65536 + ((int)this.karth * 256 + (int)this.kartl));
						this.dataGridView1[0, num].Value = num3;
						this.dataGridView1[7, num].ToolTipText = "EKLE";
						num++;
						if (this.toolStripProgressBar1.Value > 97)
						{
							this.toolStripProgressBar1.Value = 0;
						}
						this.toolStripProgressBar1.Value++;
						System.Windows.Forms.Application.DoEvents();
					}
				}
				this.toolStripStatusLabel1.Text = "BİLGİLER OKUNDU ......";
				this.textBox2.Text = (this.dataGridView1.RowCount - 1).ToString();
				this.toolStripProgressBar1.Value = 0;
				System.Windows.Forms.Application.DoEvents();
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000067E0 File Offset: 0x000049E0
		private void button5_Click_1(object sender, EventArgs e)
		{
			if (MessageBox.Show("MASTER KART SİLİNECEKTİR.", "ONAYLA....", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.komut = 4;
				this.epr1 = true;
				ulong num = (ulong)-294967296;
				checked
				{
					while (this.epr1 && num > 0UL)
					{
						num -= 1UL;
					}
					if (!this.epr1)
					{
						this.toolStripStatusLabel1.Text = "MASTER SİLİNDİ ...";
					}
				}
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00006844 File Offset: 0x00004A44
		private void textBox8_DoubleClick(object sender, EventArgs e)
		{
			if (this.button1.Enabled)
			{
				return;
			}
			if (!this.AttachedState)
			{
				MessageBox.Show("CİHAZ BAĞLI DEĞİL !!!!");
				return;
			}
			this.komut = 3;
			this.epr1 = true;
			ulong num = (ulong)-294967296;
			checked
			{
				while (this.epr1 && num > 0UL)
				{
					num -= 1UL;
				}
				if (!this.epr1)
				{
					this.textBox3.Visible = true;
					this.textBox3.Text = (((int)this.sifreu * 256 + (int)this.sifreh) * 7951).ToString();
					this.toolStripStatusLabel1.Text = "GEÇİCİ ŞİFRE PARAMETRELERİ ALINDI ...";
				}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000068EC File Offset: 0x00004AEC
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (this.DevicePath != null && this.eDevicePath == null)
			{
				this.eDevicePath = this.DevicePath;
			}
			if (this.eDevicePath != this.DevicePath)
			{
				this.button1.Enabled = false;
				this.button2.Enabled = false;
				this.button3.Enabled = false;
				this.button4.Enabled = false;
				this.button5.Enabled = false;
				this.button8.Enabled = false;
				this.button9.Enabled = false;
				this.button10.Enabled = false;
				this.button11.Enabled = false;
				this.button12.Enabled = false;
				this.toolStripStatusLabel1.Text = "ŞİFRE GİRİNİZ ...";
			}
			if (!this.AttachedState)
			{
				this.button1.Enabled = false;
				this.button2.Enabled = false;
				this.button3.Enabled = false;
				this.button4.Enabled = false;
				this.button5.Enabled = false;
				this.button8.Enabled = false;
				this.button9.Enabled = false;
				this.button10.Enabled = false;
				this.button11.Enabled = false;
				this.button12.Enabled = false;
				this.toolStripStatusLabel1.Text = "ŞİFRE GİRİNİZ ...";
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00006A48 File Offset: 0x00004C48
		private void textBox8_KeyUp(object sender, KeyEventArgs e)
		{
			if (!this.AttachedState)
			{
				MessageBox.Show("CİHAZ BAĞLI DEĞİL !!!!");
				return;
			}
			checked
			{
				if (e.KeyCode == Keys.Return)
				{
					if (this.textBox3.Visible)
					{
						string text = Convert.ToString((Convert.ToInt64(this.textBox3.Text) - 97531L) * 147L);
						text = text.Substring(0, 6);
						if (text == this.textBox8.Text)
						{
							this.textBox3.Visible = false;
							this.panel1.Visible = true;
							return;
						}
						this.textBox3.Visible = false;
						MessageBox.Show("GEÇİCİ ŞİFRE HATALI");
						return;
					}
					else
					{
						this.komut = 1;
						this.epr1 = true;
						ulong num = unchecked((ulong)-294967296);
						while (this.epr1 && num > 0UL)
						{
							num -= 1UL;
						}
						if (!this.epr1)
						{
							int num2 = Convert.ToInt32(this.textBox8.Text);
							byte b = Convert.ToByte(num2 / 65536);
							int num3 = num2 - (int)b * 65536;
							byte b2 = Convert.ToByte(num3 / 256);
							byte b3 = Convert.ToByte(num3 % 256);
							this.textBox7.Text = this.role.ToString();
							this.textBox6.Text = this.k_ara.ToString();
							if (b == this.sifreu && b2 == this.sifreh && b3 == this.sifrel)
							{
								this.button1.Visible = true;
								this.button11.Visible = true;
								this.button12.Visible = true;
								this.button1.Enabled = true;
								this.button2.Enabled = true;
								this.button3.Enabled = true;
								this.button4.Enabled = true;
								this.button5.Enabled = true;
								this.button8.Enabled = true;
								this.button9.Enabled = true;
								this.button10.Enabled = true;
								this.button11.Enabled = true;
								this.button12.Enabled = true;
								this.toolStripStatusLabel1.Text = "ŞİFRE KABUL EDİLDİ.";
								return;
							}
							this.toolStripStatusLabel1.Text = "HATALI ŞİFRE...";
							this.textBox8.Text = "";
						}
					}
				}
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00006C98 File Offset: 0x00004E98
		private void dataGridView1_MouseDown_1(object sender, MouseEventArgs e)
		{
			checked
			{
				if (e.Button == MouseButtons.Right && MessageBox.Show("SEÇİLİ SATIR SİLİNECEKTİR.", "ONAYLA....", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					int index = this.dataGridView1.CurrentRow.Index;
					ulong num = Convert.ToUInt64(this.dataGridView1[0, index].Value);
					for (int i = 0; i < 1500; i++)
					{
						Thread.Sleep(20);
						this.adrh = Convert.ToByte(i / 256);
						this.adrl = Convert.ToByte(i % 256);
						this.zr_epr = true;
						uint num2 = 600000000U;
						while (this.zr_epr && num2 > 0U)
						{
							num2 -= 1U;
						}
						if (this.kartl2 != 0 || this.karth != 0 || this.kartl != 0)
						{
							if (this.kartl2 == 255 && this.karth == 255 && this.kartl == 255)
							{
								break;
							}
							ulong num3 = Convert.ToUInt64((int)this.kartl2 * 65536 + ((int)this.karth * 256 + (int)this.kartl));
							if (num3 == num)
							{
								this.adrh = Convert.ToByte(i / 256);
								this.adrl = Convert.ToByte(i % 256);
								this.karth = Convert.ToByte(0);
								this.kartl = Convert.ToByte(0);
								this.kartl2 = Convert.ToByte(0);
								this.z_epr = true;
								ulong num4 = unchecked((ulong)-294967296);
								while (this.z_epr)
								{
									if (num4 <= 0UL)
									{
										break;
									}
									num4 -= 1UL;
								}
								break;
							}
						}
					}
					this.dataGridView1.Rows.RemoveAt(index);
				}
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00006E50 File Offset: 0x00005050
		private void button4_Click(object sender, EventArgs e)
		{
			this.openFileDialog2.ShowDialog();
			if (this.radioButton1.Checked)
			{
				this.Excel();
			}
			else
			{
				this.Txt();
			}
			this.toolStripStatusLabel1.Text = "DOSYADAN BİLGİLER OKUNDU ......";
			this.textBox2.Text = (checked(this.dataGridView1.RowCount - 1)).ToString();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00006EB4 File Offset: 0x000050B4
		private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
		{
			this.e_file = this.openFileDialog2.FileName;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00006EC8 File Offset: 0x000050C8
		private void ExcelDocViewer(string fileName)
		{
			try
			{
				Process.Start(fileName);
			}
			catch
			{
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00006EF4 File Offset: 0x000050F4
		private void Txt()
		{
			short num = 0;
			checked
			{
				try
				{
					StreamReader streamReader = new StreamReader(this.e_file, Encoding.GetEncoding("iso-8859-9"));
					while (streamReader.Peek() >= 0)
					{
						this.dataGridView1.Rows.Add();
						string text = streamReader.ReadLine() + ";";
						string[] array = text.Split(new char[]
						{
							';'
						});
						this.dataGridView1[0, (int)num].Value = Convert.ToInt32(array[0].Trim());
						this.dataGridView1[1, (int)num].Value = Convert.ToString(array[1].Trim());
						this.dataGridView1[2, (int)num].Value = Convert.ToString(array[2].Trim());
						this.dataGridView1[3, (int)num].Value = Convert.ToString(array[3].Trim());
						this.dataGridView1[4, (int)num].Value = Convert.ToString(array[4].Trim());
						this.dataGridView1[5, (int)num].Value = Convert.ToString(array[5].Trim());
						num += 1;
					}
					streamReader.Close();
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00007054 File Offset: 0x00005254
		private void Excel()
		{
			this.directorym = Directory.GetCurrentDirectory();
			checked
			{
				string a = this.directorym.Substring(this.directorym.Length - 1, 1);
				if (a != "\\")
				{
					this.directorym += "\\";
				}
				Microsoft.Office.Interop.Excel.Application application = new ApplicationClass();
				int i = 0;
				int j = 0;
				Workbook workbook = application.Workbooks.Open(this.e_file, 0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
				Worksheet worksheet = (Worksheet)workbook.Worksheets.get_Item(1);
				Range usedRange = worksheet.UsedRange;
				this.dataGridView1.Rows.Clear();
				for (int k = 0; k < usedRange.Rows.Count; k++)
				{
					this.dataGridView1.Rows.Add();
				}
				for (i = 2; i <= usedRange.Rows.Count; i++)
				{
					for (j = 1; j <= usedRange.Columns.Count; j++)
					{
						try
						{
							string value = (usedRange.Cells[i, j] as Range).Value2.ToString();
							this.dataGridView1[j - 1, i - 2].Value = value;
						}
						catch
						{
						}
					}
				}
				workbook.Close(true, null, null);
				application.Quit();
				this.releaseObject(worksheet);
				this.releaseObject(workbook);
				this.releaseObject(application);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00007230 File Offset: 0x00005430
		private void releaseObject(object obj)
		{
			try
			{
				Marshal.ReleaseComObject(obj);
				obj = null;
			}
			catch (Exception ex)
			{
				obj = null;
				MessageBox.Show("Unable to release the Object " + ex.ToString());
			}
			finally
			{
				GC.Collect();
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000728C File Offset: 0x0000548C
		private void button10_Click_1(object sender, EventArgs e)
		{
			checked
			{
				if (this.radioButton1.Checked)
				{
					try
					{
						Microsoft.Office.Interop.Excel.Application application = new ApplicationClass();
						application.Workbooks.Add(true);
						Worksheet worksheet = (Worksheet)application.ActiveSheet;
						application.Visible = true;
						object missing = Type.Missing;
						int num = 2;
						worksheet.Cells[1, 1] = "KARTNO";
						worksheet.Cells[1, 2] = "ALAN1";
						worksheet.Cells[1, 3] = "ALAN2";
						worksheet.Cells[1, 4] = "ALAN3";
						worksheet.Cells[1, 5] = "ALAN4";
						worksheet.Cells[1, 6] = "ALAN5";
						for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
						{
							try
							{
								try
								{
									worksheet.Cells[num, 1] = this.dataGridView1[0, i].Value.ToString();
								}
								catch
								{
								}
								try
								{
									worksheet.Cells[num, 2] = this.dataGridView1[1, i].Value.ToString();
								}
								catch
								{
								}
								try
								{
									worksheet.Cells[num, 3] = this.dataGridView1[2, i].Value.ToString();
								}
								catch
								{
								}
								try
								{
									worksheet.Cells[num, 4] = this.dataGridView1[3, i].Value.ToString();
								}
								catch
								{
								}
								try
								{
									worksheet.Cells[num, 5] = this.dataGridView1[4, i].Value.ToString();
								}
								catch
								{
								}
								try
								{
									worksheet.Cells[num, 6] = this.dataGridView1[5, i].Value.ToString();
								}
								catch
								{
								}
								num++;
							}
							catch
							{
							}
						}
						return;
					}
					catch
					{
						return;
					}
				}
				if (File.Exists("liste.txt"))
				{
					if (MessageBox.Show("liste.txt mevcut, üzerine yazılacak...", "DOSYA YAZ....", MessageBoxButtons.YesNo) != DialogResult.Yes)
					{
						return;
					}
					File.Delete("liste.txt");
				}
				StreamWriter streamWriter = File.AppendText("liste.txt");
				for (int j = 0; j < this.dataGridView1.RowCount - 1; j++)
				{
					if (this.dataGridView1[1, j].Value == "" || this.dataGridView1[1, j].Value == null)
					{
						this.dataGridView1[1, j].Value = " ";
					}
					if (this.dataGridView1[2, j].Value == "" || this.dataGridView1[2, j].Value == null)
					{
						this.dataGridView1[2, j].Value = " ";
					}
					if (this.dataGridView1[3, j].Value == "" || this.dataGridView1[3, j].Value == null)
					{
						this.dataGridView1[3, j].Value = " ";
					}
					if (this.dataGridView1[4, j].Value == "" || this.dataGridView1[4, j].Value == null)
					{
						this.dataGridView1[4, j].Value = " ";
					}
					if (this.dataGridView1[5, j].Value == "" || this.dataGridView1[5, j].Value == null)
					{
						this.dataGridView1[5, j].Value = " ";
					}
					string value = string.Concat(new string[]
					{
						this.dataGridView1[0, j].Value.ToString(),
						";",
						this.dataGridView1[1, j].Value.ToString(),
						";",
						this.dataGridView1[2, j].Value.ToString(),
						";",
						this.dataGridView1[3, j].Value.ToString(),
						";",
						this.dataGridView1[4, j].Value.ToString(),
						";",
						this.dataGridView1[5, j].Value.ToString()
					});
					streamWriter.WriteLine(value);
				}
				streamWriter.Close();
				MessageBox.Show("liste.txt yazıldı... ");
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00007870 File Offset: 0x00005A70
		private void button6_Click(object sender, EventArgs e)
		{
			if (this.textBox4.Text != this.textBox5.Text)
			{
				MessageBox.Show("İki alana aynı şifreyi girin.... ");
				return;
			}
			this.komut = 2;
			int num = Convert.ToInt32(this.textBox4.Text);
			byte b = Convert.ToByte(num / 65536);
			int num2 = checked(num - (int)b * 65536);
			byte b2 = Convert.ToByte(num2 / 256);
			byte b3 = Convert.ToByte(num2 % 256);
			this.eepromu = b;
			this.eepromh = b2;
			this.eeproml = b3;
			this.epr1 = true;
			ulong num3 = (ulong)-294967296;
			checked
			{
				while (this.epr1 && num3 > 0UL)
				{
					num3 -= 1UL;
				}
				this.panel1.Visible = false;
				this.textBox3.Visible = false;
				this.toolStripStatusLabel1.Text = "YENİ ŞİFRE KABUL EDİLDİ...";
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00007954 File Offset: 0x00005B54
		private void button7_Click(object sender, EventArgs e)
		{
			this.panel1.Visible = false;
			this.textBox3.Visible = false;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000796E File Offset: 0x00005B6E
		private void button1_Click(object sender, EventArgs e)
		{
			this.panel1.Visible = true;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000797C File Offset: 0x00005B7C
		private void button8_Click(object sender, EventArgs e)
		{
			this.label11.Visible = true;
			this.dataGridView1.Rows.Clear();
			this.toolStripProgressBar1.Value = 0;
			short num = 0;
			checked
			{
				for (int i = 0; i < 1500; i++)
				{
					int value = 0;
					this.yedek[i] = unchecked((ulong)Convert.ToUInt16(value));
				}
				for (short num2 = 0; num2 < 1500; num2 += 1)
				{
					Thread.Sleep(20);
					this.adrh = Convert.ToByte((int)(num2 / 256));
					this.adrl = Convert.ToByte((int)(num2 % 256));
					this.zr_epr = true;
					uint num3 = 600000000U;
					while (this.zr_epr && num3 > 0U)
					{
						num3 -= 1U;
					}
					num = num2;
					if (this.kartl2 == 255 && this.karth == 255 && this.kartl == 255)
					{
						break;
					}
					ulong num4 = Convert.ToUInt64((int)this.kartl2 * 65536 + ((int)this.karth * 256 + (int)this.kartl));
					this.yedek[(int)num2] = num4;
				}
				int num5 = 0;
				for (short num2 = 0; num2 < 20; num2 += 1)
				{
					Thread.Sleep(20);
					this.adrl = Convert.ToByte(num2);
					this.ztr_epr = true;
					uint num6 = 600000000U;
					while (this.ztr_epr && num6 > 0U)
					{
						num6 -= 1U;
					}
					if (this.kartl2 != 0 || this.karth != 0 || this.kartl != 0)
					{
						if (this.kartl2 == 255 && this.karth == 255 && this.kartl == 255)
						{
							break;
						}
						ulong num4 = Convert.ToUInt64((int)this.kartl2 * 65536 + ((int)this.karth * 256 + (int)this.kartl));
						for (int j = 0; j < (int)(num + 1); j++)
						{
							if (num4 == this.yedek[j])
							{
								goto IL_23E;
							}
						}
						this.dataGridView1.Rows.Add();
						this.dataGridView1[6, num5].Value = num4;
						num5++;
						if (this.toolStripProgressBar1.Value > 97)
						{
							this.toolStripProgressBar1.Value = 0;
						}
						this.toolStripProgressBar1.Value++;
					}
					IL_23E:;
				}
				this.toolStripStatusLabel1.Text = "BİLGİLER OKUNDU ......";
				this.textBox2.Text = (this.dataGridView1.RowCount - 1).ToString();
				this.toolStripProgressBar1.Value = 0;
				System.Windows.Forms.Application.DoEvents();
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00007C18 File Offset: 0x00005E18
		private void button9_Click(object sender, EventArgs e)
		{
			checked
			{
				if (MessageBox.Show("OKUYUCUDAN TÜM KARTLAR SİLİNECEKTİR.", "ONAYLA....", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					this.z_epr = false;
					short num = 0;
					this.t1hata = 0;
					this.toolStripProgressBar1.Value = 0;
					if (this.button2.Enabled)
					{
						this.adrh = Convert.ToByte((int)(num / 256));
						this.adrl = Convert.ToByte((int)(num % 256));
						this.karth = Convert.ToByte(255);
						this.kartl = Convert.ToByte(255);
						this.z_epr = true;
						ulong num2 = unchecked((ulong)-294967296);
						while (this.z_epr && num2 > 0UL)
						{
							num2 -= 1UL;
						}
						if (this.z_epr)
						{
							MessageBox.Show("HATA... KARTLAR SİLİNEMEDİ. ");
						}
					}
				}
				MessageBox.Show("İŞLEM TAMAMLANDI.. ");
				this.dataGridView1.Rows.Clear();
				this.toolStripStatusLabel1.Text = "İŞLEM TAMAMLANDI..";
				this.textBox2.Text = (this.dataGridView1.RowCount - 1).ToString();
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00007D28 File Offset: 0x00005F28
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int columnIndex = e.ColumnIndex;
			int rowIndex = e.RowIndex;
			if (this.dataGridView1.CurrentCell.ColumnIndex == 7)
			{
				if (Convert.ToString(this.dataGridView1[6, rowIndex].Value) == "")
				{
					return;
				}
				this.dataGridView1[0, rowIndex].Value = this.dataGridView1[6, rowIndex].Value.ToString();
				this.dataGridView1[6, rowIndex].Style.BackColor = Color.Green;
				this.dataGridView1[7, rowIndex].Style.BackColor = Color.Green;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00007DE0 File Offset: 0x00005FE0
		private void textBox6_TextChanged(object sender, EventArgs e)
		{
			if (this.textBox6.Text == "")
			{
				return;
			}
			if (!char.IsNumber(Convert.ToChar(this.textBox6.Text.Substring(checked(this.textBox6.Text.Length - 1), 1))))
			{
				MessageBox.Show("Hatalı giriş. Girilen NUMERİK  olmalı. ", "Giriş hatası", MessageBoxButtons.OK);
				this.textBox6.Text = "";
				return;
			}
			if (Convert.ToInt16(this.textBox6.Text) > 255)
			{
				MessageBox.Show("Hatalı giriş. Süre 255 den büyük olamaz. ", "Giriş hatası", MessageBoxButtons.OK);
				this.textBox6.Text = "";
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00007E90 File Offset: 0x00006090
		private void button11_Click(object sender, EventArgs e)
		{
			this.komut = 4;
			byte b = Convert.ToByte(this.textBox6.Text);
			this.eepromu = b;
			this.epr1 = true;
			ulong num = (ulong)-294967296;
			checked
			{
				while (this.epr1 && num > 0UL)
				{
					num -= 1UL;
				}
				this.toolStripStatusLabel1.Text = "AYNI ETİKET OKUMA ARALIĞI DEĞİŞTİRİLDİ....";
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00007EF0 File Offset: 0x000060F0
		private void textBox7_TextChanged(object sender, EventArgs e)
		{
			if (this.textBox7.Text == "")
			{
				return;
			}
			if (!char.IsNumber(Convert.ToChar(this.textBox7.Text.Substring(checked(this.textBox7.Text.Length - 1), 1))))
			{
				MessageBox.Show("Hatalı giriş. Girilen NUMERİK  olmalı. ", "Giriş hatası", MessageBoxButtons.OK);
				this.textBox7.Text = "";
				return;
			}
			if (Convert.ToInt16(this.textBox7.Text) > 255)
			{
				MessageBox.Show("Hatalı giriş. RÖLE SÜRESİ 255 den büyük olamaz. ", "Giriş hatası", MessageBoxButtons.OK);
				this.textBox7.Text = "";
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00007FA0 File Offset: 0x000061A0
		private void button12_Click(object sender, EventArgs e)
		{
			this.komut = 5;
			byte b = Convert.ToByte(this.textBox7.Text);
			this.eepromu = b;
			this.epr1 = true;
			ulong num = (ulong)-294967296;
			checked
			{
				while (this.epr1 && num > 0UL)
				{
					num -= 1UL;
				}
				this.toolStripStatusLabel1.Text = "RÖLE SÜRESİ DEĞİŞTİRİLDİ....";
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00007FFE File Offset: 0x000061FE
		private void timer3_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x04000001 RID: 1
		internal const uint DIGCF_PRESENT = 2U;

		// Token: 0x04000002 RID: 2
		internal const uint DIGCF_DEVICEINTERFACE = 16U;

		// Token: 0x04000003 RID: 3
		internal const short FILE_ATTRIBUTE_NORMAL = 128;

		// Token: 0x04000004 RID: 4
		internal const short INVALID_HANDLE_VALUE = -1;

		// Token: 0x04000005 RID: 5
		internal const uint GENERIC_READ = 2147483648U;

		// Token: 0x04000006 RID: 6
		internal const uint GENERIC_WRITE = 1073741824U;

		// Token: 0x04000007 RID: 7
		internal const uint CREATE_NEW = 1U;

		// Token: 0x04000008 RID: 8
		internal const uint CREATE_ALWAYS = 2U;

		// Token: 0x04000009 RID: 9
		internal const uint OPEN_EXISTING = 3U;

		// Token: 0x0400000A RID: 10
		internal const uint FILE_SHARE_READ = 1U;

		// Token: 0x0400000B RID: 11
		internal const uint FILE_SHARE_WRITE = 2U;

		// Token: 0x0400000C RID: 12
		internal const uint WM_DEVICECHANGE = 537U;

		// Token: 0x0400000D RID: 13
		internal const uint DBT_DEVICEARRIVAL = 32768U;

		// Token: 0x0400000E RID: 14
		internal const uint DBT_DEVICEREMOVEPENDING = 32771U;

		// Token: 0x0400000F RID: 15
		internal const uint DBT_DEVICEREMOVECOMPLETE = 32772U;

		// Token: 0x04000010 RID: 16
		internal const uint DBT_CONFIGCHANGED = 24U;

		// Token: 0x04000011 RID: 17
		internal const uint DBT_DEVTYP_DEVICEINTERFACE = 5U;

		// Token: 0x04000012 RID: 18
		internal const uint DEVICE_NOTIFY_WINDOW_HANDLE = 0U;

		// Token: 0x04000013 RID: 19
		internal const uint ERROR_SUCCESS = 0U;

		// Token: 0x04000014 RID: 20
		internal const uint ERROR_NO_MORE_ITEMS = 259U;

		// Token: 0x04000015 RID: 21
		internal const uint SPDRP_HARDWAREID = 1U;

		// Token: 0x04000016 RID: 22
		private IContainer components;

		// Token: 0x04000017 RID: 23
		private System.Windows.Forms.Label PushbuttonState_lbl;

		// Token: 0x04000018 RID: 24
		private System.Windows.Forms.Button ToggleLEDs_btn;

		// Token: 0x04000019 RID: 25
		private System.Windows.Forms.Label ANxVoltage_lbl;

		// Token: 0x0400001A RID: 26
		private System.Windows.Forms.Label StatusBox_lbl;

		// Token: 0x0400001B RID: 27
		private System.Windows.Forms.TextBox StatusBox_txtbx;

		// Token: 0x0400001C RID: 28
		private ProgressBar progressBar1;

		// Token: 0x0400001D RID: 29
		private BackgroundWorker ReadWriteThread;

		// Token: 0x0400001E RID: 30
		private System.Windows.Forms.Timer FormUpdateTimer;

		// Token: 0x0400001F RID: 31
		private ToolTip ANxVoltageToolTip;

		// Token: 0x04000020 RID: 32
		private ToolTip ToggleLEDToolTip;

		// Token: 0x04000021 RID: 33
		private ToolTip PushbuttonStateTooltip;

		// Token: 0x04000022 RID: 34
		private ToolTip toolTip1;

		// Token: 0x04000023 RID: 35
		private System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000024 RID: 36
		private Panel panel3;

		// Token: 0x04000025 RID: 37
		private System.Windows.Forms.Label label8;

		// Token: 0x04000026 RID: 38
		private System.Windows.Forms.Timer timer1;

		// Token: 0x04000027 RID: 39
		private System.Windows.Forms.Timer timer2;

		// Token: 0x04000028 RID: 40
		private System.Windows.Forms.Timer timer3;

		// Token: 0x04000029 RID: 41
		private ContextMenuStrip contextMenuStrip3;

		// Token: 0x0400002A RID: 42
		private ToolStripMenuItem toolStripMenuItem1;

		// Token: 0x0400002B RID: 43
		private ToolStripMenuItem toolStripMenuItem2;

		// Token: 0x0400002C RID: 44
		private ToolStrip toolStrip1;

		// Token: 0x0400002D RID: 45
		private StatusStrip statusStrip1;

		// Token: 0x0400002E RID: 46
		internal ToolStripProgressBar toolStripProgressBar1;

		// Token: 0x0400002F RID: 47
		private ToolStripStatusLabel toolStripStatusLabel1;

		// Token: 0x04000030 RID: 48
		private System.Windows.Forms.TextBox textBox8;

		// Token: 0x04000031 RID: 49
		private System.Windows.Forms.Button button4;

		// Token: 0x04000032 RID: 50
		private System.Windows.Forms.Button button10;

		// Token: 0x04000033 RID: 51
		private System.Windows.Forms.Button button1;

		// Token: 0x04000034 RID: 52
		private System.Windows.Forms.Button button3;

		// Token: 0x04000035 RID: 53
		private System.Windows.Forms.Button button2;

		// Token: 0x04000036 RID: 54
		private System.Windows.Forms.Label label6;

		// Token: 0x04000037 RID: 55
		private System.Windows.Forms.Label label5;

		// Token: 0x04000038 RID: 56
		private System.Windows.Forms.Label label4;

		// Token: 0x04000039 RID: 57
		private System.Windows.Forms.Label label3;

		// Token: 0x0400003A RID: 58
		private System.Windows.Forms.Label label7;

		// Token: 0x0400003B RID: 59
		private System.Windows.Forms.Label label9;

		// Token: 0x0400003C RID: 60
		private DataGridView dataGridView1;

		// Token: 0x0400003D RID: 61
		private System.Windows.Forms.Label label13;

		// Token: 0x0400003E RID: 62
		private System.Windows.Forms.Button button5;

		// Token: 0x0400003F RID: 63
		private System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000040 RID: 64
		private OpenFileDialog openFileDialog2;

		// Token: 0x04000041 RID: 65
		private System.Windows.Forms.TextBox textBox3;

		// Token: 0x04000042 RID: 66
		private Panel panel1;

		// Token: 0x04000043 RID: 67
		private System.Windows.Forms.Label label1;

		// Token: 0x04000044 RID: 68
		private System.Windows.Forms.TextBox textBox4;

		// Token: 0x04000045 RID: 69
		private System.Windows.Forms.Button button6;

		// Token: 0x04000046 RID: 70
		private System.Windows.Forms.Label label2;

		// Token: 0x04000047 RID: 71
		private System.Windows.Forms.TextBox textBox5;

		// Token: 0x04000048 RID: 72
		private System.Windows.Forms.Button button7;

		// Token: 0x04000049 RID: 73
		private System.Windows.Forms.Label label10;

		// Token: 0x0400004A RID: 74
		private Panel panel2;

		// Token: 0x0400004B RID: 75
		private RadioButton radioButton1;

		// Token: 0x0400004C RID: 76
		private RadioButton radioButton2;

		// Token: 0x0400004D RID: 77
		private System.Windows.Forms.Label label11;

		// Token: 0x0400004E RID: 78
		private System.Windows.Forms.Button button8;

		// Token: 0x0400004F RID: 79
		private System.Windows.Forms.Button button9;

		// Token: 0x04000050 RID: 80
		private DataGridViewTextBoxColumn c1;

		// Token: 0x04000051 RID: 81
		private DataGridViewTextBoxColumn c2;

		// Token: 0x04000052 RID: 82
		private DataGridViewTextBoxColumn c3;

		// Token: 0x04000053 RID: 83
		private DataGridViewTextBoxColumn c4;

		// Token: 0x04000054 RID: 84
		private DataGridViewTextBoxColumn c5;

		// Token: 0x04000055 RID: 85
		private DataGridViewTextBoxColumn c6;

		// Token: 0x04000056 RID: 86
		private DataGridViewTextBoxColumn t_kart;

		// Token: 0x04000057 RID: 87
		private DataGridViewButtonColumn onay;

		// Token: 0x04000058 RID: 88
		private System.Windows.Forms.Button button11;

		// Token: 0x04000059 RID: 89
		private System.Windows.Forms.TextBox textBox6;

		// Token: 0x0400005A RID: 90
		private System.Windows.Forms.Label label12;

		// Token: 0x0400005B RID: 91
		private System.Windows.Forms.Label label14;

		// Token: 0x0400005C RID: 92
		private System.Windows.Forms.Button button12;

		// Token: 0x0400005D RID: 93
		private System.Windows.Forms.TextBox textBox7;

		// Token: 0x0400005E RID: 94
		private bool AttachedState;

		// Token: 0x0400005F RID: 95
		private bool AttachedButBroken;

		// Token: 0x04000060 RID: 96
		private SafeFileHandle WriteHandleToUSBDevice;

		// Token: 0x04000061 RID: 97
		private SafeFileHandle ReadHandleToUSBDevice;

		// Token: 0x04000062 RID: 98
		private string DevicePath;

		// Token: 0x04000063 RID: 99
		private string eDevicePath;

		// Token: 0x04000064 RID: 100
		private string e_saat;

		// Token: 0x04000065 RID: 101
		private int sayac;

		// Token: 0x04000066 RID: 102
		private bool PushbuttonPressed;

		// Token: 0x04000067 RID: 103
		private bool ToggleLEDsPending;

		// Token: 0x04000068 RID: 104
		private bool epr1;

		// Token: 0x04000069 RID: 105
		private bool z_epr;

		// Token: 0x0400006A RID: 106
		private bool zr_epr;

		// Token: 0x0400006B RID: 107
		private bool ztr_epr;

		// Token: 0x0400006C RID: 108
		private bool z_ilk;

		// Token: 0x0400006D RID: 109
		private bool z_basla;

		// Token: 0x0400006E RID: 110
		private uint ADCValue;

		// Token: 0x0400006F RID: 111
		private byte gun;

		// Token: 0x04000070 RID: 112
		private byte ay;

		// Token: 0x04000071 RID: 113
		private byte yil;

		// Token: 0x04000072 RID: 114
		private byte saat;

		// Token: 0x04000073 RID: 115
		private byte dakika;

		// Token: 0x04000074 RID: 116
		private byte saniye;

		// Token: 0x04000075 RID: 117
		private byte pilh;

		// Token: 0x04000076 RID: 118
		private byte pill;

		// Token: 0x04000077 RID: 119
		private byte v1;

		// Token: 0x04000078 RID: 120
		private byte v2;

		// Token: 0x04000079 RID: 121
		private byte sifreu;

		// Token: 0x0400007A RID: 122
		private byte sifreh;

		// Token: 0x0400007B RID: 123
		private byte sifrel;

		// Token: 0x0400007C RID: 124
		private byte sr_u;

		// Token: 0x0400007D RID: 125
		private byte sr_h;

		// Token: 0x0400007E RID: 126
		private byte y_k;

		// Token: 0x0400007F RID: 127
		private byte klb;

		// Token: 0x04000080 RID: 128
		private byte adrh;

		// Token: 0x04000081 RID: 129
		private byte adrl;

		// Token: 0x04000082 RID: 130
		private byte komut;

		// Token: 0x04000083 RID: 131
		private byte eepromu;

		// Token: 0x04000084 RID: 132
		private byte eepromh;

		// Token: 0x04000085 RID: 133
		private byte eeproml;

		// Token: 0x04000086 RID: 134
		private byte karth;

		// Token: 0x04000087 RID: 135
		private byte kartl;

		// Token: 0x04000088 RID: 136
		private byte karth2;

		// Token: 0x04000089 RID: 137
		private byte kartl2;

		// Token: 0x0400008A RID: 138
		private byte adr;

		// Token: 0x0400008B RID: 139
		private byte z_saat;

		// Token: 0x0400008C RID: 140
		private byte z_dakika;

		// Token: 0x0400008D RID: 141
		private byte z_sure;

		// Token: 0x0400008E RID: 142
		private byte z_gunler;

		// Token: 0x0400008F RID: 143
		private byte role;

		// Token: 0x04000090 RID: 144
		private byte k_ara;

		// Token: 0x04000091 RID: 145
		private Guid InterfaceClassGuid = new Guid(1293833650U, 61807, 4559, 136, 203, 0, 17, 17, 0, 0, 48);

		// Token: 0x04000092 RID: 146
		private string winDir = Environment.GetEnvironmentVariable("windir");

		// Token: 0x04000093 RID: 147
		private CultureInfo enGB = new CultureInfo("en-GB");

		// Token: 0x04000094 RID: 148
		public PageSettings ayarlar;

		// Token: 0x04000095 RID: 149
		public int sayfade;

		// Token: 0x04000096 RID: 150
		public string s1;

		// Token: 0x04000097 RID: 151
		public string tursaati1eski = "";

		// Token: 0x04000098 RID: 152
		public string tursaatis1 = "";

		// Token: 0x04000099 RID: 153
		public string tursaatiseski = "";

		// Token: 0x0400009A RID: 154
		public int saatok;

		// Token: 0x0400009B RID: 155
		public int bufok;

		// Token: 0x0400009C RID: 156
		public string şifre;

		// Token: 0x0400009D RID: 157
		public int t1hata;

		// Token: 0x0400009E RID: 158
		public int tamlen;

		// Token: 0x0400009F RID: 159
		public int pil;

		// Token: 0x040000A0 RID: 160
		public int nok;

		// Token: 0x040000A1 RID: 161
		public int dak;

		// Token: 0x040000A2 RID: 162
		public int edak;

		// Token: 0x040000A3 RID: 163
		public int sirano;

		// Token: 0x040000A4 RID: 164
		public int esaat;

		// Token: 0x040000A5 RID: 165
		public int eay;

		// Token: 0x040000A6 RID: 166
		public int eyil;

		// Token: 0x040000A7 RID: 167
		public int egun;

		// Token: 0x040000A8 RID: 168
		public int prsira;

		// Token: 0x040000A9 RID: 169
		public int carpan;

		// Token: 0x040000AA RID: 170
		public int dev;

		// Token: 0x040000AB RID: 171
		public int edev;

		// Token: 0x040000AC RID: 172
		public int olay_no;

		// Token: 0x040000AD RID: 173
		public int darbe;

		// Token: 0x040000AE RID: 174
		public int cihaz;

		// Token: 0x040000AF RID: 175
		public int bilgibekle;

		// Token: 0x040000B0 RID: 176
		public int leneep;

		// Token: 0x040000B1 RID: 177
		public int hattar;

		// Token: 0x040000B2 RID: 178
		public int leneeperr;

		// Token: 0x040000B3 RID: 179
		public string eskisan = "0";

		// Token: 0x040000B4 RID: 180
		public int sayfasayisi = 1;

		// Token: 0x040000B5 RID: 181
		public int es;

		// Token: 0x040000B6 RID: 182
		public int en;

		// Token: 0x040000B7 RID: 183
		public int ed;

		// Token: 0x040000B8 RID: 184
		public int turik;

		// Token: 0x040000B9 RID: 185
		public int pilref = 114;

		// Token: 0x040000BA RID: 186
		public int t_ilk;

		// Token: 0x040000BB RID: 187
		public int kont;

		// Token: 0x040000BC RID: 188
		public int xk;

		// Token: 0x040000BD RID: 189
		public int xk2;

		// Token: 0x040000BE RID: 190
		public int xk3;

		// Token: 0x040000BF RID: 191
		public int s_sn;

		// Token: 0x040000C0 RID: 192
		private DateTime zaman;

		// Token: 0x040000C1 RID: 193
		private DateTime ezaman;

		// Token: 0x040000C2 RID: 194
		private int zamanilk;

		// Token: 0x040000C3 RID: 195
		private string sure = "";

		// Token: 0x040000C4 RID: 196
		public int ilk;

		// Token: 0x040000C5 RID: 197
		public string directorym = "";

		// Token: 0x040000C6 RID: 198
		public string e_file = "";

		// Token: 0x040000C7 RID: 199
		public ulong[] yedek = new ulong[1500];

		// Token: 0x02000004 RID: 4
		internal struct SP_DEVICE_INTERFACE_DATA
		{
			// Token: 0x040000C8 RID: 200
			internal uint cbSize;

			// Token: 0x040000C9 RID: 201
			internal Guid InterfaceClassGuid;

			// Token: 0x040000CA RID: 202
			internal uint Flags;

			// Token: 0x040000CB RID: 203
			internal uint Reserved;
		}

		// Token: 0x02000005 RID: 5
		internal struct SP_DEVICE_INTERFACE_DETAIL_DATA
		{
			// Token: 0x040000CC RID: 204
			internal uint cbSize;

			// Token: 0x040000CD RID: 205
			internal char[] DevicePath;
		}

		// Token: 0x02000006 RID: 6
		internal struct SP_DEVINFO_DATA
		{
			// Token: 0x040000CE RID: 206
			internal uint cbSize;

			// Token: 0x040000CF RID: 207
			internal Guid ClassGuid;

			// Token: 0x040000D0 RID: 208
			internal uint DevInst;

			// Token: 0x040000D1 RID: 209
			internal uint Reserved;
		}

		// Token: 0x02000007 RID: 7
		internal struct DEV_BROADCAST_DEVICEINTERFACE
		{
			// Token: 0x040000D2 RID: 210
			internal uint dbcc_size;

			// Token: 0x040000D3 RID: 211
			internal uint dbcc_devicetype;

			// Token: 0x040000D4 RID: 212
			internal uint dbcc_reserved;

			// Token: 0x040000D5 RID: 213
			internal Guid dbcc_classguid;

			// Token: 0x040000D6 RID: 214
			internal char[] dbcc_name;
		}
	}
}
