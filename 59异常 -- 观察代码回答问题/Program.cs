using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59异常____观察代码回答问题
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = GetNumber();
            Console.WriteLine(x);
            Console.ReadKey();
        }
        static int GetNumber()
        {
            try
            {
                int n1 = 10;
                int n2 = 0;
                int n3 = n1 / n2;
                return 100;
            }
            catch (Exception)
            {
                Console.WriteLine("*********异常了*******");
                return 1000;//此语句也会被执行
            }
            finally
            {
                Console.WriteLine("finally中的代码！！！");
            }
        }
    }
}
