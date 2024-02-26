using System;

class UserModel
{
    public class User
    {
        public User() { }
        public int u_id { get; set; }
        public int ro_id { get; set; }
        public string u_cccd { get; set; }
        public string u_name { get; set; }
        public DateTime u_dob { get; set; }
        public char u_gender { get; set; }
        public string u_address { get; set; }
        public string u_phone { get; set; }
        public string u_password { get; set; }
    }
}
