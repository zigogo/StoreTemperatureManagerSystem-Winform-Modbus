using STML.Models.VModels;
using STMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.BLL
{
    public class ViewProductStoreInfoBLL
    {
        ViewProductStoreInfoDAL viewProductStoreInfoDAL =new ViewProductStoreInfoDAL();
        /// <summary>
        /// 获取所有产品库存信息
        /// </summary>
        /// <returns></returns>
        public List<ViewProductStoreInfo> GetAllProductStoreInfo()
        {
            return viewProductStoreInfoDAL.GetAllProductStoreInfos();
        }
    }
}