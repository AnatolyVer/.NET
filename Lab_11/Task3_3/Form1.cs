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
            Form2 form = new Form2(float.Parse(!string.IsNullOrWhiteSpace(textBox1.Text) ? textBox1.Text : "0"));
            DialogResult result = form.ShowDialog();
        }
    }
}