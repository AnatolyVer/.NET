using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_7
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
            InitializeMenu();
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            modalForm.BackColor = colorDialog.Color;
            modalForm.menuStrip1.BackColor = colorDialog.Color;
            
            modalForm.userSettings.SelectedBackColor = colorDialog.Color;
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

            modalForm.userSettings.SelectedFont = fontDialog.Font;
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
            
            modalForm.userSettings.SelectedForeColor = colorDialog2.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modalForm.Size = new Size(sizeTrackBar1.Value, sizeTrackBar2.Value);
        }
        
        private void InitializeMenu()
        {
            string directoryPath = @"C:\Users\ASUS\RiderProjects\Lab_11\Task_7\bin\Debug";

            if (Directory.Exists(directoryPath))
            {
                string[] datFiles = Directory.GetFiles(directoryPath, "*.dat");

                
                foreach (string datFile in datFiles)
                {
                    string fileName = Path.GetFileName(datFile);
                    ToolStripMenuItem newMenuItem = new ToolStripMenuItem(fileName);

                    newMenuItem.Click += (sender, e) =>
                    {
                        modalForm.loadedSettings = SettingsManager.LoadSettings(fileName);

                        modalForm.label1.ForeColor = modalForm.loadedSettings.SelectedForeColor;
                        modalForm.label2.ForeColor = modalForm.loadedSettings.SelectedForeColor;
                        modalForm.label3.ForeColor = modalForm.loadedSettings.SelectedForeColor;
                        modalForm.label4.ForeColor = modalForm.loadedSettings.SelectedForeColor;
                        modalForm.label5.ForeColor = modalForm.loadedSettings.SelectedForeColor;
                        modalForm.label6.ForeColor = modalForm.loadedSettings.SelectedForeColor;
                        modalForm.label7.ForeColor = modalForm.loadedSettings.SelectedForeColor;
                        modalForm.label8.ForeColor = modalForm.loadedSettings.SelectedForeColor;
                        
                        modalForm.label1.Font = modalForm.loadedSettings.SelectedFont;
                        modalForm.label2.Font = modalForm.loadedSettings.SelectedFont;
                        modalForm.label3.Font = modalForm.loadedSettings.SelectedFont;
                        modalForm.label4.Font = modalForm.loadedSettings.SelectedFont;
                        modalForm.label5.Font = modalForm.loadedSettings.SelectedFont;
                        modalForm.label6.Font = modalForm.loadedSettings.SelectedFont;
                        modalForm.label7.Font = modalForm.loadedSettings.SelectedFont;
                        modalForm.label8.Font = modalForm.loadedSettings.SelectedFont;

                        this.BackColor = modalForm.loadedSettings.SelectedBackColor;
                        menuStrip1.BackColor = modalForm.loadedSettings.SelectedBackColor;

                    };

                }
            }
            else
            {
                MessageBox.Show("Каталога не існує.");
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SettingsManager.SaveSettings("user_settings.dat", modalForm.userSettings);
        }
    }
}
