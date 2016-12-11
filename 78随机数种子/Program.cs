using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _78随机数种子
{
    class Program
    {
        static void Main(string[] args)
        {
            //只要种子一样，产生的随机数都是一样的。

            Random r = new Random(100);
            int n = r.Next();
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
