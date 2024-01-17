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

namespace STMS.UControl
{
    /// <summary>
    /// 自定义Upanel：处理了尖角
    /// </summary>
    /// 
    public partial class UPanel : Panel
    {
        public UPanel()
        {
            InitializeComponent();
        }

        //绘制窗口时触发这个消息
        private const int WM_PAINT = 0xF;

        private Color bgColor = Color.Gray;
        //DefaultValue:指定属性的默认值
        //Description：指定属性的描述
        /// <summary>
        /// 控件背景色
        /// </summary>
        [DefaultValue(typeof(Color), "Gray"), Description("控件背景色")]
        public Color BgColor
        {
            get { return bgColor; }
            set
            {
                bgColor = value;
                //重绘控件
                Invalidate();
            }
        }

        private Color bgColor2 = Color.White;
        /// <summary>
        /// 背景色（渐变色中，颜色2）
        /// </summary>
        [DefaultValue(typeof(Color), "Gray"), Description("控件背景颜色2")]
        public Color BgColor2
        {
            get { return bgColor2; }
            set
            {
                bgColor2 = value;
                Invalidate();
            }
        }

        private Color borderColor = Color.Red;
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

        /// <summary>
        /// 指定线性渐变的方向
        /// </summary>
        private LinearGradientMode gradientMode = LinearGradientMode.Vertical;
        /// <summary>
        /// 渐变方式
        /// </summary>
        [DefaultValue(typeof(LinearGradientMode), "Vertical"), Description("渐变方式")]
        public LinearGradientMode GradientMode
        {
            get { return gradientMode; }
            set
            {
                gradientMode = value;
                Invalidate();
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if(m.Msg == WM_PAINT) 
            {
                if(this.Radius > 0) 
                { 
                    using(Graphics graphics= Graphics.FromHwnd(this.Handle))
                    {
                        //消除锯齿
                        graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        //这个Rectangle和Label的大小一样
                        Rectangle rectangle = new Rectangle();
                        rectangle.Width = this.Width;
                        rectangle.Height=this.Height;
                        
                        DrawBorder(graphics, rectangle,this.Radius);
                    }
                }
            }
        }

        /// <summary>
        /// 画边框刷背景
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="rectangle">矩形</param>
        /// <param name="radius">圆角弧度大小</param>
        /// <exception cref="NotImplementedException"></exception>
        private void DrawBorder(Graphics graphics, Rectangle rectangle, int radius)
        {
            //原
            rectangle.Width -= 1;
            rectangle.Height -= 1;

            if (this.BorderWidth>0)//边框粗细>0
            {
                GraphicsPath graphicsPath = new GraphicsPath();
                //绘制圆角矩形路径
                graphicsPath = PaintCommon.GetRoundRectangle(rectangle, radius);
                using (Pen pen= new Pen(this.BorderColor, this.BorderWidth))
                {
                    //绘制
                    graphics.DrawPath(pen, graphicsPath);
                }
            }
            //背景区域的矩形
            //这个Rectangle为Label减去边框
            Rectangle rectangleBack = new Rectangle(rectangle.X + this.BorderWidth, rectangle.Y + this.BorderWidth, 
                 rectangle.Width - 2 * this.BorderWidth, rectangle.Height - 2 * this.BorderWidth);
            //绘制背景
            DrawBackColor(graphics,rectangleBack,radius);
        }


        /// <summary>
        /// 获取圆角矩形后给其上色
        /// </summary>
        /// <param name="graphics">需绘制的图像</param>
        /// <param name="rectangle"></param>
        /// <param name="radius"></param>
        private void DrawBackColor(Graphics graphics, Rectangle rectangle, int radius)
        {
            //获取背景区域的圆角矩形
            GraphicsPath graphicsPath = PaintCommon.GetRoundRectangle(rectangle, radius);
            //如果背景色2（渐变）是Transparent(透明)=>使用单色画刷
            if (this.BgColor2 == Color.Transparent)
            {
                //单色画刷
                SolidBrush solidBrush = new SolidBrush(BgColor);
                graphics.FillPath(solidBrush, graphicsPath);//刷上颜色
            }
            else
            {
                LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rectangle, BgColor, BgColor2, this.gradientMode);
                graphics.FillPath(linearGradientBrush, graphicsPath);//刷上颜色
            }
        }
    }
}
