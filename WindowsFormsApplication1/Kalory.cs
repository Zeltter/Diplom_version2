using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Kalory : Form
    {
       // string wag;
        int customerId;
        int i = 1;
        int d = 10;
        int j = 1;
        int k = 10;
        const int length = 255;
        Control[] masKL = new  Control[length];
       
        Control[] masProd = new Control[length];
        
        Control[] masDel1 = new Control[length];

        Control[] masZeit = new Control[length];

        Control[] masAktiv = new Control[length];

        Control[] masDel2 = new Control[length];
        
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database.mdb");
        // String str = "tcp:zelter.database.windows.net,1433;Initial Catalog = sss2; Persist Security Info=False;User ID = { zelter }; Password={Qwerty123    }; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";
        // SqlDataReader

        public Kalory(int id)
        {
          //  wag = wes;
            InitializeComponent();
            customerId = id;

        }

        private void калькуляторКалорийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Erste erste = new Erste(customerId);
            erste.Show();
            this.Close();
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Statistik stat = new Statistik(customerId);
            stat.Show();
            this.Close();
        }

        private void Kalory_Load(object sender, EventArgs e)
        {
            //comboBox1.SelectedIndex = "Грибы";
            //ComboBoxAktiv.SelectedIndex = 0;
            textBox2.Text = "Поиск продукта";//подсказка
            textBox2.ForeColor = Color.Gray;
            Abmeldung ab = new Abmeldung();
            ab.Close();
            conn.Open();
            OleDbCommand com = new OleDbCommand("SELECT KG FROM Statistik WHERE Kod=" + customerId.ToString() + " ORDER BY Dat DESC", conn);//+ customerId.ToString()
            OleDbDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                textBox1.Text = read[0].ToString();
                break;
            }
            conn.Close();
            
           
            // TODO: This line of code loads data into the 'databaseDataSet1.group_prodact' table. You can move, or remove it, as needed.
            this.group_prodactTableAdapter.Fill(this.databaseDataSet1.group_prodact);
            // TODO: This line of code loads data into the 'databaseDataSet1.Aktivitat_art' table. You can move, or remove it, as needed.
            this.aktivitat_artTableAdapter.Fill(this.databaseDataSet1.Aktivitat_art);
            // TODO: This line of code loads data into the 'databaseDataSet.group_prodact' table. You can move, or remove it, as needed.
            this.group_prodactTableAdapter1.Fill(this.databaseDataSet.group_prodact);
            // TODO: This line of code loads data into the 'databaseDataSet.produkt' table. You can move, or remove it, as needed.

            this.produktTableAdapter.Fill(this.databaseDataSet.produkt);
            //textBox1.Text = wag;
        }

        

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                listBox1.Items.Clear();
                int str = comboBox1.SelectedIndex + 1;
                conn.Open();
                OleDbCommand command = new OleDbCommand("SELECT Nazw FROM produkt WHERE [group]=" + str.ToString()+" AND (BenutzerID=-1 OR BenutzerID="+ customerId+")", conn);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add(reader.GetValue(0));
                }
                conn.Close();
            }
        }
        private bool isFounded(String[] sabstr,int findetIndex)
        {
            Char[] firstCharIntString = textBox2.Text.ToCharArray();
            String stringFirstCharUpper = "";
            stringFirstCharUpper += Char.ToUpper(firstCharIntString[0]);
            for (int m=1;m<firstCharIntString.Length;m++)
            {
                stringFirstCharUpper += firstCharIntString[m];
            }
            for(int m = 0; m < sabstr.Length; m++)
            {
                if (sabstr[m].Contains(stringFirstCharUpper)|| sabstr[m].Contains(textBox2.Text))
                {
                    listBox1.SetSelected(findetIndex,true);
                    return true;
                }
                
            }
            return false;
        }
        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
                    
            
            int index = listBox1.FindString(textBox2.Text);
            if (index != -1)
            {
                listBox1.SetSelected(index, true);
            }
            else
            {
                if (listBox1.Items.Count != 0)
                {
                    if (textBox2.Text != "")
                    {
                        listBox1.SetSelected(0, true);
                        Char derimiter = ' ';
                        String strValue;
                        String[] subString;
                        for (int m = 0; m < listBox1.Items.Count; m++)
                        {
                            strValue = listBox1.Items[m].ToString();
                            subString = strValue.Split(derimiter);
                            if (isFounded(subString, m))
                            {
                                break;
                            }
                        }
                    }
                }
            }

        }

      

        private void ComboBoxAktiv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxAktiv.SelectedIndex != -1)
            {
                listBox3.Items.Clear();
                int st = ComboBoxAktiv.SelectedIndex + 1;
                conn.Open();

                OleDbCommand command = new OleDbCommand("SELECT Aktivitat FROM Aktivitat WHERE [ansicht]=" + st.ToString(), conn);

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox3.Items.Add(reader.GetValue(0));
                }
                conn.Close();
            }
           
                //OleDbCommand command = conn.CreateCommand();

                //command.CommandText = "SELECT Nazw FROM produkt WHERE [group]=str ";

        }

      

       

       

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                int y=e.Y/listBox1.ItemHeight;
                if(y<listBox1.Items.Count)
                {
                    listBox1.SelectedIndex = listBox1.TopIndex + y;
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex!=-1)
            {
                masKL[i] = new TextBox() { Name = i.ToString(), Location = new Point(comboBox1.Location.X+273, comboBox1.Location.Y+170 + d), Size = new System.Drawing.Size(50, 27) };
                masKL[i].KeyPress += (text_KeyPress);
                this.Controls.Add(masKL[i]);
                masProd[i] = new TextBox() { Name = i.ToString(), Location = new Point(comboBox1.Location.X, comboBox1.Location.Y + 170 + d), Size = new System.Drawing.Size(273, 27), Text = listBox1.SelectedItem.ToString(), ReadOnly=true };
                this.Controls.Add(masProd[i]);
                masDel1[i] = new Button() { Name = i.ToString(), Location = new Point(comboBox1.Location.X+330, comboBox1.Location.Y + 170 + d), Size = new System.Drawing.Size(20, 20), Text ="X" };
                masDel1[i].Click += new EventHandler(Del1_Click);
                this.Controls.Add(masDel1[i]);
                i++;
                d = d + 27;
            }
        }

        private void listBox3_DoubleClick(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex != -1)
            {
                masZeit[j] = new TextBox() { Name = j.ToString(), Location = new Point(ComboBoxAktiv.Location.X, ComboBoxAktiv.Location.Y + 210 + k), Size = new System.Drawing.Size(50, 27), Anchor = listBox3.Anchor };
                masZeit[j].KeyPress += (text_KeyPress);
                this.Controls.Add(masZeit[j]);
                masAktiv[j] = new TextBox() { Name = j.ToString(), Location = new Point(ComboBoxAktiv.Location.X + 50, ComboBoxAktiv.Location.Y + 210 + k), Size = new System.Drawing.Size(313, 27), Text = listBox3.SelectedItem.ToString(), ReadOnly = true, Anchor = listBox3.Anchor };
                this.Controls.Add(masAktiv[j]);
                masDel2[j] = new Button() { Name = j.ToString(), Location = new Point(ComboBoxAktiv.Location.X -30, ComboBoxAktiv.Location.Y + 210 + k), Size = new System.Drawing.Size(20, 20), Text = "X",Anchor = listBox3.Anchor };
                masDel2[j].Click += new EventHandler(Del2_Click);
                this.Controls.Add(masDel2[j]);
                j++;
                k = k + 27;

            }
        }

        

        private void подробнееToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string produkt = listBox1.SelectedItem.ToString();
            Information inf = new Information(produkt);
            inf.Show();
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help hl = new Help();
            hl.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Nachtrag trag = new Nachtrag(customerId);
            trag.Show();
        }
        private void text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Del1_Click(object sender, EventArgs e)
        {
            string f = (sender as Button).Name;
            int el=Convert.ToInt32( f );
            
           
            
            
                for (int p = el; p <i-1; p++)
                {
                masKL[p].Text =Convert.ToString(masKL[p+1].Text);
                masProd[p].Text = Convert.ToString(masProd[p+1].Text);                                  
            }
            
                this.Controls.Remove(masKL[i-1]);
                this.Controls.Remove(masProd[i-1]);
                this.Controls.Remove(masDel1[i-1]);
                if(d>10)d = d - 27;
                i--;
           
           
        }
        private void Del2_Click(object sender, EventArgs e)
        {
            string f = (sender as Button).Name;
            int el = Convert.ToInt32(f);




            for (int p = el; p < j - 1; p++)
            {
                masZeit[p].Text = Convert.ToString(masZeit[p + 1].Text);
                masAktiv[p].Text = Convert.ToString(masAktiv[p + 1].Text);
            }

            this.Controls.Remove(masZeit[j - 1]);
            this.Controls.Remove(masAktiv[j - 1]);
            this.Controls.Remove(masDel2[j - 1]);
            if (k > 10) k = k - 27;
            j--;


        }
        private void Rechnung_Click(object sender, EventArgs e)
        {
            float rezKL;
            float rezKL2;
            float ergebnis1 = 0;
            float ergebnis2 = 0;
            int prowerka1=0;
            int prowerka2 = 0;
            for (int f = 1; f < i; f++)
            {
                if (masKL[f].Text == "")
                {
                    prowerka1++;
                }
            }
            for (int f = 1; f < j; f++)
            {
                if (masZeit[f].Text == "")
                {
                    prowerka2++;
                }
            }
            if ((textBox1.Text == "") || (prowerka1 > 0) || (prowerka2 > 0)) MessageBox.Show("Вы не заполнили нужные поля!");
            else
            {
                for (int f = 1; f < i; f++)
                {
                    float KL = 0;
                    conn.Open();
                    OleDbCommand command = new OleDbCommand("SELECT KL FROM produkt WHERE [Nazw]=@Nazw AND (BenutzerID=-1 OR BenutzerID=@BenutzerID)", conn);
                    command.Parameters.AddWithValue("@Nazw", masProd[f].Text.ToString());
                    command.Parameters.AddWithValue("@BenutzerID", customerId);
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        KL = Convert.ToInt32(reader[0]);
                    }
                    conn.Close();
                    rezKL = (KL / 100) * Convert.ToInt32(masKL[f].Text);
                    ergebnis1 = ergebnis1 + rezKL;
                }
                int o = i;
                for (int f = 0; f <= i; f++)
                {
                    this.Controls.Remove(masKL[o]);
                    this.Controls.Remove(masProd[o]);
                    this.Controls.Remove(masDel1[o]);
                    o--;
                }
                i = 1;
                d = 10;

                for (int f = 1; f < j; f++)
                {
                    float KL = 0;
                    conn.Open();
                    OleDbCommand command = new OleDbCommand("SELECT kl FROM Aktivitat WHERE [Aktivitat]=@Aktivitat ", conn);
                    command.Parameters.AddWithValue("@Aktivitat", masAktiv[f].Text.ToString());
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        KL = Convert.ToInt32(reader[0]);
                    }
                    conn.Close();
                    rezKL2 = ((KL / 60) * Convert.ToInt32(masZeit[f].Text)) * Convert.ToInt32(textBox1.Text);
                    ergebnis2 = ergebnis2 + rezKL2;
                }
                int l = j;
                for (int f = 0; f <= j; f++)
                {
                    this.Controls.Remove(masZeit[l]);
                    this.Controls.Remove(masAktiv[l]);
                    this.Controls.Remove(masDel2[l]);
                    l--;
                }
                j = 1;
                k = 10;
                MessageBox.Show("Вы добавили: " + ergebnis1 + " калории." + "\n Вы сожгли: " + ergebnis2 + " калории.");
                DialogResult result = MessageBox.Show("Вы хотите добавить этот результат для статистики?", "Warning", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    conn.Open();

                    OleDbCommand comm = new OleDbCommand("SELECT Dat FROM Statistik WHERE Dat=@Dat AND Kod=@id" , conn);
                    int gibt = 0;
                    comm.Parameters.Add("@Dat", OleDbType.Date).Value = dateTimePicker1.Value.ToShortDateString();
                    comm.Parameters.AddWithValue("@id", customerId);
                    OleDbDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        gibt++;
                    }
                    conn.Close();
                    if (gibt > 0)
                    {
                        DialogResult res = MessageBox.Show("Запись за эту дату уже существует!" + "\nХотите заменить ее на новую?", "Warning", MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                        {
                            conn.Open();
                            Double kg = 0.1;
                            int gr = 32;
                            string sqlQuer = string.Format("UPDATE Statistik SET [KG]=@KG,[KL]=@KL,[KLm]=@KLm WHERE Kod=@Kod AND Dat=@Dat");
                            OleDbCommand com = new OleDbCommand(sqlQuer, conn);
                            com.CommandType = CommandType.Text;
                            com.CommandText = sqlQuer;
                            com.Connection = conn;
                            
                            com.Parameters.AddWithValue("@KG", textBox1.Text);
                            com.Parameters.AddWithValue("@KL", ergebnis1);
                            com.Parameters.AddWithValue("@KLm", ergebnis2);
                            
                            com.Parameters.AddWithValue("@Kod", customerId);
                            com.Parameters.Add("@Dat", OleDbType.Date).Value = dateTimePicker1.Value.ToShortDateString();
                            if (com.ExecuteNonQuery() == 0) { MessageBox.Show("Редактирование не удалось!"); }
                            else { MessageBox.Show("Редактирование прошло успешно!"); }
                            com.Dispose();
                            conn.Close();
                        }
                    }
                    else
                    {
                        conn.Open();
                        DateTime time = dateTimePicker1.Value;
                        string sqlQuery = string.Format("INSERT INTO Statistik (KG,KL,Kod,Dat,KLm) VALUES (@KG,@KL,@Kod,@Dat,@KLm)");
                        OleDbCommand command = new OleDbCommand(sqlQuery, conn);
                        command.CommandType = CommandType.Text;
                        command.CommandText = sqlQuery;
                        command.Connection = conn;
                        command.Parameters.AddWithValue("@KG", textBox1.Text);
                        command.Parameters.AddWithValue("@KL", ergebnis1);
                        command.Parameters.AddWithValue("@Kod", customerId);
                        command.Parameters.Add("@Dat", OleDbType.Date).Value = dateTimePicker1.Value.ToShortDateString();
                        command.Parameters.AddWithValue("@KLm", ergebnis2);
                        if (command.ExecuteNonQuery() == 0) { MessageBox.Show("Запись не добавлена!"); }
                        else { MessageBox.Show("Запись  добавлена!"); }
                        command.Dispose();
                        conn.Close();
                    }
                }
            }
        }

        

        private void Kalory_FormClosed(object sender, FormClosedEventArgs e)
        {
            
           // if (e.CloseReason == CloseReason.UserClosing)
              //  Application.Exit();
           
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Поиск продукта";//подсказка
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Поиск продукта")
            {
                textBox2.Text = null;
                textBox2.ForeColor = Color.Black;
            }
        }
        
    }


}
