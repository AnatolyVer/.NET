using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) checkBox1.Font = new Font("Microsoft Sans Serif", 16F);

            if (checkBox2.Checked) checkBox2.Font = new Font("Microsoft Sans Serif", 16F);

            if (checkBox3.Checked) checkBox3.Font = new Font("Microsoft Sans Serif", 16F);

            if (checkBox4.Checked) checkBox4.Font = new Font("Microsoft Sans Serif", 16F);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Font = new Font("Microsoft Sans Serif", 10F);
            checkBox2.Font = new Font("Microsoft Sans Serif", 10F);
            checkBox3.Font = new Font("Microsoft Sans Serif", 10F);
            checkBox4.Font = new Font("Microsoft Sans Serif", 10F);

            checkBox1.Checked = true;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }
    }
}
