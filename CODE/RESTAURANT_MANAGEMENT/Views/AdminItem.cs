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
using System.Globalization;
using System.Text;

namespace RESTAURANT_MANAGEMENT.Views
{
    public partial class AdminItem : Form
    {
        List<CategoryModel.Category> categories = CategoryController.GetCategories();
        List<MenuItemModel.MenuItem> menuItems = MenuItemController.GetMenuItems();
        private List<MenuItemModel.MenuItem> filteredItems;

        public AdminItem()
        {
            InitializeComponent();
            LoadCategoryData();
            LoadItemData();
            filteredItems = new List<MenuItemModel.MenuItem>(menuItems);
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
            ListItem[] listItems = new ListItem[menuItems.Count];
            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new ListItem();
                listItems[i].Id = menuItems[i].mi_id;
                listItems[i].Title = menuItems[i].mi_name;
                listItems[i].Description = menuItems[i].mi_desc;
                listItems[i].Price = menuItems[i].mi_price;
                listItems[i].Category = menuItems[i].ca_name;
                listItems[i].Image = GetImage(menuItems[i].mi_image);
                listItems[i].ItemDeleted += refreshItem;
                flowLayoutPanel.Controls.Add(listItems[i]);
            }
        }

        public void refreshItem(object sender, int id)
        {
            flowLayoutPanel.Controls.Clear();
            menuItems = MenuItemController.GetMenuItems();
            ApplyFiltersAndSearch();
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

        private void ApplyFiltersAndSearch()
        {
            string selectedCategory = cbbCateg.SelectedItem.ToString();
            string searchTerm = tbSearch.Text.ToLower();

            filteredItems = menuItems.Where(item =>
                (selectedCategory == "Tất cả" || item.ca_name == selectedCategory) &&
                (string.IsNullOrEmpty(searchTerm) || RemoveDiacritics(item.mi_name.ToLower()).Contains(RemoveDiacritics(searchTerm)))
            ).ToList();

            UpdateUIWithFilteredItems();
        }

        private string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        private void UpdateUIWithFilteredItems()
        {
            flowLayoutPanel.Controls.Clear();

            foreach (var menuItem in filteredItems)
            {
                ListItem listItem = new ListItem();
                listItem.Title = menuItem.mi_name;
                listItem.Description = menuItem.mi_desc;
                listItem.Price = menuItem.mi_price;
                listItem.Category = menuItem.ca_name;
                listItem.Image = GetImage(menuItem.mi_image);
                flowLayoutPanel.Controls.Add(listItem);
            }
        }

        private void cbbCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            ApplyFiltersAndSearch();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            ApplyFiltersAndSearch();
        }

   
    }
}
