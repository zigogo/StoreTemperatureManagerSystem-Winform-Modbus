using Common;
using STMS.product;
using STMS.store;
using STMS.storeTemper;
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

namespace STMS
{
    public partial class FrmMain : Form
    {
       
        //左侧菜单按钮：UMenuButton背景色
        Color selColorOfuMenuBtn = Color.FromArgb(88, 116, 216);//选中该按钮时显示的颜色
        //顶部菜单按钮：UPagebutton背景色
        Color selColorOfuPageBtn = Color.FromArgb(45, 50, 116);//选中该按钮时显示的颜色
        Color unSelColorOfuPageBtn = Color.White;//未选中该按钮时显示的颜色

        public FrmMain()
        {
            InitializeComponent();
        }

        #region UMenuButton点击事件

        /// <summary>
        /// FrmMain页面左侧菜单栏按钮“仓库管理”的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuBtnStoreManage_Click(object sender, EventArgs e)
        {
            //点击后改变按钮颜色
            setSelectPageButtonForeColor(pageBtnSM);
            //将FrmStoreList窗体显示到panelPage上面
            FrmStoreManage frmStoreList = new FrmStoreManage();
            panelPage.AddPanelForm(frmStoreList);
        }

        /// <summary>
        /// FrmMain页面左侧菜单栏按钮：“产品管理”的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuBtnProductManage_Click(object sender, EventArgs e)
        {
            //点击后改变按钮颜色
            setSelectPageButtonForeColor(pageBtnPM);
            //将FrmProductList窗体显示到panelPage上面
            FrmProductManage frmProductList = new FrmProductManage();
            panelPage.AddPanelForm(frmProductList);
        }

        /// <summary>
        /// FrmMain页面左侧菜单栏按钮“仓库温控管理”的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuBtnStoreTemperManage_Click(object sender, EventArgs e)
        {
            //点击后改变按钮颜色
            setSelectPageButtonForeColor(pageBtnSTM);
            //将FrmStoreList窗体显示到panelPage上面
            FrmStoreRegionTemperatureManage frmStoreRegionTemperatureList = new FrmStoreRegionTemperatureManage();
            panelPage.AddPanelForm(frmStoreRegionTemperatureList);
        }


        #endregion

        #region UPageButton点击事件

        /// <summary>
        /// FrmMain页面顶部菜单栏按钮“仓库管理页面”的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pageBtnSM_Click(object sender, EventArgs e)
        {
            //点击后改变按钮颜色
            setSelectPageButtonForeColor(pageBtnSM);
            //将FrmStoreList窗体显示到panelPage上面
            FrmStoreManage frmStoreList = new FrmStoreManage();
            frmStoreList.LoadStoreInfos();
            panelPage.AddPanelForm(frmStoreList);
        }
        /// <summary>
        ///  FrmMain页面顶部菜单栏按钮“仓库分区页面”的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pageBtnSRM_Click(object sender, EventArgs e)
        {
            //点击后改变按钮颜色
            setSelectPageButtonForeColor(pageBtnSRM);
            FrmStoreRegionManage frmStoreRegionManage = new FrmStoreRegionManage();
            panelPage.AddPanelForm(frmStoreRegionManage);
        }
        /// <summary>
        ///  FrmMain页面顶部菜单栏按钮“产品管理页面”的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pageBtnPM_Click(object sender, EventArgs e)
        {
            //点击后改变按钮颜色
            setSelectPageButtonForeColor(pageBtnPM);
            //将FrmProductList窗体显示到panelPage上面
            FrmProductManage frmProductList = new FrmProductManage();
            panelPage.AddPanelForm(frmProductList);
        }
        /// <summary>
        ///  FrmMain页面顶部菜单栏按钮“产品入库页面”的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pageBtnPIS_Click(object sender, EventArgs e)
        {
            //点击后改变按钮颜色
            setSelectPageButtonForeColor(pageBtnPIS);
            FrmProductInStoreManage frmProductInStoreManage = new FrmProductInStoreManage();
            panelPage.AddPanelForm(frmProductInStoreManage);
        }
        /// <summary>
        ///  FrmMain页面顶部菜单栏按钮“仓库温控页面”的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pageBtnSTM_Click(object sender, EventArgs e)
        {
            //点击后改变按钮颜色
            setSelectPageButtonForeColor(pageBtnSTM);
            //将FrmStoreList窗体显示到panelPage上面
            FrmStoreRegionTemperatureManage frmStoreRegionTemperatureList = new FrmStoreRegionTemperatureManage();
            panelPage.AddPanelForm(frmStoreRegionTemperatureList);
        }


