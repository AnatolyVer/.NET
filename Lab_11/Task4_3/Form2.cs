using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4_3
{
    public partial class Form2 : Form
    {
        public Form2(double result)
        {
            InitializeComponent();
            label1.Text = String.Format("Result = {0:0.00}", result);
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}