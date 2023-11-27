using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label_DoubleClick(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.Location = new Point(label.Location.X - 20, label.Location.Y);
        }
    }
}
