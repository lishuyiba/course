using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57测试变量存储
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            double d = 9.9;
            Person p = new Person();
            p.Name = "yzk";
            Console.WriteLine("{0}-{1}-{2}",n,d,p.Name);
            Console.ReadKey();
        }
    }
    class Person
    {
        public string Name
        {
            get;
            set;
        }
    }
}
