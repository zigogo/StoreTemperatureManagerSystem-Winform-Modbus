using Common.CustomArrtibutes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class AttributeHelper
    {
        /// <summary>
        /// 获取映射表名
        /// 
        /// GetName(this Type type)，这里是没有参数的
        /// 具体使用方法是：用数据库表对应的类（取其Type类型）调用GetName()方法
        /// 方法的作用是用数据库表对应的类获取其映射的表名。数据库表对应的类都应
        /// 该加上[Table("实际表名")]这个特性。
        /// 通过type.GetCustomAttribute()这个方法获取type上所有
        /// 自定义特性（其中正常就会包括TableAttribute），然后过滤
        /// 掉其他不关注的特性，用TableAttribute.TableName就可以获取
        /// 到表名了
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>

        //函数的参数里加this就扩展方法，这里的this Type type就是
        //给Type这个类扩展一个叫GetName的函数
        public static string GetTName(this Type type)
        {
            string tableName = string.Empty;
            //获取指定类型的自定义特性
            //返回应用于此成员的所有自定义属性的数组
            object[] attrs = type.GetCustomAttributes(false);
            foreach (var attr in attrs)
            {
                if (attr is TableAttribute)
                {
                    //如果attr是TableAttribute就转化将其转化为TableAttribute
                    TableAttribute tableAttribute = attr as TableAttribute;
                    tableName = tableAttribute.TableName;
                }
            }
            //如果attrs中没有TableAttribute就说明数据库表对应的类的类名和
            //数据库表的表名是一样的，则type.Name就可以获取其表名。
            if (string.IsNullOrEmpty(tableName))
            {
                //type.Name就是这类的类名
                tableName = type.Name;
            }
            return tableName;
        }
        /// <summary>
        /// 获取映射列名
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public static string GetColName(this PropertyInfo property)
        //PropertyInfo是属性信息，由type.GetProperty()返回得到
        {
            string columnName = string.Empty;
            object[] attrs = property.GetCustomAttributes(false);
            foreach (var attr in attrs)
            {
                if(attr is ColumnAttribute)
                {
                    ColumnAttribute columnAttribute = attr as ColumnAttribute;
                    columnName = columnAttribute.ColumnName;
                }
            }
            if(string.IsNullOrEmpty(columnName))
            {
                columnName = property.Name;
            }
            return columnName;
        }
        /// <summary>
        /// 获取主键
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetPrimary(this Type type)
        {
            object[] attributes = type.GetCustomAttributes(false);
            foreach (var attr in attributes) 
            { 
                if(attr is PrimaryKeyAttribute)
                {
                    PrimaryKeyAttribute primaryKeyAttribute = attr as PrimaryKeyAttribute;
                    return primaryKeyAttribute.PrimaryKeyName;
                }
            }
            return string.Empty;
        }
        /// <summary>
        /// 判断是否为主键
        /// </summary>
        /// <param name="type"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public static bool IsPrimary(this Type type,PropertyInfo property)
        {
            //获取主键名
            string primaryKeyName = type.GetPrimary();
            //获取指定属性的映射列名
            string columnName = property.GetColName();
            //判断是否相等
            return (primaryKeyName == columnName);
        }
        /// <summary>
        /// 判断主键是否自增
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsIncrement(this Type type)
        {
            object[] attributes = type.GetCustomAttributes(false);
            foreach (var attr in attributes)
            {
                if (attr is PrimaryKeyAttribute)
                {
                    PrimaryKeyAttribute primaryKeyAttribute = attr as PrimaryKeyAttribute;
                    //PrimaryKeyAttribute中的autoIncrement字段标识是否自增
                    return primaryKeyAttribute.autoIncrement; 
                }
            }
            //如果不是主键肯定不自增
            return false;
        }
    }
}
