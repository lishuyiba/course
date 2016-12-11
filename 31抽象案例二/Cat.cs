using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31抽象案例二
{
    class Cat:Animal
    {

        public override void Eat()
        {
            Console.WriteLine("猫在吃鱼。。。");
        }

        public override void Bark()
        {
            Console.WriteLine("猫在喵喵叫。。。");
        }
    }
}
