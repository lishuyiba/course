using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _98什么是递归
{
    class Program
    {
        static void Main(string[] args)
        {
            //M1();

            Story();
            Console.ReadKey();
        }
        static int count = 0;
        /// <summary>
        /// 递归就是方法自己调用自己
        /// 如果递归的时候没有停止条件，则肯定会递归死。最后报异常，栈溢出。
        /// 所用一般递归的时候，都肯定会有一个终止条件
        /// 或者说是在某种条件下才会方法自己跳用自己（递归）
        /// </summary>
        static void Story()
        {
            count++;
            Console.WriteLine("从前有座山，");
            Console.WriteLine("山里有座庙，");
            Console.WriteLine("庙里有个老和尚和小和尚，");
            Console.WriteLine("有一天老和尚给小和尚讲故事，");
            Console.WriteLine("讲的是：");
            //Story();
            //停止条件
            if (count<100)
            {
                Story();
            }
        }

        private static void M1()
        {
            M2();
        }

        private static void M2()
        {
            M3();
        }

        private static void M3()
        {
            Console.WriteLine("呵呵，终于找到我了。。。");
        }
    }
}
