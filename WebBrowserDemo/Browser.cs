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
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
            Debug.WriteLine("Browser window is initialized");
        }

        string _initialURL = string.Empty;
        List<WebBrowser> _browsers = new List<WebBrowser>();

        public Browser(int count, string url)
            : this()
        {
            _initialURL = url;

            for (int i = 0; i < count; i++)
            {
                var browser = new WebBrowser();
                Controls.Add(browser);
                _browsers.Add(browser);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            webBrowser1.Navigate(_initialURL.Equals(string.Empty) ? "google.com" : _initialURL);
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        { 
            foreach (var item in _browsers)
            {
                item.Dispose();
            }

            base.OnClosing(e);
        }
    }
}
