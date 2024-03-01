using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

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

    public bool UpdateMenuItem(MenuItemModel.MenuItem item)
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("UPDATE MENU_ITEM SET name = @name, describe = @desc, price = @price, img = @img, category_id = @category_id WHERE id = @id", Database.Connection);
            cmd.Parameters.AddWithValue("@name", item.mi_name);
            cmd.Parameters.AddWithValue("@desc", item.mi_desc);
            cmd.Parameters.AddWithValue("@price", item.mi_price);
            cmd.Parameters.AddWithValue("@img", item.mi_image);
            cmd.Parameters.AddWithValue("@category_id", item.ca_id);
            cmd.Parameters.AddWithValue("@id", item.mi_id);
            cmd.ExecuteNonQuery();
            return true;

        } catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }

    public bool AddMenuItem(MenuItemModel.MenuItem item)
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("INSERT INTO MENU_ITEM (id, name, describe, price, img, category_id) VALUES (@id, @name, @desc, @price, @img, @category_id)", Database.Connection);
            cmd.Parameters.AddWithValue("@id", item.mi_id);
            cmd.Parameters.AddWithValue("@name", item.mi_name);
            cmd.Parameters.AddWithValue("@desc", item.mi_desc);
            cmd.Parameters.AddWithValue("@price", item.mi_price);
            cmd.Parameters.AddWithValue("@img", item.mi_image);
            cmd.Parameters.AddWithValue("@category_id", item.ca_id);
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }

    public static int GetMaxItemId()
    {
        try
        {
            Database.Connect();
            SqlCommand cmd = new SqlCommand("SELECT MAX(id)+1 FROM MENU_ITEM", Database.Connection);
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
