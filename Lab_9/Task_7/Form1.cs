using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_7
{
    public partial class Form1 : Form
    {
        private int sum;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Загальна вартість: " + (sum * int.Parse(textBox1.Text)).ToString() + " грн.";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sum = 15;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sum = 23;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            sum = 29;
        }

        private void textBox1_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                e.Handled = true; 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" ||  textBox1.Text == "0")
            {
                button1.Enabled = false;
            }
            else button1.Enabled = true;
        }
    }
}