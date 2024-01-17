using Common.CustomArrtibutes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STML.Models.DModels
{
    //产品信息实体
    [Table("ProductInfos")]
    [PrimaryKey("ProductId")]
    public class ProductInfo
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductNo { get; set; }
        public decimal? FitLowTemperature { get; set; }
        public decimal? FitHighTemperature { get; set; }
        public int IsDeleted { get; set; }
    }
}
