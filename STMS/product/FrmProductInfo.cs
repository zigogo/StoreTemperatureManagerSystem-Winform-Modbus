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

namespace STMS.product
{
    public partial class FrmProductInfo : Form
    {
        public FrmProductInfo()
        {
            InitializeComponent();
        }
        FormInfo formInfo = null;//记录该窗体的类型以及ProductId
        public event Action RefreshDataGridV;//刷新
                                             //



        ProductInfo oldProductInfo = null;
        ProductInfoBLL productInfoBLL = new ProductInfoBLL();

        /// <summary>
        /// FrmStoreInfo页面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmProductInfo_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                formInfo = this.Tag as FormInfo;
                InitializeFrom();
            }
        }

        private void InitializeFrom()
        {
            if (formInfo != null)
            {
                labelTipTemperature.Visible = false;
                switch (formInfo.FromType)//1：添加产品信息   2：修改
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
        private void FillTextBox(int productId)
        {
            oldProductInfo = productInfoBLL.GetProduct(productId);
            this.textBoxProductName.Text = oldProductInfo.ProductName;
            this.textBoxProductNo.Text = oldProductInfo.ProductNo;
            this.textBoxLowTemper.Text = oldProductInfo.FitLowTemperature.ToString();
            this.textBoxHighTemper.Text = oldProductInfo.FitHighTemperature.ToString();
        }
        /// <summary>
        /// 清空TextBox的内容
        /// </summary>
        private void ClearTextBox()
        {
            textBoxProductName.Clear();
            textBoxProductNo.Clear();
            textBoxLowTemper.Clear();
            textBoxHighTemper.Clear();
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
        /// "清空"按钮的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uCircleButtonClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }
        /// <summary>
        /// "确认"按钮的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uCircleButtonSubmit_Click(object sender, EventArgs e)
        {
            string msgTitle = null;
            if (formInfo.FromType == 1)//添加产品信息
                msgTitle = "添加";
            else
                msgTitle = "修改";
            //获取输入到TextBox中的内容
            string productName = textBoxProductName.Text;
            string productNo = textBoxProductNo.Text;
            string fitLowTemper = textBoxLowTemper.Text;
            string fitHighTemper = textBoxHighTemper.Text;
            //产品名称和产品编码不能为空
            if (string.IsNullOrEmpty(productName))
                return;
            if (string.IsNullOrEmpty(productNo))
                return;
            if (labelTipTemperature.Visible == true)//最低温度大于最高温度
                return;
            //封装成ProductInfo
            ProductInfo productInfo = new ProductInfo()
            {
                ProductId = formInfo.PrimaryKeyId,
                ProductName = productName,
                ProductNo = productNo,
                FitLowTemperature = fitLowTemper.GetDecimalOrNull(),
                FitHighTemperature = fitHighTemper.GetDecimalOrNull(),
            };
            if (formInfo.FromType == 1)//添加仓库信息
            {
                //判断ProductName和ProductNo是否已经存在
                int existsCode = productInfoBLL.IsExistsProduct(productName, productNo);
                switch (existsCode)
                {
                    case 0://00都不存在
                        if (!productInfoBLL.AddProduct(productInfo))//添加失败
                        {
                            MsgBoxHelper.MsgErrorShow($"{msgTitle}产品信息", $"产品名称{productName}信息添加失败");
                            return;
                        }
                        else//添加成功
                        {
                            RefreshDataGridV.Invoke();//刷新dataGridView
                            MsgBoxHelper.MsgSuccessShow($"{msgTitle}产品信息", $"产品名称{productName}信息添加成功");
                            this.Close();
                            return;
                        }
                    case 1://01productNo存在
                        MsgBoxHelper.MsgErrorShow($"{msgTitle}产品信息", $"产品编号{productNo}已存在");
                        break;
                    case 2://10productName存在
                        MsgBoxHelper.MsgErrorShow($"{msgTitle}产品信息", $"产品名称 {productName}已存在");
                        break;
                    case 3://11都存在
                        MsgBoxHelper.MsgErrorShow($"{msgTitle}产品信息", $"产品名称{productName}和产品编号{productNo}都已存在");
                        break;
                }
            }
            else//修改产品信息
            {
                //判断TextBox上的Name和No是否已经存在，并且过滤掉未进行修改的值
                int existsCode = productInfoBLL.IsExistsProduct(productName == oldProductInfo.ProductName ? "" : productName, productNo == oldProductInfo.ProductNo ? "" : productNo);
                switch (existsCode)
                {
                    case 0://00都不存在
                        if (productInfoBLL.UpdateProduct(productInfo))
                        {
                            RefreshDataGridV.Invoke();//刷新dataGridView
                            MsgBoxHelper.MsgSuccessShow($"{msgTitle}产品信息", $"产品名称{productName}信息修改成功");
                            this.Close();
                            return;
                        }
                        else
                            MsgBoxHelper.MsgErrorShow($"{msgTitle}产品信息", $"产品名称 {productName}信息修改失败");
                        break;
                    case 1://01productNo存在
                        MsgBoxHelper.MsgErrorShow($"{msgTitle}产品信息", $"产品编号{productNo}已存在");
                        break;
                    case 2://10storeName存在
                        MsgBoxHelper.MsgErrorShow($"{msgTitle}产品信息", $"产品名称{productName}已存在");
                        break;
                    case 3://11都存在
                        MsgBoxHelper.MsgErrorShow($"{msgTitle}产品信息", $"产品名称{productName}和仓库编号{productNo}都已存在");
                        break;
                }
            }
        }
        /// <summary>
        /// 产品名称输入文本框文本改变时发生的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxProductName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxProductName.Text.Trim()))
                labelTipName.Visible = true;
            else
                labelTipName.Visible = false;
        }

        /// <summary>
        /// 产品编码输入文本框文本改变时发生的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxProductNo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxProductNo.Text.Trim()))
                labelTipNo.Visible = true;
            else
                labelTipNo.Visible = false;
        }

        private void textBoxLowTemper_TextChanged(object sender, EventArgs e)
        {
            decimal? fitLowTemperature = textBoxLowTemper.Text.Trim().GetDecimalOrNull();
            decimal? fitHighTemperature = textBoxHighTemper.Text.Trim().GetDecimalOrNull();
            if (fitHighTemperature != null && fitLowTemperature != null
                && fitLowTemperature > fitHighTemperature)//低温大于高温
                labelTipTemperature.Visible = true;
            if (fitHighTemperature != null && fitLowTemperature != null
                && fitLowTemperature <= fitHighTemperature)//输入正常，不提示
                labelTipTemperature.Visible = false;
        }

        private void textBoxHighTemper_TextChanged(object sender, EventArgs e)
        {
            decimal? fitLowTemperature = textBoxLowTemper.Text.Trim().GetDecimalOrNull();
            decimal? fitHighTemperature = textBoxHighTemper.Text.Trim().GetDecimalOrNull();
            if (fitHighTemperature != null && fitLowTemperature != null
                && fitLowTemperature > fitHighTemperature)//低温大于高温
                labelTipTemperature.Visible = true;
            if (fitHighTemperature != null && fitLowTemperature != null
                && fitLowTemperature <= fitHighTemperature)//输入正常，不提示
                labelTipTemperature.Visible = false;
        }
    }
}
