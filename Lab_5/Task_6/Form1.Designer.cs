using System.Drawing;

namespace Task_6
{
    partial class Form1
    {
      
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1 = new System.Windows.Forms.PictureBox();
        private System.Windows.Forms.PictureBox pictureBox2 = new System.Windows.Forms.PictureBox();
        private System.Windows.Forms.PictureBox pictureBox3 = new System.Windows.Forms.PictureBox();
        private System.Windows.Forms.PictureBox pictureBox4 = new System.Windows.Forms.PictureBox();
        private System.Windows.Forms.PictureBox pictureBox5 = new System.Windows.Forms.PictureBox();
        private System.Windows.Forms.PictureBox pictureBox6 = new System.Windows.Forms.PictureBox();
        private System.Windows.Forms.PictureBox pictureBox7 = new System.Windows.Forms.PictureBox();
        private System.Windows.Forms.PictureBox pictureBox8 = new System.Windows.Forms.PictureBox();

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }
        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();

            this.pictureBox1.Image = Image.FromFile(@"C:\Users\ASUS\RiderProjects\Lab_5\Task_6\img1.jpg");
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Location = new System.Drawing.Point(50, 100);
            this.pictureBox1.Size = new System.Drawing.Size(125, 150);
            
            this.pictureBox2.Image = Image.FromFile(@"C:\Users\ASUS\RiderProjects\Lab_5\Task_6\img2.jpg");
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.Location = new System.Drawing.Point(190, 175);
            this.pictureBox2.Size = new System.Drawing.Size(125, 75);
            
            this.pictureBox3.Image = Image.FromFile(@"C:\Users\ASUS\RiderProjects\Lab_5\Task_6\img3.jpg");
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.Location = new System.Drawing.Point(330, 100);
            this.pictureBox3.Size = new System.Drawing.Size(125, 150);
            
            this.pictureBox4.Image = Image.FromFile(@"C:\Users\ASUS\RiderProjects\Lab_5\Task_6\img4.jpg");
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.Location = new System.Drawing.Point(470, 175);
            this.pictureBox4.Size = new System.Drawing.Size(125, 75);
            
            this.pictureBox5.Image = Image.FromFile(@"C:\Users\ASUS\RiderProjects\Lab_5\Task_6\img5.jpg");
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.Location = new System.Drawing.Point(610, 100);
            this.pictureBox5.Size = new System.Drawing.Size(125, 150);
            
            this.pictureBox6.Image = Image.FromFile(@"C:\Users\ASUS\RiderProjects\Lab_5\Task_6\img1.jpg");
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.Location = new System.Drawing.Point(50, 300);
            this.pictureBox6.Size = new System.Drawing.Size(125, 150);
            
            this.pictureBox7.Image = Image.FromFile(@"C:\Users\ASUS\RiderProjects\Lab_5\Task_6\img5.jpg");
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.Location = new System.Drawing.Point(185, 300);
            this.pictureBox7.Size = new System.Drawing.Size(400, 150);
            
            this.pictureBox8.Image = Image.FromFile(@"C:\Users\ASUS\RiderProjects\Lab_5\Task_6\img3.jpg");
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.Location = new System.Drawing.Point(600, 375);
            this.pictureBox8.Size = new System.Drawing.Size(125, 75);
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.ResumeLayout(false);

        }

    }
}