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
    public partial class Statistik : Form
    {   int customerId;
      //  OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database.mdb");
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\Database.mdb");
        public Statistik(int id)
        {
            InitializeComponent();
            customerId = id;
        }
        private void калькуляторВесаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Erste erste = new Erste(customerId);
            erste.Show();
            this.Close();
        }

        private void калькуляторКалорийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Kalory kalory = new Kalory(customerId);
            kalory.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {        
            conn.Open();
            chart1.Series["Калории добавили"].Points.Clear();
            chart1.Series["Калории сожгли"].Points.Clear();
            chart1.Series["Вес"].Points.Clear();
            

            if (comboBox1.SelectedIndex == 0)
            {
                if (radioButton1.Checked)
                {
                    DateTime today = DateTime.Today;
                    DateTime weekAgo = today.AddDays(-7);
                    OleDbCommand com = new OleDbCommand("SELECT Dat,KG FROM Statistik WHERE Kod=" + customerId.ToString() + " ORDER BY Dat DESC", conn);//+ customerId.ToString()
                    OleDbDataReader read = com.ExecuteReader();
                    read.Read();
                    DateTime currentTimeIter = Convert.ToDateTime(read[0]);
                    while (currentTimeIter.CompareTo(weekAgo) == 1)
                    {
                        chart1.Series["Вес"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[1]));
                        read.Read();
                        currentTimeIter = Convert.ToDateTime(read[0]);
                    }
                }
                   else if (radioButton2.Checked)
                    {
                       
                        DateTime monthAgo = DateTime.Today.AddMonths(-1);
                        OleDbCommand com = new OleDbCommand("SELECT Dat,KG FROM Statistik WHERE Kod=" + customerId.ToString() + " ORDER BY Dat DESC", conn);//+ customerId.ToString()
                        OleDbDataReader read = com.ExecuteReader();
                        read.Read();
                        DateTime currentTimeIter = Convert.ToDateTime(read[0]);
                        while (currentTimeIter.CompareTo(monthAgo) == 1)
                        {
                            chart1.Series["Вес"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[1]));
                            read.Read();
                            currentTimeIter = Convert.ToDateTime(read[0]);
                        }
                    }
                else if (radioButton3.Checked)
                {

                    DateTime yearAgo = DateTime.Today.AddYears(-1);
                    OleDbCommand com = new OleDbCommand("SELECT Dat,KG FROM Statistik WHERE Kod=" + customerId.ToString() + " ORDER BY Dat DESC", conn);//+ customerId.ToString()
                    OleDbDataReader read = com.ExecuteReader();
                    read.Read();
                    DateTime currentTimeIter = Convert.ToDateTime(read[0]);
                    while (currentTimeIter.CompareTo(yearAgo) == 1)
                    {
                        chart1.Series["Вес"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[1]));
                        read.Read();
                        currentTimeIter = Convert.ToDateTime(read[0]);
                    }

                }
                 
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (radioButton1.Checked)
                {
                    DateTime today = DateTime.Today;
                    DateTime weekAgo = today.AddDays(-7);
                    OleDbCommand com = new OleDbCommand("SELECT Dat,KL,KLm FROM Statistik WHERE Kod=" + customerId.ToString() + " ORDER BY Dat DESC", conn);//+ customerId.ToString()
                    OleDbDataReader read = com.ExecuteReader();
                    read.Read();
                    DateTime currentTimeIter = Convert.ToDateTime(read[0]);
                    while (currentTimeIter.CompareTo(weekAgo) == 1)
                    {
                        chart1.Series["Калории добавили"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[1]));
                        chart1.Series["Калории сожгли"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[2]));
                        read.Read();
                        currentTimeIter = Convert.ToDateTime(read[0]);
                    }
                }
                else if (radioButton2.Checked)
                {
                    DateTime today = DateTime.Today;
                    DateTime monthAgo = today.AddMonths(-1);
                    OleDbCommand com = new OleDbCommand("SELECT Dat,KL,KLm FROM Statistik WHERE Kod=" + customerId.ToString() + " ORDER BY Dat DESC", conn);//+ customerId.ToString()
                    OleDbDataReader read = com.ExecuteReader();
                    read.Read();
                    DateTime currentTimeIter = Convert.ToDateTime(read[0]);
                    while (currentTimeIter.CompareTo(monthAgo) == 1)
                    {
                        chart1.Series["Калории добавили"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[1]));
                        chart1.Series["Калории сожгли"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[2]));
                        read.Read();
                        currentTimeIter = Convert.ToDateTime(read[0]);
                    }
                }
                else if (radioButton3.Checked)
                {
                    DateTime today = DateTime.Today;
                    DateTime yearAgo = today.AddYears(-1);
                    OleDbCommand com = new OleDbCommand("SELECT Dat,KL,KLm FROM Statistik WHERE Kod=" + customerId.ToString() + " ORDER BY Dat DESC", conn);//+ customerId.ToString()
                    OleDbDataReader read = com.ExecuteReader();
                    read.Read();
                    DateTime currentTimeIter = Convert.ToDateTime(read[0]);
                    while (currentTimeIter.CompareTo(yearAgo) == 1)
                    {
                        chart1.Series["Калории добавили"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[1]));
                        chart1.Series["Калории сожгли"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[2]));
                        read.Read();
                        currentTimeIter = Convert.ToDateTime(read[0]);
                    }
                }

               
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                if (radioButton1.Checked)
                {
                    DateTime today = DateTime.Today;
                    DateTime weekAgo = today.AddDays(-7);
                    OleDbCommand com = new OleDbCommand("SELECT Dat,KL,KG,KLm FROM Statistik WHERE Kod=" + customerId.ToString() + " ORDER BY Dat DESC", conn);//+ customerId.ToString()
                    OleDbDataReader read = com.ExecuteReader();
                    read.Read();
                    DateTime currentTimeIter = Convert.ToDateTime(read[0]);
                    while (currentTimeIter.CompareTo(weekAgo) == 1)
                    {
                        chart1.Series["Вес"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[2]));
                        chart1.Series["Калории добавили"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[1]));
                        chart1.Series["Калории сожгли"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[3]));
                        read.Read();
                        currentTimeIter = Convert.ToDateTime(read[0]);
                    }
                }
                else if (radioButton2.Checked)
                {
                    DateTime today = DateTime.Today;
                    DateTime monthAgo = today.AddMonths(-1);
                    OleDbCommand com = new OleDbCommand("SELECT Dat,KL,KG,KLm FROM Statistik WHERE Kod=" + customerId.ToString() + " ORDER BY Dat DESC", conn);//+ customerId.ToString()
                    OleDbDataReader read = com.ExecuteReader();
                    read.Read();
                    DateTime currentTimeIter = Convert.ToDateTime(read[0]);
                    while (currentTimeIter.CompareTo(monthAgo) == 1)
                    {
                        chart1.Series["Вес"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[2]));
                        chart1.Series["Калории добавили"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[1]));
                        chart1.Series["Калории сожгли"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[3]));
                        read.Read();
                        currentTimeIter = Convert.ToDateTime(read[0]);
                    }
                }
                else if (radioButton3.Checked)
                {
                    DateTime today = DateTime.Today;
                    DateTime yearAgo = today.AddYears(-1);
                    OleDbCommand com = new OleDbCommand("SELECT Dat,KL,KG,KLm FROM Statistik WHERE Kod=" + customerId.ToString() + " ORDER BY Dat DESC", conn);//+ customerId.ToString()
                    OleDbDataReader read = com.ExecuteReader();
                    read.Read();
                    DateTime currentTimeIter = Convert.ToDateTime(read[0]);
                    while (currentTimeIter.CompareTo(yearAgo) == 1)
                    {
                        chart1.Series["Вес"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[2]));
                        chart1.Series["Калории добавили"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[1]));
                        chart1.Series["Калории сожгли"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[3]));
                        read.Read();
                        currentTimeIter = Convert.ToDateTime(read[0]);
                    }
                }
            }
          
            conn.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex != -1)
            {
                chart1.Series["Калории добавили"].Points.Clear();
                chart1.Series["Калории сожгли"].Points.Clear();
                chart1.Series["Вес"].Points.Clear();
                conn.Open();
                DateTime weekAgo = DateTime.Today.AddDays(-7);
                OleDbCommand com = new OleDbCommand("SELECT Dat,KL,KG,KLm FROM Statistik WHERE Kod=" + customerId.ToString() + " ORDER BY Dat DESC", conn);
                OleDbDataReader read = com.ExecuteReader();
                read.Read();
                DateTime currentTimeIter = Convert.ToDateTime(read[0]);
                while (currentTimeIter.CompareTo(weekAgo) == 1)
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        chart1.Series["Вес"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[2]));
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        chart1.Series["Калории добавили"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[1]));
                        chart1.Series["Калории сожгли"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[2]));
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        chart1.Series["Вес"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[2]));
                        chart1.Series["Калории добавили"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[1]));
                        chart1.Series["Калории сожгли"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[3]));
                    }
                        read.Read();
                    currentTimeIter = Convert.ToDateTime(read[0]);
                }
                conn.Close();
            }
           // else MessageBox.Show("Выберите категорию");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                chart1.Series["Калории добавили"].Points.Clear();
                chart1.Series["Калории сожгли"].Points.Clear();
                chart1.Series["Вес"].Points.Clear();
                conn.Open();
                DateTime monthAgo = DateTime.Today.AddMonths(-1);
                OleDbCommand com = new OleDbCommand("SELECT Dat,KL,KG,KLm FROM Statistik WHERE Kod=" + customerId.ToString() + " ORDER BY Dat DESC", conn);
                OleDbDataReader read = com.ExecuteReader();
                read.Read();
                DateTime currentTimeIter = Convert.ToDateTime(read[0]);
                while (currentTimeIter.CompareTo(monthAgo) == 1)
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        chart1.Series["Вес"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[2]));
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        chart1.Series["Калории добавили"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[1]));
                        chart1.Series["Калории сожгли"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[3]));
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        chart1.Series["Вес"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[2]));
                        chart1.Series["Калории добавили"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[1]));
                        chart1.Series["Калории сожгли"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[3]));
                    }
                    read.Read();
                    currentTimeIter = Convert.ToDateTime(read[0]);
                }
                conn.Close();
            }
           /// else MessageBox.Show("Выберите категорию");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                chart1.Series["Калории добавили"].Points.Clear();
                chart1.Series["Калории сожгли"].Points.Clear();
                chart1.Series["Вес"].Points.Clear();
                conn.Open();
                DateTime yearAgo = DateTime.Today.AddYears(-1);
                OleDbCommand com = new OleDbCommand("SELECT Dat,KL,KG,KLm FROM Statistik WHERE Kod=" + customerId.ToString() + " ORDER BY Dat DESC", conn);
                OleDbDataReader read = com.ExecuteReader();
                read.Read();
                DateTime currentTimeIter = Convert.ToDateTime(read[0]);
                while (currentTimeIter.CompareTo(yearAgo) == 1)
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        chart1.Series["Вес"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[2]));
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        chart1.Series["Калории добавили"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[1]));
                        chart1.Series["Калории сожгли"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[3]));
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        chart1.Series["Вес"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[2]));
                        chart1.Series["Калории добавили"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[1]));
                        chart1.Series["Калории сожгли"].Points.AddXY(read[0].ToString(), Convert.ToDouble(read[3]));
                    }
                    read.Read();
                    currentTimeIter = Convert.ToDateTime(read[0]);
                }
                conn.Close();
            }
           // else MessageBox.Show("Выберите категорию");
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help hl = new Help();
            hl.Show();
        }

        private void Statistik_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
