using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class StringHelper
    {
        /// <summary>
        /// 把字符串按照分隔符speator分割成List数组。
        /// toLower指示是否把分割后的字符串转为小写
        /// </summary>
        /// <param name="str">源字符串</param>
        /// <param name="speator">分隔符</param>
        /// <param name="toLower">是否转化为小写</param>
        /// <returns></returns>
        public static List<string> GetStrList(this string str, char speator, bool toLower)
        {
            List<string> list = new List<string>();
            string[] stringArray = str.Split(speator);
            //把string[]转换为List<stirng>
            foreach (var s in stringArray)
            {
                if (!string.IsNullOrEmpty(s))
                //if (string.IsNullOrEmpty(s)&& s!=speator.Tostring())  ??? 
                {
                    if (toLower)
                    {
                        list.Add(s.ToLower());
                    }
                    else
                    {
                        list.Add(s);
                    }

                }
            }
            return list;
        }
        /// <summary>
        /// 如果是数值则转为int，否则等于0
        /// </summary>
        /// <param name="oValue"></param>
        /// <returns></returns>
        public static int GetIntOrZero(this object oValue)
        {
            int reInt = 0;
            try
            {
                reInt = Convert.ToInt32(oValue);
            }
            catch
            {
                reInt = 0;
            }

            return reInt;
        }
        /// <summary>
        /// 如果是数值则转为Decimal，否则等于0
        /// </summary>
        /// <param name="oValue"></param>
        /// <returns></returns>
        public static decimal GetDecimalOrZero(this object oValue)
        {
            decimal reDecimal = 0;
            try
            {
                reDecimal = Convert.ToDecimal(oValue);
            }
            catch
            {
                reDecimal = 0;
            }

            return reDecimal;
        }
        /// <summary>
        /// 如果是数值则转为Decimal，否则等于0。如果是null则返回null
        /// </summary>
        /// <param name="oValue"></param>
        /// <returns></returns>
        public static decimal? GetDecimalOrNull(this object oValue)
        {
            decimal? reDecimal = null;
            if (oValue == null)
                return null;
            try
            {
                reDecimal = Convert.ToDecimal(oValue);
            }
            catch
            {
                reDecimal = 0;
            }
            return reDecimal;
        }
    }
}
