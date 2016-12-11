using _14访问修饰符;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15internal访问修饰符
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            //p.score;//报错，因为跨程序集了，不能访问 internal double score;里面的score
        }
    }
}
