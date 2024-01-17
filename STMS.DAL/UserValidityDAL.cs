using STMS.DAL.Base;
using STMS.Models.DModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.DAL
{
    /// <summary>
    /// 访问UserInfos表
    /// </summary>
    public class UserValidityDAL:BaseDAL<UserInfo>
    {
        /// <summary>
        /// 根据用户名和密码查询UserInfos表
        /// </summary>
        /// <param name="uName"></param>
        /// <param name="uPassword"></param>
        /// <returns>返回值为0即不存在该用户-密码</returns>
        public int LoginSystem(string uName,string uPassword)
        {
            //sql语句的条件
            string strWhere = "UserName=@userName and UserPwd=@userPwd and UserState=1 and IsDeleted=0";
            SqlParameter[] parameters =
            {
                new SqlParameter("@userName",uName),
                new SqlParameter("@userPwd",uPassword)
            };
            UserInfo userInfo = GetModel(strWhere, "UserId", parameters);
            
            if(userInfo!=null)
                return userInfo.UserId;
            else
                return 0;
        }
        
    }
}
