using Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace STMS.DAL.Base
{
    /// <summary>
    /// 生成SQL语句的通用类
    /// </summary>
    public class CreateSql
    {
        /// <summary>
        /// 生成Insert语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t">实例化对象</param>
        /// <param name="cols"></param>
        /// <param name="isReturn">isReturn标识为1即在插入语句的后面增加了select @@identity,所以返回的是最后一条插入时自动产生的ID</param>
        /// <returns>SqlModel类的实例化对象</returns>
        public static SqlModel GetInsertSqlAndParas<T>(T t,string cols,int isReturn)
        {
            Type type = typeof(T);
            PropertyInfo[] properties = PropertyHelper.GetTypeProperties<T>(cols);//获取属性数组
            string PKName = type.GetPrimary();//获取主键名（因为主键一般是自动增长的，不需要显示插入）

            //insert into table (Id,Name,Age...) value (@Id,@Name,@Age)
            //生成要插入的列{1}   ([Id],[Name],[Age]...)
            string columns = string.Join(",", properties.Where(property => property.GetColName() != PKName).Select(property => $"[{property.GetColName()}]"));
            //生成要插入的参数{2}  (@Id,@Name,@Age)
            string paraColumns = string.Join(",", properties.Where(property => property.GetColName() != PKName).Select(property => $"@{property.GetColName()}"));
            //参数数组生成
            SqlParameter[] arrParas = CreateParameters<T>(properties, t);
            //拼接成SQL语句
            string Sql = $"INSERT INTO [{type.GetTName()}] ({columns}) VALUES ({paraColumns})";
            if (isReturn==1)
            {
                Sql += ";select @@identity";//insert语句后执行该语句可获取最后一条数据自增ID的值
            }
            return new SqlModel() { Sql=Sql,SqlParaArray = arrParas};
        }
        /// <summary>
        /// 生成Update语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="cols"></param>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public static SqlModel GetUpdataSqlAndParas<T>(T t,string cols,string strWhere)
        {
            Type type = typeof(T);
            //获取属性数组
            PropertyInfo[] properties = PropertyHelper.GetTypeProperties<T>(cols);
            string PKName = type.GetPrimary();
            //生成要更新的列 {1}  updata 表名 set coll=@col1,col2=@col2... where 条件
            string columns = string.Join(",",properties.Where(property=> property.Name!=PKName).Select(property =>$"[{property.GetColName()}]=@{property.GetColName()}"));
            SqlParameter[] arrParas = CreateParameters<T>(properties, t);
            if (string.IsNullOrEmpty(strWhere))
            {
                strWhere = $"{PKName}=@{PKName}";
            }
            //拼接sql语句
            string sql = $"UPDATE [{type.GetTName()}] SET {columns} WHERE {strWhere}";
            return new SqlModel() { Sql = sql, SqlParaArray = arrParas};
        }

        /// <summary>
        /// 生成Delete语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public static string CreateDeleteSql<T>(string strWhere)
        {
            Type type = typeof(T);
            string sql = $"DELETE FROM [{type.GetTName()}] WHERE ";
            if(!string .IsNullOrEmpty(strWhere))
            {
                sql += strWhere;
            }
            else
            {
                sql += "1=1";
            }
            return sql;
        }
        /// <summary>
        /// 生成假删除语句（把数据库表中的IsDeleted改为了1）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strWhere"></param>
        /// <param name="isDelete"></param>
        /// <returns></returns>
        public static string CreateLogicDeleteSql<T>(string strWhere,int isDelete)
        {
            Type type = typeof(T);
            string sql = $"Update [{type.GetTName()}] set IsDeleted={isDelete} WHERE 1=1";
            if(!string .IsNullOrEmpty(strWhere))
            {
                sql += " and "+strWhere;
            }
            return sql;
        }
        /// <summary>
        /// 生成查询语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strWhere"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public static string CreateSelectSql<T>(string strWhere,string cols)
        {
            Type type = typeof(T);
            if (string.IsNullOrEmpty(cols))//全部都查询
                cols = "*";
            if (string.IsNullOrEmpty(strWhere))//条件为空
                strWhere = "1=1";
            string sql = $"SELECT {cols} FROM [{type.GetTName()}] WHERE {strWhere}";
            return sql;
        }

        /// <summary>
        /// 生成带自编号的Select查询语句，用于分页查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strWhere">查询条件</param>
        /// <param name="cols">列名字符串</param>
        /// <returns>sql语句</returns>
        public static string CreateRowSelectSql<T>(string strWhere,string cols)
        {
            Type type = typeof(T);
            PropertyInfo[] properties = PropertyHelper.GetTypeProperties<T>(cols);

            //带自编号的Select查询语句，用于分页查询
            //row_number():为每一组的行按顺序生成一个惟一的序号
            //over:配合聚合函数(max、min、sum、avg、count等)或row_number等函数，
            //     可以在不改变原显示数据的情况下，新增一列作为聚合函数的计算值；
            //select row_number() over (order by{主键}asc) as Id,{1} from [表名] where 条件

            string colmns = string.Join(",", properties.Select(property => $"[{property.GetColName()}]"));
            string PKName = type.GetPrimary();
            if (string.IsNullOrEmpty(strWhere))
            {
                strWhere = " 1=1 ";
            }
            string sql = $"SELECT ROW_NUMBER() OVER ( ORDER BY {PKName} ASC ) AS Id, {colmns} FROM [{type.GetTName()}] WHERE {strWhere}";
            return sql;
        }
        /// <summary>
        /// 指定哪些列名不要，获取所有列名的字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="notHaveCols">不想要的字符串</param>
        /// <returns>所有字符串减去不想要的那些</returns>
        public static string GetColsString<T>(string notHaveCols)
        {
            //获取所有列名
            List<string> allColsName = typeof(T).GetProperties().Select(property => property.GetColName()).ToList();
            //需要去掉的列名
            List<string> notColsName = new List<string>();
            if (!string.IsNullOrEmpty(notHaveCols))
            {
                //把notHaveCols转成List<string>
                notColsName = notHaveCols.GetStrList(',', true);
                allColsName=allColsName.Where(column=>!notColsName.Contains(column.ToLower())).ToList();
            }
            string returnString = string.Join (",", allColsName);
            return returnString;
        }


        /// <summary>
        /// 生成参数数组
        /// </summary>
        /// <typeparam name="T">数据库表对应的类</typeparam>
        /// <param name="properties">属性数组</param>
        /// <param name="t">数据库表对应的类的实例化对象</param>
        /// <returns>参数数组</returns>
        private static SqlParameter[] CreateParameters<T>(PropertyInfo[] properties,T t)
        {
            SqlParameter[] sqlParameterArray = properties.Select(p => new SqlParameter("@" + p.GetColName(), p.GetValue(t) ?? DBNull.Value)).ToArray();
            return sqlParameterArray;
        }
    }
}
