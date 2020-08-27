using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Learning_Timer
{
    class Tools
    {
        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        // ReSharper disable once InconsistentNaming
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

        // ReSharper disable once InconsistentNaming
        private const uint SWP_NOSIZE = 0x0001;
        // ReSharper disable once InconsistentNaming
        private const uint SWP_NOMOVE = 0x0002;

        internal static void MakeTopMost(Form f)
        {
            SetWindowPos(f.Handle, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
        }
    }
}
