using System.Data.SqlClient;
using System.Data;
using System;
using Sprache;
using System.Windows.Forms;

class LoginController
{
    private static UserModel.User user = new UserModel.User();
    public SqlDataReader Login(String username, String password)
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("select * from USERS where phone = @username and password=@password ", Database.Connection);
            cmd.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar, 10)).Value = username;
            cmd.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar, 20)).Value = password;
            SqlDataReader reader = cmd.ExecuteReader();
     
            if (reader.Read())
            {
                user.u_id = reader.GetInt32(reader.GetOrdinal("id"));
                user.ro_id = reader.GetInt32(reader.GetOrdinal("id"));
                user.u_cccd = reader["cccd"].ToString();
                user.u_name = reader["name"].ToString();
                user.u_dob = reader.GetDateTime(reader.GetOrdinal("dob"));
                user.u_gender = Convert.ToChar(reader["gender"].ToString());
                user.u_address = reader["address"].ToString();
                user.u_phone = reader["phone"].ToString();
                user.u_password = reader["password"].ToString();
            }
            return reader;
        } catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }


    public static UserModel.User GetUser()
    {
        return user;
    }




    public static int GetUserBranchId(int user_id)
    {
        int bi = 0;
        object obj = Database.ExecuteScalar("EXEC getBranchID @user_id", new object[] { user_id });
        bi = Convert.ToInt32(obj);
            
        return bi;
    }

    public static String GetUserBranchName(int user_id)
    {
        String name = "";
        object ojb = Database.ExecuteScalar("EXEC getBranchName @user_id", new object[] { user_id });
        name = ojb.ToString();
        return name;
    }

    public static string GetUserName()
    {
        return user.u_name;
    }
}

