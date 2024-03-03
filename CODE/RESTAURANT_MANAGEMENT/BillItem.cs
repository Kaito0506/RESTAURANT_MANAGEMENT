using RESTAURANT_MANAGEMENT.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RESTAURANT_MANAGEMENT
{
    public partial class BillItem : UserControl
    {
        private int _id;
        private string _name;
        private float _price;
        private Image _image;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; lbItemName.Text = value; }
        }

        public float Price
        {
            get { return _price; }
            set { _price = value; lbPrice.Text = value.ToString(); }
        }

        public Image Image
        {
            get { return _image; }
            set { _image = value; pbImage.Image = value; }
        }

        public BillItem()
        {
            InitializeComponent();

        }

        private void ShowDetailDialog()
        {
            AddBillItem a = new AddBillItem();
            a.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowDetailDialog();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            ShowDetailDialog();
        }



        private void lbItemName_Click(object sender, EventArgs e)
        {
            ShowDetailDialog();
        }

        private void lbPrice_Click(object sender, EventArgs e)
        {
            ShowDetailDialog();
        }
    }
}
