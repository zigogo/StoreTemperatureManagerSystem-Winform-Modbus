using STML.Models.VModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.DAL
{
    public class ViewProductStoreInfoDAL:BQuery<ViewProductStoreInfo>
    {
        /// <summary>
        /// 获取所有产品库存信息
        /// </summary>
        /// <returns></returns>
        public List<ViewProductStoreInfo> GetAllProductStoreInfos()
        {
            List<ViewProductStoreInfo> viewProductStoreInfos = new List<ViewProductStoreInfo>();
            string cols = "ProStoreId,ProductName,StoreName,SRegionName,ProductCount";
            viewProductStoreInfos = GetModelList(cols, 0);
            return viewProductStoreInfos;
        }
    }
}
