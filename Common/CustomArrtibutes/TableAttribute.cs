using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.CustomArrtibutes
{
    //获取表名特性

    //标注这个特性是运用于类的--???
    [AttributeUsage(AttributeTargets.Class)]
    public class TableAttribute:Attribute
    {
        public string TableName { get; protected set; }
        public TableAttribute(string tableName) 
        {
            this.TableName = tableName;
        }
    }
}
