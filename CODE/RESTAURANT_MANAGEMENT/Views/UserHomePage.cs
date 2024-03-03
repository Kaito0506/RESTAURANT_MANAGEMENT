using RESTAURANT_MANAGEMENT.Models;
using RESTAURANT_MANAGEMENT.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANT_MANAGEMENT.Views
{
    public partial class UserHomePage : Form
    {
        int selected_table;
        private Button previousButton = null;

        List<DetailCategoryModel.DetailCategory> detailCategories = DetailCategoryController.GetDetailCategories();
        List<MenuItemModel.MenuItem> menuItems = MenuItemController.GetMenuItems();


        public UserHomePage()
        {
            InitializeComponent();
            LoadTables();
            LoadDetailCategories();
            btnInside.BackColor = Color.Orange;
            flpTables.Enabled = true;
            lbBranchName.Text = loadBranchName();

        }


        private void LoadTables()
        {
            List<TableModel.Table> listTable = TableController.GetTableList();

            foreach (TableModel.Table table in listTable)
            {
                Button btn = new Button() { Width = TableController.width, Height = TableController.heihgt};
                btn.Text = table.display_name;

                btn.Click += Btn_Click;        
                btn.Tag = table;
                
                if (table.status == 0)
                {
                    btn.BackColor = Color.LightBlue;
                }
                else
                {
                    btn.BackColor = Color.Gray;
                }
                btn.TextAlign = ContentAlignment.MiddleCenter;



                flpTables.Controls.Add(btn);

            }
        }

        private void LoadDetailCategories()
        {
            cbCategory.Items.Clear();
            cbCategory.Items.Add("All");
            cbCategory.SelectedIndex = 0;

            if(detailCategories.Count > 0)
            {
                foreach(DetailCategoryModel.DetailCategory category in detailCategories)
                {
                    cbCategory.Items.Add(category.dc_name);
                }
            }
        }



        private void showSelectedTable (String tablename)
        {
            txtSelectedTable.Text = tablename;
            txtSelectedTable.TextAlign = HorizontalAlignment.Center;
        }
        private void showBill(int table_id)
        {
            lstItems.Items.Clear();
            int id = BillController.GetBillid(table_id);
            int discount = (int)txtDiscount.Value;
            UpdateBill(id, discount);
            List<ShowBillModel.ShowBill> listDetail = BillController.GetBillView(id);
            int i = 1;
            foreach (ShowBillModel.ShowBill item in listDetail)
            {
                ListViewItem lstItem = new ListViewItem(i.ToString());
                lstItem.SubItems.Add(item.name.ToString());
                lstItem.SubItems.Add(item.quantity.ToString());
                lstItem.SubItems.Add(item.price.ToString());
                i++;
                lstItems.Items.Add(lstItem);
            }


        }

        private void UpdateBill(int billId, int discount)
        {
            if (billId != -1)
            {
                BillController.UpdateBillTotal(billId);
                BillModel.Bill bill = BillController.GetBill(billId);
                if (bill != null)
                {
                    float total = bill.total;
                    txtSum.Text = total.ToString();
                    total *= (1 - (discount / 100.0f)); // Apply discount
                    txtTotal.Text = total.ToString();
                }
            }
            else
            {
                txtTotal.Text = "0";
                txtSum.Text = "0";
            }
        }

        private String loadBranchName()
        {
            String br_name = LoginController.GetUserBranchName(LoginController.GetUser().u_id);
            return br_name;
        }
        private void btnMerge_Click(object sender, EventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInside_Click(object sender, EventArgs e)
        {
            btnInside.BackColor = Color.Orange;
            flpTables.Enabled = true;
            btnAway.BackColor = Color.White;
        }

        private void btnAway_Click(object sender, EventArgs e)
        {
            btnInside.BackColor = Color.White;
            flpTables.Enabled = false;
            btnAway.BackColor = Color.Orange;
            txtSelectedTable.Text = "Take away";
            selected_table = -1;
            flpTables.Controls.Clear(); 
            LoadTables ();
        }



        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            TableModel.Table table = btn.Tag as TableModel.Table;

            // Reset border of previously clicked button
            if (previousButton != null && previousButton != btn)
            {
                previousButton.FlatStyle = FlatStyle.Flat;
                previousButton.FlatAppearance.BorderSize = 0;
            }

            if (table != null)
            {
                String table_name = table.display_name;
                showSelectedTable(table_name);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 5;
                selected_table = table.id;
            }

            // Update previousButton to the currently clicked button
            previousButton = btn;

            // Enable or disable buttons based on bill status
            BillModel.Bill b = BillController.GetBill(selected_table);
            if (b != null)
            {
                btnOrder.Enabled = false;
                btnPay.Enabled = true;
            }
            else
            {
                btnOrder.Enabled = true;
                btnPay.Enabled = false;
            }

            txtDiscount.Value = 0;
            showBill(table.id);
            this.Refresh();
        }


        private void UserHomePage_Load(object sender, EventArgs e)
        {

        }

        private void txtDiscount_ValueChanged(object sender, EventArgs e)
        {
            int discount = (int)txtDiscount.Value;


            int billId = BillController.GetBillid(selected_table);
            UpdateBill(billId, discount);
            
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // clear tables
            flpTables.Controls.Clear();
            BillController.PayBill(selected_table);
            // reload tables
            LoadTables();
            // update and show bill
            lstItems.Items.Clear();
            showBill(selected_table);

            btnPay.Enabled=false;
            btnOrder.Enabled=true;

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // clear tables
            flpTables.Controls.Clear();
            BillModel.Bill b = BillController.GetBill(selected_table);
            BillController.OrderBill(selected_table);

            // reload tables
            LoadTables();
            btnPay.Enabled = true;
            btnOrder.Enabled = false;
        }
    }
}
