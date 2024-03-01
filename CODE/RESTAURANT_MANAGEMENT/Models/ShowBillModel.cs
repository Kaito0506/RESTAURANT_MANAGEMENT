using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTAURANT_MANAGEMENT.Models
{
    class ShowBillModel
    {
        public class ShowBill
        {
            public ShowBill() { }
            public ShowBill(String name, int q, float price)
            {
                this.name = name;
                this.quantity = q;
                this.price = price;
            }

            public ShowBill(DataRow r)
            {
                this.name = (String)r["name"];
                this.quantity = (int)r["quantity"];
                this.price = (float)Convert.ToDouble(r["price"]);
            }
            public String name { get; set; }
            public int quantity { get; set; }
            public float price { get; set; }
        }



    }
}
