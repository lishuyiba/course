using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _81CSharp中的关键字var
{
    class Program
    {
        static void Main(string[] args)
        {
            //var是一个“类型推断”，在程序编译的时候就已经替换成了对应的数据类型。
            //所以说var是一个强类型（在编译的时候已经确定数据类型了）而不是弱类型。
            var n = 10;//推断为 int类型
            n = n + 1;
            //n = "yzk";

            var s = "aaaaa";//已经推断为 string类型
            Console.WriteLine(n);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
