﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X - 20, label1.Location.Y);
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            label2.Location = new Point(label2.Location.X - 20, label2.Location.Y);
        }
        private void label3_DoubleClick(object sender, EventArgs e)
        {
            label3.Location = new Point(label3.Location.X - 20, label3.Location.Y);
        }

    }
}
