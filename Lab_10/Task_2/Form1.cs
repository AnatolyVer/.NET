using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        int currentIndex = 0;
        List<Image> images = new List<Image>();
        
        public Form1()
        {
            InitializeComponent();
            LoadImagesFromFolder("C:\\Users\\ASUS\\RiderProjects\\Lab_10\\Task_1\\Folder");
            
            timer1.Interval = 3000;
            timer1.AutoReset = true;
            timer1.Start();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button4.Text = "Start";
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

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            currentIndex++;

            if (currentIndex >= images.Count)
            {
                currentIndex = 0;
            }

            pictureBox1.Image = images[currentIndex];
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (button4.Text == "Start")
            {
                button4.Text = "Stop";
                timer1.Interval = int.Parse(textBox1.Text) * 1000;
                timer1.Start();
            }
            else
            {
                button4.Text = "Start";
                timer1.Stop();
            }
        }
        
        private void textBox1_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                e.Handled = true; 
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Text = "Start";
        }
    }
}