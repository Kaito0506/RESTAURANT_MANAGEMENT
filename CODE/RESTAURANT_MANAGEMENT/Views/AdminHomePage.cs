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
        AdminDashboard adashboard;
        AdminItem aitem;
        AdminCategory acategory;

        private Form[] adminForms;

        LoginController lg = new LoginController();
        UserModel.User admin;
        public AdminHomePage()
        {
            InitializeComponent();
            admin = lg.GetUser();
            lbName.Text = admin.u_name.Split(' ').Last();
            mdiProp();
            adminForms = new Form[] { abranch, auser, acustomer, adashboard, aitem, acategory };
        }

        private void close_Forms(Form form)
        {
            foreach (Form f in adminForms)
            {
                if (f != form && f != null)
                {
                    form.Close();
                    form.Dispose();
                    form = null;
                }
            }
        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        private void branch_Click(object sender, EventArgs e)
        {
            close_Forms(abranch);

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
            close_Forms(auser);
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
            close_Forms(acustomer);
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


        private void AdminHomePage_Load(object sender, EventArgs e)
        { }


            private void dashboard_Click(object sender, EventArgs e)
            {
                close_Forms(adashboard);
                if (adashboard == null)
                {
                    adashboard = new AdminDashboard();
                    adashboard.FormClosed += adashboard_FormClosed;
                    adashboard.MdiParent = this;
                    adashboard.Dock = DockStyle.Fill;
                    adashboard.Show();
                }
                else
                {
                    adashboard.Activate();
                }
            }
      

            private void adashboard_FormClosed(object sender, FormClosedEventArgs e)
            {
                adashboard = null;
            }

            private void item_Click(object sender, EventArgs e)
            {
                close_Forms(aitem);
                if (aitem == null)
                {
                    aitem = new AdminItem();
                    aitem.FormClosed += aitem_FormClosed;
                    aitem.MdiParent = this;
                    aitem.Dock = DockStyle.Fill;
                    aitem.Show();
                }
                else
                {
                    aitem.Activate();
                }
            }

            private void aitem_FormClosed(object sender, FormClosedEventArgs e)
            {
                aitem = null;
            }

            private void categ_Click(object sender, EventArgs e)
            {
                close_Forms(acategory);
                if (acategory == null)
                {
                    acategory = new AdminCategory();
                    acategory.FormClosed += acategory_FormClosed;
                    acategory.MdiParent = this;
                    acategory.Dock = DockStyle.Fill;
                    acategory.Show();
                }
                else
                {
                    acategory.Activate();
                }
            }

            private void acategory_FormClosed(object sender, FormClosedEventArgs e)
            {
                acategory = null;

            }
        }
 } 

