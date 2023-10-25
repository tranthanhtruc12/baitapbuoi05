using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Text;

using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void txtYourName_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(txtYourName, "You must enter Your Name!");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            string s;
            int age;
            s = "Your name is: " + txtYourName.Text + "\n";
            age = DateTime.Now.Year - Convert.ToInt32(txtYear.Text);
            s = s + "Age: " + age.ToString();
            MessageBox.Show(s);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo
                , MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txtYear.Clear();
            txtYourName.Focus();
        }
    }
}