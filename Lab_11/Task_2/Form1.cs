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
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    
    private void toolStripMenuItem2_Click(object sender, EventArgs e)
    {
      Form6 form6 = new Form6(this);
      form6.ChildFormClosed += message => label3.Text = message;
      DialogResult result = form6.ShowDialog();
    }

    private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
    {
      Form2 form2 = new Form2(this);
      form2.ChildFormClosed += message => label3.Text = message;
      DialogResult result = form2.ShowDialog();
    }
  }
}
