using System;
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
            MessageBox.Show("Failed to connect database server");
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
}
