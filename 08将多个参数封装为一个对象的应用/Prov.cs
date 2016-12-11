using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08将多个参数封装为一个对象的应用
{
    public class Prov
    {
        public string ProvName
        {
            get;
            set;
        }
        public int ProvId
        {
            get;
            set;
        }
        public override string ToString()
        {
            return ProvName;
        }
    }
}
