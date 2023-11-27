using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void item15ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void item122ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void item123ToolStripMenuItem_Click(object sender, EventArgs e)
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

                        MessageBox.Show(string.Format(
                            "Пункт меню 1-го рівня:  {0} , 2-го рівня:  {1} , 3-го рівня: {2}", topLevelMenuName,
                            level2MenuName, level3MenuName));
                    }
                }
            }
        }

        private void item124ToolStripMenuItem_Click(object sender, EventArgs e)
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

                        MessageBox.Show(string.Format(
                            "Пункт меню 1-го рівня:  {0} , 2-го рівня:  {1} , 3-го рівня: {2}", topLevelMenuName,
                            level2MenuName, level3MenuName));
                    }
                }
            }
        }

        private void item125ToolStripMenuItem_Click(object sender, EventArgs e)
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

                        MessageBox.Show(string.Format(
                            "Пункт меню 1-го рівня:  {0} , 2-го рівня:  {1} , 3-го рівня: {2}", topLevelMenuName,
                            level2MenuName, level3MenuName));
                    }
                }
            }
        }

        private void item16ToolStripMenuItem_Click(object sender, EventArgs e)
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

                        MessageBox.Show(string.Format(
                            "Пункт меню 1-го рівня:  {0} , 2-го рівня:  {1} , 3-го рівня: {2}", topLevelMenuName,
                            level2MenuName, level3MenuName));
                    }
                }
            }
        }

        private void item142ToolStripMenuItem_Click(object sender, EventArgs e)
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

                        MessageBox.Show(string.Format(
                            "Пункт меню 1-го рівня:  {0} , 2-го рівня:  {1} , 3-го рівня: {2}", topLevelMenuName,
                            level2MenuName, level3MenuName));
                    }
                }
            }
        }

        private void item143ToolStripMenuItem_Click(object sender, EventArgs e)
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

                        MessageBox.Show(string.Format(
                            "Пункт меню 1-го рівня:  {0} , 2-го рівня:  {1} , 3-го рівня: {2}", topLevelMenuName,
                            level2MenuName, level3MenuName));
                    }
                }
            }
        }

        private void item144ToolStripMenuItem_Click(object sender, EventArgs e)
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

                        MessageBox.Show(string.Format(
                            "Пункт меню 1-го рівня:   {0}  , 2-го рівня:   {1}  , 3-го рівня: {2}", topLevelMenuName,
                            level2MenuName, level3MenuName));
                    }
                }
            }
        }

        private void item541ToolStripMenuItem_Click(object sender, EventArgs e)
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

                        MessageBox.Show(string.Format(
                            "Пункт меню 1-го рівня:   {0}  , 2-го рівня:   {1}  , 3-го рівня: {2}", topLevelMenuName,
                            level2MenuName, level3MenuName));
                    }
                }
            }
        }

        private void item542ToolStripMenuItem_Click(object sender, EventArgs e)
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

                        MessageBox.Show(string.Format(
                            "Пункт меню 1-го рівня:   {0}  , 2-го рівня:   {1}  , 3-го рівня: {2}", topLevelMenuName,
                            level2MenuName, level3MenuName));
                    }
                }
            }
        }

        private void item543ToolStripMenuItem_Click(object sender, EventArgs e)
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

                        MessageBox.Show(string.Format(
                            "Пункт меню 1-го рівня:   {0}  , 2-го рівня:   {1}  , 3-го рівня: {2}", topLevelMenuName,
                            level2MenuName, level3MenuName));
                    }
                }
            }
        }

        private void item544ToolStripMenuItem_Click(object sender, EventArgs e)
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

                        MessageBox.Show(string.Format(
                            "Пункт меню 1-го рівня:   {0}  , 2-го рівня:   {1}  , 3-го рівня: {2}", topLevelMenuName,
                            level2MenuName, level3MenuName));
                    }
                }
            }
        }

        private void item545ToolStripMenuItem_Click(object sender, EventArgs e)
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

                        MessageBox.Show(string.Format(
                            "Пункт меню 1-го рівня:   {0}  , 2-го рівня:   {1}  , 3-го рівня: {2}", topLevelMenuName,
                            level2MenuName, level3MenuName));
                    }
                }
            }
        }
    }
}
