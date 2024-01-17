using STML.Models.DModels;
using STMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.BLL
{
    public class StoreInfoBLL
    {
        StoreInfoDAL storeInfoDAL = new StoreInfoDAL();
        /// <summary>
        /// 条件查询仓库信息列表
        /// </summary>
        /// <param name="wordOfSearch"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public List<StoreInfo> GetStoreInfos(string wordOfSearch, bool isDeleted)
        {
            int numIsDeleted = isDeleted ? 1 : 0;
            return storeInfoDAL.GetStoreInfos(wordOfSearch, numIsDeleted);
        }

        /// <summary>
        /// 根据StoreId获取仓库信息
        /// </summary>
        /// <returns></returns>
        public StoreInfo GetStore(int storeId)
        {
            return storeInfoDAL.GetStore(storeId);
        }
        /// <summary>
        /// 获取所有仓库信息(作为下拉框的数据)
        /// </summary>
        /// <returns></returns>
        public List<StoreInfo> GetAllStore()
        {
            return storeInfoDAL.GetAllStore();
        }



        /// <summary>
        /// 判断指定仓库是否添加了分区
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public bool IsHaveRegion(int storeId)
        {
            int count = storeInfoDAL.GetStoreRegionCount(storeId);
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 根据仓库ID进行逻辑删除
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns>返回int型  0：删除失败   1：删除成功   2：该仓库添加了分区</returns>
        public int LogicDeleteStore(int storeId)
        {
            //先判断是否有分区
            if(IsHaveRegion(storeId))
            {
                return 2;//该仓库添加了分区
            }
            else
            {
                bool isSuccess = storeInfoDAL.Delete(storeId, 0, 1);
                if (isSuccess)
                    return 1;//删除成功
                else
                    return 0;//删除失败
            }
        }
        /// <summary>
        /// 批量根据ID进行逻辑删除
        /// </summary>
        /// <param name="storeIds"></param>
        /// <returns>返回string类型 
        /// "Y":删除成功  
        /// "0":删除失败  
        /// "1,2,4":表示storeID1,2,4存在分区
        /// </returns>
        /// 都不存在分区才能删除成功
        public string LogicDeleteStore(List<int> storeIds)
        {
            string reString = "";
            foreach (int storeId in storeIds)
            {
                if (reString.Length > 0)
                    reString += ",";
                if (IsHaveRegion(storeId))
                    reString += storeId.ToString();
            }
            if (reString=="")//全都没有分区
            {
                reString = storeInfoDAL.DeleteList(storeIds, 0, 1) ? "Y" : "0";
                //"Y":删除成功   "0":删除失败 
            }
            return reString;
        }
        /// <summary>
        /// 恢复仓库信息
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public bool RecoverStore(int storeId)
        {
            return storeInfoDAL.Delete(storeId, 0, 0);
        }
        /// <summary>
        /// 真删除仓库信息
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public bool DeleteStore(int storeId)
        {
            return storeInfoDAL.Delete(storeId, 1, 2);
        }
       
        /// <summary>
        /// 判断StoreName和StoreNo是否已经存在
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="storeNo"></param>
        /// <returns>0:都不存在  01:Name不存在，No存在  10:Name存在，No不存在  11:都存在</returns>
        public int IsExistsStore(string storeName,string storeNo)
        {
            bool[] bools = storeInfoDAL.IsExistsStore(storeName, storeNo);
            //bools[0]为StoreName
            //bools[1]为StoreNo
            if (bools[0] && bools[1])
                return 3;//都存在
            else if (bools[0] && !bools[1])
                return 2;//StoreName存在
            else if (!bools[0] && bools[1])
                return 1;//StoreNo存在
            else
                return 0;//都不存在
        }
        /// <summary>
        /// 添加仓库并返回StoreId
        /// </summary>
        /// <param name="storeInfo"></param>
        /// <returns></returns> 
        public bool AddStore(StoreInfo storeInfo)
        {
            return storeInfoDAL.AddStore(storeInfo)>0;
        }
        /// <summary>
        /// 更新仓库并返回是否更新成功
        /// </summary>
        /// <param name="storeInfo"></param>
        /// <returns></returns>
        public bool UpdateStore(StoreInfo storeInfo)
        {
            return storeInfoDAL.UpdateStore(storeInfo);
        }
    }
}
