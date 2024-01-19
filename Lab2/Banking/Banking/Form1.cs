using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String pwdIn;
        String useIn;

        DateTime dob = new DateTime(2004, 10, 10);
        User u1 = new User("Ayush","test","01-01-2004",20000000,"01-01-2024");
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            useIn = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pwdIn = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pwdIn == u1.pwd())
            {
                Dashboard dash1 = new Dashboard(u1);
                dash1.Show();
            
            }
            else
            {
                MessageBox.Show("Wrong password");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_pass fpass1 = new Forgot_pass(u1);
            fpass1.Show();
        }

    }
}
