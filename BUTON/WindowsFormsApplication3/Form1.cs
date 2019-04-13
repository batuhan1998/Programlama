using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X + 5, 0);
            if (button1.Location.X == 700)
            {
                timer1.Stop();
                button1.Location = new Point(0,20);
                timer2.Start();
            }
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X + 5, 20);
            if (button1.Location.X == 700)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X - 5, 20);
            if (button1.Location.X == -70)
            {
                timer3.Stop();
                button1.Location = new Point(700,0);
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X - 5, 0);
            if (button1.Location.X == -70)
            {
                timer4.Stop();
                button1.Location = new Point(-50, 0);
            }
        }
    }
}
