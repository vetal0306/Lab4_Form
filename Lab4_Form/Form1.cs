using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a = 0.08, b = 1.08, x;

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            x = Convert.ToDouble(textBox1.Text);
            double m = x - 1;
            double x1 = (a + b); //a+b
            double x2 = Math.Pow(x1, 2) + m; //(a+b)^2 + m
            double x3 = 1 + Math.Pow(x, a) + Math.Pow(b, a); // (1 + x ^ a + b ^ a)
            double y = x2 / x3;
            label6.Text = Convert.ToString(y);            
        }
    }
}
