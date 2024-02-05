using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANT_MANAGEMENT
{
    public partial class Login : Form
    {
        public Login()
        {
         
            InitializeComponent();
            cbRole.SelectedIndex = 0;
            txtUsername.Focus();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login_function();
        }

        private void Login_function()
        {
            if (txtUsername.Text.Length == 0 || txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Username and password are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    Database.Connect();
                    SqlCommand cmd = new SqlCommand();
                    switch (cbRole.SelectedIndex)
                    {
                        //preresent Admin role
                        case 0:
                            {
                                cmd = new SqlCommand("select * from ADMIN where ad_phone = @username and ad_password=@password ", Database.Connection);
                                break;
                            }
                        case 1:
                            {
                                cmd = new SqlCommand("select * from USERS where u_phone = @username and u_password=@password ", Database.Connection);
                                break;
                            }
                        default:
                            MessageBox.Show("Invalid role selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    cmd.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar, 10)).Value = txtUsername.Text;
                    cmd.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar, 30)).Value = txtPassword.Text;

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        this.Hide();
                        MainPage mainForm = new MainPage();
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Clear();
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error when retriving data login: ");
                    Console.WriteLine(ex.ToString());
                }
                Database.Close();
            }

        }


        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login_function();
            }
        }
    }
}
