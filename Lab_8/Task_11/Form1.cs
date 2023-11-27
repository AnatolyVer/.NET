using System;
using System.Windows.Forms;

namespace Task_11
{
    public partial class Form1 : Form
    {
        private int time;
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 2000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time += timer1.Interval;
            if (time == timer1.Interval * 2)
            {
                this.Width = 400;
                this.Height = 300;
            }
            else if (time == timer1.Interval * 4)
            {
                this.Width = 800;
                this.Height = 450;
                time = 0;
            }
        }
    }
}