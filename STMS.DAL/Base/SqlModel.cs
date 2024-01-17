using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.DAL.Base
{

    /// <summary>
    /// 
    /// </summary>
    public class SqlModel
    {
        /// <summary>
        /// SQL语句
        /// </summary>
        public string Sql { get; set; }
        /// <summary>
        /// 参数数组
        /// </summary>
        public SqlParameter[] SqlParaArray { get; set; }

    }
}
