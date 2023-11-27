using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6
{
    public partial class ParametersForm : Form
    {
        ColorDialog colorDialog = new ColorDialog();
        ColorDialog colorDialog2 = new ColorDialog();
        FontDialog fontDialog = new FontDialog();
        private Form1 modalForm;
        public ParametersForm(object sender)
        {
            modalForm = sender as Form1;
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            modalForm.BackColor = colorDialog.Color;
            modalForm.menuStrip1.BackColor = colorDialog.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            
            modalForm.label1.Font = fontDialog.Font;     
            modalForm.label2.Font = fontDialog.Font;     
            modalForm.label3.Font = fontDialog.Font;     
            modalForm.label4.Font = fontDialog.Font;     
            modalForm.label5.Font = fontDialog.Font;     
            modalForm.label6.Font = fontDialog.Font;     
            modalForm.label7.Font = fontDialog.Font;     
            modalForm.label8.Font = fontDialog.Font;     

        }

        
        private void button4_Click(object sender, EventArgs e)
        {
                
            colorDialog2.ShowDialog();
            modalForm.label1.ForeColor = colorDialog2.Color;      
            modalForm.label2.ForeColor = colorDialog2.Color;                    
            modalForm.label3.ForeColor = colorDialog2.Color;                    
            modalForm.label4.ForeColor = colorDialog2.Color;                    
            modalForm.label5.ForeColor = colorDialog2.Color;                    
            modalForm.label6.ForeColor = colorDialog2.Color;                    
            modalForm.label7.ForeColor = colorDialog2.Color;                    
            modalForm.label8.ForeColor = colorDialog2.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modalForm.Size = new Size(sizeTrackBar1.Value, sizeTrackBar2.Value);
        }
    }
}
