using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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

        private Bitmap memoImg;
        CultureInfo culture = new CultureInfo("vi-VN");
        public frmPrint()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Print(panelPrint);
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtBranch.Text = branch;
            txtAddress.Text = address;
            txtTable.Text = table;
            txtDiscount.Text = discount;
            txtSum.Text = sum;
            txtTotal.Text = total;
            dgvItems.DataSource = listItem;
            dgvItems.Columns["id"].HeaderText = "ID";
            dgvItems.Columns["name"].HeaderText = "Name";
            dgvItems.Columns["price"].HeaderText = "Price";
            dgvItems.Columns["price"].ValueType = typeof(int);
            dgvItems.Columns["quantity"].HeaderText = "Quantity";

            // Set column widths\
            dgvItems.Columns["id"].Width = 50;
            dgvItems.Columns["name"].Width = 200; // Adjust width according to your requirement
            dgvItems.Columns["price"].Width = 100;
            dgvItems.Columns["quantity"].Width = 100;

            // Set text alignment to center for specific columns
            dgvItems.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvItems.Columns["price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvItems.Columns["quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvItems.Columns["price"].DefaultCellStyle.Format = "C0";
            dgvItems.Columns["price"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-VN");
        }

        ////////////////////////
        private void Print(Panel p)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = p;
            getPrintArea(p);
            previewDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            previewDialog.ShowDialog();
        }

        private void getPrintArea(Panel p)
        {
            memoImg = new Bitmap(p.Width, p.Height);
            p.DrawToBitmap(memoImg, new Rectangle(0,0, memoImg.Width, memoImg.Height));
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;
            //e.Graphics.DrawImage(memoImg, pageArea);
            e.Graphics.DrawImage(memoImg, (pageArea.Width/2)-(this.panelPrint.Width/2), (this.panelPrint.Location.Y) );
        }
    }
}
