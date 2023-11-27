using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
  public partial class ReadMessageForm : Form
  {
    private User user;
    private StartForm form;
    
    public ReadMessageForm(StartForm form, User user)
    {
      InitializeComponent();
      this.form = form;
      this.user = user;
      Text = "Social Network | " + this.user.username;
      this.FormClosing += Form1_FormClosing;
      string folderPath = Path.Combine(this.user.username, "messages");
      if (Directory.Exists(folderPath))
      {
        var files = Directory.GetFiles(folderPath, "message*");
        foreach (var file in files)
        {
          listBox1.Items.Add(Path.GetFileName(file.Remove(file.Length - 4)));
        }
      }
    }
    
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      form.Close();
    }
    
    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listBox1.SelectedItem != null)
      {
        string selectedFileName = listBox1.SelectedItem.ToString() + ".txt";
        string path = Path.Combine(user.username, "messages", selectedFileName);
        if (File.Exists(path))
        {
          using (StreamReader reader = new StreamReader(path))
          {
            string line;
            int i = 0;
            label4.Text = "";

            do
            {
              line = reader.ReadLine();
              switch (i)
              {
                case 0:
                  label2.Text = "From: " + line;
                  pictureBox1.Image = Image.FromFile(Path.Combine(line, "photo.jpg"));
                  break;
                case 1:
                  label5.Text = line;
                  break;
                case 2:
                  label3.Text = "Theme: " + line;
                  break;
                default:
                  label4.Text += line + "\n";
                  break;
              }
              i++;
            } while (!string.IsNullOrWhiteSpace(line));
          }
        }
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.FormClosing -= Form1_FormClosing;
      ProfileForm profileForm = new ProfileForm(form, user);
      profileForm.Show();
      this.Close();
    }


   
  }
}
