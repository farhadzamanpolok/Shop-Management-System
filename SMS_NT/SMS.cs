using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SMS_NT.DataAccess;
using SMS_NT.Entities;

namespace SMS_NT
{
    public partial class Sms : Form
    {
        public Sms()
        {
            InitializeComponent();
            panel3.BringToFront();
            Log_Out_button.Enabled = false;
            button4.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _11.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _41.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _31.BringToFront();
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            panel4.BringToFront();
            button4.Show();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.MarqueeAnimationSpeed = 100;
            _11.Refresh();
            _21.Refresh();
            _31.Refresh();
            _41.Refresh();
            _51.Refresh();
            if (UnametextBox.Text.Equals("") && PasswordtextBox.Text.Equals(""))
            {
                progressBar1.Style = ProgressBarStyle.Blocks;
                progressBar1.Visible = false;
                return;
            }

            List<UserInfo> udata = new UserData().GetuserInfo(UnametextBox.Text, PasswordtextBox.Text);
            if (udata.Count == 0)
            {
                progressBar1.Style = ProgressBarStyle.Blocks;
                MessageBox.Show(@"Invalid User Name Or Password", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (udata[0].type.Equals(2))
            {
                panel1.BringToFront();
            }
            else
            {
                panel2.BringToFront();
            }
            Log_Out_button.Enabled = true;
            label6.Text = @"Wellcome, " + udata[0].Uname;
            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Visible = false;
        }

        private void Log_Out_button_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
            Log_Out_button.Enabled = false;
            UnametextBox.Text = null;
            PasswordtextBox.Text = null;
            label6.Text = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Hide();
            panel3.BringToFront();
        }
    }
}