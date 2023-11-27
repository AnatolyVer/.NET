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
    public partial class Form7 : Form
    {
        public event Action<string> ChildFormClosed;
        
        public Form7(Form6 form)
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
            Form8 form8 = new Form8(this);
            form8.ChildFormClosed += message => label3.Text = message;
            DialogResult result = form8.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9(this);
            form9.ChildFormClosed += message => label3.Text = message;
            DialogResult result = form9.ShowDialog();
        }
    }
}