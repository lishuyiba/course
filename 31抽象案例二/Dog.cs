using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31抽象案例二
{
    class Dog:Animal
    {
        public override void Eat()
        {
            Console.WriteLine("狗在啃骨头。。。");
        }
        public override void Bark()
        {
            Console.WriteLine("狗在汪汪叫。。。");
        }

    }
}
