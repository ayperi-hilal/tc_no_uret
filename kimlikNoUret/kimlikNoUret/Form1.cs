using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kimlikNoUret
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_uret_Click(object sender, EventArgs e)
        {
            temizle();
            int[] rakamlar = new int[11];

            Random ran= new Random();

            for (int i = 0; i < 9; i++)
            {
                rakamlar[i] = ran.Next(0, 9);
            }

            if (rakamlar[0] == 0)
            {
                rakamlar[0] = ran.Next(0, 9);
            }
            else
            {
                int onuncuhane = ((rakamlar[0] + rakamlar[2] + rakamlar[4] + rakamlar[6] + rakamlar[8]) * 7) - (rakamlar[1] + rakamlar[3] + rakamlar[5] + rakamlar[7]);
                int ondanbolum = onuncuhane % 10;
                rakamlar[9] = ondanbolum;
                int onbirincihane = rakamlar[0] + rakamlar[1] + rakamlar[2] + rakamlar[3] + rakamlar[4] + rakamlar[5] + rakamlar[6] + rakamlar[7] + rakamlar[8] + rakamlar[9];
                int modu = onbirincihane % 10;
                
                rakamlar[10] = modu;
            }
            foreach (int a in rakamlar)
            {
                listBox1.Items.Add(a);
                textBox1.Text += a.ToString();
            }



        }

        public void temizle()
        {
            textBox1.Text = "";
            listBox1.Items.Clear();
        }
    }
}
