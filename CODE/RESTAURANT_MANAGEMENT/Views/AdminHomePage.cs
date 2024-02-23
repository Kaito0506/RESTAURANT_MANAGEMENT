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
        LoginController lg = new LoginController();
        AdminModel.Admin admin;
        public AdminHomePage()
        {
            InitializeComponent();
            admin = lg.GetAdmin();
            lbName.Text = admin.ad_name;
        }
    }
}
