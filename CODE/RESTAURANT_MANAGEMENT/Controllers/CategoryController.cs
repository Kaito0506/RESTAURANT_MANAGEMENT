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

            List<CategoryModel.Category> resultCategories = new List<CategoryModel.Category>();

            while (reader.Read())
            {
                CategoryModel.Category category = new CategoryModel.Category();
                category.ca_id = reader.GetInt32(reader.GetOrdinal("id"));
                category.ca_name = reader["name"].ToString();
                category.ca_desc = reader["describe"].ToString();
                resultCategories.Add(category);
            }

            return resultCategories;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }
}
