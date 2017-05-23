using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Information : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database.mdb");
        string prod;
        public Information(string produkt)
        {
            InitializeComponent();
            prod = produkt;
        }

        private void Information_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            conn.Open();
            OleDbCommand command = new OleDbCommand("SELECT Nazw,bel,giri,ugl,kl FROM Produkt WHERE [Nazw]='" + prod+"'", conn);
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            listBox1.Items.Add(reader.GetValue(0));
            listBox2.Items.Add(reader.GetValue(4));
            listBox3.Items.Add(reader.GetValue(1));
            listBox4.Items.Add(reader.GetValue(2));
            listBox5.Items.Add(reader.GetValue(3));           
            conn.Close();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Google google = new Google(prod);
            google.Show();
        }
    }
}
