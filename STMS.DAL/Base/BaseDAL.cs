using Common;
using STMS.DbUtility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.DAL.Base
{
    /// <summary>
    /// 增、删、改
    /// 继承了查询
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseDAL<T> : BQuery<T> where T : class //where约束泛型类型T必须为类
    {
        /// <summary>
        /// 添加实体信息
        /// </summary>
        /// <param name="t">数据库表对应的类的实例化对象</param>
        /// <param name="strCols">列名</param>
        /// <param name="isReturn">isReturn标识为1即在插入语句的后面增加了select @@identity,所以返回的是最后一条插入时自动产生的ID</param>
        /// <returns></returns>
        public int Add(T t, string strCols, int isReturn)
        {
            if (t == null)
                return 0;
            //根据t和列名数组获取SQL语句和参数列表
            SqlModel insert = CreateSql.GetInsertSqlAndParas(t, strCols, isReturn);
            //执行SQL语句
            if (isReturn == 0)
                //返回的是受影响的行数1  执行失败返回0
                return SqlHelper.ExecuteNonQuery(insert.Sql, 1, insert.SqlParaArray);
            else
            {
                object oID = SqlHelper.ExecuteScalar(insert.Sql, 1, insert.SqlParaArray);
                //ExecuteScalar()返回的是第一行第一列的值
                //isReturn标识为1即在插入语句的后面增加了select @@identity
                //所以返回的是最后一条插入时自动产生的ID
                if (oID != null && oID.ToString() != "")
                    return oID.GetIntOrZero();
                else
                    return 0;
            }
        }
        /// <summary>
        /// 批量插入
        /// </summary>
        /// <param name="list">实例化对象数组</param>
        /// <param name="strCols"></param>
        /// <returns>是否执行成功</returns>
        public bool AddList(List<T> list, string strCols)
        {
            if (list == null || list.Count == 0) return false;
            List<CommandInfo> comList = new List<CommandInfo>();
            foreach (T t in list)
            {
                SqlModel insert = CreateSql.GetInsertSqlAndParas<T>(t, strCols, 0);
                CommandInfo commandInfo = new CommandInfo(insert.Sql, insert.SqlParaArray, false);
                comList.Add(commandInfo);
            }
            return SqlHelper.ExecuteTrans(comList);
        }

        /// <summary>
        /// 修改数据(条件为空，则以主键为条件定位
        /// </summary>
        /// <param name="t"></param>
        /// <param name="strCols"></param>
        /// <returns></returns>
        public bool Update(T t, string strCols)
        {
            if (t == null)
                return false;
            else
                return Update(t, strCols, "");
        }

        /// <summary>
        /// 修改数据（以传入的条件来定位
        /// </summary>
        /// <param name="t"></param>
        /// <param name="strCols">要修改的列名</param>
        /// <param name="strWhere">条件</param>
        /// <param name="paras"></param>
        /// <returns>修改是否成功</returns>
        public bool Update(T t, string strCols, string strWhere, params SqlParameter[] paras)
        {
            if (t == null)
                return false;
            //生成SQL语句和参数列表
            SqlModel update = CreateSql.GetUpdataSqlAndParas(t, strCols, strWhere);
            //把update.SqlParaArray转为List<SqlParameter>方便插入参数SqlParameter[] paras
            List<SqlParameter> sqlParametersList = update.SqlParaArray.ToList<SqlParameter>();
            if (paras != null && paras.Length > 0)
                sqlParametersList.AddRange(paras);
            //执行SQL语句
            return SqlHelper.ExecuteNonQuery(update.Sql, 1, sqlParametersList.ToArray()) > 0;
        }

        /// <summary>
        /// 批量修改数据
        /// </summary>
        /// <param name="list"></param>
        /// <param name="strCols"></param>
        /// <returns>是否添加成功</returns>
        public bool UpdateList(List<T> list, string strCols)
        {
            if (list == null || list.Count == 0)
                return false;
            List<CommandInfo> commandInfos = new List<CommandInfo>();
            foreach (T t in list)
            {
                //生成Sql语句和参数列表
                SqlModel update = CreateSql.GetUpdataSqlAndParas(t, strCols, "");
                commandInfos.Add(new CommandInfo(update.Sql, update.SqlParaArray, false));
            }
            return SqlHelper.ExecuteTrans(commandInfos);
        }

        /// <summary>
        /// 根据Id删除  这里id是主键 delType：1 真删除  0 假删除
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="delType"></param>
        /// <param name="isDelete"></param>
        /// <returns></returns>
        /// isDeleted是直接用来设置数据库中IsDeleted字段的值
        /// 所以只有在delType=0时才有效(假删除)
        /// 当delType=1时IsDeleted是没有任何作用的
        public bool Delete(int id, int delType, int isDelete)
        {
            Type type = typeof(T);
            string strWhere = $"[{type.GetPrimary()}]=@Id";
            SqlParameter[] paras =
            {
                new SqlParameter("@Id",id)
            };
            return Delete(delType,strWhere,isDelete,paras);
        }

        /// <summary>
        /// 按条件strWhere删除数据
        /// </summary>
        /// <param name="actType">删除类型  假0  真1 </param>
        /// <param name="strWhere">删除条件</param>
        /// <param name="isDeleted">删除标识符 0  1  2  </param>
        /// <param name="paras">参数列表</param>
        /// <returns>是否删除成功</returns>
        /// isDeleted是直接用来设置数据库中IsDeleted字段的值
        /// 所以只有在delType=0时才有效(假删除)
        /// 当delType=1时IsDeleted是没有任何作用的
        public bool Delete(int actType, string strWhere, int isDeleted, SqlParameter[] paras)
        {
            string Sql = "";
            //根据删除类型生成SQL语句
            if (actType == 1)//真删除
                Sql = CreateSql.CreateDeleteSql<T>(strWhere);
            else
                Sql = CreateSql.CreateLogicDeleteSql<T>(strWhere, isDeleted);
            List<CommandInfo> list = new List<CommandInfo>();
            list.Add(new CommandInfo(){
                CommandText=Sql,
                IsProc=false,
                Paras=paras
            });
            //执行
            return SqlHelper.ExecuteTrans(list);
        }

        /// <summary>
        /// 批量删除
        /// 传入一个List,逐个删除List中给出的ID
        /// </summary>
        /// <param name="idList"></param>
        /// <param name="actType"></param>
        /// <param name="isDelete"></param>
        /// <returns></returns>
        /// isDeleted是直接用来设置数据库中IsDeleted字段的值
        /// 所以只有在delType=0时才有效(假删除)
        /// 当delType=1时IsDeleted是没有任何作用的
        public bool DeleteList(List<int> idList,int actType, int isDelete)
        {
            Type type = typeof(T);
            List<CommandInfo> commandInfos = new List<CommandInfo>();
            foreach (int id in idList)
            {
                string strWhere = $"[{type.GetPrimary()}]=@Id";
                string Sql = "";
                if(actType == 1)//真删除
                    Sql=CreateSql.CreateDeleteSql<T>(strWhere);
                else//逻辑删除
                    Sql=CreateSql.CreateLogicDeleteSql<T>(strWhere , isDelete);
                SqlParameter[] paras = { new SqlParameter("@Id", id) };
                commandInfos.Add(new CommandInfo()
                {
                    CommandText = Sql,
                    IsProc = false,
                    Paras = paras
                });
            }
            return SqlHelper.ExecuteTrans(commandInfos);
        }

    }
}
