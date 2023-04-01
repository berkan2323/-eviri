using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace çeveri_projesi
{
    public partial class Form2 : Form
    {
        public object TextBox1 { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox2.Text;
            if (metin == "Algorithm" | metin == "Algorthm")
            {
                textBox1.Text = "Algorthm";
            }

            else if (metin == "App" | metin == "app")
            {
                textBox1.Text = "Uygulama";
            }

            else if (metin == "Cloud" | metin == "Cloud")
            {
                textBox1.Text = "Bulut";
            }

            else if (metin == "Computer" | metin == "Computer")
            {
                textBox1.Text = "Bilgisayar";
            }

            else if (metin == "Software" | metin == "Software")
            {
                textBox1.Text = "Yazılım";
            }

            else if (metin == "Hardware" | metin == "Hardware")
            {
                textBox1.Text = "Donanım";
            }

            else if (metin == "Download" | metin == "Downloand")
            {
                textBox1.Text = "İndirmek";
            }

            else if (metin == "Install" | metin == "Install")
            {
                textBox1.Text = "Yüklemek";
            }

            else if (metin == "Password" | metin == "Password")
            {
                textBox1.Text = "Şifre";
            }

            else if (metin == "Screenshot" | metin == "Screenshot")
            {
                textBox1.Text = "Ekran Görüntüsü";
            }

            else if (metin == "Laptop" | metin == "Laptop" | metin == "Notebook" | metin == "notebook")
            {
                textBox1.Text = "Dizüstü bigisayar";
            }

            else if (metin == "Mous" | metin == "Mous")
            {
                textBox1.Text = "Fare";
            }

            else if (metin == "keyboard" | metin == "Keyboard")
            {
                textBox1.Text = "Klıavye";
            }

            else
            {
                textBox1.Clear();
                MessageBox.Show("Kelime bulunamadı");
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
