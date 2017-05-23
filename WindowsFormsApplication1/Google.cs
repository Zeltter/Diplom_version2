using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Google : Form
    {
        string search;
        public Google(string prod)
        {
            InitializeComponent();
            search = prod;
        }

       

        private void Google_Load(object sender, EventArgs e)
        {
            webBrowser2.Navigate("https://www.google.com/search?q="+search);
            webBrowser2.ScriptErrorsSuppressed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser2.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser2.GoForward();
        }
    }
}
