using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANT_MANAGEMENT.Views
{
    public partial class AdminEditItem : Form
    {
        List<CategoryModel.Category> categories = CategoryController.GetCategories();

        public AdminEditItem()
        {
            InitializeComponent();
            LoadCategoryData();
            cbbCateg.SelectedIndex = 0;
        }

        public void SetTbIdText(string text)
        {
            tbId.Text = text;
        }

        public void SetTbNameText(string text)
        {
            tbName.Text = text;
        }

        public void SetTbDescText(string text)
        {
            tbDesc.Text = text;
        }

        public void SetTbPriceText(string text)
        {
            tbPrice.Text = text;
        }

        public void SetCbbCategIndex(int index)
        {
            cbbCateg.SelectedIndex = index;
        }

        public void LoadCategoryData()
        {
            cbbCateg.Items.Clear();
            if (categories != null)
            {
                foreach (CategoryModel.Category category in categories)
                {
                    cbbCateg.Items.Add(category.ca_name);
                }
            }
        }
    }
}
