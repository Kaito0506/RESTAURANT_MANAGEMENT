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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            LoadBranches();
            cbbBranch.SelectedIndex = 0;
            LoadDashboardDetails();
            LoadRevenueChart();
            LoadTrendingItems();
        }

        private void LoadDashboardDetails()
        {
            lbRevToday.Text = BillController.GetTotalRevenueTodayAll().ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
            lbOrderToday.Text = BillController.GetTotalOrderTodayAll().ToString();
            lbRevWeek.Text = BillController.GetTotalRevenueThisWeekAll().ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
            lbOrderWeek.Text = BillController.GetTotalOrderThisWeekAll().ToString();
            lbRevMonth.Text = BillController.GetTotalRevenueThisMonthAll().ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
            lbOrderMonth.Text = BillController.GetTotalOrderThisMonthAll().ToString();
        }

        private void LoadRevenueChart()
        {
            revChart.Titles.Clear();
            revChart.DataSource = BillController.GetRevenueChartAll();
            revChart.Series["Revenue"].XValueMember = "Month";
            revChart.Series["Revenue"].YValueMembers = "Revenue";
            revChart.Titles.Add("Revenue Chart");
        }

        private void LoadTrendingItems()
        {
            dgvItem.DataSource = BillController.GetTrendingItemAll();
            if (dgvItem.Columns["Item"] != null)
            {
                dgvItem.Columns["Item"].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void LoadDashBoardDetailsBranch(int bid)
        {
            if (bid == 0)
            {
                LoadDashboardDetails();
                LoadRevenueChart();
                LoadTrendingItems();
                return;
            }
            lbRevToday.Text = BillController.GetTotalRevenueTodayByBranch(bid).ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
            lbOrderToday.Text = BillController.GetTotalOrderTodayByBranch(bid).ToString();
            lbRevWeek.Text = BillController.GetTotalRevenueThisWeekByBranch(bid).ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
            lbOrderWeek.Text = BillController.GetTotalOrderThisWeekByBranch(bid).ToString();
            lbRevMonth.Text = BillController.GetTotalRevenueThisMonthByBranch(bid).ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
            lbOrderMonth.Text = BillController.GetTotalOrderThisMonthByBranch(bid).ToString();
            revChart.Titles.Clear();
            revChart.DataSource = BillController.GetRevenueChartByBranch(bid);
            revChart.Series["Revenue"].XValueMember = "Month";
            revChart.Series["Revenue"].YValueMembers = "Revenue";
            revChart.Titles.Add("Revenue Chart");
            dgvItem.DataSource = BillController.GetTrendingItemByBranch(bid);
            if (dgvItem.Columns["Item"] != null)
            {
                dgvItem.Columns["Item"].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void LoadBranches()
        {
            List<BranchModel.Branch> branches = BranchController.GetBranches();
            cbbBranch.DisplayMember = "b_name";
            cbbBranch.ValueMember = "b_id";
            cbbBranch.Items.Clear();
            if (branches == null)
            {
                return;
            }
            cbbBranch.Items.Add(new BranchModel.Branch { b_id = 0, b_name = "All" });
            foreach (BranchModel.Branch branch in branches)
            {
                cbbBranch.Items.Add(branch);
            }
        }

        private void cbbBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbbBranch.SelectedItem != null && cbbBranch.SelectedItem is BranchModel.Branch selectedBranch)
            {
                LoadDashBoardDetailsBranch(selectedBranch.b_id);
            }
        }
    }
}
