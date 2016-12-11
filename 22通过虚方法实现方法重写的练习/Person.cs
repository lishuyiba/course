using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22通过虚方法实现方法重写的练习
{
     class Person
    {
        public virtual void SayHello()
        {
            Console.WriteLine("我是学生。");
        }
    }

     class Student : Person
     {
         public override void SayHello()
         {
             base.SayHello();
         }
     }

     class Teacher:Person
    {
         public override void SayHello()
         {
             Console.WriteLine("我是老师。");
         }
    }

     class SiJi:Person
    {
         public override void SayHello()
         {
             Console.WriteLine("我是司机。");
         }
    }
}
