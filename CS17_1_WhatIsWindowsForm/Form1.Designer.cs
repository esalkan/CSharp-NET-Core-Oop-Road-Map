﻿namespace CS17_1_WhatIsWindowsForm
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
            this.openSecondFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openSecondFormButton
            // 
            this.openSecondFormButton.Location = new System.Drawing.Point(86, 46);
            this.openSecondFormButton.Name = "openSecondFormButton";
            this.openSecondFormButton.Size = new System.Drawing.Size(130, 48);
            this.openSecondFormButton.TabIndex = 0;
            this.openSecondFormButton.Text = "Open Second Form";
            this.openSecondFormButton.UseVisualStyleBackColor = true;
            this.openSecondFormButton.Click += new System.EventHandler(this.openSecondFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 140);
            this.Controls.Add(this.openSecondFormButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openSecondFormButton;
    }
}

