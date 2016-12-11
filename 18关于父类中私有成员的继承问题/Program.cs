using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18关于父类中私有成员的继承问题
{
    //我观点：私有成员子类不能被继承。
    //原因1：虽然子类继承父类后，在创建子类对象的时候，父类中的那些私有成员也被分配了内存（子类中也有）。
    //原因2：但是，继承只是面向对象中的一个概念，目的是为了成员即便继承了，子类中也不能访问，所以在面向对象中，继承了但不能访问，没有意义。


    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dc = new DerivedClass();

            //只能访问到Show方法和SayHello方法。
            //dc.Show();
            //dc.SayHello();

            dc.Name = "aaaa";
            Console.WriteLine(dc.Name);

            Console.ReadKey();
        }
    }

    class BaseClass
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //private int age;
        private void SayHi()
        {
            Console.WriteLine("Hi....");
        }
        public void SayHello()
        {
            Console.WriteLine("Hello....");
        }
    }
    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            
        }

        public void Show()
        {
            Console.WriteLine("Show in DerivedClass.");
        }
    }
}
