using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36new关键字用来隐藏父类方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //结果是：父类中的SayHi方法。
            //Person cn = new Chinese();
            //cn.SayHi();

            //结果是：子类中的SayHi方法。
            //Chinese cn = new Chinese();
            //cn.SayHi();

            B b = new B();
            b.SayHi();
            b.SayHello();

            A a = new A();
            a.SayHi();
            a.SayHello();

            Console.ReadKey();
        }
    }
    class Person
    {
        public virtual void SayHi()
        {
            Console.WriteLine("父类中的SayHi方法。");
        }
    }
    class Chinese : Person
    {
        //方法重写
        //public override void SayHi()
        //{
        //    Console.WriteLine("子类中的SayHi方法。");
        //}

        //在子类中写了一个全新的方法SayHi，同时隐藏了从父类继承下来的SayHi方法。
        public new void SayHi()
        {
            Console.WriteLine("子类中的SayHi方法。");
        }
    }
}
