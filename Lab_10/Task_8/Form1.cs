using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = (DateTime.Now.Day).ToString();
            int number = 0;
            foreach (var ch in textBox1.Text)
            {
                if (ch == '0') number++;
            }


            toolStripStatusLabel2.Text = number.ToString();
        }

        private bool isFormVisible = true;
        
        private void ShowMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            isFormVisible = true;
        }

        private void HideMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
            isFormVisible = false;
        }
    }
}
