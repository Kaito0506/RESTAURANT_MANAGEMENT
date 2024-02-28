using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTAURANT_MANAGEMENT.Models
{
    internal class TableModel
    {
       public class Table
        {
            public Table() { }
            public Table(int id, string display_name, int branch_id, int status)
            {
                this.id = id;
                this.display_name = display_name;
                this.branch_id = branch_id;
                this.status = status;
            }

            public Table(DataRow r)
            {
                this.id = (int)r["id"];
                this.display_name = (String)r["display_name"];
                this.branch_id = (int)r["branch_id"];
                this.status= (int)r["status"];
            }

            public int id { get; set; }
            public string display_name { get; set; }
            public int branch_id { get; set; }
            public int status { get; set; }


        }
    }
}
