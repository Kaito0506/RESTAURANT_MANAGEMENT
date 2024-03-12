using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

class UserController
{
    public static List<UserModel.User> GetUsersByRoleAndBranch(int role, int branch) {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("Select u.id, u.name from USERS u JOIN ASSIGN a on a.u_id = u.id where u.role_id=@role AND a.branch_id=@branch;", Database.Connection);
            cmd.Parameters.AddWithValue("@role", role);
            cmd.Parameters.AddWithValue("@branch", branch);

            SqlDataReader reader = cmd.ExecuteReader();
            
            List<UserModel.User> res = new List<UserModel.User>();
            while (reader.Read())
            {
                UserModel.User user = new UserModel.User();
                user.u_id = reader.GetInt32(0);
                user.u_name = reader.GetString(1);
                res.Add(user);
            }
            return res;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }

    public static UserModel.User GetUserDetailsById(int id)
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("SELECT u.id, u.name, u.cccd, r.role_name, b.name, u.dob, u.gender, u.address, u.phone, u.password FROM USERS u JOIN ASSIGN a on a.u_id = u.id JOIN RESTAURANT_BRANCH b on b.id = a.branch_id JOIN ROLE r on r.id = u.role_id WHERE u.id=@id", Database.Connection);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                UserModel.User user = new UserModel.User();
                user.u_id = reader.GetInt32(0);
                user.u_name = reader.GetString(1);
                user.u_cccd = reader.GetString(2);
                user.ro_name = reader.GetString(3);
                user.b_name = reader.GetString(4);
                user.u_dob = reader.GetDateTime(5);
                user.u_gender = reader.GetString(6)[0];
                user.u_address = reader.GetString(7);
                user.u_phone = reader.GetString(8);
                user.u_password = reader.GetString(9);
                return user;
            }
            return null;
        } catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }
}
