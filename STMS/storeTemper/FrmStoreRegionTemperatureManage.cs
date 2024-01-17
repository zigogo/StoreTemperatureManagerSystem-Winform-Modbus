using Common;
using STML.Models.UIModels;
using STMS.BLL;
using STMS.Models;
using STMS.store;
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
    public partial class FrmStoreRegionTemperatureManage : Form
    {
        public FrmStoreRegionTemperatureManage()
        {
            InitializeComponent();
        }
        ViewSRegionTemperInfoBLL viewSRegionTemperInfoBLL = new ViewSRegionTemperInfoBLL();
        /// <summary>
        /// 窗体FrmStoreRegionTemperatureManage加载事件处理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStoreRegionTemperatureManage_Load(object sender, EventArgs e)
        {
            //加载仓库下拉框
            FormUtility.LoadComboBoxStoresSearch(comboBoxStore);
            labelTip.Visible = false;
            //加载分区信息盒子
            LoadSRegionBoxList();
        }
        /// <summary>
        /// 根据storeId加载分区信息盒子
        /// </summary>
        private void LoadSRegionBoxList()
        {
            //获取选择的仓库
            int storeId = comboBoxStore.SelectedValue.GetIntOrZero();
            List<StoreRegionBoxModel> storeRegionBoxModels = viewSRegionTemperInfoBLL.GetSRegionBoxModelInfo(storeId);
            ShowSRegionBoxList(storeRegionBoxModels);
        }
        /// <summary>
        /// 根据StoreRegionBoxModel列表加载分区信息盒子
        /// </summary>
        /// <param name="boxs"></param>
        private void ShowSRegionBoxList(List<StoreRegionBoxModel> boxs)
        {
            //清除flowLayoutPanel的内容
            flowLayoutPanel.Controls.Clear();
            if (boxs.Count > 0)
            {
                foreach (StoreRegionBoxModel box in boxs)
                {
                    UStoreRegionBox uStoreRegionBox = new UStoreRegionBox();
                    uStoreRegionBox.UBoxSource = box;
                    if (box.TemperState != 1)//温度不正常
                    {
                        //显示升温或者降温按钮
                        uStoreRegionBox.SetTemperature += UStoreRegionBox_SetTemperature;
                    }
                    uStoreRegionBox.Margin = new Padding(10, 20, 10, 20);
                    //将仓库盒子加入flowLayoutPanel盒子中
                    flowLayoutPanel.Controls.Add(uStoreRegionBox);
                }
            }
        }
        /// <summary>
        /// 显示升温或降温页面
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        private void UStoreRegionBox_SetTemperature(object sender, UStoreRegionArgs e)
        {
            ShowSetTemperaturePage(e);
        }
        /// <summary>
        /// 显示升温或降温页面
        /// </summary>
        /// <param name="e"></param>
        private void ShowSetTemperaturePage(UStoreRegionArgs e)
        {
            FrmSetSRegionTemperature frmSetSRegionTemperature = new FrmSetSRegionTemperature();
            frmSetSRegionTemperature.Tag = new RegionTemperData()
            {
                SRegionId = e.SRegionId,
                TemperState = e.TemperState,
                LowTemperature = e.LowTemperature,
                HighTemperature = e.HighTemperature,
                SId = e.SId
            };
            //订阅刷新事件
            frmSetSRegionTemperature.ReloadRegionInfo += ReloadRegionInfo;
            frmSetSRegionTemperature.StartPosition=FormStartPosition.CenterScreen;//设置页面显示的位置
            frmSetSRegionTemperature.Show();
        }
        /// <summary>
        /// 刷新列表页的温度和状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReloadRegionInfo(object sender, UStoreRegionArgs e)
        {
            foreach (Control c in flowLayoutPanel.Controls)
            {
                UStoreRegionBox uStoreRegionBox = c as UStoreRegionBox;
                if (uStoreRegionBox.SId == e.SId)
                {
                    uStoreRegionBox.SRTemper = e.SRTemperature;
                    uStoreRegionBox.TemperState = e.TemperState;
                    break;
                }
            }
        }
        /// <summary>
        /// "手动检测"按钮点击事件处理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uCircleButtonCheck_Click(object sender, EventArgs e)
        {
            labelTip.Visible = true;
            labelTip.ForeColor = Color.White;
            //显示信息，为了不阻塞UI线程要使用Task
            Task.Run(() =>
            {
                this.Invoke(new Action(() =>
                {
                    labelTip.Text = "开始读取,请稍后...";
                }));
                Thread.Sleep(500);
                this.Invoke(new Action(() =>
                {
                    labelTip.Text = "读取中,请稍后...";
                }));
                Thread.Sleep(500);
                try
                {
                    this.Invoke(new Action(() =>
                    {
                        //从设备读取分区温度数据并更新到数据库，返回最新的分区温度数据viewSRegionTemperInfos
                        List<StoreRegionBoxModel> sRBoxModels = viewSRegionTemperInfoBLL.ReadRegionTemperData();
                        if(sRBoxModels != null&&sRBoxModels.Count!=0)
                        {
                            ShowSRegionBoxList(sRBoxModels);
                            labelTip.Text = "检测完成";
                        }
                        else
                        {
                            labelTip.Text = "检测失败，请检查设备";
                            labelTip.ForeColor = Color.Red;
                        }
                    }));
                }
                catch (Exception ex)
                {
                    throw new Exception("检测失败",ex);
                }
            });

        }
        /// <summary>
        /// 仓库下拉框comboBoxStore选项改变事件处理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSRegionBoxList();
        }
        /// <summary>
        /// "刷新"按钮点击事件处理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uCircleButtonRefresh_Click(object sender, EventArgs e)
        {
            comboBoxStore.SelectedIndex = 0;
            labelTip.Text = "";
            LoadSRegionBoxList();  
        }
    }
}
