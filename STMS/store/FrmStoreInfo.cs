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
    public partial class FrmStoreInfo : Form
    {
        public event Action RefreshDataGridV;//刷新DataGridView
        public FrmStoreInfo()
        {
            InitializeComponent();
        }
        FormInfo formInfo = null;//记录该窗体的类型以及StoreId
        StoreInfoBLL storeInfosBLL = new StoreInfoBLL();
        StoreInfo oldStoreInfo=null;

        /// <summary>
        /// FrmStoreInfo页面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStoreInfo_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                formInfo = this.Tag as FormInfo;
                InitializeFrom();
            }
        }
        /// <summary>
        /// 初始化窗体的信息
        /// </summary>
        private void InitializeFrom()
        {
            if (formInfo != null)
            {
                switch (formInfo.FromType)//1：添加仓库信息   2：修改
                {
                    case 1://添加
                        uCircleButtonClear.Enabled = true;
                        ClearTextBox();//清除TextBox内容
                        this.uCircleButtonSubmit.Text = "添加";
                        this.Text += "---添加";
                        break;
                    case 2://修改
                        uCircleButtonClear.Visible = false;
                        FillTextBox(formInfo.PrimaryKeyId);//填充TextBox内容
                        this.uCircleButtonSubmit.Text = "修改";
                        this.Text += "---修改";
                        break;
                }
            }
        }
        /// <summary>
        /// 把未修改的仓库信息填充到TextBox中
        /// </summary>
        private void FillTextBox(int storeId)
        {
            oldStoreInfo = storeInfosBLL.GetStore(storeId);

            this.textBoxStoreName.Text = oldStoreInfo.StoreName;
            this.textBoxStoreNo.Text = oldStoreInfo.StoreNo;
            this.textBoxStoreRemark.Text = oldStoreInfo.Remark;

        }
        /// <summary>
        /// 清空TextBox的内容
        /// </summary>
        private void ClearTextBox()
        {
            textBoxStoreName.Clear();
            textBoxStoreNo.Clear();
            textBoxStoreRemark.Clear();
        }

        /// <summary>
        /// "确认"按钮的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uCircleButtonSubmit_Click(object sender, EventArgs e)
        {
            string msgTitle = null;
            if (formInfo.FromType == 1)//添加仓库信息
                msgTitle = "添加";
            else
                msgTitle = "修改";
            //获取输入到TextBox中的内容
            string storeName = textBoxStoreName.Text;
            string storeNo = textBoxStoreNo.Text;
            string storeRemark = textBoxStoreRemark.Text;
            //仓库名称和仓库编码不能为空
            if (string.IsNullOrEmpty(storeName))
                return;
            if (string.IsNullOrEmpty(storeNo))
                return;
            //封装成StoreInfo
            StoreInfo storeInfo = new StoreInfo()
            {
                StoreId = formInfo.PrimaryKeyId,
                StoreName = storeName,
                StoreNo = storeNo,
                Remark = storeRemark
            };
            if(formInfo.FromType == 1)//添加仓库信息
            {
                //判断StoreName和StoreNo是否已经存在
                int existsCode = storeInfosBLL.IsExistsStore(storeName, storeNo);
                switch (existsCode)
                {
                    case 0://00都不存在
                        if (!storeInfosBLL.AddStore(storeInfo))//添加失败
                        {
                            MsgBoxHelper.MsgErrorShow($"{msgTitle}仓库信息", $"仓库名称{storeName}信息添加失败");
                            return;
                        }
                        else//添加成功
                        {
                            RefreshDataGridV.Invoke();//刷新dataGridView
                            MsgBoxHelper.MsgSuccessShow($"{msgTitle}仓库信息", $"仓库名称{storeName}信息添加成功");
                            this.Close();
                            return;
                        }
                    case 1://01storeNo存在
                        MsgBoxHelper.MsgErrorShow($"{msgTitle}仓库信息", $"仓库编号{storeNo}已存在");
                        break;
                    case 2://10storeName存在
                        MsgBoxHelper.MsgErrorShow($"{msgTitle}仓库信息", $"仓库名称{storeName}已存在");
                        break;
                    case 3://11都存在
                        MsgBoxHelper.MsgErrorShow($"{msgTitle}仓库信息", $"仓库名称{storeName}和仓库编号{storeNo}都已存在");
                        break;
                }
            }
            else//修改仓库信息
            {
                //判断TextBox上的Name和No是否已经存在，并且过滤掉未进行修改的值
                int existsCode = storeInfosBLL.IsExistsStore(storeName== oldStoreInfo.StoreName?"":storeName, storeNo == oldStoreInfo.StoreNo ? "" : storeNo);
                switch (existsCode)
                {
                    case 0://00都不存在
                        if (storeInfosBLL.UpdateStore(storeInfo))
                        {
                            RefreshDataGridV.Invoke();//刷新dataGridView
                            MsgBoxHelper.MsgSuccessShow($"{msgTitle}仓库信息", $"仓库名称{storeName}信息修改成功");
                            this.Close();
                            return;
                        }
                        else
                            MsgBoxHelper.MsgErrorShow($"{msgTitle}仓库信息", $"仓库名称{storeName}信息修改失败");
                        break;
                    case 1://01storeNo存在
                        MsgBoxHelper.MsgErrorShow($"{msgTitle}仓库信息", $"仓库编号{storeNo}已存在");
                        break;
                    case 2://10storeName存在
                        MsgBoxHelper.MsgErrorShow($"{msgTitle}仓库信息", $"仓库名称{storeName}已存在");
                        break;
                    case 3://11都存在
                        MsgBoxHelper.MsgErrorShow($"{msgTitle}仓库信息", $"仓库名称{storeName}和仓库编号{storeNo}都已存在");
                        break;
                }
            }
             



        }
        /// <summary>
        /// "清空"按钮的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uCircleButtonClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        /// <summary>
        /// panelHead上"返回"按钮的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uCircleButtonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 仓库名称输入文本框文本改变时发生的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// TextBox改变后判断是否为空，如为空则显示"*必填"提示
        private void textBoxStoreName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxStoreName.Text.Trim()))
                labelTipName.Visible = true;
            else
                labelTipName.Visible = false;
        }
        /// <summary>
        /// 仓库编码输入文本框文本改变时发生的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// TextBox改变后判断是否为空，如为空则显示"*必填"提示
        private void textBoxStoreNo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxStoreNo.Text.Trim()))
                labelTipNo.Visible = true;
            else
                labelTipNo.Visible = false;
        }
    }
}
