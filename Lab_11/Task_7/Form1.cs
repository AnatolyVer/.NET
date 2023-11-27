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
    public partial class Form1 : Form
    {
        public UserSettings userSettings = new UserSettings();
        public UserSettings loadedSettings;
        
        public Form1()
        {
            InitializeComponent();
            CheckSaves();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string text = "";
            string is_recommended = "";

            if (radioButton1.Checked)
            {
                text = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                text = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                text = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                text = radioButton4.Text;
            }

            if (radioButton7.Checked)
            {
                is_recommended = radioButton7.Text;
            }
            else if (radioButton8.Checked)
            {
                is_recommended = radioButton8.Text;
            }

            MessageBox.Show(
                ("Вік: " + comboBox1.SelectedItem.ToString() + ",\nОбрана кухня: " + comboBox2.SelectedItem.ToString() + ",\nЧому обрали: "
                 + text + ",\nЧи рекомендуєте?: " + is_recommended),
                "Результати опитування",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            radioButton7.Checked = false;
            radioButton8.Checked = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (ParametersForm modalForm = new ParametersForm(this))
            {
                DialogResult result = modalForm.ShowDialog();
            }
        }
        
        private void CheckSaves()
        {
            string directoryPath = @"C:\Users\ASUS\RiderProjects\Lab_11\Task_7\bin\Debug";

            if (Directory.Exists(directoryPath))
            {
                string[] datFiles = Directory.GetFiles(directoryPath, "*.dat");

                foreach (string datFile in datFiles)
                {
                    string fileName = Path.GetFileName(datFile);
                    if (fileName != null)
                    {
                        loadedSettings = SettingsManager.LoadSettings(fileName);

                        label1.ForeColor = loadedSettings.SelectedForeColor;
                        label2.ForeColor = loadedSettings.SelectedForeColor;
                        label3.ForeColor = loadedSettings.SelectedForeColor;
                        label4.ForeColor = loadedSettings.SelectedForeColor;
                        label5.ForeColor = loadedSettings.SelectedForeColor;
                        label6.ForeColor = loadedSettings.SelectedForeColor;
                        label7.ForeColor = loadedSettings.SelectedForeColor;
                        label8.ForeColor = loadedSettings.SelectedForeColor;

                        label1.Font = loadedSettings.SelectedFont;
                        label2.Font = loadedSettings.SelectedFont;
                        label3.Font = loadedSettings.SelectedFont;
                        label4.Font = loadedSettings.SelectedFont;
                        label5.Font = loadedSettings.SelectedFont;
                        label6.Font = loadedSettings.SelectedFont;
                        label7.Font = loadedSettings.SelectedFont;
                        label8.Font = loadedSettings.SelectedFont;

                        this.BackColor = loadedSettings.SelectedBackColor;
                        menuStrip1.BackColor = loadedSettings.SelectedBackColor;
                        
                        userSettings = new UserSettings();
                        userSettings.SelectedFont = loadedSettings.SelectedFont;
                        userSettings.SelectedForeColor = loadedSettings.SelectedForeColor;
                        userSettings.SelectedBackColor = loadedSettings.SelectedBackColor;

                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Збережених налаштувань не знайдено");
            }
        }
    }
}
