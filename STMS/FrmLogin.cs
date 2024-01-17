using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STMS.BLL;

namespace STMS
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        { 
           
            InitializeComponent();
            x = Width;
            y = Height;
            setTag(this);
        }

        #region 控件自动大小
        private readonly float x; //定义当前窗体的宽度
        private readonly float y; //定义当前窗体的高度

        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ";" + con.Height + ";" + con.Left + ";" + con.Top + ";" + con.Font.Size;
                if (con.Controls.Count > 0) setTag(con);
            }
        }

        private void setControls(float newx, float newy, Control cons)
        {
            //遍历窗体中的控件，重新设置控件的值
            foreach (Control con in cons.Controls)
                //获取控件的Tag属性值，并分割后存储字符串数组
                if (con.Tag != null)
                {
                    var mytag = con.Tag.ToString().Split(';');
                    //根据窗体缩放的比例确定控件的值
                    con.Width = Convert.ToInt32(Convert.ToSingle(mytag[0]) * newx); //宽度
                    con.Height = Convert.ToInt32(Convert.ToSingle(mytag[1]) * newy); //高度
                    con.Left = Convert.ToInt32(Convert.ToSingle(mytag[2]) * newx); //左边距
                    con.Top = Convert.ToInt32(Convert.ToSingle(mytag[3]) * newy); //顶边距
                    var currentSize = Convert.ToSingle(mytag[4]) * newy; //字体大小                   
                    if (currentSize > 0) con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    con.Focus();
                    if (con.Controls.Count > 0) setControls(newx, newy, con);

                }
        }

        /// <summary>
        /// 重置窗体布局：随着窗体大小的改变按比例改变控件的大小
        /// 
        /// </summary>
        private void ReWinformLayout()
        {
            var newx = Width / x;
            var newy = Height / y;
            setControls(newx, newy, this);

        }

        private void FrmLogin_Resize(object sender, EventArgs e)
        {
            ReWinformLayout();
        }
        #endregion


        /// <summary>
        /// 点击登录按钮响应的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //获取页面输入的信息
            string uName=textBox1.Text.Trim();
            string uPwd=textBox2.Text.Trim();
            //非空检查
            if(string.IsNullOrEmpty(uName) || string.IsNullOrEmpty(uPwd) ) 
            {
                MsgBoxHelper.MsgErrorShow("登录系统", "账号或密码为空！");
                return; 
            }
            //检查信息的正确性
            UserValidityBLL userValidityBLL = new UserValidityBLL();
            if (userValidityBLL.LoginSystem(uName, uPwd))//登录成功
            {
                //跳转到系统主页
                FrmMain frmMain = new FrmMain();
                //把登录的用户名传给frmMain
                frmMain.Tag = uName;
                frmMain.Show();
                
                this.Hide();

            }
            else //登录失败
            {
                MsgBoxHelper.MsgErrorShow("登录系统", "账号或密码错误");
                textBox2.Clear();
                textBox1.Focus();
                return;
            }
        }

        /// <summary>
        /// 点击窗口关闭按钮响应的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MsgBoxHelper.MsgConfirmShow("退出系统", "请确认是否退出系统?") == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                //取消这个事件
                e.Cancel = true;
            }
        }
    }
}

