using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace RESTAURANT_MANAGEMENT.Views
{
    public partial class AdminEditItem : Form
    {
        List<DetailCategoryModel.DetailCategory> detailCategories = DetailCategoryController.GetDetailCategories();
        int mode = -1;
        public static event EventHandler ItemUpdated;

        public AdminEditItem()
        {
            InitializeComponent();
            LoadCategoryData();
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
        public void SetBackgroundImage(Image image)
        {
            img.BackgroundImage = image;
        }
        public void SetFilenameText(string name)
        {
            filename.Text = name;
        }

        public void SetCbbCategIndex(string categName)
        {
            int selectedIndex = detailCategories.FindIndex(cat => cat.dc_name == categName);
            cbbCateg.SelectedIndex = selectedIndex;
        }

        public void SetMode(int mode)
        {
            this.mode = mode;
        }

        public void LoadCategoryData()
        {
            cbbCateg.Items.Clear();
            if (detailCategories != null)
            {
                foreach (DetailCategoryModel.DetailCategory dc in detailCategories)
                {
                    cbbCateg.Items.Add(dc.dc_name);
                }
            }
        }

        private void upload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filename.Text = Path.GetFileName(dialog.FileName);
                    img.BackgroundImage = new Bitmap(dialog.FileName);
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbDesc.Text == "" || tbPrice.Text == "")
            {
                MessageBox.Show("Please fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show($"Are you sure to update this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MenuItemModel.MenuItem menuItem = new MenuItemModel.MenuItem();
                menuItem.mi_id = int.Parse(tbId.Text);
                menuItem.mi_name = tbName.Text;
                menuItem.mi_desc = tbDesc.Text;
                menuItem.mi_price = decimal.Parse(tbPrice.Text);
                menuItem.mi_image = filename.Text;
                menuItem.ca_id = detailCategories[cbbCateg.SelectedIndex].dc_id;
                MenuItemController menuItemController = new MenuItemController();
                if (mode == -1)
                {
                    MessageBox.Show("Mode is not set!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (mode == 1)
                {
                    if (menuItemController.UpdateMenuItem(menuItem))
                    {
                        MessageBox.Show("Update item successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ItemUpdated?.Invoke(this, e);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Update item failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if(menuItemController.AddMenuItem(menuItem))
                    {
                        MessageBox.Show("Add item successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ItemUpdated?.Invoke(this, e);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Add item failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
