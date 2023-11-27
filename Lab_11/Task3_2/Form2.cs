using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3_2
{
    public partial class Form2 : Form
    {
        public event Action<string> ChildFormClosed;
        
        public Form2()
        {
            InitializeComponent();
            
            this.FormClosed += (sender, e) =>
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text)) ChildFormClosed.Invoke(textBox1.Text);
                else ChildFormClosed.Invoke("0");
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