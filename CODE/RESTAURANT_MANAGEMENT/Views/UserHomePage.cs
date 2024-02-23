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
    public partial class UserHomePage : Form
    {
        LoginController lg = new LoginController();
        UserModel.User user;
        public UserHomePage()
        {
            InitializeComponent();
            user = lg.GetUser();
            lbName.Text = user.u_name;
        }
    }
}
