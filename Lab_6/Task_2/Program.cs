using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    class App : Form
    {
        public App()
        {
            ComboBox comboBox1 = new ComboBox();
            ListBox listBox1 = new ListBox();
            
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Братислава", "Кошице", "Прешов", "Нітра", "Трнава", "Тренчин ", "Попрад", "Банська-Бистриця" });
            comboBox1.Location = new System.Drawing.Point(250, 150);
            comboBox1.Size = new System.Drawing.Size(120, 21);
            comboBox1.Text = "Словаччина";

            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Братислава", "Кошице", "Прешов", "Нітра", "Трнава", "Тренчин ", "Попрад", "Банська-Бистриця" });
            listBox1.Location = new System.Drawing.Point(400, 150);
            listBox1.Size = new System.Drawing.Size(120, 120);

            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            ClientSize = new System.Drawing.Size(800, 450);
            Text = "Form1";
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new App());
        }
    }
}
