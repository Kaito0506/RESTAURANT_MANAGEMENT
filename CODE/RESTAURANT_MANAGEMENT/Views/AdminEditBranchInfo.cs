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
using System.Xml.Linq;
using RESTAURANT_MANAGEMENT.Controllers;
using RESTAURANT_MANAGEMENT.Models;

namespace RESTAURANT_MANAGEMENT.Views
{
    public partial class AdminEditBranchInfo : Form
    {
        int mode = -1;
        public static event EventHandler BranchUpdated;
        public AdminEditBranchInfo()
        {
            InitializeComponent();
        }

        public void SetTbIdText(string text)
        {
            tbId.Text = text;
        }

        public void SetTbBranchNameText(string text)
        {
            tbBranchName.Text = text;
        }

        public void SetTbAddressText(string text)
        {
            tbAddress.Text = text;
        }

        public void SetTbPhoneText(string text)
        {
            tbPhone.Text = text;
        }
        public void SetBackgroundImage(Image image)
        {
            img.BackgroundImage = image;
        }
        public void SetFilenameText(string name)
        {
            filename.Text = name;
        }
        public void SetMode(int mode)
        {
            this.mode = mode;
        }

        private void AdminEditBranchInfo_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.upload, "Upload Image");
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void save_Click_1(object sender, EventArgs e)
        {
            if (tbBranchName.Text == "" || tbAddress.Text == "" || tbPhone.Text == "")
            {
                MessageBox.Show("Please fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show($"Are you sure to update this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                BranchModel.Branch branch = new BranchModel.Branch();
                branch.b_id = int.Parse(tbId.Text);
                branch.b_name = tbBranchName.Text;
                branch.b_address = tbAddress.Text;
                branch.b_phone = tbPhone.Text;
                branch.b_img = filename.Text;

                BranchController branchController = new BranchController();
                if (mode == -1)
                {
                    MessageBox.Show("Mode is not set!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (mode == 1)
                {
                    if (branchController.UpdateBranch(branch))
                    {
                        MessageBox.Show("Update item successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BranchUpdated?.Invoke(this, e);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Update item failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (branchController.AddBranch(branch))
                    {
                        MessageBox.Show("Add item successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BranchUpdated?.Invoke(this, e);
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
