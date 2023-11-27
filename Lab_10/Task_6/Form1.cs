using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Task_6
{
    public partial class Form1 : Form
    {
        private int min = 0, sec = 0;
        
        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            sec++;
            if (sec == 60)
            {
                min++;
                sec = 0;
            }
            label1.Text = string.Format("{0:00}:{1:00}", min,sec);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                if (numericUpDown1.Text == "0"  && numericUpDown2.Text == "0") return;
                timer1.Interval = int.Parse(numericUpDown1.Text) * 60 * 1000 + int.Parse(numericUpDown2.Text) * 1000;
                timer1.Start();
                button1.Text = "Stop";
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
            }
            else
            {
                timer1.Stop();
                button1.Text = "Start";
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
            }
        }
    }
}