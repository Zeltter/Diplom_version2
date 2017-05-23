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
    public partial class Erste : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database.mdb");

        int id;
        int pol = 0;
        public Erste(int customerId)
        {
            InitializeComponent();
            id = customerId;
        }

        private void калькуляторКалорийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string wes = textBox3.Text.ToString();
            Kalory kalory = new Kalory(id);
            kalory.Show();
            this.Close();

        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Statistik stat = new Statistik(id);
            stat.Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Erste_Load(object sender, EventArgs e)
        {
            jahre.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            conn.Open();
            OleDbCommand com = new OleDbCommand("SELECT KG FROM Statistik WHERE Kod=" + id + " ORDER BY Dat DESC", conn);//+ customerId.ToString()
            OleDbDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                textBox3.Text = read[0].ToString();
                break;
            }
            string str = "Мужской";
            OleDbCommand command = new OleDbCommand("SELECT Pol FROM Leute WHERE ID=@BenutzerID", conn);
            command.Parameters.AddWithValue("@BenutzerID", id);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString().CompareTo(str) == 0)
                {
                    pol = 1;
                    pictureBox1.Image = Properties.Resources.Man;
                }
                else
                {
                    pol = 2;
                    pictureBox1.Image = Properties.Resources.GRfr;
                }

            }



            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox3.Text == "") || (textBox4.Text == "")) MessageBox.Show("Вы не заполнили нужные поля!");
            else
            {
                if ((Convert.ToInt32(textBox3.Text) < 30) || (Convert.ToInt32(textBox3.Text) > 300) || (Convert.ToInt32(textBox4.Text) < 150) || (Convert.ToInt32(textBox4.Text) > 250)) MessageBox.Show("Поля заполнены не корректными данными!");
                else
                {
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    listBox3.Items.Clear();
                    Double koef = 0;
                    int hudet = 34;
                    int wes = Convert.ToInt32(textBox3.Text);
                    Double rez2 = 0;
                    if (pol == 1)
                    {
                        int tb4 = Convert.ToInt32(textBox4.Text);
                        Double rez = (((tb4 - 110) * 1.15) / 100) * 88;
                        listBox1.Items.Add(rez);
                        listBox3.Items.Add(wes * 48);
                    }
                    else if (pol == 2)
                    {
                        int tb4 = Convert.ToInt32(textBox4.Text);
                        Double rez = ((tb4 - 100) - (tb4 - 150) / 2) ;
                        listBox1.Items.Add(rez);
                        listBox3.Items.Add(wes * 26);
                    }
                    if (comboBox1.SelectedIndex == 0)
                    {
                        koef = 1.1;
                    }
                    if (comboBox1.SelectedIndex == 1)
                    {
                        koef = 1.3;
                    }
                    if (comboBox1.SelectedIndex == 2)
                    {
                        koef = 1.5;
                    }

                    if (jahre.SelectedIndex == 0)
                    {
                        if (pol == 1)
                        {
                            rez2 = (0.063 * wes + 2.9) * 240;
                        }
                        if (pol == 2)
                        {
                            rez2 = (0.062 * wes + 2.036) * 240;
                        }

                    }
                    if (jahre.SelectedIndex == 1)
                    {
                        if (pol == 1)
                        {
                            rez2 = (0.05 * wes + 3.65) * 240;
                        }
                        if (pol == 2)
                        {
                            rez2 = (0.034 * wes + 3.54) * 240;
                        }

                    }
                    if (jahre.SelectedIndex == 2)
                    {
                        if (pol == 1)
                        {
                            rez2 = (0.05 * wes + 2.46) * 240;
                        }
                        if (pol == 2)
                        {
                            rez2 = (0.04 * wes + 2.75) * 240;
                        }

                    }
                    hudet = Convert.ToInt32(rez2 * koef);
                    listBox2.Items.Add(hudet);
                }
            }
        }
       

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar)|| char.IsSymbol(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

      

       

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help hl = new Help();
            hl.Show();
        }

       

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Size = new System.Drawing.Size(148, 53);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Size = new System.Drawing.Size(168, 73);
        }
            }
}
