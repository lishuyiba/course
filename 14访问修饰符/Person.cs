using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14访问修饰符
{
    public class Person
    {
        //private私有访问修饰符，只能在当前类内部来访问。
        //private int age;

        //protected访问修饰符，只能在当前类内部，以及所有当前类的子类的内部来访问。
        //protected string name;

        //internal访问修饰符，表示只能在当前程序集内部来访问。
        //internal double score;

        //protected与internal没有可比性。
        //protected是在当前类内部与所有子类内部可访问，而internal是在同一个程序集中可访问。
        //假如不在同一个程序集中，但是依然存在继承关系inamprotected访问修饰符修饰类型依然可以访问。

        //protected internal访问修饰符，相当于同时具有protected的权限和internal的权限
        //protected internal double salary;

        //public访问修饰符在任何地方都可以访问。
        //public void Test()
        //{
        //    age = 100;
        //    name = "当前类的内部访问";
        //}
    }
}
