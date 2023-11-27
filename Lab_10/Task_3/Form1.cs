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

namespace Task_3
{
    public partial class Form1 : Form
    {
        List<string> imageFiles = new List<string>(); 
        
        public Form1()
        {
            InitializeComponent();
            LoadImagesFromFolder("C:\\Users\\ASUS\\RiderProjects\\Lab_10\\Task_1\\Folder");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolderPath = folderDialog.SelectedPath;

                    LoadImagesFromFolder(selectedFolderPath);
                }
            }
        }
        
        private void LoadImagesFromFolder(string folderPath)
        {
            imageFiles.Clear();

            string[] files = Directory.GetFiles(folderPath, "*.jpg");

            imageFiles.AddRange(files);

            listBox1.Items.Clear();
            foreach (string imagePath in imageFiles)
            {
                string fileName = Path.GetFileName(imagePath);
                listBox1.Items.Add(fileName);
            }

            if (imageFiles.Count > 0)
            {
                listBox1.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("В выбранной папке нет изображений .jpg");
            }
            label1.Text = folderPath;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < imageFiles.Count)
            {
                string imagePath = imageFiles[selectedIndex];
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }
    }
}