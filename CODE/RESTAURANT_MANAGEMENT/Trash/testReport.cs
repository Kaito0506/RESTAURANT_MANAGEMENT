using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANT_MANAGEMENT.Views
{
    public partial class testReport : Form
    {
        public testReport()
        {
            InitializeComponent();
        }

        private void testReport_Load(object sender, EventArgs e)
        {

            //RESTAURANT_MANAGEMENTDataSet dataset = new RESTAURANT_MANAGEMENTDataSet();
            DataTable bill = new DataTable();
            DataTable details = new DataTable();
            Database.Connect();
            SqlCommand command = new SqlCommand("select * from BILL_DETAIL", Database.Connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(details);

            command = new SqlCommand("select * from BILL", Database.Connection);
            adapter = new SqlDataAdapter(command);
            adapter.Fill(bill);

            //details = Database.ExecuteQuery("select * from BILL_DETAIL");
            if (details.Rows.Count > 0 )
            {
                MessageBox.Show("not null");
            }
            else
            {
                MessageBox.Show("null");
            }


            ReportDataSource reportDatasource = new ReportDataSource("bills", bill);
            ReportDataSource reportDatasource2 = new ReportDataSource("details", details);

            reportViewer1.LocalReport.DataSources.Clear(); // Clear existing data sources
            reportViewer1.LocalReport.DataSources.Add(reportDatasource);
            reportViewer1.LocalReport.DataSources.Add(reportDatasource2);
            reportViewer1.LocalReport.Refresh();
           // reportViewer1.LocalReport.ReportEmbeddedResource = "RESTAURANT_MANAGEMENT.views.Report1.rdlc";
            this.reportViewer1.RefreshReport();
        }
    }
}
