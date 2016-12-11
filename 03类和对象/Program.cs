using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03类和对象
{
    class Program
    {

        //类和对象

        //概念：
        //类：类就是抽象的一个概念，它是对多个对象提取一些共性得到的一个类。
        //对象：对象是类的一个具体实例，类的一个具体实例化对象，在程序中要使用类的时候，得实例化一个对象来访问类中的成员。
        
        //关系：
        //类是怎么产生的，分析类的时候是通过对象分析出来的类，对象是类new出来的实例才能使用。

        //面向对象

        //特性：封装、继承、多态
        //封装：把变化的封装，保留了对用户统一的访问方式。
        //继承：增加代码重用，实现多态
        //多态：多态是在子类继承父类或者子类实现接口的时候，通过父类类型变量调用方法的时候可以最终调到具体子类的对象。

        //多态作用：可拓展、更灵活
        //实现多态的手段：继承（虚方法Virtual、抽象类方法abstract）、实现接口


        static void Main(string[] args)
        {
            //当泪的构造函的访问修饰符如果是private\protected等的时候，不能在类的外部访问，所以也就不能在类的外部通过new关键字来创建对象。
            
            //Student stu = new Student();//构造函数是public时，这样创建实例对象。

            //Student stu = Student.GetInStance();//构造函数是private时，这样创建实例对象。


            Teacher t = new Teacher("李树逸");
            Console.WriteLine(t.Name);
            Console.ReadKey();
        }
    }
}