        #endregion
         
        /// <summary>
        /// 顶部菜单按钮字体颜色的改变(选中)
        /// </summary>
        private void setSelectPageButtonForeColor(UPageButton pageButton)
        {
            //设置选中按钮的颜色
            pageButton.ForeColor = selColorOfuPageBtn;

            //处理顶部菜单未选中按钮的颜色
            //列举出所有UPageButton按钮
            UPageButton[] pageBtns = { pageBtnSM, pageBtnSRM, pageBtnPM, pageBtnPIS, pageBtnSTM };

            foreach (UPageButton uPageButton in pageBtns)
            {
                if (uPageButton.Name != pageButton.Name)
                {
                    uPageButton.ForeColor = unSelColorOfuPageBtn;
                }
            }
        }


        #region FrmMain页面初始化

        System.Timers.Timer timer = null;
        /// <summary>
        /// FrmMain页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //加载底部显示的用户名和时间
            LoadButtomInfo();

        }

        /// <summary>
        /// 加载底部显示的用户名和时间
        /// </summary>
        private void LoadButtomInfo()
        {
            //加载底部显示的用户名
            if (this.Tag != null)
                labelUserName.Text = this.Tag.ToString();
            else
                labelUserName.Text = this.Tag.ToString();


            //加载底部显示的时间
            labelTime.Text = DateTime.Now.ToString("F");
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.AutoReset = true;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                this.labelTime.Text = DateTime.Now.ToString("F");
            }));

        }
        #endregion

        /// <summary>
        /// FrmMain页面关闭时事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MsgBoxHelper.MsgConfirmShow("退出系统", "请确认是否退出系统?") == DialogResult.Yes)
            {
                if (timer != null)
                    timer.Stop();
                Application.ExitThread();
            }
            else
            {
                //取消这个事件
                e.Cancel = true;
            }
        }

        #region 按住顶部panel拖动页面

        Point pointOfMouseDown = new Point();
        private void panelHead_MouseDown(object sender, MouseEventArgs e)
        {
            pointOfMouseDown = e.Location;//鼠标按下时的位置
        }

        private void panelHead_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point pointOfMouseNew = e.Location;
                //给From.Location赋上新值
                this.Location =new Point(this.Location.X + pointOfMouseNew.X - pointOfMouseDown.X,
                    this.Location.Y + pointOfMouseNew.Y - pointOfMouseDown.Y);
            }
        }
        #endregion

        /// <summary>
        /// panelTop上关闭按钮的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            panelPage.Controls.Clear();
            //修改所有顶部按钮颜色为未选中
            UPageButton[] pageBtns = { pageBtnSM, pageBtnSRM, pageBtnPM, pageBtnPIS, pageBtnSTM };

            foreach (UPageButton uPageButton in pageBtns)
            {
                uPageButton.ForeColor = unSelColorOfuPageBtn;
            }

        }
        /// <summary>
        /// Page页面大小改变的事件--处理panelPage上From大小变化问题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelPage_SizeChanged(object sender, EventArgs e)
        {

            if (panelPage.Controls.Count != 0)
            {
                Form form = (Form)this.panelPage.Controls[0];
                form.WindowState = FormWindowState.Normal;
                form.Size = panelPage.Size;
                form.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
