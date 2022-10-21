﻿using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Console;
namespace SimpleDLLTest
{
    public class DllImportExample
    {
        [DllImport("User32.dll")]
        public static extern int
        SetForegroundWindow(IntPtr point);
    }
    class Program
    {
        static void Main(string[] args)
        {
            string? processName = "notepad.exe", text;
            Write("Enter text: ");
            text = ReadLine();
            Process p = Process.Start(processName);
            p.WaitForInputIdle();
            IntPtr h = p.MainWindowHandle;
            DllImportExample.SetForegroundWindow(h);
            SendKeys.SendWait(text);
        }
    }
}
