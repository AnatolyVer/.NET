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

namespace Task_1
{
    public partial class Form1 : Form
    {
        int currentIndex = 0;
        List<Image> images = new List<Image>();
        
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
            images.Clear();

            string[] imageFiles = Directory.GetFiles(folderPath, "*.jpg");

            foreach (string imagePath in imageFiles)
            {
                images.Add(Image.FromFile(imagePath));
            }

            if (images.Count > 0)
            {
                currentIndex = 0;
                pictureBox1.Image = images[currentIndex];
            }
            else
            {
                MessageBox.Show("В выбранной папке нет изображений .jpg");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentIndex--;
            
            if (currentIndex < 0)
            {
                currentIndex = images.Count - 1;
            }

            pictureBox1.Image = images[currentIndex];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentIndex++;

            if (currentIndex >= images.Count)
            {
                currentIndex = 0;
            }

            pictureBox1.Image = images[currentIndex];
        }
    }
}