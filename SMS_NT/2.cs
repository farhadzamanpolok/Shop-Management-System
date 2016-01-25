using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SMS_NT.DataAccess;
using SMS_NT.Entities;

namespace SMS_NT
{
    public partial class _2 : UserControl
    {
        private readonly ProductData product = new ProductData();


        public _2()
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

        private void PnameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PquanComboBox.Items.Clear();
            List<ProductInfo> info = product.GetProductInfoByName(PnameComboBox.SelectedItem.ToString());
            label5.Text = info[0].Unit;
            for (int i = 0; i < info[0].Quan; i++)
            {
                PquanComboBox.Items.Add(i);
            }
            if (info[0].Quan.Equals(1))
            {
                PquanComboBox.Enabled = false;
            }
            else
            {
                PquanComboBox.Enabled = true;
            }
            PquanComboBox.SelectedIndex = 0;
        }

        private void PquanComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ProductInfo> info = product.GetProductInfoByName(PnameComboBox.SelectedItem.ToString());
            int price = int.Parse(info[0].Price);
            total_label.Text = (price*(PquanComboBox.SelectedIndex)).ToString();
        }

        private void Buy_button_Click(object sender, EventArgs e)
        {
            List<ProductInfo> info = product.GetProductInfoByName(PnameComboBox.SelectedItem.ToString());
            if (info[0].Quan.Equals(1))
            {
                return;
            }
            if (PquanComboBox.SelectedIndex == 0)
            {
                return;
            }
            int quan = info[0].Quan - int.Parse(PquanComboBox.SelectedItem.ToString());
            string iname = PnameComboBox.SelectedItem.ToString();
            int id = info[0].Id;
            int price = int.Parse(total_label.Text);
            string date = dateTimePicker1.MinDate.ToString();


            if (product.UpdateQuan(info[0].Price, id, quan, info[0].Unit) &&
                new TransData().Insert(new TransInfo
                {
                    Date = date,
                    Pname = iname,
                    Quan = int.Parse(PquanComboBox.SelectedItem.ToString()),
                    Tprice = price
                }))
            {
                MessageBox.Show(@"Transection successfull");
                int index = PquanComboBox.SelectedIndex;
                PquanComboBox.Items.Clear();
                for (int i = 1; i < (info[0].Quan - index); i++)
                {
                    PquanComboBox.Items.Add(i);
                }

                PnameComboBox.SelectedIndex = 0;
                return;
            }
            MessageBox.Show(@"Transection Unsuccessful");

            PquanComboBox.SelectedIndex = 0;
        }
    }
}