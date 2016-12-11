using clsLib2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.Test1(M1);
            Console.ReadKey();
        }
        static void M1()
        {
            Console.WriteLine("当前时间：{0}",DateTime.Now.ToString());
        }
    }
}
