using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3_3
{
    public partial class Form2 : Form
    {
        public Form2(float R)
        {
            InitializeComponent();
            double v = 4.0 / 3.0 * Math.PI * Math.Pow(R, 3) / 1000.0;
            double s = 4 * Math.PI * Math.Pow(R, 2) / 10000;
            label2.Text = String.Format("Об\'єм кулі: {0:0.00} л", v);
            label3.Text = String.Format("Площа сфери: {0:0.00} м2", s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}