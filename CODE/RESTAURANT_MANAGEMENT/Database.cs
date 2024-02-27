using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
class Database
    {
    public static SqlConnection Connection;
    public static bool Connect()
    {
        try
        {
            DotNetEnv.Env.TraversePath().Load();
            var host = Environment.GetEnvironmentVariable("HOST");
            var database = Environment.GetEnvironmentVariable("DATABASE");
            var user = Environment.GetEnvironmentVariable("USER");
            var password = Environment.GetEnvironmentVariable("PASSWORD");
            Connection = new SqlConnection($"Server={host}; Database={database}; uid={user}; pwd={password}");
            Connection.Open();
            Console.WriteLine("Successfully connect to database server");
            return true;
        }catch (Exception ex)
        {
            MessageBox.Show("Failed to connect database server:\n" + ex.ToString());
            Console.WriteLine("ERROR DATABASE: " + ex.ToString());
            return false;

        }
    }

    public static bool Close()
    {
        try
        {
            Connection.Close();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return false;
        }
    }


    public DataTable ExecuteQuery(String cmd, object[] paras = null)
    {
        DataTable data = null;
        try
        {
            if(paras != null)
            {
                Connect();
                SqlCommand command = new SqlCommand(cmd, Connection);
                String[] listPara = cmd.Split(' ');
                int i = 0;
                foreach (String s in listPara)
                {

                    if (s.Contains("@"))
                    {
                        command.Parameters.AddWithValue(s, paras[i]);
                        i++;
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                Close();

            }
        }catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.ToString()}");
        }


        return data;
    }


    public int ExecuteNonQuery(String cmd, object[] paras = null)
    {
        int data = 0;
        try
        {
            if (paras != null)
            {
                Connect();
                SqlCommand command = new SqlCommand(cmd, Connection);
                String[] listPara = cmd.Split(' ');
                int i = 0;
                foreach (String s in listPara)
                {

                    if (s.Contains("@"))
                    {
                        command.Parameters.AddWithValue(s, paras[i]);
                        i++;
                    }
                }
                data = command.ExecuteNonQuery();
                Close();

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.ToString()}");
        }


        return data;
    }


    public object ExecuteScalar(String cmd, object[] paras = null)
    {
        object data = 0;
        try
        {
            if (paras != null)
            {
                Connect();
                SqlCommand command = new SqlCommand(cmd, Connection);
                String[] listPara = cmd.Split(' ');
                int i = 0;
                foreach (String s in listPara)
                {

                    if (s.Contains("@"))
                    {
                        command.Parameters.AddWithValue(s, paras[i]);
                        i++;
                    }
                }
                data = command.ExecuteScalar();
                Close();

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.ToString()}");
        }


        return data;
    }
}
