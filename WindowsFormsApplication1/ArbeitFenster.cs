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
    public partial class ArbeitFenster : Form
    {
        Kalory kl = new Kalory(7);
        Erste er = new Erste(7);
        Help hl = new Help();
        Rezept rez = new Rezept();
        Nachtrag nt = new Nachtrag(7);
        Registrierung reg = new Registrierung();
        Statistik stat = new Statistik(7);
        Einkauf kauf = new Einkauf();
        public ArbeitFenster()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
           
        }

        private void ArbeitFenster_Resize(object sender, EventArgs e)
        {
            Kalory reg = new Kalory(7);
            int q, w;
            reg.MdiParent = this;
            //reg.Show();
            q = this.Size.Height - 150;
            w = this.Size.Width - 150;
            reg.Height = q;
            reg.Width = w;
        }

        private void ArbeitFenster_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.White;
                    break;
                }
            }

            Abmeldung ab = new Abmeldung();
            
            ab.Show();
           
            
           

        }

       

        private void ArbeitFenster_ResizeBegin(object sender, EventArgs e)
        {
            


        }

        private void ArbeitFenster_ResizeEnd(object sender, EventArgs e)
        {
            
        }

       
        private void button1_Click_2(object sender, EventArgs e)
        {
            rez.MdiParent = this;

            rez.Show();
            stat.Hide();
            nt.Hide();
            hl.Hide();
            er.Hide();
            kauf.Hide();
            kl.Hide();

            //rez.MdiParent = this;
            
            //rez.Show();
            
            { rez.Location = new Point(button1.Location.X + 70, button1.Location.Y); }

            int q, w;
            rez.MdiParent = this;

            q = this.Size.Height - 60;
            w = this.Size.Width - 90;
            rez.Height = q;
            rez.Width = w;

            button1.Image = Properties.Resources.BludoZ;
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            kauf.Hide();
            nt.Hide();
            stat.Hide();
            er.Hide();
            kl.Hide();
            rez.Hide();
            hl.MdiParent = this;
            hl.Show();
            { hl.Location = new Point(button1.Location.X + 70, button1.Location.Y); }

            int q, w;
            hl.MdiParent = this;

            q = this.Size.Height - 60;
            w = this.Size.Width - 90;
            hl.Height = q;
            hl.Width = w;
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            kauf.Hide();
            nt.Hide();
            hl.Hide();
            er.Hide();
            kl.Hide();
            rez.Hide();
            stat.MdiParent = this;
            stat.Show();
            
            { stat.Location = new Point(button1.Location.X + 70, button1.Location.Y); }

            int q, w;
            stat.MdiParent = this;

            q = this.Size.Height - 60;
            w = this.Size.Width - 90;
            stat.Height = q;
            stat.Width = w;
           
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
          
            er.MdiParent = this;

            kl.Hide();
            stat.Hide();
            nt.Hide();
            hl.Hide();
            kauf.Hide();
            rez.Hide();
            er.Show();
            { er.Location = new Point(button1.Location.X + 70, button1.Location.Y); }

            int q, w;
            er.MdiParent = this;

            q = this.Size.Height - 60;
            w = this.Size.Width - 120;
            er.Height = q;
            er.Width = w;
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            stat.Hide();
            nt.Hide();
            hl.Hide();
            er.Hide();
            kl.Hide();
            rez.Hide();
            kauf.MdiParent = this;
            kauf.Show();
            { kauf.Location = new Point(button1.Location.X + 70, button1.Location.Y); }

            int q, w;
            kauf.MdiParent = this;

            q = this.Size.Height - 60;
            w = this.Size.Width - 110;
            kauf.Height = q;
            kauf.Width = w;

           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            stat.Hide();
            nt.Hide();
            hl.Hide();
            er.Hide();
            kauf.Hide();
            rez.Hide();
            kl.MdiParent = this;
            kl.Show();
            { kl.Location = new Point(button1.Location.X + 70, button1.Location.Y); }

            int q, w;
            kl.MdiParent = this;

            q = this.Size.Height - 60;
            w = this.Size.Width - 90;
            kl.Height = q;
            kl.Width = w;
           
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Image = Properties.Resources.BludoZ;
            pictureBox1.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.BludoN;
            pictureBox1.Visible = false;
        }
       
        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Image = Properties.Resources.WesZ;
            pictureBox1.Visible = true;
            

        }
        private void button2_MouseLeave_1(object sender, EventArgs e)
        {
            button2.Image = Properties.Resources.WesN;
            pictureBox1.Visible = false;

        }
        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.Image = Properties.Resources.KalkZ;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Image = Properties.Resources.KalkN;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Image = Properties.Resources.KorsN;

        }
        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.Image = Properties.Resources.KorsZ;
        }
        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Image = Properties.Resources.GrafN;

        }
        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.Image = Properties.Resources.GrafZ;
        }
        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.Image = Properties.Resources.HelpN;

        }
        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            button6.Image = Properties.Resources.HelpZ;
        }
        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.Image = Properties.Resources.SettingsN;

        }
        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            button7.Image = Properties.Resources.SettingsZ;
        }
    }
}
