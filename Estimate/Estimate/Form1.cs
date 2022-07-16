using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estimation;

namespace Estimate
{
    public partial class Form1 : Form
    {
        Class1 cal=new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = cal.Add(int.Parse(textBox1.Text),int.Parse(textBox2.Text));
            textBox3.Text = x.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int x = cal.Sub(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = x.ToString();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            int x = cal.Mul(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = x.ToString();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            int x = cal.Div(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = x.ToString();
        }

        private void dollar_Click(object sender, EventArgs e)
        {
            int x = cal.dollar(int.Parse(textBox1.Text));
            textBox3.Text= x.ToString();
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            int x = cal.pound(int.Parse(textBox1.Text));
            textBox3.Text = x.ToString();
        }

        private void button1_Click_5(object sender, EventArgs e)
        {
            int x = cal.euro(int.Parse(textBox1.Text));
            textBox3.Text = x.ToString();

        }
    }
}
