using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
namespace WindowsFormsApplication1
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "")) MessageBox.Show("Вы не заполнили нужные поля!");
            else
            {
                try
                {
                    string attachFile = null;
                    string thema = textBox1.Text.ToString();
                    string email = textBox2.Text.ToString();
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("mykursprogramm@yandex.ru");
                    mail.To.Add(new MailAddress("shan_shi@mail.ru"));
                    mail.Subject = thema;
                    mail.Body = email;
                    if (!string.IsNullOrEmpty(attachFile))
                        mail.Attachments.Add(new Attachment(attachFile));
                    SmtpClient client = new SmtpClient();
                    string smtpServer = "smtp.yandex.ru";
                    client.Host = smtpServer;
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential("mykursprogramm@yandex.ru", "myprogramm");
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.Send(mail);
                    mail.Dispose();
                    MessageBox.Show("Сообщение успешно отправлено!");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                catch (SmtpException)
                {
                    MessageBox.Show("Ошибка!");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string commandText = @"C:\Users\Zelter\Desktop\KursProjekt\WindowsFormsApplication1\bin\Debug\inf.doc";
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = commandText;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(159, 153);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(119, 113);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
