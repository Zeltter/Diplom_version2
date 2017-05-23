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
    public partial class Nachtrag : Form
    {
        int id;
        int idProd;
        
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database.mdb");
        public Nachtrag(int customerId)
        {
            InitializeComponent();
            id = customerId;
        }

        public void Neu()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            conn.Open();
            OleDbCommand command = new OleDbCommand("SELECT Nazw FROM produkt WHERE  BenutzerID=" + id, conn);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader.GetValue(0));
                listBox2.Items.Add(reader.GetValue(0));
            }
            conn.Close();
        }
        private bool isFounded(String[] sabstr, int findetIndex, string str)
        {
            Char[] firstCharIntString = str.ToCharArray();
            String stringFirstCharUpper = "";
            stringFirstCharUpper += Char.ToUpper(firstCharIntString[0]);
            for (int m = 1; m < firstCharIntString.Length; m++)
            {
                stringFirstCharUpper += firstCharIntString[m];
            }
            for (int m = 0; m < sabstr.Length; m++)
            {
                if (sabstr[m].Contains(stringFirstCharUpper) || sabstr[m].Contains(str))
                {
                    listBox1.SetSelected(findetIndex, true);
                    listBox2.SetSelected(findetIndex, true);
                    return true;
                }

            }
            return false;
        }
        public void textB_KeyUp(object sender, KeyEventArgs e, string str)
        {


            int index = listBox1.FindString(str);
            if (index != -1)
            {
                listBox1.SetSelected(index, true);
                listBox2.SetSelected(index, true);
            }
            else
            {
                if (listBox1.Items.Count != 0)
                {
                    if (str != "")
                    {
                        listBox1.SetSelected(0, true);
                        Char derimiter = ' ';
                        String strValue;
                        String[] subString;
                        for (int m = 0; m < listBox1.Items.Count; m++)
                        {
                            strValue = listBox1.Items[m].ToString();
                            subString = strValue.Split(derimiter);
                            if (isFounded(subString, m,str))
                            {
                                break;
                            }
                        }
                    }
                }
            }

        }
        private void Nachtrag_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Поиск продукта";//подсказка
            textBox1.ForeColor = Color.Gray;
            textBox7.Text = "Поиск продукта";//подсказка
            textBox7.ForeColor = Color.Gray;
            Neu();
            textBox6.KeyPress += (text_KeyPress);
            textBox3.KeyPress += (text_KeyPress);
            textBox4.KeyPress += (text_KeyPress);
            textBox5.KeyPress += (text_KeyPress);
            textBox9.KeyPress += (text_KeyPress);
            textBox10.KeyPress += (text_KeyPress);
            textBox11.KeyPress += (text_KeyPress);
            textBox12.KeyPress += (text_KeyPress);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == "") || (textBox6.Text == "")) MessageBox.Show("Вы не заполнили нужные поля!");
            else
            {
                DialogResult result = MessageBox.Show("Вы уверены что хотите добавить эту запись?", "Warning", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    conn.Open();

                    OleDbCommand comm = new OleDbCommand("SELECT Nazw FROM produkt WHERE Nazw='" + textBox2.Text.ToString() + "' AND BenutzerID=" + id, conn);
                    int gibt = 0;
                    OleDbDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        gibt++;
                    }
                    conn.Close();
                    if (gibt > 0) MessageBox.Show("Продукт с таким названием уже существует!");
                    else
                    {
                        conn.Open();
                        Double kg = 0.1;
                        int gr = 32;
                        string sqlQuery = string.Format("INSERT INTO produkt (Nazw,kl,bel,giri,ugl,kg,BenutzerID,[group]) VALUES (@Nazw,@kl,@bel,@giri,@ugl,@kg,@BenutzerID,@group)");
                        OleDbCommand command = new OleDbCommand(sqlQuery, conn);
                        command.CommandType = CommandType.Text;
                        command.CommandText = sqlQuery;
                        command.Connection = conn;
                        command.Parameters.AddWithValue("@Nazw", textBox2.Text);
                        command.Parameters.AddWithValue("@kl", textBox3.Text);
                        command.Parameters.AddWithValue("@bel", textBox4.Text);
                        command.Parameters.AddWithValue("@giri", textBox5.Text);
                        command.Parameters.AddWithValue("@ugl", textBox6.Text);
                        command.Parameters.AddWithValue("@kg", kg);
                        command.Parameters.AddWithValue("@BenutzerID", id);
                        command.Parameters.AddWithValue("@group", gr);

                        if (command.ExecuteNonQuery() == 0) { MessageBox.Show("Продукт не добавлен!"); }
                        else { MessageBox.Show("Продукт добавлен!"); }
                        command.Dispose();
                        conn.Close();
                        Neu();
                    }
                }
            }
        }
        

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить этот продукт?", "Warning", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string produkt = listBox1.SelectedItem.ToString();
                conn.Open();
                OleDbCommand command = new OleDbCommand("DELETE FROM produkt WHERE Nazw=@Nazw AND BenutzerID=@BenutzerID", conn);
                command.Connection = conn;
                command.Parameters.AddWithValue("@Nazw", produkt);
                command.Parameters.AddWithValue("@BenutzerID", id);
                command.ExecuteNonQuery();
                conn.Close();
                Neu();
            }
        }
        
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int y = e.Y / listBox1.ItemHeight;
                if (y < listBox1.Items.Count)
                {
                    listBox1.SelectedIndex = listBox1.TopIndex + y;
                }
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            string produkt = listBox1.SelectedItem.ToString();
            OleDbCommand command = new OleDbCommand("SELECT Nazw,kl,bel,giri,ugl,ID FROM produkt WHERE [Nazw]=@Nazw AND [BenutzerID]=@BenutzerID", conn);
            command.Parameters.AddWithValue("@Nazw", produkt);
            command.Parameters.AddWithValue("@BenutzerID", id);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                textBox8.Text = Convert.ToString(reader[0]);
                textBox9.Text = Convert.ToString(reader[1]);
                textBox10.Text = Convert.ToString(reader[2]);
                textBox11.Text = Convert.ToString(reader[3]);
                textBox12.Text = Convert.ToString(reader[4]);
                idProd = Convert.ToInt32(reader[5]);
            }
            conn.Close();
            tabControl1.SelectedIndex = 1;
            listBox2.SelectedIndex = listBox1.SelectedIndex;
        }
        private void text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox8.Text == "") || (textBox9.Text == "") || (textBox10.Text == "") || (textBox11.Text == "") || (textBox12.Text == "")) MessageBox.Show("Вы не заполнили нужные поля!");
            else
            {
                conn.Open();
                Double kg = 0.1;
                int gr = 32;
                string sqlQuery = string.Format("UPDATE produkt SET [Nazw]=@Nazw,[kl]=@kl,[bel]=@bel,[giri]=@giri,[ugl]=@ugl WHERE ID=" + idProd);
                OleDbCommand command = new OleDbCommand(sqlQuery, conn);
                command.CommandType = CommandType.Text;
                command.CommandText = sqlQuery;
                command.Connection = conn;
                command.Parameters.AddWithValue("@Nazw", textBox8.Text);
                command.Parameters.AddWithValue("@kl", textBox9.Text);
                command.Parameters.AddWithValue("@bel", textBox10.Text);
                command.Parameters.AddWithValue("@giri", textBox11.Text);
                command.Parameters.AddWithValue("@ugl", textBox12.Text);


                if (command.ExecuteNonQuery() == 0) { MessageBox.Show("Редактирование не удалось!"); }
                else { MessageBox.Show("Редактирование прошло успешно!"); }
                command.Dispose();
                conn.Close();
                Neu();
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            textB_KeyUp(sender,e,textBox1.Text.ToString());
        }

        private void textBox7_KeyUp(object sender, KeyEventArgs e)
        {
            textB_KeyUp(sender, e, textBox7.Text.ToString());
        }     
               private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Поиск продукта";
                textBox1.ForeColor = Color.Gray;
            }
           }

        private void textBox1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Поиск продукта")
            {
                textBox1.Text = null;
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox7_Leave_1(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "Поиск продукта";
                textBox7.ForeColor = Color.Gray;
            }
        }

        private void textBox7_Click_1(object sender, EventArgs e)
        {
            if (textBox7.Text == "Поиск продукта")
            {
                textBox7.Text = null;
                textBox7.ForeColor = Color.Black;
            }
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.SetSelected(listBox2.SelectedIndex, true);
            удалитьToolStripMenuItem_Click(sender, e);
        }

       

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int y = e.Y / listBox2.ItemHeight;
                if (y < listBox2.Items.Count)
                {
                    listBox2.SelectedIndex = listBox2.TopIndex + y;
                }
            }
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            conn.Open();
            string produkt = listBox2.SelectedItem.ToString();
            OleDbCommand command = new OleDbCommand("SELECT Nazw,kl,bel,giri,ugl,ID FROM produkt WHERE [Nazw]=@Nazw AND [BenutzerID]=@BenutzerID", conn);
            command.Parameters.AddWithValue("@Nazw", produkt);
            command.Parameters.AddWithValue("@BenutzerID", id);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                textBox8.Text = Convert.ToString(reader[0]);
                textBox9.Text = Convert.ToString(reader[1]);
                textBox10.Text = Convert.ToString(reader[2]);
                textBox11.Text = Convert.ToString(reader[3]);
                textBox12.Text = Convert.ToString(reader[4]);
                idProd = Convert.ToInt32(reader[5]);
            }
            conn.Close();
            tabControl1.SelectedIndex = 1;
            
        }
    }
}
