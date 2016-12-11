using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54值类型和引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 值类型

            //int n = 10;
            //int m = n;
            //m = m + 1;
            //Console.WriteLine(m);
            //Console.WriteLine(n);
            //Console.ReadKey();

            #endregion

            #region 值类型与引用类型

            Person p = new Person();//开辟一块p的地址空间
            p.Name = "lsy";//在p的地址存放 “lsy”

            Person p1 = p;//p的地址指向了p1，所以p1也存放了“lsy”，所以输出“lsy”
            Console.WriteLine(p1.Name);

            p1.Name = "yzk";//因为p1指向的是p的地址，所以当p1修改为“yzk”时，也还是指向p的地址，所以p.name输出 “yzk”
            Console.WriteLine(p.Name);
            Console.ReadKey();

            #endregion
        }
    }

    class Person
    {
        public string Name
        {
            get;
            set;
        }
    }
}
