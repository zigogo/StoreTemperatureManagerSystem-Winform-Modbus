using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STMS
{
    /// <summary>
    /// 弹出的消息框的类
    /// </summary>
    public class MsgBoxHelper
    {
        /// <summary>
        /// 操作成功的消息弹窗
        /// </summary>
        /// <param name="titile"></param>
        /// <param name="message"></param>
        public static void MsgSuccessShow(string titile,string message)
        {
            MessageBox.Show(message, titile, MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        /// <summary>
        /// 操作失败的消息弹窗
        /// </summary>
        /// <param name="titile"></param>
        /// <param name="message"></param>
        public static void MsgErrorShow(string titile, string message)
        {
            MessageBox.Show(message, titile, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// 是与否询问框
        /// </summary>
        /// <param name="titile"></param>
        /// <param name="message"></param>
        public static DialogResult MsgConfirmShow(string titile, string message)
        {
            return MessageBox.Show(message, titile, MessageBoxButtons.YesNo, MessageBoxIcon.None);
        }




    }
}
