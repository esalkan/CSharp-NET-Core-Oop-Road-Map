namespace CS17_02_DataTransferBetweenForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.openSecondFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter Some Text in Below Text Box.\r\nLütfen Aşağıdaki Metin Kutusuna Bir Me" +
    "tin Girin.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(34, 59);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(231, 43);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.Text = "\r\nEnter Some Text";
            this.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMessage.Enter += new System.EventHandler(this.txtMessage_Enter);
            // 
            // openSecondFormButton
            // 
            this.openSecondFormButton.Location = new System.Drawing.Point(34, 108);
            this.openSecondFormButton.Name = "openSecondFormButton";
            this.openSecondFormButton.Size = new System.Drawing.Size(231, 54);
            this.openSecondFormButton.TabIndex = 2;
            this.openSecondFormButton.Text = "Open Second Windows Form\r\nIkinci Windows Form\'u Aç";
            this.openSecondFormButton.UseVisualStyleBackColor = true;
            this.openSecondFormButton.Click += new System.EventHandler(this.openSecondFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 169);
            this.Controls.Add(this.openSecondFormButton);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button openSecondFormButton;
    }
}

