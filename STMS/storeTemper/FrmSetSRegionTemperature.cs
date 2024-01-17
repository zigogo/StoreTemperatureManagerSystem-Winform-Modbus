using STMS.BLL;
using STMS.Models;
using STMS.UControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STMS.storeTemper
{
    public partial class FrmSetSRegionTemperature : Form
    {
        public FrmSetSRegionTemperature()
        {
            InitializeComponent();
        }
        public event Action<object, UStoreRegionArgs> ReloadRegionInfo;//刷新列表页该分区的温度与状态
        RegionTemperData rTData;//存放窗体信息
        bool isAdjust = false;//标识是否正在调温
        ViewSRegionTemperInfoBLL vSRTInfoBLL = new ViewSRegionTemperInfoBLL();
        /// <summary>
        /// 窗体FrmSetSRegionTemperature加载事件处理器
        /// </summary>
        private void FrmSetSRegionTemperature_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                rTData = this.Tag as RegionTemperData;
                if (rTData != null)
                {
                    if (rTData.TemperState == 0)
                        labelAdjustWayText.Text = "升温";
                    else
                        labelAdjustWayText.Text = "降温";
                }
                InitSetWays();
                numericUpDownTemper.Value = 0;
            }
        }
        /// <summary>
        /// 初始化复选框checkedListBoxAdjustWay
        /// </summary>
        private void InitSetWays()
        {
            checkedListBoxAdjustWay.Items.Clear();
            if (rTData.TemperState == 0)
            {
                checkedListBoxAdjustWay.Items.Add("打开热风");
                checkedListBoxAdjustWay.Items.Add("打开暖气");
                checkedListBoxAdjustWay.Items.Add("关闭窗户");
            }
            else
            {
                checkedListBoxAdjustWay.Items.Add("打开冷风");
                checkedListBoxAdjustWay.Items.Add("关闭暖气");
                checkedListBoxAdjustWay.Items.Add("打开窗户");
            }
        }
        /// <summary>
        /// "取消"按钮点击事件处理器
        /// </summary>
        private void uCircleButtonCancel_Click(object sender, EventArgs e)
        {
            if (isAdjust)//正在调温
                return;
            else
                this.Close();
        }
        /// <summary>
        /// "确认"按钮点击事件处理器
        /// </summary>
        private void uCircleButtonSubmit_Click(object sender, EventArgs e)
        {
            if (labelTipAdjustWay.Visible || labelTipTemper.Visible)
                return;
            //开始调温
            Task.Run(() =>
            {
                isAdjust = true;
                //需要UI线程调用改变UI的函数
                this.Invoke(new Action(() =>
                {
                    listBox.Items.Add($"开始{labelAdjustWayText.Text}处理");
                }));
                Thread.Sleep(2000);
                //将目标室温写入设备
                if (vSRTInfoBLL.SetSRTemperature(rTData.SId, numericUpDownTemper.Value))
                {
                    this.Invoke(new Action(() =>
                    {
                        listBox.Items.Add($"通知设备成功，正在更新数据库");
                    }));
                    Thread.Sleep(1000);

                    //将目标室温写入数据库
                    if (vSRTInfoBLL.UpdateSRTemperatureById(rTData.SRegionId, numericUpDownTemper.Value))
                    {
                        this.Invoke(new Action(() =>
                        {
                            listBox.Items.Add($"调整成功");
                            isAdjust = false;
                            //刷新分区盒子数据
                            UStoreRegionArgs uStoreRegionArgs = new UStoreRegionArgs(rTData.SRegionId, 1, numericUpDownTemper.Value);
                            ReloadRegionInfo.Invoke(this,uStoreRegionArgs);
                        }));
                    }
                    else//目标室温写入数据库失败
                    {
                        this.Invoke(new Action(() =>
                        {
                            isAdjust = false;
                            listBox.Items.Add($"调整失败，更新数据库时出错");
                        }));
                    }
                }
                else//目标室温写入设备失败
                {
                    this.Invoke(new Action(() =>
                    {
                        isAdjust = false;
                        listBox.Items.Add($"处理失败，连接设备时出错");
                    }));
                }
            });

        }
        /// <summary>
        /// numericUpDownTemper数值改变事件处理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownTemper_ValueChanged(object sender, EventArgs e)
        {
            if (this.numericUpDownTemper.Value < rTData.LowTemperature)
            {
                labelTipTemper.Visible = true;
                labelTipTemper.Text = "目标温度不可低于最低温度";
                return;
            }
            if (this.numericUpDownTemper.Value > rTData.HighTemperature)
            {
                labelTipTemper.Visible = true;
                labelTipTemper.Text = "目标温度不可高于最高温度";
                return;
            }
            labelTipTemper.Visible = false;
        }
        /// <summary>
        /// 复选框checkedListBoxAdjustWay选项改变事件处理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkedListBoxAdjustWay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBoxAdjustWay.CheckedItems.Count == 0)
            {
                labelTipAdjustWay.Visible = true;
                return;
            }
            labelTipAdjustWay.Visible = false;
        }

        private void FrmSetSRegionTemperature_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isAdjust)//正在调温
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
