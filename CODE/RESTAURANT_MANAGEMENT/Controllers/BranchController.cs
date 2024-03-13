﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
}
