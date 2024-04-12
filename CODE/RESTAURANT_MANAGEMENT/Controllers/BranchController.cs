using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

class BranchController {
    public static List<BranchModel.Branch> GetBranches()
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM RESTAURANT_BRANCH", Database.Connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<BranchModel.Branch> res = new List<BranchModel.Branch>();
            while (reader.Read())
            {
                BranchModel.Branch branch = new BranchModel.Branch();
                branch.b_id = reader.GetInt32(0);
                branch.b_name = reader.GetString(1);
                branch.b_address = reader.GetString(2);
                branch.b_phone = reader.GetString(3);
                branch.b_img = reader.GetString(4);
                res.Add(branch);
            }
            return res;
        } 
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }

    public static int GetBranchIdByName(string name)
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand($"SELECT id FROM RESTAURANT_BRANCH WHERE name=N'{name}'", Database.Connection);
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

    public static string getAddress(string branchName)
    {
        //MessageBox.Show(branchName);
        DataTable data = Database.ExecuteQuery("select address from RESTAURANT_BRANCH where name = '" + branchName + "'");
        string add = null;
        if (data.Rows.Count > 0)
        {
            foreach (DataRow row in data.Rows)
            {
                add =  (string)row["address"];
            }
            return add;
        }
        return add;
    }

    public bool DeleteBranch(int id)
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("DELETE FROM RESTAURANT_BRANCH WHERE id = @id", Database.Connection);
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

    public bool UpdateBranch(BranchModel.Branch branch)
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("UPDATE RESTAURANT_BRANCH SET name = @name, address = @address, phone = @phone, img = @img  WHERE id = @id", Database.Connection);
            cmd.Parameters.AddWithValue("@id", branch.b_id);
            cmd.Parameters.AddWithValue("@name", branch.b_name);
            cmd.Parameters.AddWithValue("@address", branch.b_address);
            cmd.Parameters.AddWithValue("@phone", branch.b_phone);
            cmd.Parameters.AddWithValue("@img", branch.b_img);
            cmd.ExecuteNonQuery();
            return true;

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            MessageBox.Show(e.Message);
            return false;
        }
    }

    public bool AddBranch(BranchModel.Branch branch)
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("INSERT INTO RESTAURANT_BRANCH ( name, address, phone, img) VALUES ( @name, @address, @phone, @img)", Database.Connection);
            cmd.Parameters.AddWithValue("@name", branch.b_name);
            cmd.Parameters.AddWithValue("@address", branch.b_address);
            cmd.Parameters.AddWithValue("@phone", branch.b_phone);
            cmd.Parameters.AddWithValue("@img", branch.b_img);
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            MessageBox.Show(e.Message);
            return false;
        }
    }

    public static int GetMaxBranchId()
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("SELECT MAX(id)+1 FROM RESTAURANT_BRANCH", Database.Connection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            return reader.GetInt32(0);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return -1;
        }
    }

}
