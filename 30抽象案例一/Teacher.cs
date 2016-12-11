using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30抽象案例一
{
    class Teacher : Person
    {

        public override void SayHello()
        {
            Console.WriteLine("大家好，我是一名老师！");
        }

        public override void Standup()
        {
            Console.WriteLine("老师类 -- 早上好，请坐！");
        }
    }
}
