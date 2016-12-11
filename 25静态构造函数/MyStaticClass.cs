using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25静态构造函数
{
    /// <summary>
    /// 一个静态类
    /// </summary>
    public static class MyStaticClass
    {
        //静态类的构造函数，只会在第一次使用静态类之前，执行，并且只会执行一次。
        //静态构造函数不能有访问修饰符，不能有参数。
        //静态构造函数
        static MyStaticClass()
        {
            Console.WriteLine("静态构造函数被调用了");
        }

        public static int Age;
        public static string Name;

        public static void SayHi()
        {
            Console.WriteLine("Hi.....");
        }
    }
}
