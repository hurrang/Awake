using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Management;
using System.Diagnostics;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.Net.NetworkInformation;

namespace Awake
{

	public partial class frmAwake : Form
	{
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

		RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

		string app_path = Application.StartupPath;

		protected override CreateParams CreateParams
		{
			get
			{
				var cp = base.CreateParams;
				cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
				return cp;
			}
		}

		public frmAwake()
		{
			InitializeComponent();
		}


		[FlagsAttribute]
		public enum EXECUTION_STATE : uint
		{
			ES_AWAYMODE_REQUIRED = 0x00000040,
			ES_CONTINUOUS = 0x80000000,
			ES_DISPLAY_REQUIRED = 0x00000002,
			ES_SYSTEM_REQUIRED = 0x00000001
			// Legacy flag, should not be used.
			// ES_USER_PRESENT = 0x00000004
		}

		private void chkRun_CheckedChanged(object sender, EventArgs e)
		{
			if (chkRun.Checked)
			{
				// Add the value in the registry so that the application runs at startup
				rkApp.SetValue("AutoRobot", Application.ExecutablePath);
			}
			else
			{
				// Remove the value from the registry so that the application doesn't start
				rkApp.DeleteValue("AutoRobot", false);
			}
		}

		private void cmdSave_Click(object sender, EventArgs e)
		{
			var obj = new INI_JSON
			{
				start_time = dtTimer.Value.ToString("HH:mm"),
				m          = checkBox1.Checked.ToString(),
				t          = checkBox2.Checked.ToString(),
				w          = checkBox3.Checked.ToString(),
				y          = checkBox4.Checked.ToString(),
				f          = checkBox5.Checked.ToString(),
				autorun    = chAutoRun.Checked.ToString()

			};

			string json = JsonConvert.SerializeObject(obj);
			File.WriteAllText(app_path + "\\path.json", json);

		}

		private void button1_Click(object sender, EventArgs e)
		{


			using (StreamReader r = new StreamReader(app_path + "\\path.json"))
			{
				string jsonfile = r.ReadToEnd();
				INI_JSON obj = JsonConvert.DeserializeObject<INI_JSON>(jsonfile);
				//List<INI_JSON> obj = JsonConvert.DeserializeObject<List<INI_JSON>>(jsonfile);

				if (!string.IsNullOrEmpty(obj.start_time)) { dtTimer.Value = DateTime.Parse(obj.start_time.ToString()); } 
				if (!string.IsNullOrEmpty(obj.m)) { if (obj.m.ToString().Equals("True")) { checkBox1.Checked = true; } else { checkBox1.Checked = false; }} 
				if (!string.IsNullOrEmpty(obj.t)) { if (obj.t.ToString().Equals("True")) { checkBox2.Checked = true; } else { checkBox2.Checked = false; }} 
				if (!string.IsNullOrEmpty(obj.w)) { if (obj.w.ToString().Equals("True")) { checkBox3.Checked = true; } else { checkBox3.Checked = false; }} 
				if (!string.IsNullOrEmpty(obj.y)) { if (obj.y.ToString().Equals("True")) { checkBox4.Checked = true; } else { checkBox4.Checked = false; }} 
				if (!string.IsNullOrEmpty(obj.f)) { if (obj.f.ToString().Equals("True")) { checkBox5.Checked = true; } else { checkBox5.Checked = false; } }

				if (!string.IsNullOrEmpty(obj.autorun)) { if (obj.autorun.ToString().Equals("True")) { chAutoRun.Checked = true; pic_Coffe_Click(null, null); pic_shut_Click(null, null); } else { chAutoRun.Checked = false; } }
			}
		}

		private void coffee_on_Click(object sender, EventArgs e)
		{
			PreventSleep();
			coffee_on.Visible = true;
			coffee_off.Visible = false;
		}

		void PreventSleep()
		{
			// Prevent Idle-to-Sleep (monitor not affected) (see note above)
			SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_DISPLAY_REQUIRED);
		}
		void AvaiableSleep()
		{
			// Prevent Idle-to-Sleep (monitor not affected) (see note above)
			SetThreadExecutionState(EXECUTION_STATE.ES_SYSTEM_REQUIRED | EXECUTION_STATE.ES_AWAYMODE_REQUIRED);
		}

//Flags Descriptions
//ES_AWAYMODE_REQUIRED(0x00000040)
//Away mode should be used only by media-recording and media-distribution applications that must perform critical background processing
//on desktop computers while the computer appears to be sleeping.See Remarks.

//ES_CONTINUOUS(0x80000000)
//Informs the system that the state being set should remain in effect until the next call that uses ES_CONTINUOUS and one of the other state flags is cleared.

//ES_DISPLAY_REQUIRED(0x00000002)
//Forces the display to be on by resetting the display idle timer.

//ES_SYSTEM_REQUIRED(0x00000001)
//Forces the system to be in the working state by resetting the system idle timer.


