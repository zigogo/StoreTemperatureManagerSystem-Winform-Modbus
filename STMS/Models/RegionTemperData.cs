using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.Models
{
    /// <summary>
    /// 升温或者降温页面的信息
    /// </summary>
    public class RegionTemperData
    {
        public int SId { get; set; }
        public int SRegionId { get; set; }
        public int TemperState { get; set; }
        public decimal LowTemperature { get; set; }
        public decimal HighTemperature { get; set; }
    }
}
