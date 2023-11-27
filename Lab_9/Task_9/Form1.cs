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
        private int sum;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            enable_Button();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float discount = 1;
            label2.Text = "Купівля у розницю";
            if (int.Parse(textBox1.Text) >= 10)
            {
                label2.Text = "Купівля оптом";
                discount = 1.15F;
            }
            label3.Text = "Загальна вартість: " + (discount * sum * int.Parse(textBox1.Text)).ToString() + " грн.";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Маленька":
                    sum = 17;
                    break;
                case "Середня":
                    sum = 23;
                    break;
                case "Велика":
                    sum = 29;
                    break;
            }

        }
        
        private void textBox1_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                e.Handled = true; 
            }
        }

        private void enable_Button()
        {
            button1.Enabled = comboBox1.Text != "Оберіть порцію" && textBox1.Text != "" && textBox1.Text != "0";
        }
    }
}