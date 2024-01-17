using STML.Models.VModels;
using STMS.DAL.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.DAL
{
    public class ViewStoreRegionDAL:BQuery<ViewStoreRegionInfo>
    {
        /// <summary>
        /// 根据条件查询仓库分区信息
        /// </summary>
        /// <param name="storeId">指定需要查询的仓库编号</param>
        /// <param name="stateId">指定需要查询的状态</param>
        /// <param name="wordOfSearch"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public List<ViewStoreRegionInfo> GetStoreRegionInfos(int storeId,int stateId,string wordOfSearch,int isDeleted)
        {
            List<ViewStoreRegionInfo> viewStoreRegionInfos = new List<ViewStoreRegionInfo>();
            //SQL语句的列名
            string cols = CreateSql.GetColsString<ViewStoreRegionInfo>("TemperState,Remark,IsDeleted");
            //SQL语句的条件
            string strWhere = $"IsDeleted={isDeleted}";
            if (storeId != 0)//storeId=0是下拉框默认的,如果选择了下拉框就是指定了特定的仓库
                strWhere += $" and StoreId={storeId}";
            if (stateId != -1)//stateId=-1表示下拉框没有被选择
                strWhere += $" and TemperState={stateId}";
            if (!string.IsNullOrEmpty(wordOfSearch))//加上模糊查询的条件
            {
                strWhere += " and (SRegionNo like @wordOfSearch or SRegionName like @wordOfSearch)";
                SqlParameter sqlParameter = new SqlParameter("@wordOfSearch", $"%{wordOfSearch}%");
                viewStoreRegionInfos =  GetModelList(strWhere, cols, sqlParameter);
            }else
                viewStoreRegionInfos = GetModelList(strWhere, cols);
            return viewStoreRegionInfos;
        }

    }
}
