namespace Awake
{
	partial class frmAwake
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAwake));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtTimer = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chkRun = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chAutoRun = new System.Windows.Forms.CheckBox();
            this.pic_shut = new System.Windows.Forms.PictureBox();
            this.pic_Coffe = new System.Windows.Forms.PictureBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.shutdown_off = new System.Windows.Forms.Button();
            this.shutdown_on = new System.Windows.Forms.Button();
            this.coffee_off = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.coffee_on = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_shut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Coffe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "Molex Coffee Bean";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Molex Coffee Bean";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exotToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exotToolStripMenuItem
            // 
            this.exotToolStripMenuItem.Name = "exotToolStripMenuItem";
            this.exotToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exotToolStripMenuItem.Text = "Exit";
            this.exotToolStripMenuItem.Click += new System.EventHandler(this.exotToolStripMenuItem_Click);
            // 
            // dtTimer
            // 
            this.dtTimer.CustomFormat = "HH:mm";
            this.dtTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dtTimer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimer.Location = new System.Drawing.Point(92, 69);
            this.dtTimer.Name = "dtTimer";
            this.dtTimer.Size = new System.Drawing.Size(102, 23);
            this.dtTimer.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(11, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 18);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Monday";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(92, 12);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 18);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Tuesday";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(176, 12);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(100, 18);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Wednesday";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(282, 12);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(84, 18);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "Thursday";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(372, 12);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(64, 18);
            this.checkBox5.TabIndex = 12;
            this.checkBox5.Text = "Friday";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdSave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.dtTimer);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Location = new System.Drawing.Point(12, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 112);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Shutdown ";
            // 
            // chkRun
            // 
            this.chkRun.AutoSize = true;
            this.chkRun.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRun.Location = new System.Drawing.Point(361, 257);
            this.chkRun.Name = "chkRun";
            this.chkRun.Size = new System.Drawing.Size(106, 18);
            this.chkRun.TabIndex = 16;
            this.chkRun.Text = "Auto Startup";
            this.chkRun.UseVisualStyleBackColor = true;
            this.chkRun.CheckedChanged += new System.EventHandler(this.chkRun_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Load Config";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chAutoRun
            // 
            this.chAutoRun.AutoSize = true;
            this.chAutoRun.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chAutoRun.Location = new System.Drawing.Point(384, 12);
            this.chAutoRun.Name = "chAutoRun";
            this.chAutoRun.Size = new System.Drawing.Size(83, 18);
            this.chAutoRun.TabIndex = 16;
            this.chAutoRun.Text = "Auto Run";
            this.chAutoRun.UseVisualStyleBackColor = true;
            this.chAutoRun.CheckedChanged += new System.EventHandler(this.chAutoRun_CheckedChanged);
            // 
            // pic_shut
            // 
            this.pic_shut.Image = global::Awake.Properties.Resources.switch_off_icon;
            this.pic_shut.Location = new System.Drawing.Point(104, 72);
            this.pic_shut.Name = "pic_shut";
            this.pic_shut.Size = new System.Drawing.Size(48, 48);
            this.pic_shut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_shut.TabIndex = 18;
            this.pic_shut.TabStop = false;
            this.pic_shut.Click += new System.EventHandler(this.pic_shut_Click);
            // 
            // pic_Coffe
            // 
            this.pic_Coffe.Image = global::Awake.Properties.Resources.switch_off_icon;
            this.pic_Coffe.Location = new System.Drawing.Point(104, 14);
            this.pic_Coffe.Name = "pic_Coffe";
            this.pic_Coffe.Size = new System.Drawing.Size(48, 48);
            this.pic_Coffe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Coffe.TabIndex = 17;
            this.pic_Coffe.TabStop = false;
            this.pic_Coffe.Click += new System.EventHandler(this.pic_Coffe_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.FlatAppearance.BorderSize = 0;
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSave.Image = ((System.Drawing.Image)(resources.GetObject("cmdSave.Image")));
            this.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdSave.Location = new System.Drawing.Point(355, 36);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(74, 75);
            this.cmdSave.TabIndex = 14;
            this.cmdSave.Text = "Save Config";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // shutdown_off
            // 
            this.shutdown_off.FlatAppearance.BorderSize = 0;
            this.shutdown_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shutdown_off.Image = ((System.Drawing.Image)(resources.GetObject("shutdown_off.Image")));
            this.shutdown_off.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shutdown_off.Location = new System.Drawing.Point(570, 375);
            this.shutdown_off.Name = "shutdown_off";
            this.shutdown_off.Size = new System.Drawing.Size(59, 50);
            this.shutdown_off.TabIndex = 14;
            this.shutdown_off.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.shutdown_off.UseVisualStyleBackColor = true;
            this.shutdown_off.Click += new System.EventHandler(this.shutdown_off_Click);
            // 
            // shutdown_on
            // 
            this.shutdown_on.FlatAppearance.BorderSize = 0;
            this.shutdown_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shutdown_on.Image = ((System.Drawing.Image)(resources.GetObject("shutdown_on.Image")));
            this.shutdown_on.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shutdown_on.Location = new System.Drawing.Point(514, 375);
            this.shutdown_on.Name = "shutdown_on";
            this.shutdown_on.Size = new System.Drawing.Size(59, 50);
            this.shutdown_on.TabIndex = 13;
            this.shutdown_on.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.shutdown_on.UseVisualStyleBackColor = true;
            this.shutdown_on.Click += new System.EventHandler(this.shutdown_on_Click);
            // 
            // coffee_off
            // 
            this.coffee_off.FlatAppearance.BorderSize = 0;
            this.coffee_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coffee_off.Image = ((System.Drawing.Image)(resources.GetObject("coffee_off.Image")));
            this.coffee_off.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coffee_off.Location = new System.Drawing.Point(570, 310);
            this.coffee_off.Name = "coffee_off";
            this.coffee_off.Size = new System.Drawing.Size(59, 50);
            this.coffee_off.TabIndex = 4;
            this.coffee_off.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coffee_off.UseVisualStyleBackColor = true;
            this.coffee_off.Click += new System.EventHandler(this.coffee_off_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(45, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // coffee_on
            // 
            this.coffee_on.FlatAppearance.BorderSize = 0;
            this.coffee_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coffee_on.Image = ((System.Drawing.Image)(resources.GetObject("coffee_on.Image")));
            this.coffee_on.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coffee_on.Location = new System.Drawing.Point(514, 310);
            this.coffee_on.Name = "coffee_on";
            this.coffee_on.Size = new System.Drawing.Size(59, 50);
            this.coffee_on.TabIndex = 1;
            this.coffee_on.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coffee_on.UseVisualStyleBackColor = true;
            this.coffee_on.Click += new System.EventHandler(this.coffee_on_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmAwake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(478, 288);
            this.Controls.Add(this.pic_shut);
            this.Controls.Add(this.chkRun);
            this.Controls.Add(this.pic_Coffe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chAutoRun);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shutdown_off);
            this.Controls.Add(this.shutdown_on);
            this.Controls.Add(this.coffee_off);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.coffee_on);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAwake";
            this.Text = "Molex Coffee Bean";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAwake_FormClosing);
            this.Load += new System.EventHandler(this.frmAwake_Load);
            this.SizeChanged += new System.EventHandler(this.frmAwake_SizeChanged);
            this.VisibleChanged += new System.EventHandler(this.frmAwake_VisibleChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_shut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Coffe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button coffee_on;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button coffee_off;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.DateTimePicker dtTimer;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.Button shutdown_off;
		private System.Windows.Forms.Button shutdown_on;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chkRun;
		private System.Windows.Forms.Button cmdSave;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exotToolStripMenuItem;
		private System.Windows.Forms.CheckBox chAutoRun;
		private System.Windows.Forms.PictureBox pic_Coffe;
		private System.Windows.Forms.PictureBox pic_shut;
	}
}