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
  public partial class EditForm : Form
  {
    private User user;
    private StartForm form;
    private User changed;
    
    private bool isUsernameGood = true;
    private bool isEmailGood = true;
    private bool isPasswordGood = true;
    private bool isNewPasswordGood = true;
    private bool isPhotosAreSame = true;
    
    public EditForm(StartForm form, User user)
    {
      InitializeComponent();
      this.form = form;
      this.user = user;
      Text = "Social Network | " + this.user.username;
      textBox1.Text = this.user.username;
      textBox2.Text = this.user.email;
      dateTimePicker1.Text = this.user.birthday;
      user.image = FileManager.GetImage(this.user.username);
      pictureBox1.Image = this.user.image;
      this.FormClosing += Form1_FormClosing;
      changed = new User(this.user);
    }
    
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      form.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      FileManager.ChangeUser(user.username, changed);
      ProfileForm regForm = new ProfileForm(form, changed);
      regForm.Show();
      this.FormClosing -= Form1_FormClosing;
      this.Close();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      string pattern = @"^[a-zA-Z0-9]{1,15}$";
      Regex regex = new Regex(pattern);
      if (regex.IsMatch(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))
      {
        isUsernameGood = true;
        label5.Text = "";
      }
      else
      {
        isUsernameGood = false;
        label5.Text = "Wrong Username";
        if (string.IsNullOrWhiteSpace(textBox1.Text))
        {
          label5.Text = "";
        }
      }

      if (changed != null)
      {
        changed.username = textBox1.Text;
      }
      check();
    }

    void AreImagesSame(Image image1, Image image2)
    {
      Bitmap bitmap1 = new Bitmap(image1);
      Bitmap bitmap2 = new Bitmap(image2);
      if (bitmap1.Size != bitmap2.Size)
      {
        isPhotosAreSame = false; 
        return;
      }
      for (int x = 0; x < bitmap1.Width; x++)
      {
        for (int y = 0; y < bitmap1.Height; y++)
        {
          if (bitmap1.GetPixel(x, y) != bitmap2.GetPixel(x, y)) isPhotosAreSame = false; 
        }
      }
      isPhotosAreSame = true; 
    }

    
    private void check()
    {
      if (changed != null)
      {
        if (isPhotosAreSame && (changed.ToString() == user.ToString()) || (!isUsernameGood || !isEmailGood || !isPasswordGood || !isNewPasswordGood))
        {
          button1.Enabled = false;
          button1.BackColor = System.Drawing.Color.Gray;
        }
        else
        {
          button1.Enabled = true;
          button1.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
        }
      }
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
      string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
      Regex regex = new Regex(pattern);
      if (regex.IsMatch(textBox2.Text))
      {
        label6.Text = "";
        isEmailGood = true;
      }
      else
      {
        isEmailGood = false;
        label6.Text = "Wrong Email format";
        if (string.IsNullOrWhiteSpace(textBox2.Text))
        {
          label6.Text = "";
        }
      }

      if (changed != null)
      {
        changed.email = textBox2.Text;
      }
      check();
    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {
      DateTimePicker picker = (DateTimePicker)sender;

      if (picker.Value > DateTime.Now)
      {
        picker.Value = DateTime.Now;
      }

      if (changed != null)
      {
        changed.birthday = picker.Text;
      }
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
      passwordsCheck();
    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {
      passwordsCheck();
    }

    private void passwordsCheck()
    {
      isPasswordGood = (textBox3.Text == user.password || string.IsNullOrWhiteSpace(textBox3.Text));
      
      string pattern = @"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[!@#$%^&*()-_+=])[a-zA-Z\d!@#$%^&*()-_+=]{12,}$";
      Regex regex = new Regex(pattern);
      if (regex.IsMatch(textBox4.Text) && textBox4.Text == textBox5.Text && isPasswordGood)
      {
        label10.Text = "";
        isNewPasswordGood = true;
        changed.password = textBox4.Text;
      }
      else
      {
        if (isPasswordGood)
        {
          label10.Text = "Wrong password format or passwords are not same";
        }
        else
        {
          label10.Text = "Wrong current password";
        }
        isNewPasswordGood = false;
        if (string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
        {
          label10.Text = "";
        }
      }
      check();
    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {
      passwordsCheck();
    }
    
    private void checkPasswords()
    {
      string pattern = @"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[!@#$%^&*()-_+=])[a-zA-Z\d!@#$%^&*()-_+=]{12,}$";
      Regex regex = new Regex(pattern);
      if (regex.IsMatch(textBox4.Text) && textBox4.Text == textBox5.Text)
      {
        label10.Text = "";
        isNewPasswordGood = true;
      }
      else
      {
        isNewPasswordGood = false;
        label10.Text = "Wrong password format or passwords are not same";
        if (string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
        {
          label10.Text = "";
        }
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      ProfileForm profileForm = new ProfileForm(form, user);
      profileForm.Show();
      this.FormClosing -= Form1_FormClosing;
      this.Close();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();

      openFileDialog.Filter = "Изображения|*.jpg";

      DialogResult result = openFileDialog.ShowDialog();

      if (result == DialogResult.OK)
      {
        string filePath = openFileDialog.FileName;
        using (Image img = Image.FromFile(filePath))
        {
          changed.image = new Bitmap(img);
          pictureBox1.Image = new Bitmap(img);
        }
      }
      
      AreImagesSame(changed.image, user.image);
      check();
    }
  }
}
