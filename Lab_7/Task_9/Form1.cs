using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mouse1_enter(object sender, EventArgs e)
        {
            textBox1.Location = new Point(textBox1.Location.X - 2, textBox1.Location.Y);
        }

        private void mouse1_exit(object sender, EventArgs e)
        {
            textBox1.Location = new Point(textBox1.Location.X + 2, textBox1.Location.Y);
        }

        private void mouse2_enter(object sender, EventArgs e)
        {
            textBox2.Location = new Point(textBox2.Location.X - 2, textBox2.Location.Y);
        }

        private void mouse2_exit(object sender, EventArgs e)
        {
            textBox2.Location = new Point(textBox2.Location.X + 2, textBox2.Location.Y);
        }

        private void mouse3_enter(object sender, EventArgs e)
        {
            textBox3.Location = new Point(textBox3.Location.X - 2, textBox3.Location.Y);
        }

        private void mouse3_exit(object sender, EventArgs e)
        {
            textBox3.Location = new Point(textBox3.Location.X + 2, textBox3.Location.Y);
        }
    }
}
