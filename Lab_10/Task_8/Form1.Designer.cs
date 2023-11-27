using System.Drawing;
using System.Windows.Forms;

namespace Task_8
{
   partial class Form1
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
           this.components = new System.ComponentModel.Container();
           this.statusStrip1 = new System.Windows.Forms.StatusStrip();
           this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
           this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
           this.textBox1 = new System.Windows.Forms.TextBox();
           this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
           this.statusStrip1.SuspendLayout();
           this.SuspendLayout();
           // 
           // statusStrip1
           // 
           this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripStatusLabel1, this.toolStripStatusLabel2 });
           this.statusStrip1.Location = new System.Drawing.Point(0, 428);
           this.statusStrip1.Name = "statusStrip1";
           this.statusStrip1.Size = new System.Drawing.Size(800, 22);
           this.statusStrip1.TabIndex = 0;
           this.statusStrip1.Text = "statusStrip1";
           // 
           // toolStripStatusLabel1
           // 
           this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
           this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
           this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
           // 
           // toolStripStatusLabel2
           // 
           this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
           this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
           this.toolStripStatusLabel2.Padding = new System.Windows.Forms.Padding(600, 0, 0, 0);
           this.toolStripStatusLabel2.Size = new System.Drawing.Size(600, 17);
           this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
           // 
           // textBox1
           // 
           this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
           this.textBox1.Location = new System.Drawing.Point(118, 108);
           this.textBox1.Name = "textBox1";
           this.textBox1.Size = new System.Drawing.Size(187, 31);
           this.textBox1.TabIndex = 1;
           this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
           // 
           // notifyIcon1
           // 
           this.notifyIcon1.Text = "Task_8";
           this.notifyIcon1.Visible = true;
           notifyIcon1.Icon = SystemIcons.Application;

           ContextMenuStrip contextMenu = new ContextMenuStrip();
           ToolStripMenuItem showMenuItem = new ToolStripMenuItem("Показати");
           ToolStripMenuItem hideMenuItem = new ToolStripMenuItem("Сховати");

           showMenuItem.Click += ShowMenuItem_Click;
           hideMenuItem.Click += HideMenuItem_Click;

           contextMenu.Items.Add(showMenuItem);
           contextMenu.Items.Add(hideMenuItem);

           notifyIcon1.ContextMenuStrip = contextMenu;
           // 
           // Form1
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(800, 450);
           this.Controls.Add(this.textBox1);
           this.Controls.Add(this.statusStrip1);
           this.Name = "Form1";
           this.Text = "Form1";
           this.statusStrip1.ResumeLayout(false);
           this.statusStrip1.PerformLayout();
           this.ResumeLayout(false);
           this.PerformLayout();
       }

       private System.Windows.Forms.NotifyIcon notifyIcon1;


       private System.Windows.Forms.TextBox textBox1;


       private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;


       private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;


       private System.Windows.Forms.StatusStrip statusStrip1;


       #endregion
   }
}
