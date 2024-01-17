    using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.DbUtility
{
    public class SqlHelper
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        private static readonly string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        /// <summary>
        /// 增、删、改的通用方法
        /// 执行SQL语句或存储过程，返回受影响行数
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="cmdType">执行的脚本类型 1:sql语句  2:存储过程</param>
        /// <param name="parameters">参数数组</param>
        /// <returns>受影响行数</returns>
        public static int ExecuteNonQuery(string sql,int cmdType,params SqlParameter[] parameters)
        {
            int result = 0;//返回结果：受影响的行
            //using(){}可确保即使using语句块发生异常的情况下也会释放可释放实例
            using(SqlConnection conn = new SqlConnection(connStr))
            {
                //执行脚本的对象cmd
                SqlCommand cmd = BuilderCommand(conn,sql,cmdType,null,parameters);
                //执行T-SQL并返回受影响行数
                result = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            return result;
        }

        /// <summary>
        /// 执行SQL查询，返回第一行第一列的值
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="parameters"></param>
        /// <returns>第一行第一列</returns>
        public static object ExecuteScalar(string sql,int cmdType,params SqlParameter[] parameters)
        {
            object result = null;
            using( SqlConnection conn = new SqlConnection(connStr))
            {
                //执行脚本对象的cmd
                SqlCommand cmd = BuilderCommand(conn,sql,cmdType,null,parameters);
                result = cmd.ExecuteScalar();//执行T-SQL并返回第一行第一列的值
                cmd.Parameters.Clear();
                if (result==null||result==DBNull.Value)
                {
                    return null;
                }
                else
                {
                    return result;
                }
            }
        }
        /// <summary>
        /// 执行SQL语句，返回SqlDataReader对象
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="parameters"></param>
        /// <returns>SqlDataReader对象</returns>
        /// <exception cref="Exception"></exception>
        public static SqlDataReader ExecuteReader(string sql,int cmdType, params SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = BuilderCommand(conn,sql,cmdType,null,parameters);
            SqlDataReader reader;
            try
            {
                //if (conn.State == ConnectionState.Closed)
             //打开数据库连接要判断是否已经打开
             //打开已经打开的数据库会导致异常InvalidOperationException连接未关闭，连接的当前状态为打开
                    //conn.Open();
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch (Exception ex)
            {
                conn.Close();
                throw new Exception("创建SqlDataReader对象时发生异常",ex);
            }
        }

        /// <summary>
        /// 执行查询，查询结果填充到DataTable 只针对查询一个表的情况
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="parameters"></param>
        /// <returns>DataTable对象</returns>
        public static DataTable GetDataTable(string sql,int cmdType,params SqlParameter[] parameters)
        {
            DataTable dataTable= new DataTable();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = BuilderCommand(conn, sql, cmdType, null, parameters);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
                cmd.Parameters.Clear();
            }
            return dataTable;
        }

        /// <summary>
        /// 执行查询，数据填充到DataSet（多个结果集
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql,int cmdType,params SqlParameter[] parameters)
        {
            DataSet dataSet = new DataSet();
            using(SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = BuilderCommand(conn,sql,cmdType,null, parameters);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataSet);
                cmd.Parameters.Clear();

            }
            return dataSet;
        }

        /// <summary>
        /// 事务 批量执行SQL语句
        /// </summary>
        /// <param name="listSql">多条SQL语句</param>
        /// <returns>事务是否执行成功</returns>
        /// <exception cref="Exception"></exception>
        public static bool ExecuteTrans(List<string> listSql)
        {
            using(SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();//开启事务前务必打开数据库连接
                SqlTransaction sqlTransaction = conn.BeginTransaction();//开启事务
                SqlCommand cmd = BuilderCommand(conn,"", 1, sqlTransaction);
                try
                {
                    //遍历listSql，一条一条执行SQL
                    foreach (var sql in listSql)
                    {
                        if (sql != null)
                        {
                            cmd.CommandText = sql;
                            cmd.CommandType=CommandType.Text;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    sqlTransaction.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    sqlTransaction.Rollback();//回滚事务
                    throw new Exception("事务执行时发生异常(已回滚)",e);
                }
            }
        }

        /// <summary>
        /// 事务 批量执行CommandInfo
        /// CommandInfo类包括SQL、执行脚本类型、参数列表
        /// </summary>
        /// <param name="comList">CommandInfo对象数列</param>
        /// <returns>事务是否执行成功</returns>
        /// <exception cref="Exception"></exception>
        public static bool ExecuteTrans(List<CommandInfo> comList)
        {
            using( SqlConnection conn = new SqlConnection( connStr))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                SqlCommand cmd = BuilderCommand(conn, "", 1, sqlTransaction);
                try
                {
                    //遍历comList数组，一条一条根据CommandInfo对象执行
                    foreach (var commandInfo in comList)
                    {
                        
                        cmd.CommandText=commandInfo.CommandText;
                        if(commandInfo.IsProc)//是否是存储过程
                            cmd.CommandType= CommandType.StoredProcedure;
                        else
                            cmd.CommandType = CommandType.Text;

                        if (commandInfo.Paras != null && commandInfo.Paras.Length > 0)
                        {
                            //cmd.Parameters.Clear();
                            //cmd.Parameters.AddRange(commandInfo.Paras);
                            cmd.Parameters.Clear();
                            foreach (var p in commandInfo.Paras)
                            {
                                cmd.Parameters.Add(p);
                            }
                        }
                        cmd.ExecuteNonQuery();
                    }
                    sqlTransaction.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    sqlTransaction.Rollback();
                    throw new Exception("事务执行时发生异常(已回滚)",e); 
                }
            }
        }

        /// <summary>
        /// 委托：
        /// 连接数据库-获取执行脚本SqlCommand对象cmd-加入事务-...
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        public static T ExecuteTrans<T>(Func<IDbCommand,T> action)
        {
            using (SqlConnection conn =new SqlConnection(connStr))
            {
                conn.Open();
                IDbTransaction sqlTransaction = conn.BeginTransaction();
                //SqlTransaction sqlTransaction = conn.BeginTransaction();？？？
                IDbCommand cmd = conn.CreateCommand();
                //SqlCommand cmd = conn.CreateCommand();？？？
                cmd.Transaction = sqlTransaction;
                return action(cmd);
            }
        }

        /// <summary>
        /// 构建SqlCommand
        /// </summary>
        /// <param name="conn">数据库连接对象</param>
        /// <param name="sql">SQL语句或存储过程</param>
        /// <param name="cmdType">命令的类型：T-SQL or 存储过程</param>
        /// <param name="trans">事务</param>
        /// <param name="paras">参数数组</param>
        /// <returns>SqlCommand对象</returns>
        /// <exception cref="ArgumentNullException"></exception>
        private static SqlCommand BuilderCommand(SqlConnection conn, string sql, int cmdType, SqlTransaction trans, params SqlParameter[] paras)
        {
            if (conn == null) throw new ArgumentNullException("连接对象不能为空");
            //SqlCommand：表示要对一个SQL Server数据库执行一个Transact-SQL语句或存储过程
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            //cmdType：执行的脚本类型  1：SQL语句  2：存储过程
            if (cmdType == 2)
                sqlCommand.CommandType = CommandType.StoredProcedure;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            //SqlTransaction：事务
            if (trans != null)
                sqlCommand.Transaction = trans;
            if (paras!=null&&paras.Length>0)
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddRange(paras);
            }
            return sqlCommand;
        }
        /// <summary>
        /// 把sqlParameters添加到IDbCommand
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="sqlParameters"></param>
        public static void AddParameter(IDbCommand cmd, SqlParameter[] sqlParameters)
        {
            cmd.Parameters.Clear();
            if(sqlParameters != null && sqlParameters.Length > 0)
            {
                foreach (SqlParameter param in sqlParameters)
                {
                    cmd.Parameters.Add(param);
                }
            }
        }


    }
}
