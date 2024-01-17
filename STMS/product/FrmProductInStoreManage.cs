using Common;
using STML.Models.DModels;
using STML.Models.VModels;
using STMS.BLL;
using STMS.DAL;
using STMS.store;
using STMS.UControls;
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
    public partial class FrmProductInStoreManage : Form
    {
        public FrmProductInStoreManage()
        {
            InitializeComponent();

        }
        ProductInfoBLL productInfoBLL = new ProductInfoBLL();
        StoreRegionInfoBLL storeRegionInfoBLL = new StoreRegionInfoBLL();
        ViewProductStoreInfoBLL viewProductStoreInfoBLL = new ViewProductStoreInfoBLL();
        ProductStoreInfoBLL productStoreInfoBLL=new ProductStoreInfoBLL();
        //产品入库信息(本次入库的)
        List<ViewProductStoreInfo> OneTimeviewProductStoreInfos = new List<ViewProductStoreInfo>();
        /// <summary>
        /// FrmProductInStoreManage窗体加载事件处理器
        /// </summary>
        private void FrmProductInStoreManage_Load(object sender, EventArgs e)
        {
            LoadComboBoxProducts();//加载产品下拉框
            FormUtility.LoadComboBoxStoresNew(this.comboBoxStoreName);
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = OneTimeviewProductStoreInfos;

        }
        /// <summary>
        /// 加载产品下拉框
        /// </summary>
        private void LoadComboBoxProducts()
        {
            List<ProductInfo> productInfos = productInfoBLL.GetAllProduct();
            productInfos.Insert(0, new ProductInfo() { ProductId = 0, ProductName = "产品名称", });
            this.comboBoxProductName.DisplayMember = "ProductName";
            this.comboBoxProductName.ValueMember = "ProductId";
            this.comboBoxProductName.DataSource = productInfos;
            comboBoxProductName.SelectedIndex = 0;
        }
        /// <summary>
        /// 仓库名称下拉框comboBoxStoreName选择改变事件处理器
        /// </summary>
        /// 选择指定仓库后加载该仓库所有的分区
        private void comboBoxStoreName_TextChanged(object sender, EventArgs e)
        {
            //处理"*必填"是否显示
            if (comboBoxStoreName.SelectedIndex == 0)
                labelTipStore.Visible = true;
            else
                labelTipStore.Visible = false;
            //获取选择的仓库StoreId
            int storeId = comboBoxStoreName.SelectedValue.GetIntOrZero();
            if (storeId == 0)//没有选中有效的数据
                comboBoxStoreRegion.DataSource = null;
            List<StoreRegionInfo> storeRegionInfos = storeRegionInfoBLL.GetSRegionInfosByStoreId(storeId);
            storeRegionInfos.Insert(0, new StoreRegionInfo() { SRegionId = 0, SRegionName = "仓库分区" });
            comboBoxStoreRegion.DisplayMember = "SRegionName";
            comboBoxStoreRegion.ValueMember = "SRegionId";
            comboBoxStoreRegion.DataSource = storeRegionInfos;
            comboBoxStoreRegion.SelectedIndex = 0;

        }
        /// <summary>
        /// "产品库存列表"按钮点击事件处理器
        /// </summary>
        private void uCircleButtonProductStockInfo_Click(object sender, EventArgs e)
        {
            SwitchButtonStyle(uCircleButtonProductStockInfo,true);
            SwitchButtonStyle(uCircleButtonProductInStore, false);
            this.label.Text = "产品库存信息：";
            //显示所有产品库存数据
            List<ViewProductStoreInfo> allViewProductStoreInfos = viewProductStoreInfoBLL.GetAllProductStoreInfo();
            dataGridView.DataSource = allViewProductStoreInfos;
        }
        /// <summary>
        /// "产品入库记录"按钮点击事件处理器
        /// </summary>
        private void uCircleButtonProductInStore_Click(object sender, EventArgs e)
        {
            SwitchButtonStyle(uCircleButtonProductStockInfo, false);
            SwitchButtonStyle(uCircleButtonProductInStore, true);
            this.label.Text = "产品入库信息：";
            dataGridView.DataSource = OneTimeviewProductStoreInfos;

        }
        /// <summary>
        /// 切换按钮点击前后效果
        /// </summary>
        /// <param name="uCircleButton"></param>
        /// <param name="click">click：true点中  false未点中</param>
        private void SwitchButtonStyle(UCircleButton uCircleButton, bool click)
        {
            if (click)//点中
            {
                uCircleButton.BgColor = Color.MediumBlue;
                uCircleButton.BgColor2 = Color.MediumBlue;
                uCircleButton.BorderColor = Color.Black;
                uCircleButton.BorderWidth = 2;
            }
            else
            {
                uCircleButton.BgColor = Color.CornflowerBlue;
                uCircleButton.BgColor2 = Color.CornflowerBlue;
                uCircleButton.BorderColor = Color.CornflowerBlue;
                uCircleButton.BorderWidth = 0;
            }
        }
        /// <summary>
        /// "刷新"按钮点击事件处理器 
        /// </summary>
        private void uCircleButtonRefresh_Click(object sender, EventArgs e)
        {
            SwitchButtonStyle(uCircleButtonProductStockInfo, false);
            SwitchButtonStyle(uCircleButtonProductInStore, true);
            this.label.Text = "产品入库信息：";
            dataGridView.DataSource = OneTimeviewProductStoreInfos;
            
            comboBoxProductName.SelectedIndex = 0;
            comboBoxStoreName.SelectedIndex = 0;
            comboBoxStoreRegion.SelectedIndex = 0;
            numericUpDownProductCount.Value = 1;
        }
        /// <summary>
        /// "清空"按钮点击事件处理器 
        /// </summary>
        private void uCircleButtonClear_Click(object sender, EventArgs e)
        {
            comboBoxProductName.SelectedIndex = 0;
            comboBoxStoreName.SelectedIndex = 0;
            comboBoxStoreRegion.SelectedIndex = 0;
            numericUpDownProductCount.Value = 1;
        }
        /// <summary>
        /// "确定"按钮点击事件处理器
        /// </summary>
        private void uCircleButtonSubmit_Click(object sender, EventArgs e)
        {
            //获取输入的信息
            int productId = comboBoxProductName.SelectedValue.GetIntOrZero();
            int storeId = comboBoxStoreName.SelectedValue.GetIntOrZero();
            int sRegionId = comboBoxStoreRegion.SelectedValue.GetIntOrZero();
            int productCount= numericUpDownProductCount.Value.GetIntOrZero();
            if (productId == 0 || storeId == 0 || sRegionId == 0)
                return;
            ProductStoreInfo productStoreInfo = new ProductStoreInfo()
            {
                ProductId = productId,
                StoreId = storeId,
                SRegionId = sRegionId,
                ProductCount = productCount
            };
            bool isSuccess = productStoreInfoBLL.AddProductStoreInfo(productStoreInfo);
            if (isSuccess)//产品成功入库
            {
                MsgBoxHelper.MsgSuccessShow("产品入库", $"产品：{comboBoxProductName.Text}入库成功");
                //添加本次入库信息到OneTimeviewProductStoreInfos以便显示到dataGridView
                OneTimeviewProductStoreInfos.Add(new ViewProductStoreInfo()
                {
                    ProStoreId = OneTimeviewProductStoreInfos.Count + 1,
                    ProductCount = productCount,
                    ProductName = comboBoxProductName.Text,
                    StoreName = comboBoxStoreName.Text,
                    SRegionName = comboBoxStoreRegion.Text
                });
                //刷新dataGridView的内容
                dataGridView.DataSource = null;
                SwitchButtonStyle(uCircleButtonProductStockInfo, false);
                SwitchButtonStyle(uCircleButtonProductInStore, true);
                this.label.Text = "产品入库信息：";
                dataGridView.DataSource = OneTimeviewProductStoreInfos;
            }
        }
        /// <summary>
        ///仓库分区名称下拉框comboBoxStoreRegion选择改变事件处理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxStoreRegion_TextChanged(object sender, EventArgs e)
        {
            //处理"*必填"是否显示
            if (comboBoxStoreRegion.SelectedIndex == 0)
                labelTipStoreRegion.Visible = true;
            else
                labelTipStoreRegion.Visible = false;
        }

        private void comboBoxProductName_TextChanged(object sender, EventArgs e)
        {
            //处理"*必填"是否显示
            if (comboBoxProductName.SelectedIndex == 0)
                labelTipProductName.Visible = true;
            else
                labelTipProductName.Visible = false;
        }
    }
}
