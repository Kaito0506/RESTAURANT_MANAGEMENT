using System;
class MenuItemModel {
    public class MenuItem
    {
        public MenuItem() { }
        public int mi_id { get; set; }
        public int ca_id { get; set; }
        public string ca_name { get; set; }
        public string mi_name { get; set; }
        public string mi_desc { get; set; }
        public decimal mi_price { get; set; }
        public string mi_image { get; set; }
    }
}
