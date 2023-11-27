﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_1
{
  partial class EditForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(41, 62);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(462, 394);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.Gray;
      this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.button1.Enabled = false;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button1.Location = new System.Drawing.Point(304, 488);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(156, 49);
      this.button1.TabIndex = 5;
      this.button1.Text = "Save";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button2.Location = new System.Drawing.Point(551, 488);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(156, 49);
      this.button2.TabIndex = 6;
      this.button2.Text = "Cancel";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(528, 64);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(133, 29);
      this.label1.TabIndex = 7;
      this.label1.Text = "Username";
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(528, 130);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(257, 29);
      this.label2.TabIndex = 8;
      this.label2.Text = "Email";
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(528, 197);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(257, 29);
      this.label3.TabIndex = 9;
      this.label3.Text = "Birthday";
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(528, 260);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(156, 29);
      this.label4.TabIndex = 10;
      this.label4.Text = "Password";
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox1.Location = new System.Drawing.Point(706, 64);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(307, 31);
      this.textBox1.TabIndex = 11;
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // textBox2
      // 
      this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox2.Location = new System.Drawing.Point(706, 130);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(307, 31);
      this.textBox2.TabIndex = 12;
      this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
      // 
      // textBox3
      // 
      this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox3.Location = new System.Drawing.Point(706, 260);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(156, 31);
      this.textBox3.TabIndex = 13;
      this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
      // 
      // textBox4
      // 
      this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox4.Location = new System.Drawing.Point(528, 348);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(156, 31);
      this.textBox4.TabIndex = 14;
      this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
      // 
      // textBox5
      // 
      this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox5.Location = new System.Drawing.Point(706, 348);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(156, 31);
      this.textBox5.TabIndex = 15;
      this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dateTimePicker1.Location = new System.Drawing.Point(706, 199);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(156, 26);
      this.dateTimePicker1.TabIndex = 16;
      this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.ForeColor = System.Drawing.Color.Red;
      this.label5.Location = new System.Drawing.Point(528, 96);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(257, 20);
      this.label5.TabIndex = 17;
      this.label5.Text = "label5";
      // 
      // label6
      // 
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.ForeColor = System.Drawing.Color.Red;
      this.label6.Location = new System.Drawing.Point(528, 164);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(257, 22);
      this.label6.TabIndex = 18;
      this.label6.Text = "label6";
      // 
      // label8
      // 
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label8.Location = new System.Drawing.Point(706, 316);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(156, 29);
      this.label8.TabIndex = 20;
      this.label8.Text = "Confirm";
      // 
      // label9
      // 
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label9.Location = new System.Drawing.Point(528, 316);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(84, 29);
      this.label9.TabIndex = 21;
      this.label9.Text = "New";
      // 
      // label10
      // 
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label10.ForeColor = System.Drawing.Color.Red;
      this.label10.Location = new System.Drawing.Point(528, 382);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(485, 22);
      this.label10.TabIndex = 22;
      // 
      // EditForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(1068, 574);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.textBox5);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.pictureBox1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Location = new System.Drawing.Point(15, 15);
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "EditForm";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.Label label10;

    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.PictureBox pictureBox1;

    #endregion
  }
}

