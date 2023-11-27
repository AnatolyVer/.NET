using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.FontFamily, 16, textBox1.Font.Style);
            textBox2.Font = new Font(textBox1.Font.FontFamily, 16, textBox1.Font.Style);
            textBox3.Font = new Font(textBox1.Font.FontFamily, 16, textBox1.Font.Style);
            textBox4.Font = new Font(textBox1.Font.FontFamily, 16, textBox1.Font.Style);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.FontFamily, 8, textBox1.Font.Style);
            textBox2.Font = new Font(textBox1.Font.FontFamily, 8, textBox1.Font.Style);
            textBox3.Font = new Font(textBox1.Font.FontFamily, 8, textBox1.Font.Style);
            textBox4.Font = new Font(textBox1.Font.FontFamily, 8, textBox1.Font.Style);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
