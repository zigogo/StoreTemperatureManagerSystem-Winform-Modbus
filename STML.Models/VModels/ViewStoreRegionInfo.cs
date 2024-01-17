using Common.CustomArrtibutes;
using STML.Models.DModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STML.Models.VModels
{
    /// <summary>
    /// 视图：仓库分区信息
    /// </summary>
    [Table("ViewStoreRegionInfos")]
    [PrimaryKey("SRegionId")]
    public class ViewStoreRegionInfo:StoreRegionInfo
    {
        public string StoreName { get; set; }
        public string TemperStateText { get; set; }


    }
}
