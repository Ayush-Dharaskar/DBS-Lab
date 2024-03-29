﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));

            t.Start();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public static void ThreadProc()
        {
            // Window Help = new Window();
            //Application.Run(new Window(Help);    

            Application.Run(new Form1());
        }
        private void saveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            String fname = saveFileDialog1.FileName;
            StreamWriter sw = new StreamWriter(fname);
            sw.Write(richTextBox1.Text);
            sw.Flush();
            sw.Close();
        }

        private void openToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Title = "Open";
            od.ShowDialog();
            string name = od.FileName;
            StreamReader sr = new StreamReader(name);
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();

        }

        private void fontToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = richTextBox1.SelectionFont;
       
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
               
            }
        }

        private void colorToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ColorDialog cd= new ColorDialog();
            cd.Color = richTextBox1.SelectionColor;
            cd.ShowDialog();
            richTextBox1.SelectionColor =cd.Color;

        }

        private void cutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Cut();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if(richTextBox1.SelectionLength>0)
            {
                richTextBox1.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                richTextBox1.Paste();
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            richTextBox1.SelectAll();
        }
    }
}
