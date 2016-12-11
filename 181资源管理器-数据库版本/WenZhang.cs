using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _181资源管理器_数据库版本
{
    public class WenZhang
    {
        public int WenZhangId
        {
            get;
            set;
        }
        public string WenZhangBiaoTi
        {
            get;
            set;
        }
        public override string ToString()
        {
            return WenZhangBiaoTi;
        }
    }
}
