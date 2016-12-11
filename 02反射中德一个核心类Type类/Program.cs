using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _02反射中德一个核心类Type类
{
    class Program
    {
        //得到type以后就可以获取里面的成员
        static void Main(string[] args)
        {
            Person p = new Person();

            //获取Person类型的Type
            //1.通过对象调用GetType()方法。
            Type type = p.GetType();

            //2.通过typeof关键字。
            Type type1 = typeof(Person);

            //3.通过程序集对象GetType()方法。
            Assembly asm = Assembly.LoadFile(@"f:\TestLib.dll");
            Type typs = asm.GetType("命名空间.类型名");
        }
    }
    class Person
    {
        public string Name
        {
            get;
            set;
        }
    }
}
