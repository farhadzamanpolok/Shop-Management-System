using System;
using System.Data;
using System.Windows.Forms;
using SMS_NT.DataAccess;

namespace SMS_NT
{
    public partial class _3 : UserControl
    {
        public _3()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DataTable gtot = new TransData().GetGpriceByDate(dateTimePicker1.MinDate);
            label3.Text = gtot.Rows[0]["total"].ToString();
        }

        private void All_product_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new ProductData().GetProductInfoTable();
        }

        private void All_trans_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new TransData().GetTransInfoTable();
        }


        private void All_user_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new UserData().GetUserInfoTable();
        }
    }
}