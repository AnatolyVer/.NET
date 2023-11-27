using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mouse1_up(object sender, MouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                label1.Location = new Point(label1.Location.X + 20, label1.Location.Y);
            }
        }

        private void mouse1_down(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                label1.Location = new Point(label1.Location.X - 20, label1.Location.Y);
            }
        }

        private void mouse2_up(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                label2.Location = new Point(label2.Location.X + 20, label2.Location.Y);
            }
        }

        private void mouse2_down(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                label2.Location = new Point(label2.Location.X - 20, label2.Location.Y);
            }
        }

        private void mouse3_up(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                label3.Location = new Point(label3.Location.X + 20, label3.Location.Y);
            }
        }

        private void mouse3_down(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                label3.Location = new Point(label3.Location.X - 20, label3.Location.Y);
            }
        }
    }
}
