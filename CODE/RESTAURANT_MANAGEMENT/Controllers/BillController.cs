using RESTAURANT_MANAGEMENT.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        public static DataTable GetBillView(int bill_id)
        {
            DataTable data = Database.ExecuteQuery("select b.id as detail_id, ROW_NUMBER() OVER(ORDER BY m.id) as id, name, quantity, price from BILL_DETAIL as b join MENU_ITEM as m on b.item_id = m.id where bill_id=" + bill_id);
            if (data.Rows.Count > 0)
            {
                return data;
            }
            return null;
        }

        public static List<ShowBillModel.ShowBill> GetPrintPage(int bill_id)
        {
            List<ShowBillModel.ShowBill> l = new List<ShowBillModel.ShowBill>();
            DataTable data = Database.ExecuteQuery("select ROW_NUMBER() OVER(ORDER BY m.id) as id, name, quantity, price from BILL_DETAIL as b join MENU_ITEM as m on b.item_id = m.id where bill_id=" + bill_id);
            if (data.Rows.Count > 0)
            {
                foreach(DataRow row in data.Rows)
                {
                    ShowBillModel.ShowBill b = new ShowBillModel.ShowBill(row);
                    l.Add(b);
                }
                return l;
            }
            return null;
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



        public static void PayBill(int table_id, float discount)
        {
            try
            {
                if (table_id == -1)
                {
                    Database.ExecuteNonQuery("PAY @table_id=null , @discount=" + discount);
                }
                else 
                {
                    Database.ExecuteNonQuery("PAY @table_id , @discount", new object[] {table_id, discount});

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

        public static void deleteBillDetail(int id)
        {
            try
            {
                Database.ExecuteNonQuery("DELETE FROM BILL_DETAIL WHERE id = " + id);
                Console.WriteLine("Delete item successflly");
            }
            catch( Exception e) {
                Console.WriteLine("Delete item FAILED" + e);
            }
        }

        public static void updateBillDetail(int id, int quantity)
        {
            try
            {
                Database.ExecuteNonQuery("UPDATE BILL_DETAIL SET quantity=" + quantity + " WHERE id = " + id);
                MessageBox.Show("Update successflly");
            }
            catch (Exception e)
            {
                MessageBox.Show("Update failed");
            }
        }
      
        public static decimal GetTotalRevenueTodayAll()
        {
            try
            {
                Database.Connect();
                SqlCommand cmd = new SqlCommand("select SUM(total) AS Total_day from BILL where checkin_date = convert (date, GETDATE()) and status = 1;", Database.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetDecimal(0);
                }
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }

        public static int GetTotalOrderTodayAll()
        {
            try
            {
                Database.Connect();
                SqlCommand cmd = new SqlCommand("select count(b.id) AS Order_Today from BILL b where b.checkin_date = convert (date, GETDATE()) and b.status = 1;", Database.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetInt32(0);
                }
                return 0;
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }

        public static decimal GetTotalRevenueThisWeekAll()
        {
            try
            {
                Database.Connect();
                SqlCommand cmd = new SqlCommand("SELECT SUM(total) AS This_Week FROM BILL WHERE checkin_date >= DATEADD(WEEK, DATEDIFF(WEEK, 0, GETDATE()), 0) AND checkin_date <= DATEADD(DAY, 6, DATEADD(WEEK, DATEDIFF(WEEK, 0, GETDATE()), 0)) AND status = 1;", Database.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetDecimal(0);
                }
                return 0;
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }

        public static int GetTotalOrderThisWeekAll()
        {
            try
            {
                Database.Connect();
                SqlCommand cmd = new SqlCommand("SELECT count(b.id) AS Order_Week FROM BILL b WHERE checkin_date >= DATEADD(WEEK, DATEDIFF(WEEK, 0, GETDATE()), 0) AND checkin_date <= DATEADD(DAY, 6, DATEADD(WEEK, DATEDIFF(WEEK, 0, GETDATE()), 0)) AND b.status = 1;", Database.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetInt32(0);
                }
                return 0;
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }

        public static decimal GetTotalRevenueThisMonthAll()
        {
            try
            {
                Database.Connect();
                SqlCommand cmd = new SqlCommand("SELECT SUM(total) As This_month FROM BILL WHERE YEAR(checkin_date) = YEAR(GETDATE()) AND MONTH(checkin_date) = MONTH(GETDATE()) AND status = 1;", Database.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetDecimal(0);
                }
                return 0;
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }

        public static int GetTotalOrderThisMonthAll()
        {
            try
            {
                Database.Connect();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(b.id) As Order_Month FROM BILL b WHERE YEAR(checkin_date) = YEAR(GETDATE()) AND MONTH(checkin_date) = MONTH(GETDATE()) AND b.status = 1;", Database.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetInt32(0);
                }
                return 0;
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }

        public static decimal GetTotalRevenueTodayByBranch(int bid)
        {
            try
            {
                Database.Connect();
                SqlCommand cmd = new SqlCommand($"select SUM(total) AS Total_day from BILL b join TABLES t on b.table_id = t.id where b.checkin_date = convert (date, GETDATE()) and b.status = 1 and t.branch_id = {bid};", Database.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetDecimal(0);
                }
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }

        public static int GetTotalOrderTodayByBranch(int bid)
        {
            try
            {
                Database.Connect();
                SqlCommand cmd = new SqlCommand($"select SUM(total) AS Total_day from BILL b join TABLES t on b.table_id = t.id where b.checkin_date = convert (date, GETDATE()) and b.status = 1 and t.branch_id = {bid};", Database.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetInt32(0);
                }
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }

        public static decimal GetTotalRevenueThisWeekByBranch(int bid)
        {
            try
            {
                Database.Connect();
                SqlCommand cmd = new SqlCommand($"SELECT SUM(total) AS This_Week FROM BILL b join TABLES t on b.table_id = t.id WHERE checkin_date >= DATEADD(WEEK, DATEDIFF(WEEK, 0, GETDATE()), 0) AND checkin_date <= DATEADD(DAY, 6, DATEADD(WEEK, DATEDIFF(WEEK, 0, GETDATE()), 0)) AND b.status = 1 AND t.branch_id = {bid};", Database.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetDecimal(0);
                }
                return 0;
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }

        public static int GetTotalOrderThisWeekByBranch(int bid)
        {
            try
            {
                Database.Connect();
                SqlCommand cmd = new SqlCommand($"SELECT count(b.id) AS Order_Week FROM BILL b join TABLES t on b.table_id = t.id WHERE checkin_date >= DATEADD(WEEK, DATEDIFF(WEEK, 0, GETDATE()), 0) AND checkin_date <= DATEADD(DAY, 6, DATEADD(WEEK, DATEDIFF(WEEK, 0, GETDATE()), 0)) AND b.status = 1 AND t.branch_id = {bid};", Database.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetInt32(0);
                }
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }

        public static decimal GetTotalRevenueThisMonthByBranch(int bid)
        {
            try
            {
                Database.Connect();
                SqlCommand cmd = new SqlCommand($"SELECT SUM(total) As This_month FROM BILL b join TABLES t on b.table_id = t.id WHERE YEAR(checkin_date) = YEAR(GETDATE()) AND MONTH(checkin_date) = MONTH(GETDATE()) AND b.status = 1 AND t.branch_id = {bid};", Database.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetDecimal(0);
                }
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }

        public static int GetTotalOrderThisMonthByBranch(int bid)
        {
            try
            {
                Database.Connect();
                SqlCommand cmd = new SqlCommand($"SELECT COUNT(b.id) As Order_Month FROM BILL b join TABLES t on b.table_id = t.id WHERE YEAR(checkin_date) = YEAR(GETDATE()) AND MONTH(checkin_date) = MONTH(GETDATE()) AND b.status = 1 AND t.branch_id = {bid};", Database.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetInt32(0);
                }
                return 0;
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }

        public static DataTable GetRevenueChartAll()
        {
            string query = "SELECT FORMAT(DATEADD(MONTH, number, '1900-01-01'), 'MMMM') AS Month," +
                           "COALESCE(SUM(b.total), 0) AS Revenue FROM master..spt_values " +
                           "LEFT JOIN BILL b ON MONTH(b.checkin_date) = DATEPART(MONTH, DATEADD(MONTH, number, '1900-01-01')) " +
                           "AND b.status = 1 AND YEAR(b.checkin_date) = YEAR(GETDATE()) WHERE type = 'P' AND number BETWEEN 0 AND 11" +
                           "GROUP BY FORMAT(DATEADD(MONTH, number, '1900-01-01'), 'MMMM') ORDER BY MIN(DATEPART(MONTH, DATEADD(MONTH, number, '1900-01-01')));";
            try
            {
                Database.Connect();
                SqlCommand cmd = new SqlCommand(query, Database.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public static DataTable GetRevenueChartByBranch(int bid)
        {
            string query = "SELECT FORMAT(DATEADD(MONTH, number, '1900-01-01'), 'MMMM') AS Month," +
                           $"COALESCE(SUM(CASE WHEN t.branch_id = {bid} THEN b.total ELSE 0 END), 0) AS Revenue FROM master..spt_values " +
                           "LEFT JOIN BILL b ON MONTH(b.checkin_date) = DATEPART(MONTH, DATEADD(MONTH, number, '1900-01-01')) " +
                           "AND b.status = 1 AND YEAR(b.checkin_date) = YEAR(GETDATE())" +
                           $"LEFT JOIN TABLES t ON b.table_id = t.id WHERE type = 'P' AND number BETWEEN 0 AND 11 " +
                           "GROUP BY FORMAT(DATEADD(MONTH, number, '1900-01-01'), 'MMMM') ORDER BY MIN(DATEPART(MONTH, DATEADD(MONTH, number, '1900-01-01')));";
            try
            {
                Database.Connect();
                SqlCommand cmd = new SqlCommand(query, Database.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public static DataTable GetTrendingItemAll()
        {
            string query = "WITH ItemPercentages AS (SELECT m.name, COUNT(bd.item_id) * 100.0 / (SELECT COUNT(*) FROM BILL_DETAIL) AS percentage, " +
                           "ROW_NUMBER() OVER (ORDER BY COUNT(bd.item_id) * 100.0 / (SELECT COUNT(*) FROM BILL_DETAIL) DESC) AS rn FROM MENU_ITEM m " +
                           "LEFT JOIN BILL_DETAIL bd ON m.id = bd.item_id GROUP BY m.name) SELECT name as Item FROM ItemPercentages " +
                           "WHERE rn <= CASE WHEN (SELECT COUNT(*) FROM ItemPercentages) * 0.3 > 5 THEN 5 ELSE (SELECT COUNT(*) FROM ItemPercentages) * 0.3 END;";
            try
            {
                Database.Connect();
                SqlCommand cmd = new SqlCommand(query, Database.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;

            } catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public static DataTable GetTrendingItemByBranch(int bid)
        {
            string query = "WITH ItemPercentages AS (SELECT m.name, COUNT(bd.item_id) * 100.0 / NULLIF((SELECT COUNT(*) " +
                           $"FROM BILL WHERE table_id IN (SELECT id FROM TABLES WHERE branch_id = {bid})), 0) AS percentage, " +
                           "ROW_NUMBER() OVER (ORDER BY COUNT(bd.item_id) * 100.0 / NULLIF((SELECT COUNT(*) FROM BILL " +
                           $"WHERE table_id IN (SELECT id FROM TABLES WHERE branch_id = {bid})), 0) DESC) AS rn FROM MENU_ITEM m " +
                           "LEFT JOIN BILL_DETAIL bd ON m.id = bd.item_id LEFT JOIN BILL b ON bd.bill_id = b.id WHERE b.table_id " +
                           $"IN (SELECT id FROM TABLES WHERE branch_id = {bid}) GROUP BY m.name)" +
                           "SELECT name as Item FROM ItemPercentages WHERE rn <= CASE WHEN (SELECT COUNT(*) FROM ItemPercentages) * 0.3 > 5 " +
                           "THEN 5 ELSE (SELECT COUNT(*) FROM ItemPercentages) * 0.3 END;";
            try
            {
                Database.Connect();
                SqlCommand cmd = new SqlCommand(query, Database.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
