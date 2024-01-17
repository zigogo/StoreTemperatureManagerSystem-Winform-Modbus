using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.DbUtility
{
    public class CommandInfo
    {
        public string CommandText;//sql或存储过程名
        public SqlParameter[] Paras;//参数列表
        public bool IsProc;//是否是存储过程

        public CommandInfo() { }

        public CommandInfo(string commandText, bool isProc)
        {
            CommandText = commandText;
            IsProc = isProc;
        }

        public CommandInfo(string commandText, SqlParameter[] paras, bool isProc)
        {
            CommandText = commandText;
            Paras = paras;
            IsProc = isProc;
        }
    }
}
