using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
}
