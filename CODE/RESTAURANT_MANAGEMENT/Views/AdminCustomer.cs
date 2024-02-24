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
    public partial class AdminCustomer : Form
    {
        public AdminCustomer()
        {
            InitializeComponent();
        }

        private void AdminCustomer_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
