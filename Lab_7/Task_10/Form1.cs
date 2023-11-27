using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mouse_enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Location = new Point(textBox.Location.X - 20, textBox.Location.Y);
        }

        private void mouse_exit(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Location = new Point(textBox.Location.X + 20, textBox.Location.Y);
        }
    }
}
