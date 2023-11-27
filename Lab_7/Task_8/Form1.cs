﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mouse_up(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                label.Location = new Point(label.Location.X + 2, label.Location.Y);
            }
        }

        private void mouse_down(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                label.Location = new Point(label.Location.X - 2, label.Location.Y);
            }
        }
    }
}
