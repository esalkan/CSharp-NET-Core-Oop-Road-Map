using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS17_02_DataTransferBetweenForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtMessage.Text = "Enter Text Here!";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openSecondFormButton_Click(object sender, EventArgs e)
        {
            string txtMessageValue = txtMessage.Text;

            HelloForm helloForm = new HelloForm(txtMessageValue);
            helloForm.Show();
        }

        private void txtMessage_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender; 
            T1.Text = string.Empty;
        }
    }
}
