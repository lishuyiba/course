using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30抽象案例一
{
    class Student:Person
    {
        public override void SayHello()
        {
            Console.WriteLine("大家好，我是一名学生！");
        }

        public override void Standup()
        {
            Console.WriteLine("学生类 -- 早上好，请坐！");
        }
    }
}
