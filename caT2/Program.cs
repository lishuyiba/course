using ClsLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.WriteTime = M1;
            c1.Dosth();
            Console.ReadKey();
        }
        static void M1()
        {
            File.WriteAllText(@"time.txt", System.DateTime.Now.ToString("当前时间：yyy-mm-dd-hh:mm:ss"));
            Console.WriteLine("时间成功写入文件中！");
        }
    }
}
