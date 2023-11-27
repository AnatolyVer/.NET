using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mouseEnter_1(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X - 20, button1.Location.Y);
        }

        private void mouseExit_1(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X + 20, button1.Location.Y);
        }

        private void mouseEnter_2(object sender, EventArgs e)
        {
            button2.Location = new Point(button2.Location.X - 20, button2.Location.Y);
        }

        private void mouseExit_2(object sender, EventArgs e)
        {
            button2.Location = new Point(button2.Location.X + 20, button2.Location.Y);
        }

        private void mouseEnter_3(object sender, EventArgs e)
        {
            button3.Location = new Point(button3.Location.X - 20, button3.Location.Y);
        }

        private void mouseExit_3(object sender, EventArgs e)
        {
            button3.Location = new Point(button3.Location.X + 20, button3.Location.Y);
        }
    }
}
