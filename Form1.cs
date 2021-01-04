using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gottabeokay
{
    public partial class Form1 : Form
    {
        public int h = 0;
        public int z = 0;
        int[] masyvas = new int[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string Kintamasis;
                int d = 0;
                Kintamasis = textBox1.Text;
                while (h < 10)
                {
                    masyvas[h] = Convert.ToInt32(Kintamasis.Substring(d, 1));
                    d++;
                    h++;
                }
                int skaicius = 0;
                for (int i = 0; i < 10; i++) { skaicius = skaicius + masyvas[i]; }
                textBox2.Text = Convert.ToString(skaicius);
                button2.BringToFront();

            }
            catch (System.FormatException) { MessageBox.Show("Klaida"); }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Įveskite dar " + (10 - h) + " skaitmenis."); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            h = 0; z = 0; textBox1.Text = ""; textBox2.Text = ""; button2.SendToBack();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            int eglutesDyd = 0;
            try
            {
                eglutesDyd = Convert.ToInt32(textBox3.Text);
            }
            catch (System.FormatException) { MessageBox.Show("Klaidinga reikšmė"); }
            for (int a = 0; a < eglutesDyd + 1; a++) { for (int b = 0; b < a; b++) { richTextBox1.Text += "* "; } richTextBox1.Text += "\n"; }
            richTextBox1.SelectAll(); richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

   
    }
}