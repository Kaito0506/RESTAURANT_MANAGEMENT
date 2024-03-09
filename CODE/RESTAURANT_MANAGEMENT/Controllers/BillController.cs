using RESTAURANT_MANAGEMENT.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RESTAURANT_MANAGEMENT.Controllers
{
    class BillController
    {
        public static int GetBillid(int? table_id)
        {
            DataTable data;
            if (table_id == -1)
            {
                data = Database.ExecuteQuery("getBillId @table_id=null");
            }
            else
            {
                data = Database.ExecuteQuery("getBillId @table_id=" + table_id);
            }
            if(data.Rows.Count>0)
            {
                BillModel.Bill b = new BillModel.Bill(data.Rows[0]);
                return b.bill_id;
            }
            return -1; //no bill unpaid
        }

        public static BillModel.Bill GetBill(int? table_id)
        {
            DataTable data;
            if (table_id == -1)
            {
                data = Database.ExecuteQuery("getBillId @table_id=null");
                //MessageBox.Show("get bill from null");
            }
            else
            {
                data = Database.ExecuteQuery("getBillId @table_id=" + table_id);
            }
            if (data.Rows.Count > 0)
            {
                BillModel.Bill b = new BillModel.Bill(data.Rows[0]);
                //MessageBox.Show(b.bill_id.ToString());
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
            DataTable data = Database.ExecuteQuery("select name, quantity, price from BILL_DETAIL as b join MENU_ITEM as m on b.item_id = m.id where bill_id=" + bill_id);
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



        public static void PayBill(int table_id)
        {
            try
            {
                if (table_id == -1)
                {
                    Database.ExecuteNonQuery("PAY @table_id=null");
                }
                else 
                {
                    Database.ExecuteNonQuery("PAY @table_id=" + table_id);

                }
                

                Console.WriteLine("Pay successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Pay error " + ex.Message);
            }
        }

        public static void OrderBill(int? table_id)
        {
            try
            {
                if(table_id == -1)
                {
                    Database.ExecuteNonQuery("EXEC ORDER_BILL @table_id=null");
                    Console.WriteLine("Order successfully with null table");
                    //MessageBox.Show("order null success");
                }
                else
                {
                    Database.ExecuteNonQuery("ORDER_BILL @table_id=" + table_id);
                    Console.WriteLine("Order successfully");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Order error " + ex.Message);
                //MessageBox.Show("order failed");
            }
        }

        public static void AddBillDetail(int bill_id, int item_id, int quantity)
        {
            try
            {
                Database.ExecuteNonQuery("EXEC addBillDetail @bill_id  , @item_id , @quantity ", new object[] { bill_id, item_id, quantity });
                Console.WriteLine("Success insert bill detail");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error when inserting bill detail" + ex);
            }

        }

    }
}
