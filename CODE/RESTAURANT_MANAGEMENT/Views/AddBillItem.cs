using RESTAURANT_MANAGEMENT.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANT_MANAGEMENT.Views
{
    public partial class AddBillItem : Form
    {
        public static event EventHandler isChosen;
        private int itemId;
        private string name;
        private string description;
        private int quantity;
        public int ItemId { get => itemId; set => itemId = value; }
        public string Name1 { get => name; set => name = value; }
        public string Description { get => description; set { description = value; }  }
        public int Quantity { get => quantity; set { quantity = value;  } }

        MenuItemModel.MenuItem item;
        
        CultureInfo culture = new CultureInfo("vi-VN");
        public AddBillItem()
        {
            InitializeComponent();

        }
        public AddBillItem(int id)
        {
            
            InitializeComponent();
            itemId = id;
            //MessageBox.Show(itemId.ToString());
            setValue();
        }

        public void setValue()
        {
            item = MenuItemController.getItem(ItemId);
            if(item != null)
            {
                txtItemName.Text = item.mi_name;
                txtItemPrice.Text = item.mi_price.ToString("C0", culture);
            }
        }


        private void btnMinus_Click(object sender, EventArgs e)
        {
            nudQuantity.Value -= 1;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            nudQuantity.Value += 1;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            BillController.AddBillDetail(UserHomePage.selectedBillId, itemId, (int)nudQuantity.Value);
            isChosen?.Invoke(this, e);
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
