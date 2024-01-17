using STML.Models.DModels;
using STMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.BLL
{
    public class StoreRegionInfoBLL
    {
        //实例化StoreRegionInfoDAL
        StoreRegionInfoDAL storeRegionInfoDAL = new StoreRegionInfoDAL();

        /// <summary>
        /// 判断指定仓库分区是否添加了产品
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public bool IsHaveProduct(int sRegionId)
        {
            int count = storeRegionInfoDAL.GetRegionProductCount(sRegionId);
            if (count > 0)
                return true;
            else
                return false;
        }


        /// <summary>
        /// 逻辑删除仓库分区sRegionId,更新仓库storeId的分区数
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="sRegionId"></param>
        /// <returns>返回int型  0：删除失败   1：删除成功   2：该仓库分区添加了产品</returns>
        public int LogicDeleteStoreRegion(int sRegionId,int storeId)
        {
            //先判断仓库分区是否有产品
            if (IsHaveProduct(sRegionId))
            {
                return 2;//该仓库分区添加了产品
            }
            else
            {
                bool isSuccess = storeRegionInfoDAL.DeleteStoreRegion(sRegionId, storeId, 0, 1);
                if (isSuccess)
                    return 1;//删除成功
                else
                    return 0;//删除失败
            }
        }

        /// <summary>
        /// 批量根据ID进行逻辑删除
        /// </summary>
        /// <param name="storeRegionInfosList"></param>
        /// <returns>返回string类型 
        /// "Y":删除成功  
        /// "0":删除失败  
        /// "1,2,4":表示storeID1,2,4存在分区
        /// </returns>
        /// 都不存在产品才能删除成功
        public string LogicDeleteStoreRegion(List<StoreRegionInfo> storeRegionInfosList)
        {
            string reString = "";
            foreach (StoreRegionInfo storeRegionInfo in storeRegionInfosList)
            {
                if (reString.Length > 0)
                    reString += ",";
                if (IsHaveProduct(storeRegionInfo.SRegionId))
                    reString += storeRegionInfo.SRegionId.ToString();
            }
            if (reString == "")//全都没有产品
            {
                reString = storeRegionInfoDAL.DeleteStoreRegionList(storeRegionInfosList, 0, 1) ? "Y" : "0";
                //"Y":删除成功   "0":删除失败 
            }
            return reString;
        }


        /// <summary>
        /// 恢复仓库分区信息
        /// </summary>
        /// <param name="sRegionId"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public bool RecoverStore(int sRegionId,int storeId)
        {
            return storeRegionInfoDAL.DeleteStoreRegion(sRegionId,storeId,0, 0);
        }
        /// <summary>
        /// 真删除仓库分区信息
        /// </summary>
        /// <param name="sRegionId"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public bool DeleteStore(int sRegionId, int storeId)
        {
            return storeRegionInfoDAL.DeleteStoreRegion(sRegionId, storeId, 1, 2);
        }

        /// <summary>
        /// 根据SRegionId获取StoreRegionInfo仓库分区信息
        /// </summary>
        /// <param name="sRegionId"></param>
        /// <returns></returns>
        public StoreRegionInfo GetStoreRegion(int sRegionId)
        {
            return storeRegionInfoDAL.GetStoreRegion(sRegionId);
        }
        /// <summary>
        /// 根据StoreId获取所在仓库所有分区信息StoreRegionInfo
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public List<StoreRegionInfo> GetSRegionInfosByStoreId(int storeId)
        {
            return storeRegionInfoDAL.GetSRegionInfosByStoreId(storeId);
        }


        /// <summary>
        /// 判断sRegionName和sRegionNo是否已经存在
        /// </summary>
        /// <param name="sRegionName"></param>
        /// <param name="sRegionNo"></param>
        /// <returns>0:都不存在  01:Name不存在，No存在  10:Name存在，No不存在  11:都存在</returns>
        public int IsExistsStoreRegion(string sRegionName, string sRegionNo)
        {
            bool[] bools = storeRegionInfoDAL.IsExistsStoreRegion(sRegionName, sRegionNo);
            //bools[0]为sRegionName
            //bools[1]为sRegionNo
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
        /// 添加仓库分区
        /// </summary>
        /// <param name="storeRegionInfo"></param>
        /// <returns>int类型：新添加仓库分区的SRegionId</returns>
        public int AddStoreRegion(StoreRegionInfo storeRegionInfo)
        {
            return storeRegionInfoDAL.AddStoreRegion(storeRegionInfo);
        }

        /// <summary>
        /// 修改仓库分区信息(修改了所属的仓库)
        /// </summary>
        /// <param name="storeRegionInfo"></param>
        /// <param name="oldStoreId"></param>
        /// <returns></returns>
        public bool UpdateStoreRegion(StoreRegionInfo storeRegionInfo,int oldStoreId)
        {
            return storeRegionInfoDAL.UpdateStoreRegion(storeRegionInfo, oldStoreId);
        }
        /// <summary>
        /// 修改仓库分区信息(没有修改所属的仓库)
        /// </summary>
        /// <param name="storeRegionInfo"></param>
        /// <returns></returns>
        public bool UpdateStoreRegion(StoreRegionInfo storeRegionInfo)
        {
            return storeRegionInfoDAL.UpdateStoreRegion(storeRegionInfo, 0);
        }
    } 
}
