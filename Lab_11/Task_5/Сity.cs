using System.Drawing;
using System.Windows.Forms;

namespace Task_5
{
    public class City
    {
        public Image img;
        public string name;
        public string description;

        public City(string img, string name, string description)
        {
            this.img = Image.FromFile(img);
            this.name = name;
            this.description = description;
        }
    }
}