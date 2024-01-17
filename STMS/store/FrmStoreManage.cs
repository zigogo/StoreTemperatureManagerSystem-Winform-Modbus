using Common;
using STML.Models.DModels;
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
    public partial class FrmStoreManage : Form
    {
        public FrmStoreManage()
        {
            InitializeComponent();
        }
        StoreInfoBLL storeInfosBLL = new StoreInfoBLL();
        public event Action RefreshDataGridV;//刷新DataGridView
        /// <summary>
        /// 窗体加载的事件处理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStoreManage_Load(object sender, EventArgs e)
        {
            //清除搜索框内容textBoxStoreNameOfSearch
            this.textBoxWordOfSearch.Clear();

            //加载dataGridView的数据
            LoadStoreInfos();
        }
        /// <summary>
        /// 加载dataGridVIew的数据
        /// </summary>
        public void LoadStoreInfos()
        {
            //处理查询框-首位去空格
            string wordOfSearch = textBoxWordOfSearch.Text.Trim();
            //显示datagridView的操作列
            dataGridView.dGVShowContent(isShowDelete);
            dataGridView.Columns["ColumnAddRegion"].Visible = !isShowDelete;
            List<StoreInfo> storeInfosList = storeInfosBLL.GetStoreInfos(wordOfSearch, isShowDelete);
            if (storeInfosList.Count > 0)//返回的仓库信息列表有数据
            {
                dataGridView.AutoGenerateColumns = false;
                dataGridView.DataSource = storeInfosList;
                uCircleButtonDelete.Enabled = true;//使删除按钮有效
            }
            else
            {
                dataGridView.DataSource = null;
                uCircleButtonDelete.Enabled = false;//使删除按钮无效
            }
        }

        #region 处理uPageMenu上"显示已删除数据"按钮

        bool isShowDelete = false;//标识是否显示已删除的数据---false:未删除   true:已删除

        /// <summary>
        /// uPageMenu上"显示已删除数据"按钮的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uCircleBtnSwitchContent_Click(object sender, EventArgs e)
        {
            //切换dataGridView显示的内容：未删除数据/已删除数据
            SwitchShowContent();
            LoadStoreInfos();
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
        #endregion

        /// <summary>
        /// uPanelHead上"刷新"按钮的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uCircleButtonRefresh_Click(object sender, EventArgs e)
        {
            textBoxWordOfSearch.Text = "";
            LoadStoreInfos();
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
            ShowFrmStoreInfo(new FormInfo(1, 0));
        }
        /// <summary>
        /// 显示仓库信息页面
        /// </summary>
        /// <param name="formInfo"></param>
        private void ShowFrmStoreInfo(FormInfo formInfo)
        {
            FrmStoreInfo frmStoreInfo = new FrmStoreInfo();
            frmStoreInfo.Tag = formInfo;

            frmStoreInfo.RefreshDataGridV += LoadStoreInfos;//给RefreshDataGridV事件加上事件处理器
            frmStoreInfo.StartPosition = FormStartPosition.CenterScreen;//设置页面显示的位置
            frmStoreInfo.ShowDialog();
        }
        /// <summary>
        /// uPanelMenu上"删除"按钮的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uCircleButtonDelete_Click(object sender, EventArgs e)
        {
            string messageTitle = "仓库信息删除";
            List<int> storeIds = new List<int>();
            //获取dataGridView上所选择的行的StoreId
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataGridViewCheckBoxCell dataGridViewCheckBoxCell = row.Cells["ColumnCheck"] as DataGridViewCheckBoxCell;
                if (dataGridViewCheckBoxCell.FormattedValue.ToString()== "True")//选中
                {
                    StoreInfo storeInfo = row.DataBoundItem as StoreInfo;
                    storeIds.Add(storeInfo.StoreId);//将选中的StoreId添加到列表
                }
            }
            if (storeIds.Count > 0)//有选中的
            {
                if(MsgBoxHelper.MsgConfirmShow(messageTitle, "你确定要删除所选择的仓库信息吗？")==DialogResult.Yes)
                {
                    string reStr = storeInfosBLL.LogicDeleteStore(storeIds);
                    //reStr="Y":删除成功
                    //"0":删除失败
                    //"1,2,4":表示storeID1,2,4存在分区
                    switch (reStr)
                    {
                        case "Y"://删除成功
                            MsgBoxHelper.MsgSuccessShow(messageTitle, "删除成功");
                            LoadStoreInfos();
                            break;
                        case "0"://删除失败
                            MsgBoxHelper.MsgErrorShow(messageTitle, "删除失败");
                            break;
                        default://存在分区，删除失败
                            MsgBoxHelper.MsgErrorShow(messageTitle, $"删除失败，仓库编号为{reStr}的仓库存在分区！");
                            break;
                    }
                }
            }
            else//没有进行选择
            {
                MsgBoxHelper.MsgErrorShow(messageTitle, "请选择需要删除的仓库");
                return;
            }
        }
        /// <summary>
        /// 显示添加仓库分区页面
        /// </summary>
        private void showFrmStoreRegionInfo(FormInfo formInfo)
        {
            FrmStoreRegionInfo frmStoreRegionInfo = new FrmStoreRegionInfo();
            frmStoreRegionInfo.Tag = formInfo;
            frmStoreRegionInfo.RefreshDataGridStore += LoadStoreInfos;//给RefreshDataGridV事件加上事件处理器
            frmStoreRegionInfo.StartPosition = FormStartPosition.CenterScreen;
            frmStoreRegionInfo.ShowDialog();
        }
        /// <summary>
        /// DataGridView单元格的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //根据点击的行列可以获取所在行的StoreInfo对象 和 所在单元格的值--可以判断需要进行什么操作
                string cellText = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
                StoreInfo storeInfo = dataGridView.Rows[e.RowIndex].DataBoundItem as StoreInfo;
                switch (cellText)//根据单元格的文本可以判断执行什么操作
                {
                    case "添加分区":
                        //打开添加分区信息页
                        showFrmStoreRegionInfo(new FormInfo(3, storeInfo.StoreId));
                        break;
                    case "修改":
                        //打开仓库信息页
                        ShowFrmStoreInfo(new FormInfo(2, storeInfo.StoreId));
                        break;
                    case "删除":
                        DeleteStore(storeInfo.StoreId, 0);//delType=0:逻辑删除  1:真删除  2:恢复
                        //执行假删除
                        break;
                    case "恢复":
                        DeleteStore(storeInfo.StoreId, 2);//delType=0:逻辑删除  1:真删除  2:恢复
                        //恢复假删除
                        break;
                    case "移除":
                        DeleteStore(storeInfo.StoreId, 1);//delType=0:逻辑删除  1:真删除  2:恢复
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
        /// <param name="storeId">仓库的主键ID</param>
        /// <param name="delType">0:逻辑删除  1:真删除  2:恢复</param>
        private void DeleteStore(int storeId, int delType)
        {
            string formName = "仓库信息";
            string delName = FormUtility.GetDelName(delType);
            string messageTitle = $"{formName}{delName}";
            DialogResult dialogResult = MsgBoxHelper.MsgConfirmShow(messageTitle, $"你确定要{delName}该{formName}吗？");

            if (dialogResult == DialogResult.Yes)//点击确认后开始执行
            {
                switch (delType)
                {
                    case 0://逻辑删除
                        switch (storeInfosBLL.LogicDeleteStore(storeId))
                        {
                            case 0://删除失败
                                MsgBoxHelper.MsgErrorShow(messageTitle, "删除失败");
                                break;
                            case 1://删除成功
                                MsgBoxHelper.MsgSuccessShow(messageTitle, "删除成功");
                                break;
                            case 2://添加了分区
                                MsgBoxHelper.MsgErrorShow(messageTitle, "删除失败，该仓库存在分区，请先将分区移除");
                                break;
                        }
                        break;
                    case 1://真删除
                        storeInfosBLL.DeleteStore(storeId);
                        MsgBoxHelper.MsgSuccessShow(messageTitle, "移除成功");
                        break;
                    case 2://恢复
                        storeInfosBLL.RecoverStore(storeId);
                        MsgBoxHelper.MsgSuccessShow(messageTitle, "恢复成功");
                        break;
                }
                LoadStoreInfos();
            }
        }
        /// <summary>
        /// uPanelMenu上textBoxWordOfSearch查询文本框的内容改变时的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxWordOfSearch_TextChanged(object sender, EventArgs e)
        {
            LoadStoreInfos();
        }
    }
}
