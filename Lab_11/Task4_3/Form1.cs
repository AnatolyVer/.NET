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

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(!string.IsNullOrWhiteSpace(textBox1.Text) ? textBox1.Text : "0");
            double y = double.Parse(!string.IsNullOrWhiteSpace(textBox2.Text) ? textBox2.Text : "0");
            double z = double.Parse(!string.IsNullOrWhiteSpace(textBox3.Text) ? textBox3.Text : "0");
            double result = 1;
            try
            {
                for (int i = 1; i <= x + y + z; i++)
                {
                    result *= Math.Sqrt((i + 10) / (x - y + i));
                }

                Form2 form = new Form2(result);
                DialogResult dialogResult = form.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ділення на 0");
            }
        }
    }
}