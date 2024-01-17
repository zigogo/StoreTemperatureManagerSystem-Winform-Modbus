using Common;
using STML.Models.DModels;
using STMS.DAL.Base;
using STMS.DbUtility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace STMS.DAL
{
    public class StoreInfoDAL:BaseDAL<StoreInfo>
    {
        /// <summary>
        /// 根据查询条件返回仓库信息
        /// </summary>
        /// <param name="wordOfSearch">查询关键字</param>
        /// <param name="isDeletd">是否已删除</param>
        /// <returns></returns>
        public List<StoreInfo> GetStoreInfos(string wordOfSearch,int isDeleted)
        {
            //string cols = "StoreId,StoreNo,StoreName,RegionCount,Remark";
            string cols = CreateSql.GetColsString<StoreInfo>("IsDeleted");
            string strWhere = $"IsDeleted={isDeleted}";
            if(!string.IsNullOrEmpty(wordOfSearch))
            {//有查询条件
                strWhere += " and (StoreNo like @wordOfSearch or StoreName like @wordOfSearch) ";
                SqlParameter sqlParameter = new SqlParameter("@wordOfSearch", wordOfSearch);
                return GetModelList(strWhere, cols, sqlParameter);
            }
            else
                return GetModelList(cols, isDeleted);//Where is null
        }

        /// <summary>
        /// 获取指定仓库ID的仓库信息
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public StoreInfo GetStore(int storeId)
        {
            //string cols = "StoreNo,StoreName,Remark";
            string cols = CreateSql.GetColsString<StoreInfo>("IsDeleted");
            return GetById(storeId, cols);
        }

        /// <summary>
        /// 获取所有仓库信息( 作为下拉框的数据)
        /// </summary>
        /// <returns></returns>
        public List<StoreInfo> GetAllStore()
        {
            return GetModelList("StoreId,StoreName", 0);
        }

        /// <summary>
        /// 获取指定仓库的分区数
        /// </summary>
        /// <returns></returns>
        public int GetStoreRegionCount(int storeId)
        {
            string sql = $"select RegionCount from StoreInfos where StoreId = {storeId} ";
            object oCount = SqlHelper.ExecuteScalar(sql, 1);
            if(oCount != null && oCount.ToString()!="") 
            {
                return oCount.GetIntOrZero();
            }
            return 0;
        }

        /// <summary>
        /// 判断StoreName和StoreNo是否已经存在
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="storeNo"></param>
        /// <returns>bool类型数组 第一个为StoreName，第二个为StoreNo</returns>
        public bool[] IsExistsStore(string storeName,string storeNo)
        {
            bool isExistsStoreName = false;
            if (!string.IsNullOrEmpty(storeName))//传空值就返回false
                isExistsStoreName = ExistsByName("StoreName", storeName);
            bool isExistsStoreNo = false;
            if (!string.IsNullOrEmpty(storeNo))//传空值就返回false
                isExistsStoreNo = ExistsByName("StoreNo", storeNo);
            return new bool[] { isExistsStoreName, isExistsStoreNo };
        }
        /// <summary>
        /// 添加仓库信息
        /// </summary>
        /// <param name="storeInfo"></param>
        /// <returns>返回新添加仓库的StoreId</returns>
        public int AddStore(StoreInfo storeInfo)
        {
            string cols = "StoreName,StoreNo,Remark";
            return Add(storeInfo, cols,1);
        }
        /// <summary>
        /// 更新仓库信息
        /// </summary>
        /// <param name="storeInfo"></param>
        /// <returns>返回是否更新成功</returns>
        public bool UpdateStore(StoreInfo storeInfo)
        {
            string cols = CreateSql.GetColsString<StoreInfo>("RegionCount,IsDeleted");
            return Update(storeInfo, cols);
        }
    }
}
