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

    public static int GetUserIdByPhone(string phone)
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("SELECT id FROM USERS WHERE phone=@phone", Database.Connection);
            cmd.Parameters.AddWithValue("@phone", phone);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return reader.GetInt32(0);
            }
            return -1;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return -1;
        }
    }

    public static bool UpdateUserDetailsById(UserModel.User user)
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("UPDATE USERS SET role_id=@role, cccd=@cccd, name=@name, dob=@dob, gender=@gender, address=@address, phone=@phone, password=@password WHERE id=@id", Database.Connection);
            SqlCommand cmd2 = new SqlCommand("UPDATE ASSIGN SET branch_id=@branch WHERE u_id=@id", Database.Connection);
            cmd.Parameters.AddWithValue("@role", user.ro_id);
            cmd.Parameters.AddWithValue("@cccd", user.u_cccd);
            cmd.Parameters.AddWithValue("@name", user.u_name);
            cmd.Parameters.AddWithValue("@dob", user.u_dob);
            cmd.Parameters.AddWithValue("@gender", user.u_gender);
            cmd.Parameters.AddWithValue("@address", user.u_address);
            cmd.Parameters.AddWithValue("@phone", user.u_phone);
            cmd.Parameters.AddWithValue("@password", user.u_password);
            cmd.Parameters.AddWithValue("@id", user.u_id);
            cmd2.Parameters.AddWithValue("@branch", user.b_id);
            cmd2.Parameters.AddWithValue("@id", user.u_id);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            return true;
        } catch (Exception e)
        {
            MessageBox.Show("Update user failed");
            MessageBox.Show(e.Message.ToString());
            Console.WriteLine(e);
            return false;
        }
    }

    public static bool CreateUser(UserModel.User user)
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("INSERT INTO USERS (role_id, cccd, name, dob, gender, address, phone, password) VALUES (@role, @cccd, @name, @dob, @gender, @address, @phone, @password)", Database.Connection);
            SqlCommand cmd2 = new SqlCommand("INSERT INTO ASSIGN (u_id, branch_id) VALUES (@id, @branch)", Database.Connection);
            cmd.Parameters.AddWithValue("@role", user.ro_id);
            cmd.Parameters.AddWithValue("@cccd", user.u_cccd);
            cmd.Parameters.AddWithValue("@name", user.u_name);
            cmd.Parameters.AddWithValue("@dob", user.u_dob);
            cmd.Parameters.AddWithValue("@gender", user.u_gender);
            cmd.Parameters.AddWithValue("@address", user.u_address);
            cmd.Parameters.AddWithValue("@phone", user.u_phone);
            cmd.Parameters.AddWithValue("@password", user.u_password);
            cmd.ExecuteNonQuery();
            int id = GetUserIdByPhone(user.u_phone);
            cmd2.Parameters.AddWithValue("@id", id);
            cmd2.Parameters.AddWithValue("@branch", user.b_id);
            cmd2.ExecuteNonQuery();
            return true;
        } catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }
    
    public static bool DeleteUserById(int id)
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("DELETE FROM USERS WHERE id=@id", Database.Connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }
}
