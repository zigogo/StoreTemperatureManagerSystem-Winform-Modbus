using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.CustomArrtibutes
{
    //主键特性

    //标注这个特性是运用于类的--???
    [AttributeUsage(AttributeTargets.Class)]
    public class PrimaryKeyAttribute:Attribute
    {
        public string PrimaryKeyName { get; protected set; }
        //标记是否为自动增长(默认为否)
        public bool autoIncrement = false;
        public PrimaryKeyAttribute(string priName)
        {
            this.PrimaryKeyName = priName;
        }
    }
}
