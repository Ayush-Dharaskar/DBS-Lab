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
    public partial class Forgot_pass : Form
    {
        User user; 
        public Forgot_pass(User u1)
        {
            InitializeComponent();
            user = u1;
        }
        string dobIn;
        string pwdIn;
        private void Forgot_pass_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dobIn = dateTimePicker1.Value.ToString();
            dobIn = dobIn.Substring(0, 10);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pwdIn = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dobIn == user.DOB)
            {
                user.password = pwdIn;
                MessageBox.Show("Password Changed Successfully", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Wrong DOB", "ERROR", MessageBoxButtons.OK);
            }
        }


    }
}
