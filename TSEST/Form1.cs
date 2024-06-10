using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "환영합니다, " + textBox1.Text + "님.";
            label3.Visible = true;
            //MessageBox.Show("Hello, " + textBox1.Text);
            // MessageBox.Show("Welcome to winformers");

            string number1 = "123";
            string number2 = "123";
            MessageBox.Show(( int.Parse(number1) + int.Parse(number2) ).ToString());
            string test1 = "456";
            int test3 = 123;
            int result;
            bool success = int.TryParse(test1, out result);//parse : 스트링받아야함
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox2.Text);
            int n2 = int.Parse(textBox3.Text);
            label4.Text = "값 : " + (n1+n2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox2.Text);
            int n2 = int.Parse(textBox3.Text);
            label4.Text = "값 : "+ (n1 - n2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox2.Text);
            int n2 = int.Parse(textBox3.Text);
            label4.Text = "값 : " + (n1 * n2).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox2.Text);
            int n2 = int.Parse(textBox3.Text);
            label4.Text = "값 : " + (n1 / n2).ToString();
        }
    }
}
