using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

class UserController
{
    public static List<String> GetManagers() {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("Select u.name from USERS u join ROLE r on u.role_id = r.id where r.role_name= N'Quản lý';", Database.Connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<String> resultUser = new List<String>();

            while (reader.Read())
            {
                resultUser.Add(reader.GetString(0));
            }

            return resultUser;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }
}
