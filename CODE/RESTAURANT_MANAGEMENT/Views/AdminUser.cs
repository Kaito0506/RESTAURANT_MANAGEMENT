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
        List<String> managers = UserController.GetManagers();
        public AdminUser()
        {
            InitializeComponent();
            lstManager.Items.Clear();
            this.lstManager.Items.AddRange(managers.ToArray());
        }

        private void AdminUser_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void lstManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
