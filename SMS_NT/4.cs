using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SMS_NT.DataAccess;
using SMS_NT.Entities;

namespace SMS_NT
{
    public partial class _4 : UserControl
    {
        private readonly ProductData product = new ProductData();

        public _4()
        {
            InitializeComponent();
            foreach (ProductInfo i in product.GetProductInfo())
            {
                PnameComboBox.Items.Add(i.Pname);
            }
            PnameComboBox.SelectedIndex = 0;
        }

        public override void Refresh()
        {
            base.Refresh();
            PnameComboBox.Items.Clear();
            foreach (ProductInfo i in product.GetProductInfo())
            {
                PnameComboBox.Items.Add(i.Pname);
            }
            PnameComboBox.SelectedIndex = 0;
        }

        private void Remove_Product_Button_Click(object sender, EventArgs e)
        {
            List<ProductInfo> id = new ProductData().GetProductInfoByName(PnameComboBox.SelectedItem.ToString());
            if (new ProductData().Delete(id[0].Id))
            {
                MessageBox.Show(@"Product Remove Successfull");
                Refresh();
                return;
            }
            MessageBox.Show(@"Product Remove Unsuccessful ");
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            List<ProductInfo> id = new ProductData().GetProductInfoByName(PnameComboBox.SelectedItem.ToString());
            string price = Price_textBox.Text;
            int quan = int.Parse(Quan_textBox.Text);
            string unit = Unit_textBox.Text;
            if (new ProductData().UpdateQuan(price, id[0].Id, quan, unit))
            {
                MessageBox.Show(@"Product Update Successfull");
                return;
            }
            MessageBox.Show(@"Product Update Unsuccessful");
        }

        private void PnameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ProductInfo> info = product.GetProductInfoByName(PnameComboBox.SelectedItem.ToString());
            Price_textBox.Text = info[0].Price;
            Unit_textBox.Text = info[0].Unit;
            Quan_textBox.Text = info[0].Quan.ToString();
        }

        private void PnameComboBox_Click(object sender, EventArgs e)
        {
            PnameComboBox.Items.Clear();
            foreach (ProductInfo i in product.GetProductInfo())
            {
                PnameComboBox.Items.Add(i.Pname);
            }
            PnameComboBox.SelectedIndex = 0;
        }
    }
}