using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.CustomArrtibutes;

namespace STMS.Models.DModels
{
    //用户信息实体

    //表名特性
    [Table("UserInfos")]
    //[TableAttribute("UserInfos")]

    //标识主键
    [PrimaryKey("UserId",autoIncrement=true)]
    public class UserInfo
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public string UserState { get; set; }
        public int IsDeleted { get; set; }
    }
}
