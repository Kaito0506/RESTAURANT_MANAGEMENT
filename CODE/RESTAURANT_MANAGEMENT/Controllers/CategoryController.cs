using System;
using System.Collections.Generic;
using System.Data.SqlClient;
class CategoryController
{
    public static List<CategoryModel.Category> GetCategories()
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORY", Database.Connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<CategoryModel.Category> res = new List<CategoryModel.Category>();

            while (reader.Read())
            {
                CategoryModel.Category category = new CategoryModel.Category();
                category.c_id = reader.GetInt32(0);
                category.c_name = reader.GetString(1);
                category.c_desc = reader.GetString(2);
                res.Add(category);
            }

            return res;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }
}

