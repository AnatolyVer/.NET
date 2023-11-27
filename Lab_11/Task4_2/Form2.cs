using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4_2
{
    public partial class Form2 : Form
    {
        public event Action<string> ChildFormClosed;
        
        public Form2()
        {
            InitializeComponent();
            
            this.FormClosed += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    textBox1.Text = "0";
                }
                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    textBox2.Text = "0";
                }
                if (string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    textBox3.Text = "0";
                }
                ChildFormClosed.Invoke(String.Format("{0} {1} {2}", textBox1.Text, textBox2.Text, textBox3.Text));
            };
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
            this.Close();
        }
    }
}