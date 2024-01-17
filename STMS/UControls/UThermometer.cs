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
    public partial class UThermometer : UserControl
    {
        public UThermometer()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Size = new Size(60, 200);
        }
        private Color glassTubeColor = Color.FromArgb(211, 211, 211);
        [Description("玻璃管颜色"), Category("自定义")]
        public Color GlassTubeColor
        {
            get { return glassTubeColor; }
            set
            {
                glassTubeColor = value;
                Refresh();
            }
        }

        private Color mercuryColor = Color.FromArgb(255, 77, 59);
        [Description("水银颜色"), Category("自定义")]
        public Color MercuryColor
        {
            get { return mercuryColor; }
            set
            {
                mercuryColor = value;
                Refresh();
            }
        }

        private decimal minValue = 0;
        [Description("最小值"), Category("自定义")]
        public decimal MinValue
        {
            get { return minValue; }
            set
            {
                minValue = value;
                Refresh();
            }
        }

        private decimal maxValue = 50;
        [Description("最大值"), Category("自定义")]
        public decimal MaxValue
        {
            get { return maxValue; }
            set
            {
                maxValue = value;
                Refresh();
            }
        }

        private decimal mValue = 10;
        [Description("刻度值"), Category("自定义")]
        public decimal Value
        {
            get { return mValue; }
            set
            {
                mValue = value;
                Refresh();
            }
        }

        private int spCount = 6;
        [Description("分隔份数"), Category("自定义")]
        public int SpCount
        {
            get { return spCount; }
            set
            {
                if (value <= 0)
                    return;
                spCount = value;
                Refresh();
            }
        }
        [Description("获取或设置控件显示的文字的字体"), Category("自定义")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                Refresh();
            }
        }

        [Description("获取或设置控件的文字及刻度颜色"), Category("自定义")]
        public override System.Drawing.Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                Refresh();
            }
        }

        private Color valueColor = Color.White;
        [Description("温度值的文本颜色"), Category("自定义")]
        public Color ValueColor
        {
            get
            {
                return valueColor;
            }
            set
            {
                valueColor = value;
                Refresh();
            }
        }

        private Font valueFont = new Font("宋体", 10);
        public Font ValueFont
        {
            get
            {
                return valueFont;
            }
            set
            {
                valueFont = value;
                Refresh();
            }
        }




        private TemperatureUnit leftTemperatureUnit = TemperatureUnit.C;
        [Description("左侧刻度单位，不可为none"), Category("自定义")]
        public TemperatureUnit LeftTemperatureUnit
        {
            get { return leftTemperatureUnit; }
            set
            {
                if (value == TemperatureUnit.None)
                    return;
                leftTemperatureUnit = value;
                Refresh();
            }
        }

        /// <summary>
        /// 高温线的温度值
        /// </summary>
        public decimal bMaxValue;
        public decimal BMaxValue
        {
            get { return bMaxValue; }
            set
            {
                bMaxValue = value;
                Refresh();
            }
        }

        /// <summary>
        ///低温线的温度值
        /// </summary>
        public decimal bMinValue;
        public decimal BMinValue
        {
            get { return bMinValue; }
            set
            {
                bMinValue = value;
                Refresh();
            }
        }

        Rectangle m_rectWorking; //工作区
        Rectangle m_rectLeft;//刻度区域

        /// <summary>
        /// 温度计单位
        /// </summary>
        public enum TemperatureUnit
        {
            /// <summary>
            /// 不显示
            /// </summary>
            None,
            /// <summary>
            /// 摄氏度
            /// </summary>
            C,
            /// <summary>
            /// 华氏度
            /// </summary>
            F,
            /// <summary>
            /// 开氏度
            /// </summary>
            K,
            /// <summary>
            /// 兰氏度
            /// </summary>
            R,
            /// <summary>
            /// 列氏度
            /// </summary>
            Re
        }

        private void UThermometer_SizeChanged(object sender, EventArgs e)
        {
            m_rectWorking = new Rectangle(this.Width / 2 - this.Width / 8, this.Width / 4, this.Width / 4, this.Height - this.Width / 2);
            m_rectLeft = new Rectangle(this.Width / 2 - this.Width / 8, m_rectWorking.Top + m_rectWorking.Width / 2, (this.Width - this.Width / 4) / 2 - 2, m_rectWorking.Height - m_rectWorking.Width * 2);
        }

        /// <summary>
        /// 画温度计
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            //玻璃管
            GraphicsPath path = new GraphicsPath();
            path.AddLine(m_rectWorking.Left, m_rectWorking.Bottom, m_rectWorking.Left, m_rectWorking.Top + m_rectWorking.Width / 2);
            path.AddArc(new Rectangle(m_rectWorking.Left, m_rectWorking.Top, m_rectWorking.Width, m_rectWorking.Width), 180, 180);
            path.AddLine(m_rectWorking.Right, m_rectWorking.Top + m_rectWorking.Width / 2, m_rectWorking.Right, m_rectWorking.Bottom);
            path.CloseAllFigures();
            g.FillPath(new SolidBrush(glassTubeColor), path);
            //底部
            var rectDi = new Rectangle(this.Width / 2 - m_rectWorking.Width, m_rectWorking.Bottom - m_rectWorking.Width - 2, m_rectWorking.Width * 2, m_rectWorking.Width * 2);
            g.FillEllipse(new SolidBrush(glassTubeColor), rectDi);
            g.FillEllipse(new SolidBrush(mercuryColor), new Rectangle(rectDi.Left + 4, rectDi.Top + 4, rectDi.Width - 8, rectDi.Height - 8));

            //值
            float fltHeightValue = (float)(Value / (maxValue - minValue) * m_rectLeft.Height);
            RectangleF rectValue = new RectangleF(m_rectWorking.Left + 4, m_rectLeft.Top + (m_rectLeft.Height - fltHeightValue), m_rectWorking.Width - 8, fltHeightValue + (m_rectWorking.Height - m_rectWorking.Width / 2 - m_rectLeft.Height));
            g.FillRectangle(new SolidBrush(mercuryColor), rectValue);
            //
            //刻度
            decimal decSplit = (maxValue - minValue) / spCount;
            decimal decSplitHeight = m_rectLeft.Height / spCount;
            for (int i = 0; i <= spCount; i++)
            {
                g.DrawLine(new Pen(new SolidBrush(ForeColor), 1), new PointF(m_rectLeft.Left + 1, (float)(m_rectLeft.Bottom - decSplitHeight * i)), new PointF(m_rectLeft.Left + 8, (float)(m_rectLeft.Bottom - decSplitHeight * i)));

                var valueLeft = (minValue + decSplit * i).ToString("0.#");
                var sizeLeft = g.MeasureString(valueLeft, Font);
                g.DrawString(valueLeft, Font, new SolidBrush(ForeColor), new PointF(m_rectLeft.Left - sizeLeft.Width - 2, m_rectLeft.Bottom - (float)decSplitHeight * i - 5));
                if (i != spCount)
                {
                    if (decSplitHeight > 40)
                    {
                        var decSp1 = decSplitHeight / 10;
                        for (int j = 1; j < 10; j++)
                        {
                            if (j == 5)
                            {
                                g.DrawLine(new Pen(new SolidBrush(ForeColor), 1), new PointF(m_rectLeft.Left + 1, (m_rectLeft.Bottom - (float)decSplitHeight * i - ((float)decSp1 * j))), new PointF(m_rectLeft.Left + 8, (m_rectLeft.Bottom - (float)decSplitHeight * i - ((float)decSp1 * j))));

                            }
                            else
                            {
                                g.DrawLine(new Pen(new SolidBrush(ForeColor), 1), new PointF(m_rectLeft.Left + 1, (m_rectLeft.Bottom - (float)decSplitHeight * i - ((float)decSp1 * j))), new PointF(m_rectLeft.Left + 5, (m_rectLeft.Bottom - (float)decSplitHeight * i - ((float)decSp1 * j))));

                            }
                        }
                    }
                    else if (decSplitHeight > 10)
                    {
                        g.DrawLine(new Pen(new SolidBrush(ForeColor), 1), new PointF(m_rectLeft.Left + 1, (m_rectLeft.Bottom - (float)decSplitHeight * i - (float)decSplitHeight / 2)), new PointF(m_rectLeft.Left + 5, (m_rectLeft.Bottom - (float)decSplitHeight * i - (float)decSplitHeight / 2)));

                    }
                }
            }

            //单位
            string strLeftUnit = GetUnitChar(leftTemperatureUnit);
            g.DrawString(strLeftUnit, Font, new SolidBrush(ForeColor), new PointF(m_rectLeft.Left + 2, 5));

            float bmaxValue = (float)(BMaxValue / (maxValue - minValue) * m_rectLeft.Height);
            float bminValue = (float)(BMinValue / (maxValue - minValue) * m_rectLeft.Height);

            //低温线
            g.DrawLine(new Pen(new SolidBrush(Color.Blue), 1), m_rectWorking.Left + 2, m_rectLeft.Top + (m_rectLeft.Height - bminValue), m_rectWorking.Left + m_rectWorking.Width, m_rectLeft.Top + (m_rectLeft.Height - bminValue));
            //高温线
            g.DrawLine(new Pen(new SolidBrush(Color.Orange), 1), m_rectWorking.Left + 2, m_rectLeft.Top + (m_rectLeft.Height - bmaxValue), m_rectWorking.Left + m_rectWorking.Width, m_rectLeft.Top + (m_rectLeft.Height - bmaxValue));

            var sizeValue = g.MeasureString(mValue.ToString("0.##"), ValueFont);

            g.DrawString(mValue.ToString("0.##"), ValueFont, new SolidBrush(ValueColor), new PointF(rectDi.Left + (rectDi.Width - sizeValue.Width) / 2, rectDi.Top + (rectDi.Height - sizeValue.Height) / 2 + 1));

        }

        private string GetUnitChar(TemperatureUnit unit)
        {
            string strUnit = "℃";
            switch (unit)
            {
                case TemperatureUnit.C:
                    strUnit = "℃";
                    break;
                case TemperatureUnit.F:
                    strUnit = "℉";
                    break;
                case TemperatureUnit.K:
                    strUnit = "K";
                    break;
                case TemperatureUnit.R:
                    strUnit = "°R";
                    break;
                case TemperatureUnit.Re:
                    strUnit = "°Re";
                    break;
            }
            return strUnit;
        }  
    }
}
