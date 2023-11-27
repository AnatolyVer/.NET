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
    public partial class Form8 : Form
    {
        public event Action<string> ChildFormClosed;

        public Form8(Form7 form)
        {
            InitializeComponent();
            
            label5.Text = form.Text + ": " +  form.textBox1.Text;
            
            this.FormClosed += (sender, e) =>
            {
                ChildFormClosed.Invoke("Повернення управління з " + Text + "\nПовернутий текст: " + textBox2.Text);
            };
        }
    }
}