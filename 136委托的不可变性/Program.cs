using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _136委托的不可变性
{
    public delegate void MyDelegate();
    class Program
    {
        //委托具有类似于string一样的不可变性。
        //建议使用的时候尽量少定义自己的委托，使用系统中已经有的委托，减少程序集中定义的类型的个数。
        static void Main(string[] args)
        {
            MyDelegate md = M1;
            md += M2;
            md();
            Console.ReadKey();
        }
        static void M1()
        {
            Console.WriteLine("M1");
        }
        static void M2()
        {
            Console.WriteLine("M2");
        }
    }
}
