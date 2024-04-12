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
using static MenuItemModel;

namespace RESTAURANT_MANAGEMENT.Views
{
    public partial class AdminBranch : Form
    {
        List<BranchModel.Branch> branches = BranchController.GetBranches();

        public AdminBranch()
        {
            InitializeComponent();
            LoadBranchItemData();
            AdminEditBranchInfo.BranchUpdated += BranchUpdated;
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


            ListBranch[] listBranch = new ListBranch[branches.Count];
            for (int i = 0; i < listBranch.Length; i++)
            {
                listBranch[i] = new ListBranch();
                listBranch[i].Id = branches[i].b_id;
                listBranch[i].Title = branches[i].b_name;
                listBranch[i].Address = branches[i].b_address;
                listBranch[i].Image = GetImage(branches[i].b_img);
                listBranch[i].Phone = branches[i].b_phone;
                flowLayoutPanel.Controls.Add(listBranch[i]);
            }
        }

        public void refreshBranchItem(object sender, int id)
        {
            flowLayoutPanel.Controls.Clear();
            branches = BranchController.GetBranches();
            LoadBranchData();
        }

        private void BranchUpdated(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            branches = BranchController.GetBranches();
            LoadBranchData();
        }

        private void cbbBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
        }
        
        public void LoadBranchData()
        {
            flowLayoutPanel.Controls.Clear();


            ListBranch[] listBranch = new ListBranch[branches.Count];
            for (int i = 0; i < listBranch.Length; i++)
            {
                listBranch[i] = new ListBranch();
                listBranch[i].Id = branches[i].b_id;
                listBranch[i].Title = branches[i].b_name;
                listBranch[i].Address = branches[i].b_address;
                listBranch[i].Phone = branches[i].b_phone;
                listBranch[i].Image = GetImage(branches[i].b_img);
                listBranch[i].Filename = branches[i].b_img;
                listBranch[i].BranchDeleted += refreshBranchItem;
                flowLayoutPanel.Controls.Add(listBranch[i]);
            }
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            branches = BranchController.GetBranches();
            LoadBranchData();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            AdminEditBranchInfo adminEditBranchInfo = new AdminEditBranchInfo();
            int new_id = BranchController.GetMaxBranchId();

            adminEditBranchInfo.SetTbIdText(new_id.ToString());
            adminEditBranchInfo.SetBackgroundImage(GetImage("branch.png"));
            adminEditBranchInfo.SetFilenameText("branch.png");
            adminEditBranchInfo.SetMode(0);
            adminEditBranchInfo.ShowDialog();
        }
    }
}
