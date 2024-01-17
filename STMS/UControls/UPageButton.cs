using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace STMS.UControls
{
    [DefaultEvent("Click")]
    public partial class UPageButton : UserControl
    {
        public UPageButton()   
        {
            InitializeComponent();
        }



        /// <summary>
        /// 控件的文本
        /// </summary>
        public String BtnText
        {
            set { btnlabel.Text = value; }
            get { return btnlabel.Text; }
        }
        /// <summary>
        /// 控件的前景色
        /// </summary>
        public override Color ForeColor 
        {
            get { return btnlabel.ForeColor; } 
            set => btnlabel.ForeColor = value; 
        }

        protected override void OnClick(EventArgs e)
        {
            btnlabel.ForeColor = Color.FromArgb(45, 50, 116);
            base.OnClick(e);

        }
        private void btnlabel_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

    }
}
