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
    public partial class AdminUser : Form
    {
        int mode = -1;
        private Dictionary<string, int> userIdDictionary = new Dictionary<string, int>();
        public AdminUser()
        {
            InitializeComponent();
            LoadRoles();
            LoadBranches();
        }

        private void AdminUser_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void LoadRoles()
        {
            List<RoleModel.Role> roles = RoleController.GetRoles();
            cbbRole.Items.Clear();
            cbbRole2.Items.Clear();
            if (roles == null)
            {
                return;
            }
            foreach (RoleModel.Role role in roles)
            {
                if (role.r_id != 0)
                {
                    cbbRole.DisplayMember = "r_name";
                    cbbRole.ValueMember = "r_id";
                    cbbRole.Items.Add(role);
                    cbbRole2.DisplayMember = "r_name";
                    cbbRole2.ValueMember = "r_id";
                    cbbRole2.Items.Add(role);
                }
            }
        }

        private void LoadBranches()
        {
            List<BranchModel.Branch> branches = BranchController.GetBranches();
            cbbBranch.Items.Clear();
            cbbBranch2.Items.Clear();
            if (branches == null)
            {
                return;
            }
            foreach (BranchModel.Branch branch in branches)
            {
                cbbBranch.DisplayMember = "b_name";
                cbbBranch.ValueMember = "b_id";
                cbbBranch.Items.Add(branch);
                cbbBranch2.DisplayMember = "b_name";
                cbbBranch2.ValueMember = "b_id";
                cbbBranch2.Items.Add(branch);
            }
        }

        private void LoadUsers()
        {
            lstUsers.Items.Clear();
            userIdDictionary.Clear();
            if (cbbRole.SelectedItem != null && cbbBranch.SelectedItem != null)
            {
                int roleid = ((RoleModel.Role)cbbRole.SelectedItem).r_id;
                int branchid = ((BranchModel.Branch)cbbBranch.SelectedItem).b_id;
                List<UserModel.User> users = UserController.GetUsersByRoleAndBranch(roleid, branchid);
                if (users == null)
                {
                    return;
                }
                foreach (UserModel.User user in users)
                {
                    string userString = user.u_name;
                    lstUsers.Items.Add(userString);
                    userIdDictionary.Add(userString, user.u_id);
                }
            }
        }

        private void cbbRole_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void cbbBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUsers.SelectedItem != null)
            {
                string selectedUserName = lstUsers.SelectedItem.ToString();

                if (userIdDictionary.ContainsKey(selectedUserName))
                {
                    int selectedUserID = userIdDictionary[selectedUserName];
                    UserModel.User user = UserController.GetUserDetailsById(selectedUserID);
                    if (user != null)
                    {
                        mode = 1;
                        lbId.Text = user.u_id.ToString();
                        tbName.Text = user.u_name;
                        tbCCCD.Text = user.u_cccd;
                        cbbRole2.Text = user.ro_name;
                        cbbBranch2.Text = user.b_name;
                        date.Value = user.u_dob;
                        cbbGender.Text = user.u_gender.ToString();
                        tbAddress.Text = user.u_address;
                        tbPhone.Text = user.u_phone;
                        tbPass.Text = user.u_password;
                    }
                }
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            lbId.Text = "";
            tbName.Text = "";
            tbCCCD.Text = "";
            cbbRole2.SelectedIndex = -1;
            cbbBranch2.SelectedIndex = -1;
            date.Value = DateTime.Now;
            cbbGender.SelectedIndex = -1;
            tbAddress.Text = "";
            tbPhone.Text = "";
            tbPass.Text = "";
            mode = 0;
        }

        private void refreshForm() { 
            lbId.Text = "";
            tbName.Text = "";
            tbCCCD.Text = "";
            cbbRole2.SelectedIndex = -1;
            cbbBranch2.SelectedIndex = -1;
            date.Value = DateTime.Now;
            cbbGender.SelectedIndex = -1;
            tbAddress.Text = "";
            tbPhone.Text = "";
            tbPass.Text = "";
            mode = -1;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (cbbRole2.Text == "" || cbbBranch2.Text == "" || tbCCCD.Text == "" || tbName.Text == "" || cbbGender.Text == "" || tbAddress.Text == "" || tbPhone.Text == "" || tbPass.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            int branchId = BranchController.GetBranchIdByName(cbbBranch2.Text);
            int roleId = RoleController.GetRoleIdByName(cbbRole2.Text);
            UserModel.User user = new UserModel.User();
            user.ro_id = roleId;
            user.ro_name = cbbRole2.Text;
            user.b_id = branchId;
            user.b_name = cbbBranch2.Text;
            user.u_cccd = tbCCCD.Text;
            user.u_name = tbName.Text;
            user.u_dob = date.Value;
            user.u_gender = cbbGender.Text[0];
            user.u_address = tbAddress.Text;
            user.u_phone = tbPhone.Text;
            user.u_password = tbPass.Text;

            if(mode == -1)
            {
                return;
            }
            else if (mode == 0)
            {
                if (UserController.CreateUser(user))
                {
                    MessageBox.Show("Create user successfully");
                    refreshForm();
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("Create user failed");
                }

            }
            else
            {
                user.u_id = int.Parse(lbId.Text);
                if (UserController.UpdateUserDetailsById(user))
                {
                    MessageBox.Show("Update user successfully");
                    refreshForm();
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("Update user failed");
                }
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (lbId.Text == "")
            {
                return;
            }
            int id = int.Parse(lbId.Text);
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (UserController.DeleteUserById(id))
                {
                    MessageBox.Show("Delete user successfully");
                    refreshForm();
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("Delete user failed");
                }
            }
        }
    }
}
