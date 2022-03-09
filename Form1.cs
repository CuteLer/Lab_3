using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public double f(double x)
        {
            if(radioButton1.Checked)
                return Math.Sinh(x);
            else
                if (radioButton2.Checked)
                    return Math.Pow(x,2);
                else
                    return Math.Exp(x);
        }

        public double func(double x, double m)
        {
            if (m > (-1) && m < x)
                return Math.Sin(5 * f(x) + 3 * m * Math.Abs(f(x)));
            else
                if (x > m)
                    return Math.Cos(3 * f(x) + 5 * m * Math.Abs(f(x)));
                else
                    if (x == m)
                        return Math.Pow(f(x) + m, 2);
            return 0;
        }

        double x, m;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Text = "Результат работы программы ст. Михайловской" + Environment.NewLine + Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                    throw new Exception("Вы не ввели значение.");
                x = Convert.ToDouble(textBox1.Text);
                m = Convert.ToDouble(textBox2.Text);
                textBox3.Text += "При Х = " + x;
                textBox3.Text += Environment.NewLine + "При M = " + m;
                textBox3.Text += Environment.NewLine + "U = " + func(x, m) + Environment.NewLine;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }
    }
}
