using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31抽象案例二
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            dog.Eat();
            dog.Bark();
            Console.ReadKey();
        }
    }
}
