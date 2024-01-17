using Common;
using STML.Models.DModels;
using STMS.DAL.Base;
using STMS.DbUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.DAL
{
    public class StoreRegionInfoDAL : BaseDAL<StoreRegionInfo>
    {
        /// <summary>
        /// 删除(包括恢复)仓库分区
        /// </summary>
        /// <param name="SRegionId">需要删除仓库分区的SRegionId</param>
        /// <param name="storeId">需要更新分区数的storeId</param>
        /// <param name="delType">删除类型 delType：1 真删除  0 假删除</param>
        /// <param name="isDeleted">设置删除标识: 0为未删除  1为已删除</param>
        /// <returns>bool类型：是否执行成功</returns>
        public bool DeleteStoreRegion(int SRegionId, int storeId, int delType, int isDeleted)
        {
            //获取需要执行的两条SQL语句：删除仓库分区和更新对应仓库分区数
            List<string> SQL = GetDeleteStoreRegionSQL(storeId, SRegionId, delType, isDeleted);
            return SqlHelper.ExecuteTrans(SQL);
        }
        /// <summary>
        /// 批量逻辑删除仓库分区
        /// </summary>
        /// <param name="SRegionList">待删除StoreRegionInfo列表</param>
        /// <param name="delType">删除类型 delType：1 真删除  0 假删除</param>
        /// <param name="isDeleted">设置删除标识: 0为未删除  1为已删除</param>
        /// <returns>bool类型：是否执行成功<</returns>
        public bool DeleteStoreRegionList(List<StoreRegionInfo> SRegionList, int delType, int isDeleted)
        {
            //需要执行的多条SQL语句
            List<string> SQLList = new List<string>();
            foreach (StoreRegionInfo storeRegionInfo in SRegionList)
            {
                SQLList.AddRange(GetDeleteStoreRegionSQL(storeRegionInfo.StoreId, storeRegionInfo.SRegionId, delType, isDeleted));
            }
            return SqlHelper.ExecuteTrans(SQLList);
        }

        /// <summary>获取删除(包含恢复)仓库分区的SQL语句</summary>
        /// <param name="storeId">需要更新分区数的storeId</param>
        /// <param name="SRegionId">需要删除仓库分区的SRegionId</param>
        /// <param name="delType">删除类型 delType：1 真删除  0 假删除</param>
        /// <param name="isDeleted">设置删除标识: 0为未删除  1为已删除</param>
        /// <returns>两条SQL语句:删除仓库分区和更新对应仓库分区数</returns>
        private List<string> GetDeleteStoreRegionSQL(int storeId, int SRegionId, int delType, int isDeleted)
        {
            string strWhere = $"SRegionId = {SRegionId}";
            List<string> SQLList = new List<string>();
            //删除仓库分区的SQL语句
            string SQLDelete = null;
            if (delType == 1)
                SQLDelete = CreateSql.CreateDeleteSql<StoreRegionInfo>(strWhere);
            else
                SQLDelete = CreateSql.CreateLogicDeleteSql<StoreRegionInfo>(strWhere, isDeleted);
            //更新对应仓库的分区数的SQL语句
            string SQLUpdate = null;
            if (isDeleted == 0)//设置IsDeleted为0即恢复该仓库分区，则需要设置对应仓库的分区数+1
                SQLUpdate = $"Update StoreInfos set RegionCount = RegionCount+1 Where StoreId = {storeId}";
            else//设置IsDeleted为0则不管是逻辑删除还是移除仓库分区都将对应仓库的分区数-1
                SQLUpdate = $"Update StoreInfos set RegionCount = RegionCount-1 Where StoreId = {storeId}";
            //将两条SQL语句放入List作为返回值
            SQLList.Add(SQLDelete);
            SQLList.Add(SQLUpdate);
            return SQLList;
        }

        /// <summary>
        /// 根据仓库分区ID在ProductStoreInfos表中查询产品数量
        /// </summary>
        /// <param name="sRegionId"></param>
        /// <returns></returns>
        public int GetRegionProductCount(int sRegionId)
        {
            string sql = $"select sum(ProductCount) from ProductStoreInfos where SRegionId={sRegionId}";

            object oCount = SqlHelper.ExecuteScalar(sql, 1);
            if (oCount != null && oCount.ToString() != "")
                return oCount.GetIntOrZero();
            return 0;
        }
        /// <summary>
        /// 指定sRegionId获取仓库分区信息
        /// </summary>
        /// <param name="sRegionId"></param>
        /// <returns></returns>
        public StoreRegionInfo GetStoreRegion(int sRegionId)
        {
            string cols = CreateSql.GetColsString<StoreRegionInfo>("");
            return GetById(sRegionId, cols);
        }
        /// <summary>
        /// 根据StoreId获取所在仓库所有分区信息StoreRegionInfo
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public List<StoreRegionInfo> GetSRegionInfosByStoreId(int storeId)
        {
            string strWhere = $"StoreId = {storeId} and IsDeleted = 0";
            return GetModelList(strWhere, "SRegionId,SRegionName");
        }

        /// <summary>
        /// 判断sRegionName和SRegionNo是否已经存在
        /// </summary>
        /// <param name="sRegionName"></param>
        /// <param name="sRegionNo"></param>
        /// <returns>bool类型数组 第一个为sRegionName，第二个为SRegionNo</returns>
        public bool[] IsExistsStoreRegion(string sRegionName, string sRegionNo)
        {
            bool isExistssRegionName = false;
            if (!string.IsNullOrEmpty(sRegionName))//传空值就返回false
                isExistssRegionName = ExistsByName("sRegionName", sRegionName);
            bool isExistsSRegionNo = false;
            if (!string.IsNullOrEmpty(sRegionNo))//传空值就返回false
                isExistsSRegionNo = ExistsByName("SRegionNo", sRegionNo);
            return new bool[] { isExistssRegionName, isExistsSRegionNo };
        }

        /// <summary>
        /// 添加仓库分区
        /// </summary>
        /// <param name="storeRegionInfo"></param>
        /// <returns>返回新添加仓库分区的SRegionId</returns>
        public int AddStoreRegion(StoreRegionInfo storeRegionInfo)
        {
            string cols = CreateSql.GetColsString<StoreRegionInfo>("SRegionId,AllowLowTemperature,AllowHighTemperature,IsDeleted");
            return SqlHelper.ExecuteTrans<int>(cmd =>
            {
                try
                {
                    //新增仓库分区信息
                    SqlModel sqlModelInsert = CreateSql.GetInsertSqlAndParas<StoreRegionInfo>(storeRegionInfo, cols, 1);
                    cmd.CommandText = sqlModelInsert.Sql;
                    SqlHelper.AddParameter(cmd, sqlModelInsert.SqlParaArray);
                    object o = cmd.ExecuteScalar();
                    int newSRegionId = o.GetIntOrZero();
                    //更新对应仓库的分区数
                    cmd.Parameters.Clear();
                    string sqlUpdate = $"Update StoreInfos set RegionCount = RegionCount + 1 Where StoreId = {storeRegionInfo.StoreId}";
                    if (newSRegionId > 0)
                    {
                        cmd.CommandText = sqlUpdate;
                        cmd.ExecuteNonQuery();
                    }
                    //提交事务
                    cmd.Transaction.Commit();
                    return newSRegionId;
                }
                catch (Exception)
                {
                    cmd.Transaction.Rollback();
                    throw new Exception("执行添加仓库分区事务异常，已回滚");
                }
            });
        }
        /// <summary>
        /// 修改仓库分区信息
        /// </summary>
        /// <param name="storeRegionInfo"></param>
        /// <param name="oldStoreId">0：没有修改所属的仓库   >0：修改前所属的仓库的StoreId</param>
        /// <returns></returns>
        public bool UpdateStoreRegion(StoreRegionInfo storeRegionInfo, int oldStoreId)
        {
            string cols = CreateSql.GetColsString<StoreRegionInfo>("AllowLowTemperature,AllowHighTemperature,IsDeleted");
            if (storeRegionInfo.AllowLowTemperature != null)
                cols += ",AllowLowTemperature";
            if (storeRegionInfo.AllowHighTemperature != null)
                cols += ",AllowHighTemperature";
            return SqlHelper.ExecuteTrans<bool>(cmd =>
            {
                try
                {
                    SqlModel sqlModelUpdate = CreateSql.GetUpdataSqlAndParas<StoreRegionInfo>(storeRegionInfo, cols, "");
                    cmd.CommandText = sqlModelUpdate.Sql;
                    SqlHelper.AddParameter(cmd, sqlModelUpdate.SqlParaArray);
                    if (cmd.ExecuteNonQuery() == 1)//Update语句执行成功
                    {
                        if (oldStoreId != 0)//修改了所属的仓库
                        {
                            //原本所属仓库的分区数-1
                            string sqlUpdate1 = $"Update StoreInfos set RegionCount = RegionCount - 1 Where StoreId = {oldStoreId}";
                            cmd.CommandText = sqlUpdate1;
                            if(cmd.ExecuteNonQuery()==0)//Update语句执行失败
                                return false;
                            //新加上的所属仓库的分区数+1
                            string sqlUpdate2 = $"Update StoreInfos set RegionCount = RegionCount + 1 Where StoreId = {storeRegionInfo.StoreId}";
                            cmd.CommandText = sqlUpdate2;
                            if(cmd.ExecuteNonQuery()==0)//Update语句执行失败
                                return false;
                        }
                    }
                    else
                        
                        return false;
                    cmd.Transaction.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    cmd.Transaction.Rollback();
                    throw new Exception("执行更新仓库分区事务异常，已回滚",e);
                }
            });
        }
        /// <summary>
        /// 批量更新仓库分区的室温和状态（从设备获取的数据更新到数据库）
        /// </summary>
        /// <param name="storeRegionInfo"></param>
        /// <returns></returns>
        public bool UpdateSRegionSRTemperature(List<StoreRegionInfo> storeRegionInfo)
        {
            List<string> SQLlist = new List<string>();
            foreach (StoreRegionInfo s in storeRegionInfo)
            {
                string sql = $"Update StoreRegionInfos Set SRTemperature ={s.SRTemperature},TemperState = {s.TemperState} Where SRegionId={s.SRegionId}";
                SQLlist.Add(sql);
            }
            return SqlHelper.ExecuteTrans(SQLlist);
        }
        /// <summary>
        /// 根据sRegionId更新指定仓库分区的温度
        /// </summary>
        /// <param name="sRegionId"></param>
        /// <param name="sRTemperature">最新的温度</param>
        /// <returns></returns>
        public bool UpdateSRTemperatureById(int sRegionId,decimal sRTemperature)
        {
            string sql = $"Update StoreRegionInfos Set SRTemperature = {sRTemperature}, TemperState = 1 Where SRegionId = {sRegionId}";
            return SqlHelper.ExecuteNonQuery(sql, 1) > 0;
        }

    }
}
