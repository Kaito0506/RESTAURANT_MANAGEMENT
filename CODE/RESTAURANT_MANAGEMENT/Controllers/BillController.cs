﻿using RESTAURANT_MANAGEMENT.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace RESTAURANT_MANAGEMENT.Controllers
{
    class BillController
    {
        public static int GetBillid(int table_id)
        {
            DataTable data = Database.ExecuteQuery("select * from BILL where status=0 and table_id=" + table_id);
            if(data.Rows.Count>0)
            {
                BillModel.Bill b = new BillModel.Bill(data.Rows[0]);
                return b.bill_id;
            }
            return -1; //no bill unpaid
        }

        public static BillModel.Bill GetBill(int table_id)
        {
            DataTable data = Database.ExecuteQuery("select * from BILL where status=0 and table_id=" + table_id);
            if (data.Rows.Count > 0)
            {
                BillModel.Bill b = new BillModel.Bill(data.Rows[0]);
                return b;
            }
            return null; //no bill unpaid
        }


        public static List<BillDetailModel.BillDetail> GetBillDetails(int bill_id)
        {
            List<BillDetailModel.BillDetail> listBillDetail = new List<BillDetailModel.BillDetail>();
            DataTable data = Database.ExecuteQuery("select * from BILL_DETAIL where bill_id=" + bill_id);
            if (data.Rows.Count>0)
            {
                foreach (DataRow row in data.Rows)
                {
                    BillDetailModel.BillDetail b = new BillDetailModel.BillDetail(row);
                    listBillDetail.Add(b);
                }
            }

            return listBillDetail;
        }

        public static List<ShowBillModel.ShowBill> GetBillView(int bill_id)
        {
            List<ShowBillModel.ShowBill> lstItem = new List<ShowBillModel.ShowBill>();
            DataTable data = Database.ExecuteQuery("select name, quantity, price from BILL_DETAIL as b join MENU_ITEM as m on b.id = m.id where bill_id=" + bill_id);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    ShowBillModel.ShowBill b = new ShowBillModel.ShowBill(row);
                    lstItem.Add(b);
                }
            }

            return lstItem;
        }

        public static void UpdateBillTotal(int bill_id) {
            try
            {
                Database.ExecuteNonQuery("EXEC CalculateBillTotal @b_id=" + bill_id);
                Console.WriteLine("Update bill successfully");
            }catch (Exception ex)
            {
                Console.WriteLine("Update error "+ ex.Message);
            }
        }

    }
}