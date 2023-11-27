using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Task_13
{
    public partial class Form1 : Form
    {
        private List<ComboBox> comboBoxes = new List<ComboBox>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Alt && e.KeyCode == Keys.A)
            {
                if (comboBoxes.Count < 5)
                {
                    ComboBox comboBox = new ComboBox();
                    comboBox.FormattingEnabled = true;
                    comboBox.Items.AddRange(new object[] {"Елемент 1", "Елемент 2", "Елемент 3"});
                    comboBox.Location = new System.Drawing.Point(250, 150 + 100 * comboBoxes.Count);
                    comboBox.Name = "comboBox1";
                    comboBox.Size = new System.Drawing.Size(120, 25);
                    comboBoxes.Add(comboBox);
                    Controls.Add(comboBox);
                }
            }
            else if (e.Control && e.Alt && e.KeyCode == Keys.D)
            {
                if (comboBoxes.Count != 0)
                { 
                    ComboBox comboBox = comboBoxes[comboBoxes.Count - 1];
                    Controls.Remove(comboBox);
                    comboBox.Dispose();
                    comboBoxes.Remove(comboBox);
                }
            }
        }
    }
}
