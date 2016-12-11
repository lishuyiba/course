using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _93装箱和拆箱性能问题
{
    class Program
    {
        static void Main(string[] args)
        {
            //用了1.6060229秒
            //ArrayList list = new ArrayList();
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //for (int i = 0; i < 10000000; i++)
            //{
                  //使用ArrayList集合，每次增加一个数字都会发生装箱操作。
            //    list.Add(i);
            //}
            //watch.Stop();
            //Console.WriteLine(watch.Elapsed);
            //Console.ReadKey();



            //用了0.1702217秒，使用泛型集合后，省去了装箱和拆箱操作，性能大大提升。
            //List<int> list = new List<int>();
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //for (int i = 0; i < 10000000; i++)
            //{
            //    list.Add(i);
            //}
            //watch.Stop();
            //Console.WriteLine(watch.Elapsed);
            //Console.ReadKey();
        }
    }
}
