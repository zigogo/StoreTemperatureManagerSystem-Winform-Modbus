using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STMS.UControls
{
    public partial class UCircle : UserControl
    {
        public UCircle()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 重写OnPaint
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectangle = e.ClipRectangle;

            Rectangle rectangle1 = new Rectangle(rectangle.X + 1, rectangle.Y + 1, rectangle.Width - 2, rectangle.Height - 2);
            graphics.DrawEllipse(new Pen(this.ForeColor),rectangle1);
            graphics.FillEllipse(new SolidBrush(this.ForeColor),rectangle1);
            
        }
    }
}
