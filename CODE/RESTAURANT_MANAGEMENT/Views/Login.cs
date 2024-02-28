using RESTAURANT_MANAGEMENT.Properties;
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
    public partial class login : Form
    {
        private bool usePassword = true;
        public login()
        {

            InitializeComponent();
            labels1.SendToBack();
            labels2.SendToBack();
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
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
                SqlDataReader reader = loginController.Login(txtUsername.Text, txtPassword.Text);
                if(reader == null)
                {
                    Console.WriteLine("Error when retriving data login: ");
                }
                else if (reader.HasRows)
                {
                    this.Hide();
                    int roleId = Convert.ToInt32(reader["role_id"]);
                    if (roleId == 0)
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

        private void btnShowPassword(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !usePassword;
            usePassword = !usePassword;
        }

        private void login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            Console.WriteLine("Focus user name works");
        }
    }
}
