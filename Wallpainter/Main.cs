using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Wallpainter
{
    public partial class WallpainterMain : Form
    {
        WallpaperManager mgr;

		public WallpainterMain()
        {
            InitializeComponent();

            mgr = new WallpaperManager();
		}

		private void WallpainterMain_Resize(object sender, EventArgs e)
		{
			notifyIcon1.BalloonTipTitle = "Minimize to Tray App";
			notifyIcon1.BalloonTipText = "You have successfully minimized your form.";

			if (FormWindowState.Minimized == this.WindowState)
			{
				notifyIcon1.Visible = true;
				notifyIcon1.ShowBalloonTip(500);
				this.Hide();
			}
			else if (FormWindowState.Normal == this.WindowState)
			{
				notifyIcon1.Visible = false;
			}
		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.Show();
			this.WindowState = FormWindowState.Normal;
		}

		private void buttonAttach_Click(object sender, EventArgs e)
        {
			//Also ability to startup programs to set
			IntPtr wndHandle = IntPtr.Zero;
			int matches = 0;
			foreach (Process proc in Process.GetProcesses())
			{
				if (proc.MainWindowTitle.ToLower().Contains(textboxWindowName.Text.ToLower()))
				{
					wndHandle = proc.MainWindowHandle;
					matches++;
				}
			}
			if (wndHandle == IntPtr.Zero)
			{
                MessageBox.Show("No window found!", "Failed to attach", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
			if (matches > 1)
			{
                MessageBox.Show("Matches multiple windows!", "Failed to attach", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
			}

            if (mgr.SetWallpaper(wndHandle, (int) numericUpDownPosX.Value, (int) numericUpDownPosY.Value, (int) numericUpDownSizeX.Value, (int) numericUpDownSizeY.Value))
            {
                buttonDetach.Enabled = true;
            }
        }

        private void buttonDetach_Click(object sender, EventArgs e)
        {
            mgr.SetWallpaper(IntPtr.Zero);
            buttonDetach.Enabled = false;
        }

        private void WallpainterMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Reset the wallpaper on exit
            mgr.SetWallpaper(IntPtr.Zero);
        }

		private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
		{
			notifyIcon1.Visible = false;
			this.Show();
			this.WindowState = FormWindowState.Normal;
		}
	}
}
