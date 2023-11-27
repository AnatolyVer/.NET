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
    public partial class Form6 : Form
    {
        public event Action<string> ChildFormClosed;

        public Form6(Form1 form)
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
            Form7 form7 = new Form7(this);
            form7.ChildFormClosed += message => label3.Text = message;
            DialogResult result = form7.ShowDialog();
        }
    }
}