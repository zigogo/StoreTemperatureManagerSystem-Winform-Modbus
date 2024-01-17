using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.Models
{
    /// <summary>
    /// 仓库分区状态(int)和状态名字(string)对应关系类
    /// </summary>
    public class RegionStateInfo
    {
        public int TemperState { set; get; }
        public string StateText { set; get; }
    }
}
