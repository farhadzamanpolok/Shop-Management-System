using System;
using System.Windows.Forms;
using SMS_NT.DataAccess;
using SMS_NT.Entities;

namespace SMS_NT
{
    public partial class _1 : UserControl
    {
        public _1()
        {
            InitializeComponent();
        }

        private void Add_inventory_button_Click(object sender, EventArgs e)
        {
            if (pname_tbox.Text.Equals("") && Pprice_tbox.Text.Equals("") && Pavailable_tbox.Text.Equals(""))
            {
                return;
            }
            var product = new ProductInfo
            {
                Pname = pname_tbox.Text,
                Price = Pprice_tbox.Text,
                Quan = Int32.Parse(Pavailable_tbox.Text),
                Unit = Unit_textBox.Text
            };
            var pdata = new ProductData();
            if (pdata.Insert(product))
            {
                MessageBox.Show(@"Product Add Successfully");
            }
            else
            {
                MessageBox.Show(@"ERROR ! Try Again");
            }
        }
    }
}