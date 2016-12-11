using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36new关键字用来隐藏父类方法
{
    class A
    {
        public void SayHi()
        {
            Console.WriteLine("A类中的SayHi方法。");
        }

        //后面加上的SayHello方法，就会提示跟子类的SayHello方法重名，提示要求在子类中添加new关键字隐藏父类中的SayHello方法。
        public void SayHello()
        {
            Console.WriteLine("A类中的SayHello方法。");
        }
    }
    class B : A
    {
        //public void SayHello()
        //{
        //    Console.WriteLine("B类中的SayHello方法。");
        //}

        public new void SayHello()
        {
            Console.WriteLine("B类中的SayHello方法。");
        }
    }
}
