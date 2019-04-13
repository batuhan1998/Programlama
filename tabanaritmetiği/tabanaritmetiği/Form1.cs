using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabanaritmetiği
{
    public partial class Form1 : Form
    {
        int taban;

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Coral;
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            long b, x;

string s = "";

try

{

x =int.Parse(textBox1.Text);

taban = int.Parse(textBox2.Text);

}

catch

{

MessageBox.Show("Hatalı sayı");

return;

}

while(x >= taban)

{

b = x % taban;

x = x / taban;


if(b > 9)

    {

s = (char)(55 + b) + s;

    }

else

{

s = b + s;

}


}

if(x > 9) 

s = (char)(55 + x) + s;

else

s = x + s;

label3.Text =s ;


}

        
        }
    }

