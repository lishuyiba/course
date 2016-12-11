using ClsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caT1
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
            Console.WriteLine(System.DateTime.Now.ToString("当前时间：yyy-mm-dd-hh:mm:ss"));
        }
    }
}
