using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANT_MANAGEMENT.Views
{
    public class RoundPictureBox : PictureBox
    {
            protected override void OnPaint(PaintEventArgs pe)
            {
                GraphicsPath grpath = new GraphicsPath();
                grpath.AddEllipse(0, 0, ClientRectangle.Width, ClientRectangle.Height);
                this.Region = new System.Drawing.Region(grpath);
                base.OnPaint(pe);
            }
    }
}
