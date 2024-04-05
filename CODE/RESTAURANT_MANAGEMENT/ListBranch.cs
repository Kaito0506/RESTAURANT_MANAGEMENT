using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RESTAURANT_MANAGEMENT
{
    public partial class ListBranch : UserControl
    {
        public event EventHandler<int> ItemDeleted;

        public ListBranch()
        {
            InitializeComponent();
        }

        #region Properties

        private int _id;
        private string _title;
        private Image _image;
        private string _address;
        private string _phone;
        private decimal _revenue;
        private int _employeeCount;

        [Category("Custom Props")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lbTitle.Text = value; }
        }


        [Category("Custom Props")]
        public Image Image
        {
            get { return _image; }
            set { _image = value; pictureBox.Image = value; }
        }


        [Category("Custom Props")]
        public string Address
        {
            get { return _address; }
            set { _address = value; lbAdress.Text = value; }
        }

        [Category("Custom Props")]
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; lbPhone.Text = value; }
        }


        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Do you want to delete item {_title}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ItemDeleted?.Invoke(this, _id);
                Dispose();
            }
        }

    
    }
}
