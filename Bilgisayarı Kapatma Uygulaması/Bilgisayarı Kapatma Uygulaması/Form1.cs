using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bilgisayarı_Kapatma_Uygulaması
{
    public partial class Form1 : Form
    {
        int saniye, dakika, saat;
        int sonuc;
        Point farkMesafe = new Point();
        public Form1()
        {
            InitializeComponent();
            timer1.Stop();

            FormKoselendirme();
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                DateTime.Now.Hour + 1, DateTime.Now.Minute, DateTime.Now.Second);
        }

        private void FormKoselendirme()
        {
            FormBorderStyle = FormBorderStyle.None;

            Rectangle kenarlar = new Rectangle(0, 0, Width, Height);

            int koseradius = 10;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(kenarlar.X, kenarlar.Y, koseradius, koseradius, 180, 90);
            path.AddArc(kenarlar.X + kenarlar.Width - koseradius, kenarlar.Y, koseradius, koseradius, 270, 90);
            path.AddArc(kenarlar.X + kenarlar.Width - koseradius, kenarlar.Y + kenarlar.Height - koseradius, koseradius, koseradius, 0, 90);
            path.AddArc(kenarlar.X, kenarlar.Y + kenarlar.Height - koseradius, koseradius, koseradius, 90, 90);

            Region = new Region(path);  // Alan oluştur path şeklinde
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxFromSaniye.Text == "")
            {
                textBoxFromSaniye.Text = "0";
            }
            if (textBoxFromDakika.Text == "")
            {
                textBoxFromDakika.Text = "0";
            }
            if (textBoxFromSaat.Text == "")
            {
                textBoxFromSaat.Text = "0";
            }
            saniye = Convert.ToInt32(textBoxFromSaniye.Text);
            dakika = Convert.ToInt32(textBoxFromDakika.Text);
            saat = Convert.ToInt32(textBoxFromSaat.Text);

            sonuc = saat * 3600 + dakika * 60 + saniye;
            if (sonuc <= 10)
            {
                DialogResult diyalogSonuc = MessageBox.Show("It will shut down after 10 seconds. Do you approve ?",
                    "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (diyalogSonuc == DialogResult.Yes)
                {
                    TimerBaslat();
                }
            }
            else TimerBaslat();

        }
        void TimerBaslat()
        {
            System.Diagnostics.Process.Start("shutdown", ($"/s /f /t {sonuc}"));
            timer1.Start();
            button_SetToThis.BackColor = Color.Gray;
            button_SetTimer.BackColor = Color.AntiqueWhite;
            progressBar1.Enabled = true;
            button_SetTimer.Enabled = false;
            button_SetToThis.Enabled = false;
            progressBar1.Minimum = 0;
        }
        // Bilgi Mesaj Kutusu
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Created by Ertuğrul Baran.\nContact: ert.baran@gmail.com"
                , "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxFromSaat.SelectAll();
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxFromDakika.SelectAll();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxFromSaniye.SelectAll();
        }

        // İptal Butonu İşlemleri
        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/a");

            timer1.Stop();
            timer2.Stop();
            progressBar1.Enabled = false;
            progressBar1.Value = 0;

            button_SetTimer.Enabled = true;
            button_SetToThis.Enabled = true;

            button_SetToThis.BackColor = Color.Black;
            button_SetTimer.BackColor = Color.Navy;

            textBoxFromSaniye.Text = "0";
            textBoxFromDakika.Text = "3";
            textBoxFromSaat.Text = "0";

            labelKalanSaniye.Text = "0";
            labelKalanDakika.Text = "0";
            labelKalanSaat.Text = "0";
        }

        // Kapatma tuşu işlemleri
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                DialogResult result = new DialogResult();
                result = MessageBox.Show("The Shutdown Timer still running.\n" +
                    "Your computer will be shut down in the specified time.\n\n" +
                    "Do you want to stop the timer? ", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("shutdown", "/a");
                    Close();
                }
                else
                    Close();
            }
            else
                Close();
        }

        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            notifyIcon1.ShowBalloonTip(3);
        }

        private void tus_sinirlama(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Btn_SetThis_Click(object sender, EventArgs e)
        {
            button_SetToThis.BackColor = Color.Gray;
            button_SetTimer.BackColor = Color.AntiqueWhite;
            button_SetToThis.Enabled = false;
            button_SetTimer.Enabled = false;


            timer1.Start();
            progressBar1.Enabled = true;
            progressBar1.Minimum = 0;

            DateTime gecerliZaman = DateTime.Now;
            DateTime istenenZaman = dateTimePicker1.Value;

            if (gecerliZaman < istenenZaman)
            {
                sonuc = Convert.ToInt32((istenenZaman - gecerliZaman).TotalSeconds);
            }
            else
            {
                sonuc = Convert.ToInt32((gecerliZaman - istenenZaman).TotalSeconds);
            }

            System.Diagnostics.Process.Start("shutdown", ($"/s /f /t {sonuc}"));
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            farkMesafe = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = new Point(Cursor.Position.X - farkMesafe.X, Cursor.Position.Y - farkMesafe.Y);
            }
        }

        // ProgressBar için Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sonuc == 0)
            {
                timer1.Stop();
            }
            --sonuc;
            progressBar1.Maximum = sonuc;
            progressBar1.Value++;

            saat = sonuc / 3600;
            dakika = (sonuc / 60) % 60;
            saniye = sonuc % 60;

            labelKalanSaniye.Text = saniye.ToString();
            labelKalanDakika.Text = dakika.ToString();
            labelKalanSaat.Text = saat.ToString();
        }
    }
}
// ert.baran@gmail.com