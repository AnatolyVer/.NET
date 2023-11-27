using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
  public partial class SendMessageForm : Form
  {
    private User user;
    private StartForm form;
    private bool isUsername = false;
    private bool isTheme = false;
    private bool isText = false;
    
    public SendMessageForm(StartForm form, User user)
    {
      InitializeComponent();
      this.form = form;
      this.user = user;
      Text = "Social Network | " + this.user.username;
      this.FormClosing += Form1_FormClosing;
    }

    private void check()
    {
      if (isText && isUsername && isTheme)
      {
        button1.Enabled = true;
        button1.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
      }
      else
      {
        button1.Enabled = false;
        button1.BackColor = System.Drawing.Color.Gray;
      }
    }
    
    
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      form.Close();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      string folderPath = textBox1.Text;
      if (Directory.Exists(folderPath))
      {
        isUsername = true;
        label2.Text = "";
      }
      else
      {
        isUsername = false;
        label2.Text = "User doesn`t exist";
        if (string.IsNullOrWhiteSpace(textBox1.Text))
        {
          label2.Text = "";
        }
      }
      check();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string folderPath = textBox1.Text;

      if (!Directory.Exists(Path.Combine(folderPath, "messages")))
      {
        Directory.CreateDirectory(Path.Combine(folderPath, "messages"));
      }
      
      string fileName = "message_" + DateTime.Now.ToString("HH-mm-ss_dd-MM-yyyy") + ".txt";
      string filePath = Path.Combine(folderPath, "messages" ,fileName);
      if (Directory.Exists(folderPath))
      {
        string message = string.Format("{0}\n{1}\n{2}\n{3}", user.username, DateTime.Now.ToString("U"), textBox2.Text, textBox3.Text);
        File.WriteAllText(filePath, message);
        returnToProfile();
      }
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
      if (textBox2.Text.Length > 26)
      {
        textBox2.Text = textBox2.Text.Substring(0, 26);
      }
      isTheme = textBox2.Text.Length > 0 && textBox2.Text.Length <= 26;

      check();
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
      isText = !string.IsNullOrWhiteSpace(textBox3.Text);
     
      check();
    }

    private void returnToProfile()
    {
      this.FormClosing -= Form1_FormClosing;
      ProfileForm profileForm = new ProfileForm(form, user);
      profileForm.Show();
      this.Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      returnToProfile();
    }
  }
}
