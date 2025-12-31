using System;
using System.Runtime.InteropServices;

namespace Notification.Wpf.Utils;


internal static class NativeMethods
{
    public const int MDT_EFFECTIVE_DPI = 0;

    [DllImport("user32.dll")]
    public static extern IntPtr GetForegroundWindow();

    [DllImport("user32.dll")]
    public static extern IntPtr MonitorFromWindow(
        IntPtr hwnd,
        int dwFlags);

    [DllImport("shcore.dll")]
    public static extern int GetDpiForMonitor(
        IntPtr hmonitor,
        int dpiType,
        out uint dpiX,
        out uint dpiY);
}
