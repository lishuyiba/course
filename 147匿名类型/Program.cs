using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _147匿名类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //没有Person类也能存储 属性            

            var yzk = new { Name = "yangzhongke", Age = 18, Email = "yzk@rupeng.com" };

            //匿名类型中的成员是只读的
            //yzk = "xiayzk";

            Console.WriteLine(yzk.Name);
            Console.WriteLine(yzk.Age);
            Console.WriteLine(yzk.Email);
            Console.ReadKey();


            //匿名类型
            var arrInt = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }
    }
}
