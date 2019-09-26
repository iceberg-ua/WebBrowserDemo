using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserDemo
{
    public partial class ActionListenerWindow : Form
    {
        ActionListener _listener = new ActionListener();

        public ActionListenerWindow()
        {
            InitializeComponent();

            Debug.Listeners.Add(_listener);
            _listener.NewLineCame += ListenerNewLineCame;
            _listener.NewStringCame += ListenerNewStringCame;
        }

        private void ListenerNewStringCame(string msg)
        {
            textBox1.Text += msg;
            textBox1.Text += Environment.NewLine;
        }

        private void ListenerNewLineCame(string msg)
        {
            textBox1.Text += msg;
            //textBox1.Text += Environment.NewLine;
        }
    }
}
