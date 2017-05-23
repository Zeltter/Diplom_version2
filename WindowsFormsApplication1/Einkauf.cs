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
    public partial class Einkauf : Form
    {
        public Einkauf()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Einkauf_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.produkt' table. You can move, or remove it, as needed.
            this.produktTableAdapter.Fill(this.databaseDataSet1.produkt);
            string url = "https://yandex.ua/maps/141/dnipro/?ncrnd=5319&ll=35.005285%2C48.430513&z=16&rtext=48.429312%2C35.007831~48.431452%2C35.002739&rtt=pd&rtm=atm&mode=routes";
            webBrowser1.Navigate(url);
        }
    }
}
