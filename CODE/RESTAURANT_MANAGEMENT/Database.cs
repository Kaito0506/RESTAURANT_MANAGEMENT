using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANT_MANAGEMENT
{
    internal class Database
    {
        public static SqlConnection Connection;
        public static bool Connect()
        {
            try
            {
                Connection = new SqlConnection("Data Source = KAITO; Initial Catalog = RESTAURANT_MANAGEMENT; Integrated Security = True;");
                Connection.Open();
                Console.WriteLine("Successfully connect to database server");
                return true;
            }catch (Exception ex)
            {
                MessageBox.Show("Failed to connect database server");
                Console.WriteLine("ERROR DATABASE: " + ex.ToString());
                return false;

            }
        }

        public static bool Close()
        {
            try
            {
                Connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
