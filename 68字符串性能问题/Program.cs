using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _68字符串性能问题
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Salary.txt",Encoding.Default);

            #region 使用string来拼接字符串（读取大数据的时候很耗时间）
            //string result = "";
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    result += lines[i];
            //} 
            //Console.WriteLine(result);
            //Console.ReadKey();
            #endregion

            #region StringBuilder拼接字符串

            //在进行大量字符串拼接的时候，string的问题：
            //1.内存浪费，产生大量的垃圾内存。
            //2.由于string的不可变性，每次拼接都会创建一个新的string对象，每次创建新对象的时候，本身也是比较耗时资源的。所以造成了使用string拼接字符串性能及其低下。

            //解决办法就是使用StringBuilder
            //除非是大量拼接字符串的时候使用StringBuilder，其他情况都是使用string ，因为各种方法要求的参数都是string类型，并且string类型具有一些特性：不可变性、字符串池。
            //最后通过StringBuilder拼接的字符串一般都会调用ToString（）再转换为String

            StringBuilder sb = new StringBuilder();

            Stopwatch watch = new Stopwatch();
            watch.Start();//启动计时器

            for (int i = 0; i < lines.Length; i++)
            {
                sb.Append(lines[i]);
            }

            watch.Stop();//停止计时器
            Console.WriteLine(watch.Elapsed);//输出程序读取数据所需的时间

            //sb.ToString();
            //Console.WriteLine();

            Console.WriteLine(sb);
            Console.ReadKey();
            #endregion

        }
    }
}
