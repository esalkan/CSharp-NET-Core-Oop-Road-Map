using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS17_1_WhatIsWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openSecondFormButton_Click(object sender, EventArgs e)
        {
            HelloWindowsForm helloWindowsForm = new HelloWindowsForm();
            helloWindowsForm.Show();
        }
    }
}
