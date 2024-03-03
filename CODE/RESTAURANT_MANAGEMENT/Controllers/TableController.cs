using RESTAURANT_MANAGEMENT.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANT_MANAGEMENT.Controllers
{
    internal class TableController
    {
        public static int heihgt = 100, width = 100;
        LoginController lg = new LoginController();
        public UserModel.User user;
        public static int   current_u_id =  LoginController.GetUser().u_id;
        public static List<TableModel.Table> GetTableList()
        {
            List<TableModel.Table> list = new List<TableModel.Table>();

            try
            {
                Database.Connect();
                DataTable listTable = new DataTable();
                int branch_id = LoginController.GetUserBranchId(current_u_id);
                listTable = Database.ExecuteQuery("EXEC getTableWithBranch @branch_id", new object[] { branch_id });

                foreach(DataRow row in listTable.Rows)
                {
                    TableModel.Table table = new TableModel.Table(row);
                    list.Add(table);
                }
                return list;

            }
            catch (Exception ex)
            {   
                Console.WriteLine("Error getting tables: " + ex.Message);
                return null;
            }

        }
    }
}
