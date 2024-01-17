using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class PaintCommon
    {
        /// <summary>
        /// 根据矩形和圆角弧度大小绘制圆角矩形路径
        /// </summary>
        /// <param name="rectangle">矩形</param>
        /// <param name="radius">圆角弧度大小</param>
        /// <returns>圆角矩形路径GraphicsPath对象</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static GraphicsPath GetRoundRectangle(Rectangle rectangle, int radius)
        {
            int len = 2 * radius;
            // 把圆角矩形分成八段直线、弧的组合，依次加到路径中 
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddLine(new Point(rectangle.X + radius, rectangle.Y), new Point(rectangle.Right - radius, rectangle.Y));
            graphicsPath.AddArc(new Rectangle(rectangle.Right - len, rectangle.Y, len, len), 270F, 90F);

            graphicsPath.AddLine(new Point(rectangle.Right, rectangle.Y + radius), new Point(rectangle.Right, rectangle.Bottom - radius));
            graphicsPath.AddArc(new Rectangle(rectangle.Right - len, rectangle.Bottom - len, len, len), 0F, 90F);

            graphicsPath.AddLine(new Point(rectangle.Right - radius, rectangle.Bottom), new Point(rectangle.X + radius, rectangle.Bottom));
            graphicsPath.AddArc(new Rectangle(rectangle.X, rectangle.Bottom - len, len, len), 90F, 90F);

            graphicsPath.AddLine(new Point(rectangle.X, rectangle.Bottom - radius), new Point(rectangle.X, rectangle.Y + radius));
            graphicsPath.AddArc(new Rectangle(rectangle.X, rectangle.Y, len, len), 180F, 90F);
            return graphicsPath;
        }
    }
}
