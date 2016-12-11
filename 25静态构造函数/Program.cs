using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25静态构造函数
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyStaticClass.Age = 10;
            //MyStaticClass.SayHi();

            
            T1();
            T2();
            T3();

            Console.WriteLine("=======OK=======");
            Console.ReadKey();
        }

        static void T1()
        { 
            
        }
        static void T2()
        {
            MyStaticClass.Name = "lsy";
        }
        static void T3()
        {
            MyStaticClass.SayHi();
        }
    }
}
