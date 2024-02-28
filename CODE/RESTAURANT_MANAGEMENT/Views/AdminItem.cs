using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RESTAURANT_MANAGEMENT.Views
{
    public partial class AdminItem : Form
    {
        List<CategoryModel.Category> categories = CategoryController.GetCategories();
        List<MenuItemModel.MenuItem> menuItems = MenuItemController.GetMenuItems();

        public AdminItem()
        {
            InitializeComponent();
            LoadCategoryData();
            LoadItemData();
        }

        public void LoadCategoryData()
        {
            cbbCateg.Items.Clear();
            cbbCateg.Items.Add("Tất cả");
            if (categories != null)
            {
                foreach (CategoryModel.Category category in categories)
                {
                    cbbCateg.Items.Add(category.ca_name);
                }
            }
            cbbCateg.SelectedIndex = 0;
        }

        public void LoadItemData()
        {
            ListItem [] listItems = new ListItem[menuItems.Count];
            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new ListItem();
                listItems[i].Title = menuItems[i].mi_name;
                listItems[i].Description = menuItems[i].mi_desc;
                listItems[i].Price = menuItems[i].mi_price;
                listItems[i].Category = menuItems[i].ca_name;
                listItems[i].Image = GetImage(menuItems[i].mi_image);
                flowLayoutPanel.Controls.Add(listItems[i]);
            }
        }

        private Image GetImage(string imageName)
        {
            try
            {
                string fullPath = Path.GetFullPath(Path.Combine("..", "..", "images", "foods", imageName));

                if (File.Exists(fullPath))
                {
                    return Image.FromFile(fullPath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string defaultImagePath = Path.GetFullPath(Path.Combine("..", "..", "images", "foods", "food.png"));
            return Image.FromFile(defaultImagePath);
        }
    }
}
