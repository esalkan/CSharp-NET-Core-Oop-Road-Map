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
    public partial class HelloForm : Form
    {
        public HelloForm(string text)
        {
            InitializeComponent();
            // Eğer bir windows form elemanına dokunmamız gerekli ise, buradan veya daha aşağıda bu işlemleri yapabiliriz.
            // If we need to touch a windows form element, we can do it here or further down.
            label1.Text = text;
        }

        private void HelloForm_Load(object sender, EventArgs e)
        {

        }
    }
}
