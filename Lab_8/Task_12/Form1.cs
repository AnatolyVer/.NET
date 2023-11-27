using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_12
{
    public partial class Form1 : Form
    {
        private int time;
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time += timer1.Interval;
            if (time == timer1.Interval)
            {
                this.Width = 400;
                this.Height = 300;
            }
            else if (time == timer1.Interval * 2)
            {
                this.Width = 800;
                this.Height = 450;
                time = 0;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                timer1.Interval = (int)numericUpDown1.Value;
                timer1.Start();
                this.Text = timer1.Interval.ToString();
                button1.Text = "Stop";
            }
            else
            {
                timer1.Stop();
                this.Text = "Form1";
                this.Width = 800;
                this.Height = 450;
                time = 0;
                button1.Text = "Start";
            }
        }
    }
}
