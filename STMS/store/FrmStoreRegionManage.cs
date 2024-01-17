using Common;
using STML.Models.DModels;
using STML.Models.VModels;
using STMS.BLL;
using STMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace STMS.store
{
    public partial class FrmStoreRegionManage : Form
    {
        public FrmStoreRegionManage()
        {
            InitializeComponent();
        }
        bool isShowDelete = false;//标识是否显示已删除的数据---false:未删除   true:已删除
        StoreRegionInfoBLL storeRegionInfoBLL = new StoreRegionInfoBLL();
        ViewStoreRegionBLL viewStoreRegionBLL = new ViewStoreRegionBLL();
        /// <summary>
        /// uPanelHead上"刷新"按钮的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uCircleButtonRefresh_Click(object sender, EventArgs e)
        {
            //清空限制的条件重新加载数据
            comboBoxMenuState.SelectedIndex = 0;
            comboBoxMenuStore.SelectedIndex = 0;
            textBoxWordOfSearch.Text = string.Empty;
            LoadStoreRegionInfos();
        }
        /// <summary>
        /// uPanelMenu上"新增"按钮的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uCircleButtonNew_Click(object sender, EventArgs e)
        {
            //1：表示是新增的窗体
            //0：新增不需要传入主键
            ShowFrmStoreRegionInfo(new FormInfo(1,0));
        }
        /// <summary>
        /// uPanelMenu上"删除"按钮的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uCircleButtonDelete_Click(object sender, EventArgs e)
        {
            string messageTitle = "仓库分区信息删除";
            List<StoreRegionInfo> storeRegionInfosList = new List<StoreRegionInfo>();
            //获取dataGridView上所选择的行的StoreId
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataGridViewCheckBoxCell dataGridViewCheckBoxCell = row.Cells["ColumnCheck"] as DataGridViewCheckBoxCell;
                if (dataGridViewCheckBoxCell.FormattedValue.ToString() == "True")//选中
                {
                    ViewStoreRegionInfo viewStoreRegionInfo = row.DataBoundItem as ViewStoreRegionInfo;
                    storeRegionInfosList.Add(new StoreRegionInfo() { SRegionId=viewStoreRegionInfo.SRegionId,StoreId=viewStoreRegionInfo.StoreId});//将选中的StoreId添加到列表
                }
            }
            if (storeRegionInfosList.Count > 0)//有选中的
            {
                if (MsgBoxHelper.MsgConfirmShow(messageTitle, "你确定要删除所选择的仓库分区信息吗？") == DialogResult.Yes)
                {
                    string reStr = storeRegionInfoBLL.LogicDeleteStoreRegion(storeRegionInfosList);
                    //reStr="Y":删除成功
                    //"0":删除失败
                    //"1,2,4":表示storeID1,2,4存在产品
                    switch (reStr)
                    {
                        case "Y"://删除成功
                            MsgBoxHelper.MsgSuccessShow(messageTitle, "删除成功");
                            LoadStoreRegionInfos();
                            break;
                        case "0"://删除失败
                            MsgBoxHelper.MsgErrorShow(messageTitle, "删除失败");
                            break;
                        default://存在产品，删除失败
                            MsgBoxHelper.MsgErrorShow(messageTitle, $"删除失败，仓库分区编号为{reStr}的仓库存在产品！");
                            break;
                    }
                }
            }
            else//没有进行选择
            {
                MsgBoxHelper.MsgErrorShow(messageTitle, "请选择需要删除的仓库分区");
                return;
            }
        }
        /// <summary>
        /// uPanelMenu上"显示已删除数据"按钮的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uCircleBtnSwitchContent_Click(object sender, EventArgs e)
        {
            SwitchShowContent();
            LoadStoreRegionInfos();
        }
        /// <summary>
        /// 切换dataGridView显示的内容：未删除数据/已删除数据
        /// </summary>
        private void SwitchShowContent()
        {
            if (isShowDelete)//已删除
            {
                isShowDelete = false;
                dataGridView.dGVShowContent(isShowDelete);
                //修改按钮的文本
                uCircleBtnSwitchContent.Text = "显示已删除数据";
                uCircleButtonDelete.Visible = true;
                uCircleButtonNew.Visible = true;
            }
            else
            {
                isShowDelete = true;
                dataGridView.dGVShowContent(isShowDelete);
                //修改按钮的文本
                uCircleBtnSwitchContent.Text = "显示未删除数据";
                uCircleButtonDelete.Visible = false;
                uCircleButtonNew.Visible = false;
            }
        }
        /// <summary>
        /// FrmStoreRegionManage仓库分区管理页面的加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStoreRegionManage_Load(object sender, EventArgs e)
        {
            //清除查询框内容
            textBoxWordOfSearch.Clear();

            //加载仓库下拉框
            FormUtility.LoadComboBoxStoresSearch(comboBoxMenuStore);
            //加载状态下拉框
            FormUtility.LoadComboBoxStates(comboBoxMenuState);

            //加载dataGridView的数据
            LoadStoreRegionInfos();
        }
        /// <summary>
        /// 获取下拉框和查询文本框内容进行加载页面数据
        /// </summary>
        private void LoadStoreRegionInfos()
        {
            int comboBoxStoreId = comboBoxMenuStore.SelectedValue.GetIntOrZero();
            int comboBoxTemperState = comboBoxMenuState.SelectedValue.GetIntOrZero();
            string wordOfSearch = textBoxWordOfSearch.Text.Trim();
            this.dataGridView.dGVShowContent(isShowDelete);//显示dataViewGrid的操作列
            List<ViewStoreRegionInfo> viewStoreRegionInfoList = viewStoreRegionBLL.GetStoreRegionInfos(comboBoxStoreId, comboBoxTemperState, wordOfSearch, isShowDelete);
            if (viewStoreRegionInfoList.Count > 0)//在限制条件下有结果
            {
                dataGridView.AutoGenerateColumns = false;
                dataGridView.DataSource = viewStoreRegionInfoList;
                uCircleButtonDelete.Enabled = true;
            }
            else//没有结果
            {
                //使"删除"按钮无效
                dataGridView.DataSource = null;
                uCircleButtonDelete.Enabled = false;
            }
        }


        #region 下拉框和查询框自动筛选数据处理
        /// <summary>
        /// 选择仓库下拉框文本改变事件处理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxMenuStore_TextChanged(object sender, EventArgs e)
        {
            LoadStoreRegionInfos();
        }
        /// <summary>
        /// 选择分区状态下拉框文本改变事件处理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxMenuState_TextChanged(object sender, EventArgs e)
        {
            LoadStoreRegionInfos();
        }
        /// <summary>
        /// 搜索文本框文本改变事件处理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxWordOfSearch_TextChanged(object sender, EventArgs e)
        {
            LoadStoreRegionInfos();
        }
        #endregion
        /// <summary>
        /// 点击dataGridView单元格的事件处理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //根据点击的行列可以获取所在行的ViewStoreRegionInfo对象 和 所在单元格的值--可以判断需要进行什么操作
                string cellText = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
                ViewStoreRegionInfo viewStoreRegionInfo = dataGridView.Rows[e.RowIndex].DataBoundItem as ViewStoreRegionInfo;
                switch (cellText)//根据单元格的文本可以判断执行什么操作
                {
                    case "修改":
                        //打开仓库信息页
                        ShowFrmStoreRegionInfo(new FormInfo(2, viewStoreRegionInfo.SRegionId));
                        break;
                    case "删除":
                        DeleteStoreRegion(viewStoreRegionInfo, 0);//delType=0:逻辑删除  1:真删除  2:恢复
                        //执行假删除
                        break;
                    case "恢复":
                        DeleteStoreRegion(viewStoreRegionInfo, 2);//delType=0:逻辑删除  1:真删除  2:恢复
                        //恢复假删除
                        break;
                    case "移除":
                        DeleteStoreRegion(viewStoreRegionInfo, 1);//delType=0:逻辑删除  1:真删除  2:恢复
                        //删除假删除的数据
                        break;
                }
            }
            catch (ArgumentOutOfRangeException exception)
            {
                //点击DataGridView第一行(即各列的列名)时会触发事件，并且e.RowIndex=-1
                //dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex]会抛出ArgumentOutOfRangeException
            }
        }
        /// <summary>
        /// 逻辑删除/真删除/恢复仓库信息
        /// delType=0:逻辑删除  1:真删除  2:恢复
        /// </summary>
        /// <param name="sRegionId">仓库分区主键sRegionId</param>
        /// <param name="delType">0:逻辑删除  1:真删除  2:恢复</param>
        private void DeleteStoreRegion(ViewStoreRegionInfo viewStoreRegionInfo, int delType)
        {
            string formName = "仓库分区信息";
            string delName = FormUtility.GetDelName(delType);
            string messageTitle = $"{formName}{delName}";
            DialogResult dialogResult = MsgBoxHelper.MsgConfirmShow(messageTitle, $"你确定要{delName}该{formName}吗？");

            if (dialogResult == DialogResult.Yes)//点击确认后开始执行
            {
                switch (delType)
                {
                    case 0://逻辑删除
                        switch (storeRegionInfoBLL.LogicDeleteStoreRegion(viewStoreRegionInfo.SRegionId,viewStoreRegionInfo.StoreId))
                        {
                            case 0://删除失败
                                MsgBoxHelper.MsgErrorShow(messageTitle, "删除失败");
                                break;
                            case 1://删除成功
                                MsgBoxHelper.MsgSuccessShow(messageTitle, "删除成功");
                                break;
                            case 2://添加了分区
                                MsgBoxHelper.MsgErrorShow(messageTitle, "删除失败，该仓库分区存在产品，请先将产品移除");
                                break;
                        }
                        break;
                    case 1://真删除
                        storeRegionInfoBLL.DeleteStore(viewStoreRegionInfo.SRegionId, viewStoreRegionInfo.StoreId);
                        MsgBoxHelper.MsgSuccessShow(messageTitle, "移除成功");
                        break;
                    case 2://恢复
                        storeRegionInfoBLL.RecoverStore(viewStoreRegionInfo.SRegionId, viewStoreRegionInfo.StoreId);
                        MsgBoxHelper.MsgSuccessShow(messageTitle, "恢复成功");
                        break;
                }
                LoadStoreRegionInfos();
            }
        }

        /// <summary>
        /// 显示仓库分区信息页面
        /// </summary>
        /// <param name="formInfo"></param>
        private void ShowFrmStoreRegionInfo(FormInfo formInfo)
        {
            FrmStoreRegionInfo frmStoreRegionInfo = new FrmStoreRegionInfo();
            frmStoreRegionInfo.Tag = formInfo;
            frmStoreRegionInfo.RefreshDataGridStoreRegion += LoadStoreRegionInfos;//给RefreshDataGridV事件加上事件处理器
            frmStoreRegionInfo.StartPosition = FormStartPosition.CenterScreen;
            frmStoreRegionInfo.ShowDialog();
        }
    }
}
