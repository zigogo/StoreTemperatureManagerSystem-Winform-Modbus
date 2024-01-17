using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class DbConvert
    {
        /// <summary>
        /// 将DataRow转化为T，并且按cols中存在的列进行筛选。
        /// 先实例化T为model，再根据DataRow里面的数据进行赋值，并且只赋值cols中存在的列名
        /// </summary>
        /// <typeparam name="T">数据库表对应的类</typeparam>
        /// <param name="dr">一行数据</param>
        /// <param name="cols">列名字符串</param>
        /// <returns>实例化对象model</returns>
        private static T DataRowToModel<T>(DataRow dr, string cols)
        {
            //利用反射创建T的实例化对象model
            T model = Activator.CreateInstance<T>();
            //Object model = Activator.CreateInstance(typeof(T)):两者差别在于返回值不同
            Type type = typeof(T);
            if (dr != null)
            {
                //根据列名字符串cols获取属性数组
                PropertyInfo[] propertyInfos = PropertyHelper.GetTypeProperties<T>(cols);
                //将dr的值赋值给对应的属性
                foreach (PropertyInfo property in propertyInfos)
                {
                    //获取属性的映射列名（以便在DataRow中索引
                    string colName = property.GetColName();
                    if (dr[colName] is DBNull)
                    {
                        property.SetValue(model, null);
                    }
                    else
                    {
                        SetPropertyValue<T>(model, dr[colName], property);
                    }
                }
            }
            return model;
        }
        /// <summary>
        /// 把DataTable转化为List
        /// </summary>
        /// <typeparam name="T">数据库表对应的类</typeparam>
        /// <param name="dt">表中的数据</param>
        /// <param name="cols">列名字符串</param>
        /// <returns></returns>
        public static List<T> DataTableToList<T>(DataTable dt, string cols)
        {
            List<T> list = new List<T>();
            if (dt.Rows.Count > 0)//行数大于0
            {
                foreach (DataRow dr in dt.Rows)
                {
                    //将每行转化为一个对象
                    T model = DataRowToModel<T>(dr, cols);
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 将SqlDataReader转化为T的实例化对象
        /// </summary>
        /// <typeparam name="T">数据库表对应的类</typeparam>
        /// <param name="reader"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public static T SqlDataReaderToModel<T>(SqlDataReader reader, string cols)
        {
            //创建T的实例化对象model
            T model = Activator.CreateInstance<T>();
            Type type = typeof(T);
            //获取列名字符串cols中类型T的属性
            PropertyInfo[] propertyInfos = PropertyHelper.GetTypeProperties<T>(cols);
            if (reader.Read())
            {
                foreach (PropertyInfo property in propertyInfos)
                {
                    string colName = property.GetColName();
                    if (reader[colName] is DBNull)
                    {
                        property.SetValue(model, null);
                    }
                    else
                    {
                        SetPropertyValue<T>(model, reader[colName], property);
                    }
                }
                return model;
            }
            else
            {
                return default(T);
            }

;
        }
        public static List<T> SqlDataReaderToList<T>(SqlDataReader reader, string cols)
        {
            List<T> list = new List<T>();

            Type type = typeof(T);
            PropertyInfo[] propertyInfos = PropertyHelper.GetTypeProperties<T>(cols);
            while (reader.Read())
            {
                T model = Activator.CreateInstance<T>();
                foreach (PropertyInfo property in propertyInfos)
                {
                    string colName = property.GetColName();
                    if (reader[colName] is DBNull)
                    {
                        property.SetValue(model, null);
                    }
                    else
                    {
                        SetPropertyValue<T>(model, reader[colName], property);
                    }
                }
                list.Add(model);
            }
            return list;
        }
        /// <summary>
        /// 给属性设置值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model">对象</param>
        /// <param name="value">值</param>
        /// <param name="property">属性</param>
        private static void SetPropertyValue<T>(T model, object value, PropertyInfo property)
        {
            //数据类型是泛型类型&&泛型类型定义是Nullable
            if (property.PropertyType.IsGenericType &&
                property.PropertyType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                //Type Nullable.GetUnderlyingType()：把Nullable<>转化为普通类
                //object Convert.ChangeType(Object object,Type type)：返回类型为type，值为boject的对象
                property.SetValue(model, Convert.ChangeType(value, Nullable.GetUnderlyingType(property.PropertyType)));
            }
            else
            {
                property.SetValue(model, value);
                //原本(有必要？)：property.SetValue(model,Convert.ChangeType(value,property.PropertyType));
            }
        }
    }
}
