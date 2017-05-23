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
using System.Data.SqlClient;




namespace WindowsFormsApplication1
{
    public partial class Registrierung : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database.mdb");
        public Registrierung()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) MessageBox.Show("Вы не указали ваш пол");
            else
            {
                if ((textBox1.Text.Equals("")) || (textBox2.Text.Equals("")) || (textBox3.Text.Equals(""))) MessageBox.Show("Необходимые поля не заполнены!");
                else
                {
                    if (Convert.ToString(textBox1.Text).Length < 3) MessageBox.Show("Логин не должен быть короче 3 символов!");
                    else
                    {
                        conn.Open();

                        OleDbCommand comm = new OleDbCommand("SELECT Login FROM Leute WHERE Login='" + textBox1.Text.ToString() + "'", conn);
                        int gibt = 0;
                        OleDbDataReader reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            gibt++;
                        }
                        conn.Close();
                        if (gibt > 0) MessageBox.Show("Такой логин уже используется другим пользователем");
                        else
                        {
                            if (String.Compare(textBox2.Text.ToString(), textBox3.Text.ToString()) != 0)
                            {
                                MessageBox.Show("Пароли не совпадают");
                                textBox2.Clear();
                                textBox3.Clear();
                            }
                            else
                            {
                                if (Convert.ToString(textBox2.Text).Length < 6) MessageBox.Show("Пароль не должен быть короче 6-ти символов!");
                                else
                                {
                                    conn.Open();
                                    string sqlQuery = string.Format("INSERT INTO Leute (Login,Parol,Pol) VALUES (" + textBox1.Text + "," + textBox3.Text + "," + comboBox1.Text + ")");
                                    OleDbCommand command = new OleDbCommand(sqlQuery, conn);
                                    command.CommandType = CommandType.Text;
                                    command.CommandText = sqlQuery;
                                    command.Connection = conn;
                                    command.Parameters.Add("", OleDbType.WChar).Value = textBox1.Text;
                                    command.Parameters.Add("", OleDbType.WChar).Value = textBox3.Text;
                                    command.Parameters.Add("", OleDbType.WChar).Value = comboBox1.Text;
                                    if (command.ExecuteNonQuery() == 0) { MessageBox.Show("Пользователь не добавлен"); }
                                    else { MessageBox.Show("Пользователь добавлен!"); }
                                    command.Dispose();
                                    conn.Close();
                                    this.Close();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar)||char.IsPunctuation(e.KeyChar)) { e.Handled = true; 
        }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = Properties.Resources.Frau;
            }
            else pictureBox1.Image = Properties.Resources.man1;
        }
    }
}
