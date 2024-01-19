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
    public partial class Dashboard : Form
    {
        public Dashboard(User user)
        {
            InitializeComponent();
            label5.Text = user.name;
            label6.Text = user.balance.ToString();
            label7.Text = user.lastAccessed;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
