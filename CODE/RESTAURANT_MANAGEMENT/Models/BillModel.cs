using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTAURANT_MANAGEMENT.Models
{
    internal class BillModel
    {
        public class Bill
        {

            public Bill() { 
            }

            public Bill(int bill_id, DateTime date, int status, float total, int customer_id)
            {
                this.bill_id = bill_id;
                this.date = date;
                this.status = status;
                this.total = total;

            }

            public Bill(DataRow r)
            {
                this.bill_id = (int)r["id"];
                this.date = (DateTime)r["checkin_date"];
                this.status = (int)r["status"];
                this.total = (float)Convert.ToDouble(r["total"]);

            }

            public int bill_id {  get; set; }
            public DateTime date { get; set; }

            public int status { get; set; }
            public float total { get; set; }

        }

    }
}
