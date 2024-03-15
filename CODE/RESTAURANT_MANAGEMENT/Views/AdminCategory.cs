using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CategoryModel;

namespace RESTAURANT_MANAGEMENT.Views
{
    public partial class AdminCategory : Form
    {
        public AdminCategory()
        {
            InitializeComponent();
            getCategories();
            getDetailCategoriesByCategory();
        }

        public void getCategories()
        {
            List<CategoryModel.Category> categories = CategoryController.GetCategories();
            cbbCateg.DataSource = categories;
            cbbCateg.DisplayMember = "c_name";
            cbbCateg.ValueMember = "c_id";
            cbbCateg.SelectedIndex = -1;
        }

        public void getDetailCategoriesByCategory()
        {
            if (cbbCateg.SelectedItem != null)
            {
                CategoryModel.Category selectedCategory = (CategoryModel.Category)cbbCateg.SelectedItem;
                int c_id = selectedCategory.c_id;
                dgv.Rows.Clear();
                List<DetailCategoryModel.DetailCategory> detailCategories = DetailCategoryController.GetDetailCategoriesByCategory(c_id);
                foreach (var detailCategory in detailCategories)
                {
                    dgv.Rows.Add(detailCategory.dc_id, detailCategory.dc_name, detailCategory.dc_desc);
                }
            }
        }

        private void cbbCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            getDetailCategoriesByCategory();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv.Columns["edit"].Index && e.RowIndex >= 0)
            {
                int selectedRowIndex = e.RowIndex;
                int dc_id = Convert.ToInt32(dgv.Rows[selectedRowIndex].Cells["id"].Value);
                string dc_name = dgv.Rows[selectedRowIndex].Cells["name"].Value.ToString();
                string dc_desc = dgv.Rows[selectedRowIndex].Cells["desc"].Value.ToString();
                DetailCategoryController dc = new DetailCategoryController();

                if (dc.EditDetailCategory(dc_id, dc_name, dc_desc))
                {
                    MessageBox.Show("Detail category edited successfully");
                    getDetailCategoriesByCategory();
                }
                else
                {
                    MessageBox.Show("Failed to edit detail category");
                }
            }
            else if (e.ColumnIndex == dgv.Columns["delete"].Index && e.RowIndex >= 0)
            {
                int selectedRowIndex = e.RowIndex;
                int dc_id = Convert.ToInt32(dgv.Rows[selectedRowIndex].Cells["id"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this detail category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DetailCategoryController dc = new DetailCategoryController();

                    if (dc.DeleteDetailCategory(dc_id))
                    {
                        MessageBox.Show("Detail category deleted successfully");
                        getDetailCategoriesByCategory();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete detail category");
                    }
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (cbbCateg.SelectedItem == null)
            {
                MessageBox.Show("Please select a category first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DetailCategoryModel.DetailCategory dc = new DetailCategoryModel.DetailCategory();
            DetailCategoryController dcc = new DetailCategoryController();
            dc.dc_name = tbName.Text;
            dc.dc_desc = tbDesc.Text;
            dc.c_id = ((CategoryModel.Category)cbbCateg.SelectedItem).c_id;
            if (dcc.AddDetailCategory(dc))
            {
                MessageBox.Show("Detail category added successfully");
                getDetailCategoriesByCategory();
            }
            else
            {
                MessageBox.Show("Failed to add detail category");
            }
            
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            getCategories();
            getDetailCategoriesByCategory();
        }

        private void AdminCategory_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip t = new System.Windows.Forms.ToolTip();
            t.SetToolTip(this.refresh, "Refresh");
        }
    }
}
