﻿using RESTAURANT_MANAGEMENT.Models;
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
            lblUserName.Text = LoginController.GetUserName();
            
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
            lstItems.Rows.Clear();
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
            Image imgDelete = Image.FromFile("..\\..\\images\\delete.png");
            DataGridViewImageColumn btnDelete = new DataGridViewImageColumn()
            {
                Image = imgDelete,
                Name = "delete",
                HeaderText = ""
            };
            // Remove the "delete" button column if it exists
            if (lstItems.Columns.Contains("delete"))
            {
                lstItems.Columns.Remove("delete");
            }
            lstItems.Columns.Add(btnDelete);
            if (listDetail!=null)
            {
                customGridView();
                lstItems.Rows.Clear();
                foreach (DataRow item in listDetail.Rows)
                {

                    int rowIndex = lstItems.Rows.Add(item["detail_id"], item["id"], item["name"], item["quantity"], item["price"]);
                    
                }


            }
            //lstItems.CellContentClick += lstItems_CellContentClick;

        }

        private void customGridView()
        {
            

            // Set text alignment to center for specific columns
            lstItems.Columns["idCol"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            lstItems.Columns["priceCol"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            lstItems.Columns["quantityCol"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            lstItems.Columns["priceCol"].DefaultCellStyle.Format = "C0";
            lstItems.Columns["priceCol"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-VN");
            
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
            txtSelectedTable.Text = "";
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
            if (selectedBillId > 0)
            {

                frmPrint printPage = new frmPrint();
                printPage.sum = txtSum.Text;
                printPage.total = txtTotal.Text;
                printPage.discount = txtDiscount.Text;
                printPage.table = txtSelectedTable.Text;
                printPage.branch = lbBranchName.Text;
                printPage.address = BranchController.getAddress(lbBranchName.Text);                
                printPage.listDetail = BillController.GetPrintPage(selectedBillId);         
                printPage.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose a bill to print", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void setButtonStatus()
        //{
        //    if (selectedBillId > 0)
        //    {
        //        btnPay.Enabled = true;
        //        btnOrder.Enabled = false;
        //        btnPrint.Enabled = true;
        //    }
        //}

        private void lstItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0 && e.ColumnIndex== lstItems.Columns["delete"].Index)
            {
                int id = Convert.ToInt32(lstItems.Rows[e.RowIndex].Cells["itemCol"].Value);
                // Display a confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    BillController.deleteBillDetail(id);
                    showBill(selectedTable);
                    //MessageBox.Show(item_id.ToString());
                }
                
            }
        }

        private void lstItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex == lstItems.Columns["quantityCol"].Index)
            {

                try
                {
                    int quantity = Convert.ToInt32(lstItems.Rows[e.RowIndex].Cells["quantityCol"].Value);
                    int id = Convert.ToInt32(lstItems.Rows[e.RowIndex].Cells["itemCol"].Value);
                    if (quantity > 0)
                    {

                        BillController.updateBillDetail(id, quantity);
                        showBill(selectedTable);
                    }
                    else
                    {
                        MessageBox.Show("Please enter positive number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        showBill(selectedTable);
                    }
                }
                catch(Exception err)
                {
                    MessageBox.Show("Please enter valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    showBill(selectedTable);
                }

            }
        }

        private void btnLofout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do do want to logout", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Hide();
                login login = new login();
                login.Closed += (s, args) => this.Close();
                login.ShowDialog();
            }

        }
    }
}
