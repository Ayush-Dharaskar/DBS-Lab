using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        string input;
        string op1;
        char op;
        string op2;
        double ans;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input = input + "1";
            textBox1.Text += input;

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input = input + "2";
            textBox1.Text += input;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input = input + "7";
            textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input = input + "9";
            textBox1.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input = input + "0";
            textBox1.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            op1 = string.Empty;
            input = string.Empty;
            op2 = string.Empty;
            
            textBox1.Text = string.Empty;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            op1 = input;
            op = '-';
            input = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            op1 = input;
            op = '*';
            input = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double num1,num2;
            op2 = input;
            double.TryParse(op1,out num1);
            double.TryParse(op2, out num2);
            if (op == '+')
            {
                ans = num1 + num2;
                input = ans.ToString();
                textBox1.Text = ans.ToString();
            }
            else if (op == '-')
            {
                ans = num1 - num2;
                input = ans.ToString();
                textBox1.Text = ans.ToString();
            }
            else if (op == '*')
            {
                ans = num1 * num2;
                input = ans.ToString();
                textBox1.Text = ans.ToString();
            }
            else if (op == '/')
            {
                if (num2 != 0)
                {
                    ans = num1 / num2;
                    input = ans.ToString();
                    textBox1.Text = ans.ToString();
                }
                else
                {
                    textBox1.Text = "DIV/ZERO!";
                    input = string.Empty;
                }
            }
            
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input = input + "3";
            textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input = input + "4";
            textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input = input + "5";
            textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input = input + "6";
            textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input = input + "8";
            textBox1.Text += input;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            op1 = input;
            op = '+';
            input = string.Empty;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            op1 = input;
            op = '/';
            input = string.Empty;
        }
    }
}
