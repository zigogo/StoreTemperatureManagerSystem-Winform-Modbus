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
    public partial class UIndicatorLight : UserControl
    {
        public UIndicatorLight()
        {
            InitializeComponent();
        }
        //扩展属性
        public Color LightColor 
        {
            get{ return this.uCircleLight.ForeColor; }
            set{ this.uCircleLight.ForeColor = value; }
        }
        public string State
        {
            get { return this.labelState.Text; }
            set { this.labelState.Text = value; }
        }
    }
}
