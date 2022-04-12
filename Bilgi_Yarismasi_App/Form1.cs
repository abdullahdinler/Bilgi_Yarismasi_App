using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int soru_no = 0, puan = 0;
        private int sayac = 30;
        private int sayac2 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = button1.Text;
            button1.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;


            if (label6.Text == label7.Text)
            {
                puan = puan + 10;
                label5.Text = puan.ToString();
                green.Visible = true;
                button1.BackColor = Color.Green;
            }
            else
            {
                red.Visible = true;
                button1.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = button2.Text;
            button1.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
            if (label6.Text == label7.Text)
            {
                puan = puan + 10;
                label5.Text = puan.ToString();
                green.Visible = true;
                button2.BackColor = Color.Green;
            }
            else
            {
                red.Visible = true;
                button2.BackColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label7.Text = button5.Text;
            button1.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
            if (label6.Text == label7.Text)
            {
                puan = puan + 10;
                label5.Text = puan.ToString();
                green.Visible = true;
                button5.BackColor = Color.Green;
            }
            else
            {
                red.Visible = true;
                button5.BackColor = Color.Red;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            sayac2++;
            label8.Text = sayac.ToString("00");
            progressBar1.Value = sayac2;
            if (sayac2 == 30)
            {
                timer1.Stop();
                red.Visible = true;
            }
            if (sayac == 00)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button5.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = true;
                timer1.Stop();
                sayac = 30;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label7.Text = button3.Text;
            button1.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = false;
            button3.Enabled = false;
            if (label6.Text == label7.Text)
            {
                puan = puan + 10;
                label5.Text = puan.ToString();
                green.Visible = true;
                button3.BackColor = Color.Green;
            }
            else
            {
                red.Visible = true;
                button3.BackColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            soru_no++;
            sayac = 30;
            sayac2 = 0;
            timer1.Start();
            label4.Text = soru_no.ToString();
            label7.Text = button1.Text;
            button1.Enabled = true;
            button2.Enabled = true;
            button5.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            button4.Text = "Siradaki";
            red.Visible = false;
            green.Visible = false;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button5.BackColor = Color.White;




            if (soru_no == 1)
            {
                richTextBox1.Text = "İbn Haldun'un bir eserinin adı da olan 'mukaddime' kelimesi ne anlama gelir?";
                button1.Text = "Çeviri";
                button2.Text = "Ön söz";
                button5.Text = "Kaynakça";
                button3.Text = "Dipnot";
                label6.Text = "Ön söz";
            }

            if (soru_no == 2)
            {
                richTextBox1.Text = "Hangi edebiyatçı TBMM'de milletvekilliği yapmamıştır?";
                button1.Text = "Yahya Kemal Beyatlı";
                button2.Text = "Sait Faik Abasıyanık";
                button5.Text = "Halide Edip Adıvar";
                button3.Text = "Mehmet Akif Ersoy";
                label6.Text = "Sait Faik Abasıyanık";
            }

            if (soru_no == 3)
            {
                richTextBox1.Text = "İkiz kardeş olan Şota ve Arçil adlı Gürcü milli futbolcular, Türkiye'de hangi takımın formasını giymiştir?";
                button1.Text = "Galatasaray";
                button2.Text = "Trabzonspor";
                button5.Text = "Beşiktaş";
                button3.Text = "Fenerbahçe";
                label6.Text = "Trabzonspor";
            }

            if (soru_no == 4)
            {
                richTextBox1.Text = "Hangisi 'yazı karakteri' anlamındadır?";
                button1.Text = "Font";
                button2.Text = "Küpür";
                button5.Text = "Ons";
                button3.Text = "Karat";
                label6.Text = "Font";
            }

            if (soru_no == 5)
            {
                richTextBox1.Text = "Hangisi Türkçe sözlüklerde tanımı olan bir kelime değildir?";
                button1.Text = "Galoş";
                button2.Text = "Gamboç";
                button5.Text = "Gayzer";
                button3.Text = "Gayda";
                label6.Text = "Gamboç";
            }

            if (soru_no == 6)
            {
                richTextBox1.Text = "1959'da New York'taki bir şampiyonaya erkek kılığında katılan Rena Kanogoki, hangi alanda altın madalya kazanmış ve kadın olduğu anlaşılınca madalyasını iade etmek zorunda kalmıştır?";
                button1.Text = "Satranç";
                button2.Text = "Judo";
                button5.Text = "Eskrim";
                button3.Text = "Okçuluk";
                label6.Text = "Judo";
            }

            if (soru_no == 7)
            {
                richTextBox1.Text = "Cumhuriyet ilan edildikten sonra hangi ülkenin temsilcisi Türkiye'ye diğerlerinden daha önce diplomatik ziyarette bulunmuş ve Mustafa Kemal tarafından kabul edilmiştir?";
                button1.Text = "Afganistan";
                button2.Text = "Fransa";
                button5.Text = "ABD";
                button3.Text = "Birleşik Krallık";
                label6.Text = "Fransa";
            }

            if (soru_no == 8)
            {
                richTextBox1.Text = "Fransa'dan trene binip deniz altındaki Manş Tüneli'nden geçen biri hangi ülkeye ulaşır?";
                button1.Text = "Birleşik Krallık";
                button2.Text = "Almanya";
                button5.Text = "İzlanda";
                button3.Text = "Portekiz";
                label6.Text = "Birleşik Krallık";
            }

            if (soru_no == 9)
            {
                richTextBox1.Text = "Gırnata, Belensiye ve İşbıliye günümüzde hangi ülkenin sınırları içinde yer alan şehirlerin eski adlarıdır?";
                button1.Text = "Türkiye";
                button2.Text = "Bulgaristan";
                button5.Text = "İspanya";
                button3.Text = "Yunanistan";
                label6.Text = "İspanya";
            }

            if (soru_no == 10)
            {
                richTextBox1.Text = "Oyun Sonuna Gelindi.";
                button1.Visible = false;
                button2.Visible = false;
                button5.Visible = false;
                button3.Visible = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button5.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button4.Text = "Son";
                MessageBox.Show("Tebrikler oyunu bitirdiniz. Skorunuz: " + puan);

            }

        }
    }
}
