using System;
using System.Windows.Forms;
using SMS_NT.DataAccess;
using SMS_NT.Entities;

namespace SMS_NT
{
    public partial class _5 : UserControl
    {
        public _5()
        {
            InitializeComponent();
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            if (UnametextBox.Text.Equals("") && PasswordtextBox.Text.Equals("")) return;
            string uname = UnametextBox.Text;
            string pass = PasswordtextBox.Text;
            try
            {
                if (new UserData().Insert(new UserInfo {Pass = pass, type = 1, Uname = uname}))
                {
                    MessageBox.Show(@"User reg successfull");
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"User already Exist");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}