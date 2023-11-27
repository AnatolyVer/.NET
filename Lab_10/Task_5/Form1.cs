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

namespace Task_5
{
    public partial class Form1 : Form
    {
        private int min = 0, sec = 0;
        
        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                button1.Text = "Stop";
                timer1.Start();
            }
            else
            {
                button1.Text = "Start";
                timer1.Stop();
            }
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            sec++;
            if (sec == 60)
            {
                sec = 0;
                min++;
            }

            if (sec % 5 == 0)
            {
                Random random = new Random();
                Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                button1.ForeColor = randomColor;
            }

            label1.Text = string.Format("{0:00}:{1:00}", min,sec);
        }
    }
}