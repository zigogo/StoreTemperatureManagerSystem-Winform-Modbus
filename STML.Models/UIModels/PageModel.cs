using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STML.Models.UIModels
{
    /// <summary>
    /// 分页模型
    /// </summary>
    public class PageModel<T>
    {
        public int TotalCount { get; set; }
        public List<T> ReList { get; set; }

    }
}
