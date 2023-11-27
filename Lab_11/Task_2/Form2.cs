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
    public partial class Form2 : Form
    {
        public event Action<string> ChildFormClosed;
        
        public Form2(Form1 form)
        {
            InitializeComponent();
            label5.Text = form.Text + ": " +  form.textBox1.Text;
            
            this.FormClosed += (sender, e) =>
            {
                ChildFormClosed.Invoke("Повернення управління з " + Text + "\nПовернутий текст: " + textBox2.Text);
            };
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.ChildFormClosed += message => label3.Text = message;
            DialogResult result = form3.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.ChildFormClosed += message => label3.Text = message;
            DialogResult result = form4.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this);
            form5.ChildFormClosed += message => label3.Text = message;
            DialogResult result = form5.ShowDialog();
        }
    }
}