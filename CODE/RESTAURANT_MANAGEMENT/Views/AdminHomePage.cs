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
    public partial class AdminHomePage : Form
    {
        AdminBranch abranch;
        AdminUser auser;
        AdminCustomer acustomer;

        LoginController lg = new LoginController();
        AdminModel.Admin admin;
        public AdminHomePage()
        {
            InitializeComponent();
            admin = lg.GetAdmin();
            lbName.Text = admin.ad_name.Split(' ').Last();
            mdiProp();
        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        private void branch_Click(object sender, EventArgs e)
        {
            if (auser != null)
            {
                auser.Close();
                auser = null;
            }
            if (acustomer != null)
            {
                acustomer.Close();
                acustomer = null;
            }

            if (abranch == null)
            {
                abranch = new AdminBranch();
                abranch.FormClosed += abranch_FormClosed;
                abranch.MdiParent = this;
                abranch.Dock = DockStyle.Fill;
                abranch.Show();
            }
            else
            {
                abranch.Activate();
            }
        }

        private void abranch_FormClosed(object sender, FormClosedEventArgs e)
        {
            abranch = null;
        }

        private void user_Click(object sender, EventArgs e)
        {
            if (abranch != null)
            {
                abranch.Close();
                abranch = null;
            }
            if (acustomer != null)
            {
                acustomer.Close();
                acustomer = null;
            }

            if (auser == null)
            {
                auser = new AdminUser();
                auser.FormClosed += auser_FormClosed;
                auser.MdiParent = this;
                auser.Dock = DockStyle.Fill;
                auser.Show();
            }
            else
            {
                auser.Activate();
            }
        }

        private void auser_FormClosed(object sender, FormClosedEventArgs e)
        {
            auser = null;
        }

        private void customer_Click(object sender, EventArgs e)
        {
            if (abranch != null)
            {
                abranch.Close();
                abranch = null;
            }
            if (auser != null)
            {
                auser.Close();
                auser = null;
            }

            if (acustomer == null)
            {
                acustomer = new AdminCustomer();
                acustomer.FormClosed += acustomer_FormClosed;
                acustomer.MdiParent = this;
                acustomer.Dock = DockStyle.Fill;
                acustomer.Show();
            }
            else
            {
                acustomer.Activate();
            }
        }

        private void acustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            acustomer = null;
        }
    }
}
