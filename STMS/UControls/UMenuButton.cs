using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STMS.UControls
{
    [DefaultEvent("Click")]
    public partial class UMenuButton : UserControl
    {
        public UMenuButton()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 按钮照片
        /// </summary>
        public Image ButtonImage
        {
            get { return buttonImage.Image; }
            set { buttonImage.Image = value; }
        }
        /// <summary>
        /// 按钮文本
        /// </summary>
        public string ButtonText
        {
            get { return buttonText.Text; }
            set { buttonText.Text = value; }
        }

        /// <summary>
        /// 鼠标经过时的响应(重写)
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BackColor = Color.FromArgb(88, 116, 216);
        }
        /// <summary>
        /// 鼠标离开时的响应
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackColor = Color.FromArgb(45, 50, 116);
        }
        /// <summary>
        /// 鼠标点击响应
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            this.BackColor = Color.FromArgb(88, 116, 216);
        }

        private void buttonText_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void buttonImage_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void buttonText_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void buttonImage_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void buttonText_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }
    }
}
