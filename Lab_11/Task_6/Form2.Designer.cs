﻿using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Task_6
{
    partial class ParametersForm
    {
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sizeTrackBar1 = new System.Windows.Forms.TrackBar();
            this.sizeTrackBar2 = new System.Windows.Forms.TrackBar();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Location = new System.Drawing.Point(50, 35);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(190, 35);
            this.button.TabIndex = 0;
            this.button.Text = "Колір заднього фону";
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(50, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Стиль шрифту";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(50, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Колір шрифту";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(264, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ширина";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(264, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Висота";
            // 
            // sizeTrackBar1
            // 
            this.sizeTrackBar1.Location = new System.Drawing.Point(264, 55);
            this.sizeTrackBar1.Maximum = 1200;
            this.sizeTrackBar1.Minimum = 300;
            this.sizeTrackBar1.Name = "sizeTrackBar1";
            this.sizeTrackBar1.Size = new System.Drawing.Size(200, 45);
            this.sizeTrackBar1.TabIndex = 4;
            this.sizeTrackBar1.Value = 300;
            // 
            // sizeTrackBar2
            // 
            this.sizeTrackBar2.Location = new System.Drawing.Point(264, 119);
            this.sizeTrackBar2.Maximum = 1200;
            this.sizeTrackBar2.Minimum = 300;
            this.sizeTrackBar2.Name = "sizeTrackBar2";
            this.sizeTrackBar2.Size = new System.Drawing.Size(200, 45);
            this.sizeTrackBar2.TabIndex = 5;
            this.sizeTrackBar2.Value = 300;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(274, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Змінити розмір";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ParametersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 227);
            this.Controls.Add(this.button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.sizeTrackBar1);
            this.Controls.Add(this.sizeTrackBar2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ParametersForm";
            this.Text = "Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar sizeTrackBar2;
        private System.Windows.Forms.TrackBar sizeTrackBar1;
        private System.Windows.Forms.Label label1;
    }
}

