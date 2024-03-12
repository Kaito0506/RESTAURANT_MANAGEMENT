using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

class RoleController {
    public static List<RoleModel.Role> GetRoles() 
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ROLE", Database.Connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<RoleModel.Role> res = new List<RoleModel.Role>();
            while (reader.Read())
            {
                RoleModel.Role role = new RoleModel.Role();
                role.r_id = reader.GetInt32(0);
                role.r_name = reader.GetString(1);
                role.r_salary = reader.GetDecimal(2);
                res.Add(role);
            }
            return res;
        } 
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    } 
}
