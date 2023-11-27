using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton1.Font = new Font("Microsoft Sans Serif", 16F);
            }
            if (radioButton2.Checked)
            {
                radioButton2.Font = new Font("Microsoft Sans Serif", 16F);
            }
            if (radioButton3.Checked)
            {
                radioButton3.Font = new Font("Microsoft Sans Serif", 16F);
            }
            if (radioButton4.Checked)
            {
                radioButton4.Font = new Font("Microsoft Sans Serif", 16F);
            }
            if (radioButton6.Checked)
            {
                radioButton6.Font = new Font("Microsoft Sans Serif", 16F);
            }
            if (radioButton7.Checked)
            {
                radioButton7.Font = new Font("Microsoft Sans Serif", 16F);
            }
            if (radioButton8.Checked)
            {
                radioButton8.Font = new Font("Microsoft Sans Serif", 16F);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Font = new Font("Microsoft Sans Serif", 10F);
            radioButton2.Font = new Font("Microsoft Sans Serif", 10F);
            radioButton3.Font = new Font("Microsoft Sans Serif", 10F);
            radioButton4.Font = new Font("Microsoft Sans Serif", 10F);
            radioButton6.Font = new Font("Microsoft Sans Serif", 10F);
            radioButton7.Font = new Font("Microsoft Sans Serif", 10F);
            radioButton8.Font = new Font("Microsoft Sans Serif", 10F);

            radioButton2.Checked = true;
            radioButton6.Checked = true;
        }
    }
}
