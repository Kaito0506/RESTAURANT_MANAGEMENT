using Microsoft.Reporting.WinForms;
using RESTAURANT_MANAGEMENT.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RESTAURANT_MANAGEMENT.Views
{
    public partial class frmPrint : Form
    {
        public List<ShowBillModel.ShowBill> listDetail;
        public string discount;
        public string total;
        public string sum;
        public string date;
        public string address;
        public string table;
        public string branch;

        public frmPrint()
        {
            InitializeComponent();
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {

            date = DateTime.Now.ToString("dd/MM/yyyy");
            
            ReportParameter[] para =
            {
                new ReportParameter("pTotal", total),
                new ReportParameter("pDate", date),
                new ReportParameter("pSum", sum),
                new ReportParameter("pDiscount", discount),
                new ReportParameter("pAddress", address),
                new ReportParameter("pTable", table),
                new ReportParameter("pBranch", branch)
            };
            viewer.LocalReport.SetParameters(para);

            ReportDataSource reportDatasource = new ReportDataSource();
            reportDatasource.Name = "dsShowBill";
            reportDatasource.Value = listDetail;
            viewer.LocalReport.DataSources.Clear(); // Clear existing data sources
            viewer.LocalReport.DataSources.Add(reportDatasource);

            viewer.RefreshReport();
            //this.Controls.Add(viewer);
        }
    }
}
