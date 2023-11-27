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
    
    
    public partial class Form2 : Form
    {
        
        
        public Form2(City city)
        {
            InitializeComponent();
            Text = city.name;
            pictureBox1.Image = city.img;
            label1.Text = city.name;
            label2.Text = city.description;
        }
    }
}