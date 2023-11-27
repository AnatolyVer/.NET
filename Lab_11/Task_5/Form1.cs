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

namespace Task_5
{
    
    public partial class Form1 : Form
    {
        private List<City> cities = new List<City>();

        private string path = "C:\\Users\\ASUS\\RiderProjects\\Lab_11\\Task_5\\Cities\\";
        
        public Form1()
        {
            InitializeComponent();
            try
            {
                int i = 1;
                string[] lines = File.ReadAllLines(path + "info.txt");
                
                int j = 0;
                while (j < lines.Length)
                {
                    string cityName = lines[j];
                    j++; 
                    string cityDescription = "";
                    while (j < lines.Length && !string.IsNullOrWhiteSpace(lines[j]))
                    {
                        cityDescription += lines[j] + "\n";
                        j++;
                    }
                    string img = path + i++ + ".jpg";
                    listBox1.Items.Add(cityName);
                    cities.Add(new City(img, cityName, cityDescription ));
                    j++; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ошибка при чтении файла: {0}", ex.Message));
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            Form2 form = new Form2(cities[selectedIndex]);
            DialogResult dialog = form.ShowDialog();
        }
    }
}