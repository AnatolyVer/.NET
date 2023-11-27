using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
       private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            try
            {
                double loanAmount = double.Parse(textBox1.Text);
                double interestRate = double.Parse(textBox3.Text);
                int loanTerm = int.Parse(textBox2.Text);
                
                double monthlyInterestRate = interestRate / 1200;
                double monthlyPayment = loanAmount * (monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, loanTerm)) / (Math.Pow(1 + monthlyInterestRate, loanTerm) - 1);

                for (int month = 1; month <= loanTerm; month++)
                {
                    double interestPayment = loanAmount * monthlyInterestRate;
                    double principalPayment = monthlyPayment - interestPayment;

                    ListViewItem item = new ListViewItem(month.ToString());
                    item.SubItems.Add(loanAmount.ToString());
                    item.SubItems.Add(interestPayment.ToString());
                    item.SubItems.Add(monthlyPayment.ToString());

                    listView1.Items.Add(item);

                    loanAmount -= principalPayment;
                }

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch (Exception exception)
            {
                MessageBox.Show("Wrong data");
            }
        }
    }
}