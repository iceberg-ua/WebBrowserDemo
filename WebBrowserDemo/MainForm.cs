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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _listenerWindow.Show();
        }

        ActionListenerWindow _listenerWindow = new ActionListenerWindow();
        List<Browser> _browsers = new List<Browser>();

        private void Button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Create button clicked");
            int.TryParse(textBox2.Text, out int count);

            //for (int i = 0; i <= count; i++)
            {
                var browser = new Browser(count, textBox1.Text);
                _browsers.Add(browser);
                browser.Show();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Clear button clicked");

            foreach (var item in _browsers)
            {
                item.Dispose();
            }
        }
    }
}
