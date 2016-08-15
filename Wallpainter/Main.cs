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
				string text = mgr.GetWallpaperWindowTitle();
				{
					if ( text.Length >= 64 )
					{
						// LESS than 64, Count ellipses
						int newlength = 64 - 1 - 3;
						text = text.Remove( newlength );
						text += "...";
					}
				}
                notifyIcon1.Text = text;
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
			string wndTitle = "";
            int matches = 0;
			foreach (Process proc in Process.GetProcesses())
			{
				// If exact then use that, otherwise find close match
				if (proc.MainWindowTitle == textboxWindowName.Text)
				{
					wndHandle = proc.MainWindowHandle;
					wndTitle = proc.MainWindowTitle;
                    matches = 1;
                    break;
				}
				else if (proc.MainWindowTitle.ToLower().Contains(textboxWindowName.Text.ToLower()))
				{
					wndHandle = proc.MainWindowHandle;
					wndTitle = proc.MainWindowTitle;
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

            if (mgr.SetWallpaper(wndHandle, wndTitle, (int) numericUpDownPosX.Value, (int) numericUpDownPosY.Value, (int) numericUpDownSizeX.Value, (int) numericUpDownSizeY.Value))
            {
                buttonDetach.Enabled = true;
				this.Text = mgr.GetWallpaperWindowTitle();
			}
        }

        private void buttonDetach_Click(object sender, EventArgs e)
        {
            mgr.SetWallpaper(IntPtr.Zero);
            buttonDetach.Enabled = false;
			this.Text = mgr.GetWallpaperWindowTitle();
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
