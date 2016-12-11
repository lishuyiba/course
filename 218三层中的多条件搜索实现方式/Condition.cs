using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _218三层中的多条件搜索实现方式
{
    public class Condition
    {
        /// <summary>
        /// 书姓名或者数据库中的列名
        /// </summary>
        public string PropertyName
        {
            get;
            set;
        }

        /// <summary>
        /// 属性对应的值
        /// </summary>
        public object Value
        {
            get;
            set;
        }

        /// <summary>
        /// 描述当前属性与值的关系（Equal,NotEqual,GreaterThan,LessThan,Like）
        /// </summary>
        public Opt Operation
        {
            get;
            set;
        }

    }
    public enum Opt
    {
        Equal,
        NotEqual,
        GreaterThan,
        LessThan,
        Like
    }
}
