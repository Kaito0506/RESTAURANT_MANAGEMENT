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
                        cmd = new SqlCommand("select * from ADMIN where phone = @username and password=@password ", Database.Connection);
                        break;
                    }
                case 1:
                    {
                        cmd = new SqlCommand("select * from USERS where phone = @username and password=@password ", Database.Connection);
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
                            admin.ad_id = reader.GetInt32(reader.GetOrdinal("id"));
                            admin.ad_name = reader["name"].ToString();
                            admin.ad_gender = reader.GetInt32(reader.GetOrdinal("gender"));
                            admin.ad_phone = reader["phone"].ToString();
                            admin.ad_password = reader["password"].ToString();
                            break;
                        }
                    case 1:
                        {
                            user.u_id = reader.GetInt32(reader.GetOrdinal("id"));
                            user.ro_id = reader.GetInt32(reader.GetOrdinal("id"));
                            user.rb_id = reader.GetInt32(reader.GetOrdinal("id"));
                            user.u_cccd = reader["cccd"].ToString();
                            user.u_name = reader["name"].ToString();
                            user.u_dob = reader.GetDateTime(reader.GetOrdinal("dob"));
                            user.u_gender = Convert.ToChar(reader["gender"].ToString());
                            user.u_address = reader["address"].ToString();
                            user.u_phone = reader["phone"].ToString();
                            user.u_password = reader["password"].ToString();
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

