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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            string[] R = {"0 0 0"};
            form.ChildFormClosed += message => R = message.Split(' ');
            DialogResult Dresult = form.ShowDialog();
            
            if (Dresult == DialogResult.OK || Dresult == DialogResult.Cancel)
            {
                double x = double.Parse(R[0]);
                double y = double.Parse(R[1]);
                double z = double.Parse(R[2]);
                double result = 1;
                try
                {
                    for (int i = 1; i <= x + y + z; i++)
                    {
                        result *= Math.Sqrt((i + 10) / (x - y + i));
                    }

                    label1.Text = String.Format("Result = {0:0.00}", result);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ділення на 0");
                }
            }
        }
    }
}