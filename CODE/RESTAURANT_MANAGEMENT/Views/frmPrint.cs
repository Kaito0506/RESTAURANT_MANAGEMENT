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
    public partial class frmPrint : Form
    {
        public string branch, address, table;
        public string sum, discount, total;
        public DataTable listItem = new DataTable();

        CultureInfo culture = new CultureInfo("vi-VN");
        public frmPrint()
        {
            InitializeComponent();
        }


        private void frmPrint_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("dd/mm/yyyy");
            txtBranch.Text = branch;
            txtAddress.Text = address;
            txtTable.Text = table;
            txtDiscount.Text = discount;
            txtSum.Text = sum;
            txtTotal.Text = total;
            dgvItems.DataSource = listItem;
            dgvItems.Columns["name"].HeaderText = "Name";
            dgvItems.Columns["price"].HeaderText = "Price";
            dgvItems.Columns["price"].ValueType = typeof(int);
            dgvItems.Columns["quantity"].HeaderText = "Quantity";



        }
    }
}
