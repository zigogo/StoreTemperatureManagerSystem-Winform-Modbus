using Common;
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
    /// <summary>
    /// 圆角button
    /// </summary>
    public partial class UCircleButton : Button
    {
        public UCircleButton()
        {
            InitializeComponent();
        }
        private const int WM_PAINT = 0xF;


        private Color bgColor = Color.Gray;
        /// <summary>
        /// 背景色（渐变色中，颜色1）
        /// </summary>
        [DefaultValue(typeof(Color), "Gray"), Description("控件背景色1")]
        public Color BgColor
        {
            get { return bgColor; }
            set
            {
                bgColor = value;
                Invalidate();
            }
        }

        private Color bgColor2 = Color.Transparent;
        /// <summary>
        /// 控件背景色2
        /// </summary>
        [DefaultValue(typeof(Color), "Transparent"), Description("控件背景色2")]
        public Color BgColor2
        {
            get { return bgColor2; }
            set
            {
                bgColor2 = value;
                Invalidate();
            }
        }


        private Color borderColor = Color.Gray;
        /// <summary>
        /// 控件边框颜色
        /// </summary>
        [DefaultValue(typeof(Color), "Gray"), Description("控件边框颜色")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        private int borderWidth = 0;
        /// <summary>
        /// 控件边框粗细
        /// </summary>
        [DefaultValue(typeof(int), "0"), Description("控件边框粗细")]
        public int BorderWidth
        {
            get { return borderWidth; }
            set
            {
                borderWidth = value;
                Invalidate();
            }
        }


        private int radius = 5;
        /// <summary>
        /// 圆角弧度大小
        /// </summary>
        [DefaultValue(typeof(int), "5"), Description("圆角弧度大小")]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                Invalidate();
            }
        }

        private LinearGradientMode gradientMode = LinearGradientMode.Vertical;
        /// <summary>
        /// 渐变方向
        /// </summary>
        [DefaultValue(typeof(LinearGradientMode), "Vertical"), Description("渐变方向")]
        public LinearGradientMode GradientMode
        {
            get { return gradientMode; }
            set
            {
                gradientMode = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Windows消息处理
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT)
            {
                //绘制工作：重绘边框、背景、按钮文本Text
                if (this.Radius > 0)
                {
                    using (Graphics graphics = Graphics.FromHwnd(this.Handle))
                    {
                        graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        Rectangle rectangle = new Rectangle();
                        rectangle.Width = this.Width;
                        rectangle.Height = this.Height;
                        DrawBorder(graphics, rectangle, this.Radius);//绘制边框和背景还有文本
                    }
                }
            }
        }

        private void DrawBorder(Graphics graphics, Rectangle rectangle, int radius)
        {
            rectangle.Width -= 1;
            rectangle.Height -= 1;

            if (this.BorderWidth > 0)//边框粗细>0
            {
                GraphicsPath graphicsPath = new GraphicsPath();
                //获取圆角矩形路径
                graphicsPath = PaintCommon.GetRoundRectangle(rectangle, radius);
                //根据圆角矩形路径画边框
                using (Pen pen = new Pen(this.BorderColor, BorderWidth))
                {
                    graphics.DrawPath(pen, graphicsPath);
                }
            }
            //背景区域的矩形
            Rectangle rectangleBack = new Rectangle(rectangle.X + BorderWidth,
                rectangle.Y + BorderWidth, rectangle.Width - 2 * BorderWidth,
                rectangle.Height - 2 * BorderWidth);
            // 绘制背景
            DrawBackColor(graphics, rectangleBack, radius);
            //绘制按钮文本
            //设置一个StringFormat为垂直方向和水平方向上居中
            StringFormat stringFormat = new StringFormat();
            stringFormat.LineAlignment = StringAlignment.Center;
            stringFormat.Alignment = StringAlignment.Center;
            Rectangle rect2 = new Rectangle(5, 5, rectangle.Width - 10, rectangle.Height - 10);
            graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), rectangleBack, stringFormat);
        }

        /// <summary>
        /// 绘制背景
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="rect1"></param>
        /// <param name="radius"></param>
        private void DrawBackColor(Graphics graphics, Rectangle rectangle, int radius)
        {
            //获取背景区域的圆角矩形
            GraphicsPath graphicsPath = PaintCommon.GetRoundRectangle(rectangle, radius);
            if (this.BgColor2 != Color.Transparent)
            {
                //线型渐变画刷
                LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rectangle, this.BgColor, this.BgColor2, this.gradientMode);
                graphics.FillPath(linearGradientBrush, graphicsPath);//填充圆角矩形内部
            }
            else
            {
                SolidBrush solidBrush = new SolidBrush(this.BgColor);
                graphics.FillPath(solidBrush, graphicsPath);//填充圆角矩形内部
            }
        }


    }
}
