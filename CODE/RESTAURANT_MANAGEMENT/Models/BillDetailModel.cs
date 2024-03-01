using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTAURANT_MANAGEMENT.Models
{
    class BillDetailModel
    {
        public class BillDetail
        {
            public BillDetail() { }
            public BillDetail(int id, int bill_id, int item_id, int quantity)
            {
                this.id = id;
                this.bill_id = bill_id;
                this.item_id = item_id;
                this.quantity = quantity;
            }

            public BillDetail(DataRow r)
            {
                this.id = (int)r["id"];
                this.bill_id = (int)r["bill_id"];
                this.item_id = (int)r["item_id"];
                this.quantity = (int)r["quantity"];
            }

            public int id { get; set; }
            public int bill_id { get; set; }
            public int item_id { get; set; }
            public int quantity { get; set;
            }
        }
    }
}
