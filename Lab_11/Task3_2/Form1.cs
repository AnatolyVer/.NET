using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            float R = 0;
            form.ChildFormClosed += message => R = float.Parse(message);
            DialogResult result = form.ShowDialog();
            
            if (result == DialogResult.OK || result == DialogResult.Cancel)
            {
                double v = 4.0 / 3.0 * Math.PI * Math.Pow(R, 3) / 1000.0;
                double s = 4 * Math.PI * Math.Pow(R, 2) / 10000;
                label1.Text = String.Format("Об\'єм кулі: {0:0.00} л", v);
                label2.Text = String.Format("Площа сфери: {0:0.00} м2", s);
            }
        }
    }
}