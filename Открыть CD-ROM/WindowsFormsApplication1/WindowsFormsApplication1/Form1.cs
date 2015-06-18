using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
        protected static extern int mciSendString
        (string mciCommand,
        StringBuilder returnValue,
        int returnLength,
        IntPtr callback);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          int  result = mciSendString("set cdaudio door closed", null, 0, IntPtr.Zero);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c shutdown -s";
            p.Start(); 
        }
    }
}
