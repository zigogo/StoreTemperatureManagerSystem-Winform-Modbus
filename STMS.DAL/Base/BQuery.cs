using Common;
using STML.Models.UIModels;
using STMS.DAL.Base;
using STMS.DbUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.DAL
{
    /// <summary>
    /// 查询通用类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BQuery<T>
    {
        /// <summary>
        /// 按条件查询返回实体信息
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="strCols">查询的列名</param>
        /// <param name="paras"></param>
        /// <returns>数据库表对应类的实例化对象</returns>
        public T GetModel(string strWhere,string strCols,params SqlParameter[] paras)
        {
            //生成SQL语句
            string sql = CreateSql.CreateSelectSql<T>(strWhere, strCols);
            //执行SQL语句，生成SqlDataReader对象
            SqlDataReader sqlDataReader = SqlHelper.ExecuteReader(sql,1,paras);
            //将SqlDataReader对象转为实体对象
            T t = DbConvert.SqlDataReaderToModel<T>(sqlDataReader, strCols);
            sqlDataReader.Close();
            return t;
        }

        /// <summary>
        /// 根据ID获取实体信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="strCols">需要查询的列名</param>
        /// <returns></returns>
        public T GetById(int id,string strCols)
        {  
            Type type = typeof(T);
            //查询条件
            string strWhere = $"[{type.GetPrimary()}]=@Id";
            //SQL语句的参数
            SqlParameter[] paras = { new SqlParameter("@Id", id) };
            return GetModel(strWhere,strCols,paras);
        }

        /// <summary>
        /// 根据条件判断是否存在
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public bool Exists(string strWhere,params SqlParameter[] paras) 
        {
            Type type = typeof(T);
            //生成SQL语句
            string sql = $"SELECT COUNT(1) FROM {type.GetTName()} WHERE {strWhere}";
            //执行SQL语句，返回的是第一行第一列的值
            object first = SqlHelper.ExecuteScalar(sql,1,paras);
            if(first.GetIntOrZero()>0) 
                return true;
            else
                return false;
        }

        /// <summary>
        /// 判断某个值是否存在
        /// </summary>
        /// <param name="sName">列名</param>
        /// <param name="vName">值</param>
        /// <returns></returns>
        public bool ExistsByName(string sName,string vName)
        {
             string strWhere=$"{sName}=@{sName} and IsDeleted=0";
            SqlParameter[] paras = {new SqlParameter($"@{sName}",vName) };
            return Exists(strWhere,paras);
        }

        /// <summary>
        /// 同一级别下，检查是否同名
        /// </summary>
        /// <param name="sName">列名</param>
        /// <param name="vName">值</param>
        /// <param name="sParent">父级Id列名</param>
        /// <param name="parId">父级Id</param>
        /// <returns></returns>
        public bool ExistsByName(string sName,string vName,string sParent,int parId)
        {
            string strWhere = $"{sName}=@{sName}";
            if (parId > 0)
                strWhere += $" and {sParent}=@{sParent}";
            strWhere += " and IsDeleted =0";
            SqlParameter[] paras =
            {
                new SqlParameter($"@{sName}",vName),
                new SqlParameter($"@{sParent}",parId)
            };
            return Exists(strWhere, paras);
        }

        /// <summary>
        /// 根据列名获取所有数据
        /// </summary>
        /// <param name="cols"></param>
        /// <param name="IsDeleted"></param>
        /// <returns></returns>
        public List<T> GetModelList(string cols,int IsDeleted)
        {
            return GetModelList($"IsDeleted={IsDeleted}", cols);
        }

        /// <summary>
        /// 按条件查询返回List（多条数据
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="strCols"></param>
        /// <param name="parameters"></param>
        /// <returns>List</returns>
        public List<T> GetModelList(string strWhere,string strCols,params SqlParameter[] parameters)
        {
            //生成SQL语句
            string sql = CreateSql.CreateSelectSql<T>(strWhere, strCols);
            //执行SQL语句，返回SqlDataReader对象
            SqlDataReader sqlDataReader = SqlHelper.ExecuteReader(sql, 1, parameters);
            //把SqlDataReader转为List<T>
            List<T> list=DbConvert.SqlDataReaderToList<T>(sqlDataReader, strCols);
            sqlDataReader.Close();
            return list;
        }

        /// <summary>
        /// 返回带行序号的列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="strCols"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public List<T> GetRowsModelList(string strWhere,string strCols,params SqlParameter[] parameters)
        {
            //生成SQL语句
            string sql = CreateSql.CreateSelectSql<T>(strWhere, strCols);
            //执行SQL语句，返回SqlDataReader对象
            SqlDataReader sqlDataReader = SqlHelper.ExecuteReader(sql,1,parameters);
            //把SqlDataReader转为List<T>
            List<T> list = DbConvert.SqlDataReaderToList<T>(sqlDataReader , strCols+",Id");
            return list;
        }

        /// <summary>
        /// 执行SQL语句，返回DataTable对象
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public DataTable GetDT(string sql,int cmdType,params SqlParameter[] parameters)
        {
            DataTable dataTable = SqlHelper.GetDataTable(sql, cmdType, parameters);
            return dataTable;
        }

        /// <summary>
        /// 执行SQL语句，返回DataSet对象
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public DataSet GetDS(string sql, int cmdType, params SqlParameter[] parameters)
        {
            DataSet dataSet = SqlHelper.GetDataSet(sql, cmdType, parameters);
            return dataSet;
        }

        //？？?
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="strCols"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public PageModel<T> GetPageList(string sql,string strCols,int startIndex,int pageSize)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@sql",sql),
                new SqlParameter("@startIndex",startIndex),
                new SqlParameter("@endIndex",startIndex+pageSize-1)
            };
            DataSet dataSet = GetDS("proc_Page", 2, sqlParameters);
            int total = (int)dataSet.Tables[0].Rows[0][0];
            List<T> list = DbConvert.DataTableToList<T>(dataSet.Tables[1], strCols);
            return new PageModel<T>() { TotalCount=total, ReList=list };
        }


    }
}
