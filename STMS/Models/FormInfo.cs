using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.Models
{
    /// <summary>
    /// From的信息：
    /// </summary>
    public class FormInfo
    {
        public FormInfo(int type,int PKId) 
        { 
            this.FromType = type;
            this.PrimaryKeyId = PKId;
        }
        /// <summary>
        /// 1：添加仓库信息   2：修改仓库信息  3：添加仓库分区  4：？
        /// </summary>
        public int FromType { get; set; }

        /// <summary>
        /// 主键编号:对哪一条数据进行操作
        /// </summary>
        public int PrimaryKeyId { get; set; }
    }
}
