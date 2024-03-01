using System;
using System.Collections.Generic;
using System.Data.SqlClient;

class MenuItemController {
    public static List<MenuItemModel.MenuItem> GetMenuItems()
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("SELECT mi.id, mi.price, mi.name, mi.describe, mi.img, mi.category_id, ca.name as category_name FROM MENU_ITEM mi JOIN DETAIL_CATEGORY ca ON mi.category_id = ca.id;", Database.Connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<MenuItemModel.MenuItem> resultMenuItems = new List<MenuItemModel.MenuItem>();

            while (reader.Read())
            {
                MenuItemModel.MenuItem menuItem = new MenuItemModel.MenuItem();
                menuItem.mi_id = reader.GetInt32(reader.GetOrdinal("id"));
                menuItem.mi_price = reader.GetDecimal(reader.GetOrdinal("price"));
                menuItem.mi_name = reader["name"].ToString();
                menuItem.mi_desc = reader["describe"].ToString();
                menuItem.mi_image = reader["img"].ToString();
                menuItem.ca_id = reader.GetInt32(reader.GetOrdinal("category_id"));
                menuItem.ca_name = reader["category_name"].ToString();
                resultMenuItems.Add(menuItem);
            }

            return resultMenuItems;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }

    public bool DeleteMenuItem(int id)
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("DELETE FROM MENU_ITEM WHERE id = @id", Database.Connection);
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
}
