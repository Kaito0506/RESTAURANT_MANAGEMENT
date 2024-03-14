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
using System.IO;
using System.Globalization;
using System.Xml.Serialization;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.CompilerServices;
using static RESTAURANT_MANAGEMENT.Models.TableModel;
using static RESTAURANT_MANAGEMENT.Models.BillModel;

namespace RESTAURANT_MANAGEMENT.Views
{
    public partial class UserHomePage : Form
    {
        public static int selectedTable=0;
        private Button previousButton = null;
        private CultureInfo culture = new CultureInfo("vi-VN");
        public static int selectedItemId;
        public static int selectedBillId;
        List<DetailCategoryModel.DetailCategory> detailCategories = DetailCategoryController.GetDetailCategories();
        List<MenuItemModel.MenuItem> menuItems = MenuItemController.GetMenuItems();
        List<MenuItemModel.MenuItem> filteredItems;
        
        public UserHomePage()
        {
            InitializeComponent();
            LoadTables();
            LoadDetailCategories();
            btnInside.BackColor = Color.Orange;
            flpTables.Enabled = true;
            lbBranchName.Text = loadBranchName();
            LoadMenuItems();
            AddBillItem.isChosen += refreshBillItem;
            
            //MessageBox.Show(selectedTable.ToString());

        }


        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void LoadTables()
        {
            flpTables.Controls.Clear();
            //cbTables.Items.Clear();
            List<TableModel.Table> listTable = TableController.GetTableList();
            cbTables.DataSource = listTable;
            cbTables.DisplayMember = "display_name";
            cbTables.ValueMember = "id";
            foreach (TableModel.Table table in listTable)
            {
                Button btn = new Button() { Width = TableController.width, Height = TableController.heihgt};
                btn.Text = table.display_name;
                // show table in cbox

                //cbTables.Items.Add(table.display_name);

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
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void LoadDetailCategories()
        {
            cbCategory.Items.Clear();
            cbCategory.Items.Add("Tất cả");
            cbCategory.SelectedIndex = 0;

            if(detailCategories.Count > 0)
            {
                foreach(DetailCategoryModel.DetailCategory category in detailCategories)
                {
                    cbCategory.Items.Add(category.dc_name);
                }
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void LoadMenuItems()
        {
            flpItems.Controls.Clear();
            List<BillItem> listBillItems = new List<BillItem>();
            //filteredItems = new List<MenuItemModel.MenuItem>(menuItems);
            //MessageBox.Show(filteredItems[0].mi_name);
            foreach(MenuItemModel.MenuItem item in menuItems)
            {
                BillItem i = new BillItem();
                i.Id = item.mi_id;
                i.Name = item.mi_name;
                i.Price = (float)item.mi_price;
                i.Image = GetImage(item.mi_image);
                listBillItems.Add(i);
                // add click handler
                flpItems.Controls.Add(i);

            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private Image GetImage(string imageName)
        {
            try
            {
                string fullPath = Path.GetFullPath(Path.Combine("..", "..", "images", "foods", imageName));

                if (File.Exists(fullPath))
                {
                    return Image.FromFile(fullPath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string defaultImagePath = Path.GetFullPath(Path.Combine("..", "..", "images", "foods", "food.png"));
            return Image.FromFile(defaultImagePath);
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void showSelectedTable (String tablename)
        {
            txtSelectedTable.Text = tablename;
            txtSelectedTable.TextAlign = HorizontalAlignment.Center;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        public void showBill(int? table_id)
        {
            lstItems.DataSource = null;
            int id;
            if(table_id>0)
            {
                id = BillController.GetBillid(table_id);
            }
            else
            {
                id = BillController.GetBillid(-1);
            }
            selectedBillId = id;
            Console.WriteLine("Show bill " + id.ToString());
            int discount = (int)txtDiscount.Value;
            UpdateBill(id, discount);
            
            DataTable listDetail = BillController.GetBillView(id);
            
            if (listDetail!=null)
            {
                lstItems.DataSource = listDetail;
                customtaGridView();
                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                btnCol.Name = "editBtn";
                btnCol.HeaderText = "Action";
                btnCol.Text = "Edit";
                btnCol.UseColumnTextForButtonValue = true;
                lstItems.Columns.Add(btnCol);
            }


        }

        private void customtaGridView()
        {
            
            lstItems.Columns["id"].HeaderText = "ID";
            lstItems.Columns["id"].ReadOnly = true;
            lstItems.Columns["name"].HeaderText = "Name";
            lstItems.Columns["name"].ReadOnly = true;
            lstItems.Columns["price"].HeaderText = "Price";
            lstItems.Columns["price"].ValueType = typeof(int);
            lstItems.Columns["price"].ReadOnly = true;
            lstItems.Columns["quantity"].HeaderText = "Quantity";

            // Set column widths\
            lstItems.Columns["id"].Width = 50;
            lstItems.Columns["name"].Width = 200; // Adjust width according to your requirement
            lstItems.Columns["price"].Width = 100;
            lstItems.Columns["quantity"].Width = 100;

            // Set text alignment to center for specific columns
            lstItems.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            lstItems.Columns["price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            lstItems.Columns["quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            lstItems.Columns["price"].DefaultCellStyle.Format = "C0";
            lstItems.Columns["price"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-VN");
            
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void UpdateBill(int billId, int discount)
        {
            //MessageBox.Show("table: " + selectedTable.ToString() + "bill: "+selectedBillId.ToString());
            if (billId != -1)
            {
                BillController.UpdateBillTotal(billId);
                BillModel.Bill bill = BillController.GetBill(selectedTable);
                //
                if (bill != null)
                {
                    float total = bill.total;
                    txtSum.Text = total.ToString("C0", culture);
                    total *= (1 - (discount / 100.0f)); // Apply discount
                    txtTotal.Text = total.ToString("C0", culture);
                }
            }
            else
            {
                txtTotal.Text = "0";
                txtSum.Text = "0";
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void ApplyFilter()
        {
           
            string category = cbCategory.Text.ToLower();
            string searchText = txtFindName.Text.ToLower();
            if (category == "tất cả" && string.IsNullOrEmpty(searchText))
            {
                filteredItems = new List<MenuItemModel.MenuItem>(menuItems);
                return;
            }
            else
            {
                filteredItems = new List<MenuItemModel.MenuItem>();
                foreach (MenuItemModel.MenuItem item in menuItems)
                {
                    if (category == "tất cả")
                    {
                        if (RemoveVietnameseSigns(item.mi_name.ToLower()).Contains(RemoveVietnameseSigns(searchText)))
                        {
                            filteredItems.Add(item);
                        }
                    }
                    else
                    {
                        if (item.ca_name.ToLower() == category && string.IsNullOrEmpty(searchText))
                        {
                            filteredItems.Add(item);
                        }
                        else if (item.ca_name.ToLower() == category && RemoveVietnameseSigns(item.mi_name.ToLower()).Contains(RemoveVietnameseSigns(searchText)))
                        {
                            filteredItems.Add(item);
                        }
                    }
                }
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private string RemoveVietnameseSigns(string str)
        {
            string[] vietnameseSigns = new string[]
            {
        "aAeEoOuUiIdDyY",
        "áàạảãâấầậẩẫăắằặẳẵ",
        "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
        "éèẹẻẽêếềệểễ",
        "ÉÈẸẺẼÊẾỀỆỂỄ",
        "óòọỏõôốồộổỗơớờợởỡ",
        "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
        "úùụủũưứừựửữ",
        "ÚÙỤỦŨƯỨỪỰỬỮ",
        "íìịỉĩ",
        "ÍÌỊỈĨ",
        "đ",
        "Đ",
        "ýỳỵỷỹ",
        "ÝỲỴỶỸ"
            };

            StringBuilder sb = new StringBuilder(str);

            for (int i = 1; i < vietnameseSigns.Length; i++)
            {
                for (int j = 0; j < vietnameseSigns[i].Length; j++)
                {
                    sb.Replace(vietnameseSigns[i][j], vietnameseSigns[0][i - 1]);
                }
            }

            return sb.ToString();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void UpdateUIMenuItem()
        {
            ApplyFilter();
            if (filteredItems!=null)
            {
                flpItems.Controls.Clear();
                foreach (MenuItemModel.MenuItem item in filteredItems)
                {
                    BillItem i = new BillItem();
                    i.Id = item.mi_id;
                    i.Name = item.mi_name;
                    i.Price = (float)item.mi_price;
                    i.Image = GetImage(item.mi_image);
                    flpItems.Controls.Add(i);
                }
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////
        private String loadBranchName()
        {
            String br_name = LoginController.GetUserBranchName(LoginController.GetUser().u_id);
            return br_name;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnMerge_Click(object sender, EventArgs e)
        {
            int table1 = selectedTable;
            int table2 = (int)cbTables.SelectedValue;
            //MessageBox.Show(table2.ToString());
            int bill1 = BillController.GetBillid(table1);
            int bill2 = BillController.GetBillid(table2);
            if(bill2 != -1)
            {
                MessageBox.Show("Please choose another table to change", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (bill1 == -1)
            {
                MessageBox.Show("Please choose a table to change", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    TableController.ChangeTable(table1, table2);
                    //Console.WriteLine("success change");
                    LoadTables();
                }catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUIMenuItem();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnInside_Click(object sender, EventArgs e)
        {
            btnInside.BackColor = Color.Orange;
            flpTables.Enabled = true;
            btnAway.BackColor = Color.White;
            selectedTable = 0;
            LoadTables();
            btnMerge.Enabled = true;
            cbTables.Enabled = true;
            cbTables.Visible = true;
            btnMerge.Visible = true;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnAway_Click(object sender, EventArgs e)
        {
            //LoadTables();
            flpTables.Controls.Clear();
            btnInside.BackColor = Color.White;
            flpTables.Enabled = false;
            btnAway.BackColor = Color.Orange;
            btnMerge.Enabled = false;
            cbTables.Enabled = false;
            txtSelectedTable.Text = "Take away";
            selectedTable = -1;
            cbTables.Visible = false;
            btnMerge.Visible = false;

            //flpTables.Controls.Clear(); 
            //LoadTables();
            int id = BillController.GetBillid(-1);
            selectedBillId = id;
            if(id == -1)
            {
                btnOrder.Enabled = true;
                btnPay.Enabled = false;
            }
            else
            {
                btnOrder.Enabled = false;
                btnPay.Enabled = true;
            }
            showBill(-1);
            UpdateBill(id, (int)txtDiscount.Value);


        }

        //////////////////////////////////////////////////////////////////////////////////////////////////
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
                selectedTable = table.id;
            }

            // Update previousButton to the currently clicked button
            previousButton = btn;

            // Enable or disable buttons based on bill status
            BillModel.Bill b = BillController.GetBill(selectedTable);
            if (b != null)
            {
                btnOrder.Enabled = false;
                btnPay.Enabled = true;
                selectedBillId = b.bill_id;
                BillModel.Bill bill = BillController.GetBill(selectedTable);


            }
            else
            {
                btnOrder.Enabled = true;
                btnPay.Enabled = false;
            }

            txtDiscount.Value = 0;
            UpdateBill(selectedBillId, (int)txtDiscount.Value);
            showBill(table.id);
            this.Refresh();
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void txtDiscount_ValueChanged(object sender, EventArgs e)
        {
            int discount = (int)txtDiscount.Value;


            int billId = BillController.GetBillid(selectedTable);
            UpdateBill(billId, discount);
            
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnPay_Click(object sender, EventArgs e)
        {
            // clear tables
            flpTables.Controls.Clear();
            float discount = (float)txtDiscount.Value;
            BillController.PayBill(selectedTable, discount);
            // reload tables
            if(selectedTable!=-1)
            {
                LoadTables();
            }

            // update and show bill
            lstItems.DataSource = null;
            showBill(selectedTable);
            txtDiscount.Value = 0;
            btnPay.Enabled=false;
            btnOrder.Enabled=true;

        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (selectedTable>0) 
            {
                // clear tables
                flpTables.Controls.Clear();
                BillController.OrderBill(selectedTable);
                selectedBillId = BillController.GetBillid(selectedTable);

                UpdateBill(selectedBillId, (int)txtDiscount.Value);
                // reload tables
                LoadTables();
                btnPay.Enabled = true;
                btnOrder.Enabled = false;
            }
            else if(selectedTable==-1)
            {
                BillController.OrderBill(-1);
                
                selectedBillId = BillController.GetBillid(-1);
                Console.WriteLine("selected table = -1 order bill with table=null bill id=" + selectedBillId.ToString());
                UpdateBill(selectedBillId, (int)txtDiscount.Value);

                btnPay.Enabled = true;
                btnOrder.Enabled = false;

            }
            else if (selectedTable==0)
            {
                MessageBox.Show("Please choose a table or take away mode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnPay.Enabled = false;
            }

        }
        //////////////////////////////////////////////////////////////////////////////////////////////////

        private void txtFindName_TextChanged(object sender, EventArgs e)
        {
            UpdateUIMenuItem();
        }

        private void refreshBillItem(object sender, EventArgs e)
        {
            showBill(selectedTable);
            UpdateBill(selectedBillId, (int)txtDiscount.Value);
        }

        private void bntPrint_Click(object sender, EventArgs e)
        {
            frmPrint printPage = new frmPrint();
            printPage.branch = lbBranchName.Text;
            printPage.sum = txtSum.Text;
            printPage.total = txtTotal.Text;
            printPage.discount = txtDiscount.Text;
            printPage.table = txtSelectedTable.Text;
            printPage.listItem = Database.ExecuteQuery("select ROW_NUMBER() OVER(ORDER BY m.id) as id, name, quantity, price from BILL_DETAIL as b join MENU_ITEM as m on b.item_id = m.id where bill_id=" + selectedBillId);
            printPage.ShowDialog();
        }
    }
}