		private void coffee_off_Click(object sender, EventArgs e)
		{
			coffee_on.Visible = false;
			coffee_off.Visible = true;
			AvaiableSleep();
		}

		private void shutdown_on_Click(object sender, EventArgs e)
		{
			shutdown_on.Visible = true;
			shutdown_off.Visible = false;
			panel1.Enabled = false;
			timer1.Interval = 1000;
			timer1.Tick += Timer1_Tick;
			timer1.Start();	
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				string nowday = DateTime.Now.DayOfWeek.ToString();

				if (nowday.Equals(checkBox1.Text)) { if (checkBox1.Checked == true) { Shutdown(); } }
				else if (nowday.Equals(checkBox2.Text)) { if (checkBox2.Checked == true) { Shutdown(); } }
				else if (nowday.Equals(checkBox3.Text)) { if (checkBox3.Checked == true) { Shutdown(); } }
				else if (nowday.Equals(checkBox4.Text)) { if (checkBox4.Checked == true) { Shutdown(); } }
				else if (nowday.Equals(checkBox5.Text)) { if (checkBox5.Checked == true) { Shutdown(); } }
				else
				{
					return;
				}
			}
			catch (Exception ex)
			{
				throw new NotImplementedException();
			}
		}

		void Shutdown()
		{
			string nowdate = DateTime.Now.ToString("HH:mm");
			if (nowdate.Equals(dtTimer.Value.ToString("HH:mm")))
			{
				timer1.Stop();
				Process.Start(new ProcessStartInfo("shutdown", "/s /t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false
				});
			}
		}

		private void shutdown_off_Click(object sender, EventArgs e)
		{
			shutdown_on.Visible  = false;
			shutdown_off.Visible = true;
			timer1.Stop();
			panel1.Enabled = true;
		}

		private void frmAwake_Load(object sender, EventArgs e)
		{
			//shutdown_on.Visible = false;
			//coffee_on.Visible   = false;

			pic_Coffe.Image = Properties.Resources.switch_off_icon;
			pic_shut.Image  = Properties.Resources.switch_off_icon;


			button1_Click(null, null);

			this.WindowState = FormWindowState.Minimized;
			this.ShowInTaskbar  = false;
			notifyIcon1.Visible = true;

			Application.ApplicationExit += Exit;
		}

		private void exotToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }

            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }

            this.BringToFront();
			
		}

		private void frmAwake_SizeChanged(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.Visible = false;
				this.ShowInTaskbar = false;
				notifyIcon1.Visible = true;
			}

			else if (this.WindowState == FormWindowState.Normal)
			{
				this.Visible = true;
				this.ShowInTaskbar = true;
				notifyIcon1.Visible = false;
			}
		}

		private void frmAwake_FormClosing(object sender, FormClosingEventArgs e)
		{
			cmdSave_Click(null, null);
			
		}

		string coffe_status = "off";
		string shut_status = "off";
		private void pic_Coffe_Click(object sender, EventArgs e)
		{
			if (coffe_status.Equals("off"))
			{
				coffee_on_Click(null, null);
				pic_Coffe.Image = Properties.Resources.switch_on_icon;
				coffe_status = "on";
			}
			else
			{
				coffee_off_Click(null, null);
				pic_Coffe.Image = Properties.Resources.switch_off_icon;
				coffe_status = "off";
			}
		}

		private void pic_shut_Click(object sender, EventArgs e)
		{
			if (shut_status.Equals("off"))
			{
				shutdown_on_Click(null, null);
				pic_shut.Image = Properties.Resources.switch_on_icon;
				shut_status = "on";
			}
			else
			{
				shutdown_off_Click(null, null);
				pic_shut.Image = Properties.Resources.switch_off_icon;
				shut_status = "off";
			}
		}

		private void Exit(object sender, EventArgs e)
		{
			notifyIcon1.Dispose();
		}

        private void frmAwake_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void chAutoRun_CheckedChanged(object sender, EventArgs e)
        {

        }

        //protected override void SetVisibleCore(bool value)
        //{
        //	if (value && !this.IsHandleCreated)
        //	{
        //		value = false;
        //		CreateHandle();
        //		// Put your Load event code here
        //		this.WindowState = FormWindowState.Minimized;
        //		this.ShowInTaskbar = false;
        //		notifyIcon1.Visible = true;

        //	}
        //	base.SetVisibleCore(value);
        //}
    }
}
