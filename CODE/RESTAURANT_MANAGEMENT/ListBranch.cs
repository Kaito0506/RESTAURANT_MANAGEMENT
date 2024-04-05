using RESTAURANT_MANAGEMENT.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RESTAURANT_MANAGEMENT
{
    public partial class ListBranch : UserControl
    {
        public event EventHandler<int> BranchDeleted;

        public ListBranch()
        {
            InitializeComponent();
        }

        #region Properties

        private int _id;
        private string _title;
        private Image _image;
        private string _address;
        private string _phone;
        private string _filename;

        [Category("Custom Props")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lbTitle.Text = value; }
        }


        [Category("Custom Props")]
        public Image Image
        {
            get { return _image; }
            set { _image = value; pictureBox.Image = value; }
        }


        [Category("Custom Props")]
        public string Address
        {
            get { return _address; }
            set { _address = value; lbAdress.Text = value; }
        }

        [Category("Custom Props")]
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; lbPhone.Text = value; }
        }
        public string Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }

        #endregion
        private void btnEditBranch_Click(object sender, EventArgs e)
        {
            AdminEditBranchInfo adminEditBranchInfo = new AdminEditBranchInfo();
            adminEditBranchInfo.SetTbIdText(_id.ToString());
            adminEditBranchInfo.SetTbBranchNameText(_title);
            adminEditBranchInfo.SetTbAddressText(_address);
            adminEditBranchInfo.SetTbPhoneText(_phone);
            adminEditBranchInfo.SetBackgroundImage(_image);
            adminEditBranchInfo.SetFilenameText(_filename);
            adminEditBranchInfo.SetMode(1);
            adminEditBranchInfo.ShowDialog();
        }

        private void btnDeleteBranch_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Do you want to delete item {_title}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                BranchController branchController = new BranchController();
                if (branchController.DeleteBranch(_id))
                {
                    MessageBox.Show("Delete item successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BranchDeleted?.Invoke(this, _id);
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Delete item failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
