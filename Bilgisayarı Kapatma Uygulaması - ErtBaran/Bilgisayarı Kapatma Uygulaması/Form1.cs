using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgisayarı_Kapatma_Uygulaması
{
    public partial class Form1 : Form
    {
        int saniye, dakika; 
        int sonuc;
        int ilerleme_toplam = 0;            // ProgressBar için
        int ilerleme_artma_miktari = 0;     // ProgressBar için

        public Form1()
        {
            InitializeComponent();
            timer1.Stop();

            // ____________________Form köşe kıvrımları___________________
            this.FormBorderStyle = FormBorderStyle.None;    // Form kenarlarını kaldır

            Rectangle kenarlar = new Rectangle(0, 0, Width, Height);    //Dikdörtgen oluştur

            int koseradius = 10;    // radius belirle

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(kenarlar.X, kenarlar.Y, koseradius, koseradius, 180, 90);
            path.AddArc(kenarlar.X + kenarlar.Width - koseradius, kenarlar.Y, koseradius, koseradius, 270, 90);
            path.AddArc(kenarlar.X + kenarlar.Width - koseradius, kenarlar.Y + kenarlar.Height - koseradius, koseradius, koseradius, 0, 90);
            path.AddArc(kenarlar.X, kenarlar.Y + kenarlar.Height - koseradius, koseradius, koseradius, 90, 90);

            Region = new Region(path);  // Alan oluştur path şeklinde

            // ________________Köşe kıvrımları sonu___________________
        }

        private void button1_Click(object sender, EventArgs e)
        {
            linkLabel1.Focus();
            button1.Enabled = false;
            button1.BackColor = Color.AntiqueWhite; // buton1 arkaplanı
            progressBar1.Enabled = true;
            timer1.Start();
            if (textBox1.Text == "")    // kutu boş ise 0 kabul edilsin.
            {
                textBox1.Text = "0";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }

            saniye = Convert.ToInt32(textBox1.Text);
            dakika = Convert.ToInt32(textBox2.Text);

            dakika *= 60;   // Toplam saniyeyi hesaplamak için
            sonuc = dakika + saniye;

            System.Diagnostics.Process.Start("shutdown", ($"/s /f /t {sonuc}"));    // Bilgisayarı Kapatma parametreleri
            // ProgressBar hesapları
            dakika /= 60;
            ilerleme_toplam = ((dakika * 60) + saniye) * 10;
            ilerleme_artma_miktari = ilerleme_toplam / (saniye + dakika * 60);
            progressBar1.Maximum = ilerleme_toplam;
        }

        // Bilgi Mesaj Kutusu
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Ertuğrul Baran tarafından hazırlanmıştır.\nİletişim: ert.baran@gmail.com"
                , "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.SelectAll();   // textBox'a tıklayınca verinin tamamını seçer
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.SelectAll();
        }

        // İptal Butonu İşlemleri
        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/a"); // Kapatmayı Durdurmak İçin

            timer1.Stop();
            progressBar1.Enabled = false;
            progressBar1.Value = 0;

            button1.Enabled = true;
            button1.BackColor = Color.Black;
            textBox1.Text = "0";
            textBox2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
        }

        // Kapatma tuşu işlemleri
        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                DialogResult result = new DialogResult();   // MessageBox'tan gelen cevabı kullanmak için
                result = MessageBox.Show("Kapatma zamanlayıcısı devam ediyor.\nBelirtilen sürede bilgisayarınız kapatılacak.\n\nZamanlayıcıyı durdurmak istiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("shutdown", "/a");
                    this.Close();   // Mesaj Kutusunda Evet seçilirse zamanlayıcıyı durdur ve uygulamayı kapat
                }
                else
                    this.Close();   // Mesaj Kutusunda Hayır seçilirse uygulamayı kapat (zamanlayıcı devam eder)
            }
            else
                this.Close();   // Zamanlayıcı kapalı ise direk uygulamayı kapat
        }

        // Ekranı küçültme butonu
        private void button4_Click(object sender, EventArgs e)
        {
            // Thread.Sleep(3000);  // 3 saniye beklet || Sadece örnek kod
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.ShowBalloonTip(3);  //Ekranı küçültünce bildirim paneli çıksın. 3 saniye görünür
        }

        //TextBox içerisinde sadece sayı girilmesi için
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        // Form'u hareket ettirmek için saydam bir panel oluşturduk
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int formx = Location.X;
                int formy = Location.Y;
                
                int farex = Cursor.Position.X;
                int farey = Cursor.Position.Y;

                int konuma = farex - (farex - formx);
                int konumb = farey - (farey - formy);
                Point konum = new Point();
                konum.X = farex;
                konum.Y = farey;
                   
                Location = konum;
            }
        }

        // ProgressBar için Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            dakika = sonuc / 60;
            saniye = sonuc % 60;
            if (dakika == 0 && saniye == 0)
            {
                timer1.Stop();
            }
            --sonuc;
            progressBar1.Value += ilerleme_artma_miktari;

            label3.Text = saniye.ToString();    // Kalan süreyi yazdırıyoruz
            label4.Text = dakika.ToString();
        }
    }
}
// ert.baran@gmail.com