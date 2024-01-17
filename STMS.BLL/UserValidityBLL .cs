using STMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.BLL
{
    /// <summary>
    /// 处理用户登录
    /// </summary>
    public class UserValidityBLL
    {
        UserValidityDAL userValidityDAL = new UserValidityDAL();
        /// <summary>
        /// 给定用户名和密码返回是否存在
        /// </summary>
        /// <param name="uName">用户名</param>
        /// <param name="uPassword">用户密码</param>
        /// <returns>false or true</returns>
        public bool LoginSystem(string uName, string uPassword)
        {
            int userId= userValidityDAL.LoginSystem(uName, uPassword);
            if(userId == 0)  
                return false;
            else
                return true;
        }
    }
}
