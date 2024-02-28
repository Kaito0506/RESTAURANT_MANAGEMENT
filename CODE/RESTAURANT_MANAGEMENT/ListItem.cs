using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANT_MANAGEMENT
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        #region Properties

        private string _title;
        private string _description;
        private decimal _price;
        private string _category;
        private Image _image;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lbTitle.Text = value; }
        }

        [Category("Custom Props")]
        public string Description
        {
            get { return _description; }
            set { _description = value; lbDesc.Text = value; }
        }

        [Category("Custom Props")]
        public decimal Price
        {
            get { return _price; }
            set { _price = value; CultureInfo vietnameseCulture = new CultureInfo("vi-VN"); lbPrice.Text = value.ToString("C0", vietnameseCulture); }
        }

        [Category("Custom Props")]
        public string Category
        {
            get { return _category; }
            set { _category = value; lbCateg.Text = value; }
        }

        [Category("Custom Props")]
        public Image Image
        {
            get { return _image; }
            set { _image = value; pictureBox.Image = value; }
        }

        #endregion 
    }
}
