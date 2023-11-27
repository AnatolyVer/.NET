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
  public partial class RegForm : Form
  {
    private string method = "Auth";
    private StartForm form;

    private bool isUsernameGood = false;
    private bool isEmailGood = false;
    private bool isPasswordGood = false;
    
    public RegForm(StartForm form)
    {
      InitializeComponent();
      this.form = form;
      this.FormClosing += Form1_FormClosing;
      this.button1.Click += Reg;
      this.button2.Click += Auth;
    }

    private void DateTimePicker_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
      DateTimePicker picker = (DateTimePicker)sender;

      if (picker.Value > DateTime.Now)
      {
        e.Cancel = true;
        picker.Value = DateTime.Now;
      }
    }
    
    private void Reg(object sender, EventArgs e)
    {
      if (method == "Auth")
      {
        textBox1.Text = "";
        textBox2.Text = "";
        textBox3.Text = "";
        textBox4.Text = "";
        label5.Text = "";
        button3.Enabled = false;
        method = "Reg";
        SwapButtons();
        this.button1.Click -= Reg;
        this.button1.Click += Auth;
        this.button2.Click += Reg;
        this.button2.Click -= Auth;
        button3.Text = "Create";
        button2.Text = "X";
        button1.Text = "Log in";

        label1.Text = "Username";
        textBox2.Size = new Size(178, 26);
        
        label3.Visible = true;
        label4.Visible = true;
        textBox4.Visible = true;
        label7.Visible = true;
        textBox3.Visible = true;
        dateTimePicker1.Visible = true;
      }
    }
    
    private void Auth(object sender, EventArgs e)
    {
      if (method == "Reg")
      {
        textBox1.Text = "";
        textBox2.Text = "";
        textBox3.Text = "";
        textBox4.Text = "";
        button3.Enabled = false;
        method = "Auth";
        SwapButtons();
        this.button1.Click += Reg;
        this.button1.Click -= Auth;
        this.button2.Click -= Reg;
        this.button2.Click += Auth;
        button3.Text = "Log in";
        button1.Text = "Sign up";
        button2.Text = "X";
        
        textBox2.Size = new Size(360, 26);

        label3.Visible = false;
        label4.Visible = false;
        label7.Visible = false;
        textBox3.Visible = false;
        textBox4.Visible = false;
        dateTimePicker1.Visible = false;
      }
    }

    private void SwapButtons()
    {
      Point position = button1.Location;
      button1.Location = button2.Location;
      button2.Location = position;
    }
    
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      form.Close();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      string username = textBox1.Text;
      if (method == "Reg")
      {
        string password = textBox2.Text;
        string email = textBox4.Text;
        string birthday = dateTimePicker1.Text;
        User user = new User(username, password, birthday, email);
        if (FileManager.CreateUser(user)) OpenProfile(user);
        else label5.Text = "User already exists";
      }
      else
      {
        User user = FileManager.GetUser(username);
        if (user != null && user.password == textBox2.Text) OpenProfile(user);
        else label5.Text = "Wrong data or user doesn`t exist"; 
      }
    }

    private void OpenProfile(User user)
    {
      this.FormClosing -= Form1_FormClosing;
      ProfileForm profileForm = new ProfileForm(form, user);
      this.Hide();
      profileForm.Show();
    }
    
    private void check()
    {
      if (method == "Reg")
      {
        if (!isUsernameGood || !isEmailGood || !isPasswordGood)
        {
          button3.Enabled = false;
          button3.BackColor = System.Drawing.Color.Gray;
        }
        else
        {
          button3.Enabled = true;
          button3.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
        }
      }

      else
      {
        if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
        {
          button3.Enabled = false;
          button3.BackColor = System.Drawing.Color.Gray;
        }
        else
        {
          button3.Enabled = true;
          button3.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
        }
      }
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      if (method == "Reg")
      {
        string pattern = @"^[a-zA-Z0-9]{1,15}$";
        Regex regex = new Regex(pattern);
        if (regex.IsMatch(textBox1.Text))
        {
          label6.Text = "";
          isUsernameGood = true;
        }
        else
        {
          isUsernameGood = false;
          label6.Text = "Wrong Username";
          if (string.IsNullOrWhiteSpace(textBox1.Text))
          {
            label6.Text = "";
          }
        }
      }
      check();
    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {
      if (method == "Reg")
      {
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        Regex regex = new Regex(pattern);
        if (regex.IsMatch(textBox4.Text))
        {
          label9.Text = "";
          isEmailGood = true;
        }
        else
        {
          isEmailGood = false;
          label9.Text = "Wrong Email format";
          if (string.IsNullOrWhiteSpace(textBox4.Text))
          {
            label9.Text = "";
          }
        }
        check();
      }
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
      if (method == "Reg") checkPasswords();
      check();
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
      if (method == "Reg") checkPasswords();
      check();
    }

    private void checkPasswords()
    {
      string pattern = @"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[!@#$%^&*()-_+=])[a-zA-Z\d!@#$%^&*()-_+=]{12,}$";
      Regex regex = new Regex(pattern);
      if (regex.IsMatch(textBox2.Text) && textBox2.Text == textBox3.Text)
      {
        label8.Text = "";
        isPasswordGood = true;
      }
      else
      {
        isPasswordGood = false;
        label8.Text = "Wrong password format or passwords are not same";
        if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
        {
          label8.Text = "";
        }
      }
    }
  }
}
