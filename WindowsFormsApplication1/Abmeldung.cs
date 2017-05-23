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
  
    public partial class Abmeldung : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database.mdb");
        public Abmeldung()
        {
            InitializeComponent();
        }

               private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand("SELECT ID,Login,Parol FROM Leute WHERE Login='" + textBox1.Text.ToString() + "' AND Parol='" + textBox2.Text.ToString() + "'", conn);//"' && Parol='" + textBox2.Text.ToString() +
                OleDbDataReader read = comm.ExecuteReader();
                read.Read();
                Kalory kl = new Kalory(Convert.ToInt32(read[0]));
                string log = Convert.ToString(read[1]);
                string par = Convert.ToString(read[2]);
            if ((String.Compare(log, textBox1.Text.ToString()) == 0)&&(String.Compare(par, textBox2.Text.ToString()) == 0))
            {
                kl.Show();
                textBox1.Clear();
                textBox2.Clear();
                    this.Hide();
            }
            else MessageBox.Show("Логин или пароль не совпадают!");

            }
            catch
            {
                MessageBox.Show("Логин или пароль не совпадают!");
                               
            }
    conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registrierung reg = new Registrierung();
            reg.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
