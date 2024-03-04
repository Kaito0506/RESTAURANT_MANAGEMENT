using System;
using System.Data;
class MenuItemModel {
    public class MenuItem
    {
        public MenuItem() { }

        public MenuItem(DataRow r)
        {
            this.mi_id = (int)r["id"];
            this.mi_price = (decimal)r["price"];
            this.mi_image = r["img"].ToString();
            this.mi_desc = r["describe"].ToString();
            this.ca_id = (int)r["category_id"];
            this.mi_name = r["name"].ToString();
        }
        public int mi_id { get; set; }
        public int ca_id { get; set; }
        public string ca_name { get; set; }
        public string mi_name { get; set; }
        public string mi_desc { get; set; }
        public decimal mi_price { get; set; }
        public string mi_image { get; set; }
    }
}
