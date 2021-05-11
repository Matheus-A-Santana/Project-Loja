using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Loja
{
    class PictureCircle : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath GP = new GraphicsPath();
            GP.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(GP);
            base.OnPaint(pe);
        }
    }
}
