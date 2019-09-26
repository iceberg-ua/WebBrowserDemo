using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowserDemo
{
    public class ActionListener : TraceListener
    {
        public delegate void NewMessageDelegate(string msg);

        public event NewMessageDelegate NewLineCame;
        public event NewMessageDelegate NewStringCame;

        public override void Write(string message)
        {
            NewLineCame?.Invoke(message);
        }

        public override void WriteLine(string message)
        {
            NewStringCame?.Invoke(message);
        }
    }
}
