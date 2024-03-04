using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

class DetailCategoryController
{   
    public static List<DetailCategoryModel.DetailCategory> GetDetailCategories()
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("SELECT dc.id, dc.name as dc_name, dc.describe as dc_desc, dc.category_id, c.name as c_name, c.describe as c_desc FROM DETAIL_CATEGORY dc JOIN CATEGORY c on dc.category_id = c.id; ", Database.Connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<DetailCategoryModel.DetailCategory> res = new List<DetailCategoryModel.DetailCategory>();

            while (reader.Read())
            {
                DetailCategoryModel.DetailCategory detailCategory = new DetailCategoryModel.DetailCategory();
                detailCategory.dc_id = reader.GetInt32(0);
                detailCategory.dc_name = reader.GetString(1);
                detailCategory.dc_desc = reader.GetString(2);
                detailCategory.c_id = reader.GetInt32(3);
                detailCategory.c_name = reader.GetString(4);
                detailCategory.c_desc = reader.GetString(5);
                res.Add(detailCategory);
            }

            return res;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }

    public static List<DetailCategoryModel.DetailCategory> GetDetailCategoriesByCategory(int c_id)
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("SELECT dc.id, dc.name as dc_name, dc.describe as dc_desc, dc.category_id, c.name as c_name, c.describe as c_desc FROM DETAIL_CATEGORY dc JOIN CATEGORY c on dc.category_id = c.id WHERE dc.category_id = @c_id; ", Database.Connection);
            cmd.Parameters.AddWithValue("@c_id", c_id);
            SqlDataReader reader = cmd.ExecuteReader();

            List<DetailCategoryModel.DetailCategory> res = new List<DetailCategoryModel.DetailCategory>();

            while (reader.Read())
            {
                DetailCategoryModel.DetailCategory detailCategory = new DetailCategoryModel.DetailCategory();
                detailCategory.dc_id = reader.GetInt32(0);
                detailCategory.dc_name = reader.GetString(1);
                detailCategory.dc_desc = reader.GetString(2);
                detailCategory.c_id = reader.GetInt32(3);
                detailCategory.c_name = reader.GetString(4);
                detailCategory.c_desc = reader.GetString(5);
                res.Add(detailCategory);
            }

            return res;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }

    public bool EditDetailCategory(int dc_id, string dc_name, string dc_desc)
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("UPDATE DETAIL_CATEGORY SET name = @dc_name, describe = @dc_desc WHERE id = @dc_id", Database.Connection);
            cmd.Parameters.AddWithValue("@dc_id", dc_id);
            cmd.Parameters.AddWithValue("@dc_name", dc_name);
            cmd.Parameters.AddWithValue("@dc_desc", dc_desc);
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }

    public bool DeleteDetailCategory(int dc_id)
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("DELETE FROM DETAIL_CATEGORY WHERE id = @dc_id", Database.Connection);
            cmd.Parameters.AddWithValue("@dc_id", dc_id);
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }

    public bool AddDetailCategory(DetailCategoryModel.DetailCategory dc)
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("INSERT INTO DETAIL_CATEGORY (name, describe, category_id) VALUES (@dc_name, @dc_desc, @c_id)", Database.Connection);
            cmd.Parameters.AddWithValue("@dc_name", dc.dc_name);
            cmd.Parameters.AddWithValue("@dc_desc", dc.dc_desc);
            cmd.Parameters.AddWithValue("@c_id", dc.c_id);
            cmd.ExecuteNonQuery();
            return true;
        } catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }
}
