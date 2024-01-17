using STML.Models.VModels;
using STMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.BLL
{
    public class ViewStoreRegionBLL
    {
        //实例化DAL
        ViewStoreRegionDAL viewStoreRegionDAL = new ViewStoreRegionDAL();

        /// <summary>
        /// 根据条件查询仓库分区信息
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="stateId"></param>
        /// <param name="wordOfSearch"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public List<ViewStoreRegionInfo> GetStoreRegionInfos(int storeId, int stateId, string wordOfSearch, bool isDeleted)
        {
            int numIsDeleted = isDeleted ? 1 : 0;
            return viewStoreRegionDAL.GetStoreRegionInfos(storeId, stateId, wordOfSearch, numIsDeleted);
        }
    }
}
