using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox1_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
            
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float R = float.Parse(textBox1.Text);
            double v = 4.0 / 3.0 * Math.PI * Math.Pow(R, 3) / 1000.0;
            double s = 4 * Math.PI * Math.Pow(R, 2) / 10000;
            label2.Text = String.Format("Об\'єм кулі: {0:0.00} л", v);
            label3.Text = String.Format("Площа сфери: {0:0.00} м2", s);
        }

    }
}