using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class PropertyHelper
    {
        /// <summary>
        /// 返回指定类型的指定列名的属性数组。
        /// 类=》属性=》对应列名 和 传入的列名数组比较，其中和传入的列名数组不匹配的去掉，返回符合要求的属性数组
        /// </summary>
        /// <typeparam name="T">上述的指定类型(数据库表对应的类)</typeparam>
        /// <param name="cols">上述的指定列名(很多个列名)</param>
        /// <returns>返回符合要求的PropertyInfo[]</returns>
        public static PropertyInfo[] GetTypeProperties<T> (string cols)
        {
            //T是类型参数，在这里就是数据库表对应的类
            Type type = typeof (T);
            //将字符串cols按','分割成字符串数组，并转换为小写
            List<string> listCols =cols.GetStrList(',', true);//GetStrList()是扩展方法
            
            //获取T类型的所有属性
            PropertyInfo[] properties = type.GetProperties();
            if(listCols.Count > 0 && listCols != null)
            {
                //Where():筛选properties数组中的元素，传入Lambda表达式，
                // =>左边为properties中的元素，右边需要提供一个布尔类型来决定留下和去除
                //property.GetColName().ToLower()：按照属性获取对应的列名并将其转化为小写
                properties=properties.Where(property=>listCols.Contains(property.GetColName().ToLower())).ToArray();
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            return properties;
        }
    }
}
