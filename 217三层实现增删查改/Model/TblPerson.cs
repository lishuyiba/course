using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _217三层实现增删查改.Model
{
    /// <summary>
    /// 操作TblPerson表的Model
    /// </summary>
    public class TblPerson
    {
        public int AutoId
        {
            get;
            set;
        }

        public string Uname
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public int? Height
        {
            get;
            set;
        }
        public bool? Gender
        {
            get;
            set;
        }
    }
}
