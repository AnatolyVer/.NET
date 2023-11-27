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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;

            if (clickedItem != null)
            {
                ToolStripMenuItem parentLevel2 = clickedItem.OwnerItem as ToolStripMenuItem;

                if (parentLevel2 != null)
                {
                    ToolStripMenuItem parentLevel1 = parentLevel2.OwnerItem as ToolStripMenuItem;

                    if (parentLevel1 != null)
                    {
                        string topLevelMenuName = parentLevel1.Text;
                        string level2MenuName = parentLevel2.Text;
                        string level3MenuName = clickedItem.Text;

                        MessageBox.Show(string.Format("Пункт меню 1-го рівня: {0}, 2-го рівня: {1}, 3-го рівня: {2}",
                            topLevelMenuName, level2MenuName, level3MenuName));
                    }
                }
            }
        }
    }
}
