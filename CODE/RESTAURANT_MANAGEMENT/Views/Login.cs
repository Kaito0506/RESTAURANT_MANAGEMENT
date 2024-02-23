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

namespace RESTAURANT_MANAGEMENT.Views
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
                LoginController loginController = new LoginController();
                SqlDataReader reader = loginController.Login(cbRole.SelectedIndex, txtUsername.Text, txtPassword.Text);
                if(reader == null)
                {
                    Console.WriteLine("Error when retriving data login: ");
                }
                else if (reader.HasRows)
                {
                    this.Hide();
                    if(cbRole.SelectedIndex == 0)
                    {
                        AdminHomePage mainForm = new AdminHomePage();
                        mainForm.Closed += (s, args) => this.Close();
                        mainForm.Show();
                    }
                    else
                    {
                        UserHomePage mainForm = new UserHomePage();
                        mainForm.Closed += (s, args) => this.Close();
                        mainForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                }
                Database.Close();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_function();
            }
        }
    }
}
