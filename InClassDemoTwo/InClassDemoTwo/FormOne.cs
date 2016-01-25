using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassDemoTwo
{
    public partial class FormOne : Form
    {
        Int64 clicks = 0;

        public FormOne()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clicks++;
            myFirstLabel.Text = "Clicks: " + clicks.ToString();
            picboxFirstPicture.Visible = true;
        }

        private void picboxFirstPicture_Click(object sender, EventArgs e)
        {
            picboxFirstPicture.Visible = false;
        }

        private void myFirstLabel_Click(object sender, EventArgs e)
        {
            myFirstLabel.Text = string.Empty;
            clicks = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye!");
            this.Close();
        }
    }
}
