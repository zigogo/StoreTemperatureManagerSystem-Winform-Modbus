using Common;
using STML.Models.DModels;
using STMS.BLL;
using STMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STMS.store
{
    public partial class FrmStoreRegionInfo : Form
    {
        StoreRegionInfoBLL storeRegionInfoBLL =  new StoreRegionInfoBLL();
        public event Action RefreshDataGridStoreRegion;//刷新DataGridView
        public event Action RefreshDataGridStore;//刷新DataGridView
        FormInfo formInfo = null;//记录该窗体的类型以及主键Id
        StoreRegionInfo oldStoreRegionInfo = null;
        public FrmStoreRegionInfo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 仓库分区信息页面的窗体加载的事件处理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStoreRegionInfo_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                formInfo=this.Tag as FormInfo;
                InitializeFrom();
            }
        }
        /// <summary>
        /// 初始化窗体
        /// </summary>
        private void InitializeFrom()
        {
            //根据formInfo.FormType初始化
            if (formInfo != null)
            {
                labelTipTemperature.Visible = false;//不显示"*最低温度不能大于最高温度"
                FormUtility.LoadComboBoxStoresNew(comboBoxStoreName);
                switch (formInfo.FromType)//1：添加仓库信息   2：修改
                {
                    case 1://添加
                        uCircleButtonClear.Enabled = true;
                        panelLowHighTemper.Visible = false;//添加时不需要填写最高和最低温度
                        ClearAllBox();//清除TextBox内容
                        this.uCircleButtonSubmit.Text = "添加";
                        this.Text += "---添加";
                        break;
                    case 2://修改
                        uCircleButtonClear.Visible = false;
                        FillAllBox(formInfo.PrimaryKeyId);//填充TextBox内容
                        this.uCircleButtonSubmit.Text = "修改";
                        this.Text += "---修改";
                        break;
                    case 3://仓库管理页面点击的添加分区(固定所属仓库)
                        uCircleButtonClear.Enabled = true;
                        panelLowHighTemper.Visible = false;//添加时不需要填写最高和最低温度
                        ClearAllBox();
                        //设置所属仓库默认值
                        comboBoxStoreName.SelectedValue = formInfo.PrimaryKeyId;//StoreId
                        comboBoxStoreName.Enabled = false;
                        this.uCircleButtonSubmit.Text = "添加";
                        this.Text += "---添加";
                        break;
                }
            }
        }
        /// <summary>
        /// 填充修改前的数据
        /// </summary>
        /// <param name="primaryKeyId"></param>
        private void FillAllBox(int primaryKeyId)
        {
            oldStoreRegionInfo = storeRegionInfoBLL.GetStoreRegion(formInfo.PrimaryKeyId);
            if (oldStoreRegionInfo != null)
            {
                textBoxSRegionName.Text = oldStoreRegionInfo.SRegionName;
                textBoxSRegionNo.Text = oldStoreRegionInfo.SRegionNo;
                textBoxTemperature.Text = oldStoreRegionInfo.SRTemperature==null?"":oldStoreRegionInfo.SRTemperature.Value.ToString();
                textBoxHighTemper.Text = oldStoreRegionInfo.AllowHighTemperature == null ? "" : oldStoreRegionInfo.AllowHighTemperature.Value.ToString();
                textBoxLowTemper.Text = oldStoreRegionInfo.AllowLowTemperature == null ? "" : oldStoreRegionInfo.AllowLowTemperature.Value.ToString();
                textBoxSRegionRemark.Text = oldStoreRegionInfo.Remark;
                comboBoxStoreName.SelectedValue = oldStoreRegionInfo.StoreId;
            }
        }
        /// <summary>
        /// 清空控件的内容
        /// </summary>
        private void ClearAllBox()
        {
            textBoxSRegionName.Text = string.Empty;
            textBoxSRegionNo.Text = string.Empty;
            textBoxTemperature.Text = string.Empty;
            textBoxHighTemper.Text = string.Empty;
            textBoxLowTemper.Text = string.Empty;
            textBoxSRegionRemark.Text = string.Empty;
            if(formInfo.FromType!=3)//在指定仓库中添加分区不可改变所属仓库
                comboBoxStoreName.SelectedIndex = 0;
        }  
        /// <summary>
        /// "Submit"按钮点击事件处理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uCircleButtonSubmit_Click(object sender, EventArgs e)
        {
            string msgTitle = null;
            if (formInfo.FromType == 2)//修改仓库信息
                msgTitle = "修改";
            else
                msgTitle = "添加";
            //接收信息
            string sRegionNo = textBoxSRegionNo.Text.Trim();
            string sRegionName = textBoxSRegionName.Text.Trim();
            decimal? sRTemperature = textBoxTemperature.Text.Trim().GetDecimalOrNull();
            decimal? allowLowTemperature = textBoxLowTemper.Text.Trim().GetDecimalOrNull();
            decimal? allowHighTemperature = textBoxHighTemper.Text.Trim().GetDecimalOrNull();
            int storeId=comboBoxStoreName.SelectedValue.GetIntOrZero();
            string remark=textBoxSRegionRemark.Text.Trim();
            int temperState = 1;//正常
            if (string.IsNullOrEmpty(sRegionNo) || string.IsNullOrEmpty(sRegionName)
                || storeId == 0)//必填的没填
                return;
            if (allowHighTemperature != null && allowLowTemperature != null
                && allowLowTemperature > allowHighTemperature)//最低温度大于最高温度
                return;
            if (labelTipTemperature.Visible == true)//最低温度大于最高温度
                return;
            else if (allowHighTemperature != null && allowLowTemperature != null
                && sRTemperature != null && sRTemperature > allowHighTemperature)//该分区温度过高
                temperState = 2;
            else if (allowHighTemperature != null && allowLowTemperature != null
                && sRTemperature != null && sRTemperature < allowHighTemperature)//该分区温度过低
                temperState = 0;

            //封装信息
            StoreRegionInfo storeRegionInfo = new StoreRegionInfo()
            {
                SRegionId = formInfo.PrimaryKeyId,
                SRegionNo = sRegionNo,
                SRegionName = sRegionName,
                StoreId = storeId,
                AllowLowTemperature = allowLowTemperature,
                AllowHighTemperature = allowHighTemperature,
                SRTemperature = sRTemperature,
                TemperState = temperState,
                Remark = remark,
            };
            if (formInfo.FromType == 2)//修改仓库信息
            {
                //判断新的仓库分区名称和仓库分区编号是否已经存在
                     int existsCode = storeRegionInfoBLL.IsExistsStoreRegion
                    (oldStoreRegionInfo.SRegionName == sRegionName ? "" : sRegionName, oldStoreRegionInfo.SRegionNo == sRegionNo ? "" : sRegionNo);
                switch (existsCode)
                {
                    case 0://00都不存在
                        //分两种情况1.修改了所属的仓库  2.没有修改所属的仓库
                        if(oldStoreRegionInfo.StoreId!=storeId)//修改了所属的仓库
                        {
                            if (storeRegionInfoBLL.UpdateStoreRegion(storeRegionInfo, oldStoreRegionInfo.StoreId))
                            { 
                                MsgBoxHelper.MsgSuccessShow($"{msgTitle}仓库分区信息", $"仓库分区名称{sRegionName}信息修改成功");
                                RefreshDataGridStoreRegion.Invoke();//刷新dataGridView
                                this.Close(); 
                                return;
                            }
                            else
                                MsgBoxHelper.MsgErrorShow($"{msgTitle}仓库分区信息", $"仓库分区名称{sRegionName}信息修改失败");
                        }
                        else//没有修改所属的仓库
                        {
                            if (storeRegionInfoBLL.UpdateStoreRegion(storeRegionInfo))
                            {
                                MsgBoxHelper.MsgSuccessShow($"{msgTitle}仓库分区信息", $"仓库分区名称{sRegionName}信息修改成功");
                                RefreshDataGridStoreRegion.Invoke();//刷新dataGridView
                                this.Close();
                                return;
                            }
                            else
                                MsgBoxHelper.MsgErrorShow($"{msgTitle}仓库分区信息", $"仓库分区名称{sRegionName}信息修改失败");
                        }
                        break;
                    case 1://01storeNo存在
                        MsgBoxHelper.MsgErrorShow($"{msgTitle}仓库分区信息", $"仓库分区编号{sRegionNo}已存在");
                        break;
                    case 2://10storeName存在
                        MsgBoxHelper.MsgErrorShow($"{msgTitle}仓库分区信息", $"仓库分区名称{sRegionName}已存在");
                        break;
                    case 3://11都存在
                        MsgBoxHelper.MsgErrorShow($"{msgTitle}仓库分区信息", $"仓库分区名称{sRegionName}和仓库编号{sRegionNo}都已存在");
                        break;
                }
            }
            else //添加仓库信息
            {
                //判断新的仓库分区名称和仓库分区编号是否已经存在
                int existsCode = storeRegionInfoBLL.IsExistsStoreRegion(sRegionName, sRegionNo);
                switch (existsCode)
                {
                    case 0://00都不存在
                        if (storeRegionInfoBLL.AddStoreRegion(storeRegionInfo) == 0)//添加失败
                        {
                            MsgBoxHelper.MsgErrorShow($"{msgTitle}仓库分区信息", $"仓库分区名称{storeRegionInfo.SRegionName}信息添加失败");
                            return;
                        }
                        else//AddStore()返回的是新增仓库信息的StoreId，添加成功
                        {
                            if(formInfo.FromType==1)
                                RefreshDataGridStoreRegion.Invoke();//刷新dataGridView
                            if (formInfo.FromType == 3)
                                RefreshDataGridStore.Invoke();
                            MsgBoxHelper.MsgSuccessShow($"{msgTitle}仓库分区信息", $"仓库分区名称{storeRegionInfo.SRegionName}信息添加成功");
                            this.Close();
                            return;
                        }
                    case 1://01storeNo存在
                        MsgBoxHelper.MsgErrorShow($"{msgTitle}仓库分区信息", $"仓库分区编号{sRegionNo}已存在");
                        break;
                    case 2://10storeName存在
                        MsgBoxHelper.MsgErrorShow($"{msgTitle}仓库分区信息", $"仓库分区名称{sRegionName}已存在");
                        break;
                    case 3://11都存在
                        MsgBoxHelper.MsgErrorShow($"{msgTitle}仓库分区信息", $"仓库分区名称{sRegionName}和仓库编号{sRegionNo}都已存在");
                        break;
                }

            }
        }
        /// <summary>
        /// "清空"按钮点击事件处理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uCircleButtonClear_Click(object sender, EventArgs e)
        {
            ClearAllBox();
        }
      
        /// <summary>
        /// panelHead上"返回"按钮点击事件处理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uCircleButtonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 仓库分区名称文本框文本改变事件处理器
        /// </summary>
        private void textBoxSRegionName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSRegionName.Text.Trim()))//文本框为空
                labelTipName.Visible = true;
            else
                labelTipName.Visible = false;

        }
        /// <summary>
        /// 仓库分区编号文本框文本改变事件处理器
        /// </summary>
        private void textBoxSRegionNo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSRegionNo.Text.Trim()))//文本框为空
                labelTipNo.Visible = true;
            else
                labelTipNo.Visible = false;
        }
        /// <summary>
        /// 最低温度文本框文本改变事件处理器
        /// </summary>
        private void textBoxLowTemper_TextChanged(object sender, EventArgs e)
        {
            decimal? allowLowTemperature = textBoxLowTemper.Text.Trim().GetDecimalOrNull();
            decimal? allowHighTemperature = textBoxHighTemper.Text.Trim().GetDecimalOrNull();
            if(allowHighTemperature!=null&&allowLowTemperature!=null
                &&allowLowTemperature>allowHighTemperature)//低温大于高温
                labelTipTemperature.Visible = true;
            if (allowHighTemperature != null && allowLowTemperature != null
                && allowLowTemperature <= allowHighTemperature)//输入正常，不提示
                labelTipTemperature.Visible = false;

        }
        /// <summary>
        /// 最高温度文本框文本改变事件处理器
        /// </summary>
        private void textBoxHighTemper_TextChanged(object sender, EventArgs e)
        {
            decimal? allowLowTemperature = textBoxLowTemper.Text.Trim().GetDecimalOrNull();
            decimal? allowHighTemperature = textBoxHighTemper.Text.Trim().GetDecimalOrNull();
            if (allowHighTemperature != null && allowLowTemperature != null
                && allowLowTemperature > allowHighTemperature)//低温大于高温
                labelTipTemperature.Visible = true;
            if (allowHighTemperature != null && allowLowTemperature != null
                && allowLowTemperature <= allowHighTemperature)//输入正常，不提示
                labelTipTemperature.Visible = false;
        }
        /// <summary>
        /// 所属仓库下拉框选项改变事件处理器
        /// </summary>
        private void comboBoxStoreName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStoreName.SelectedIndex == 0)
                labelTipStoreId.Visible = true;
            else
                labelTipStoreId.Visible = false;
        }
    }
}
