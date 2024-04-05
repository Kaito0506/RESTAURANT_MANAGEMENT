using System;
using System.Data;
class BranchModel
{
    public class Branch
    {
        public Branch() { }
        public int b_id { get; set; }
        public string b_name { get; set; }
        public string b_address { get; set; }
        public string b_phone { get; set;}
        public string b_img { get; set; }
        public decimal b_revenue { get; set; }
        public int b_employee { get; set; }
    }
}