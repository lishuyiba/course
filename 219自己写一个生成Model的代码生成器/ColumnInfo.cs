using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _219自己写一个生成Model的代码生成器
{
    public class ColumnInfo
    {
        public string ColumnName
        {
            get;
            set;
        }

        public string DataType
        {
            get;
            set;
        }

        public string IsNullable
        {
            get;
            set;
        }
    }
}
