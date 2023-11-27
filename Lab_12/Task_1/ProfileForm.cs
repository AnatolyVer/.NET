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
  public partial class ProfileForm : Form
  {
    private User user;
    private StartForm form;
    
    public ProfileForm(StartForm form, User user)
    {
      InitializeComponent();
      this.form = form;
      this.user = user;
      Text = "Social Network | " + this.user.username;
      label1.Text = this.user.username;
      label2.Text = this.user.email;
      label3.Text = this.user.birthday;
      pictureBox1.Image = FileManager.GetImage(this.user.username);
      this.FormClosing += Form1_FormClosing;
    }
    
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      form.Close();
    }

    private void toolStripMenuItem2_Click(object sender, EventArgs e)
    {
      RegForm regForm = new RegForm(form);
      regForm.Show();
      this.FormClosing -= Form1_FormClosing;
      this.Close();
    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {
      EditForm editForm = new EditForm(form, user);
      editForm.Show();
      this.FormClosing -= Form1_FormClosing;
      this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      SendMessageForm sendMessageForm = new SendMessageForm(form, user);
      sendMessageForm.Show();
      this.FormClosing -= Form1_FormClosing;
      this.Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      ReadMessageForm readMessageForm = new ReadMessageForm(form, user);
      readMessageForm.Show();
      this.FormClosing -= Form1_FormClosing;
      this.Close();
    }
  }
}
