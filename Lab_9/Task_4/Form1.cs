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
        private float exchange_rate = 0.201168F;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar) )
            {
                e.Handled = true; 
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "") textBox2.Text = (float.Parse(textBox1.Text) * exchange_rate).ToString();
            else textBox2.Text = "";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar) )
            {
                e.Handled = true; 
            }
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "") textBox1.Text = (float.Parse(textBox2.Text) / exchange_rate).ToString();
            else textBox1.Text = "";
        }
    }
}