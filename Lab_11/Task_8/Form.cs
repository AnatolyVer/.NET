using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Task_8.Properties;

namespace Task_8
{
    public partial class Form : System.Windows.Forms.Form
    {
        string path = "";
        string state = "not_saved";

        public Form()
        {
            InitializeComponent();
            timer1.Start();
        }
        
        private void AboutProgram(object sender, EventArgs e)
        {
            using (AboutForm modalForm = new AboutForm())
            {
                DialogResult result = modalForm.ShowDialog(this);
            }
        }

        private void Create(object sender, EventArgs e)
        {
            this.Text = "Текстовий редактор - *Новий файл";

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "|*.txt";
            saveFileDialog1.Title = "Save an .txt File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != null)
            {
                try
                {
                    path = Path.GetFullPath(saveFileDialog1.FileName);
                    File.WriteAllText(path, textBox1.Text);
                    this.Text = "Текстовий редактор - " + Path.GetFileName(path);
                    state = "saved";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при збереженні файлу: " + ex.Message, "Збереження файлу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Save(object sender, EventArgs e)
        {
           Save();
        }
        
        private void Save()
        {
            File.WriteAllText(path, textBox1.Text);
            state = "saved";
            this.Text = "Текстовий редактор - " + Path.GetFileName(path);
        }
        
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Alt && e.KeyCode == Keys.D)
            {
                string currentDate = DateTime.Now.ToString("dd.mm.yyyy ");
                int cursorPosition = textBox1.SelectionStart;
                textBox1.Text = textBox1.Text.Insert(cursorPosition, currentDate);
                textBox1.SelectionStart = cursorPosition + currentDate.Length;
                textBox1.SelectionLength = 0;
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                Save();
            }
        }    
            
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(state == "saved")
            {
                this.Text = "Текстовий редактор - *" + Path.GetFileName(path);
                state = "not_saved";
            }
        }

        private void LoadFile(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;

                if (File.Exists(filePath))
                {
                    string fileContent = File.ReadAllText(filePath);
                    textBox1.Text = fileContent;
                    this.Text = "Текстовий редактор - " + Path.GetFileName(filePath);
                    state = "saved";
                    path = filePath;
                }
                else
                {
                    MessageBox.Show("Файл не існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            int cursorPosition = textBox1.SelectionStart;
            int lineIndex = textBox1.GetLineFromCharIndex(cursorPosition);
            int columnIndex = cursorPosition - textBox1.GetFirstCharIndexFromLine(lineIndex);
            
            ToolStripStatusLabel statusLabel = (ToolStripStatusLabel)statusStrip1.Items[0];
            statusLabel.Text = string.Format("Рядок: {0}, Позиція: {1}", lineIndex+1, columnIndex);
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            зберегтиToolStripMenuItem.Enabled = !string.IsNullOrWhiteSpace(path);
        }

        private void statusLabel_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
