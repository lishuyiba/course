using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _179省市联动
{
    public class Area
    {

        //建议编写“实体类”的时候一定要用属性，不要用字段

        //因为有些空间数据绑定的时候只认属性，不认字段（大多数都是）

        //public int AreaId;
        //public string AreaName;

        public int AreaId
        {
            get;
            set;
        }
        public string AreaName
        {
            get;
            set;
        }
        public override string ToString()
        {
            return AreaName;
        }
    }
}
