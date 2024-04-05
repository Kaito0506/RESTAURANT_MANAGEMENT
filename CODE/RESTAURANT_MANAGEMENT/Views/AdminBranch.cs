using RESTAURANT_MANAGEMENT.Controllers;
using RESTAURANT_MANAGEMENT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using static RESTAURANT_MANAGEMENT.Models.BillModel;
using static RESTAURANT_MANAGEMENT.Models.TableModel;
using static RoleModel;




namespace RESTAURANT_MANAGEMENT.Views
{
    public partial class AdminBranch : Form
    {
        List<BranchModel.Branch> branches = BranchController.GetBranches();
        private List<BranchModel.Branch> filteredBranches;

        public AdminBranch()
        {
            InitializeComponent();
            filteredBranches = new List<BranchModel.Branch>();
            LoadBranchItemData();
        }



        private Image GetImage(string imageName)
        {
            try
            {
                string fullPath = Path.GetFullPath(Path.Combine("..", "..", "images", "branch", imageName));
                Console.WriteLine("Full Path: " + fullPath);

                if (File.Exists(fullPath))
                {
                    return Image.FromFile(fullPath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string defaultImagePath = Path.GetFullPath(Path.Combine("..", "..", "images", "branch", "branch.jpg"));
            return Image.FromFile(defaultImagePath);
        }

        public void LoadBranchItemData()
        {
            flowLayoutPanel.Controls.Clear();

            filteredBranches = new List<BranchModel.Branch>(branches);

            ListBranch[] listBranch = new ListBranch[branches.Count];
            for (int i = 0; i < listBranch.Length; i++)
            {
                listBranch[i] = new ListBranch();
                listBranch[i].Id = branches[i].b_id;
                listBranch[i].Title = branches[i].b_name;
                listBranch[i].Address = branches[i].b_address;
                listBranch[i].Image = GetImage(branches[i].b_img);
                listBranch[i].Phone = branches[i].b_phone;
                //listBranch[i].Revenue = branches[i].b_revenue;
                // listBranch[i].EmployeeCount = branches[i].b_employee;
                flowLayoutPanel.Controls.Add(listBranch[i]);
            }
        }

        public void refreshBranchItem(object sender, int id)
        {
            flowLayoutPanel.Controls.Clear();
            branches = BranchController.GetBranches();
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

        private void UpdateUIWithFilteredBranches()
        {
            flowLayoutPanel.Controls.Clear();

            foreach (var branch in filteredBranches)
            {
                ListBranch listBranch = new ListBranch();
                listBranch.Id = branch.b_id;
                listBranch.Title = branch.b_name;
                listBranch.Address = branch.b_address;
                listBranch.Image = GetImage(branch.b_img);
                listBranch.Phone = branch.b_phone;
                flowLayoutPanel.Controls.Add(listBranch);
            }
        }

        private void cbbBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
        }

 
    }
}
