using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wallpainter
{
    class WallpaperManager
    {
        private struct Window
        {
            public IntPtr Handle;
            public UInt32 Style;

			public WinAPI.RECT Bounds;

            public Window(IntPtr hwnd, uint style, WinAPI.RECT bounds)
            {
                Handle = hwnd;
                Style = style;
				Bounds = bounds;
            }

            public bool IsValid()
            {
                return Handle != IntPtr.Zero;
            }

            public void Reset()
            {
                Handle = IntPtr.Zero;
                Style = 0;
            }

        }

        private Window curWindow;
		private string curWindowTitle;
        private IntPtr progman = IntPtr.Zero;

        public WallpaperManager()
        {
            progman = Wallpainter.SetupWallpaper();

            if (progman == IntPtr.Zero)
                throw new InvalidOperationException("Failed to retrieve progman!");
        }
		~WallpaperManager()
		{
            //Remove from wallpaper
            if (curWindow.IsValid())
            {
                Restore(curWindow);
                curWindow.Reset();
            }
		}

        public bool SetWallpaper(IntPtr wp, string title = "N/A", int posx = 0, int posy = 0, int width = -1, int height = -1)
        {
            //Remove from wallpaper
            if (curWindow.IsValid())
            {
                Restore(curWindow);
                curWindow.Reset();
            }

            //set the next
            curWindow = Set(wp, posx, posy, width, height);
			curWindowTitle = title;

            return curWindow.IsValid();
        }

        public IntPtr GetWallpaperWindow()
        {
            return curWindow.Handle;
        }

		public string GetWallpaperWindowTitle()
		{
			string text;
			if (curWindow.Handle == IntPtr.Zero)
			{
				text = "Wallpainter - N/A";
			}
			else
			{
				text = "Wallpainter - " + curWindowTitle;
			}
			return text;
		}

		private Window Set(IntPtr hwnd, int posx = 0, int posy = 0, int width = -1, int height = -1)
        {
            uint style = WinAPI.GetWindowLong(hwnd, (int)WinAPI.WindowLongFlags.GWL_STYLE);

			// Store old positioning and size
			WinAPI.RECT oldbounds;
			WinAPI.GetWindowRect(hwnd, out oldbounds);

			// Must offset for worker thread
			Screen current = Screen.FromHandle(hwnd);
			{
				// Width and height can be flagged as fullscreen
				if (width == -1)
				{
					width = current.Bounds.Width;
				}
				if (height == -1)
				{
					height = current.Bounds.Height;
				}
			}
			WinAPI.SetWindowPos(hwnd, progman, current.Bounds.X + current.Bounds.Width + posx, current.Bounds.Y + posy, width, height, 0);

			if (WinAPI.SetParent(hwnd, progman) == IntPtr.Zero)
			    return new Window();

			//Remove borders
			//TODO: Should this be an option? It might break some programs
			WinAPI.SetWindowLong(hwnd, (int)WinAPI.WindowLongFlags.GWL_STYLE, 0);

			//Maximize the window
			//TODO: Fine-grained placement. This kinda sucks for multimonitor setups
			WinAPI.ShowWindowAsync(hwnd, 1);

			return new Window(hwnd, style, oldbounds);
        }

        private void Restore(Window window)
        {
            if (WinAPI.SetParent(window.Handle, IntPtr.Zero) != IntPtr.Zero)
			{
				WinAPI.SetWindowLong(window.Handle, (int)WinAPI.WindowLongFlags.GWL_STYLE, window.Style);
				// Return to old size and position
				WinAPI.SetWindowPos(window.Handle, progman, window.Bounds.Left, window.Bounds.Top, window.Bounds.Right - window.Bounds.Left, window.Bounds.Bottom - window.Bounds.Top, 0);
			}
		}
    }
}
