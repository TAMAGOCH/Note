using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
        protected static extern int mciSendString
           (string mciCommand,
           StringBuilder returnValue,
           int returnLength,
           IntPtr callback);

        static void Main(string[] args)
        {

            int result = mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
            result = mciSendString("set cdaudio door closed", null, 0, IntPtr.Zero);
        }

    }
}

