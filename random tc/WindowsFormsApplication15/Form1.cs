using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication15
{
    public partial class Form1 : Form
    {
        Random salla = new Random();
        string TC;
        UInt64[] dizi = new UInt64[12];
        UInt64 bol;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            UInt64 kontrol, kontrol2;
            TC = salla.Next(100000000,1000000000).ToString();
            bol = 1;
            for (int i = 9; i >= 1; i--)
            {
                dizi[i] =Convert.ToUInt64(TC) / bol % 10;
                listBox1.Items.Add(dizi[i]);
                bol = bol * 10;
            }
            kontrol = (dizi[1] + dizi[3] + dizi[5] + dizi[7] + dizi[9]) * 7 - (dizi[2] + dizi[4] + dizi[6] + dizi[8]);
            kontrol = kontrol % 10;
            dizi[10] = kontrol;
            kontrol2 = dizi[1] + dizi[2] + dizi[3] + dizi[4] + dizi[5] + dizi[6] + dizi[7] + dizi[8] + dizi[9] + dizi[10];
            kontrol2 = kontrol2 % 10;
            dizi[11] = kontrol2;
            listBox1.Items.Add(dizi[10]);
            listBox1.Items.Add(dizi[11]);
            label1.Text = TC+dizi[10]+dizi[11];
            label2.Text = kontrol.ToString();
            label3.Text = kontrol2.ToString();
            listBox2.Items.Add(label1.Text);
        }
    }
}
