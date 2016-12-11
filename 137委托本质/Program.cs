using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _137委托本质
{
    public delegate void TestDelegate();
    class Program
    {
        //reflector查看IL代码
        static void Main(string[] args)
        {
            TestDelegate td = T1;
            td += T2;
            td();
            Console.ReadKey();
        }
        static void T1()
        {
            Console.WriteLine("T1");
        }
        static void T2()
        {
            Console.WriteLine("M2");
        }
    }
}
