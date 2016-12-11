using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23静态成员静态类
{

    /// <summary>
    /// 只要类里面有可能会用到实例对象时，就不能把类声明成static静态类
    /// </summary>
    class Account
    {
        public int Id;
        public string Name;
        public double balance;
        public static double lilv=0.5;
    }
}
