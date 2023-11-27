using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6
{
    public partial class Form1 : Form
    {
        private int sum = 0;
        private float exchange_rate = 0.22F;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void enable_Button()
        {
            button1.Enabled = checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) sum += 20;
            else sum -= 20;
            enable_Button();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) sum += 35;
            else sum -= 35;
            enable_Button();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) sum += 25;
            else sum -= 25;
            enable_Button();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) sum += 33;
            else sum -= 33;
            enable_Button();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = string.Format("Ціна обраного замовлення: {0:0.00} грн. ({1:0.00} HKD)", sum, sum * exchange_rate);
            label3.Text = string.Format("Чайові (15%): {0:0.00} грн. ({1:0.00} HKD)", sum * 0.15, sum * 0.15 * exchange_rate);
            label4.Text = string.Format("Загальна сума замовлення: {0:0.00} грн. ({1:0.00} HKD)", sum * 1.15, sum * 1.15 * exchange_rate);
        }
    }
}