using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANT_MANAGEMENT.Models
{
    public class ShowBillModel
    {
        public class ShowBill
        {
            public ShowBill() { }


            public ShowBill(int id, String name, int q, float price)
            {
                this.id= id;
                this.name = name;
                this.quantity = q;
                this.price = price;

            }

            public ShowBill(DataRow r)
            {

                //object idValue = r["id"];
                //Type idType = idValue.GetType();
                //MessageBox.Show("Data Type of 'id': " + idType.FullName);
                this.id = (long)r["id"];
                this.name = (String)r["name"];
                this.quantity = (int)r["quantity"];
                this.price = (float)Convert.ToDouble(r["price"]);
            }
            public long id { get; set; }
            public string name { get; set; }
            public int quantity { get; set; }
            public float price { get; set; }
        }



    }
}
