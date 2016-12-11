using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30抽象案例一
{
    class Program
    {
        static void Main(string[] args)
        {
            Person student = new Student();
            student.SayHello();
            Console.ReadKey();
        }
    }
}
