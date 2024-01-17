using Common.CustomArrtibutes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STML.Models.DModels
{
    //仓库分区信息实体
    [Table("StoreRegionInfos")]
    [PrimaryKey("SRegionId")]
    public class StoreRegionInfo
    {
        public int SRegionId { get; set; }
        public string SRegionName { get; set; }
        public string SRegionNo { get; set; }
        public int StoreId { get; set; }
        public decimal? SRTemperature { get; set; }
        public decimal? AllowLowTemperature { get; set; }
        public decimal? AllowHighTemperature { get; set; }
        public int TemperState { get; set; }
        public string Remark { get; set; }
        public int IsDeleted { get; set; }
    }
}
