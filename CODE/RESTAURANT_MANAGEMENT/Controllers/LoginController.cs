using System.Data.SqlClient;
using System.Data;
using System;

class LoginController
{
    private static AdminModel.Admin admin = new AdminModel.Admin();
    private static UserModel.User user = new UserModel.User();

    public SqlDataReader Login(int index, String username, String password)
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand();
            switch (index)
            {
                //preresent Admin role
                case 0:
                    {
                        cmd = new SqlCommand("select * from ADMIN where ad_phone = @username and ad_password=@password ", Database.Connection);
                        break;
                    }
                case 1:
                    {
                        cmd = new SqlCommand("select * from USERS where u_phone = @username and u_password=@password ", Database.Connection);
                        break;
                    }
                default:
                    return null;
            }
            cmd.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar, 10)).Value = username;
            cmd.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar, 20)).Value = password;
            SqlDataReader reader = cmd.ExecuteReader();
     
            if (reader.Read())
            {
                switch (index)
                {
                    case 0:
                        {
                            admin.ad_id = reader.GetInt32(reader.GetOrdinal("ad_id"));
                            admin.ad_name = reader["ad_name"].ToString();
                            admin.ad_gender = reader.GetInt32(reader.GetOrdinal("ad_gender"));
                            admin.ad_phone = reader["ad_phone"].ToString();
                            admin.ad_password = reader["ad_password"].ToString();
                            break;
                        }
                    case 1:
                        {
                            user.u_id = reader.GetInt32(reader.GetOrdinal("u_id"));
                            user.ro_id = reader.GetInt32(reader.GetOrdinal("ro_id"));
                            user.rb_id = reader.GetInt32(reader.GetOrdinal("rb_id"));
                            user.u_cccd = reader["u_cccd"].ToString();
                            user.u_name = reader["u_name"].ToString();
                            user.u_dob = reader.GetDateTime(reader.GetOrdinal("u_dob"));
                            user.u_gender = Convert.ToChar(reader["u_gender"].ToString());
                            user.u_address = reader["u_address"].ToString();
                            user.u_phone = reader["u_phone"].ToString();
                            user.u_password = reader["u_password"].ToString();
                            break;
                        }
                    default:
                        {
                            return null;
                        }
                }
            }
            return reader;
        } catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }

    public AdminModel.Admin GetAdmin()
    {
        return admin;
    }

    public UserModel.User GetUser()
    {
        return user;
    }
}

