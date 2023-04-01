using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace çeveri_projesi
{
    public partial class Form3 : Form
    {
        private object texBox2;
        private object texBox1;

        public Form3()
        {
            InitializeComponent();
        }

        public void Form3_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox2.Text;
            
            if (metin == "Algoritma" | metin  == "algoritma" | metin == "ALGORİTMA")
            {
                textBox2.Text = "Agoritma";
            }

            else if (metin == "Uygulama" | metin == "uygulama" | metin == "UYGULAMA")
            {
                textBox2.Text = "App";
            }

            else if (metin == "Bulut" | metin == "bulut" | metin ==  "BULUT")
            {
                textBox2.Text = "Cloud";
            }

            else if (metin == "Bilgisayar" | metin == "bilgisayar" | metin == "BİLGİSAYAR")
            {
                textBox2.Text = "Computer";
            }

            else if (metin == "Yazılım" | metin == "yazılım" | metin == "YAZILIM")
            {
                textBox2.Text = "Software";
            }

            else if (metin == "Donanım" | metin == "donanım" | metin == "DONANIM")
            {
                textBox2.Text = "Hardware";
            }

            else if (metin == "İndirmek" | metin == "indirmek" | metin == "İNDİRMEK")
            {
                textBox2.Text = "Downland";
            }

            else if (metin == "Yüklemek" | metin == "yüklemek" | metin == "YÜKLEMEK")
            {
                textBox2.Text = "Install";
            }

            else if (metin == "Şifre" | metin == "şifre" | metin == "ŞİFRE")
            {
                textBox2.Text = "Password";
            }

            else if (metin == "Ekran görüntüsü" | metin == "ekran görüntüsü" | metin == "ekran görüntüsü" | metin == "EKRAN GÖRÜNTÜSÜ")
            {
                textBox2.Text = "Screenshot";
            }

            else if (metin == "Dizüstü bilgisayar" | metin == "dizüstü bilgisayar" | metin == "dizüstü bilgisayar" | metin == "DİZÜSTÜ BİLGİSAYAR" | metin == "Notebook" | metin == "notebook" | metin == "NOTEBOOK")
            {
                textBox2.Text = "Laptop";
            }

            else if (metin == "Fare" | metin == "fare" | metin == "FARE")
            {
                textBox2.Text = "Mouse";
            }

            else if (metin == "Klavye" | metin == "klavye" | metin == "KLAVYE")
            {
                textBox2.Text = "Keyboard";
            }

            else
            {
                textBox2.Clear();
                MessageBox.Show("Kelime Bulunamdı!");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
