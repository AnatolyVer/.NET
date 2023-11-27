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


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(toolStripButton1.Text);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(toolStripButton2.Text);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(toolStripButton3.Text);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(toolStripButton4.Text);
        }
    }
}
