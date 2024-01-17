using STML.Models.UIModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STMS.UControls
{
    public partial class UStoreRegionBox : UserControl
    {
        public UStoreRegionBox()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 数据集对象
        /// </summary>
        private StoreRegionBoxModel uBoxSource;
        public StoreRegionBoxModel UBoxSource
        {
            get { return uBoxSource; }
            set
            {
                uBoxSource = value;
                //赋值
                this.SId = uBoxSource.SId;
                this.ProductCount = uBoxSource.ProductCount;
                this.SRgeionName = uBoxSource.SRegionName;
                this.TemperRange = uBoxSource.TemperRange;
                this.TemperState = uBoxSource.TemperState;
                this.MaxTemper = uBoxSource.MaxTemper;
                this.MinTemper = uBoxSource.MinTemper;
                this.SRTemper = uBoxSource.SRTemper;
                this.SRegionId = uBoxSource.SRgionId;
            }
        }
        /// <summary>
        /// 编号 
        /// </summary>
        public int SId
        {
            get { return uBoxSource.SId; }
            set
            {
                uBoxSource.SId = value;
            }
        }
        public int SRegionId
        {
            get { return uBoxSource.SRgionId; }
            set { uBoxSource.SRgionId = value; }
        }
        /// <summary>
        /// 分区名称
        /// </summary>
        public string SRgeionName
        {
            get { return uBoxSource.SRegionName; }
            set
            {
                uBoxSource.SRegionName = value;
                this.labelSRegionName.Text = uBoxSource.SRegionName;
            }
        }

        /// <summary>
        /// 设置按钮的显示（升温或降温按钮）
        /// </summary>
        public bool BtnSetVisible
        {
            get { return uBoxSource.BtnSetVisible; }
            set
            {
                uBoxSource.BtnSetVisible = value;
                this.uCircleButton.Visible = uBoxSource.BtnSetVisible;
            }
        }

        /// <summary>
        /// 设置按钮的文本
        /// </summary>
        public string BtnSetText
        {
            get { return uBoxSource.BtnSetText; }
            set
            {
                uBoxSource.BtnSetText = value;
                this.uCircleButton.Text = uBoxSource.BtnSetText;
            }
        }

        /// <summary>
        /// 该仓库分区的温度状态
        /// </summary>
        public int TemperState
        {
            get { return uBoxSource.TemperState; }
            set
            {
                uBoxSource.TemperState = value;
                switch (uBoxSource.TemperState)
                {
                    case 0://低温
                        this.uBoxSource.StateColor = Color.Green;
                        this.labelTemperState.Text = "低温";
                        this.uBoxSource.BtnSetVisible = true;
                        this.uBoxSource.BtnSetText = "升温";
                        break;
                    case 1://正常
                        this.uBoxSource.StateColor = Color.Orange;
                        this.labelTemperState.Text = "正常";
                        this.uBoxSource.BtnSetVisible = false;
                        this.uBoxSource.BtnSetText = "";
                        break;
                    case 2://高温
                        this.uBoxSource.StateColor = Color.Red;
                        this.labelTemperState.Text = "高温";
                        this.uBoxSource.BtnSetVisible = true;
                        this.uBoxSource.BtnSetText = "降温";
                        break;
                }
                this.uCircleTemperatureState.ForeColor = this.uBoxSource.StateColor;
                this.uCircleButton.Visible = this.uBoxSource.BtnSetVisible;
                this.uCircleButton.Text = this.uBoxSource.BtnSetText;
            }
        }

        /// <summary>
        /// 指示灯颜色
        /// </summary>
        public Color StateColor
        {
            get { return uBoxSource.StateColor; }
            set
            {
                uBoxSource.StateColor = value;
                this.uCircleTemperatureState.ForeColor = uBoxSource.StateColor;
            }
        }

        /// <summary>
        /// 产品数量
        /// </summary>
        public int ProductCount
        {
            get { return uBoxSource.ProductCount; }
            set
            {
                uBoxSource.ProductCount = value;
                this.labelProductCount.Text = uBoxSource.ProductCount.ToString();
            }
        }

        /// <summary>
        /// 室内温度
        /// </summary>
        public decimal SRTemper
        {
            get { return uBoxSource.SRTemper; }
            set
            {
                uBoxSource.SRTemper = value;
                this.labelTemperature.Text = uBoxSource.SRTemper.ToString();
                uThermometer.Value = uBoxSource.SRTemper;
            }
        }

        public decimal MaxTemper
        {
            get { return uBoxSource.MaxTemper; }
            set
            {
                uBoxSource.MaxTemper = value;
                uThermometer.BMaxValue = uBoxSource.MaxTemper;
            }
        }

        public decimal MinTemper
        {
            get { return uBoxSource.MinTemper; }
            set
            {
                uBoxSource.MinTemper = value;
                uThermometer.BMinValue = uBoxSource.MinTemper;
            }
        }

        /// <summary>
        /// 室内温度范围
        /// </summary>
        public string TemperRange
        {
            get { return uBoxSource.TemperRange; }
            set
            {

                uBoxSource.TemperRange = value;
                this.labelLowAndHighTemperature.Text = uBoxSource.TemperRange.ToString() + "℃";
            }
        }

        public event Action<object, UStoreRegionArgs> SetTemperature;//设置分区温度事件

        /// <summary>
        /// 升温或降温
        /// </summary>
        private void uCircleButton_Click(object sender, EventArgs e)
        {
            UStoreRegionArgs args = new UStoreRegionArgs(this.SId, this.SRegionId, this.TemperState, this.MinTemper, this.MaxTemper);
            SetTemperature?.Invoke(sender, args);
        }
    }
}
