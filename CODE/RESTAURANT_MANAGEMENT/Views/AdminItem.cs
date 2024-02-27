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
            dataGridView.AllowUserToAddRows = false;
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
            dataGridView.Columns.Clear();

            // Add the DataGridViewImageColumn for images
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "Image";
            imageColumn.HeaderText = "Image";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Adjust the layout
            dataGridView.Columns.Add(imageColumn);

            // Create columns for DataGridView
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.HeaderText = "ID";
            idColumn.Width = 50; // Adjust the width as needed
            dataGridView.Columns.Add(idColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "Name";
            nameColumn.HeaderText = "Name";
            nameColumn.Width = 150; // Adjust the width as needed
            dataGridView.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn categoryColumn = new DataGridViewTextBoxColumn();
            categoryColumn.Name = "CategoryName";
            categoryColumn.HeaderText = "Category Name";
            categoryColumn.Width = 100; // Adjust the width as needed
            dataGridView.Columns.Add(categoryColumn);

            DataGridViewTextBoxColumn descColumn = new DataGridViewTextBoxColumn();
            descColumn.Name = "Description";
            descColumn.HeaderText = "Description";
            descColumn.Width = 250; // Adjust the width as needed
            dataGridView.Columns.Add(descColumn);

            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();
            priceColumn.Name = "Price";
            priceColumn.HeaderText = "Price";
            priceColumn.Width = 150; // Adjust the width as needed
            dataGridView.Columns.Add(priceColumn);

            // Set the row height
            dataGridView.RowTemplate.Height = 100; // Adjust the height as needed

            dataGridView.AllowUserToAddRows = false; // Disable the last empty row

            // Set AutoSizeColumnsMode to Fill
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (var menuItem in menuItems)
            {
                // Load the image
                Image img = GetImage(menuItem.mi_image);
                // Resize the image to 100x100
                img = new Bitmap(img, new Size(100, 100));

                // Create a row with data and image
                object[] row = {
                img,
                menuItem.mi_id.ToString(),
                menuItem.mi_name,
                menuItem.ca_name,
                menuItem.mi_desc,
                menuItem.mi_price.ToString("C0", CultureInfo.GetCultureInfo("vi-VN")),
            };

            dataGridView.Rows.Add(row);
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
